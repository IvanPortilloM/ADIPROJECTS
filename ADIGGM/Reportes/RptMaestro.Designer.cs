namespace ADIGGM.Reportes
{
    partial class RptMaestro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RptMaestro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PR_R_DetalleViajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.PR_R_DetalleCtaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PR_R_DetalleViajesRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PR_R_ResumenViajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRRDetalleViajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRRDetalleCtaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRRDetalleViajesRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRRResumenViajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cODSlcASMaestrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodeasAdiggm = new ADIGGM.DataSets.DsCodeasAdiggm();
            this.cODSlcEstadoCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFiltros = new System.Windows.Forms.Panel();
            this.ckbMarcarTpVeh = new System.Windows.Forms.CheckBox();
            this.dgvTipoVeh = new System.Windows.Forms.DataGridView();
            this.idTipoVehiculoD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagaISVDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activoDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.chkResumenCta = new System.Windows.Forms.CheckBox();
            this.ckbMarcarTodo = new System.Windows.Forms.CheckBox();
            this.cboRutas = new System.Windows.Forms.ComboBox();
            this.tRRutasFiltradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboVeh = new System.Windows.Forms.ComboBox();
            this.tRVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboContratistas = new System.Windows.Forms.ComboBox();
            this.tRContratistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboMotoristas = new System.Windows.Forms.ComboBox();
            this.tRMotoristasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.tRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvClaseTrab = new System.Windows.Forms.DataGridView();
            this.idClaseTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tRClaseTrabajosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboListaReportes = new System.Windows.Forms.ComboBox();
            this.tR_ClaseTrabajosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClaseTrabajosTableAdapter();
            this.tR_ClientesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter();
            this.tR_MotoristasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_MotoristasTableAdapter();
            this.tR_TipoVehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter();
            this.tR_ContratistasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ContratistasTableAdapter();
            this.tR_VehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_VehiculosTableAdapter();
            this.rvViajes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pR_R_DetalleViajesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.PR_R_DetalleViajesTableAdapter();
            this.tR_RutasFiltradasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_RutasFiltradasTableAdapter();
            this.pR_R_DetalleCtaTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.PR_R_DetalleCtaTableAdapter();
            this.rvViajesR = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pR_R_DetalleViajesRTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.PR_R_DetalleViajesRTableAdapter();
            this.rvResViajes = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pR_R_ResumenViajesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.PR_R_ResumenViajesTableAdapter();
            this.cOD_SlcASMaestrasTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.COD_SlcASMaestrasTableAdapter();
            this.cOD_SlcEstadoCuentaTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.COD_SlcEstadoCuentaTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PR_R_DetalleViajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PR_R_DetalleCtaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PR_R_DetalleViajesRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PR_R_ResumenViajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRRDetalleViajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRRDetalleCtaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRRDetalleViajesRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRRResumenViajesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcASMaestrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcEstadoCuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).BeginInit();
            this.pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVeh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRRutasFiltradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRContratistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRMotoristasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaseTrab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClaseTrabajosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(139, 19);
            this.lblFooter.Text = "Visor de Reportes";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(957, 0);
            this.btnMax.Visible = false;
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
            // PR_R_DetalleViajesBindingSource
            // 
            this.PR_R_DetalleViajesBindingSource.DataMember = "PR_R_DetalleViajes";
            this.PR_R_DetalleViajesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PR_R_DetalleCtaBindingSource
            // 
            this.PR_R_DetalleCtaBindingSource.DataMember = "PR_R_DetalleCta";
            this.PR_R_DetalleCtaBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // PR_R_DetalleViajesRBindingSource
            // 
            this.PR_R_DetalleViajesRBindingSource.DataMember = "PR_R_DetalleViajesR";
            this.PR_R_DetalleViajesRBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // PR_R_ResumenViajesBindingSource
            // 
            this.PR_R_ResumenViajesBindingSource.DataMember = "PR_R_ResumenViajes";
            this.PR_R_ResumenViajesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // pRRDetalleViajesBindingSource
            // 
            this.pRRDetalleViajesBindingSource.DataMember = "PR_R_DetalleViajes";
            this.pRRDetalleViajesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // pRRDetalleCtaBindingSource
            // 
            this.pRRDetalleCtaBindingSource.DataMember = "PR_R_DetalleCta";
            this.pRRDetalleCtaBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // pRRDetalleViajesRBindingSource
            // 
            this.pRRDetalleViajesRBindingSource.DataMember = "PR_R_DetalleViajesR";
            this.pRRDetalleViajesRBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // pRRResumenViajesBindingSource
            // 
            this.pRRResumenViajesBindingSource.DataMember = "PR_R_ResumenViajes";
            this.pRRResumenViajesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // cODSlcASMaestrasBindingSource
            // 
            this.cODSlcASMaestrasBindingSource.DataMember = "COD_SlcASMaestras";
            this.cODSlcASMaestrasBindingSource.DataSource = this.dsCodeasAdiggm;
            // 
            // dsCodeasAdiggm
            // 
            this.dsCodeasAdiggm.DataSetName = "DsCodeasAdiggm";
            this.dsCodeasAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cODSlcEstadoCuentaBindingSource
            // 
            this.cODSlcEstadoCuentaBindingSource.DataMember = "COD_SlcEstadoCuenta";
            this.cODSlcEstadoCuentaBindingSource.DataSource = this.dsCodeasAdiggm;
            // 
            // tRTipoVehiculosBindingSource
            // 
            this.tRTipoVehiculosBindingSource.DataMember = "TR_TipoVehiculos";
            this.tRTipoVehiculosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // pnlFiltros
            // 
            this.pnlFiltros.BackColor = System.Drawing.Color.Lavender;
            this.pnlFiltros.Controls.Add(this.ckbMarcarTpVeh);
            this.pnlFiltros.Controls.Add(this.dgvTipoVeh);
            this.pnlFiltros.Controls.Add(this.btnGenerar);
            this.pnlFiltros.Controls.Add(this.btnExport);
            this.pnlFiltros.Controls.Add(this.chkResumenCta);
            this.pnlFiltros.Controls.Add(this.ckbMarcarTodo);
            this.pnlFiltros.Controls.Add(this.cboRutas);
            this.pnlFiltros.Controls.Add(this.cboVeh);
            this.pnlFiltros.Controls.Add(this.cboContratistas);
            this.pnlFiltros.Controls.Add(this.cboMotoristas);
            this.pnlFiltros.Controls.Add(this.cboClientes);
            this.pnlFiltros.Controls.Add(this.dgvClaseTrab);
            this.pnlFiltros.Controls.Add(this.label3);
            this.pnlFiltros.Controls.Add(this.label2);
            this.pnlFiltros.Controls.Add(this.dtpHasta);
            this.pnlFiltros.Controls.Add(this.dtpDesde);
            this.pnlFiltros.Controls.Add(this.label1);
            this.pnlFiltros.Controls.Add(this.cboListaReportes);
            this.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltros.Location = new System.Drawing.Point(0, 35);
            this.pnlFiltros.Name = "pnlFiltros";
            this.pnlFiltros.Size = new System.Drawing.Size(1037, 141);
            this.pnlFiltros.TabIndex = 104;
            // 
            // ckbMarcarTpVeh
            // 
            this.ckbMarcarTpVeh.AutoSize = true;
            this.ckbMarcarTpVeh.Checked = true;
            this.ckbMarcarTpVeh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMarcarTpVeh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ckbMarcarTpVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMarcarTpVeh.Location = new System.Drawing.Point(553, 0);
            this.ckbMarcarTpVeh.Name = "ckbMarcarTpVeh";
            this.ckbMarcarTpVeh.Size = new System.Drawing.Size(93, 18);
            this.ckbMarcarTpVeh.TabIndex = 25;
            this.ckbMarcarTpVeh.Text = "Marcar Todo";
            this.ckbMarcarTpVeh.UseVisualStyleBackColor = true;
            this.ckbMarcarTpVeh.CheckedChanged += new System.EventHandler(this.ckbMarcarTpVeh_CheckedChanged);
            // 
            // dgvTipoVeh
            // 
            this.dgvTipoVeh.AllowUserToAddRows = false;
            this.dgvTipoVeh.AllowUserToDeleteRows = false;
            this.dgvTipoVeh.AutoGenerateColumns = false;
            this.dgvTipoVeh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoVeh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTipoVeh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTipoVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoVeh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoVehiculoD,
            this.TipoVehiculo,
            this.pagaISVDataGridViewCheckBoxColumn,
            this.activoDataGridViewCheckBoxColumn1,
            this.usuarioDataGridViewTextBoxColumn1,
            this.Seleccion});
            this.dgvTipoVeh.DataSource = this.tRTipoVehiculosBindingSource;
            this.dgvTipoVeh.Location = new System.Drawing.Point(463, 22);
            this.dgvTipoVeh.Name = "dgvTipoVeh";
            this.dgvTipoVeh.RowHeadersVisible = false;
            this.dgvTipoVeh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoVeh.ShowEditingIcon = false;
            this.dgvTipoVeh.Size = new System.Drawing.Size(193, 116);
            this.dgvTipoVeh.TabIndex = 24;
            // 
            // idTipoVehiculoD
            // 
            this.idTipoVehiculoD.DataPropertyName = "IdTipoVehiculo";
            this.idTipoVehiculoD.HeaderText = "IdTipoVehiculo";
            this.idTipoVehiculoD.Name = "idTipoVehiculoD";
            this.idTipoVehiculoD.ReadOnly = true;
            this.idTipoVehiculoD.Visible = false;
            // 
            // TipoVehiculo
            // 
            this.TipoVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoVehiculo.DataPropertyName = "TipoVehiculo";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.TipoVehiculo.DefaultCellStyle = dataGridViewCellStyle1;
            this.TipoVehiculo.HeaderText = "Tipo Vehiculo";
            this.TipoVehiculo.Name = "TipoVehiculo";
            this.TipoVehiculo.ReadOnly = true;
            // 
            // pagaISVDataGridViewCheckBoxColumn
            // 
            this.pagaISVDataGridViewCheckBoxColumn.DataPropertyName = "PagaISV";
            this.pagaISVDataGridViewCheckBoxColumn.HeaderText = "PagaISV";
            this.pagaISVDataGridViewCheckBoxColumn.Name = "pagaISVDataGridViewCheckBoxColumn";
            this.pagaISVDataGridViewCheckBoxColumn.Visible = false;
            // 
            // activoDataGridViewCheckBoxColumn1
            // 
            this.activoDataGridViewCheckBoxColumn1.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn1.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn1.Name = "activoDataGridViewCheckBoxColumn1";
            this.activoDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn1
            // 
            this.usuarioDataGridViewTextBoxColumn1.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.Name = "usuarioDataGridViewTextBoxColumn1";
            this.usuarioDataGridViewTextBoxColumn1.Visible = false;
            // 
            // Seleccion
            // 
            this.Seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Seleccion.HeaderText = "Selec.";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccion.Width = 64;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(871, 49);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(61, 62);
            this.btnGenerar.TabIndex = 19;
            this.btnGenerar.Text = "&Generar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(938, 49);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(69, 62);
            this.btnExport.TabIndex = 22;
            this.btnExport.Text = "&Exportar";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkResumenCta
            // 
            this.chkResumenCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkResumenCta.Location = new System.Drawing.Point(42, 94);
            this.chkResumenCta.Name = "chkResumenCta";
            this.chkResumenCta.Size = new System.Drawing.Size(127, 34);
            this.chkResumenCta.TabIndex = 23;
            this.chkResumenCta.Text = "Agregar Resumen por Cta. Contable";
            this.chkResumenCta.UseVisualStyleBackColor = true;
            this.chkResumenCta.Visible = false;
            // 
            // ckbMarcarTodo
            // 
            this.ckbMarcarTodo.AutoSize = true;
            this.ckbMarcarTodo.Checked = true;
            this.ckbMarcarTodo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMarcarTodo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ckbMarcarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMarcarTodo.Location = new System.Drawing.Point(354, 0);
            this.ckbMarcarTodo.Name = "ckbMarcarTodo";
            this.ckbMarcarTodo.Size = new System.Drawing.Size(93, 18);
            this.ckbMarcarTodo.TabIndex = 21;
            this.ckbMarcarTodo.Text = "Marcar Todo";
            this.ckbMarcarTodo.UseVisualStyleBackColor = true;
            this.ckbMarcarTodo.CheckedChanged += new System.EventHandler(this.ckbMarcarTodo_CheckedChanged);
            // 
            // cboRutas
            // 
            this.cboRutas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboRutas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRutas.DataSource = this.tRRutasFiltradasBindingSource;
            this.cboRutas.DisplayMember = "Ruta";
            this.cboRutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRutas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRutas.FormattingEnabled = true;
            this.cboRutas.Location = new System.Drawing.Point(848, 114);
            this.cboRutas.Name = "cboRutas";
            this.cboRutas.Size = new System.Drawing.Size(180, 21);
            this.cboRutas.TabIndex = 17;
            this.cboRutas.ValueMember = "IdRuta";
            // 
            // tRRutasFiltradasBindingSource
            // 
            this.tRRutasFiltradasBindingSource.DataMember = "TR_RutasFiltradas";
            this.tRRutasFiltradasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // cboVeh
            // 
            this.cboVeh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVeh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVeh.DataSource = this.tRVehiculosBindingSource;
            this.cboVeh.DisplayMember = "CodVehiculo";
            this.cboVeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVeh.FormattingEnabled = true;
            this.cboVeh.Location = new System.Drawing.Point(662, 114);
            this.cboVeh.Name = "cboVeh";
            this.cboVeh.Size = new System.Drawing.Size(180, 21);
            this.cboVeh.TabIndex = 15;
            this.cboVeh.ValueMember = "IdVehiculo";
            // 
            // tRVehiculosBindingSource
            // 
            this.tRVehiculosBindingSource.DataMember = "TR_Vehiculos";
            this.tRVehiculosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // cboContratistas
            // 
            this.cboContratistas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboContratistas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboContratistas.DataSource = this.tRContratistasBindingSource;
            this.cboContratistas.DisplayMember = "Contratista";
            this.cboContratistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContratistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboContratistas.FormattingEnabled = true;
            this.cboContratistas.Location = new System.Drawing.Point(663, 68);
            this.cboContratistas.Name = "cboContratistas";
            this.cboContratistas.Size = new System.Drawing.Size(180, 21);
            this.cboContratistas.TabIndex = 13;
            this.cboContratistas.ValueMember = "IdContratista";
            // 
            // tRContratistasBindingSource
            // 
            this.tRContratistasBindingSource.DataMember = "TR_Contratistas";
            this.tRContratistasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // cboMotoristas
            // 
            this.cboMotoristas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMotoristas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMotoristas.DataSource = this.tRMotoristasBindingSource;
            this.cboMotoristas.DisplayMember = "Motorista";
            this.cboMotoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotoristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMotoristas.FormattingEnabled = true;
            this.cboMotoristas.Location = new System.Drawing.Point(848, 22);
            this.cboMotoristas.Name = "cboMotoristas";
            this.cboMotoristas.Size = new System.Drawing.Size(180, 21);
            this.cboMotoristas.TabIndex = 9;
            this.cboMotoristas.ValueMember = "IdMotorista";
            // 
            // tRMotoristasBindingSource
            // 
            this.tRMotoristasBindingSource.DataMember = "TR_Motoristas";
            this.tRMotoristasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // cboClientes
            // 
            this.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClientes.DataSource = this.tRClientesBindingSource;
            this.cboClientes.DisplayMember = "Cliente";
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(662, 22);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(180, 21);
            this.cboClientes.TabIndex = 7;
            this.cboClientes.ValueMember = "IdCliente";
            // 
            // tRClientesBindingSource
            // 
            this.tRClientesBindingSource.DataMember = "TR_Clientes";
            this.tRClientesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dgvClaseTrab
            // 
            this.dgvClaseTrab.AllowUserToAddRows = false;
            this.dgvClaseTrab.AllowUserToDeleteRows = false;
            this.dgvClaseTrab.AutoGenerateColumns = false;
            this.dgvClaseTrab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClaseTrab.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvClaseTrab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvClaseTrab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClaseTrab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClaseTrabajo,
            this.claseTrabajoDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.Seleccionar});
            this.dgvClaseTrab.DataSource = this.tRClaseTrabajosBindingSource;
            this.dgvClaseTrab.Location = new System.Drawing.Point(214, 22);
            this.dgvClaseTrab.Name = "dgvClaseTrab";
            this.dgvClaseTrab.RowHeadersVisible = false;
            this.dgvClaseTrab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClaseTrab.ShowEditingIcon = false;
            this.dgvClaseTrab.Size = new System.Drawing.Size(243, 116);
            this.dgvClaseTrab.TabIndex = 6;
            // 
            // idClaseTrabajo
            // 
            this.idClaseTrabajo.DataPropertyName = "IdClaseTrabajo";
            this.idClaseTrabajo.HeaderText = "IdClaseTrabajo";
            this.idClaseTrabajo.Name = "idClaseTrabajo";
            this.idClaseTrabajo.ReadOnly = true;
            this.idClaseTrabajo.Visible = false;
            // 
            // claseTrabajoDataGridViewTextBoxColumn
            // 
            this.claseTrabajoDataGridViewTextBoxColumn.DataPropertyName = "ClaseTrabajo";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.claseTrabajoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.claseTrabajoDataGridViewTextBoxColumn.HeaderText = "ClaseTrabajo";
            this.claseTrabajoDataGridViewTextBoxColumn.Name = "claseTrabajoDataGridViewTextBoxColumn";
            this.claseTrabajoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Seleccionar.HeaderText = "Selec.";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Width = 45;
            // 
            // tRClaseTrabajosBindingSource
            // 
            this.tRClaseTrabajosBindingSource.DataMember = "TR_ClaseTrabajos";
            this.tRClaseTrabajosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(113, 65);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(95, 21);
            this.dtpHasta.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(12, 65);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(95, 21);
            this.dtpDesde.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Reportes";
            // 
            // cboListaReportes
            // 
            this.cboListaReportes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboListaReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboListaReportes.FormattingEnabled = true;
            this.cboListaReportes.Location = new System.Drawing.Point(12, 19);
            this.cboListaReportes.Name = "cboListaReportes";
            this.cboListaReportes.Size = new System.Drawing.Size(196, 21);
            this.cboListaReportes.TabIndex = 0;
            this.cboListaReportes.SelectedValueChanged += new System.EventHandler(this.CboListaReportes_SelectedValueChanged);
            // 
            // tR_ClaseTrabajosTableAdapter
            // 
            this.tR_ClaseTrabajosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ClientesTableAdapter
            // 
            this.tR_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tR_MotoristasTableAdapter
            // 
            this.tR_MotoristasTableAdapter.ClearBeforeFill = true;
            // 
            // tR_TipoVehiculosTableAdapter
            // 
            this.tR_TipoVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ContratistasTableAdapter
            // 
            this.tR_ContratistasTableAdapter.ClearBeforeFill = true;
            // 
            // tR_VehiculosTableAdapter
            // 
            this.tR_VehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // rvViajes
            // 
            this.rvViajes.AutoScroll = true;
            this.rvViajes.AutoSize = true;
            reportDataSource1.Name = "DsViajes";
            reportDataSource1.Value = this.PR_R_DetalleViajesBindingSource;
            reportDataSource2.Name = "DsCta";
            reportDataSource2.Value = this.PR_R_DetalleCtaBindingSource;
            this.rvViajes.LocalReport.DataSources.Add(reportDataSource1);
            this.rvViajes.LocalReport.DataSources.Add(reportDataSource2);
            this.rvViajes.LocalReport.ReportEmbeddedResource = "ADIGGM.Informes.rptViajes.rdlc";
            this.rvViajes.Location = new System.Drawing.Point(12, 215);
            this.rvViajes.Name = "rvViajes";
            this.rvViajes.ServerReport.BearerToken = null;
            this.rvViajes.Size = new System.Drawing.Size(323, 182);
            this.rvViajes.TabIndex = 105;
            this.rvViajes.Visible = false;
            // 
            // pR_R_DetalleViajesTableAdapter
            // 
            this.pR_R_DetalleViajesTableAdapter.ClearBeforeFill = true;
            // 
            // tR_RutasFiltradasTableAdapter
            // 
            this.tR_RutasFiltradasTableAdapter.ClearBeforeFill = true;
            // 
            // pR_R_DetalleCtaTableAdapter
            // 
            this.pR_R_DetalleCtaTableAdapter.ClearBeforeFill = true;
            // 
            // rvViajesR
            // 
            reportDataSource3.Name = "DsCta";
            reportDataSource3.Value = this.PR_R_DetalleCtaBindingSource;
            reportDataSource4.Name = "DsViajesR";
            reportDataSource4.Value = this.PR_R_DetalleViajesRBindingSource;
            this.rvViajesR.LocalReport.DataSources.Add(reportDataSource3);
            this.rvViajesR.LocalReport.DataSources.Add(reportDataSource4);
            this.rvViajesR.LocalReport.ReportEmbeddedResource = "ADIGGM.Informes.rptViajesR.rdlc";
            this.rvViajesR.Location = new System.Drawing.Point(341, 215);
            this.rvViajesR.Name = "rvViajesR";
            this.rvViajesR.ServerReport.BearerToken = null;
            this.rvViajesR.Size = new System.Drawing.Size(326, 182);
            this.rvViajesR.TabIndex = 106;
            this.rvViajesR.Visible = false;
            // 
            // pR_R_DetalleViajesRTableAdapter
            // 
            this.pR_R_DetalleViajesRTableAdapter.ClearBeforeFill = true;
            // 
            // rvResViajes
            // 
            this.rvResViajes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rvResViajes.AutoSize = true;
            reportDataSource5.Name = "DsViajes";
            reportDataSource5.Value = this.PR_R_ResumenViajesBindingSource;
            this.rvResViajes.LocalReport.DataSources.Add(reportDataSource5);
            this.rvResViajes.LocalReport.ReportEmbeddedResource = "ADIGGM.Informes.rptResViajes.rdlc";
            this.rvResViajes.Location = new System.Drawing.Point(673, 215);
            this.rvResViajes.Name = "rvResViajes";
            this.rvResViajes.ServerReport.BearerToken = null;
            this.rvResViajes.Size = new System.Drawing.Size(326, 182);
            this.rvResViajes.TabIndex = 107;
            this.rvResViajes.Visible = false;
            // 
            // pR_R_ResumenViajesTableAdapter
            // 
            this.pR_R_ResumenViajesTableAdapter.ClearBeforeFill = true;
            // 
            // cOD_SlcASMaestrasTableAdapter
            // 
            this.cOD_SlcASMaestrasTableAdapter.ClearBeforeFill = true;
            // 
            // cOD_SlcEstadoCuentaTableAdapter
            // 
            this.cOD_SlcEstadoCuentaTableAdapter.ClearBeforeFill = true;
            // 
            // RptMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1037, 475);
            this.Controls.Add(this.rvResViajes);
            this.Controls.Add(this.rvViajesR);
            this.Controls.Add(this.rvViajes);
            this.Controls.Add(this.pnlFiltros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RptMaestro";
            this.Text = "Reporte Maestro";
            this.Load += new System.EventHandler(this.RptViajes_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.pnlFiltros, 0);
            this.Controls.SetChildIndex(this.rvViajes, 0);
            this.Controls.SetChildIndex(this.rvViajesR, 0);
            this.Controls.SetChildIndex(this.rvResViajes, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PR_R_DetalleViajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PR_R_DetalleCtaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PR_R_DetalleViajesRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PR_R_ResumenViajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRRDetalleViajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRRDetalleCtaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRRDetalleViajesRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRRResumenViajesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcASMaestrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcEstadoCuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).EndInit();
            this.pnlFiltros.ResumeLayout(false);
            this.pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVeh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRRutasFiltradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRContratistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRMotoristasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaseTrab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClaseTrabajosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.Panel pnlFiltros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboListaReportes;
        private System.Windows.Forms.DataGridView dgvClaseTrab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.BindingSource tRClaseTrabajosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClaseTrabajosTableAdapter tR_ClaseTrabajosTableAdapter;
        private System.Windows.Forms.ComboBox cboRutas;
        private System.Windows.Forms.ComboBox cboVeh;
        private System.Windows.Forms.ComboBox cboContratistas;
        private System.Windows.Forms.ComboBox cboMotoristas;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.BindingSource tRClientesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter tR_ClientesTableAdapter;
        private System.Windows.Forms.BindingSource tRMotoristasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_MotoristasTableAdapter tR_MotoristasTableAdapter;
        private System.Windows.Forms.BindingSource tRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter tR_TipoVehiculosTableAdapter;
        private System.Windows.Forms.BindingSource tRContratistasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ContratistasTableAdapter tR_ContratistasTableAdapter;
        private System.Windows.Forms.BindingSource tRVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_VehiculosTableAdapter tR_VehiculosTableAdapter;
        private System.Windows.Forms.CheckBox ckbMarcarTodo;
        private Microsoft.Reporting.WinForms.ReportViewer rvViajes;
        private System.Windows.Forms.BindingSource pRRDetalleViajesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.PR_R_DetalleViajesTableAdapter pR_R_DetalleViajesTableAdapter;
        private System.Windows.Forms.BindingSource tRRutasFiltradasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_RutasFiltradasTableAdapter tR_RutasFiltradasTableAdapter;
        private System.Windows.Forms.BindingSource pRRDetalleCtaBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.PR_R_DetalleCtaTableAdapter pR_R_DetalleCtaTableAdapter;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkResumenCta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClaseTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn claseTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private Microsoft.Reporting.WinForms.ReportViewer rvViajesR;
        private System.Windows.Forms.BindingSource PR_R_DetalleViajesBindingSource;
        private System.Windows.Forms.BindingSource PR_R_DetalleCtaBindingSource;
        private System.Windows.Forms.BindingSource pRRDetalleViajesRBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.PR_R_DetalleViajesRTableAdapter pR_R_DetalleViajesRTableAdapter;
        private System.Windows.Forms.CheckBox ckbMarcarTpVeh;
        private System.Windows.Forms.DataGridView dgvTipoVeh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoVehiculoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagaISVDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private Microsoft.Reporting.WinForms.ReportViewer rvResViajes;
        private System.Windows.Forms.BindingSource pRRResumenViajesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.PR_R_ResumenViajesTableAdapter pR_R_ResumenViajesTableAdapter;
        private System.Windows.Forms.BindingSource cODSlcASMaestrasBindingSource;
        private DataSets.DsCodeasAdiggm dsCodeasAdiggm;
        private DataSets.DsCodeasAdiggmTableAdapters.COD_SlcASMaestrasTableAdapter cOD_SlcASMaestrasTableAdapter;
        private System.Windows.Forms.BindingSource cODSlcEstadoCuentaBindingSource;
        private DataSets.DsCodeasAdiggmTableAdapters.COD_SlcEstadoCuentaTableAdapter cOD_SlcEstadoCuentaTableAdapter;
        private System.Windows.Forms.BindingSource PR_R_DetalleViajesRBindingSource;
        private System.Windows.Forms.BindingSource PR_R_ResumenViajesBindingSource;
    }
}
