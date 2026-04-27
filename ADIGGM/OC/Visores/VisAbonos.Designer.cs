namespace ADIGGM.OC.Visores
{
    partial class VisAbonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisAbonos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.oCProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.cPTipoDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.cPAbonosVisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dgvAbonos = new System.Windows.Forms.DataGridView();
            this.IdAbono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAbonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anuladoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.anularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cP_AbonosVisorTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.CP_AbonosVisorTableAdapter();
            this.cP_TipoDocumentosTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.CP_TipoDocumentosTableAdapter();
            this.oC_ProveedoresTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAbonosDet = new System.Windows.Forms.DataGridView();
            this.fechaDesdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorAplicado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPAbonosDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cP_AbonosDetTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.CP_AbonosDetTableAdapter();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPTipoDocumentosBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPAbonosVisorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonosDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPAbonosDetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(108, 19);
            this.lblFooter.Text = "Visor Abonos";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(665, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(625, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(705, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(565, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 449);
            this.pnlFooter.Size = new System.Drawing.Size(745, 23);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.btnVisualizar);
            this.panel1.Controls.Add(this.cboProveedor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboTipoDoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 70);
            this.panel1.TabIndex = 104;
            // 
            // btnReporte
            // 
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(674, 3);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(68, 61);
            this.btnReporte.TabIndex = 138;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(590, 3);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(78, 61);
            this.btnVisualizar.TabIndex = 120;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // cboProveedor
            // 
            this.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProveedor.DataSource = this.oCProveedoresBindingSource;
            this.cboProveedor.DisplayMember = "NombreProveedor";
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(347, 40);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(195, 24);
            this.cboProveedor.TabIndex = 118;
            this.cboProveedor.ValueMember = "IdProveedor";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 119;
            this.label4.Text = "Proveedor:";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DataSource = this.cPTipoDocumentosBindingSource;
            this.cboTipoDoc.DisplayMember = "TipoDocumento";
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(100, 40);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(171, 24);
            this.cboTipoDoc.TabIndex = 116;
            this.cboTipoDoc.ValueMember = "IdCxpDocumento";
            // 
            // cPTipoDocumentosBindingSource
            // 
            this.cPTipoDocumentosBindingSource.DataMember = "CP_TipoDocumentos";
            this.cPTipoDocumentosBindingSource.DataSource = this.dsOC;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Tipo Documento:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(347, 12);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(195, 21);
            this.dtpHasta.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(100, 11);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(171, 21);
            this.dtpDesde.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Desde:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.txtObservaciones);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(745, 36);
            this.panel3.TabIndex = 110;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cPAbonosVisorBindingSource, "Observacion", true));
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaciones.Location = new System.Drawing.Point(92, 0);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.Size = new System.Drawing.Size(653, 36);
            this.txtObservaciones.TabIndex = 4;
            // 
            // cPAbonosVisorBindingSource
            // 
            this.cPAbonosVisorBindingSource.DataMember = "CP_AbonosVisor";
            this.cPAbonosVisorBindingSource.DataSource = this.dsOC;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Observaciones:";
            // 
            // dgvAbonos
            // 
            this.dgvAbonos.AllowUserToAddRows = false;
            this.dgvAbonos.AllowUserToDeleteRows = false;
            this.dgvAbonos.AutoGenerateColumns = false;
            this.dgvAbonos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbonos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAbono,
            this.fechaAbonoDataGridViewTextBoxColumn,
            this.tipoDocumentoDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.numeroDocumentoDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.anuladoDataGridViewCheckBoxColumn});
            this.dgvAbonos.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAbonos.DataSource = this.cPAbonosVisorBindingSource;
            this.dgvAbonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbonos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvAbonos.Location = new System.Drawing.Point(0, 105);
            this.dgvAbonos.Name = "dgvAbonos";
            this.dgvAbonos.ReadOnly = true;
            this.dgvAbonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbonos.Size = new System.Drawing.Size(745, 176);
            this.dgvAbonos.TabIndex = 111;
            this.dgvAbonos.SelectionChanged += new System.EventHandler(this.dgvAbonos_SelectionChanged);
            // 
            // IdAbono
            // 
            this.IdAbono.DataPropertyName = "IdAbono";
            this.IdAbono.HeaderText = "IdAbono";
            this.IdAbono.Name = "IdAbono";
            this.IdAbono.ReadOnly = true;
            this.IdAbono.Visible = false;
            // 
            // fechaAbonoDataGridViewTextBoxColumn
            // 
            this.fechaAbonoDataGridViewTextBoxColumn.DataPropertyName = "FechaAbono";
            this.fechaAbonoDataGridViewTextBoxColumn.FillWeight = 60.91371F;
            this.fechaAbonoDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaAbonoDataGridViewTextBoxColumn.Name = "fechaAbonoDataGridViewTextBoxColumn";
            this.fechaAbonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDocumentoDataGridViewTextBoxColumn
            // 
            this.tipoDocumentoDataGridViewTextBoxColumn.DataPropertyName = "TipoDocumento";
            this.tipoDocumentoDataGridViewTextBoxColumn.FillWeight = 155.1981F;
            this.tipoDocumentoDataGridViewTextBoxColumn.HeaderText = "T. Documento";
            this.tipoDocumentoDataGridViewTextBoxColumn.Name = "tipoDocumentoDataGridViewTextBoxColumn";
            this.tipoDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.FillWeight = 155.1981F;
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDocumentoDataGridViewTextBoxColumn
            // 
            this.numeroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "NumeroDocumento";
            this.numeroDocumentoDataGridViewTextBoxColumn.FillWeight = 104.3347F;
            this.numeroDocumentoDataGridViewTextBoxColumn.HeaderText = "# Documento";
            this.numeroDocumentoDataGridViewTextBoxColumn.Name = "numeroDocumentoDataGridViewTextBoxColumn";
            this.numeroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            dataGridViewCellStyle1.Format = "N2";
            this.montoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.montoDataGridViewTextBoxColumn.FillWeight = 74.72025F;
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // anuladoDataGridViewCheckBoxColumn
            // 
            this.anuladoDataGridViewCheckBoxColumn.DataPropertyName = "Anulado";
            this.anuladoDataGridViewCheckBoxColumn.FillWeight = 49.6352F;
            this.anuladoDataGridViewCheckBoxColumn.HeaderText = "Anulado";
            this.anuladoDataGridViewCheckBoxColumn.Name = "anuladoDataGridViewCheckBoxColumn";
            this.anuladoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anularToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // anularToolStripMenuItem
            // 
            this.anularToolStripMenuItem.Name = "anularToolStripMenuItem";
            this.anularToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.anularToolStripMenuItem.Text = "&Anular";
            this.anularToolStripMenuItem.Click += new System.EventHandler(this.anularToolStripMenuItem_Click);
            // 
            // cP_AbonosVisorTableAdapter
            // 
            this.cP_AbonosVisorTableAdapter.ClearBeforeFill = true;
            // 
            // cP_TipoDocumentosTableAdapter
            // 
            this.cP_TipoDocumentosTableAdapter.ClearBeforeFill = true;
            // 
            // oC_ProveedoresTableAdapter
            // 
            this.oC_ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(745, 132);
            this.panel2.TabIndex = 112;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAbonosDet);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // dgvAbonosDet
            // 
            this.dgvAbonosDet.AllowUserToAddRows = false;
            this.dgvAbonosDet.AllowUserToDeleteRows = false;
            this.dgvAbonosDet.AutoGenerateColumns = false;
            this.dgvAbonosDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbonosDet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAbonosDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbonosDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDesdeDataGridViewTextBoxColumn,
            this.fechaHastaDataGridViewTextBoxColumn,
            this.Monto,
            this.ValorAplicado});
            this.dgvAbonosDet.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAbonosDet.DataSource = this.cPAbonosDetBindingSource;
            this.dgvAbonosDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbonosDet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvAbonosDet.Location = new System.Drawing.Point(3, 17);
            this.dgvAbonosDet.Name = "dgvAbonosDet";
            this.dgvAbonosDet.ReadOnly = true;
            this.dgvAbonosDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbonosDet.Size = new System.Drawing.Size(739, 112);
            this.dgvAbonosDet.TabIndex = 113;
            // 
            // fechaDesdeDataGridViewTextBoxColumn
            // 
            this.fechaDesdeDataGridViewTextBoxColumn.DataPropertyName = "FechaDesde";
            this.fechaDesdeDataGridViewTextBoxColumn.HeaderText = "FechaDesde";
            this.fechaDesdeDataGridViewTextBoxColumn.Name = "fechaDesdeDataGridViewTextBoxColumn";
            this.fechaDesdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHastaDataGridViewTextBoxColumn
            // 
            this.fechaHastaDataGridViewTextBoxColumn.DataPropertyName = "FechaHasta";
            this.fechaHastaDataGridViewTextBoxColumn.HeaderText = "FechaHasta";
            this.fechaHastaDataGridViewTextBoxColumn.Name = "fechaHastaDataGridViewTextBoxColumn";
            this.fechaHastaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            dataGridViewCellStyle2.Format = "N2";
            this.Monto.DefaultCellStyle = dataGridViewCellStyle2;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // ValorAplicado
            // 
            this.ValorAplicado.DataPropertyName = "ValorAplicado";
            dataGridViewCellStyle3.Format = "N2";
            this.ValorAplicado.DefaultCellStyle = dataGridViewCellStyle3;
            this.ValorAplicado.HeaderText = "Valor Aplicado";
            this.ValorAplicado.Name = "ValorAplicado";
            this.ValorAplicado.ReadOnly = true;
            // 
            // cPAbonosDetBindingSource
            // 
            this.cPAbonosDetBindingSource.DataMember = "CP_AbonosDet";
            this.cPAbonosDetBindingSource.DataSource = this.dsOC;
            // 
            // cP_AbonosDetTableAdapter
            // 
            this.cP_AbonosDetTableAdapter.ClearBeforeFill = true;
            // 
            // VisAbonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(745, 472);
            this.Controls.Add(this.dgvAbonos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VisAbonos";
            this.Text = "Visor de Abonos";
            this.Load += new System.EventHandler(this.VisAbonos_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.dgvAbonos, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPTipoDocumentosBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPAbonosVisorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonosDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPAbonosDetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.BindingSource cPAbonosVisorBindingSource;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvAbonos;
        private DataSets.DsOCTableAdapters.CP_AbonosVisorTableAdapter cP_AbonosVisorTableAdapter;
        private System.Windows.Forms.BindingSource cPTipoDocumentosBindingSource;
        private DataSets.DsOCTableAdapters.CP_TipoDocumentosTableAdapter cP_TipoDocumentosTableAdapter;
        private System.Windows.Forms.BindingSource oCProveedoresBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter oC_ProveedoresTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anularToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAbono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAbonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anuladoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAbonosDet;
        private System.Windows.Forms.BindingSource cPAbonosDetBindingSource;
        private DataSets.DsOCTableAdapters.CP_AbonosDetTableAdapter cP_AbonosDetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDesdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHastaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorAplicado;
        private System.Windows.Forms.Button btnReporte;
    }
}
