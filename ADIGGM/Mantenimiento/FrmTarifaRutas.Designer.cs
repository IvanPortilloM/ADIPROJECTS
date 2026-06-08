namespace ADIGGM.Mantenimiento
{
    partial class FrmTarifaRutas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTarifaRutas));
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
            this.cboClaseTrabajo = new System.Windows.Forms.ComboBox();
            this.tRClaseTrabajosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblRutas2 = new System.Windows.Forms.Label();
            this.lblBuscar1 = new System.Windows.Forms.Label();
            this.txtRuta2 = new System.Windows.Forms.TextBox();
            this.txtRuta1 = new System.Windows.Forms.TextBox();
            this.lblRutasAsig = new System.Windows.Forms.Label();
            this.tR_TipoVehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter();
            this.tR_ClaseTrabajosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClaseTrabajosTableAdapter();
            this.pR_TarifaRutasNoAsigTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.PR_TarifaRutasNoAsigTableAdapter();
            this.pR_TarifaRutasAsigTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.PR_TarifaRutasAsigTableAdapter();
            this.tRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.tR_ClientesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasNoAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRTarifaRutasNoAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRTarifaRutasAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClaseTrabajosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblFooter.Size = new System.Drawing.Size(201, 19);
            this.lblFooter.Text = "ASIGNAR TARIFA A RUTAS";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(573, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(533, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(613, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(473, 0);
            this.pgbProcesos.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 477);
            this.pnlFooter.Size = new System.Drawing.Size(653, 23);
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
            this.dgvRutasNoAsignadas.Location = new System.Drawing.Point(0, 1263);
            this.dgvRutasNoAsignadas.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.dgvRutasNoAsignadas.Name = "dgvRutasNoAsignadas";
            this.dgvRutasNoAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutasNoAsignadas.Size = new System.Drawing.Size(5920, 2577);
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
            this.Tarifa.HeaderText = "Tarifa";
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.Width = 61;
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
            this.dgvRutasAsignadas.Location = new System.Drawing.Point(21, 61);
            this.dgvRutasAsignadas.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.dgvRutasAsignadas.Name = "dgvRutasAsignadas";
            this.dgvRutasAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutasAsignadas.Size = new System.Drawing.Size(592, 257);
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
            this.TarifaReal.HeaderText = "Tarifa";
            this.TarifaReal.Name = "TarifaReal";
            this.TarifaReal.Width = 61;
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
            this.btnEliminarTodo.Location = new System.Drawing.Point(6016, 2622);
            this.btnEliminarTodo.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(720, 258);
            this.btnEliminarTodo.TabIndex = 21;
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(6000, 1839);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(720, 258);
            this.btnAgregar.TabIndex = 20;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(6000, 2230);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(720, 258);
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
            this.btnAgregarTodo.Location = new System.Drawing.Point(6016, 1447);
            this.btnAgregarTodo.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(720, 258);
            this.btnAgregarTodo.TabIndex = 18;
            this.btnAgregarTodo.UseVisualStyleBackColor = true;
            this.btnAgregarTodo.Click += new System.EventHandler(this.btnAgregarTodo_Click);
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(18, 81);
            this.lblTipoVehiculo.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(120, 16);
            this.lblTipoVehiculo.TabIndex = 22;
            this.lblTipoVehiculo.Text = "Tipo de Vehiculo:";
            // 
            // lblClaseTrabajo
            // 
            this.lblClaseTrabajo.AutoSize = true;
            this.lblClaseTrabajo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaseTrabajo.Location = new System.Drawing.Point(18, 113);
            this.lblClaseTrabajo.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblClaseTrabajo.Name = "lblClaseTrabajo";
            this.lblClaseTrabajo.Size = new System.Drawing.Size(123, 16);
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
            this.cboTipoVehiculo.Location = new System.Drawing.Point(2192, 199);
            this.cboTipoVehiculo.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(2500, 21);
            this.cboTipoVehiculo.TabIndex = 24;
            this.cboTipoVehiculo.ValueMember = "IdTipoVehiculo";
            this.cboTipoVehiculo.SelectedValueChanged += new System.EventHandler(this.cboTipoVehiculo_SelectedValueChanged);
            // 
            // tRTipoVehiculosBindingSource
            // 
            this.tRTipoVehiculosBindingSource.DataMember = "TR_TipoVehiculos";
            this.tRTipoVehiculosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // cboClaseTrabajo
            // 
            this.cboClaseTrabajo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboClaseTrabajo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClaseTrabajo.DataSource = this.tRClaseTrabajosBindingSource;
            this.cboClaseTrabajo.DisplayMember = "ClaseTrabajo";
            this.cboClaseTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClaseTrabajo.FormattingEnabled = true;
            this.cboClaseTrabajo.Location = new System.Drawing.Point(2192, 391);
            this.cboClaseTrabajo.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.cboClaseTrabajo.Name = "cboClaseTrabajo";
            this.cboClaseTrabajo.Size = new System.Drawing.Size(2500, 21);
            this.cboClaseTrabajo.TabIndex = 25;
            this.cboClaseTrabajo.ValueMember = "IdClaseTrabajo";
            this.cboClaseTrabajo.SelectedValueChanged += new System.EventHandler(this.cboClaseTrabajo_SelectedValueChanged);
            // 
            // tRClaseTrabajosBindingSource
            // 
            this.tRClaseTrabajosBindingSource.DataMember = "TR_ClaseTrabajos";
            this.tRClaseTrabajosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // lblRutas2
            // 
            this.lblRutas2.AutoSize = true;
            this.lblRutas2.BackColor = System.Drawing.Color.Transparent;
            this.lblRutas2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutas2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRutas2.Location = new System.Drawing.Point(18, 35);
            this.lblRutas2.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblRutas2.Name = "lblRutas2";
            this.lblRutas2.Size = new System.Drawing.Size(94, 16);
            this.lblRutas2.TabIndex = 31;
            this.lblRutas2.Text = "Buscar Rutas:";
            // 
            // lblBuscar1
            // 
            this.lblBuscar1.AutoSize = true;
            this.lblBuscar1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBuscar1.Location = new System.Drawing.Point(132, 26);
            this.lblBuscar1.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblBuscar1.Name = "lblBuscar1";
            this.lblBuscar1.Size = new System.Drawing.Size(94, 16);
            this.lblBuscar1.TabIndex = 30;
            this.lblBuscar1.Text = "Buscar Rutas:";
            // 
            // txtRuta2
            // 
            this.txtRuta2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRuta2.Location = new System.Drawing.Point(1776, 753);
            this.txtRuta2.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.txtRuta2.Name = "txtRuta2";
            this.txtRuta2.Size = new System.Drawing.Size(3460, 20);
            this.txtRuta2.TabIndex = 29;
            this.txtRuta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuta2_KeyPress);
            // 
            // txtRuta1
            // 
            this.txtRuta1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRuta1.Location = new System.Drawing.Point(135, 52);
            this.txtRuta1.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.txtRuta1.Name = "txtRuta1";
            this.txtRuta1.Size = new System.Drawing.Size(346, 20);
            this.txtRuta1.TabIndex = 28;
            this.txtRuta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuta1_KeyPress);
            // 
            // lblRutasAsig
            // 
            this.lblRutasAsig.AutoSize = true;
            this.lblRutasAsig.BackColor = System.Drawing.Color.Transparent;
            this.lblRutasAsig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutasAsig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRutasAsig.Location = new System.Drawing.Point(2144, 613);
            this.lblRutasAsig.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblRutasAsig.Name = "lblRutasAsig";
            this.lblRutasAsig.Size = new System.Drawing.Size(111, 16);
            this.lblRutasAsig.TabIndex = 26;
            this.lblRutasAsig.Text = "Rutas con Tarifa";
            // 
            // tR_TipoVehiculosTableAdapter
            // 
            this.tR_TipoVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ClaseTrabajosTableAdapter
            // 
            this.tR_ClaseTrabajosTableAdapter.ClearBeforeFill = true;
            // 
            // pR_TarifaRutasNoAsigTableAdapter
            // 
            this.pR_TarifaRutasNoAsigTableAdapter.ClearBeforeFill = true;
            // 
            // pR_TarifaRutasAsigTableAdapter
            // 
            this.pR_TarifaRutasAsigTableAdapter.ClearBeforeFill = true;
            // 
            // tRClientesBindingSource
            // 
            this.tRClientesBindingSource.DataMember = "TR_Clientes";
            this.tRClientesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // cboClientes
            // 
            this.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClientes.DataSource = this.tRClientesBindingSource;
            this.cboClientes.DisplayMember = "Cliente";
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(720, 57);
            this.cboClientes.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(321, 21);
            this.cboClientes.TabIndex = 34;
            this.cboClientes.ValueMember = "IdCliente";
            this.cboClientes.SelectedValueChanged += new System.EventHandler(this.cboClientes_SelectedValueChanged);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(18, 26);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(63, 16);
            this.lblClientes.TabIndex = 32;
            this.lblClientes.Text = "Clientes:";
            // 
            // tR_ClientesTableAdapter
            // 
            this.tR_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.cboClientes);
            this.groupBox1.Controls.Add(this.lblClientes);
            this.groupBox1.Controls.Add(this.lblBuscar1);
            this.groupBox1.Controls.Add(this.txtRuta1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.groupBox1.Size = new System.Drawing.Size(653, 116);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por Clientes";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.lblTipoVehiculo);
            this.groupBox2.Controls.Add(this.lblClaseTrabajo);
            this.groupBox2.Controls.Add(this.lblRutas2);
            this.groupBox2.Controls.Add(this.cboClaseTrabajo);
            this.groupBox2.Controls.Add(this.txtRuta2);
            this.groupBox2.Controls.Add(this.cboTipoVehiculo);
            this.groupBox2.Controls.Add(this.dgvRutasAsignadas);
            this.groupBox2.Controls.Add(this.lblRutasAsig);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(0, 151);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.groupBox2.Size = new System.Drawing.Size(653, 326);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rutas Asignadas por Tipo de Vehiculo y Clase de Trabajo";
            // 
            // FrmTarifaRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(653, 500);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarTodo);
            this.Controls.Add(this.dgvRutasNoAsignadas);
            this.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.Name = "FrmTarifaRutas";
            this.Load += new System.EventHandler(this.FrmTarifaRutas_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvRutasNoAsignadas, 0);
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
        private System.Windows.Forms.BindingSource tRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter tR_TipoVehiculosTableAdapter;
        private System.Windows.Forms.BindingSource tRClaseTrabajosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClaseTrabajosTableAdapter tR_ClaseTrabajosTableAdapter;
        private System.Windows.Forms.BindingSource pRTarifaRutasNoAsigBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.PR_TarifaRutasNoAsigTableAdapter pR_TarifaRutasNoAsigTableAdapter;
        private System.Windows.Forms.BindingSource pRTarifaRutasAsigBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.PR_TarifaRutasAsigTableAdapter pR_TarifaRutasAsigTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRutaNoAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTarifaRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TarifaReal;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.BindingSource tRClientesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter tR_ClientesTableAdapter;
        //private DataSets.DsTransporteAdiggmTableAdapters.TR_SubClienteTableAdapter tR_SubClienteTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
