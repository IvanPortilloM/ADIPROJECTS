namespace ADIGGM.Visores
{
    partial class FrmVisorPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisorPrestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboFiltro = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNSolHasta = new System.Windows.Forms.TextBox();
            this.txtNSolDesde = new System.Windows.Forms.TextBox();
            this.RdbRangoSolicitud = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cboPrinterList = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cboFDependencia = new System.Windows.Forms.ComboBox();
            this.mskCodigo = new System.Windows.Forms.MaskedTextBox();
            this.RdbRangoFecha = new System.Windows.Forms.RadioButton();
            this.RdbCodigo = new System.Windows.Forms.RadioButton();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.Marcar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idAsociado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantSolicitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantConsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantAprobada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoSug = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitalizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aprobado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fechaAprobacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anulado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TipoSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dependencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprobarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reversarAprobaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reversarAnulaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sACSolicitudesDgvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodeasAdiggm = new ADIGGM.DataSets.DsCodeasAdiggm();
            this.gboDetalles = new System.Windows.Forms.GroupBox();
            this.gboDatosPres = new System.Windows.Forms.GroupBox();
            this.lblTipoSol = new System.Windows.Forms.Label();
            this.pnlDatosPres = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFecAprob = new System.Windows.Forms.TextBox();
            this.txtCantConsumo = new System.Windows.Forms.TextBox();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCantAprob = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.gboParametros = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPeriodoSug = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtTasa = new System.Windows.Forms.TextBox();
            this.txtCapitalizacion = new System.Windows.Forms.TextBox();
            this.gboDatosGen = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtAreaTrab = new System.Windows.Forms.TextBox();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.txtTipoEmp = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.sAC_SolicitudesDgvTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.SAC_SolicitudesDgvTableAdapter();
            this.sAC_AsociadosTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.SAC_AsociadosTableAdapter();
            this.sAC_SolicitudesTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.SAC_SolicitudesTableAdapter();
            this.sAC_EstadoFinancieroTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.SAC_EstadoFinancieroTableAdapter();
            this.saC_AmortizacionesTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.SAC_AmortizacionesTableAdapter();
            this.pR_R_SolicitudesTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.PR_R_SolicitudesTableAdapter();
            this.pnlFooter.SuspendLayout();
            this.gboFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            this.CmsOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sACSolicitudesDgvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).BeginInit();
            this.gboDetalles.SuspendLayout();
            this.gboDatosPres.SuspendLayout();
            this.pnlDatosPres.SuspendLayout();
            this.gboParametros.SuspendLayout();
            this.gboDatosGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Size = new System.Drawing.Size(255, 19);
            this.lblFooter.Text = "Visor de Solicitudes de Préstamo";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(995, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(955, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(1035, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(895, 0);
            this.pgbProcesos.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 624);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Size = new System.Drawing.Size(1075, 23);
            // 
            // gboFiltro
            // 
            this.gboFiltro.Controls.Add(this.button1);
            this.gboFiltro.Controls.Add(this.label20);
            this.gboFiltro.Controls.Add(this.txtNSolHasta);
            this.gboFiltro.Controls.Add(this.txtNSolDesde);
            this.gboFiltro.Controls.Add(this.RdbRangoSolicitud);
            this.gboFiltro.Controls.Add(this.label17);
            this.gboFiltro.Controls.Add(this.label18);
            this.gboFiltro.Controls.Add(this.cboPrinterList);
            this.gboFiltro.Controls.Add(this.label19);
            this.gboFiltro.Controls.Add(this.cboFDependencia);
            this.gboFiltro.Controls.Add(this.mskCodigo);
            this.gboFiltro.Controls.Add(this.RdbRangoFecha);
            this.gboFiltro.Controls.Add(this.RdbCodigo);
            this.gboFiltro.Controls.Add(this.btnVisualizar);
            this.gboFiltro.Controls.Add(this.btnNuevo);
            this.gboFiltro.Controls.Add(this.btnEditar);
            this.gboFiltro.Controls.Add(this.btnGenerar);
            this.gboFiltro.Controls.Add(this.btnImprimir);
            this.gboFiltro.Controls.Add(this.btnExportar);
            this.gboFiltro.Controls.Add(this.btnSalir);
            this.gboFiltro.Controls.Add(this.dtpFechaHasta);
            this.gboFiltro.Controls.Add(this.dtpFechaDesde);
            this.gboFiltro.Controls.Add(this.label5);
            this.gboFiltro.Controls.Add(this.label4);
            this.gboFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboFiltro.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboFiltro.Location = new System.Drawing.Point(0, 35);
            this.gboFiltro.Name = "gboFiltro";
            this.gboFiltro.Size = new System.Drawing.Size(1075, 130);
            this.gboFiltro.TabIndex = 103;
            this.gboFiltro.TabStop = false;
            this.gboFiltro.Text = "Filtrar por:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 50;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(443, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 16);
            this.label20.TabIndex = 49;
            this.label20.Text = "Imprimir a:";
            // 
            // txtNSolHasta
            // 
            this.txtNSolHasta.Location = new System.Drawing.Point(318, 75);
            this.txtNSolHasta.Name = "txtNSolHasta";
            this.txtNSolHasta.Size = new System.Drawing.Size(46, 21);
            this.txtNSolHasta.TabIndex = 48;
            this.txtNSolHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNSolDesde
            // 
            this.txtNSolDesde.Location = new System.Drawing.Point(213, 75);
            this.txtNSolDesde.Name = "txtNSolDesde";
            this.txtNSolDesde.Size = new System.Drawing.Size(48, 21);
            this.txtNSolDesde.TabIndex = 47;
            this.txtNSolDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RdbRangoSolicitud
            // 
            this.RdbRangoSolicitud.AutoSize = true;
            this.RdbRangoSolicitud.Location = new System.Drawing.Point(218, 35);
            this.RdbRangoSolicitud.Name = "RdbRangoSolicitud";
            this.RdbRangoSolicitud.Size = new System.Drawing.Size(147, 20);
            this.RdbRangoSolicitud.TabIndex = 46;
            this.RdbRangoSolicitud.TabStop = true;
            this.RdbRangoSolicitud.Text = "Por Rango de Solicitud";
            this.RdbRangoSolicitud.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(320, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 16);
            this.label17.TabIndex = 45;
            this.label17.Text = "Hasta:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(215, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 16);
            this.label18.TabIndex = 44;
            this.label18.Text = "Desde:";
            // 
            // cboPrinterList
            // 
            this.cboPrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrinterList.FormattingEnabled = true;
            this.cboPrinterList.Location = new System.Drawing.Point(389, 88);
            this.cboPrinterList.Name = "cboPrinterList";
            this.cboPrinterList.Size = new System.Drawing.Size(171, 24);
            this.cboPrinterList.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(431, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 16);
            this.label19.TabIndex = 42;
            this.label19.Text = "Dependencia:";
            // 
            // cboFDependencia
            // 
            this.cboFDependencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboFDependencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFDependencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFDependencia.FormattingEnabled = true;
            this.cboFDependencia.Items.AddRange(new object[] {
            "(TODO)",
            "A.D.I.-GGM",
            "A.D.I.-GGM (ESL)"});
            this.cboFDependencia.Location = new System.Drawing.Point(414, 38);
            this.cboFDependencia.Name = "cboFDependencia";
            this.cboFDependencia.Size = new System.Drawing.Size(121, 24);
            this.cboFDependencia.TabIndex = 41;
            // 
            // mskCodigo
            // 
            this.mskCodigo.Location = new System.Drawing.Point(47, 38);
            this.mskCodigo.Mask = "9999-9999-99999";
            this.mskCodigo.Name = "mskCodigo";
            this.mskCodigo.Size = new System.Drawing.Size(100, 21);
            this.mskCodigo.TabIndex = 30;
            this.mskCodigo.Enter += new System.EventHandler(this.mskCodigo_Enter);
            this.mskCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCodigo_KeyDown);
            // 
            // RdbRangoFecha
            // 
            this.RdbRangoFecha.AutoSize = true;
            this.RdbRangoFecha.Location = new System.Drawing.Point(29, 63);
            this.RdbRangoFecha.Name = "RdbRangoFecha";
            this.RdbRangoFecha.Size = new System.Drawing.Size(136, 20);
            this.RdbRangoFecha.TabIndex = 29;
            this.RdbRangoFecha.TabStop = true;
            this.RdbRangoFecha.Text = "Por Rango de Fecha";
            this.RdbRangoFecha.UseVisualStyleBackColor = true;
            this.RdbRangoFecha.CheckedChanged += new System.EventHandler(this.RdbRangoFecha_CheckedChanged);
            // 
            // RdbCodigo
            // 
            this.RdbCodigo.AutoSize = true;
            this.RdbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.RdbCodigo.Checked = true;
            this.RdbCodigo.Location = new System.Drawing.Point(19, 13);
            this.RdbCodigo.Name = "RdbCodigo";
            this.RdbCodigo.Size = new System.Drawing.Size(156, 20);
            this.RdbCodigo.TabIndex = 28;
            this.RdbCodigo.TabStop = true;
            this.RdbCodigo.Text = "Por Código de Asociado";
            this.RdbCodigo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.RdbCodigo.UseVisualStyleBackColor = false;
            this.RdbCodigo.CheckedChanged += new System.EventHandler(this.RdbCodigo_CheckedChanged);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(603, 17);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(67, 110);
            this.btnVisualizar.TabIndex = 24;
            this.btnVisualizar.Text = "Ejecutar";
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(670, 17);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(67, 110);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(737, 17);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(67, 110);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(804, 17);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(67, 110);
            this.btnGenerar.TabIndex = 32;
            this.btnGenerar.Text = "Visualizar";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(871, 17);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(67, 110);
            this.btnImprimir.TabIndex = 31;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(938, 17);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(67, 110);
            this.btnExportar.TabIndex = 33;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1005, 17);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 110);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(102, 103);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(85, 21);
            this.dtpFechaHasta.TabIndex = 22;
            this.dtpFechaHasta.Value = new System.DateTime(2018, 11, 28, 14, 54, 48, 0);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CalendarMonthBackground = System.Drawing.Color.Azure;
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(6, 103);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(85, 21);
            this.dtpFechaDesde.TabIndex = 20;
            this.dtpFechaDesde.Value = new System.DateTime(2018, 11, 28, 14, 54, 48, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Desde:";
            // 
            // dgvPrestamos
            // 
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AllowUserToResizeRows = false;
            this.dgvPrestamos.AutoGenerateColumns = false;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marcar,
            this.idAsociado,
            this.IdSolicitud,
            this.codigo,
            this.fecha,
            this.identidad,
            this.nombreCompleto,
            this.areaTrabajo,
            this.domicilio,
            this.estadoCivil,
            this.tipoEmpleado,
            this.telefono,
            this.cantSolicitada,
            this.aporte,
            this.credito,
            this.cantConsumo,
            this.cantAprobada,
            this.cuota,
            this.periodo,
            this.periodoSug,
            this.tasa,
            this.capitalizacion,
            this.motivo,
            this.aprobado,
            this.fechaAprobacion,
            this.Anulado,
            this.TipoSolicitud,
            this.Dependencia,
            this.Usuario});
            this.dgvPrestamos.ContextMenuStrip = this.CmsOpciones;
            this.dgvPrestamos.DataSource = this.sACSolicitudesDgvBindingSource;
            this.dgvPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestamos.Location = new System.Drawing.Point(0, 165);
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.RowHeadersWidth = 51;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(1075, 323);
            this.dgvPrestamos.TabIndex = 104;
            this.dgvPrestamos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPrestamos_DataError);
            this.dgvPrestamos.SelectionChanged += new System.EventHandler(this.dgvPrestamos_SelectionChanged);
            this.dgvPrestamos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPrestamos_MouseDown);
            // 
            // Marcar
            // 
            this.Marcar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Marcar.HeaderText = "X";
            this.Marcar.Name = "Marcar";
            this.Marcar.ReadOnly = true;
            this.Marcar.Width = 20;
            // 
            // idAsociado
            // 
            this.idAsociado.DataPropertyName = "IdAsociado";
            this.idAsociado.HeaderText = "IdAsociado";
            this.idAsociado.MinimumWidth = 6;
            this.idAsociado.Name = "idAsociado";
            this.idAsociado.ReadOnly = true;
            this.idAsociado.Visible = false;
            this.idAsociado.Width = 125;
            // 
            // IdSolicitud
            // 
            this.IdSolicitud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IdSolicitud.DataPropertyName = "IdSolicitud";
            this.IdSolicitud.HeaderText = "N°";
            this.IdSolicitud.MinimumWidth = 6;
            this.IdSolicitud.Name = "IdSolicitud";
            this.IdSolicitud.ReadOnly = true;
            this.IdSolicitud.Width = 44;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "CodigoAsociado";
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            this.codigo.Width = 125;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fecha.DataPropertyName = "FechaSolicitud";
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 66;
            // 
            // identidad
            // 
            this.identidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.identidad.DataPropertyName = "Identidad";
            this.identidad.HeaderText = "Identidad";
            this.identidad.MinimumWidth = 6;
            this.identidad.Name = "identidad";
            this.identidad.ReadOnly = true;
            this.identidad.Width = 87;
            // 
            // nombreCompleto
            // 
            this.nombreCompleto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreCompleto.DataPropertyName = "NombreCompleto";
            this.nombreCompleto.HeaderText = "Nombre";
            this.nombreCompleto.MinimumWidth = 6;
            this.nombreCompleto.Name = "nombreCompleto";
            this.nombreCompleto.ReadOnly = true;
            // 
            // areaTrabajo
            // 
            this.areaTrabajo.DataPropertyName = "AreaTrabajo";
            this.areaTrabajo.HeaderText = "Área de Trabajo";
            this.areaTrabajo.MinimumWidth = 6;
            this.areaTrabajo.Name = "areaTrabajo";
            this.areaTrabajo.ReadOnly = true;
            this.areaTrabajo.Visible = false;
            this.areaTrabajo.Width = 125;
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "Domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.MinimumWidth = 6;
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            this.domicilio.Visible = false;
            this.domicilio.Width = 125;
            // 
            // estadoCivil
            // 
            this.estadoCivil.DataPropertyName = "EstadoCivil";
            this.estadoCivil.HeaderText = "Estado Civil";
            this.estadoCivil.MinimumWidth = 6;
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.ReadOnly = true;
            this.estadoCivil.Visible = false;
            this.estadoCivil.Width = 125;
            // 
            // tipoEmpleado
            // 
            this.tipoEmpleado.DataPropertyName = "TipoEmpleado";
            this.tipoEmpleado.HeaderText = "Tipo de Empleado";
            this.tipoEmpleado.MinimumWidth = 6;
            this.tipoEmpleado.Name = "tipoEmpleado";
            this.tipoEmpleado.ReadOnly = true;
            this.tipoEmpleado.Visible = false;
            this.tipoEmpleado.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Visible = false;
            this.telefono.Width = 125;
            // 
            // cantSolicitada
            // 
            this.cantSolicitada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cantSolicitada.DataPropertyName = "CantSolicitada";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.cantSolicitada.DefaultCellStyle = dataGridViewCellStyle1;
            this.cantSolicitada.HeaderText = "Préstamo";
            this.cantSolicitada.MinimumWidth = 6;
            this.cantSolicitada.Name = "cantSolicitada";
            this.cantSolicitada.ReadOnly = true;
            this.cantSolicitada.Width = 82;
            // 
            // aporte
            // 
            this.aporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.aporte.DataPropertyName = "Aporte";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.aporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.aporte.HeaderText = "Aporte";
            this.aporte.MinimumWidth = 6;
            this.aporte.Name = "aporte";
            this.aporte.ReadOnly = true;
            this.aporte.Width = 68;
            // 
            // credito
            // 
            this.credito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.credito.DataPropertyName = "Credito";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.credito.DefaultCellStyle = dataGridViewCellStyle3;
            this.credito.HeaderText = "Crédito";
            this.credito.MinimumWidth = 6;
            this.credito.Name = "credito";
            this.credito.ReadOnly = true;
            this.credito.Width = 72;
            // 
            // cantConsumo
            // 
            this.cantConsumo.DataPropertyName = "CantConsumo";
            this.cantConsumo.HeaderText = "Cant. Consumo";
            this.cantConsumo.MinimumWidth = 6;
            this.cantConsumo.Name = "cantConsumo";
            this.cantConsumo.ReadOnly = true;
            this.cantConsumo.Visible = false;
            this.cantConsumo.Width = 125;
            // 
            // cantAprobada
            // 
            this.cantAprobada.DataPropertyName = "CantAprobada";
            this.cantAprobada.HeaderText = "Cant. Aprobada";
            this.cantAprobada.MinimumWidth = 6;
            this.cantAprobada.Name = "cantAprobada";
            this.cantAprobada.ReadOnly = true;
            this.cantAprobada.Visible = false;
            this.cantAprobada.Width = 125;
            // 
            // cuota
            // 
            this.cuota.DataPropertyName = "Cuota";
            this.cuota.HeaderText = "Cuota";
            this.cuota.MinimumWidth = 6;
            this.cuota.Name = "cuota";
            this.cuota.ReadOnly = true;
            this.cuota.Visible = false;
            this.cuota.Width = 125;
            // 
            // periodo
            // 
            this.periodo.DataPropertyName = "Periodo";
            this.periodo.HeaderText = "Período";
            this.periodo.MinimumWidth = 6;
            this.periodo.Name = "periodo";
            this.periodo.ReadOnly = true;
            this.periodo.Visible = false;
            this.periodo.Width = 125;
            // 
            // periodoSug
            // 
            this.periodoSug.DataPropertyName = "PeriodoSug";
            this.periodoSug.HeaderText = "Período Sug.";
            this.periodoSug.MinimumWidth = 6;
            this.periodoSug.Name = "periodoSug";
            this.periodoSug.ReadOnly = true;
            this.periodoSug.Visible = false;
            this.periodoSug.Width = 125;
            // 
            // tasa
            // 
            this.tasa.DataPropertyName = "Tasa";
            this.tasa.HeaderText = "Tasa";
            this.tasa.MinimumWidth = 6;
            this.tasa.Name = "tasa";
            this.tasa.ReadOnly = true;
            this.tasa.Visible = false;
            this.tasa.Width = 125;
            // 
            // capitalizacion
            // 
            this.capitalizacion.DataPropertyName = "Capitalizacion";
            this.capitalizacion.HeaderText = "Capitalización";
            this.capitalizacion.MinimumWidth = 6;
            this.capitalizacion.Name = "capitalizacion";
            this.capitalizacion.ReadOnly = true;
            this.capitalizacion.Visible = false;
            this.capitalizacion.Width = 125;
            // 
            // motivo
            // 
            this.motivo.DataPropertyName = "Motivo";
            this.motivo.HeaderText = "Motivo";
            this.motivo.MinimumWidth = 6;
            this.motivo.Name = "motivo";
            this.motivo.ReadOnly = true;
            this.motivo.Visible = false;
            this.motivo.Width = 125;
            // 
            // aprobado
            // 
            this.aprobado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aprobado.DataPropertyName = "Aprobado";
            this.aprobado.HeaderText = "Aprobado";
            this.aprobado.MinimumWidth = 6;
            this.aprobado.Name = "aprobado";
            this.aprobado.ReadOnly = true;
            this.aprobado.Width = 69;
            // 
            // fechaAprobacion
            // 
            this.fechaAprobacion.DataPropertyName = "FechaAprobacion";
            this.fechaAprobacion.HeaderText = "Fecha Aprob.";
            this.fechaAprobacion.MinimumWidth = 6;
            this.fechaAprobacion.Name = "fechaAprobacion";
            this.fechaAprobacion.ReadOnly = true;
            this.fechaAprobacion.Visible = false;
            this.fechaAprobacion.Width = 125;
            // 
            // Anulado
            // 
            this.Anulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Anulado.DataPropertyName = "Anulado";
            this.Anulado.HeaderText = "Anulado";
            this.Anulado.MinimumWidth = 6;
            this.Anulado.Name = "Anulado";
            this.Anulado.ReadOnly = true;
            this.Anulado.Width = 59;
            // 
            // TipoSolicitud
            // 
            this.TipoSolicitud.DataPropertyName = "TipoSolicitud";
            this.TipoSolicitud.HeaderText = "TipoSolicitud";
            this.TipoSolicitud.MinimumWidth = 6;
            this.TipoSolicitud.Name = "TipoSolicitud";
            this.TipoSolicitud.ReadOnly = true;
            this.TipoSolicitud.Visible = false;
            this.TipoSolicitud.Width = 125;
            // 
            // Dependencia
            // 
            this.Dependencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Dependencia.DataPropertyName = "Dependencia";
            this.Dependencia.HeaderText = "Dependencia";
            this.Dependencia.MinimumWidth = 6;
            this.Dependencia.Name = "Dependencia";
            this.Dependencia.ReadOnly = true;
            this.Dependencia.Width = 108;
            // 
            // Usuario
            // 
            this.Usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Width = 71;
            // 
            // CmsOpciones
            // 
            this.CmsOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.aprobarToolStripMenuItem,
            this.reversarAprobaciónToolStripMenuItem,
            this.anularToolStripMenuItem,
            this.reversarAnulaciónToolStripMenuItem});
            this.CmsOpciones.Name = "CmsOpciones";
            this.CmsOpciones.Size = new System.Drawing.Size(188, 134);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarToolStripMenuItem.Image")));
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // aprobarToolStripMenuItem
            // 
            this.aprobarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aprobarToolStripMenuItem.Image")));
            this.aprobarToolStripMenuItem.Name = "aprobarToolStripMenuItem";
            this.aprobarToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.aprobarToolStripMenuItem.Text = "Aprobar";
            this.aprobarToolStripMenuItem.Click += new System.EventHandler(this.aprobarToolStripMenuItem_Click);
            // 
            // reversarAprobaciónToolStripMenuItem
            // 
            this.reversarAprobaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reversarAprobaciónToolStripMenuItem.Image")));
            this.reversarAprobaciónToolStripMenuItem.Name = "reversarAprobaciónToolStripMenuItem";
            this.reversarAprobaciónToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.reversarAprobaciónToolStripMenuItem.Text = "Reversar Aprobación";
            this.reversarAprobaciónToolStripMenuItem.Click += new System.EventHandler(this.reversarAprobaciónToolStripMenuItem_Click);
            // 
            // anularToolStripMenuItem
            // 
            this.anularToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("anularToolStripMenuItem.Image")));
            this.anularToolStripMenuItem.Name = "anularToolStripMenuItem";
            this.anularToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.anularToolStripMenuItem.Text = "Anular";
            this.anularToolStripMenuItem.Click += new System.EventHandler(this.anularToolStripMenuItem_Click);
            // 
            // reversarAnulaciónToolStripMenuItem
            // 
            this.reversarAnulaciónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reversarAnulaciónToolStripMenuItem.Image")));
            this.reversarAnulaciónToolStripMenuItem.Name = "reversarAnulaciónToolStripMenuItem";
            this.reversarAnulaciónToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.reversarAnulaciónToolStripMenuItem.Text = "Reversar Anulación";
            this.reversarAnulaciónToolStripMenuItem.Click += new System.EventHandler(this.reversarAnulaciónToolStripMenuItem_Click);
            // 
            // sACSolicitudesDgvBindingSource
            // 
            this.sACSolicitudesDgvBindingSource.DataMember = "SAC_SolicitudesDgv";
            this.sACSolicitudesDgvBindingSource.DataSource = this.dsCodeasAdiggm;
            // 
            // dsCodeasAdiggm
            // 
            this.dsCodeasAdiggm.DataSetName = "DsCodeasAdiggm";
            this.dsCodeasAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gboDetalles
            // 
            this.gboDetalles.Controls.Add(this.gboDatosPres);
            this.gboDetalles.Controls.Add(this.gboParametros);
            this.gboDetalles.Controls.Add(this.gboDatosGen);
            this.gboDetalles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gboDetalles.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDetalles.Location = new System.Drawing.Point(0, 488);
            this.gboDetalles.Name = "gboDetalles";
            this.gboDetalles.Size = new System.Drawing.Size(1075, 136);
            this.gboDetalles.TabIndex = 105;
            this.gboDetalles.TabStop = false;
            this.gboDetalles.Text = "Más Detalles";
            // 
            // gboDatosPres
            // 
            this.gboDatosPres.Controls.Add(this.lblTipoSol);
            this.gboDatosPres.Controls.Add(this.pnlDatosPres);
            this.gboDatosPres.Controls.Add(this.label12);
            this.gboDatosPres.Controls.Add(this.txtMotivo);
            this.gboDatosPres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboDatosPres.Location = new System.Drawing.Point(403, 17);
            this.gboDatosPres.Name = "gboDatosPres";
            this.gboDatosPres.Size = new System.Drawing.Size(453, 116);
            this.gboDatosPres.TabIndex = 19;
            this.gboDatosPres.TabStop = false;
            this.gboDatosPres.Text = "Datos de la Solicitud";
            // 
            // lblTipoSol
            // 
            this.lblTipoSol.AutoSize = true;
            this.lblTipoSol.Location = new System.Drawing.Point(178, 70);
            this.lblTipoSol.Name = "lblTipoSol";
            this.lblTipoSol.Size = new System.Drawing.Size(0, 16);
            this.lblTipoSol.TabIndex = 28;
            // 
            // pnlDatosPres
            // 
            this.pnlDatosPres.Controls.Add(this.label14);
            this.pnlDatosPres.Controls.Add(this.label16);
            this.pnlDatosPres.Controls.Add(this.label6);
            this.pnlDatosPres.Controls.Add(this.txtFecAprob);
            this.pnlDatosPres.Controls.Add(this.txtCantConsumo);
            this.pnlDatosPres.Controls.Add(this.txtCuota);
            this.pnlDatosPres.Controls.Add(this.label13);
            this.pnlDatosPres.Controls.Add(this.txtCantAprob);
            this.pnlDatosPres.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDatosPres.Location = new System.Drawing.Point(3, 17);
            this.pnlDatosPres.Name = "pnlDatosPres";
            this.pnlDatosPres.Size = new System.Drawing.Size(447, 50);
            this.pnlDatosPres.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "Cant. Aprobada";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(338, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 16);
            this.label16.TabIndex = 26;
            this.label16.Text = "Aprobación";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cant. Consumo";
            // 
            // txtFecAprob
            // 
            this.txtFecAprob.Location = new System.Drawing.Point(337, 25);
            this.txtFecAprob.Name = "txtFecAprob";
            this.txtFecAprob.ReadOnly = true;
            this.txtFecAprob.Size = new System.Drawing.Size(75, 21);
            this.txtFecAprob.TabIndex = 25;
            this.txtFecAprob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCantConsumo
            // 
            this.txtCantConsumo.Location = new System.Drawing.Point(240, 25);
            this.txtCantConsumo.Name = "txtCantConsumo";
            this.txtCantConsumo.ReadOnly = true;
            this.txtCantConsumo.Size = new System.Drawing.Size(75, 21);
            this.txtCantConsumo.TabIndex = 6;
            this.txtCantConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(139, 25);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.ReadOnly = true;
            this.txtCuota.Size = new System.Drawing.Size(80, 21);
            this.txtCuota.TabIndex = 24;
            this.txtCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(158, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Cuota";
            // 
            // txtCantAprob
            // 
            this.txtCantAprob.Location = new System.Drawing.Point(39, 25);
            this.txtCantAprob.Name = "txtCantAprob";
            this.txtCantAprob.ReadOnly = true;
            this.txtCantAprob.Size = new System.Drawing.Size(80, 21);
            this.txtCantAprob.TabIndex = 22;
            this.txtCantAprob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Motivo de la Soliciutud";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(42, 89);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.ReadOnly = true;
            this.txtMotivo.Size = new System.Drawing.Size(373, 21);
            this.txtMotivo.TabIndex = 23;
            this.txtMotivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gboParametros
            // 
            this.gboParametros.Controls.Add(this.label15);
            this.gboParametros.Controls.Add(this.txtPeriodoSug);
            this.gboParametros.Controls.Add(this.label9);
            this.gboParametros.Controls.Add(this.label11);
            this.gboParametros.Controls.Add(this.label10);
            this.gboParametros.Controls.Add(this.txtPeriodo);
            this.gboParametros.Controls.Add(this.txtTasa);
            this.gboParametros.Controls.Add(this.txtCapitalizacion);
            this.gboParametros.Dock = System.Windows.Forms.DockStyle.Right;
            this.gboParametros.Location = new System.Drawing.Point(856, 17);
            this.gboParametros.Name = "gboParametros";
            this.gboParametros.Size = new System.Drawing.Size(216, 116);
            this.gboParametros.TabIndex = 20;
            this.gboParametros.TabStop = false;
            this.gboParametros.Text = "Parametrización";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 16);
            this.label15.TabIndex = 22;
            this.label15.Text = "Período Sugerido";
            // 
            // txtPeriodoSug
            // 
            this.txtPeriodoSug.Location = new System.Drawing.Point(131, 42);
            this.txtPeriodoSug.Name = "txtPeriodoSug";
            this.txtPeriodoSug.ReadOnly = true;
            this.txtPeriodoSug.Size = new System.Drawing.Size(50, 21);
            this.txtPeriodoSug.TabIndex = 23;
            this.txtPeriodoSug.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Período";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(113, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Capitalización";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tasa";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(38, 42);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(50, 21);
            this.txtPeriodo.TabIndex = 19;
            this.txtPeriodo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTasa
            // 
            this.txtTasa.Location = new System.Drawing.Point(38, 85);
            this.txtTasa.Name = "txtTasa";
            this.txtTasa.ReadOnly = true;
            this.txtTasa.Size = new System.Drawing.Size(50, 21);
            this.txtTasa.TabIndex = 21;
            this.txtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCapitalizacion
            // 
            this.txtCapitalizacion.Location = new System.Drawing.Point(131, 85);
            this.txtCapitalizacion.Name = "txtCapitalizacion";
            this.txtCapitalizacion.ReadOnly = true;
            this.txtCapitalizacion.Size = new System.Drawing.Size(50, 21);
            this.txtCapitalizacion.TabIndex = 20;
            this.txtCapitalizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gboDatosGen
            // 
            this.gboDatosGen.Controls.Add(this.label8);
            this.gboDatosGen.Controls.Add(this.label7);
            this.gboDatosGen.Controls.Add(this.label2);
            this.gboDatosGen.Controls.Add(this.label1);
            this.gboDatosGen.Controls.Add(this.label3);
            this.gboDatosGen.Controls.Add(this.txtDomicilio);
            this.gboDatosGen.Controls.Add(this.txtAreaTrab);
            this.gboDatosGen.Controls.Add(this.txtEstadoCivil);
            this.gboDatosGen.Controls.Add(this.txtTipoEmp);
            this.gboDatosGen.Controls.Add(this.txtTelefono);
            this.gboDatosGen.Dock = System.Windows.Forms.DockStyle.Left;
            this.gboDatosGen.Location = new System.Drawing.Point(3, 17);
            this.gboDatosGen.Name = "gboDatosGen";
            this.gboDatosGen.Size = new System.Drawing.Size(400, 116);
            this.gboDatosGen.TabIndex = 12;
            this.gboDatosGen.TabStop = false;
            this.gboDatosGen.Text = "Datos Generales";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Área de Trabajo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(233, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Domicilio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado Civil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Empleado";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(135, 89);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(250, 21);
            this.txtDomicilio.TabIndex = 10;
            this.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAreaTrab
            // 
            this.txtAreaTrab.Location = new System.Drawing.Point(14, 89);
            this.txtAreaTrab.Name = "txtAreaTrab";
            this.txtAreaTrab.ReadOnly = true;
            this.txtAreaTrab.Size = new System.Drawing.Size(115, 21);
            this.txtAreaTrab.TabIndex = 8;
            this.txtAreaTrab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Location = new System.Drawing.Point(118, 42);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.ReadOnly = true;
            this.txtEstadoCivil.Size = new System.Drawing.Size(120, 21);
            this.txtEstadoCivil.TabIndex = 2;
            this.txtEstadoCivil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTipoEmp
            // 
            this.txtTipoEmp.Location = new System.Drawing.Point(261, 42);
            this.txtTipoEmp.Name = "txtTipoEmp";
            this.txtTipoEmp.ReadOnly = true;
            this.txtTipoEmp.Size = new System.Drawing.Size(124, 21);
            this.txtTipoEmp.TabIndex = 4;
            this.txtTipoEmp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(14, 42);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(80, 21);
            this.txtTelefono.TabIndex = 0;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sAC_SolicitudesDgvTableAdapter
            // 
            this.sAC_SolicitudesDgvTableAdapter.ClearBeforeFill = true;
            // 
            // sAC_AsociadosTableAdapter
            // 
            this.sAC_AsociadosTableAdapter.ClearBeforeFill = true;
            // 
            // sAC_SolicitudesTableAdapter
            // 
            this.sAC_SolicitudesTableAdapter.ClearBeforeFill = true;
            // 
            // sAC_EstadoFinancieroTableAdapter
            // 
            this.sAC_EstadoFinancieroTableAdapter.ClearBeforeFill = true;
            // 
            // saC_AmortizacionesTableAdapter
            // 
            this.saC_AmortizacionesTableAdapter.ClearBeforeFill = true;
            // 
            // pR_R_SolicitudesTableAdapter
            // 
            this.pR_R_SolicitudesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVisorPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1075, 647);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.gboDetalles);
            this.Controls.Add(this.gboFiltro);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVisorPrestamos";
            this.Text = "Visor de Solicitudes de Préstamo";
            this.Load += new System.EventHandler(this.FrmVisorPrestamos_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.gboFiltro, 0);
            this.Controls.SetChildIndex(this.gboDetalles, 0);
            this.Controls.SetChildIndex(this.dgvPrestamos, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.gboFiltro.ResumeLayout(false);
            this.gboFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            this.CmsOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sACSolicitudesDgvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).EndInit();
            this.gboDetalles.ResumeLayout(false);
            this.gboDatosPres.ResumeLayout(false);
            this.gboDatosPres.PerformLayout();
            this.pnlDatosPres.ResumeLayout(false);
            this.pnlDatosPres.PerformLayout();
            this.gboParametros.ResumeLayout(false);
            this.gboParametros.PerformLayout();
            this.gboDatosGen.ResumeLayout(false);
            this.gboDatosGen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboFiltro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private DataSets.DsCodeasAdiggm dsCodeasAdiggm;
        private System.Windows.Forms.BindingSource sACSolicitudesDgvBindingSource;
        private DataSets.DsCodeasAdiggmTableAdapters.SAC_SolicitudesDgvTableAdapter sAC_SolicitudesDgvTableAdapter;
        private System.Windows.Forms.GroupBox gboDetalles;
        private System.Windows.Forms.ContextMenuStrip CmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprobarToolStripMenuItem;
        private System.Windows.Forms.RadioButton RdbRangoFecha;
        private System.Windows.Forms.RadioButton RdbCodigo;
        private System.Windows.Forms.MaskedTextBox mskCodigo;
        private System.Windows.Forms.ToolStripMenuItem anularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reversarAnulaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reversarAprobaciónToolStripMenuItem;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gboDatosGen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtAreaTrab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantConsumo;
        private System.Windows.Forms.TextBox txtTipoEmp;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.GroupBox gboDatosPres;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtFecAprob;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtCantAprob;
        private System.Windows.Forms.GroupBox gboParametros;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPeriodoSug;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtTasa;
        private System.Windows.Forms.TextBox txtCapitalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsociadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGenerar;
        private DataSets.DsCodeasAdiggmTableAdapters.SAC_AsociadosTableAdapter sAC_AsociadosTableAdapter;
        private DataSets.DsCodeasAdiggmTableAdapters.SAC_SolicitudesTableAdapter sAC_SolicitudesTableAdapter;
        private DataSets.DsCodeasAdiggmTableAdapters.SAC_EstadoFinancieroTableAdapter sAC_EstadoFinancieroTableAdapter;
        private DataSets.DsCodeasAdiggmTableAdapters.SAC_AmortizacionesTableAdapter saC_AmortizacionesTableAdapter;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Panel pnlDatosPres;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cboFDependencia;
        private System.Windows.Forms.Label lblTipoSol;
        private System.Windows.Forms.ComboBox cboPrinterList;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNSolHasta;
        private System.Windows.Forms.TextBox txtNSolDesde;
        private System.Windows.Forms.RadioButton RdbRangoSolicitud;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Marcar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsociado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantSolicitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn aporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantConsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantAprobada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoSug;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitalizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aprobado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAprobacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Anulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dependencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.Button button1;
        private DataSets.DsCodeasAdiggmTableAdapters.PR_R_SolicitudesTableAdapter pR_R_SolicitudesTableAdapter;
    }
}
