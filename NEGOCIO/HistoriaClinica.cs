using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace historiasClinicas.NEGOCIO
    {
        public class HistoriaClinica
        {
            // Atributos
            private int idHistoriaClinica;
            private Paciente paciente;
            private DateTime fechaCreacion;
            private string grupoSanguineo;
            private string alergias;
            private string enfermedadesCronicas;
            private string antecedentesQuirurgicos;
            private string medicamentosHabituales;
            private string enfermedadesFamiliares;

            // Propiedades
            public int IdHistoriaClinica { get { return idHistoriaClinica; } set { idHistoriaClinica = value; } }
            public Paciente Paciente { get { return paciente; } set { paciente = value; } }
            public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = value; } }
            public string GrupoSanguineo { get { return grupoSanguineo; } set { grupoSanguineo = value; } }
            public string Alergias { get { return alergias; } set { alergias = value; } }
            public string EnfermedadesCronicas { get { return enfermedadesCronicas; } set { enfermedadesCronicas = value; } }
            public string AntecedentesQuirurgicos { get { return antecedentesQuirurgicos; } set { antecedentesQuirurgicos = value; } }
            public string MedicamentosHabituales { get { return medicamentosHabituales; } set { medicamentosHabituales = value; } }
            public string EnfermedadesFamiliares { get { return enfermedadesFamiliares; } set { enfermedadesFamiliares = value; } }

            // Constructor sin parámetros
            public HistoriaClinica() { }

            // Constructor con parámetros
            public HistoriaClinica(int idHistoriaClinica, Paciente paciente, DateTime fechaCreacion,
                                    string grupoSanguineo, string alergias, string enfermedadesCronicas,
                                    string antecedentesQuirurgicos, string medicamentosHabituales,
                                    string enfermedadesFamiliares)
            {
                this.idHistoriaClinica = idHistoriaClinica;
                this.paciente = paciente;
                this.fechaCreacion = fechaCreacion;
                this.grupoSanguineo = grupoSanguineo;
                this.alergias = alergias;
                this.enfermedadesCronicas = enfermedadesCronicas;
                this.antecedentesQuirurgicos = antecedentesQuirurgicos;
                this.medicamentosHabituales = medicamentosHabituales;
                this.enfermedadesFamiliares = enfermedadesFamiliares;
            }

            // Método de control
            public bool TieneAlergias()
            {
                return !string.IsNullOrEmpty(alergias);
            }

            public override string ToString()
            {
                string nombrePaciente = (paciente != null) ? paciente.ToString() : "Sin paciente";
                return "HC #" + idHistoriaClinica + " - " + nombrePaciente + " - " + fechaCreacion.ToShortDateString();
            }
        }
    }


