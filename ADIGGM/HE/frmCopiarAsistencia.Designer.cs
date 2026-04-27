namespace ADIGGM.HE
{
    partial class frmCopiarAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCopiarAsistencia));
            this.dgvMotoristas = new System.Windows.Forms.DataGridView();
            this.calFechas = new System.Windows.Forms.MonthCalendar();
            this.btnAgregarFecha = new System.Windows.Forms.Button();
            this.lstFechas = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiarFechas = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(641, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(601, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(681, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(541, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 576);
            this.pnlFooter.Size = new System.Drawing.Size(721, 23);
            // 
            // dgvMotoristas
            // 
            this.dgvMotoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotoristas.Location = new System.Drawing.Point(12, 47);
            this.dgvMotoristas.Name = "dgvMotoristas";
            this.dgvMotoristas.Size = new System.Drawing.Size(455, 523);
            this.dgvMotoristas.TabIndex = 103;
            // 
            // calFechas
            // 
            this.calFechas.Location = new System.Drawing.Point(479, 46);
            this.calFechas.Name = "calFechas";
            this.calFechas.TabIndex = 104;
            // 
            // btnAgregarFecha
            // 
            this.btnAgregarFecha.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarFecha.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarFecha.Image")));
            this.btnAgregarFecha.Location = new System.Drawing.Point(488, 238);
            this.btnAgregarFecha.Name = "btnAgregarFecha";
            this.btnAgregarFecha.Size = new System.Drawing.Size(100, 80);
            this.btnAgregarFecha.TabIndex = 105;
            this.btnAgregarFecha.Text = "Agregar Fecha seleccionada";
            this.btnAgregarFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarFecha.UseVisualStyleBackColor = true;
            this.btnAgregarFecha.Click += new System.EventHandler(this.btnAgregarFecha_Click);
            // 
            // lstFechas
            // 
            this.lstFechas.FormattingEnabled = true;
            this.lstFechas.ItemHeight = 16;
            this.lstFechas.Location = new System.Drawing.Point(479, 334);
            this.lstFechas.Name = "lstFechas";
            this.lstFechas.Size = new System.Drawing.Size(227, 116);
            this.lstFechas.TabIndex = 106;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(488, 496);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(100, 60);
            this.btnAceptar.TabIndex = 107;
            this.btnAceptar.Text = "Copiar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(609, 496);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 60);
            this.btnCancelar.TabIndex = 108;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiarFechas
            // 
            this.btnLimpiarFechas.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpiarFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarFechas.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFechas.Image")));
            this.btnLimpiarFechas.Location = new System.Drawing.Point(606, 238);
            this.btnLimpiarFechas.Name = "btnLimpiarFechas";
            this.btnLimpiarFechas.Size = new System.Drawing.Size(100, 80);
            this.btnLimpiarFechas.TabIndex = 109;
            this.btnLimpiarFechas.Text = "Limpiar Fechas";
            this.btnLimpiarFechas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiarFechas.UseVisualStyleBackColor = true;
            this.btnLimpiarFechas.Click += new System.EventHandler(this.btnLimpiarFechas_Click);
            // 
            // frmCopiarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(721, 599);
            this.Controls.Add(this.btnLimpiarFechas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lstFechas);
            this.Controls.Add(this.btnAgregarFecha);
            this.Controls.Add(this.calFechas);
            this.Controls.Add(this.dgvMotoristas);
            this.Name = "frmCopiarAsistencia";
            this.Load += new System.EventHandler(this.frmCopiarAsistencia_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvMotoristas, 0);
            this.Controls.SetChildIndex(this.calFechas, 0);
            this.Controls.SetChildIndex(this.btnAgregarFecha, 0);
            this.Controls.SetChildIndex(this.lstFechas, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnLimpiarFechas, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMotoristas;
        private System.Windows.Forms.MonthCalendar calFechas;
        private System.Windows.Forms.Button btnAgregarFecha;
        private System.Windows.Forms.ListBox lstFechas;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiarFechas;
    }
}
