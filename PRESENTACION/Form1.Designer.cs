namespace historiasClinicas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHistorias = new System.Windows.Forms.DataGridView();
            this.ColPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGrupoSanguineo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAlergias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblInserteDNI = new System.Windows.Forms.Label();
            this.txtInserteDNI = new System.Windows.Forms.TextBox();
            this.dgvHistoriasClinicas = new System.Windows.Forms.DataGridView();
            this.ColFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHistoriaClinica = new System.Windows.Forms.Label();
            this.btnConsultar2 = new System.Windows.Forms.Button();
            this.btnDatosMedicos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorias
            // 
            this.dgvHistorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPaciente,
            this.ColDni,
            this.ColEdad,
            this.ColGrupoSanguineo,
            this.ColAlergias,
            this.ColTelefono,
            this.ColEmail});
            this.dgvHistorias.Location = new System.Drawing.Point(33, 79);
            this.dgvHistorias.Name = "dgvHistorias";
            this.dgvHistorias.RowHeadersVisible = false;
            this.dgvHistorias.Size = new System.Drawing.Size(711, 109);
            this.dgvHistorias.TabIndex = 0;
            // 
            // ColPaciente
            // 
            this.ColPaciente.HeaderText = "Paciente";
            this.ColPaciente.Name = "ColPaciente";
            // 
            // ColDni
            // 
            this.ColDni.HeaderText = "DNI";
            this.ColDni.Name = "ColDni";
            this.ColDni.Width = 90;
            // 
            // ColEdad
            // 
            this.ColEdad.HeaderText = "Edad";
            this.ColEdad.Name = "ColEdad";
            this.ColEdad.Width = 50;
            // 
            // ColGrupoSanguineo
            // 
            this.ColGrupoSanguineo.HeaderText = "Grupo Sanguineo";
            this.ColGrupoSanguineo.Name = "ColGrupoSanguineo";
            this.ColGrupoSanguineo.Width = 65;
            // 
            // ColAlergias
            // 
            this.ColAlergias.HeaderText = "Alergias";
            this.ColAlergias.Name = "ColAlergias";
            // 
            // ColTelefono
            // 
            this.ColTelefono.HeaderText = "Telefono";
            this.ColTelefono.Name = "ColTelefono";
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Email";
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.Width = 200;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(645, 30);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(99, 32);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(645, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(33, 398);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 35);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblInserteDNI
            // 
            this.lblInserteDNI.AutoSize = true;
            this.lblInserteDNI.Location = new System.Drawing.Point(30, 40);
            this.lblInserteDNI.Name = "lblInserteDNI";
            this.lblInserteDNI.Size = new System.Drawing.Size(125, 13);
            this.lblInserteDNI.TabIndex = 4;
            this.lblInserteDNI.Text = "Inserte DNI del paciente:";
            // 
            // txtInserteDNI
            // 
            this.txtInserteDNI.Location = new System.Drawing.Point(175, 37);
            this.txtInserteDNI.Name = "txtInserteDNI";
            this.txtInserteDNI.Size = new System.Drawing.Size(149, 20);
            this.txtInserteDNI.TabIndex = 5;
            // 
            // dgvHistoriasClinicas
            // 
            this.dgvHistoriasClinicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriasClinicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFecha,
            this.ColMedico,
            this.ColDiagnostico,
            this.ColTratamiento});
            this.dgvHistoriasClinicas.Location = new System.Drawing.Point(33, 247);
            this.dgvHistoriasClinicas.Name = "dgvHistoriasClinicas";
            this.dgvHistoriasClinicas.RowHeadersVisible = false;
            this.dgvHistoriasClinicas.Size = new System.Drawing.Size(711, 136);
            this.dgvHistoriasClinicas.TabIndex = 6;
            // 
            // ColFecha
            // 
            this.ColFecha.HeaderText = "Fecha";
            this.ColFecha.Name = "ColFecha";
            this.ColFecha.Width = 70;
            // 
            // ColMedico
            // 
            this.ColMedico.HeaderText = "Medico";
            this.ColMedico.Name = "ColMedico";
            this.ColMedico.Width = 150;
            // 
            // ColDiagnostico
            // 
            this.ColDiagnostico.HeaderText = "Diagnostico";
            this.ColDiagnostico.Name = "ColDiagnostico";
            this.ColDiagnostico.Width = 250;
            // 
            // ColTratamiento
            // 
            this.ColTratamiento.HeaderText = "Tratamiento";
            this.ColTratamiento.Name = "ColTratamiento";
            this.ColTratamiento.Width = 250;
            // 
            // lblHistoriaClinica
            // 
            this.lblHistoriaClinica.AutoSize = true;
            this.lblHistoriaClinica.Location = new System.Drawing.Point(30, 213);
            this.lblHistoriaClinica.Name = "lblHistoriaClinica";
            this.lblHistoriaClinica.Size = new System.Drawing.Size(76, 13);
            this.lblHistoriaClinica.TabIndex = 7;
            this.lblHistoriaClinica.Text = "Historia Clinica";
            // 
            // btnConsultar2
            // 
            this.btnConsultar2.Location = new System.Drawing.Point(645, 194);
            this.btnConsultar2.Name = "btnConsultar2";
            this.btnConsultar2.Size = new System.Drawing.Size(99, 32);
            this.btnConsultar2.TabIndex = 8;
            this.btnConsultar2.Text = "Consultar";
            this.btnConsultar2.UseVisualStyleBackColor = true;
            this.btnConsultar2.Click += new System.EventHandler(this.btnConsultar2_Click);
            // 
            // btnDatosMedicos
            // 
            this.btnDatosMedicos.Location = new System.Drawing.Point(175, 398);
            this.btnDatosMedicos.Name = "btnDatosMedicos";
            this.btnDatosMedicos.Size = new System.Drawing.Size(99, 35);
            this.btnDatosMedicos.TabIndex = 9;
            this.btnDatosMedicos.Text = "Ficha Medica";
            this.btnDatosMedicos.UseVisualStyleBackColor = true;
            this.btnDatosMedicos.Click += new System.EventHandler(this.btnDatosMedicos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.Controls.Add(this.btnDatosMedicos);
            this.Controls.Add(this.btnConsultar2);
            this.Controls.Add(this.lblHistoriaClinica);
            this.Controls.Add(this.dgvHistoriasClinicas);
            this.Controls.Add(this.txtInserteDNI);
            this.Controls.Add(this.lblInserteDNI);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvHistorias);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorias;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblInserteDNI;
        private System.Windows.Forms.TextBox txtInserteDNI;
        private System.Windows.Forms.DataGridView dgvHistoriasClinicas;
        private System.Windows.Forms.Label lblHistoriaClinica;
        private System.Windows.Forms.Button btnConsultar2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGrupoSanguineo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAlergias;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTratamiento;
        private System.Windows.Forms.Button btnDatosMedicos;
    }
}

