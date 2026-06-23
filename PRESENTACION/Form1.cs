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
    public partial class Form1 : Form
    {
        HistoriasClinicasDao oDao;
        public Form1()
        {
            InitializeComponent();
            oDao = new HistoriasClinicasDao();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevo fn = new frmNuevo();
            fn.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
    
        {
            string filtroDni = txtInserteDNI.Text.Trim();

            if (!string.IsNullOrEmpty(filtroDni) && !int.TryParse(filtroDni, out _))
            {
                MessageBox.Show("El DNI debe contener solo números.", "Dato inválido",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvHistorias.Rows.Clear();
            dgvHistoriasClinicas.Rows.Clear();

            List<HistoriaClinica> historias = oDao.RecuperarHistoriasClinicas(filtroDni);

            foreach (HistoriaClinica hc in historias)
            {
                string nombreCompleto = hc.Paciente.Apellido + ", " + hc.Paciente.Nombre;

                int indiceFila = dgvHistorias.Rows.Add(
                    nombreCompleto,
                    hc.Paciente.Dni,
                    hc.Paciente.CalcularEdad(),
                    hc.GrupoSanguineo,
                    hc.Alergias,
                    hc.Paciente.Telefono,
                    hc.Paciente.Email
                );

                dgvHistorias.Rows[indiceFila].Tag = hc.IdHistoriaClinica;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "SALIR",
                MessageBoxButtons.YesNo,defaultButton:MessageBoxDefaultButton.Button2, icon:
                MessageBoxIcon.Question) == DialogResult.Yes)

                this.Close();            
        }

        private void btnConsultar2_Click(object sender, EventArgs e)
        {
            
            if (dgvHistorias.CurrentRow == null)
            {
                MessageBox.Show("Primero seleccioná un paciente de la lista.", "Sin selección",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idHistoriaClinica = (int)dgvHistorias.CurrentRow.Tag;

            dgvHistoriasClinicas.Rows.Clear();

            List<Consulta> consultas = oDao.RecuperarConsultasPorHistoria(idHistoriaClinica);

            if (consultas.Count == 0)
            {
                MessageBox.Show("Este paciente no tiene consultas registradas.", "Sin resultados",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (Consulta c in consultas)
            {
                string nombreMedico = c.Medico.Apellido + ", " + c.Medico.Nombre;

                dgvHistoriasClinicas.Rows.Add(
                    c.FechaConsulta.ToShortDateString(),
                    nombreMedico,
                    c.Diagnostico,
                    c.Tratamiento
                );
            }
        }

        private void btnDatosMedicos_Click(object sender, EventArgs e)
        {
          //frmHistoriaClinica frmHistoria = new frmHistoriaClinica();
          //  frmHistoria.ShowDialog();
        }
    }
}
