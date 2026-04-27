namespace ADIGGM.Tarjetas
{
    partial class frmSeguridad
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnReponer = new System.Windows.Forms.Button();
            this.btnBloquear = new System.Windows.Forms.Button();
            this.txtCodigoQR = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlAcciones = new System.Windows.Forms.Panel();
            this.txtNuevoQR = new System.Windows.Forms.TextBox();
            this.pnlFooter.SuspendLayout();
            this.pnlAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 220);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(121, 158);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 103;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnReponer
            // 
            this.btnReponer.Location = new System.Drawing.Point(22, 12);
            this.btnReponer.Name = "btnReponer";
            this.btnReponer.Size = new System.Drawing.Size(75, 23);
            this.btnReponer.TabIndex = 104;
            this.btnReponer.Text = "Reponer";
            this.btnReponer.UseVisualStyleBackColor = true;
            this.btnReponer.Click += new System.EventHandler(this.btnReponer_Click);
            // 
            // btnBloquear
            // 
            this.btnBloquear.Location = new System.Drawing.Point(119, 12);
            this.btnBloquear.Name = "btnBloquear";
            this.btnBloquear.Size = new System.Drawing.Size(75, 23);
            this.btnBloquear.TabIndex = 105;
            this.btnBloquear.Text = "Bloquear";
            this.btnBloquear.UseVisualStyleBackColor = true;
            this.btnBloquear.Click += new System.EventHandler(this.btnBloquear_Click);
            // 
            // txtCodigoQR
            // 
            this.txtCodigoQR.Location = new System.Drawing.Point(29, 68);
            this.txtCodigoQR.Name = "txtCodigoQR";
            this.txtCodigoQR.Size = new System.Drawing.Size(168, 21);
            this.txtCodigoQR.TabIndex = 106;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(36, 107);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(16, 16);
            this.lblInfo.TabIndex = 107;
            this.lblInfo.Text = "...";
            // 
            // pnlAcciones
            // 
            this.pnlAcciones.Controls.Add(this.btnBloquear);
            this.pnlAcciones.Controls.Add(this.btnReponer);
            this.pnlAcciones.Location = new System.Drawing.Point(202, 146);
            this.pnlAcciones.Name = "pnlAcciones";
            this.pnlAcciones.Size = new System.Drawing.Size(214, 48);
            this.pnlAcciones.TabIndex = 108;
            // 
            // txtNuevoQR
            // 
            this.txtNuevoQR.Location = new System.Drawing.Point(261, 68);
            this.txtNuevoQR.Name = "txtNuevoQR";
            this.txtNuevoQR.Size = new System.Drawing.Size(100, 21);
            this.txtNuevoQR.TabIndex = 109;
            // 
            // frmSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(428, 243);
            this.Controls.Add(this.txtNuevoQR);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.pnlAcciones);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtCodigoQR);
            this.Name = "frmSeguridad";
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.txtCodigoQR, 0);
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.pnlAcciones, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.txtNuevoQR, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlAcciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnReponer;
        private System.Windows.Forms.Button btnBloquear;
        private System.Windows.Forms.TextBox txtCodigoQR;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlAcciones;
        private System.Windows.Forms.TextBox txtNuevoQR;
    }
}
