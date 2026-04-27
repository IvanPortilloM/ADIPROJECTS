namespace ADIGGM.FAC.Visores
{
    partial class FAC_VerReporte
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rvFAC = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(616, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(576, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(656, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(516, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 518);
            this.pnlFooter.Size = new System.Drawing.Size(696, 23);
            // 
            // rvFAC
            // 
            this.rvFAC.AutoScroll = true;
            this.rvFAC.AutoSize = true;
            this.rvFAC.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsViajes";
            reportDataSource1.Value = null;
            reportDataSource2.Name = "DsCta";
            reportDataSource2.Value = null;
            this.rvFAC.LocalReport.DataSources.Add(reportDataSource1);
            this.rvFAC.LocalReport.DataSources.Add(reportDataSource2);
            this.rvFAC.Location = new System.Drawing.Point(0, 35);
            this.rvFAC.Name = "rvFAC";
            this.rvFAC.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.rvFAC.ServerReport.BearerToken = null;
            this.rvFAC.Size = new System.Drawing.Size(696, 483);
            this.rvFAC.TabIndex = 106;
            this.rvFAC.Visible = false;
            // 
            // FAC_VerReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(696, 541);
            this.Controls.Add(this.rvFAC);
            this.Name = "FAC_VerReporte";
            this.Load += new System.EventHandler(this.FAC_VerReporte_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.rvFAC, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvFAC;
    }
}
