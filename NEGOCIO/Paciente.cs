using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace historiasClinicas.NEGOCIO
    {
        public class Paciente
        {
        
       
                // Atributos
                private int idPaciente;
                private int numeroPaciente;
                private string nombre;
                private string apellido;
                private int dni;
                private DateTime fechaNacimiento;
                private string direccionPostal;
                private string telefono;
                private string email;

                // Propiedades
                public int IdPaciente { get { return idPaciente; } set { idPaciente = value; } }
                public int NumeroPaciente { get { return numeroPaciente; } set { numeroPaciente = value; } }
                public string Nombre { get { return nombre; } set { nombre = value; } }
                public string Apellido { get { return apellido; } set { apellido = value; } }
                public int Dni { get { return dni; } set { dni = value; } }
                public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
                public string DireccionPostal { get { return direccionPostal; } set { direccionPostal = value; } }
                public string Telefono { get { return telefono; } set { telefono = value; } }
                public string Email { get { return email; } set { email = value; } }

                // Constructor sin parámetros
                public Paciente() { }

                // Constructor con parámetros
                public Paciente(int idPaciente, int numeroPaciente, string nombre, string apellido,
                                 int dni, DateTime fechaNacimiento, string direccionPostal,
                                 string telefono, string email)
                {
                    this.idPaciente = idPaciente;
                    this.numeroPaciente = numeroPaciente;
                    this.nombre = nombre;
                    this.apellido = apellido;
                    this.dni = dni;
                    this.fechaNacimiento = fechaNacimiento;
                    this.direccionPostal = direccionPostal;
                    this.telefono = telefono;
                    this.email = email;
                }

                // Método de control (ejemplo simple, lo afinamos si querés validar formato)
                public bool EsValido()
                {
                    return dni > 0 && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido);
                }
        public int CalcularEdad()
        {
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad))
                edad--;
            return edad;
        }
        public override string ToString()
                {
                    return apellido + ", " + nombre + " (DNI: " + dni + ")";
                }
            }


        }

