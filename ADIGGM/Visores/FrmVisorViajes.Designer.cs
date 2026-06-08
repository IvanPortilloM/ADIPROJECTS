namespace ADIGGM.Formularios_Base.Visores
{
    partial class FrmVisorViajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisorViajes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboFiltro = new System.Windows.Forms.GroupBox();
            this.mskNumBolHasta = new System.Windows.Forms.MaskedTextBox();
            this.mskNumBolDesde = new System.Windows.Forms.MaskedTextBox();
            this.RdbRango = new System.Windows.Forms.RadioButton();
            this.RdbCodigo = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cboPrefijos = new System.Windows.Forms.ComboBox();
            this.tRPrefijosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvVisorViajes = new System.Windows.Forms.DataGridView();
            this.idViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdViajeR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClaseTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoVeh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLaguna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrTrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HrGPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numBoleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anulado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codBoleta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reversarAnularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRViajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gboDetalle = new System.Windows.Forms.GroupBox();
            this.gboDatosGrales = new System.Windows.Forms.GroupBox();
            this.txtMotorista = new System.Windows.Forms.TextBox();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gboDetHr = new System.Windows.Forms.GroupBox();
            this.txtHrGPS = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtHrTrabajadas = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtHrFinal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtHrInical = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gboDatosPago = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.LklEditarObs = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.tR_PrefijosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_PrefijosTableAdapter();
            this.pR_ViajesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.PR_ViajesTableAdapter();
            this.pnlFooter.SuspendLayout();
            this.gboFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRPrefijosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisorViajes)).BeginInit();
            this.CmsOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRViajesBindingSource)).BeginInit();
            this.gboDetalle.SuspendLayout();
            this.gboDatosGrales.SuspendLayout();
            this.gboDetHr.SuspendLayout();
            this.gboDatosPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(132, 19);
            this.lblFooter.Text = "VISOR DE VIAJES";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(844, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(804, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(884, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(744, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 536);
            this.pnlFooter.Size = new System.Drawing.Size(924, 23);
            // 
            // gboFiltro
            // 
            this.gboFiltro.Controls.Add(this.mskNumBolHasta);
            this.gboFiltro.Controls.Add(this.mskNumBolDesde);
            this.gboFiltro.Controls.Add(this.RdbRango);
            this.gboFiltro.Controls.Add(this.RdbCodigo);
            this.gboFiltro.Controls.Add(this.btnSalir);
            this.gboFiltro.Controls.Add(this.btnNuevo);
            this.gboFiltro.Controls.Add(this.btnEditar);
            this.gboFiltro.Controls.Add(this.cboPrefijos);
            this.gboFiltro.Controls.Add(this.label3);
            this.gboFiltro.Controls.Add(this.btnVisualizar);
            this.gboFiltro.Controls.Add(this.dtpFechaHasta);
            this.gboFiltro.Controls.Add(this.dtpFechaDesde);
            this.gboFiltro.Controls.Add(this.label5);
            this.gboFiltro.Controls.Add(this.label4);
            this.gboFiltro.Controls.Add(this.label2);
            this.gboFiltro.Controls.Add(this.label1);
            this.gboFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboFiltro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboFiltro.Location = new System.Drawing.Point(0, 35);
            this.gboFiltro.Name = "gboFiltro";
            this.gboFiltro.Size = new System.Drawing.Size(924, 109);
            this.gboFiltro.TabIndex = 103;
            this.gboFiltro.TabStop = false;
            this.gboFiltro.Text = "Filtrar por:";
            // 
            // mskNumBolHasta
            // 
            this.mskNumBolHasta.BackColor = System.Drawing.SystemColors.Window;
            this.mskNumBolHasta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNumBolHasta.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskNumBolHasta.Location = new System.Drawing.Point(301, 36);
            this.mskNumBolHasta.Mask = "999999";
            this.mskNumBolHasta.Name = "mskNumBolHasta";
            this.mskNumBolHasta.Size = new System.Drawing.Size(56, 21);
            this.mskNumBolHasta.TabIndex = 5;
            this.mskNumBolHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskNumBolHasta.ValidatingType = typeof(int);
            // 
            // mskNumBolDesde
            // 
            this.mskNumBolDesde.BackColor = System.Drawing.Color.LightBlue;
            this.mskNumBolDesde.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNumBolDesde.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskNumBolDesde.Location = new System.Drawing.Point(202, 36);
            this.mskNumBolDesde.Mask = "999999";
            this.mskNumBolDesde.Name = "mskNumBolDesde";
            this.mskNumBolDesde.Size = new System.Drawing.Size(56, 21);
            this.mskNumBolDesde.TabIndex = 4;
            this.mskNumBolDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskNumBolDesde.ValidatingType = typeof(int);
            this.mskNumBolDesde.Enter += new System.EventHandler(this.mskNumBolDesde_Enter);
            this.mskNumBolDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskNumBolDesde_KeyDown);
            // 
            // RdbRango
            // 
            this.RdbRango.AutoSize = true;
            this.RdbRango.Location = new System.Drawing.Point(97, 16);
            this.RdbRango.Name = "RdbRango";
            this.RdbRango.Size = new System.Drawing.Size(81, 19);
            this.RdbRango.TabIndex = 2;
            this.RdbRango.TabStop = true;
            this.RdbRango.Text = "Por Rango";
            this.RdbRango.UseVisualStyleBackColor = true;
            // 
            // RdbCodigo
            // 
            this.RdbCodigo.AutoSize = true;
            this.RdbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.RdbCodigo.Checked = true;
            this.RdbCodigo.Location = new System.Drawing.Point(6, 16);
            this.RdbCodigo.Name = "RdbCodigo";
            this.RdbCodigo.Size = new System.Drawing.Size(85, 19);
            this.RdbCodigo.TabIndex = 1;
            this.RdbCodigo.TabStop = true;
            this.RdbCodigo.Text = "Por Código";
            this.RdbCodigo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RdbCodigo.UseVisualStyleBackColor = false;
            this.RdbCodigo.CheckedChanged += new System.EventHandler(this.RdbCodigo_CheckedChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(806, 33);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 57);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(656, 33);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 57);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(731, 33);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(69, 57);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cboPrefijos
            // 
            this.cboPrefijos.DataSource = this.tRPrefijosBindingSource;
            this.cboPrefijos.DisplayMember = "Prefijo";
            this.cboPrefijos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrefijos.FormattingEnabled = true;
            this.cboPrefijos.Location = new System.Drawing.Point(53, 64);
            this.cboPrefijos.Name = "cboPrefijos";
            this.cboPrefijos.Size = new System.Drawing.Size(72, 23);
            this.cboPrefijos.TabIndex = 3;
            this.cboPrefijos.ValueMember = "Prefijo";
            this.cboPrefijos.SelectedValueChanged += new System.EventHandler(this.cboPrefijos_SelectedValueChanged);
            // 
            // tRPrefijosBindingSource
            // 
            this.tRPrefijosBindingSource.DataMember = "TR_Prefijos";
            this.tRPrefijosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prefijo:";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(378, 33);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(69, 57);
            this.btnVisualizar.TabIndex = 8;
            this.btnVisualizar.Text = "Ejecutar";
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(287, 78);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(85, 21);
            this.dtpFechaHasta.TabIndex = 7;
            this.dtpFechaHasta.Value = new System.DateTime(2018, 11, 28, 14, 54, 48, 0);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(188, 78);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(85, 21);
            this.dtpFechaDesde.TabIndex = 6;
            this.dtpFechaDesde.Value = new System.DateTime(2018, 11, 28, 14, 54, 48, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "N° Boleta desde:";
            // 
            // dgvVisorViajes
            // 
            this.dgvVisorViajes.AllowUserToAddRows = false;
            this.dgvVisorViajes.AllowUserToDeleteRows = false;
            this.dgvVisorViajes.AutoGenerateColumns = false;
            this.dgvVisorViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVisorViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVisorViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idViaje,
            this.IdViajeR,
            this.idCliente,
            this.idClaseTrabajo,
            this.idTipoVeh,
            this.idRuta,
            this.idVehiculo,
            this.idMotorista,
            this.IdLaguna,
            this.HrInicial,
            this.HrFinal,
            this.HrTrabajadas,
            this.HrGPS,
            this.fecha,
            this.numBoleta,
            this.cliente,
            this.claseTrabajo,
            this.tipoVehiculo,
            this.ruta,
            this.codVehiculo,
            this.motorista,
            this.cantidad,
            this.tarifa,
            this.iSV,
            this.subtotal,
            this.total,
            this.observaciones,
            this.Anulado,
            this.codBoleta,
            this.prefijo});
            this.dgvVisorViajes.ContextMenuStrip = this.CmsOpciones;
            this.dgvVisorViajes.DataSource = this.pRViajesBindingSource;
            this.dgvVisorViajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisorViajes.Location = new System.Drawing.Point(0, 144);
            this.dgvVisorViajes.Name = "dgvVisorViajes";
            this.dgvVisorViajes.ReadOnly = true;
            this.dgvVisorViajes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVisorViajes.Size = new System.Drawing.Size(924, 258);
            this.dgvVisorViajes.TabIndex = 104;
            this.dgvVisorViajes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvVisorViajes_DataError);
            this.dgvVisorViajes.SelectionChanged += new System.EventHandler(this.dgvVisorViajes_SelectionChanged);
            this.dgvVisorViajes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvVisorViajes_MouseDown);
            // 
            // idViaje
            // 
            this.idViaje.DataPropertyName = "IdViaje";
            this.idViaje.HeaderText = "IdViaje";
            this.idViaje.Name = "idViaje";
            this.idViaje.ReadOnly = true;
            this.idViaje.Visible = false;
            this.idViaje.Width = 69;
            // 
            // IdViajeR
            // 
            this.IdViajeR.DataPropertyName = "IdViajeR";
            this.IdViajeR.HeaderText = "IdViajeR";
            this.IdViajeR.Name = "IdViajeR";
            this.IdViajeR.ReadOnly = true;
            this.IdViajeR.Visible = false;
            this.IdViajeR.Width = 76;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "IdCliente";
            this.idCliente.HeaderText = "IdCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            this.idCliente.Width = 81;
            // 
            // idClaseTrabajo
            // 
            this.idClaseTrabajo.DataPropertyName = "IdClaseTrabajo";
            this.idClaseTrabajo.HeaderText = "IdClaseTrabajo";
            this.idClaseTrabajo.Name = "idClaseTrabajo";
            this.idClaseTrabajo.ReadOnly = true;
            this.idClaseTrabajo.Visible = false;
            this.idClaseTrabajo.Width = 114;
            // 
            // idTipoVeh
            // 
            this.idTipoVeh.DataPropertyName = "IdTipoVeh";
            this.idTipoVeh.HeaderText = "IdTipoVeh";
            this.idTipoVeh.Name = "idTipoVeh";
            this.idTipoVeh.ReadOnly = true;
            this.idTipoVeh.Visible = false;
            this.idTipoVeh.Width = 86;
            // 
            // idRuta
            // 
            this.idRuta.DataPropertyName = "IdRuta";
            this.idRuta.HeaderText = "IdRuta";
            this.idRuta.Name = "idRuta";
            this.idRuta.ReadOnly = true;
            this.idRuta.Visible = false;
            this.idRuta.Width = 69;
            // 
            // idVehiculo
            // 
            this.idVehiculo.DataPropertyName = "IdVehiculo";
            this.idVehiculo.HeaderText = "IdVehiculo";
            this.idVehiculo.Name = "idVehiculo";
            this.idVehiculo.ReadOnly = true;
            this.idVehiculo.Visible = false;
            this.idVehiculo.Width = 89;
            // 
            // idMotorista
            // 
            this.idMotorista.DataPropertyName = "IdMotorista";
            this.idMotorista.HeaderText = "IdMotorista";
            this.idMotorista.Name = "idMotorista";
            this.idMotorista.ReadOnly = true;
            this.idMotorista.Visible = false;
            this.idMotorista.Width = 93;
            // 
            // IdLaguna
            // 
            this.IdLaguna.DataPropertyName = "IdLaguna";
            this.IdLaguna.HeaderText = "IdLaguna";
            this.IdLaguna.Name = "IdLaguna";
            this.IdLaguna.ReadOnly = true;
            this.IdLaguna.Visible = false;
            this.IdLaguna.Width = 85;
            // 
            // HrInicial
            // 
            this.HrInicial.DataPropertyName = "HrInicial";
            this.HrInicial.HeaderText = "HrInicial";
            this.HrInicial.Name = "HrInicial";
            this.HrInicial.ReadOnly = true;
            this.HrInicial.Visible = false;
            this.HrInicial.Width = 74;
            // 
            // HrFinal
            // 
            this.HrFinal.DataPropertyName = "HrFinal";
            this.HrFinal.HeaderText = "HrFinal";
            this.HrFinal.Name = "HrFinal";
            this.HrFinal.ReadOnly = true;
            this.HrFinal.Visible = false;
            this.HrFinal.Width = 67;
            // 
            // HrTrabajadas
            // 
            this.HrTrabajadas.DataPropertyName = "HrTrabajadas";
            this.HrTrabajadas.HeaderText = "HrTrabajadas";
            this.HrTrabajadas.Name = "HrTrabajadas";
            this.HrTrabajadas.ReadOnly = true;
            this.HrTrabajadas.Visible = false;
            this.HrTrabajadas.Width = 105;
            // 
            // HrGPS
            // 
            this.HrGPS.DataPropertyName = "HrGPS";
            this.HrGPS.HeaderText = "HrGPS";
            this.HrGPS.Name = "HrGPS";
            this.HrGPS.ReadOnly = true;
            this.HrGPS.Visible = false;
            this.HrGPS.Width = 66;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "Fecha";
            this.fecha.FillWeight = 243.6548F;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 66;
            // 
            // numBoleta
            // 
            this.numBoleta.DataPropertyName = "NumBoleta";
            this.numBoleta.FillWeight = 71.26904F;
            this.numBoleta.HeaderText = "N° Boleta";
            this.numBoleta.Name = "numBoleta";
            this.numBoleta.ReadOnly = true;
            this.numBoleta.Width = 81;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "Cliente";
            this.cliente.FillWeight = 71.26904F;
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 70;
            // 
            // claseTrabajo
            // 
            this.claseTrabajo.DataPropertyName = "ClaseTrabajo";
            this.claseTrabajo.FillWeight = 71.26904F;
            this.claseTrabajo.HeaderText = "Clase de Trabajo";
            this.claseTrabajo.Name = "claseTrabajo";
            this.claseTrabajo.ReadOnly = true;
            this.claseTrabajo.Width = 124;
            // 
            // tipoVehiculo
            // 
            this.tipoVehiculo.DataPropertyName = "TipoVehiculo";
            this.tipoVehiculo.FillWeight = 71.26904F;
            this.tipoVehiculo.HeaderText = "Tipo de Vehiculo";
            this.tipoVehiculo.Name = "tipoVehiculo";
            this.tipoVehiculo.ReadOnly = true;
            this.tipoVehiculo.Width = 121;
            // 
            // ruta
            // 
            this.ruta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ruta.DataPropertyName = "Ruta";
            this.ruta.FillWeight = 71.26904F;
            this.ruta.HeaderText = "Ruta";
            this.ruta.Name = "ruta";
            this.ruta.ReadOnly = true;
            // 
            // codVehiculo
            // 
            this.codVehiculo.DataPropertyName = "CodVehiculo";
            this.codVehiculo.HeaderText = "CodVehiculo";
            this.codVehiculo.Name = "codVehiculo";
            this.codVehiculo.ReadOnly = true;
            this.codVehiculo.Visible = false;
            this.codVehiculo.Width = 102;
            // 
            // motorista
            // 
            this.motorista.DataPropertyName = "Motorista";
            this.motorista.HeaderText = "Motorista";
            this.motorista.Name = "motorista";
            this.motorista.ReadOnly = true;
            this.motorista.Visible = false;
            this.motorista.Width = 82;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "Cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Visible = false;
            this.cantidad.Width = 86;
            // 
            // tarifa
            // 
            this.tarifa.DataPropertyName = "Tarifa";
            dataGridViewCellStyle1.Format = "N4";
            dataGridViewCellStyle1.NullValue = null;
            this.tarifa.DefaultCellStyle = dataGridViewCellStyle1;
            this.tarifa.HeaderText = "Tarifa";
            this.tarifa.Name = "tarifa";
            this.tarifa.ReadOnly = true;
            this.tarifa.Visible = false;
            this.tarifa.Width = 61;
            // 
            // iSV
            // 
            this.iSV.DataPropertyName = "ISV";
            this.iSV.HeaderText = "ISV";
            this.iSV.Name = "iSV";
            this.iSV.ReadOnly = true;
            this.iSV.Visible = false;
            this.iSV.Width = 48;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "Subtotal";
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Visible = false;
            this.subtotal.Width = 78;
            // 
            // total
            // 
            this.total.DataPropertyName = "Total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Visible = false;
            this.total.Width = 58;
            // 
            // observaciones
            // 
            this.observaciones.DataPropertyName = "Observaciones";
            this.observaciones.HeaderText = "Observaciones";
            this.observaciones.Name = "observaciones";
            this.observaciones.ReadOnly = true;
            this.observaciones.Visible = false;
            this.observaciones.Width = 114;
            // 
            // Anulado
            // 
            this.Anulado.DataPropertyName = "Anulado";
            this.Anulado.HeaderText = "Anulado";
            this.Anulado.Name = "Anulado";
            this.Anulado.ReadOnly = true;
            this.Anulado.Width = 59;
            // 
            // codBoleta
            // 
            this.codBoleta.DataPropertyName = "CodBoleta";
            this.codBoleta.HeaderText = "CodBoleta";
            this.codBoleta.Name = "codBoleta";
            this.codBoleta.ReadOnly = true;
            this.codBoleta.Visible = false;
            this.codBoleta.Width = 90;
            // 
            // prefijo
            // 
            this.prefijo.DataPropertyName = "Prefijo";
            this.prefijo.HeaderText = "Prefijo";
            this.prefijo.Name = "prefijo";
            this.prefijo.ReadOnly = true;
            this.prefijo.Visible = false;
            this.prefijo.Width = 63;
            // 
            // CmsOpciones
            // 
            this.CmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.anularToolStripMenuItem,
            this.reversarAnularToolStripMenuItem});
            this.CmsOpciones.Name = "CmsOpciones";
            this.CmsOpciones.Size = new System.Drawing.Size(157, 70);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editarToolStripMenuItem.Text = "&Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // anularToolStripMenuItem
            // 
            this.anularToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anularToolStripMenuItem.Image")));
            this.anularToolStripMenuItem.Name = "anularToolStripMenuItem";
            this.anularToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.anularToolStripMenuItem.Text = "&Anular";
            this.anularToolStripMenuItem.Click += new System.EventHandler(this.anularToolStripMenuItem_Click);
            // 
            // reversarAnularToolStripMenuItem
            // 
            this.reversarAnularToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reversarAnularToolStripMenuItem.Image")));
            this.reversarAnularToolStripMenuItem.Name = "reversarAnularToolStripMenuItem";
            this.reversarAnularToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.reversarAnularToolStripMenuItem.Text = "&Reversar Anular";
            this.reversarAnularToolStripMenuItem.Click += new System.EventHandler(this.reversarAnularToolStripMenuItem_Click);
            // 
            // pRViajesBindingSource
            // 
            this.pRViajesBindingSource.DataMember = "PR_Viajes";
            this.pRViajesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // gboDetalle
            // 
            this.gboDetalle.Controls.Add(this.gboDatosGrales);
            this.gboDetalle.Controls.Add(this.gboDetHr);
            this.gboDetalle.Controls.Add(this.gboDatosPago);
            this.gboDetalle.Controls.Add(this.LklEditarObs);
            this.gboDetalle.Controls.Add(this.label10);
            this.gboDetalle.Controls.Add(this.txtObservaciones);
            this.gboDetalle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gboDetalle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDetalle.Location = new System.Drawing.Point(0, 402);
            this.gboDetalle.Name = "gboDetalle";
            this.gboDetalle.Size = new System.Drawing.Size(924, 134);
            this.gboDetalle.TabIndex = 105;
            this.gboDetalle.TabStop = false;
            this.gboDetalle.Text = "Más Detalles del Viaje";
            // 
            // gboDatosGrales
            // 
            this.gboDatosGrales.Controls.Add(this.txtMotorista);
            this.gboDatosGrales.Controls.Add(this.txtVehiculo);
            this.gboDatosGrales.Controls.Add(this.label6);
            this.gboDatosGrales.Controls.Add(this.label7);
            this.gboDatosGrales.Location = new System.Drawing.Point(6, 14);
            this.gboDatosGrales.Name = "gboDatosGrales";
            this.gboDatosGrales.Size = new System.Drawing.Size(200, 115);
            this.gboDatosGrales.TabIndex = 18;
            this.gboDatosGrales.TabStop = false;
            this.gboDatosGrales.Text = "Datos Generales";
            // 
            // txtMotorista
            // 
            this.txtMotorista.Location = new System.Drawing.Point(6, 79);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.ReadOnly = true;
            this.txtMotorista.Size = new System.Drawing.Size(188, 21);
            this.txtMotorista.TabIndex = 1;
            this.txtMotorista.TabStop = false;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(6, 37);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.ReadOnly = true;
            this.txtVehiculo.Size = new System.Drawing.Size(84, 21);
            this.txtVehiculo.TabIndex = 0;
            this.txtVehiculo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Vehículo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Motorista:";
            // 
            // gboDetHr
            // 
            this.gboDetHr.Controls.Add(this.txtHrGPS);
            this.gboDetHr.Controls.Add(this.label18);
            this.gboDetHr.Controls.Add(this.txtHrTrabajadas);
            this.gboDetHr.Controls.Add(this.label17);
            this.gboDetHr.Controls.Add(this.txtHrFinal);
            this.gboDetHr.Controls.Add(this.label15);
            this.gboDetHr.Controls.Add(this.txtHrInical);
            this.gboDetHr.Controls.Add(this.label14);
            this.gboDetHr.Location = new System.Drawing.Point(460, 14);
            this.gboDetHr.Name = "gboDetHr";
            this.gboDetHr.Size = new System.Drawing.Size(149, 115);
            this.gboDetHr.TabIndex = 17;
            this.gboDetHr.TabStop = false;
            this.gboDetHr.Text = "Detalle de Horas";
            // 
            // txtHrGPS
            // 
            this.txtHrGPS.BackColor = System.Drawing.Color.LavenderBlush;
            this.txtHrGPS.Location = new System.Drawing.Point(77, 76);
            this.txtHrGPS.Name = "txtHrGPS";
            this.txtHrGPS.ReadOnly = true;
            this.txtHrGPS.Size = new System.Drawing.Size(65, 21);
            this.txtHrGPS.TabIndex = 24;
            this.txtHrGPS.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(74, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "Hr GPS";
            // 
            // txtHrTrabajadas
            // 
            this.txtHrTrabajadas.BackColor = System.Drawing.Color.PeachPuff;
            this.txtHrTrabajadas.Location = new System.Drawing.Point(6, 76);
            this.txtHrTrabajadas.Name = "txtHrTrabajadas";
            this.txtHrTrabajadas.ReadOnly = true;
            this.txtHrTrabajadas.Size = new System.Drawing.Size(65, 21);
            this.txtHrTrabajadas.TabIndex = 22;
            this.txtHrTrabajadas.TabStop = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 15);
            this.label17.TabIndex = 23;
            this.label17.Text = "Hr Trabaj.";
            // 
            // txtHrFinal
            // 
            this.txtHrFinal.BackColor = System.Drawing.Color.Khaki;
            this.txtHrFinal.Location = new System.Drawing.Point(77, 34);
            this.txtHrFinal.Name = "txtHrFinal";
            this.txtHrFinal.ReadOnly = true;
            this.txtHrFinal.Size = new System.Drawing.Size(65, 21);
            this.txtHrFinal.TabIndex = 19;
            this.txtHrFinal.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(74, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Hr Final";
            // 
            // txtHrInical
            // 
            this.txtHrInical.BackColor = System.Drawing.Color.Wheat;
            this.txtHrInical.Location = new System.Drawing.Point(6, 34);
            this.txtHrInical.Name = "txtHrInical";
            this.txtHrInical.ReadOnly = true;
            this.txtHrInical.Size = new System.Drawing.Size(65, 21);
            this.txtHrInical.TabIndex = 16;
            this.txtHrInical.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "Hr Inicial";
            // 
            // gboDatosPago
            // 
            this.gboDatosPago.Controls.Add(this.txtCantidad);
            this.gboDatosPago.Controls.Add(this.txtTarifa);
            this.gboDatosPago.Controls.Add(this.label13);
            this.gboDatosPago.Controls.Add(this.label8);
            this.gboDatosPago.Controls.Add(this.label12);
            this.gboDatosPago.Controls.Add(this.label9);
            this.gboDatosPago.Controls.Add(this.txtTotal);
            this.gboDatosPago.Controls.Add(this.label11);
            this.gboDatosPago.Controls.Add(this.txtSubtotal);
            this.gboDatosPago.Controls.Add(this.txtISV);
            this.gboDatosPago.Location = new System.Drawing.Point(212, 14);
            this.gboDatosPago.Name = "gboDatosPago";
            this.gboDatosPago.Size = new System.Drawing.Size(242, 115);
            this.gboDatosPago.TabIndex = 16;
            this.gboDatosPago.TabStop = false;
            this.gboDatosPago.Text = "Detalle de Pago";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(9, 34);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(51, 21);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.TabStop = false;
            // 
            // txtTarifa
            // 
            this.txtTarifa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTarifa.Location = new System.Drawing.Point(9, 76);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.ReadOnly = true;
            this.txtTarifa.Size = new System.Drawing.Size(65, 21);
            this.txtTarifa.TabIndex = 3;
            this.txtTarifa.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(76, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cantidad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(76, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Subtotal:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tarifa:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTotal.Location = new System.Drawing.Point(79, 76);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(84, 21);
            this.txtTotal.TabIndex = 13;
            this.txtTotal.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(165, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "ISV:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubtotal.Location = new System.Drawing.Point(79, 34);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(84, 21);
            this.txtSubtotal.TabIndex = 12;
            this.txtSubtotal.TabStop = false;
            // 
            // txtISV
            // 
            this.txtISV.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtISV.Location = new System.Drawing.Point(168, 34);
            this.txtISV.Name = "txtISV";
            this.txtISV.ReadOnly = true;
            this.txtISV.Size = new System.Drawing.Size(65, 21);
            this.txtISV.TabIndex = 11;
            this.txtISV.TabStop = false;
            // 
            // LklEditarObs
            // 
            this.LklEditarObs.AutoSize = true;
            this.LklEditarObs.Location = new System.Drawing.Point(720, 10);
            this.LklEditarObs.Name = "LklEditarObs";
            this.LklEditarObs.Size = new System.Drawing.Size(109, 15);
            this.LklEditarObs.TabIndex = 12;
            this.LklEditarObs.TabStop = true;
            this.LklEditarObs.Text = "Editar Observación";
            this.LklEditarObs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LklEditarObs_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(618, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Enabled = false;
            this.txtObservaciones.Location = new System.Drawing.Point(615, 26);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(305, 103);
            this.txtObservaciones.TabIndex = 13;
            this.txtObservaciones.TabStop = false;
            // 
            // tR_PrefijosTableAdapter
            // 
            this.tR_PrefijosTableAdapter.ClearBeforeFill = true;
            // 
            // pR_ViajesTableAdapter
            // 
            this.pR_ViajesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVisorViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(924, 559);
            this.Controls.Add(this.dgvVisorViajes);
            this.Controls.Add(this.gboDetalle);
            this.Controls.Add(this.gboFiltro);
            this.Name = "FrmVisorViajes";
            this.Text = "Visor de Viajes";
            this.Load += new System.EventHandler(this.FrmVisorViajes_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.gboFiltro, 0);
            this.Controls.SetChildIndex(this.gboDetalle, 0);
            this.Controls.SetChildIndex(this.dgvVisorViajes, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.gboFiltro.ResumeLayout(false);
            this.gboFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRPrefijosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisorViajes)).EndInit();
            this.CmsOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pRViajesBindingSource)).EndInit();
            this.gboDetalle.ResumeLayout(false);
            this.gboDetalle.PerformLayout();
            this.gboDatosGrales.ResumeLayout(false);
            this.gboDatosGrales.PerformLayout();
            this.gboDetHr.ResumeLayout(false);
            this.gboDetHr.PerformLayout();
            this.gboDatosPago.ResumeLayout(false);
            this.gboDatosPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboFiltro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPrefijos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DataGridView dgvVisorViajes;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRPrefijosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_PrefijosTableAdapter tR_PrefijosTableAdapter;
        private System.Windows.Forms.GroupBox gboDetalle;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.BindingSource pRViajesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.PR_ViajesTableAdapter pR_ViajesTableAdapter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtMotorista;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.ContextMenuStrip CmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reversarAnularToolStripMenuItem;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.LinkLabel LklEditarObs;
        private System.Windows.Forms.RadioButton RdbRango;
        private System.Windows.Forms.RadioButton RdbCodigo;
        private System.Windows.Forms.MaskedTextBox mskNumBolHasta;
        private System.Windows.Forms.MaskedTextBox mskNumBolDesde;
        private System.Windows.Forms.GroupBox gboDetHr;
        private System.Windows.Forms.TextBox txtHrInical;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gboDatosPago;
        private System.Windows.Forms.GroupBox gboDatosGrales;
        private System.Windows.Forms.TextBox txtHrGPS;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtHrTrabajadas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtHrFinal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn idViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdViajeR;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClaseTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoVeh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLaguna;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrTrabajadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn HrGPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn numBoleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn claseTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifa;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn observaciones;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBoleta;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefijo;
    }
}
