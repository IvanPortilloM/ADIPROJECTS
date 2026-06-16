namespace ADIGGM.Mantenimiento
{
    partial class FrmSyncTransCod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSyncTransCod));
            this.gboHeader = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnActualizarHeader = new System.Windows.Forms.Button();
            this.btnBuscarCierre = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerificarCta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSync = new System.Windows.Forms.Button();
            this.txtVistaPrev = new System.Windows.Forms.TextBox();
            this.txtCodTipAsiento = new System.Windows.Forms.TextBox();
            this.cODSlcTipoAsientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTipoAsiento = new System.Windows.Forms.ComboBox();
            this.txtAbvFac = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetHeader = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumAsiento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvAsiento = new System.Windows.Forms.DataGridView();
            this.pRSyncTransCodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHaber = new System.Windows.Forms.TextBox();
            this.txtDebe = new System.Windows.Forms.TextBox();
            this.pnlFooter.SuspendLayout();
            this.gboHeader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcTipoAsientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSyncTransCodBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(1087, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(1047, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(1127, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(987, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 500);
            this.pnlFooter.Size = new System.Drawing.Size(1167, 23);
            // 
            // gboHeader
            // 
            this.gboHeader.Controls.Add(this.label4);
            this.gboHeader.Controls.Add(this.groupBox2);
            this.gboHeader.Controls.Add(this.groupBox3);
            this.gboHeader.Controls.Add(this.groupBox1);
            this.gboHeader.Controls.Add(this.txtVistaPrev);
            this.gboHeader.Controls.Add(this.txtCodTipAsiento);
            this.gboHeader.Controls.Add(this.cboTipoAsiento);
            this.gboHeader.Controls.Add(this.txtAbvFac);
            this.gboHeader.Controls.Add(this.label8);
            this.gboHeader.Controls.Add(this.label7);
            this.gboHeader.Controls.Add(this.txtFactura);
            this.gboHeader.Controls.Add(this.label5);
            this.gboHeader.Controls.Add(this.label3);
            this.gboHeader.Controls.Add(this.txtDetHeader);
            this.gboHeader.Controls.Add(this.label2);
            this.gboHeader.Controls.Add(this.txtNumAsiento);
            this.gboHeader.Controls.Add(this.label1);
            this.gboHeader.Controls.Add(this.dtpFecha);
            this.gboHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboHeader.Location = new System.Drawing.Point(0, 35);
            this.gboHeader.Name = "gboHeader";
            this.gboHeader.Size = new System.Drawing.Size(1167, 163);
            this.gboHeader.TabIndex = 103;
            this.gboHeader.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Vista Previa del Encabezado:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnActualizarHeader);
            this.groupBox2.Controls.Add(this.btnBuscarCierre);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(705, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 143);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paso #1: Elegir Cierre";
            // 
            // btnActualizarHeader
            // 
            this.btnActualizarHeader.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarHeader.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnActualizarHeader.FlatAppearance.BorderSize = 0;
            this.btnActualizarHeader.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActualizarHeader.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActualizarHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarHeader.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarHeader.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarHeader.Image")));
            this.btnActualizarHeader.Location = new System.Drawing.Point(61, 68);
            this.btnActualizarHeader.Name = "btnActualizarHeader";
            this.btnActualizarHeader.Size = new System.Drawing.Size(82, 69);
            this.btnActualizarHeader.TabIndex = 15;
            this.btnActualizarHeader.Text = "Actualizar Encabezado";
            this.btnActualizarHeader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizarHeader.UseVisualStyleBackColor = false;
            this.btnActualizarHeader.Click += new System.EventHandler(this.btnActualizarHeader_Click);
            // 
            // btnBuscarCierre
            // 
            this.btnBuscarCierre.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCierre.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnBuscarCierre.FlatAppearance.BorderSize = 0;
            this.btnBuscarCierre.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBuscarCierre.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCierre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCierre.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCierre.Image")));
            this.btnBuscarCierre.Location = new System.Drawing.Point(0, 20);
            this.btnBuscarCierre.Name = "btnBuscarCierre";
            this.btnBuscarCierre.Size = new System.Drawing.Size(55, 69);
            this.btnBuscarCierre.TabIndex = 24;
            this.btnBuscarCierre.Text = "Buscar Cierre";
            this.btnBuscarCierre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscarCierre.UseVisualStyleBackColor = false;
            this.btnBuscarCierre.Click += new System.EventHandler(this.btnBuscarCierre_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerificarCta);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(858, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 143);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paso #2: Verificar Datos";
            // 
            // btnVerificarCta
            // 
            this.btnVerificarCta.BackColor = System.Drawing.Color.Transparent;
            this.btnVerificarCta.Enabled = false;
            this.btnVerificarCta.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnVerificarCta.FlatAppearance.BorderSize = 0;
            this.btnVerificarCta.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVerificarCta.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVerificarCta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificarCta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificarCta.Image = ((System.Drawing.Image)(resources.GetObject("btnVerificarCta.Image")));
            this.btnVerificarCta.Location = new System.Drawing.Point(49, 42);
            this.btnVerificarCta.Name = "btnVerificarCta";
            this.btnVerificarCta.Size = new System.Drawing.Size(61, 69);
            this.btnVerificarCta.TabIndex = 24;
            this.btnVerificarCta.Text = "Verificar Cuentas";
            this.btnVerificarCta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVerificarCta.UseVisualStyleBackColor = false;
            this.btnVerificarCta.Click += new System.EventHandler(this.btnVerificarCta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSync);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(1011, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 143);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paso #3: Sincronizar con CODEAS";
            // 
            // btnSync
            // 
            this.btnSync.BackColor = System.Drawing.Color.Transparent;
            this.btnSync.Enabled = false;
            this.btnSync.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSync.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.Location = new System.Drawing.Point(40, 42);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(76, 69);
            this.btnSync.TabIndex = 17;
            this.btnSync.Text = "Sincronizar CODEAS";
            this.btnSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSync.UseVisualStyleBackColor = false;
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // txtVistaPrev
            // 
            this.txtVistaPrev.Location = new System.Drawing.Point(180, 97);
            this.txtVistaPrev.Multiline = true;
            this.txtVistaPrev.Name = "txtVistaPrev";
            this.txtVistaPrev.ReadOnly = true;
            this.txtVistaPrev.Size = new System.Drawing.Size(411, 54);
            this.txtVistaPrev.TabIndex = 29;
            // 
            // txtCodTipAsiento
            // 
            this.txtCodTipAsiento.BackColor = System.Drawing.Color.CornflowerBlue;
            this.txtCodTipAsiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cODSlcTipoAsientoBindingSource, "ctipasient", true));
            this.txtCodTipAsiento.Enabled = false;
            this.txtCodTipAsiento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodTipAsiento.Location = new System.Drawing.Point(177, 43);
            this.txtCodTipAsiento.Name = "txtCodTipAsiento";
            this.txtCodTipAsiento.ReadOnly = true;
            this.txtCodTipAsiento.Size = new System.Drawing.Size(50, 21);
            this.txtCodTipAsiento.TabIndex = 26;
            this.txtCodTipAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboTipoAsiento
            // 
            this.cboTipoAsiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTipoAsiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoAsiento.DataSource = this.cODSlcTipoAsientoBindingSource;
            this.cboTipoAsiento.DisplayMember = "cdesasien";
            this.cboTipoAsiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAsiento.FormattingEnabled = true;
            this.cboTipoAsiento.Location = new System.Drawing.Point(104, 13);
            this.cboTipoAsiento.Name = "cboTipoAsiento";
            this.cboTipoAsiento.Size = new System.Drawing.Size(174, 24);
            this.cboTipoAsiento.TabIndex = 25;
            this.cboTipoAsiento.ValueMember = "ctipasient";
            // 
            // txtAbvFac
            // 
            this.txtAbvFac.Location = new System.Drawing.Point(459, 43);
            this.txtAbvFac.Name = "txtAbvFac";
            this.txtAbvFac.Size = new System.Drawing.Size(132, 21);
            this.txtAbvFac.TabIndex = 23;
            this.txtAbvFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "N° Doc.*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "N° Factura*:";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(405, 13);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(186, 21);
            this.txtFactura.TabIndex = 20;
            this.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFactura.TextChanged += new System.EventHandler(this.txtFactura_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Detalle*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fecha:";
            // 
            // txtDetHeader
            // 
            this.txtDetHeader.Location = new System.Drawing.Point(104, 70);
            this.txtDetHeader.Name = "txtDetHeader";
            this.txtDetHeader.Size = new System.Drawing.Size(487, 21);
            this.txtDetHeader.TabIndex = 6;
            this.txtDetHeader.TextChanged += new System.EventHandler(this.txtDetHeader_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "N° de Asiento:";
            // 
            // txtNumAsiento
            // 
            this.txtNumAsiento.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtNumAsiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cODSlcTipoAsientoBindingSource, "nconsecuti", true));
            this.txtNumAsiento.Enabled = false;
            this.txtNumAsiento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumAsiento.Location = new System.Drawing.Point(104, 43);
            this.txtNumAsiento.Name = "txtNumAsiento";
            this.txtNumAsiento.ReadOnly = true;
            this.txtNumAsiento.Size = new System.Drawing.Size(72, 21);
            this.txtNumAsiento.TabIndex = 4;
            this.txtNumAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Asiento:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(284, 43);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 21);
            this.dtpFecha.TabIndex = 2;
            // 
            // dgvAsiento
            // 
            this.dgvAsiento.AllowUserToAddRows = false;
            this.dgvAsiento.AllowUserToDeleteRows = false;
            this.dgvAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // Las columnas se definen en codigo (ConfigurarColumnas), no aqui, para que el disenador de VS no las borre.
            this.dgvAsiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsiento.Location = new System.Drawing.Point(0, 198);
            this.dgvAsiento.Name = "dgvAsiento";
            this.dgvAsiento.ReadOnly = true;
            this.dgvAsiento.Size = new System.Drawing.Size(1167, 250);
            this.dgvAsiento.TabIndex = 104;
            //
            // pRSyncTransCodBindingSource
            //
            this.pRSyncTransCodBindingSource.DataMember = "PR_SyncTransCod";
            //
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtDif);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtHaber);
            this.groupBox4.Controls.Add(this.txtDebe);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox4.Location = new System.Drawing.Point(0, 448);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1167, 52);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Más Detalles";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1097, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Diferencia:";
            // 
            // txtDif
            // 
            this.txtDif.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtDif.Enabled = false;
            this.txtDif.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDif.Location = new System.Drawing.Point(1091, 30);
            this.txtDif.Name = "txtDif";
            this.txtDif.ReadOnly = true;
            this.txtDif.Size = new System.Drawing.Size(70, 21);
            this.txtDif.TabIndex = 41;
            this.txtDif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1037, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Haber:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(964, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Debe:";
            // 
            // txtHaber
            // 
            this.txtHaber.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtHaber.Enabled = false;
            this.txtHaber.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHaber.Location = new System.Drawing.Point(1020, 30);
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.ReadOnly = true;
            this.txtHaber.Size = new System.Drawing.Size(70, 21);
            this.txtHaber.TabIndex = 38;
            this.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDebe
            // 
            this.txtDebe.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtDebe.Enabled = false;
            this.txtDebe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebe.Location = new System.Drawing.Point(949, 30);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.ReadOnly = true;
            this.txtDebe.Size = new System.Drawing.Size(70, 21);
            this.txtDebe.TabIndex = 37;
            this.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmSyncTransCod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1167, 523);
            this.Controls.Add(this.dgvAsiento);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gboHeader);
            this.Name = "FrmSyncTransCod";
            this.Load += new System.EventHandler(this.FrmSyncTransCod_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.gboHeader, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.dgvAsiento, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.gboHeader.ResumeLayout(false);
            this.gboHeader.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcTipoAsientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSyncTransCodBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboHeader;
        private System.Windows.Forms.TextBox txtDetHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumAsiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvAsiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnActualizarHeader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAbvFac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Button btnBuscarCierre;
        private System.Windows.Forms.BindingSource pRSyncTransCodBindingSource;
        private System.Windows.Forms.ComboBox cboTipoAsiento;
        private System.Windows.Forms.BindingSource cODSlcTipoAsientoBindingSource;
        private System.Windows.Forms.TextBox txtCodTipAsiento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVistaPrev;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVerificarCta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHaber;
        private System.Windows.Forms.TextBox txtDebe;
    }
}
