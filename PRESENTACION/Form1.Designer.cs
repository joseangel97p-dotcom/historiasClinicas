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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcionHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaConsulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblInserteDNI = new System.Windows.Forms.Label();
            this.txtInserteDNI = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPaciente,
            this.colMedico,
            this.colDescripcionHC,
            this.colDiagnostico,
            this.colTratamiento,
            this.colFechaConsulta});
            this.dataGridView1.Location = new System.Drawing.Point(91, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(614, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // colPaciente
            // 
            this.colPaciente.HeaderText = "Paciente";
            this.colPaciente.Name = "colPaciente";
            // 
            // colMedico
            // 
            this.colMedico.HeaderText = "Medico";
            this.colMedico.Name = "colMedico";
            // 
            // colDescripcionHC
            // 
            this.colDescripcionHC.HeaderText = "Historia Clinica";
            this.colDescripcionHC.Name = "colDescripcionHC";
            // 
            // colDiagnostico
            // 
            this.colDiagnostico.HeaderText = "Diagonstico";
            this.colDiagnostico.Name = "colDiagnostico";
            // 
            // colTratamiento
            // 
            this.colTratamiento.HeaderText = "Tratamiento";
            this.colTratamiento.Name = "colTratamiento";
            // 
            // colFechaConsulta
            // 
            this.colFechaConsulta.HeaderText = "Fecha Consulta";
            this.colFechaConsulta.Name = "colFechaConsulta";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(606, 130);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(99, 32);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(674, 403);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 403);
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
            this.lblInserteDNI.Location = new System.Drawing.Point(88, 140);
            this.lblInserteDNI.Name = "lblInserteDNI";
            this.lblInserteDNI.Size = new System.Drawing.Size(125, 13);
            this.lblInserteDNI.TabIndex = 4;
            this.lblInserteDNI.Text = "Inserte DNI del paciente:";
            // 
            // txtInserteDNI
            // 
            this.txtInserteDNI.Location = new System.Drawing.Point(219, 137);
            this.txtInserteDNI.Name = "txtInserteDNI";
            this.txtInserteDNI.Size = new System.Drawing.Size(149, 20);
            this.txtInserteDNI.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInserteDNI);
            this.Controls.Add(this.lblInserteDNI);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcionHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblInserteDNI;
        private System.Windows.Forms.TextBox txtInserteDNI;
    }
}

