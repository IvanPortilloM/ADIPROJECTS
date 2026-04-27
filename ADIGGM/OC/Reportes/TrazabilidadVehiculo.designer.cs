namespace ADIGGM.OC.Reportes
{
    partial class TrazabilidadVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrazabilidadVehiculo));
            this.oCProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.tRVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tR_VehiculosTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.TR_VehiculosTableAdapter();
            this.oC_ProveedoresTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.oCProductosCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.oCProductosCategoriasOCProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdbFecConf = new System.Windows.Forms.RadioButton();
            this.rdbFecElab = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.cboVehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oC_ProductosCategoriasTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProductosCategoriasTableAdapter();
            this.oC_ProductosTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProductosTableAdapter();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer4 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasOCProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(179, 19);
            this.lblFooter.Text = "Trazabilidad Vehiculo";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(957, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(917, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(997, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(857, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 452);
            this.pnlFooter.Size = new System.Drawing.Size(1037, 23);
            // 
            // oCProveedoresBindingSource
            // 
            this.oCProveedoresBindingSource.DataMember = "OC_Proveedores";
            this.oCProveedoresBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRVehiculosBindingSource
            // 
            this.tRVehiculosBindingSource.DataMember = "TR_Vehiculos";
            this.tRVehiculosBindingSource.DataSource = this.dsOC;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.DocumentMapWidth = 20;
            this.reportViewer1.Location = new System.Drawing.Point(143, 157);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(2, 2);
            this.reportViewer1.TabIndex = 105;
            this.reportViewer1.Visible = false;
            // 
            // tR_VehiculosTableAdapter
            // 
            this.tR_VehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // oC_ProveedoresTableAdapter
            // 
            this.oC_ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.AutoSize = true;
            this.reportViewer2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer2.DocumentMapWidth = 32;
            this.reportViewer2.Location = new System.Drawing.Point(378, 157);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(2, 2);
            this.reportViewer2.TabIndex = 106;
            this.reportViewer2.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cboCategoria);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cboProducto);
            this.groupBox2.Controls.Add(this.rdbFecConf);
            this.groupBox2.Controls.Add(this.rdbFecElab);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboTipoReporte);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cboProveedor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpFechaHasta);
            this.groupBox2.Controls.Add(this.dtpFechaDesde);
            this.groupBox2.Controls.Add(this.btnVisualizar);
            this.groupBox2.Controls.Add(this.cboVehiculo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 134;
            this.label7.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCategoria.DataSource = this.oCProductosCategoriasBindingSource;
            this.cboCategoria.DisplayMember = "Categoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(642, 16);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(189, 24);
            this.cboCategoria.TabIndex = 133;
            this.cboCategoria.ValueMember = "IdCatProducto";
            // 
            // oCProductosCategoriasBindingSource
            // 
            this.oCProductosCategoriasBindingSource.DataMember = "OC_ProductosCategorias";
            this.oCProductosCategoriasBindingSource.DataSource = this.dsOC;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 132;
            this.label6.Text = "Producto:";
            // 
            // cboProducto
            // 
            this.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProducto.DataSource = this.oCProductosCategoriasOCProductosBindingSource;
            this.cboProducto.DisplayMember = "Producto";
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(642, 46);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(189, 24);
            this.cboProducto.TabIndex = 131;
            this.cboProducto.ValueMember = "IdProducto";
            // 
            // oCProductosCategoriasOCProductosBindingSource
            // 
            this.oCProductosCategoriasOCProductosBindingSource.DataMember = "OC_ProductosCategorias_OC_Productos";
            this.oCProductosCategoriasOCProductosBindingSource.DataSource = this.oCProductosCategoriasBindingSource;
            // 
            // rdbFecConf
            // 
            this.rdbFecConf.AutoSize = true;
            this.rdbFecConf.Location = new System.Drawing.Point(141, 22);
            this.rdbFecConf.Name = "rdbFecConf";
            this.rdbFecConf.Size = new System.Drawing.Size(146, 20);
            this.rdbFecConf.TabIndex = 130;
            this.rdbFecConf.Text = "Fecha Conf./Estimada";
            this.rdbFecConf.UseVisualStyleBackColor = true;
            this.rdbFecConf.CheckedChanged += new System.EventHandler(this.rdbFecConf_CheckedChanged);
            // 
            // rdbFecElab
            // 
            this.rdbFecElab.AutoSize = true;
            this.rdbFecElab.Checked = true;
            this.rdbFecElab.Location = new System.Drawing.Point(39, 20);
            this.rdbFecElab.Name = "rdbFecElab";
            this.rdbFecElab.Size = new System.Drawing.Size(89, 20);
            this.rdbFecElab.TabIndex = 129;
            this.rdbFecElab.TabStop = true;
            this.rdbFecElab.Text = "Fecha Elab.";
            this.rdbFecElab.UseVisualStyleBackColor = true;
            this.rdbFecElab.CheckedChanged += new System.EventHandler(this.rdbFecElab_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 128;
            this.label5.Text = "Tipo de Reporte:";
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTipoReporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoReporte.FormattingEnabled = true;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "General",
            "Trazabilidad de Combustible",
            "Facturas por Proveedor",
            "Requisiciones"});
            this.cboTipoReporte.Location = new System.Drawing.Point(375, 78);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(189, 24);
            this.cboTipoReporte.TabIndex = 127;
            this.cboTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cboTipoReporte_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 126;
            this.label4.Text = "Proveedor:";
            // 
            // cboProveedor
            // 
            this.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProveedor.DataSource = this.oCProveedoresBindingSource;
            this.cboProveedor.DisplayMember = "NombreProveedor";
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(375, 48);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(189, 24);
            this.cboProveedor.TabIndex = 125;
            this.cboProveedor.ValueMember = "IdProveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 124;
            this.label3.Text = "Vehiculo:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(100, 79);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(144, 21);
            this.dtpFechaHasta.TabIndex = 123;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(100, 48);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(144, 21);
            this.dtpFechaDesde.TabIndex = 122;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(848, 22);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(66, 60);
            this.btnVisualizar.TabIndex = 121;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboVehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVehiculo.DataSource = this.tRVehiculosBindingSource;
            this.cboVehiculo.DisplayMember = "Vehiculo";
            this.cboVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.Location = new System.Drawing.Point(375, 18);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(189, 24);
            this.cboVehiculo.TabIndex = 117;
            this.cboVehiculo.ValueMember = "IdVehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Desde:";
            // 
            // oC_ProductosCategoriasTableAdapter
            // 
            this.oC_ProductosCategoriasTableAdapter.ClearBeforeFill = true;
            // 
            // oC_ProductosTableAdapter
            // 
            this.oC_ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.AutoSize = true;
            this.reportViewer3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer3.DocumentMapWidth = 45;
            this.reportViewer3.Location = new System.Drawing.Point(620, 158);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(2, 2);
            this.reportViewer3.TabIndex = 107;
            this.reportViewer3.Visible = false;
            // 
            // reportViewer4
            // 
            this.reportViewer4.AutoSize = true;
            this.reportViewer4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer4.DocumentMapWidth = 20;
            this.reportViewer4.Location = new System.Drawing.Point(517, 156);
            this.reportViewer4.Name = "reportViewer4";
            this.reportViewer4.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer4.ServerReport.BearerToken = null;
            this.reportViewer4.Size = new System.Drawing.Size(2, 2);
            this.reportViewer4.TabIndex = 108;
            this.reportViewer4.Visible = false;
            // 
            // TrazabilidadVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1037, 475);
            this.Controls.Add(this.reportViewer4);
            this.Controls.Add(this.reportViewer3);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.groupBox2);
            this.Name = "TrazabilidadVehiculo";
            this.Text = "Trazabilidad Vehículo";
            this.Load += new System.EventHandler(this.TrazabilidadVehiculo_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            this.Controls.SetChildIndex(this.reportViewer2, 0);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.reportViewer3, 0);
            this.Controls.SetChildIndex(this.reportViewer4, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasOCProductosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.BindingSource tRVehiculosBindingSource;
        private DataSets.DsOCTableAdapters.TR_VehiculosTableAdapter tR_VehiculosTableAdapter;
        private System.Windows.Forms.BindingSource oCProveedoresBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter oC_ProveedoresTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbFecConf;
        private System.Windows.Forms.RadioButton rdbFecElab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTipoReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.ComboBox cboVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.BindingSource oCProductosCategoriasBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProductosCategoriasTableAdapter oC_ProductosCategoriasTableAdapter;
        private System.Windows.Forms.BindingSource oCProductosCategoriasOCProductosBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProductosTableAdapter oC_ProductosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer4;
    }
}
