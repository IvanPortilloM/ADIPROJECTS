namespace ADIGGM.OC.Visores
{
    partial class VisOrdenesTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisOrdenesTrabajo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbProxVencer = new System.Windows.Forms.RadioButton();
            this.rdbTodo = new System.Windows.Forms.RadioButton();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.oCProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoOC = new System.Windows.Forms.ComboBox();
            this.oCTipoOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tRVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.dgvOC = new System.Windows.Forms.DataGridView();
            this.IdOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anulado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.confirmado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Autorizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaEstimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.anularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmarOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmarReparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.solicitarDesconfirmaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarReimpresiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oCOrdenTrabajoVisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOCDet = new System.Windows.Forms.DataGridView();
            this.vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCOrdenTrabajoDetVisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.oC_TipoOCTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_TipoOCTableAdapter();
            this.oC_ProveedoresTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter();
            this.oC_OrdenTrabajoVisorTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_OrdenTrabajoVisorTableAdapter();
            this.oC_OrdenTrabajoDetVisorTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_OrdenTrabajoDetVisorTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tR_VehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_VehiculosTableAdapter();
            this.lblTotalDetalle = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCTipoOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOC)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenTrabajoVisorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOCDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenTrabajoDetVisorBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Size = new System.Drawing.Size(208, 19);
            this.lblFooter.Text = "Visor Ordenes de Compra";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(882, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(842, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(922, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(782, 0);
            this.pgbProcesos.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblTotalDetalle);
            this.pnlFooter.Location = new System.Drawing.Point(0, 511);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Size = new System.Drawing.Size(962, 23);
            this.pnlFooter.Controls.SetChildIndex(this.lblFooter, 0);
            this.pnlFooter.Controls.SetChildIndex(this.pgbProcesos, 0);
            this.pnlFooter.Controls.SetChildIndex(this.lblTotalDetalle, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbProxVencer);
            this.panel1.Controls.Add(this.rdbTodo);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnVisualizar);
            this.panel1.Controls.Add(this.cboProveedor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboTipoOC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 70);
            this.panel1.TabIndex = 103;
            // 
            // rdbProxVencer
            // 
            this.rdbProxVencer.AutoSize = true;
            this.rdbProxVencer.Location = new System.Drawing.Point(589, 41);
            this.rdbProxVencer.Name = "rdbProxVencer";
            this.rdbProxVencer.Size = new System.Drawing.Size(103, 20);
            this.rdbProxVencer.TabIndex = 124;
            this.rdbProxVencer.Text = "Prox. a Vencer";
            this.rdbProxVencer.UseVisualStyleBackColor = true;
            this.rdbProxVencer.CheckedChanged += new System.EventHandler(this.rdbProxVencer_CheckedChanged);
            // 
            // rdbTodo
            // 
            this.rdbTodo.AutoSize = true;
            this.rdbTodo.Checked = true;
            this.rdbTodo.Location = new System.Drawing.Point(589, 13);
            this.rdbTodo.Name = "rdbTodo";
            this.rdbTodo.Size = new System.Drawing.Size(79, 20);
            this.rdbTodo.TabIndex = 122;
            this.rdbTodo.TabStop = true;
            this.rdbTodo.Text = "Por Fecha";
            this.rdbTodo.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(896, 11);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(54, 49);
            this.btnNuevo.TabIndex = 121;
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnNuevo, "Nueva Orden");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(836, 12);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(54, 49);
            this.btnVisualizar.TabIndex = 120;
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnVisualizar, "Visualizar");
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
            // cboTipoOC
            // 
            this.cboTipoOC.DataSource = this.oCTipoOCBindingSource;
            this.cboTipoOC.DisplayMember = "TipoOC";
            this.cboTipoOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoOC.FormattingEnabled = true;
            this.cboTipoOC.Location = new System.Drawing.Point(100, 40);
            this.cboTipoOC.Name = "cboTipoOC";
            this.cboTipoOC.Size = new System.Drawing.Size(171, 24);
            this.cboTipoOC.TabIndex = 116;
            this.cboTipoOC.ValueMember = "IdTipoOC";
            this.cboTipoOC.SelectedIndexChanged += new System.EventHandler(this.cboTipoOC_SelectedIndexChanged);
            // 
            // oCTipoOCBindingSource
            // 
            this.oCTipoOCBindingSource.DataMember = "OC_TipoOC";
            this.oCTipoOCBindingSource.DataSource = this.dsOC;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Tipo de Orden:";
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
            // tRVehiculosBindingSource
            // 
            this.tRVehiculosBindingSource.DataMember = "TR_Vehiculos";
            this.tRVehiculosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvOC
            // 
            this.dgvOC.AllowUserToAddRows = false;
            this.dgvOC.AllowUserToDeleteRows = false;
            this.dgvOC.AutoGenerateColumns = false;
            this.dgvOC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOC,
            this.Correlativo,
            this.fecha,
            this.Solicitado,
            this.tipoOC,
            this.nombreProveedor,
            this.observaciones,
            this.anulado,
            this.confirmado,
            this.Autorizado,
            this.fechaEstimada});
            this.dgvOC.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvOC.DataSource = this.oCOrdenTrabajoVisorBindingSource;
            this.dgvOC.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvOC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOC.Location = new System.Drawing.Point(0, 105);
            this.dgvOC.Name = "dgvOC";
            this.dgvOC.ReadOnly = true;
            this.dgvOC.RowHeadersVisible = false;
            this.dgvOC.RowHeadersWidth = 51;
            this.dgvOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOC.Size = new System.Drawing.Size(962, 199);
            this.dgvOC.TabIndex = 107;
            this.dgvOC.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvOC_DataError);
            this.dgvOC.SelectionChanged += new System.EventHandler(this.dgvOC_SelectionChanged);
            this.dgvOC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvOC_MouseDown);
            // 
            // IdOC
            // 
            this.IdOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdOC.DataPropertyName = "IdOC";
            this.IdOC.HeaderText = "IdOC";
            this.IdOC.MinimumWidth = 6;
            this.IdOC.Name = "IdOC";
            this.IdOC.ReadOnly = true;
            this.IdOC.Visible = false;
            // 
            // Correlativo
            // 
            this.Correlativo.DataPropertyName = "Correlativo";
            this.Correlativo.FillWeight = 80.73384F;
            this.Correlativo.HeaderText = "#Orden";
            this.Correlativo.MinimumWidth = 6;
            this.Correlativo.Name = "Correlativo";
            this.Correlativo.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.fecha.FillWeight = 69.03455F;
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Solicitado
            // 
            this.Solicitado.DataPropertyName = "Solicitado";
            this.Solicitado.FillWeight = 143.9715F;
            this.Solicitado.HeaderText = "Solicitado";
            this.Solicitado.MinimumWidth = 6;
            this.Solicitado.Name = "Solicitado";
            this.Solicitado.ReadOnly = true;
            // 
            // tipoOC
            // 
            this.tipoOC.DataPropertyName = "TipoOC";
            this.tipoOC.FillWeight = 157.4407F;
            this.tipoOC.HeaderText = "Tipo Orden";
            this.tipoOC.MinimumWidth = 6;
            this.tipoOC.Name = "tipoOC";
            this.tipoOC.ReadOnly = true;
            // 
            // nombreProveedor
            // 
            this.nombreProveedor.DataPropertyName = "NombreProveedor";
            this.nombreProveedor.FillWeight = 157.4407F;
            this.nombreProveedor.HeaderText = "Nombre Proveedor";
            this.nombreProveedor.MinimumWidth = 6;
            this.nombreProveedor.Name = "nombreProveedor";
            this.nombreProveedor.ReadOnly = true;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "Observaciones";
            this.observaciones.FillWeight = 104.7716F;
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.MinimumWidth = 6;
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Visible = false;
            // 
            // anulado
            // 
            this.anulado.DataPropertyName = "Anulado";
            this.anulado.FillWeight = 49.37095F;
            this.anulado.HeaderText = "Anulado";
            this.anulado.MinimumWidth = 6;
            this.anulado.Name = "anulado";
            this.anulado.ReadOnly = true;
            // 
            // confirmado
            // 
            this.confirmado.DataPropertyName = "Confirmado";
            this.confirmado.FillWeight = 71.09652F;
            this.confirmado.HeaderText = "Confirmado";
            this.confirmado.MinimumWidth = 6;
            this.confirmado.Name = "confirmado";
            this.confirmado.ReadOnly = true;
            // 
            // Autorizado
            // 
            this.Autorizado.DataPropertyName = "Autorizado";
            this.Autorizado.FillWeight = 66.1395F;
            this.Autorizado.HeaderText = "Autorizado";
            this.Autorizado.MinimumWidth = 6;
            this.Autorizado.Name = "Autorizado";
            this.Autorizado.ReadOnly = true;
            // 
            // fechaEstimada
            // 
            this.fechaEstimada.DataPropertyName = "FechaEstimada";
            this.fechaEstimada.HeaderText = "FechaEstimada";
            this.fechaEstimada.Name = "fechaEstimada";
            this.fechaEstimada.ReadOnly = true;
            this.fechaEstimada.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anularToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.confirmarOrdenToolStripMenuItem,
            this.confirmarReparacionToolStripMenuItem,
            this.autorizarToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.toolStripSeparator1,
            this.solicitarDesconfirmaciónToolStripMenuItem,
            this.solicitarReimpresiónToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 208);
            // 
            // anularToolStripMenuItem
            // 
            this.anularToolStripMenuItem.Name = "anularToolStripMenuItem";
            this.anularToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.anularToolStripMenuItem.Text = "&Anular";
            this.anularToolStripMenuItem.Click += new System.EventHandler(this.anularToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.editarToolStripMenuItem.Text = "&Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // confirmarOrdenToolStripMenuItem
            // 
            this.confirmarOrdenToolStripMenuItem.Name = "confirmarOrdenToolStripMenuItem";
            this.confirmarOrdenToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.confirmarOrdenToolStripMenuItem.Text = "&Confirmar Orden";
            this.confirmarOrdenToolStripMenuItem.Click += new System.EventHandler(this.confirmarOrdenToolStripMenuItem_Click);
            // 
            // confirmarReparacionToolStripMenuItem
            // 
            this.confirmarReparacionToolStripMenuItem.Name = "confirmarReparacionToolStripMenuItem";
            this.confirmarReparacionToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.confirmarReparacionToolStripMenuItem.Text = "Confirmar Reparación";
            this.confirmarReparacionToolStripMenuItem.Click += new System.EventHandler(this.confirmarReparacionToolStripMenuItem_Click);
            // 
            // autorizarToolStripMenuItem
            // 
            this.autorizarToolStripMenuItem.Name = "autorizarToolStripMenuItem";
            this.autorizarToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.autorizarToolStripMenuItem.Text = "Autorizar";
            this.autorizarToolStripMenuItem.Click += new System.EventHandler(this.autorizarToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.reporteToolStripMenuItem.Text = "&Reporte";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // solicitarDesconfirmaciónToolStripMenuItem
            // 
            this.solicitarDesconfirmaciónToolStripMenuItem.Name = "solicitarDesconfirmaciónToolStripMenuItem";
            this.solicitarDesconfirmaciónToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.solicitarDesconfirmaciónToolStripMenuItem.Text = "Solicitar Desconfirmación";
            this.solicitarDesconfirmaciónToolStripMenuItem.Click += new System.EventHandler(this.solicitarDesconfirmaciónToolStripMenuItem_Click);
            // 
            // solicitarReimpresiónToolStripMenuItem
            // 
            this.solicitarReimpresiónToolStripMenuItem.Name = "solicitarReimpresiónToolStripMenuItem";
            this.solicitarReimpresiónToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.solicitarReimpresiónToolStripMenuItem.Text = "Solicitar Reimpresión";
            this.solicitarReimpresiónToolStripMenuItem.Click += new System.EventHandler(this.solicitarReimpresiónToolStripMenuItem_Click);
            // 
            // oCOrdenTrabajoVisorBindingSource
            // 
            this.oCOrdenTrabajoVisorBindingSource.DataMember = "OC_OrdenTrabajoVisor";
            this.oCOrdenTrabajoVisorBindingSource.DataSource = this.dsOC;
            // 
            // dgvOCDet
            // 
            this.dgvOCDet.AllowUserToAddRows = false;
            this.dgvOCDet.AllowUserToDeleteRows = false;
            this.dgvOCDet.AutoGenerateColumns = false;
            this.dgvOCDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOCDet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOCDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOCDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehiculo,
            this.productoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.iSV,
            this.total,
            this.DescripcionServicio});
            this.dgvOCDet.DataSource = this.oCOrdenTrabajoDetVisorBindingSource;
            this.dgvOCDet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOCDet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOCDet.Location = new System.Drawing.Point(0, 0);
            this.dgvOCDet.Name = "dgvOCDet";
            this.dgvOCDet.ReadOnly = true;
            this.dgvOCDet.RowHeadersVisible = false;
            this.dgvOCDet.RowHeadersWidth = 51;
            this.dgvOCDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOCDet.Size = new System.Drawing.Size(962, 168);
            this.dgvOCDet.TabIndex = 107;
            this.dgvOCDet.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvOCDet_DataError);
            // 
            // vehiculo
            // 
            this.vehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.vehiculo.DataPropertyName = "Vehiculo";
            this.vehiculo.FillWeight = 150F;
            this.vehiculo.HeaderText = "Vehiculo";
            this.vehiculo.MinimumWidth = 6;
            this.vehiculo.Name = "vehiculo";
            this.vehiculo.ReadOnly = true;
            this.vehiculo.Width = 78;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.FillWeight = 169.8959F;
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            dataGridViewCellStyle2.Format = "N2";
            this.cantidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cantidadDataGridViewTextBoxColumn.FillWeight = 60.91375F;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 86;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            dataGridViewCellStyle3.Format = "N4";
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.precioDataGridViewTextBoxColumn.FillWeight = 64.47442F;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 65;
            // 
            // iSV
            // 
            this.iSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iSV.DataPropertyName = "ISV";
            dataGridViewCellStyle4.Format = "N4";
            this.iSV.DefaultCellStyle = dataGridViewCellStyle4;
            this.iSV.FillWeight = 66.82574F;
            this.iSV.HeaderText = "ISV";
            this.iSV.MinimumWidth = 6;
            this.iSV.Name = "iSV";
            this.iSV.ReadOnly = true;
            this.iSV.Width = 48;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.total.DataPropertyName = "Total";
            dataGridViewCellStyle5.Format = "N4";
            this.total.DefaultCellStyle = dataGridViewCellStyle5;
            this.total.FillWeight = 67.9947F;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 58;
            // 
            // DescripcionServicio
            // 
            this.DescripcionServicio.DataPropertyName = "DescripcionServicio";
            this.DescripcionServicio.HeaderText = "Observación";
            this.DescripcionServicio.MinimumWidth = 6;
            this.DescripcionServicio.Name = "DescripcionServicio";
            this.DescripcionServicio.ReadOnly = true;
            // 
            // oCOrdenTrabajoDetVisorBindingSource
            // 
            this.oCOrdenTrabajoDetVisorBindingSource.DataMember = "OC_OrdenTrabajoDetVisor";
            this.oCOrdenTrabajoDetVisorBindingSource.DataSource = this.dsOC;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvOCDet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(962, 168);
            this.panel2.TabIndex = 104;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.txtObservaciones);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(962, 39);
            this.panel3.TabIndex = 109;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oCOrdenTrabajoVisorBindingSource, "Observaciones", true));
            this.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaciones.Location = new System.Drawing.Point(92, 0);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ReadOnly = true;
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(870, 39);
            this.txtObservaciones.TabIndex = 4;
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
            // oC_TipoOCTableAdapter
            // 
            this.oC_TipoOCTableAdapter.ClearBeforeFill = true;
            // 
            // oC_ProveedoresTableAdapter
            // 
            this.oC_ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // oC_OrdenTrabajoVisorTableAdapter
            // 
            this.oC_OrdenTrabajoVisorTableAdapter.ClearBeforeFill = true;
            // 
            // oC_OrdenTrabajoDetVisorTableAdapter
            // 
            this.oC_OrdenTrabajoDetVisorTableAdapter.ClearBeforeFill = true;
            // 
            // tR_VehiculosTableAdapter
            // 
            this.tR_VehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotalDetalle
            // 
            this.lblTotalDetalle.AutoSize = true;
            this.lblTotalDetalle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotalDetalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDetalle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalDetalle.Location = new System.Drawing.Point(782, 0);
            this.lblTotalDetalle.Name = "lblTotalDetalle";
            this.lblTotalDetalle.Size = new System.Drawing.Size(0, 19);
            this.lblTotalDetalle.TabIndex = 105;
            // 
            // VisOrdenesTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(962, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvOC);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisOrdenesTrabajo";
            this.Text = "Visor OC";
            this.Load += new System.EventHandler(this.VisOrdenesTrabajo_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgvOC, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCTipoOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOC)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenTrabajoVisorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOCDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenTrabajoDetVisorBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoOC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DataGridView dgvOC;
        private System.Windows.Forms.DataGridView dgvOCDet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label5;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.BindingSource oCTipoOCBindingSource;
        private DataSets.DsOCTableAdapters.OC_TipoOCTableAdapter oC_TipoOCTableAdapter;
        private System.Windows.Forms.BindingSource oCProveedoresBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter oC_ProveedoresTableAdapter;
        private System.Windows.Forms.BindingSource oCOrdenTrabajoVisorBindingSource;
        private DataSets.DsOCTableAdapters.OC_OrdenTrabajoVisorTableAdapter oC_OrdenTrabajoVisorTableAdapter;
        private System.Windows.Forms.BindingSource oCOrdenTrabajoDetVisorBindingSource;
        private DataSets.DsOCTableAdapters.OC_OrdenTrabajoDetVisorTableAdapter oC_OrdenTrabajoDetVisorTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmarOrdenToolStripMenuItem;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizarToolStripMenuItem;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_VehiculosTableAdapter tR_VehiculosTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem solicitarDesconfirmaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarReimpresiónToolStripMenuItem;
        private System.Windows.Forms.Label lblTotalDetalle;
        private System.Windows.Forms.ToolStripMenuItem confirmarReparacionToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anulado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Autorizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEstimada;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionServicio;
        private System.Windows.Forms.RadioButton rdbProxVencer;
        private System.Windows.Forms.RadioButton rdbTodo;
    }
}
