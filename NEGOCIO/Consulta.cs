using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace historiasClinicas.NEGOCIO
{
    public class Consulta
    {
        // Atributos
        private int idConsulta;
        private int idHistoriaClinica;
        private Medico medico;
        private DateTime fechaConsulta;
        private string diagnostico;
        private string tratamiento; // puede venir vacío si la consulta no tuvo tratamiento asociado

        // Propiedades
        public int IdConsulta { get { return idConsulta; } set { idConsulta = value; } }
        public int IdHistoriaClinica { get { return idHistoriaClinica; } set { idHistoriaClinica = value; } }
        public Medico Medico { get { return medico; } set { medico = value; } }
        public DateTime FechaConsulta { get { return fechaConsulta; } set { fechaConsulta = value; } }
        public string Diagnostico { get { return diagnostico; } set { diagnostico = value; } }
        public string Tratamiento { get { return tratamiento; } set { tratamiento = value; } }

        // Constructor sin parámetros
        public Consulta() { }

        // Constructor con parámetros
        public Consulta(int idConsulta, int idHistoriaClinica, Medico medico,
                         DateTime fechaConsulta, string diagnostico, string tratamiento)
        {
            this.idConsulta = idConsulta;
            this.idHistoriaClinica = idHistoriaClinica;
            this.medico = medico;
            this.fechaConsulta = fechaConsulta;
            this.diagnostico = diagnostico;
            this.tratamiento = tratamiento;
        }

        // Método de control
        public bool TuvoTratamiento()
        {
            return !string.IsNullOrEmpty(tratamiento);
        }

        public override string ToString()
        {
            string nombreMedico = (medico != null) ? medico.ToString() : "Sin médico";
            return fechaConsulta.ToShortDateString() + " - " + nombreMedico + " - " + diagnostico;
        }
    }
}
