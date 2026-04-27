namespace ADIGGM.Tarjetas
{
    partial class frmCanjePremios
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
            this.txtCodigoQR = new System.Windows.Forms.TextBox();
            this.txtPuntosCanjear = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnCanjear = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
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
            // txtCodigoQR
            // 
            this.txtCodigoQR.Location = new System.Drawing.Point(25, 73);
            this.txtCodigoQR.Name = "txtCodigoQR";
            this.txtCodigoQR.Size = new System.Drawing.Size(100, 21);
            this.txtCodigoQR.TabIndex = 103;
            this.txtCodigoQR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoQR_KeyPress);
            // 
            // txtPuntosCanjear
            // 
            this.txtPuntosCanjear.Location = new System.Drawing.Point(161, 73);
            this.txtPuntosCanjear.Name = "txtPuntosCanjear";
            this.txtPuntosCanjear.Size = new System.Drawing.Size(100, 21);
            this.txtPuntosCanjear.TabIndex = 104;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(303, 73);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(100, 21);
            this.txtReferencia.TabIndex = 105;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(248, 249);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 41);
            this.btnConsultar.TabIndex = 106;
            this.btnConsultar.Text = "Consultar Puntos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnCanjear
            // 
            this.btnCanjear.Location = new System.Drawing.Point(333, 249);
            this.btnCanjear.Name = "btnCanjear";
            this.btnCanjear.Size = new System.Drawing.Size(75, 41);
            this.btnCanjear.TabIndex = 107;
            this.btnCanjear.Text = "Procesar Canje";
            this.btnCanjear.UseVisualStyleBackColor = true;
            this.btnCanjear.Click += new System.EventHandler(this.btnCanjear_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(27, 117);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(21, 19);
            this.lblMensaje.TabIndex = 108;
            this.lblMensaje.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 114;
            this.label3.Text = "Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 113;
            this.label2.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 112;
            this.label4.Text = "Código tarjeta";
            // 
            // frmCanjePremios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(428, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnCanjear);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.txtPuntosCanjear);
            this.Controls.Add(this.txtCodigoQR);
            this.Name = "frmCanjePremios";
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.txtCodigoQR, 0);
            this.Controls.SetChildIndex(this.txtPuntosCanjear, 0);
            this.Controls.SetChildIndex(this.txtReferencia, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnCanjear, 0);
            this.Controls.SetChildIndex(this.lblMensaje, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoQR;
        private System.Windows.Forms.TextBox txtPuntosCanjear;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnCanjear;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
