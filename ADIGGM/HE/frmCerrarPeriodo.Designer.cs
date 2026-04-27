namespace ADIGGM.HE
{
    partial class frmCerrarPeriodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCerrarPeriodo));
            this.dtpCierreInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpCierreFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarPeriodo = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(303, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(263, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(343, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(203, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 262);
            this.pnlFooter.Size = new System.Drawing.Size(383, 23);
            // 
            // dtpCierreInicio
            // 
            this.dtpCierreInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCierreInicio.Location = new System.Drawing.Point(151, 82);
            this.dtpCierreInicio.Name = "dtpCierreInicio";
            this.dtpCierreInicio.Size = new System.Drawing.Size(86, 21);
            this.dtpCierreInicio.TabIndex = 103;
            // 
            // dtpCierreFin
            // 
            this.dtpCierreFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCierreFin.Location = new System.Drawing.Point(151, 137);
            this.dtpCierreFin.Name = "dtpCierreFin";
            this.dtpCierreFin.Size = new System.Drawing.Size(86, 21);
            this.dtpCierreFin.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Cerrar registros de asistencia desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 106;
            this.label2.Text = "Hasta:";
            // 
            // btnCerrarPeriodo
            // 
            this.btnCerrarPeriodo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCerrarPeriodo.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCerrarPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPeriodo.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarPeriodo.Image")));
            this.btnCerrarPeriodo.Location = new System.Drawing.Point(147, 185);
            this.btnCerrarPeriodo.Name = "btnCerrarPeriodo";
            this.btnCerrarPeriodo.Size = new System.Drawing.Size(95, 60);
            this.btnCerrarPeriodo.TabIndex = 107;
            this.btnCerrarPeriodo.Text = "Cerrar Período";
            this.btnCerrarPeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCerrarPeriodo.UseVisualStyleBackColor = false;
            this.btnCerrarPeriodo.Click += new System.EventHandler(this.btnCerrarPeriodo_Click);
            // 
            // frmCerrarPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(383, 285);
            this.Controls.Add(this.btnCerrarPeriodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpCierreFin);
            this.Controls.Add(this.dtpCierreInicio);
            this.Name = "frmCerrarPeriodo";
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dtpCierreInicio, 0);
            this.Controls.SetChildIndex(this.dtpCierreFin, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnCerrarPeriodo, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpCierreInicio;
        private System.Windows.Forms.DateTimePicker dtpCierreFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarPeriodo;
    }
}
