namespace ADIGGM.HE
{
    partial class frmHistorialSalarios
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
            this.cboMotoristas = new System.Windows.Forms.ComboBox();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpVigencia = new System.Windows.Forms.DateTimePicker();
            this.numSalario = new System.Windows.Forms.NumericUpDown();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(287, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(247, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(327, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(187, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 355);
            this.pnlFooter.Size = new System.Drawing.Size(367, 23);
            // 
            // cboMotoristas
            // 
            this.cboMotoristas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMotoristas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMotoristas.FormattingEnabled = true;
            this.cboMotoristas.Location = new System.Drawing.Point(12, 69);
            this.cboMotoristas.Name = "cboMotoristas";
            this.cboMotoristas.Size = new System.Drawing.Size(231, 24);
            this.cboMotoristas.TabIndex = 103;
            this.cboMotoristas.SelectedIndexChanged += new System.EventHandler(this.cboMotoristas_SelectedIndexChanged);
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(12, 145);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(345, 198);
            this.dgvHistorial.TabIndex = 105;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(261, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 36);
            this.btnGuardar.TabIndex = 106;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtpVigencia
            // 
            this.dtpVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVigencia.Location = new System.Drawing.Point(138, 99);
            this.dtpVigencia.Name = "dtpVigencia";
            this.dtpVigencia.Size = new System.Drawing.Size(105, 21);
            this.dtpVigencia.TabIndex = 107;
            // 
            // numSalario
            // 
            this.numSalario.Location = new System.Drawing.Point(12, 99);
            this.numSalario.Name = "numSalario";
            this.numSalario.Size = new System.Drawing.Size(120, 21);
            this.numSalario.TabIndex = 108;
            // 
            // frmHistorialSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(367, 378);
            this.Controls.Add(this.numSalario);
            this.Controls.Add(this.dtpVigencia);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.cboMotoristas);
            this.Name = "frmHistorialSalarios";
            this.Load += new System.EventHandler(this.frmHistorialSalarios_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.cboMotoristas, 0);
            this.Controls.SetChildIndex(this.dgvHistorial, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.dtpVigencia, 0);
            this.Controls.SetChildIndex(this.numSalario, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMotoristas;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpVigencia;
        private System.Windows.Forms.NumericUpDown numSalario;
    }
}
