namespace ADIGGM.Mantenimiento
{
    partial class FrmCierreCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCierreCliente));
            this.dgvCierreCliente = new System.Windows.Forms.DataGridView();
            this.idCierreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCierrePK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.idTipoVehiculo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SubTotalCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISVCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cerrado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SynCodeas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.anulado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reversarCerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aplicarISVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarISVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRCierreClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKTRCierreClientesTRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTipoVeh = new System.Windows.Forms.ComboBox();
            this.tRTipoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodeasAdiggm = new ADIGGM.DataSets.DsCodeasAdiggm();
            this.tR_TipoVehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter();
            this.tR_CierreClientesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_CierreClientesTableAdapter();
            this.tR_ClientesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.tR_TipoFacturasTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.TR_TipoFacturasTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal2 = new System.Windows.Forms.TextBox();
            this.txtISV2 = new System.Windows.Forms.TextBox();
            this.txtSubtotal2 = new System.Windows.Forms.TextBox();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierreCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).BeginInit();
            this.cmsOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRCierreClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRCierreClientesTRTipoVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Size = new System.Drawing.Size(296, 19);
            this.lblFooter.Text = "Cierre por Clientes y Tipo de Vehículo";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(760, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(720, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(800, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(660, 0);
            this.pgbProcesos.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 485);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Size = new System.Drawing.Size(840, 23);
            // 
            // dgvCierreCliente
            // 
            this.dgvCierreCliente.AllowUserToAddRows = false;
            this.dgvCierreCliente.AllowUserToDeleteRows = false;
            this.dgvCierreCliente.AutoGenerateColumns = false;
            this.dgvCierreCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCierreCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCierreCliente,
            this.IdTipoFactura,
            this.idCierrePK,
            this.idCliente,
            this.idTipoVehiculo,
            this.SubTotalCierre,
            this.ISVCierre,
            this.totalCierre,
            this.cerrado,
            this.SynCodeas,
            this.anulado});
            this.dgvCierreCliente.ContextMenuStrip = this.cmsOpciones;
            this.dgvCierreCliente.DataSource = this.tRCierreClientesBindingSource;
            this.dgvCierreCliente.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCierreCliente.Location = new System.Drawing.Point(0, 129);
            this.dgvCierreCliente.Name = "dgvCierreCliente";
            this.dgvCierreCliente.ReadOnly = true;
            this.dgvCierreCliente.RowHeadersWidth = 51;
            this.dgvCierreCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCierreCliente.Size = new System.Drawing.Size(840, 356);
            this.dgvCierreCliente.TabIndex = 103;
            this.dgvCierreCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCierreCliente_CellClick);
            this.dgvCierreCliente.SelectionChanged += new System.EventHandler(this.dgvCierreCliente_SelectionChanged);
            this.dgvCierreCliente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCierreCliente_MouseDown);
            // 
            // idCierreCliente
            // 
            this.idCierreCliente.DataPropertyName = "IdCierreCliente";
            this.idCierreCliente.HeaderText = "IdCierreCliente";
            this.idCierreCliente.MinimumWidth = 6;
            this.idCierreCliente.Name = "idCierreCliente";
            this.idCierreCliente.ReadOnly = true;
            this.idCierreCliente.Visible = false;
            this.idCierreCliente.Width = 125;
            // 
            // IdTipoFactura
            // 
            this.IdTipoFactura.DataPropertyName = "IdTipoFactura";
            this.IdTipoFactura.HeaderText = "IdTipoFactura";
            this.IdTipoFactura.MinimumWidth = 6;
            this.IdTipoFactura.Name = "IdTipoFactura";
            this.IdTipoFactura.ReadOnly = true;
            this.IdTipoFactura.Visible = false;
            this.IdTipoFactura.Width = 125;
            // 
            // idCierrePK
            // 
            this.idCierrePK.DataPropertyName = "IdCierre";
            this.idCierrePK.HeaderText = "IdCierre";
            this.idCierrePK.MinimumWidth = 6;
            this.idCierrePK.Name = "idCierrePK";
            this.idCierrePK.ReadOnly = true;
            this.idCierrePK.Visible = false;
            this.idCierrePK.Width = 125;
            // 
            // idCliente
            // 
            this.idCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCliente.DataPropertyName = "IdCliente";
            this.idCliente.DataSource = this.tRClientesBindingSource;
            this.idCliente.DisplayMember = "Cliente";
            this.idCliente.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idCliente.HeaderText = "Cliente";
            this.idCliente.MinimumWidth = 6;
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCliente.ValueMember = "IdCliente";
            // 
            // tRClientesBindingSource
            // 
            this.tRClientesBindingSource.DataMember = "TR_Clientes";
            this.tRClientesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTipoVehiculo
            // 
            this.idTipoVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idTipoVehiculo.DataPropertyName = "IdTipoVehiculo";
            this.idTipoVehiculo.DataSource = this.tRTipoVehiculosBindingSource;
            this.idTipoVehiculo.DisplayMember = "TipoVehiculo";
            this.idTipoVehiculo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idTipoVehiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idTipoVehiculo.HeaderText = "Tipo Vehículo";
            this.idTipoVehiculo.MinimumWidth = 6;
            this.idTipoVehiculo.Name = "idTipoVehiculo";
            this.idTipoVehiculo.ReadOnly = true;
            this.idTipoVehiculo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTipoVehiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idTipoVehiculo.ValueMember = "IdTipoVehiculo";
            // 
            // tRTipoVehiculosBindingSource
            // 
            this.tRTipoVehiculosBindingSource.DataMember = "TR_TipoVehiculos";
            this.tRTipoVehiculosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // SubTotalCierre
            // 
            this.SubTotalCierre.DataPropertyName = "SubTotalCierre";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.SubTotalCierre.DefaultCellStyle = dataGridViewCellStyle1;
            this.SubTotalCierre.HeaderText = "Sub Total";
            this.SubTotalCierre.MinimumWidth = 6;
            this.SubTotalCierre.Name = "SubTotalCierre";
            this.SubTotalCierre.ReadOnly = true;
            this.SubTotalCierre.Width = 125;
            // 
            // ISVCierre
            // 
            this.ISVCierre.DataPropertyName = "ISVCierre";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ISVCierre.DefaultCellStyle = dataGridViewCellStyle2;
            this.ISVCierre.HeaderText = "ISV";
            this.ISVCierre.MinimumWidth = 6;
            this.ISVCierre.Name = "ISVCierre";
            this.ISVCierre.ReadOnly = true;
            this.ISVCierre.Width = 125;
            // 
            // totalCierre
            // 
            this.totalCierre.DataPropertyName = "TotalCierre";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.totalCierre.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalCierre.HeaderText = "Total";
            this.totalCierre.MinimumWidth = 6;
            this.totalCierre.Name = "totalCierre";
            this.totalCierre.ReadOnly = true;
            this.totalCierre.Width = 93;
            // 
            // cerrado
            // 
            this.cerrado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cerrado.DataPropertyName = "Cerrado";
            this.cerrado.HeaderText = "Cerrado";
            this.cerrado.MinimumWidth = 6;
            this.cerrado.Name = "cerrado";
            this.cerrado.ReadOnly = true;
            this.cerrado.Width = 59;
            // 
            // SynCodeas
            // 
            this.SynCodeas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SynCodeas.DataPropertyName = "SynCodeas";
            this.SynCodeas.HeaderText = "SynCodeas";
            this.SynCodeas.MinimumWidth = 6;
            this.SynCodeas.Name = "SynCodeas";
            this.SynCodeas.ReadOnly = true;
            this.SynCodeas.Width = 76;
            // 
            // anulado
            // 
            this.anulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.anulado.DataPropertyName = "Anulado";
            this.anulado.HeaderText = "Anulado";
            this.anulado.MinimumWidth = 6;
            this.anulado.Name = "anulado";
            this.anulado.ReadOnly = true;
            this.anulado.Width = 60;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem,
            this.reversarCerrarToolStripMenuItem,
            this.aplicarISVToolStripMenuItem,
            this.borrarISVToolStripMenuItem});
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(168, 108);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarToolStripMenuItem.Image")));
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // reversarCerrarToolStripMenuItem
            // 
            this.reversarCerrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reversarCerrarToolStripMenuItem.Image")));
            this.reversarCerrarToolStripMenuItem.Name = "reversarCerrarToolStripMenuItem";
            this.reversarCerrarToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.reversarCerrarToolStripMenuItem.Text = "Reversar Cerrado";
            this.reversarCerrarToolStripMenuItem.Click += new System.EventHandler(this.reversarCerrarToolStripMenuItem_Click);
            // 
            // aplicarISVToolStripMenuItem
            // 
            this.aplicarISVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aplicarISVToolStripMenuItem.Image")));
            this.aplicarISVToolStripMenuItem.Name = "aplicarISVToolStripMenuItem";
            this.aplicarISVToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.aplicarISVToolStripMenuItem.Text = "Aplicar ISV";
            this.aplicarISVToolStripMenuItem.Click += new System.EventHandler(this.aplicarISVToolStripMenuItem_Click);
            // 
            // borrarISVToolStripMenuItem
            // 
            this.borrarISVToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("borrarISVToolStripMenuItem.Image")));
            this.borrarISVToolStripMenuItem.Name = "borrarISVToolStripMenuItem";
            this.borrarISVToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.borrarISVToolStripMenuItem.Text = "Borrar ISV";
            this.borrarISVToolStripMenuItem.Click += new System.EventHandler(this.borrarISVToolStripMenuItem_Click);
            // 
            // tRCierreClientesBindingSource
            // 
            this.tRCierreClientesBindingSource.DataMember = "TR_CierreClientes";
            this.tRCierreClientesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // fKTRCierreClientesTRTipoVehiculosBindingSource
            // 
            this.fKTRCierreClientesTRTipoVehiculosBindingSource.DataMember = "FK_TR_CierreClientes_TR_TipoVehiculos";
            this.fKTRCierreClientesTRTipoVehiculosBindingSource.DataSource = this.tRTipoVehiculosBindingSource;
            // 
            // cboTipoVeh
            // 
            this.cboTipoVeh.DataSource = this.tRTipoFacturasBindingSource;
            this.cboTipoVeh.DisplayMember = "TipoFactura";
            this.cboTipoVeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVeh.FormattingEnabled = true;
            this.cboTipoVeh.Location = new System.Drawing.Point(274, 75);
            this.cboTipoVeh.Name = "cboTipoVeh";
            this.cboTipoVeh.Size = new System.Drawing.Size(258, 24);
            this.cboTipoVeh.TabIndex = 104;
            this.cboTipoVeh.ValueMember = "IdTipoFactura";
            this.cboTipoVeh.SelectedValueChanged += new System.EventHandler(this.cboTipoVeh_SelectedValueChanged);
            // 
            // tRTipoFacturasBindingSource
            // 
            this.tRTipoFacturasBindingSource.DataMember = "TR_TipoFacturas";
            this.tRTipoFacturasBindingSource.DataSource = this.dsCodeasAdiggm;
            // 
            // dsCodeasAdiggm
            // 
            this.dsCodeasAdiggm.DataSetName = "DsCodeasAdiggm";
            this.dsCodeasAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tR_TipoVehiculosTableAdapter
            // 
            this.tR_TipoVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_CierreClientesTableAdapter
            // 
            this.tR_CierreClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ClientesTableAdapter
            // 
            this.tR_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Seleccione:";
            // 
            // tR_TipoFacturasTableAdapter
            // 
            this.tR_TipoFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTotal2);
            this.groupBox2.Controls.Add(this.txtISV2);
            this.groupBox2.Controls.Add(this.txtSubtotal2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(547, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 94);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total por Tipo de Factura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 109;
            this.label5.Text = "Total L.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 108;
            this.label6.Text = "ISV L.:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 107;
            this.label7.Text = "Subtotal L.:";
            // 
            // txtTotal2
            // 
            this.txtTotal2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTotal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal2.Location = new System.Drawing.Point(185, 40);
            this.txtTotal2.Name = "txtTotal2";
            this.txtTotal2.ReadOnly = true;
            this.txtTotal2.Size = new System.Drawing.Size(100, 21);
            this.txtTotal2.TabIndex = 2;
            this.txtTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtISV2
            // 
            this.txtISV2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtISV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtISV2.Location = new System.Drawing.Point(111, 40);
            this.txtISV2.Name = "txtISV2";
            this.txtISV2.ReadOnly = true;
            this.txtISV2.Size = new System.Drawing.Size(68, 21);
            this.txtISV2.TabIndex = 1;
            this.txtISV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSubtotal2
            // 
            this.txtSubtotal2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSubtotal2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubtotal2.Location = new System.Drawing.Point(5, 40);
            this.txtSubtotal2.Name = "txtSubtotal2";
            this.txtSubtotal2.ReadOnly = true;
            this.txtSubtotal2.Size = new System.Drawing.Size(100, 21);
            this.txtSubtotal2.TabIndex = 0;
            this.txtSubtotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmCierreCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(840, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoVeh);
            this.Controls.Add(this.dgvCierreCliente);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCierreCliente";
            this.Load += new System.EventHandler(this.FrmCierreCliente_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvCierreCliente, 0);
            this.Controls.SetChildIndex(this.cboTipoVeh, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierreCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).EndInit();
            this.cmsOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tRCierreClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRCierreClientesTRTipoVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCierreCliente;
        private System.Windows.Forms.ComboBox cboTipoVeh;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter tR_TipoVehiculosTableAdapter;
        private System.Windows.Forms.BindingSource fKTRCierreClientesTRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_CierreClientesTableAdapter tR_CierreClientesTableAdapter;
        private System.Windows.Forms.BindingSource tRClientesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter tR_ClientesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reversarCerrarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private DataSets.DsCodeasAdiggm dsCodeasAdiggm;
        private System.Windows.Forms.BindingSource tRTipoFacturasBindingSource;
        private DataSets.DsCodeasAdiggmTableAdapters.TR_TipoFacturasTableAdapter tR_TipoFacturasTableAdapter;
        private System.Windows.Forms.BindingSource tRCierreClientesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCierreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCierrePK;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewComboBoxColumn idTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISVCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCierre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cerrado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SynCodeas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anulado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal2;
        private System.Windows.Forms.TextBox txtISV2;
        private System.Windows.Forms.TextBox txtSubtotal2;
        private System.Windows.Forms.ToolStripMenuItem aplicarISVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarISVToolStripMenuItem;
    }
}
