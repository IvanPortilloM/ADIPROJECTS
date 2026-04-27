namespace ADIGGM.FAC.Transacciones
{
    partial class FAC_BusquedaViajes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.fACProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFAC = new ADIGGM.DataSets.DsFAC();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipoFac = new System.Windows.Forms.ComboBox();
            this.tRTipoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVer = new System.Windows.Forms.Button();
            this.cboProforma = new System.Windows.Forms.ComboBox();
            this.fACProformasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.tRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cboCalendarizacion = new System.Windows.Forms.ComboBox();
            this.fACCierresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTiposVehBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvBoletas = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prefijoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numBoletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claseTrabajoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACVisorBoletasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.fAC_CierresTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.FAC_CierresTableAdapter();
            this.tR_ClientesTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.TR_ClientesTableAdapter();
            this.fAC_TiposVehTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.FAC_TiposVehTableAdapter();
            this.fAC_ProformasTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.FAC_ProformasTableAdapter();
            this.fAC_VisorBoletasTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.FAC_VisorBoletasTableAdapter();
            this.tR_TipoFacturasTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.TR_TipoFacturasTableAdapter();
            this.fAC_ProductosTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.FAC_ProductosTableAdapter();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACProformasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACCierresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTiposVehBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACVisorBoletasBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(103, 19);
            this.lblFooter.Text = "Visor Boletas";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(762, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(722, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(802, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(662, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 456);
            this.pnlFooter.Size = new System.Drawing.Size(842, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboProducto);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboTipoFac);
            this.panel1.Controls.Add(this.btnVer);
            this.panel1.Controls.Add(this.cboProforma);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboCalendarizacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 95);
            this.panel1.TabIndex = 106;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(467, 62);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(245, 21);
            this.txtCantidad.TabIndex = 15;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cantidad:";
            // 
            // cboProducto
            // 
            this.cboProducto.DataSource = this.fACProductosBindingSource;
            this.cboProducto.DisplayMember = "NombreProducto";
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(113, 64);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(268, 24);
            this.cboProducto.TabIndex = 13;
            this.cboProducto.ValueMember = "IdProducto";
            // 
            // fACProductosBindingSource
            // 
            this.fACProductosBindingSource.DataMember = "FAC_Productos";
            this.fACProductosBindingSource.DataSource = this.dsFAC;
            // 
            // dsFAC
            // 
            this.dsFAC.DataSetName = "DsFAC";
            this.dsFAC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Producto:";
            // 
            // cboTipoFac
            // 
            this.cboTipoFac.DataSource = this.tRTipoFacturasBindingSource;
            this.cboTipoFac.DisplayMember = "TipoFactura";
            this.cboTipoFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFac.FormattingEnabled = true;
            this.cboTipoFac.Location = new System.Drawing.Point(113, 35);
            this.cboTipoFac.Name = "cboTipoFac";
            this.cboTipoFac.Size = new System.Drawing.Size(268, 24);
            this.cboTipoFac.TabIndex = 11;
            this.cboTipoFac.ValueMember = "IdTipoFactura";
            this.cboTipoFac.SelectedIndexChanged += new System.EventHandler(this.cboTipoFac_SelectedIndexChanged);
            // 
            // tRTipoFacturasBindingSource
            // 
            this.tRTipoFacturasBindingSource.DataMember = "TR_TipoFacturas";
            this.tRTipoFacturasBindingSource.DataSource = this.dsFAC;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(736, 17);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(93, 56);
            this.btnVer.TabIndex = 10;
            this.btnVer.Text = "Visualizar";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // cboProforma
            // 
            this.cboProforma.DataSource = this.fACProformasBindingSource;
            this.cboProforma.DisplayMember = "Numero";
            this.cboProforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProforma.FormattingEnabled = true;
            this.cboProforma.Location = new System.Drawing.Point(467, 35);
            this.cboProforma.Name = "cboProforma";
            this.cboProforma.Size = new System.Drawing.Size(245, 24);
            this.cboProforma.TabIndex = 9;
            this.cboProforma.ValueMember = "IdProforma";
            // 
            // fACProformasBindingSource
            // 
            this.fACProformasBindingSource.DataMember = "FAC_Proformas";
            this.fACProformasBindingSource.DataSource = this.dsFAC;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Proforma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo Facturación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente:";
            // 
            // cboCliente
            // 
            this.cboCliente.DataSource = this.tRClientesBindingSource;
            this.cboCliente.DisplayMember = "Cliente";
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.Enabled = false;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(467, 7);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(245, 24);
            this.cboCliente.TabIndex = 5;
            this.cboCliente.ValueMember = "IdCliente";
            // 
            // tRClientesBindingSource
            // 
            this.tRClientesBindingSource.DataMember = "TR_Clientes";
            this.tRClientesBindingSource.DataSource = this.dsFAC;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calendarización:";
            // 
            // cboCalendarizacion
            // 
            this.cboCalendarizacion.DataSource = this.fACCierresBindingSource;
            this.cboCalendarizacion.DisplayMember = "Cierre";
            this.cboCalendarizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCalendarizacion.FormattingEnabled = true;
            this.cboCalendarizacion.Location = new System.Drawing.Point(113, 6);
            this.cboCalendarizacion.Name = "cboCalendarizacion";
            this.cboCalendarizacion.Size = new System.Drawing.Size(268, 24);
            this.cboCalendarizacion.TabIndex = 1;
            this.cboCalendarizacion.ValueMember = "IdCierre";
            this.cboCalendarizacion.SelectedIndexChanged += new System.EventHandler(this.cboCalendarizacion_SelectedIndexChanged);
            // 
            // fACCierresBindingSource
            // 
            this.fACCierresBindingSource.DataMember = "FAC_Cierres";
            this.fACCierresBindingSource.DataSource = this.dsFAC;
            // 
            // fACTiposVehBindingSource
            // 
            this.fACTiposVehBindingSource.DataMember = "FAC_TiposVeh";
            this.fACTiposVehBindingSource.DataSource = this.dsFAC;
            // 
            // dgvBoletas
            // 
            this.dgvBoletas.AllowUserToAddRows = false;
            this.dgvBoletas.AllowUserToDeleteRows = false;
            this.dgvBoletas.AutoGenerateColumns = false;
            this.dgvBoletas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBoletas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBoletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn,
            this.tipoVehiculoDataGridViewTextBoxColumn,
            this.prefijoDataGridViewTextBoxColumn,
            this.numBoletaDataGridViewTextBoxColumn,
            this.claseTrabajoDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.tarifaDataGridViewTextBoxColumn,
            this.iSVDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgvBoletas.DataSource = this.fACVisorBoletasBindingSource;
            this.dgvBoletas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBoletas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvBoletas.Location = new System.Drawing.Point(0, 130);
            this.dgvBoletas.Name = "dgvBoletas";
            this.dgvBoletas.RowHeadersVisible = false;
            this.dgvBoletas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBoletas.Size = new System.Drawing.Size(842, 286);
            this.dgvBoletas.TabIndex = 107;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.FillWeight = 97.58509F;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.FillWeight = 157.7723F;
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // tipoVehiculoDataGridViewTextBoxColumn
            // 
            this.tipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "TipoVehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.FillWeight = 117.977F;
            this.tipoVehiculoDataGridViewTextBoxColumn.HeaderText = "T. Vehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.Name = "tipoVehiculoDataGridViewTextBoxColumn";
            // 
            // prefijoDataGridViewTextBoxColumn
            // 
            this.prefijoDataGridViewTextBoxColumn.DataPropertyName = "Prefijo";
            this.prefijoDataGridViewTextBoxColumn.FillWeight = 51.27513F;
            this.prefijoDataGridViewTextBoxColumn.HeaderText = "Prefijo";
            this.prefijoDataGridViewTextBoxColumn.Name = "prefijoDataGridViewTextBoxColumn";
            // 
            // numBoletaDataGridViewTextBoxColumn
            // 
            this.numBoletaDataGridViewTextBoxColumn.DataPropertyName = "NumBoleta";
            this.numBoletaDataGridViewTextBoxColumn.FillWeight = 97.58509F;
            this.numBoletaDataGridViewTextBoxColumn.HeaderText = "#Boleta";
            this.numBoletaDataGridViewTextBoxColumn.Name = "numBoletaDataGridViewTextBoxColumn";
            // 
            // claseTrabajoDataGridViewTextBoxColumn
            // 
            this.claseTrabajoDataGridViewTextBoxColumn.DataPropertyName = "ClaseTrabajo";
            this.claseTrabajoDataGridViewTextBoxColumn.FillWeight = 163.9284F;
            this.claseTrabajoDataGridViewTextBoxColumn.HeaderText = "Clase Trabajo";
            this.claseTrabajoDataGridViewTextBoxColumn.Name = "claseTrabajoDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.FillWeight = 80.6768F;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // tarifaDataGridViewTextBoxColumn
            // 
            this.tarifaDataGridViewTextBoxColumn.DataPropertyName = "Tarifa";
            dataGridViewCellStyle1.Format = "N2";
            this.tarifaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.tarifaDataGridViewTextBoxColumn.FillWeight = 79.28324F;
            this.tarifaDataGridViewTextBoxColumn.HeaderText = "Tarifa";
            this.tarifaDataGridViewTextBoxColumn.Name = "tarifaDataGridViewTextBoxColumn";
            // 
            // iSVDataGridViewTextBoxColumn
            // 
            this.iSVDataGridViewTextBoxColumn.DataPropertyName = "ISV";
            dataGridViewCellStyle2.Format = "N2";
            this.iSVDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iSVDataGridViewTextBoxColumn.FillWeight = 77.77485F;
            this.iSVDataGridViewTextBoxColumn.HeaderText = "ISV";
            this.iSVDataGridViewTextBoxColumn.Name = "iSVDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle3.Format = "N2";
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalDataGridViewTextBoxColumn.FillWeight = 76.14214F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // fACVisorBoletasBindingSource
            // 
            this.fACVisorBoletasBindingSource.DataMember = "FAC_VisorBoletas";
            this.fACVisorBoletasBindingSource.DataSource = this.dsFAC;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 40);
            this.panel2.TabIndex = 108;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(742, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(95, 34);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(736, 38);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fAC_CierresTableAdapter
            // 
            this.fAC_CierresTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ClientesTableAdapter
            // 
            this.tR_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // fAC_TiposVehTableAdapter
            // 
            this.fAC_TiposVehTableAdapter.ClearBeforeFill = true;
            // 
            // fAC_ProformasTableAdapter
            // 
            this.fAC_ProformasTableAdapter.ClearBeforeFill = true;
            // 
            // fAC_VisorBoletasTableAdapter
            // 
            this.fAC_VisorBoletasTableAdapter.ClearBeforeFill = true;
            // 
            // tR_TipoFacturasTableAdapter
            // 
            this.tR_TipoFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // fAC_ProductosTableAdapter
            // 
            this.fAC_ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // FAC_BusquedaViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(842, 479);
            this.Controls.Add(this.dgvBoletas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FAC_BusquedaViajes";
            this.Load += new System.EventHandler(this.FAC_BusquedaViajes_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvBoletas, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACProformasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACCierresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTiposVehBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACVisorBoletasBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCalendarizacion;
        private System.Windows.Forms.DataGridView dgvBoletas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.ComboBox cboProforma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private DataSets.DsFAC dsFAC;
        private System.Windows.Forms.BindingSource fACCierresBindingSource;
        private DataSets.DsFACTableAdapters.FAC_CierresTableAdapter fAC_CierresTableAdapter;
        private System.Windows.Forms.BindingSource tRClientesBindingSource;
        private DataSets.DsFACTableAdapters.TR_ClientesTableAdapter tR_ClientesTableAdapter;
        private System.Windows.Forms.BindingSource fACTiposVehBindingSource;
        private DataSets.DsFACTableAdapters.FAC_TiposVehTableAdapter fAC_TiposVehTableAdapter;
        private System.Windows.Forms.BindingSource fACProformasBindingSource;
        private DataSets.DsFACTableAdapters.FAC_ProformasTableAdapter fAC_ProformasTableAdapter;
        private System.Windows.Forms.BindingSource fACVisorBoletasBindingSource;
        private DataSets.DsFACTableAdapters.FAC_VisorBoletasTableAdapter fAC_VisorBoletasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prefijoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numBoletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claseTrabajoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTipoFac;
        private System.Windows.Forms.BindingSource tRTipoFacturasBindingSource;
        private DataSets.DsFACTableAdapters.TR_TipoFacturasTableAdapter tR_TipoFacturasTableAdapter;
        private System.Windows.Forms.BindingSource fACProductosBindingSource;
        private DataSets.DsFACTableAdapters.FAC_ProductosTableAdapter fAC_ProductosTableAdapter;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
    }
}
