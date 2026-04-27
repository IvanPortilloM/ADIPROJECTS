
namespace ADIGGM.PRESUPUESTO.Visores
{
    partial class frmReporteMaestro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteMaestro));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PR_R_ReporteMaestroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.pRDepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRctaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvPresMensual = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pRPresupuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRMaterialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRAniosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR_AniosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_AniosTableAdapter();
            this.pR_DepartamentosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter();
            this.pR_ctaCategoriaTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_ctaCategoriaTableAdapter();
            this.pR_CuentasTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_CuentasTableAdapter();
            this.pR_MaterialesTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_MaterialesTableAdapter();
            this.pR_PresupuestosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_PresupuestosTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPresupuesto = new System.Windows.Forms.ComboBox();
            this.lblPresupuesto = new System.Windows.Forms.Label();
            this.lblMateriales = new System.Windows.Forms.Label();
            this.cboMateriales = new System.Windows.Forms.ComboBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.pR_R_ReporteMaestroTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_R_ReporteMaestroTableAdapter();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.rvPresSemanal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cboTipoReporte = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PR_R_ReporteMaestroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRPresupuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMaterialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRCuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAniosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PR_R_ReporteMaestroBindingSource
            // 
            this.PR_R_ReporteMaestroBindingSource.DataMember = "PR_R_ReporteMaestro";
            this.PR_R_ReporteMaestroBindingSource.DataSource = this.dsPresupuesto;
            // 
            // dsPresupuesto
            // 
            this.dsPresupuesto.DataSetName = "DsPresupuesto";
            this.dsPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRDepartamentosBindingSource
            // 
            this.pRDepartamentosBindingSource.DataMember = "PR_Departamentos";
            this.pRDepartamentosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // pRctaCategoriaBindingSource
            // 
            this.pRctaCategoriaBindingSource.DataMember = "PR_ctaCategoria";
            this.pRctaCategoriaBindingSource.DataSource = this.dsPresupuesto;
            // 
            // rvPresMensual
            // 
            reportDataSource1.Name = "PR_R_ReporteMaestro";
            reportDataSource1.Value = this.PR_R_ReporteMaestroBindingSource;
            this.rvPresMensual.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPresMensual.LocalReport.ReportEmbeddedResource = "ADIGGM.PRESUPUESTO.Informes.rptPresupuestoMensual.rdlc";
            this.rvPresMensual.Location = new System.Drawing.Point(0, 99);
            this.rvPresMensual.Name = "rvPresMensual";
            this.rvPresMensual.ServerReport.BearerToken = null;
            this.rvPresMensual.Size = new System.Drawing.Size(363, 514);
            this.rvPresMensual.TabIndex = 84;
            // 
            // pRPresupuestosBindingSource
            // 
            this.pRPresupuestosBindingSource.DataMember = "PR_Presupuestos";
            this.pRPresupuestosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // pRMaterialesBindingSource
            // 
            this.pRMaterialesBindingSource.DataMember = "PR_Materiales";
            this.pRMaterialesBindingSource.DataSource = this.dsPresupuesto;
            // 
            // pRCuentasBindingSource
            // 
            this.pRCuentasBindingSource.DataMember = "PR_Cuentas";
            this.pRCuentasBindingSource.DataSource = this.dsPresupuesto;
            // 
            // pRAniosBindingSource
            // 
            this.pRAniosBindingSource.DataMember = "PR_Anios";
            this.pRAniosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // pR_AniosTableAdapter
            // 
            this.pR_AniosTableAdapter.ClearBeforeFill = true;
            // 
            // pR_DepartamentosTableAdapter
            // 
            this.pR_DepartamentosTableAdapter.ClearBeforeFill = true;
            // 
            // pR_ctaCategoriaTableAdapter
            // 
            this.pR_ctaCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // pR_CuentasTableAdapter
            // 
            this.pR_CuentasTableAdapter.ClearBeforeFill = true;
            // 
            // pR_MaterialesTableAdapter
            // 
            this.pR_MaterialesTableAdapter.ClearBeforeFill = true;
            // 
            // pR_PresupuestosTableAdapter
            // 
            this.pR_PresupuestosTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTipoReporte);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.cboPresupuesto);
            this.groupBox1.Controls.Add(this.lblPresupuesto);
            this.groupBox1.Controls.Add(this.lblMateriales);
            this.groupBox1.Controls.Add(this.cboMateriales);
            this.groupBox1.Controls.Add(this.lblCuenta);
            this.groupBox1.Controls.Add(this.cboCuenta);
            this.groupBox1.Controls.Add(this.cboAño);
            this.groupBox1.Controls.Add(this.lblAño);
            this.groupBox1.Controls.Add(this.cboDepartamento);
            this.groupBox1.Controls.Add(this.lblDepartamento);
            this.groupBox1.Controls.Add(this.lblCategoria);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1147, 99);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // cboPresupuesto
            // 
            this.cboPresupuesto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboPresupuesto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPresupuesto.DataSource = this.pRPresupuestosBindingSource;
            this.cboPresupuesto.DisplayMember = "NumVer";
            this.cboPresupuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPresupuesto.FormattingEnabled = true;
            this.cboPresupuesto.Location = new System.Drawing.Point(110, 72);
            this.cboPresupuesto.Margin = new System.Windows.Forms.Padding(2);
            this.cboPresupuesto.Name = "cboPresupuesto";
            this.cboPresupuesto.Size = new System.Drawing.Size(74, 21);
            this.cboPresupuesto.TabIndex = 90;
            this.cboPresupuesto.ValueMember = "idPresupuesto";
            // 
            // lblPresupuesto
            // 
            this.lblPresupuesto.AutoSize = true;
            this.lblPresupuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresupuesto.Location = new System.Drawing.Point(16, 74);
            this.lblPresupuesto.Name = "lblPresupuesto";
            this.lblPresupuesto.Size = new System.Drawing.Size(89, 16);
            this.lblPresupuesto.TabIndex = 91;
            this.lblPresupuesto.Text = "Presupuesto:";
            // 
            // lblMateriales
            // 
            this.lblMateriales.AutoSize = true;
            this.lblMateriales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateriales.Location = new System.Drawing.Point(646, 51);
            this.lblMateriales.Name = "lblMateriales";
            this.lblMateriales.Size = new System.Drawing.Size(81, 16);
            this.lblMateriales.TabIndex = 89;
            this.lblMateriales.Text = "Materiales:";
            // 
            // cboMateriales
            // 
            this.cboMateriales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboMateriales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMateriales.DataSource = this.pRMaterialesBindingSource;
            this.cboMateriales.DisplayMember = "Material";
            this.cboMateriales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMateriales.FormattingEnabled = true;
            this.cboMateriales.Location = new System.Drawing.Point(732, 49);
            this.cboMateriales.Margin = new System.Windows.Forms.Padding(2);
            this.cboMateriales.Name = "cboMateriales";
            this.cboMateriales.Size = new System.Drawing.Size(181, 21);
            this.cboMateriales.TabIndex = 88;
            this.cboMateriales.ValueMember = "idMaterial";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.Location = new System.Drawing.Point(668, 26);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(59, 16);
            this.lblCuenta.TabIndex = 87;
            this.lblCuenta.Text = "Cuenta:";
            // 
            // cboCuenta
            // 
            this.cboCuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboCuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCuenta.DataSource = this.pRCuentasBindingSource;
            this.cboCuenta.DisplayMember = "cuentaContable";
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(732, 24);
            this.cboCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(181, 21);
            this.cboCuenta.TabIndex = 86;
            this.cboCuenta.ValueMember = "idCuenta";
            // 
            // cboAño
            // 
            this.cboAño.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboAño.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAño.DataSource = this.pRAniosBindingSource;
            this.cboAño.DisplayMember = "Anio";
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(110, 47);
            this.cboAño.Margin = new System.Windows.Forms.Padding(2);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(74, 21);
            this.cboAño.TabIndex = 84;
            this.cboAño.ValueMember = "idAnio";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(67, 49);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(38, 16);
            this.lblAño.TabIndex = 85;
            this.lblAño.Text = "Año:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDepartamento.DataSource = this.pRDepartamentosBindingSource;
            this.cboDepartamento.DisplayMember = "Departamento";
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(385, 22);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(181, 21);
            this.cboDepartamento.TabIndex = 80;
            this.cboDepartamento.ValueMember = "idDepartamento";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(275, 24);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(105, 16);
            this.lblDepartamento.TabIndex = 81;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(302, 49);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 16);
            this.lblCategoria.TabIndex = 83;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCategoria.DataSource = this.pRctaCategoriaBindingSource;
            this.cboCategoria.DisplayMember = "Categoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(385, 47);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(181, 21);
            this.cboCategoria.TabIndex = 82;
            this.cboCategoria.ValueMember = "idCtaCategoria";
            // 
            // pR_R_ReporteMaestroTableAdapter
            // 
            this.pR_R_ReporteMaestroTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(1004, 24);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 53);
            this.btnActualizar.TabIndex = 92;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // rvPresSemanal
            // 
            reportDataSource2.Name = "PR_R_ReporteMaestro";
            reportDataSource2.Value = this.PR_R_ReporteMaestroBindingSource;
            this.rvPresSemanal.LocalReport.DataSources.Add(reportDataSource2);
            this.rvPresSemanal.LocalReport.ReportEmbeddedResource = "ADIGGM.PRESUPUESTO.Informes.rptPresupuestoSemanal.rdlc";
            this.rvPresSemanal.Location = new System.Drawing.Point(369, 105);
            this.rvPresSemanal.Name = "rvPresSemanal";
            this.rvPresSemanal.ServerReport.BearerToken = null;
            this.rvPresSemanal.Size = new System.Drawing.Size(325, 514);
            this.rvPresSemanal.TabIndex = 87;
            // 
            // cboTipoReporte
            // 
            this.cboTipoReporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTipoReporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoReporte.FormattingEnabled = true;
            this.cboTipoReporte.Items.AddRange(new object[] {
            "Reporte por Mes",
            "Reporte por Semana"});
            this.cboTipoReporte.Location = new System.Drawing.Point(19, 19);
            this.cboTipoReporte.Name = "cboTipoReporte";
            this.cboTipoReporte.Size = new System.Drawing.Size(165, 21);
            this.cboTipoReporte.TabIndex = 93;
            this.cboTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cboTipoReporte_SelectedIndexChanged);
            // 
            // frmReporteMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 698);
            this.Controls.Add(this.rvPresSemanal);
            this.Controls.Add(this.rvPresMensual);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReporteMaestro";
            this.Text = "frmReporteMaestro";
            this.Load += new System.EventHandler(this.frmReporteMaestro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PR_R_ReporteMaestroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRPresupuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMaterialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRCuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAniosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer rvPresMensual;
        private DataSets.DsPresupuesto dsPresupuesto;
        private System.Windows.Forms.BindingSource pRAniosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_AniosTableAdapter pR_AniosTableAdapter;
        private System.Windows.Forms.BindingSource pRDepartamentosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter pR_DepartamentosTableAdapter;
        private System.Windows.Forms.BindingSource pRctaCategoriaBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_ctaCategoriaTableAdapter pR_ctaCategoriaTableAdapter;
        private System.Windows.Forms.BindingSource pRCuentasBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_CuentasTableAdapter pR_CuentasTableAdapter;
        private System.Windows.Forms.BindingSource pRMaterialesBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_MaterialesTableAdapter pR_MaterialesTableAdapter;
        private System.Windows.Forms.BindingSource pRPresupuestosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_PresupuestosTableAdapter pR_PresupuestosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPresupuesto;
        private System.Windows.Forms.Label lblPresupuesto;
        private System.Windows.Forms.Label lblMateriales;
        private System.Windows.Forms.ComboBox cboMateriales;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.ComboBox cboCuenta;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.BindingSource PR_R_ReporteMaestroBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_R_ReporteMaestroTableAdapter pR_R_ReporteMaestroTableAdapter;
        public System.Windows.Forms.Button btnActualizar;
        private Microsoft.Reporting.WinForms.ReportViewer rvPresSemanal;
        private System.Windows.Forms.ComboBox cboTipoReporte;
    }
}