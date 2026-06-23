using historiasClinicas.NEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;

namespace historiasClinicas.DATOS
{
    public class HistoriasClinicasDao
    {
        private AccesoDatos oBD = new AccesoDatos();

        public List<HistoriaClinica> RecuperarHistoriasClinicas(string filtroDni)
        {
            List<HistoriaClinica> lista = new List<HistoriaClinica>();

            string consultaSQL = "SELECT hc.id_historia_clinica, hc.fecha_creacion, hc.grupo_sanguineo, " +
                                  "hc.alergias, hc.enfermedades_cronicas, hc.antecedentes_quirurgicos, " +
                                  "hc.medicamentos_habituales, hc.enfermedades_familiares, " +
                                  "p.id_paciente, p.numero_paciente, p.nombre, p.apellido, p.dni, " +
                                  "p.fecha_nacimiento, p.direccion_postal, p.telefono, p.email " +
                                  "FROM HISTORIAS_CLINICAS hc " +
                                  "JOIN PACIENTES p ON hc.id_paciente = p.id_paciente";

            List<Parametro> parametros = new List<Parametro>();

            if (!string.IsNullOrEmpty(filtroDni))
            {
                consultaSQL += " WHERE p.dni = @dni";
                parametros.Add(new Parametro("@dni", int.Parse(filtroDni)));
            }

            DataTable tabla = parametros.Count > 0
                ? oBD.ConsultarBD(consultaSQL, parametros)
                : oBD.ConsultarBD(consultaSQL);

            //Mapeo
            foreach (DataRow fila in tabla.Rows)
            {
                Paciente oPaciente = new Paciente();
                oPaciente.IdPaciente = (int)fila["id_paciente"];
                oPaciente.NumeroPaciente = (int)fila["numero_paciente"];
                oPaciente.Nombre = (string)fila["nombre"];
                oPaciente.Apellido = (string)fila["apellido"];
                oPaciente.Dni = (int)fila["dni"];
                oPaciente.FechaNacimiento = (DateTime)fila["fecha_nacimiento"];
                oPaciente.DireccionPostal = fila["direccion_postal"] != DBNull.Value ? (string)fila["direccion_postal"] : "";
                oPaciente.Telefono = fila["telefono"] != DBNull.Value ? (string)fila["telefono"] : "";
                oPaciente.Email = fila["email"] != DBNull.Value ? (string)fila["email"] : "";

                HistoriaClinica oHistoria = new HistoriaClinica();
                oHistoria.IdHistoriaClinica = (int)fila["id_historia_clinica"];
                oHistoria.Paciente = oPaciente;
                oHistoria.FechaCreacion = (DateTime)fila["fecha_creacion"];
                oHistoria.GrupoSanguineo = fila["grupo_sanguineo"] != DBNull.Value ? (string)fila["grupo_sanguineo"] : "";
                oHistoria.Alergias = fila["alergias"] != DBNull.Value ? (string)fila["alergias"] : "";
                oHistoria.EnfermedadesCronicas = fila["enfermedades_cronicas"] != DBNull.Value ? (string)fila["enfermedades_cronicas"] : "";
                oHistoria.AntecedentesQuirurgicos = fila["antecedentes_quirurgicos"] != DBNull.Value ? (string)fila["antecedentes_quirurgicos"] : "";
                oHistoria.MedicamentosHabituales = fila["medicamentos_habituales"] != DBNull.Value ? (string)fila["medicamentos_habituales"] : "";
                oHistoria.EnfermedadesFamiliares = fila["enfermedades_familiares"] != DBNull.Value ? (string)fila["enfermedades_familiares"] : "";

                lista.Add(oHistoria);
            }

            return lista;


        }

        public List<Consulta> RecuperarConsultasPorHistoria(int idHistoriaClinica)
        {
            List<Consulta> lista = new List<Consulta>();

            string consultaSQL = "SELECT c.id_consulta, c.id_historia_clinica, c.fecha_consulta, c.diagnostico, " +
                                  "m.id_medico, m.nombre AS nombre_medico, m.apellido AS apellido_medico, " +
                                  "m.dni AS dni_medico, m.matricula, " +
                                  "t.descripcion AS tratamiento " +
                                  "FROM CONSULTAS c " +
                                  "JOIN MEDICOS m ON c.id_medico = m.id_medico " +
                                  "LEFT JOIN TRATAMIENTOS t ON t.id_consulta = c.id_consulta " +
                                  "WHERE c.id_historia_clinica = @idHistoria " +
                                  "ORDER BY c.fecha_consulta DESC";

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@idHistoria", idHistoriaClinica));

            DataTable tabla = oBD.ConsultarBD(consultaSQL, parametros);

            foreach (DataRow fila in tabla.Rows)
            {
                Medico oMedico = new Medico();
                oMedico.IdMedico = (int)fila["id_medico"];
                oMedico.Nombre = (string)fila["nombre_medico"];
                oMedico.Apellido = (string)fila["apellido_medico"];
                oMedico.Dni = (string)fila["dni_medico"];
                oMedico.Matricula = (string)fila["matricula"];

                Consulta oConsulta = new Consulta();
                oConsulta.IdConsulta = (int)fila["id_consulta"];
                oConsulta.IdHistoriaClinica = (int)fila["id_historia_clinica"];
                oConsulta.Medico = oMedico;
                oConsulta.FechaConsulta = (DateTime)fila["fecha_consulta"];
                oConsulta.Diagnostico = fila["diagnostico"] != DBNull.Value ? (string)fila["diagnostico"] : "";
                oConsulta.Tratamiento = fila["tratamiento"] != DBNull.Value ? (string)fila["tratamiento"] : "";

                lista.Add(oConsulta);
            }

            return lista;
        }

        // Calcula el próximo número de paciente disponible
        public int ObtenerSiguienteNumeroPaciente()
        {
            string consultaSQL = "SELECT ISNULL(MAX(numero_paciente), 0) + 1 AS siguiente FROM PACIENTES";

            DataTable tabla = oBD.ConsultarBD(consultaSQL);

            return (int)tabla.Rows[0]["siguiente"];
        }

        // Inserta un paciente nuevo y devuelve el id_paciente generado por la base
        public int CrearPaciente(Paciente oPaciente)
        {
            string consultaSQL = "INSERT INTO PACIENTES (numero_paciente, nombre, apellido, dni, " +
                                  "fecha_nacimiento, direccion_postal, telefono, email) " +
                                  "OUTPUT INSERTED.id_paciente " +
                                  "VALUES (@numeroPaciente, @nombre, @apellido, @dni, " +
                                  "@fechaNacimiento, @direccionPostal, @telefono, @email)";

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@numeroPaciente", oPaciente.NumeroPaciente));
            parametros.Add(new Parametro("@nombre", oPaciente.Nombre));
            parametros.Add(new Parametro("@apellido", oPaciente.Apellido));
            parametros.Add(new Parametro("@dni", oPaciente.Dni));
            parametros.Add(new Parametro("@fechaNacimiento", oPaciente.FechaNacimiento));
            parametros.Add(new Parametro("@direccionPostal", oPaciente.DireccionPostal));
            parametros.Add(new Parametro("@telefono", string.IsNullOrEmpty(oPaciente.Telefono) ? (object)DBNull.Value : oPaciente.Telefono));
            parametros.Add(new Parametro("@email", string.IsNullOrEmpty(oPaciente.Email) ? (object)DBNull.Value : oPaciente.Email));

            DataTable resultado = oBD.ConsultarBD(consultaSQL, parametros);

            return (int)resultado.Rows[0]["id_paciente"];
        }
    }
}