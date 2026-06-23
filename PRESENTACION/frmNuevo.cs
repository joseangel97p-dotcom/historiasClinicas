using historiasClinicas.DATOS;
using historiasClinicas.NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace historiasClinicas
{
    public partial class frmNuevo : Form
    {
        HistoriasClinicasDao oDao;
        public frmNuevo()
        {
            InitializeComponent();
            oDao = new HistoriasClinicasDao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar",
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                ) == DialogResult.Yes)
                
                    this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validaciones básicas antes de tocar la base
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido son obligatorios.", "Datos incompletos",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDni.Text.Trim(), out int dniIngresado))
            {
                MessageBox.Show("El DNI debe ser un número válido.", "Dato inválido",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDireccionPostal.Text))
            {
                MessageBox.Show("La dirección es obligatoria.", "Datos incompletos",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Armamos el objeto Paciente con lo que cargó el usuario
            Paciente oPaciente = new Paciente();
            oPaciente.NumeroPaciente = oDao.ObtenerSiguienteNumeroPaciente();
            oPaciente.Nombre = txtNombre.Text.Trim();
            oPaciente.Apellido = txtApellido.Text.Trim();
            oPaciente.Dni = dniIngresado;
            oPaciente.FechaNacimiento = dtpFechaNacimiento.Value;
            oPaciente.DireccionPostal = txtDireccionPostal.Text.Trim();
            oPaciente.Telefono = txtTelefono.Text.Trim();
            oPaciente.Email = txtEmail.Text.Trim();

            int idPacienteCreado = oDao.CrearPaciente(oPaciente);

            MessageBox.Show("Paciente creado correctamente.", "Éxito",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Próximo paso: abrir frmHistoriaClinica pasándole idPacienteCreado
            // frmHistoriaClinica fhc = new frmHistoriaClinica(idPacienteCreado);
            // fhc.ShowDialog();

            this.Close();
        }
    }
}
