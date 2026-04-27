namespace ADIGGM.Mantenimiento
{
    partial class FrmAsigTarifas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsigTarifas));
            this.dgvRutasNoAsignadas = new System.Windows.Forms.DataGridView();
            this.idRutaNoAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRTarifaRutasNoAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.dgvRutasAsignadas = new System.Windows.Forms.DataGridView();
            this.IdTarifaRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TarifaReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRTarifaRutasAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarTodo = new System.Windows.Forms.Button();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblClaseTrabajo = new System.Windows.Forms.Label();
            this.cboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.tRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm1 = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.cboClaseTrabajo = new System.Windows.Forms.ComboBox();
            this.tRClaseTrabajosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRutas2 = new System.Windows.Forms.Label();
            this.lblBuscar1 = new System.Windows.Forms.Label();
            this.txtRuta2 = new System.Windows.Forms.TextBox();
            this.txtRuta1 = new System.Windows.Forms.TextBox();
            this.lblRutasAsig = new System.Windows.Forms.Label();
            this.pR_TarifaRutasNoAsigTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.PR_TarifaRutasNoAsigTableAdapter();
            this.pR_TarifaRutasAsigTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.PR_TarifaRutasAsigTableAdapter();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.tRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblClientes = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tR_TipoVehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter();
            this.tR_ClaseTrabajosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClaseTrabajosTableAdapter();
            this.tR_ClientesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasNoAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRTarifaRutasNoAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRTarifaRutasAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClaseTrabajosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(293, 19);
            this.lblFooter.Text = "ASIGNAR RUTAS A CLASE DE TRABAJO";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(718, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(678, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(758, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(618, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 517);
            this.pnlFooter.Size = new System.Drawing.Size(798, 23);
            // 
            // dgvRutasNoAsignadas
            // 
            this.dgvRutasNoAsignadas.AllowUserToAddRows = false;
            this.dgvRutasNoAsignadas.AllowUserToDeleteRows = false;
            this.dgvRutasNoAsignadas.AutoGenerateColumns = false;
            this.dgvRutasNoAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutasNoAsignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRutaNoAsig,
            this.rutaDataGridViewTextBoxColumn,
            this.Tarifa});
            this.dgvRutasNoAsignadas.DataSource = this.pRTarifaRutasNoAsigBindingSource;
            this.dgvRutasNoAsignadas.Location = new System.Drawing.Point(0, 171);
            this.dgvRutasNoAsignadas.Name = "dgvRutasNoAsignadas";
            this.dgvRutasNoAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutasNoAsignadas.Size = new System.Drawing.Size(370, 343);
            this.dgvRutasNoAsignadas.TabIndex = 2;
            this.dgvRutasNoAsignadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutasNoAsignadas_CellClick);
            // 
            // idRutaNoAsig
            // 
            this.idRutaNoAsig.DataPropertyName = "IdRuta";
            this.idRutaNoAsig.HeaderText = "IdRuta";
            this.idRutaNoAsig.Name = "idRutaNoAsig";
            this.idRutaNoAsig.ReadOnly = true;
            this.idRutaNoAsig.Visible = false;
            // 
            // rutaDataGridViewTextBoxColumn
            // 
            this.rutaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rutaDataGridViewTextBoxColumn.DataPropertyName = "Ruta";
            this.rutaDataGridViewTextBoxColumn.HeaderText = "Ruta";
            this.rutaDataGridViewTextBoxColumn.Name = "rutaDataGridViewTextBoxColumn";
            this.rutaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Tarifa
            // 
            this.Tarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Tarifa.DataPropertyName = "Tarifa";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.Tarifa.DefaultCellStyle = dataGridViewCellStyle1;
            this.Tarifa.HeaderText = "Tarifa";
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.Width = 62;
            // 
            // pRTarifaRutasNoAsigBindingSource
            // 
            this.pRTarifaRutasNoAsigBindingSource.DataMember = "PR_TarifaRutasNoAsig";
            this.pRTarifaRutasNoAsigBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvRutasAsignadas
            // 
            this.dgvRutasAsignadas.AllowUserToAddRows = false;
            this.dgvRutasAsignadas.AllowUserToDeleteRows = false;
            this.dgvRutasAsignadas.AutoGenerateColumns = false;
            this.dgvRutasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutasAsignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTarifaRuta,
            this.idRuta,
            this.rutaDataGridViewTextBoxColumn1,
            this.TarifaReal});
            this.dgvRutasAsignadas.DataSource = this.pRTarifaRutasAsigBindingSource;
            this.dgvRutasAsignadas.Location = new System.Drawing.Point(428, 171);
            this.dgvRutasAsignadas.Name = "dgvRutasAsignadas";
            this.dgvRutasAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutasAsignadas.Size = new System.Drawing.Size(370, 343);
            this.dgvRutasAsignadas.TabIndex = 3;
            this.dgvRutasAsignadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutasAsignadas_CellClick);
            this.dgvRutasAsignadas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutasAsignadas_CellEndEdit);
            // 
            // IdTarifaRuta
            // 
            this.IdTarifaRuta.DataPropertyName = "IdTarifaRuta";
            this.IdTarifaRuta.HeaderText = "IdTarifaRuta";
            this.IdTarifaRuta.Name = "IdTarifaRuta";
            this.IdTarifaRuta.ReadOnly = true;
            this.IdTarifaRuta.Visible = false;
            // 
            // idRuta
            // 
            this.idRuta.DataPropertyName = "IdRuta";
            this.idRuta.HeaderText = "IdRuta";
            this.idRuta.Name = "idRuta";
            this.idRuta.ReadOnly = true;
            this.idRuta.Visible = false;
            // 
            // rutaDataGridViewTextBoxColumn1
            // 
            this.rutaDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rutaDataGridViewTextBoxColumn1.DataPropertyName = "Ruta";
            this.rutaDataGridViewTextBoxColumn1.HeaderText = "Ruta";
            this.rutaDataGridViewTextBoxColumn1.Name = "rutaDataGridViewTextBoxColumn1";
            this.rutaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // TarifaReal
            // 
            this.TarifaReal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TarifaReal.DataPropertyName = "Tarifa";
            dataGridViewCellStyle2.Format = "N2";
            this.TarifaReal.DefaultCellStyle = dataGridViewCellStyle2;
            this.TarifaReal.HeaderText = "Tarifa";
            this.TarifaReal.Name = "TarifaReal";
            this.TarifaReal.Width = 62;
            // 
            // pRTarifaRutasAsigBindingSource
            // 
            this.pRTarifaRutasAsigBindingSource.DataMember = "PR_TarifaRutasAsig";
            this.pRTarifaRutasAsigBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarTodo.FlatAppearance.BorderSize = 0;
            this.btnEliminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarTodo.Image")));
            this.btnEliminarTodo.Location = new System.Drawing.Point(376, 355);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(45, 35);
            this.btnEliminarTodo.TabIndex = 21;
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(375, 249);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 35);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(375, 302);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 35);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarTodo
            // 
            this.btnAgregarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarTodo.FlatAppearance.BorderSize = 0;
            this.btnAgregarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTodo.Image")));
            this.btnAgregarTodo.Location = new System.Drawing.Point(376, 196);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(45, 35);
            this.btnAgregarTodo.TabIndex = 18;
            this.btnAgregarTodo.UseVisualStyleBackColor = true;
            this.btnAgregarTodo.Click += new System.EventHandler(this.btnAgregarTodo_Click);
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(12, 58);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(121, 16);
            this.lblTipoVehiculo.TabIndex = 22;
            this.lblTipoVehiculo.Text = "Tipo de Vehiculo:";
            // 
            // lblClaseTrabajo
            // 
            this.lblClaseTrabajo.AutoSize = true;
            this.lblClaseTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaseTrabajo.Location = new System.Drawing.Point(7, 54);
            this.lblClaseTrabajo.Name = "lblClaseTrabajo";
            this.lblClaseTrabajo.Size = new System.Drawing.Size(124, 16);
            this.lblClaseTrabajo.TabIndex = 23;
            this.lblClaseTrabajo.Text = "Clase de Trabajo:";
            // 
            // cboTipoVehiculo
            // 
            this.cboTipoVehiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTipoVehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoVehiculo.DataSource = this.tRTipoVehiculosBindingSource;
            this.cboTipoVehiculo.DisplayMember = "TipoVehiculo";
            this.cboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVehiculo.FormattingEnabled = true;
            this.cboTipoVehiculo.Location = new System.Drawing.Point(139, 57);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(160, 21);
            this.cboTipoVehiculo.TabIndex = 24;
            this.cboTipoVehiculo.ValueMember = "IdTipoVehiculo";
            this.cboTipoVehiculo.SelectedValueChanged += new System.EventHandler(this.cboTipoVehiculo_SelectedValueChanged);
            // 
            // tRTipoVehiculosBindingSource
            // 
            this.tRTipoVehiculosBindingSource.DataMember = "TR_TipoVehiculos";
            this.tRTipoVehiculosBindingSource.DataSource = this.dsTransporteAdiggm1;
            // 
            // dsTransporteAdiggm1
            // 
            this.dsTransporteAdiggm1.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboClaseTrabajo
            // 
            this.cboClaseTrabajo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboClaseTrabajo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClaseTrabajo.DataSource = this.tRClaseTrabajosBindingSource;
            this.cboClaseTrabajo.DisplayMember = "ClaseTrabajo";
            this.cboClaseTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClaseTrabajo.FormattingEnabled = true;
            this.cboClaseTrabajo.Location = new System.Drawing.Point(137, 53);
            this.cboClaseTrabajo.Name = "cboClaseTrabajo";
            this.cboClaseTrabajo.Size = new System.Drawing.Size(160, 21);
            this.cboClaseTrabajo.TabIndex = 25;
            this.cboClaseTrabajo.ValueMember = "IdClaseTrabajo";
            this.cboClaseTrabajo.SelectedValueChanged += new System.EventHandler(this.cboClaseTrabajo_SelectedValueChanged);
            // 
            // tRClaseTrabajosBindingSource
            // 
            this.tRClaseTrabajosBindingSource.DataMember = "TR_ClaseTrabajos";
            this.tRClaseTrabajosBindingSource.DataSource = this.dsTransporteAdiggm1;
            // 
            // lblRutas2
            // 
            this.lblRutas2.AutoSize = true;
            this.lblRutas2.BackColor = System.Drawing.Color.Transparent;
            this.lblRutas2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutas2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRutas2.Location = new System.Drawing.Point(10, 103);
            this.lblRutas2.Name = "lblRutas2";
            this.lblRutas2.Size = new System.Drawing.Size(95, 16);
            this.lblRutas2.TabIndex = 31;
            this.lblRutas2.Text = "Buscar Rutas:";
            // 
            // lblBuscar1
            // 
            this.lblBuscar1.AutoSize = true;
            this.lblBuscar1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBuscar1.Location = new System.Drawing.Point(12, 103);
            this.lblBuscar1.Name = "lblBuscar1";
            this.lblBuscar1.Size = new System.Drawing.Size(95, 16);
            this.lblBuscar1.TabIndex = 30;
            this.lblBuscar1.Text = "Buscar Rutas:";
            // 
            // txtRuta2
            // 
            this.txtRuta2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRuta2.Location = new System.Drawing.Point(111, 102);
            this.txtRuta2.Name = "txtRuta2";
            this.txtRuta2.Size = new System.Drawing.Size(220, 20);
            this.txtRuta2.TabIndex = 29;
            this.txtRuta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuta2_KeyPress);
            // 
            // txtRuta1
            // 
            this.txtRuta1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRuta1.Location = new System.Drawing.Point(113, 102);
            this.txtRuta1.Name = "txtRuta1";
            this.txtRuta1.Size = new System.Drawing.Size(220, 20);
            this.txtRuta1.TabIndex = 28;
            this.txtRuta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuta1_KeyPress);
            // 
            // lblRutasAsig
            // 
            this.lblRutasAsig.AutoSize = true;
            this.lblRutasAsig.BackColor = System.Drawing.Color.Transparent;
            this.lblRutasAsig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutasAsig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRutasAsig.Location = new System.Drawing.Point(134, 83);
            this.lblRutasAsig.Name = "lblRutasAsig";
            this.lblRutasAsig.Size = new System.Drawing.Size(112, 16);
            this.lblRutasAsig.TabIndex = 26;
            this.lblRutasAsig.Text = "Rutas con Tarifa";
            // 
            // pR_TarifaRutasNoAsigTableAdapter
            // 
            this.pR_TarifaRutasNoAsigTableAdapter.ClearBeforeFill = true;
            // 
            // pR_TarifaRutasAsigTableAdapter
            // 
            this.pR_TarifaRutasAsigTableAdapter.ClearBeforeFill = true;
            // 
            // cboClientes
            // 
            this.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClientes.DataSource = this.tRClientesBindingSource;
            this.cboClientes.DisplayMember = "Cliente";
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(82, 24);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(217, 21);
            this.cboClientes.TabIndex = 34;
            this.cboClientes.ValueMember = "IdCliente";
            this.cboClientes.SelectedValueChanged += new System.EventHandler(this.cboClientes_SelectedValueChanged);
            // 
            // tRClientesBindingSource
            // 
            this.tRClientesBindingSource.DataMember = "TR_Clientes";
            this.tRClientesBindingSource.DataSource = this.dsTransporteAdiggm1;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(12, 25);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(64, 16);
            this.lblClientes.TabIndex = 32;
            this.lblClientes.Text = "Clientes:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.lblTipoVehiculo);
            this.groupBox1.Controls.Add(this.cboClientes);
            this.groupBox1.Controls.Add(this.lblClientes);
            this.groupBox1.Controls.Add(this.lblBuscar1);
            this.groupBox1.Controls.Add(this.txtRuta1);
            this.groupBox1.Controls.Add(this.cboTipoVehiculo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 131);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por Clientes y Tipo de Vehículo";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.lblClaseTrabajo);
            this.groupBox2.Controls.Add(this.lblRutas2);
            this.groupBox2.Controls.Add(this.cboClaseTrabajo);
            this.groupBox2.Controls.Add(this.txtRuta2);
            this.groupBox2.Controls.Add(this.lblRutasAsig);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(428, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 131);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rutas Asignadas por Clase de Trabajo";
            // 
            // tR_TipoVehiculosTableAdapter
            // 
            this.tR_TipoVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ClaseTrabajosTableAdapter
            // 
            this.tR_ClaseTrabajosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ClientesTableAdapter
            // 
            this.tR_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAsigTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(798, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarTodo);
            this.Controls.Add(this.dgvRutasAsignadas);
            this.Controls.Add(this.dgvRutasNoAsignadas);
            this.Name = "FrmAsigTarifas";
            this.Load += new System.EventHandler(this.FrmTarifaRutas_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvRutasNoAsignadas, 0);
            this.Controls.SetChildIndex(this.dgvRutasAsignadas, 0);
            this.Controls.SetChildIndex(this.btnAgregarTodo, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnEliminarTodo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasNoAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRTarifaRutasNoAsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRTarifaRutasAsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClaseTrabajosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRutasNoAsignadas;
        private System.Windows.Forms.DataGridView dgvRutasAsignadas;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarTodo;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblClaseTrabajo;
        private System.Windows.Forms.ComboBox cboTipoVehiculo;
        private System.Windows.Forms.ComboBox cboClaseTrabajo;
        private System.Windows.Forms.Label lblRutas2;
        private System.Windows.Forms.Label lblBuscar1;
        private System.Windows.Forms.TextBox txtRuta2;
        private System.Windows.Forms.TextBox txtRuta1;
        private System.Windows.Forms.Label lblRutasAsig;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource pRTarifaRutasNoAsigBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.PR_TarifaRutasNoAsigTableAdapter pR_TarifaRutasNoAsigTableAdapter;
        private System.Windows.Forms.BindingSource pRTarifaRutasAsigBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.PR_TarifaRutasAsigTableAdapter pR_TarifaRutasAsigTableAdapter;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label lblClientes;
        //private DataSets.DsTransporteAdiggmTableAdapters.TR_SubClienteTableAdapter tR_SubClienteTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm1;
        private System.Windows.Forms.BindingSource tRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter tR_TipoVehiculosTableAdapter;
        private System.Windows.Forms.BindingSource tRClaseTrabajosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClaseTrabajosTableAdapter tR_ClaseTrabajosTableAdapter;
        private System.Windows.Forms.BindingSource tRClientesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter tR_ClientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRutaNoAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTarifaRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarifaReal;
    }
}
