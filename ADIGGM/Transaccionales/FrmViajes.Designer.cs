namespace ADIGGM.Transaccionales
{
    partial class FrmViajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViajes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ptbIndRuta = new System.Windows.Forms.PictureBox();
            this.ptbIndVeh = new System.Windows.Forms.PictureBox();
            this.ptbIndTipoVeh = new System.Windows.Forms.PictureBox();
            this.ptbIndClaTra = new System.Windows.Forms.PictureBox();
            this.ptbIndCliente = new System.Windows.Forms.PictureBox();
            this.ptbInfoRuta = new System.Windows.Forms.PictureBox();
            this.ptbInfoVehiculo = new System.Windows.Forms.PictureBox();
            this.ptbInfoClaseTrab = new System.Windows.Forms.PictureBox();
            this.ptbInfoTipoVeh = new System.Windows.Forms.PictureBox();
            this.ptbInfoCliente = new System.Windows.Forms.PictureBox();
            this.mskNumBoleta = new System.Windows.Forms.MaskedTextBox();
            this.mskFecha = new System.Windows.Forms.MaskedTextBox();
            this.dtpFecMaxCierre = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTISV = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtMotorista = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblISV = new System.Windows.Forms.Label();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.cboPrefijos = new System.Windows.Forms.ComboBox();
            this.tRPrefijosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm1 = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblNumBoleta = new System.Windows.Forms.Label();
            this.lblClaseTrabajo = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.CboVehiculo = new System.Windows.Forms.ComboBox();
            this.tRVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.CboRutas = new System.Windows.Forms.ComboBox();
            this.tRRutasFiltradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CboTipoVehiculos = new System.Windows.Forms.ComboBox();
            this.tRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CboClaseTrabajos = new System.Windows.Forms.ComboBox();
            this.tRClaseTrabajosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CboClientes = new System.Windows.Forms.ComboBox();
            this.tRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tRViajesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tR_PrefijosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_PrefijosTableAdapter();
            this.tR_RutasFiltradasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_RutasFiltradasTableAdapter();
            this.tR_ViajesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ViajesTableAdapter();
            this.tR_ClientesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter();
            this.tR_ClaseTrabajosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClaseTrabajosTableAdapter();
            this.tR_TipoVehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter();
            this.tR_VehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_VehiculosTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndVeh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndTipoVeh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndClaTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoVehiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoClaseTrab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoTipoVeh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPrefijosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRRutasFiltradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClaseTrabajosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRViajesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(396, 0);
            this.btnMax.Visible = false;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(356, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(436, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(296, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 497);
            this.pnlFooter.Size = new System.Drawing.Size(476, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 63);
            this.panel1.TabIndex = 100;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(343, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 57);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(201, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 57);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(59, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 57);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.ptbIndRuta);
            this.panel2.Controls.Add(this.ptbIndVeh);
            this.panel2.Controls.Add(this.ptbIndTipoVeh);
            this.panel2.Controls.Add(this.ptbIndClaTra);
            this.panel2.Controls.Add(this.ptbIndCliente);
            this.panel2.Controls.Add(this.ptbInfoRuta);
            this.panel2.Controls.Add(this.ptbInfoVehiculo);
            this.panel2.Controls.Add(this.ptbInfoClaseTrab);
            this.panel2.Controls.Add(this.ptbInfoTipoVeh);
            this.panel2.Controls.Add(this.ptbInfoCliente);
            this.panel2.Controls.Add(this.mskNumBoleta);
            this.panel2.Controls.Add(this.mskFecha);
            this.panel2.Controls.Add(this.dtpFecMaxCierre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtSubtotal);
            this.panel2.Controls.Add(this.txtTISV);
            this.panel2.Controls.Add(this.lblCantidad);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.lblObservaciones);
            this.panel2.Controls.Add(this.txtObservaciones);
            this.panel2.Controls.Add(this.txtMotorista);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.lblISV);
            this.panel2.Controls.Add(this.txtISV);
            this.panel2.Controls.Add(this.lblTarifa);
            this.panel2.Controls.Add(this.txtTarifa);
            this.panel2.Controls.Add(this.cboPrefijos);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblVehiculo);
            this.panel2.Controls.Add(this.lblNumBoleta);
            this.panel2.Controls.Add(this.lblClaseTrabajo);
            this.panel2.Controls.Add(this.lblRuta);
            this.panel2.Controls.Add(this.lblTipoVehiculo);
            this.panel2.Controls.Add(this.lblCliente);
            this.panel2.Controls.Add(this.CboVehiculo);
            this.panel2.Controls.Add(this.CboRutas);
            this.panel2.Controls.Add(this.CboTipoVehiculos);
            this.panel2.Controls.Add(this.CboClaseTrabajos);
            this.panel2.Controls.Add(this.CboClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 399);
            this.panel2.TabIndex = 3;
            // 
            // ptbIndRuta
            // 
            this.ptbIndRuta.Location = new System.Drawing.Point(385, 186);
            this.ptbIndRuta.Name = "ptbIndRuta";
            this.ptbIndRuta.Size = new System.Drawing.Size(16, 16);
            this.ptbIndRuta.TabIndex = 42;
            this.ptbIndRuta.TabStop = false;
            this.ptbIndRuta.Visible = false;
            // 
            // ptbIndVeh
            // 
            this.ptbIndVeh.Location = new System.Drawing.Point(385, 160);
            this.ptbIndVeh.Name = "ptbIndVeh";
            this.ptbIndVeh.Size = new System.Drawing.Size(16, 16);
            this.ptbIndVeh.TabIndex = 41;
            this.ptbIndVeh.TabStop = false;
            this.ptbIndVeh.Visible = false;
            // 
            // ptbIndTipoVeh
            // 
            this.ptbIndTipoVeh.Location = new System.Drawing.Point(385, 134);
            this.ptbIndTipoVeh.Name = "ptbIndTipoVeh";
            this.ptbIndTipoVeh.Size = new System.Drawing.Size(16, 16);
            this.ptbIndTipoVeh.TabIndex = 40;
            this.ptbIndTipoVeh.TabStop = false;
            this.ptbIndTipoVeh.Visible = false;
            // 
            // ptbIndClaTra
            // 
            this.ptbIndClaTra.Location = new System.Drawing.Point(385, 108);
            this.ptbIndClaTra.Name = "ptbIndClaTra";
            this.ptbIndClaTra.Size = new System.Drawing.Size(16, 16);
            this.ptbIndClaTra.TabIndex = 39;
            this.ptbIndClaTra.TabStop = false;
            this.ptbIndClaTra.Visible = false;
            // 
            // ptbIndCliente
            // 
            this.ptbIndCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ptbIndCliente.Location = new System.Drawing.Point(385, 82);
            this.ptbIndCliente.Name = "ptbIndCliente";
            this.ptbIndCliente.Size = new System.Drawing.Size(16, 16);
            this.ptbIndCliente.TabIndex = 38;
            this.ptbIndCliente.TabStop = false;
            this.ptbIndCliente.Visible = false;
            // 
            // ptbInfoRuta
            // 
            this.ptbInfoRuta.BackColor = System.Drawing.Color.Transparent;
            this.ptbInfoRuta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbInfoRuta.BackgroundImage")));
            this.ptbInfoRuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbInfoRuta.Location = new System.Drawing.Point(402, 184);
            this.ptbInfoRuta.Name = "ptbInfoRuta";
            this.ptbInfoRuta.Size = new System.Drawing.Size(20, 20);
            this.ptbInfoRuta.TabIndex = 37;
            this.ptbInfoRuta.TabStop = false;
            this.ptbInfoRuta.Visible = false;
            // 
            // ptbInfoVehiculo
            // 
            this.ptbInfoVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.ptbInfoVehiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbInfoVehiculo.BackgroundImage")));
            this.ptbInfoVehiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbInfoVehiculo.Location = new System.Drawing.Point(402, 158);
            this.ptbInfoVehiculo.Name = "ptbInfoVehiculo";
            this.ptbInfoVehiculo.Size = new System.Drawing.Size(20, 20);
            this.ptbInfoVehiculo.TabIndex = 36;
            this.ptbInfoVehiculo.TabStop = false;
            this.ptbInfoVehiculo.Visible = false;
            // 
            // ptbInfoClaseTrab
            // 
            this.ptbInfoClaseTrab.BackColor = System.Drawing.Color.Transparent;
            this.ptbInfoClaseTrab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbInfoClaseTrab.BackgroundImage")));
            this.ptbInfoClaseTrab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbInfoClaseTrab.Location = new System.Drawing.Point(402, 106);
            this.ptbInfoClaseTrab.Name = "ptbInfoClaseTrab";
            this.ptbInfoClaseTrab.Size = new System.Drawing.Size(20, 20);
            this.ptbInfoClaseTrab.TabIndex = 35;
            this.ptbInfoClaseTrab.TabStop = false;
            this.ptbInfoClaseTrab.Visible = false;
            // 
            // ptbInfoTipoVeh
            // 
            this.ptbInfoTipoVeh.BackColor = System.Drawing.Color.Transparent;
            this.ptbInfoTipoVeh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbInfoTipoVeh.BackgroundImage")));
            this.ptbInfoTipoVeh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbInfoTipoVeh.Location = new System.Drawing.Point(402, 132);
            this.ptbInfoTipoVeh.Name = "ptbInfoTipoVeh";
            this.ptbInfoTipoVeh.Size = new System.Drawing.Size(20, 20);
            this.ptbInfoTipoVeh.TabIndex = 34;
            this.ptbInfoTipoVeh.TabStop = false;
            this.ptbInfoTipoVeh.Visible = false;
            // 
            // ptbInfoCliente
            // 
            this.ptbInfoCliente.BackColor = System.Drawing.Color.Transparent;
            this.ptbInfoCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbInfoCliente.BackgroundImage")));
            this.ptbInfoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ptbInfoCliente.Location = new System.Drawing.Point(402, 80);
            this.ptbInfoCliente.Name = "ptbInfoCliente";
            this.ptbInfoCliente.Size = new System.Drawing.Size(20, 20);
            this.ptbInfoCliente.TabIndex = 33;
            this.ptbInfoCliente.TabStop = false;
            this.ptbInfoCliente.Visible = false;
            // 
            // mskNumBoleta
            // 
            this.mskNumBoleta.BackColor = System.Drawing.Color.LightBlue;
            this.mskNumBoleta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNumBoleta.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskNumBoleta.Location = new System.Drawing.Point(202, 26);
            this.mskNumBoleta.Mask = "999999";
            this.mskNumBoleta.Name = "mskNumBoleta";
            this.mskNumBoleta.Size = new System.Drawing.Size(56, 21);
            this.mskNumBoleta.TabIndex = 2;
            this.mskNumBoleta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskNumBoleta.ValidatingType = typeof(int);
            this.mskNumBoleta.Enter += new System.EventHandler(this.mskNumBoleta_Enter);
            this.mskNumBoleta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskNumBoleta_KeyDown);
            this.mskNumBoleta.Validating += new System.ComponentModel.CancelEventHandler(this.mskNumBoleta_Validating);
            // 
            // mskFecha
            // 
            this.mskFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskFecha.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskFecha.Location = new System.Drawing.Point(136, 52);
            this.mskFecha.Mask = "00/00/0000";
            this.mskFecha.Name = "mskFecha";
            this.mskFecha.Size = new System.Drawing.Size(69, 21);
            this.mskFecha.TabIndex = 3;
            this.mskFecha.ValidatingType = typeof(System.DateTime);
            this.mskFecha.Enter += new System.EventHandler(this.mskFecha_Enter);
            this.mskFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskFecha_KeyDown);
            // 
            // dtpFecMaxCierre
            // 
            this.dtpFecMaxCierre.CustomFormat = "";
            this.dtpFecMaxCierre.Enabled = false;
            this.dtpFecMaxCierre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecMaxCierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecMaxCierre.Location = new System.Drawing.Point(301, 52);
            this.dtpFecMaxCierre.Name = "dtpFecMaxCierre";
            this.dtpFecMaxCierre.ShowUpDown = true;
            this.dtpFecMaxCierre.Size = new System.Drawing.Size(83, 21);
            this.dtpFecMaxCierre.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(211, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "F. Max. Cierre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(304, 230);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(80, 21);
            this.txtSubtotal.TabIndex = 29;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTISV
            // 
            this.txtTISV.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.txtTISV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTISV.Enabled = false;
            this.txtTISV.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTISV.Location = new System.Drawing.Point(304, 206);
            this.txtTISV.Name = "txtTISV";
            this.txtTISV.Size = new System.Drawing.Size(80, 21);
            this.txtTISV.TabIndex = 28;
            this.txtTISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(71, 236);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(59, 15);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(136, 230);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(60, 21);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.Enter += new System.EventHandler(this.txtCantidad_Enter);
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            this.txtCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.txtCantidad_Validating);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblObservaciones.Location = new System.Drawing.Point(37, 292);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(91, 15);
            this.lblObservaciones.TabIndex = 26;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtObservaciones.Location = new System.Drawing.Point(40, 310);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(393, 85);
            this.txtObservaciones.TabIndex = 10;
            // 
            // txtMotorista
            // 
            this.txtMotorista.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtMotorista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotorista.Enabled = false;
            this.txtMotorista.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotorista.Location = new System.Drawing.Point(236, 155);
            this.txtMotorista.Name = "txtMotorista";
            this.txtMotorista.ReadOnly = true;
            this.txtMotorista.Size = new System.Drawing.Size(148, 21);
            this.txtMotorista.TabIndex = 23;
            this.txtMotorista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(263, 256);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 15);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(304, 254);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(80, 21);
            this.txtTotal.TabIndex = 21;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblISV
            // 
            this.lblISV.AutoSize = true;
            this.lblISV.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblISV.Location = new System.Drawing.Point(216, 211);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(26, 15);
            this.lblISV.TabIndex = 23;
            this.lblISV.Text = "ISV:";
            // 
            // txtISV
            // 
            this.txtISV.BackColor = System.Drawing.Color.Orange;
            this.txtISV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISV.Enabled = false;
            this.txtISV.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISV.Location = new System.Drawing.Point(248, 206);
            this.txtISV.Name = "txtISV";
            this.txtISV.Size = new System.Drawing.Size(50, 21);
            this.txtISV.TabIndex = 19;
            this.txtISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifa.Location = new System.Drawing.Point(91, 211);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(39, 15);
            this.lblTarifa.TabIndex = 21;
            this.lblTarifa.Text = "Tarifa:";
            // 
            // txtTarifa
            // 
            this.txtTarifa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTarifa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTarifa.Enabled = false;
            this.txtTarifa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarifa.Location = new System.Drawing.Point(136, 206);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(74, 21);
            this.txtTarifa.TabIndex = 27;
            this.txtTarifa.Tag = "";
            this.txtTarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTarifa.TextChanged += new System.EventHandler(this.txtTarifa_TextChanged);
            // 
            // cboPrefijos
            // 
            this.cboPrefijos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboPrefijos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPrefijos.BackColor = System.Drawing.SystemColors.Window;
            this.cboPrefijos.DataSource = this.tRPrefijosBindingSource;
            this.cboPrefijos.DisplayMember = "Prefijo";
            this.cboPrefijos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPrefijos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPrefijos.FormattingEnabled = true;
            this.cboPrefijos.Location = new System.Drawing.Point(136, 26);
            this.cboPrefijos.Name = "cboPrefijos";
            this.cboPrefijos.Size = new System.Drawing.Size(60, 24);
            this.cboPrefijos.TabIndex = 1;
            this.cboPrefijos.ValueMember = "Prefijo";
            this.cboPrefijos.SelectedValueChanged += new System.EventHandler(this.cboPrefijos_SelectedValueChanged);
            this.cboPrefijos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboPrefijos_KeyDown);
            // 
            // tRPrefijosBindingSource
            // 
            this.tRPrefijosBindingSource.DataMember = "TR_Prefijos";
            this.tRPrefijosBindingSource.DataSource = this.dsTransporteAdiggm1;
            // 
            // dsTransporteAdiggm1
            // 
            this.dsTransporteAdiggm1.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(86, 55);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 15);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(71, 159);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(59, 15);
            this.lblVehiculo.TabIndex = 19;
            this.lblVehiculo.Text = "Vehículo:";
            // 
            // lblNumBoleta
            // 
            this.lblNumBoleta.AutoSize = true;
            this.lblNumBoleta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumBoleta.Location = new System.Drawing.Point(55, 29);
            this.lblNumBoleta.Name = "lblNumBoleta";
            this.lblNumBoleta.Size = new System.Drawing.Size(75, 15);
            this.lblNumBoleta.TabIndex = 14;
            this.lblNumBoleta.Text = "Núm. Boleta:";
            // 
            // lblClaseTrabajo
            // 
            this.lblClaseTrabajo.AutoSize = true;
            this.lblClaseTrabajo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaseTrabajo.Location = new System.Drawing.Point(30, 107);
            this.lblClaseTrabajo.Name = "lblClaseTrabajo";
            this.lblClaseTrabajo.Size = new System.Drawing.Size(100, 15);
            this.lblClaseTrabajo.TabIndex = 17;
            this.lblClaseTrabajo.Text = "Clase de Trabajo:";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.Location = new System.Drawing.Point(96, 185);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(34, 15);
            this.lblRuta.TabIndex = 20;
            this.lblRuta.Text = "Ruta:";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(29, 133);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(101, 15);
            this.lblTipoVehiculo.TabIndex = 18;
            this.lblTipoVehiculo.Text = "Tipo de Vehículo:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(82, 81);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 15);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "Cliente:";
            // 
            // CboVehiculo
            // 
            this.CboVehiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CboVehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboVehiculo.DataSource = this.tRVehiculosBindingSource;
            this.CboVehiculo.DisplayMember = "CodVehiculo";
            this.CboVehiculo.DropDownHeight = 140;
            this.CboVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboVehiculo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboVehiculo.FormattingEnabled = true;
            this.CboVehiculo.IntegralHeight = false;
            this.CboVehiculo.Location = new System.Drawing.Point(136, 154);
            this.CboVehiculo.Name = "CboVehiculo";
            this.CboVehiculo.Size = new System.Drawing.Size(94, 24);
            this.CboVehiculo.TabIndex = 7;
            this.CboVehiculo.ValueMember = "IdVehiculo";
            this.CboVehiculo.SelectedValueChanged += new System.EventHandler(this.CboVehiculo_SelectedValueChanged);
            this.CboVehiculo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboVehiculo_KeyDown);
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
            // CboRutas
            // 
            this.CboRutas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CboRutas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboRutas.DataSource = this.tRRutasFiltradasBindingSource;
            this.CboRutas.DisplayMember = "Ruta";
            this.CboRutas.DropDownHeight = 130;
            this.CboRutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboRutas.DropDownWidth = 363;
            this.CboRutas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboRutas.FormattingEnabled = true;
            this.CboRutas.IntegralHeight = false;
            this.CboRutas.Location = new System.Drawing.Point(136, 180);
            this.CboRutas.Name = "CboRutas";
            this.CboRutas.Size = new System.Drawing.Size(248, 24);
            this.CboRutas.TabIndex = 8;
            this.CboRutas.ValueMember = "IdRuta";
            this.CboRutas.SelectedValueChanged += new System.EventHandler(this.CboRutas_SelectedValueChanged);
            this.CboRutas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboRutas_KeyDown);
            // 
            // tRRutasFiltradasBindingSource
            // 
            this.tRRutasFiltradasBindingSource.DataMember = "TR_RutasFiltradas";
            this.tRRutasFiltradasBindingSource.DataSource = this.dsTransporteAdiggm1;
            // 
            // CboTipoVehiculos
            // 
            this.CboTipoVehiculos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CboTipoVehiculos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboTipoVehiculos.DataSource = this.tRTipoVehiculosBindingSource;
            this.CboTipoVehiculos.DisplayMember = "TipoVehiculo";
            this.CboTipoVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoVehiculos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoVehiculos.FormattingEnabled = true;
            this.CboTipoVehiculos.Location = new System.Drawing.Point(136, 128);
            this.CboTipoVehiculos.Name = "CboTipoVehiculos";
            this.CboTipoVehiculos.Size = new System.Drawing.Size(248, 24);
            this.CboTipoVehiculos.TabIndex = 6;
            this.CboTipoVehiculos.ValueMember = "IdTipoVehiculo";
            this.CboTipoVehiculos.SelectedValueChanged += new System.EventHandler(this.CboTipoVehiculos_SelectedValueChanged);
            this.CboTipoVehiculos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboTipoVehiculos_KeyDown);
            // 
            // tRTipoVehiculosBindingSource
            // 
            this.tRTipoVehiculosBindingSource.DataMember = "TR_TipoVehiculos";
            this.tRTipoVehiculosBindingSource.DataSource = this.dsTransporteAdiggm1;
            // 
            // CboClaseTrabajos
            // 
            this.CboClaseTrabajos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CboClaseTrabajos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboClaseTrabajos.DataSource = this.tRClaseTrabajosBindingSource;
            this.CboClaseTrabajos.DisplayMember = "ClaseTrabajo";
            this.CboClaseTrabajos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboClaseTrabajos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboClaseTrabajos.FormattingEnabled = true;
            this.CboClaseTrabajos.Location = new System.Drawing.Point(136, 102);
            this.CboClaseTrabajos.Name = "CboClaseTrabajos";
            this.CboClaseTrabajos.Size = new System.Drawing.Size(248, 24);
            this.CboClaseTrabajos.TabIndex = 5;
            this.CboClaseTrabajos.ValueMember = "IdClaseTrabajo";
            this.CboClaseTrabajos.SelectedValueChanged += new System.EventHandler(this.CboClaseTrabajos_SelectedValueChanged);
            this.CboClaseTrabajos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboClaseTrabajos_KeyDown);
            // 
            // tRClaseTrabajosBindingSource
            // 
            this.tRClaseTrabajosBindingSource.DataMember = "TR_ClaseTrabajos";
            this.tRClaseTrabajosBindingSource.DataSource = this.dsTransporteAdiggm1;
            // 
            // CboClientes
            // 
            this.CboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CboClientes.DataSource = this.tRClientesBindingSource;
            this.CboClientes.DisplayMember = "Cliente";
            this.CboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboClientes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboClientes.FormattingEnabled = true;
            this.CboClientes.Location = new System.Drawing.Point(136, 76);
            this.CboClientes.Name = "CboClientes";
            this.CboClientes.Size = new System.Drawing.Size(248, 24);
            this.CboClientes.TabIndex = 4;
            this.CboClientes.ValueMember = "IdCliente";
            this.CboClientes.SelectedValueChanged += new System.EventHandler(this.CboClientes_SelectedValueChanged);
            this.CboClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboClientes_KeyDown);
            // 
            // tRClientesBindingSource
            // 
            this.tRClientesBindingSource.DataMember = "TR_Clientes";
            this.tRClientesBindingSource.DataSource = this.dsTransporteAdiggm1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tRViajesBindingSource
            // 
            this.tRViajesBindingSource.DataMember = "TR_Viajes";
            this.tRViajesBindingSource.DataSource = this.dsTransporteAdiggm1;
            // 
            // tR_PrefijosTableAdapter
            // 
            this.tR_PrefijosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_RutasFiltradasTableAdapter
            // 
            this.tR_RutasFiltradasTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ViajesTableAdapter
            // 
            this.tR_ViajesTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ClientesTableAdapter
            // 
            this.tR_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ClaseTrabajosTableAdapter
            // 
            this.tR_ClaseTrabajosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_TipoVehiculosTableAdapter
            // 
            this.tR_TipoVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_VehiculosTableAdapter
            // 
            this.tR_VehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ttInfo
            // 
            this.ttInfo.IsBalloon = true;
            // 
            // FrmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(476, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmViajes";
            this.Text = "Viajes";
            this.Load += new System.EventHandler(this.FrmViajes_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndVeh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndTipoVeh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndClaTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIndCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoVehiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoClaseTrab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoTipoVeh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInfoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPrefijosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRRutasFiltradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClaseTrabajosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRViajesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CboTipoVehiculos;
        private System.Windows.Forms.ComboBox CboClaseTrabajos;
        private System.Windows.Forms.ComboBox CboClientes;
        private System.Windows.Forms.ComboBox CboRutas;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label lblNumBoleta;
        private System.Windows.Forms.Label lblClaseTrabajo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox CboVehiculo;
        private System.Windows.Forms.ComboBox cboPrefijos;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.TextBox txtMotorista;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.Label lblTarifa;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm1;
        private System.Windows.Forms.BindingSource tRPrefijosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_PrefijosTableAdapter tR_PrefijosTableAdapter;
        private System.Windows.Forms.BindingSource tRRutasFiltradasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_RutasFiltradasTableAdapter tR_RutasFiltradasTableAdapter;
        private System.Windows.Forms.TextBox txtTISV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource tRViajesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ViajesTableAdapter tR_ViajesTableAdapter;
        private System.Windows.Forms.BindingSource tRClientesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter tR_ClientesTableAdapter;
        private System.Windows.Forms.BindingSource tRClaseTrabajosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClaseTrabajosTableAdapter tR_ClaseTrabajosTableAdapter;
        private System.Windows.Forms.BindingSource tRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter tR_TipoVehiculosTableAdapter;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_VehiculosTableAdapter tR_VehiculosTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpFecMaxCierre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskFecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MaskedTextBox mskNumBoleta;
        private System.Windows.Forms.PictureBox ptbInfoCliente;
        private System.Windows.Forms.PictureBox ptbInfoRuta;
        private System.Windows.Forms.PictureBox ptbInfoVehiculo;
        private System.Windows.Forms.PictureBox ptbInfoClaseTrab;
        private System.Windows.Forms.PictureBox ptbInfoTipoVeh;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.PictureBox ptbIndRuta;
        private System.Windows.Forms.PictureBox ptbIndVeh;
        private System.Windows.Forms.PictureBox ptbIndTipoVeh;
        private System.Windows.Forms.PictureBox ptbIndClaTra;
        private System.Windows.Forms.PictureBox ptbIndCliente;
    }
}
