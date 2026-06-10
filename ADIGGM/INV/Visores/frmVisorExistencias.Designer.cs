
namespace ADIGGM.INV.Visores
{
    partial class frmVisorExistencias
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.iNRExistenciasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IN_R_ProductosExistenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.chkSoloExistencias = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.chkCat = new System.Windows.Forms.CheckBox();
            this.cboVehiculos = new System.Windows.Forms.ComboBox();
            this.tRVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chkFiltroVeh = new System.Windows.Forms.CheckBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.chkFiltroProd = new System.Windows.Forms.CheckBox();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.oCProductosCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.oCProductosCategoriasOCProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvInv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rvExistencias = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNRExistenciasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_R_ProductosExistenciaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasOCProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(920, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(880, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(960, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(820, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 656);
            this.pnlFooter.Size = new System.Drawing.Size(1000, 23);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.chkSoloExistencias);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTipoReporte);
            this.groupBox1.Controls.Add(this.chkCat);
            this.groupBox1.Controls.Add(this.cboVehiculos);
            this.groupBox1.Controls.Add(this.chkFiltroVeh);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Controls.Add(this.chkFiltroProd);
            this.groupBox1.Controls.Add(this.cboCategorias);
            this.groupBox1.Controls.Add(this.cboProductos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 99);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha Desde:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(616, 40);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(95, 21);
            this.dtpFechaHasta.TabIndex = 11;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(616, 10);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(95, 21);
            this.dtpFechaDesde.TabIndex = 10;
            // 
            // chkSoloExistencias
            // 
            this.chkSoloExistencias.AutoSize = true;
            this.chkSoloExistencias.Checked = true;
            this.chkSoloExistencias.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoloExistencias.Location = new System.Drawing.Point(371, 13);
            this.chkSoloExistencias.Name = "chkSoloExistencias";
            this.chkSoloExistencias.Size = new System.Drawing.Size(150, 20);
            this.chkSoloExistencias.TabIndex = 9;
            this.chkSoloExistencias.Text = "Mostrar solo existencias";
            this.chkSoloExistencias.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo de reporte:";
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.FormattingEnabled = true;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "Reporte General",
            "Reporte de Existencias"});
            this.cboTipoReporte.Location = new System.Drawing.Point(151, 11);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(214, 24);
            this.cboTipoReporte.TabIndex = 7;
            this.cboTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cboTipoReporte_SelectedIndexChanged);
            // 
            // chkCat
            // 
            this.chkCat.AutoSize = true;
            this.chkCat.Location = new System.Drawing.Point(12, 43);
            this.chkCat.Name = "chkCat";
            this.chkCat.Size = new System.Drawing.Size(130, 20);
            this.chkCat.TabIndex = 6;
            this.chkCat.Text = "Filtrar por categoria";
            this.chkCat.UseVisualStyleBackColor = true;
            this.chkCat.CheckedChanged += new System.EventHandler(this.chkCat_CheckedChanged);
            // 
            // cboVehiculos
            // 
            this.cboVehiculos.DataSource = this.tRVehiculosBindingSource;
            this.cboVehiculos.DisplayMember = "Vehiculo";
            this.cboVehiculos.Enabled = false;
            this.cboVehiculos.FormattingEnabled = true;
            this.cboVehiculos.Location = new System.Drawing.Point(510, 69);
            this.cboVehiculos.Name = "cboVehiculos";
            this.cboVehiculos.Size = new System.Drawing.Size(154, 24);
            this.cboVehiculos.TabIndex = 5;
            this.cboVehiculos.ValueMember = "IdVehiculo";
            // 
            // chkFiltroVeh
            // 
            this.chkFiltroVeh.AutoSize = true;
            this.chkFiltroVeh.Location = new System.Drawing.Point(371, 71);
            this.chkFiltroVeh.Name = "chkFiltroVeh";
            this.chkFiltroVeh.Size = new System.Drawing.Size(124, 20);
            this.chkFiltroVeh.TabIndex = 4;
            this.chkFiltroVeh.Text = "Filtrar por vehiculo";
            this.chkFiltroVeh.UseVisualStyleBackColor = true;
            this.chkFiltroVeh.CheckedChanged += new System.EventHandler(this.chkFiltroVeh_CheckedChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(892, 9);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(102, 34);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar Reporte";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // chkFiltroProd
            // 
            this.chkFiltroProd.AutoSize = true;
            this.chkFiltroProd.Location = new System.Drawing.Point(12, 73);
            this.chkFiltroProd.Name = "chkFiltroProd";
            this.chkFiltroProd.Size = new System.Drawing.Size(132, 20);
            this.chkFiltroProd.TabIndex = 2;
            this.chkFiltroProd.Text = "Filtrar por productos";
            this.chkFiltroProd.UseVisualStyleBackColor = true;
            this.chkFiltroProd.CheckedChanged += new System.EventHandler(this.chkFiltroProd_CheckedChanged);
            // 
            // cboCategorias
            // 
            this.cboCategorias.DataSource = this.oCProductosCategoriasBindingSource;
            this.cboCategorias.DisplayMember = "Categoria";
            this.cboCategorias.Enabled = false;
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(151, 41);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(214, 24);
            this.cboCategorias.TabIndex = 1;
            this.cboCategorias.ValueMember = "IdCatProducto";
            // 
            // cboProductos
            // 
            this.cboProductos.DataSource = this.oCProductosCategoriasOCProductosBindingSource;
            this.cboProductos.DisplayMember = "Producto";
            this.cboProductos.Enabled = false;
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(151, 71);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(214, 24);
            this.cboProductos.TabIndex = 0;
            this.cboProductos.ValueMember = "IdProducto";
            // 
            // rvInv
            // 
            reportDataSource1.Name = "DsInv";
            reportDataSource1.Value = this.iNRExistenciasBindingSource;
            this.rvInv.LocalReport.DataSources.Add(reportDataSource1);
            this.rvInv.LocalReport.ReportEmbeddedResource = "ADIGGM.INV.Informes.rptExistencias.rdlc";
            this.rvInv.Location = new System.Drawing.Point(73, 234);
            this.rvInv.Name = "rvInv";
            this.rvInv.ServerReport.BearerToken = null;
            this.rvInv.Size = new System.Drawing.Size(324, 309);
            this.rvInv.TabIndex = 104;
            this.rvInv.Visible = false;
            // 
            // rvExistencias
            // 
            reportDataSource2.Name = "DsInv";
            reportDataSource2.Value = this.IN_R_ProductosExistenciaBindingSource;
            this.rvExistencias.LocalReport.DataSources.Add(reportDataSource2);
            this.rvExistencias.LocalReport.ReportEmbeddedResource = "ADIGGM.INV.Informes.rptProductosExistencia.rdlc";
            this.rvExistencias.Location = new System.Drawing.Point(487, 256);
            this.rvExistencias.Name = "rvExistencias";
            this.rvExistencias.ServerReport.BearerToken = null;
            this.rvExistencias.Size = new System.Drawing.Size(396, 246);
            this.rvExistencias.TabIndex = 105;
            this.rvExistencias.Visible = false;
            // 
            // frmVisorExistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1000, 679);
            this.Controls.Add(this.rvExistencias);
            this.Controls.Add(this.rvInv);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVisorExistencias";
            this.Text = "Visor de Existencias";
            this.Load += new System.EventHandler(this.frmVisorExistencias_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.rvInv, 0);
            this.Controls.SetChildIndex(this.rvExistencias, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iNRExistenciasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IN_R_ProductosExistenciaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasOCProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.BindingSource oCProductosCategoriasBindingSource;
        private System.Windows.Forms.BindingSource oCProductosCategoriasOCProductosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rvInv;
        private System.Windows.Forms.BindingSource iNRExistenciasBindingSource;
        private System.Windows.Forms.CheckBox chkFiltroProd;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ComboBox cboVehiculos;
        private System.Windows.Forms.CheckBox chkFiltroVeh;
        private System.Windows.Forms.BindingSource tRVehiculosBindingSource;
        private System.Windows.Forms.CheckBox chkCat;
        private System.Windows.Forms.CheckBox chkSoloExistencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rvExistencias;
        private System.Windows.Forms.BindingSource IN_R_ProductosExistenciaBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
    }
}
