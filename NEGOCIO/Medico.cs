using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace historiasClinicas.NEGOCIO
{
    public class Medico
    {
        // Atributos
        private int idMedico;
        private string nombre;
        private string apellido;
        private string dni;
        private string matricula;

        // Propiedades
        public int IdMedico { get { return idMedico; } set { idMedico = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Dni { get { return dni; } set { dni = value; } }
        public string Matricula { get { return matricula; } set { matricula = value; } }

        // Constructor sin parámetros
        public Medico() { }

        // Constructor con parámetros
        public Medico(int idMedico, string nombre, string apellido, string dni, string matricula)
        {
            this.idMedico = idMedico;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.matricula = matricula;
        }

        public override string ToString()
        {
            return "Dr/a. " + apellido + ", " + nombre;
        }
    }
}
