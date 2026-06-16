namespace ADIGGM.FAC.Transacciones
{
    partial class FAC_Factura
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.fACTipoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.tRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.fACProductosDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.fACProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscarBoletas = new System.Windows.Forms.Button();
            this.cboTipoMoneda = new System.Windows.Forms.ComboBox();
            this.fACTipoMonedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.txtCAI = new System.Windows.Forms.TextBox();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAplica = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSAG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOrdenExenta = new System.Windows.Forms.TextBox();
            this.lblExenta = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACProductosDetBindingSource)).BeginInit();
            this.gbDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoMonedaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Size = new System.Drawing.Size(68, 19);
            this.lblFooter.Text = "Factura";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(582, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(542, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(622, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(482, 0);
            this.pgbProcesos.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 522);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Size = new System.Drawing.Size(662, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 103;
            this.label1.Text = "Tipo Factura";
            // 
            // cboTipoFactura
            //
            this.cboTipoFactura.DisplayMember = "TipoFactura";
            this.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Location = new System.Drawing.Point(99, 47);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(253, 24);
            this.cboTipoFactura.TabIndex = 104;
            this.cboTipoFactura.ValueMember = "IdTipoFactura";
            this.cboTipoFactura.SelectedIndexChanged += new System.EventHandler(this.cboTipoFactura_SelectedIndexChanged);
            //
            // cboCliente
            //
            this.cboCliente.DisplayMember = "Cliente";
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(99, 74);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(253, 24);
            this.cboCliente.TabIndex = 106;
            this.cboCliente.ValueMember = "IdCliente";
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cboCliente_SelectedIndexChanged);
            //
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 105;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 107;
            this.label3.Text = "CAI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 109;
            this.label4.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(99, 18);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(98, 21);
            this.dtpFecha.TabIndex = 110;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            // Las columnas se definen en codigo (ConfigurarColumnas), no aqui, para que el disenador de VS no las borre.
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDetalle.Location = new System.Drawing.Point(0, 347);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(662, 142);
            this.dgvDetalle.TabIndex = 111;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            this.dgvDetalle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDetalle_DataError);
            //
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Peru;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.Location = new System.Drawing.Point(0, 326);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(662, 21);
            this.lblTotal.TabIndex = 112;
            this.lblTotal.Text = "Cantidad: 0 -  ISV: 0  -  Total: 0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 113;
            this.label6.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(99, 156);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(370, 47);
            this.txtObservaciones.TabIndex = 114;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Controls.Add(this.btnAgregar);
            this.gbDetalle.Controls.Add(this.txtISV);
            this.gbDetalle.Controls.Add(this.label10);
            this.gbDetalle.Controls.Add(this.txtPrecio);
            this.gbDetalle.Controls.Add(this.label9);
            this.gbDetalle.Controls.Add(this.txtCantidad);
            this.gbDetalle.Controls.Add(this.label8);
            this.gbDetalle.Controls.Add(this.cboProducto);
            this.gbDetalle.Controls.Add(this.label7);
            this.gbDetalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDetalle.Location = new System.Drawing.Point(0, 246);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(662, 80);
            this.gbDetalle.TabIndex = 115;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Agregar Producto";
            this.gbDetalle.Enter += new System.EventHandler(this.gbDetalle_Enter);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(474, 18);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(72, 46);
            this.btnAgregar.TabIndex = 115;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtISV
            // 
            this.txtISV.Location = new System.Drawing.Point(403, 46);
            this.txtISV.Name = "txtISV";
            this.txtISV.ReadOnly = true;
            this.txtISV.Size = new System.Drawing.Size(65, 21);
            this.txtISV.TabIndex = 114;
            this.txtISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 113;
            this.label10.Text = "ISV";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(226, 46);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(98, 21);
            this.txtPrecio.TabIndex = 112;
            this.txtPrecio.Text = "0";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 111;
            this.label9.Text = "Precio";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(67, 46);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(91, 21);
            this.txtCantidad.TabIndex = 110;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 109;
            this.label8.Text = "Cantidad";
            // 
            // cboProducto
            //
            this.cboProducto.DisplayMember = "NombreProducto";
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(67, 19);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(401, 24);
            this.cboProducto.TabIndex = 108;
            this.cboProducto.ValueMember = "IdProducto";
            //
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 107;
            this.label7.Text = "Servicio";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Peru;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(512, 156);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 50);
            this.btnGuardar.TabIndex = 116;
            this.btnGuardar.Text = "Guardar Factura";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscarBoletas
            // 
            this.btnBuscarBoletas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBuscarBoletas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnBuscarBoletas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBoletas.Location = new System.Drawing.Point(356, 74);
            this.btnBuscarBoletas.Name = "btnBuscarBoletas";
            this.btnBuscarBoletas.Size = new System.Drawing.Size(112, 23);
            this.btnBuscarBoletas.TabIndex = 116;
            this.btnBuscarBoletas.Text = "Buscar Boletas";
            this.btnBuscarBoletas.UseVisualStyleBackColor = false;
            this.btnBuscarBoletas.Visible = false;
            this.btnBuscarBoletas.Click += new System.EventHandler(this.btnBuscarBoletas_Click);
            //
            // cboTipoMoneda
            //
            this.cboTipoMoneda.DisplayMember = "TipoMoneda";
            this.cboTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMoneda.FormattingEnabled = true;
            this.cboTipoMoneda.Location = new System.Drawing.Point(99, 127);
            this.cboTipoMoneda.Name = "cboTipoMoneda";
            this.cboTipoMoneda.Size = new System.Drawing.Size(253, 24);
            this.cboTipoMoneda.TabIndex = 118;
            this.cboTipoMoneda.ValueMember = "IdTipoMoneda";
            //
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 117;
            this.label11.Text = "Tipo Moneda";
            //
            // txtCAI
            // 
            this.txtCAI.Location = new System.Drawing.Point(99, 102);
            this.txtCAI.Name = "txtCAI";
            this.txtCAI.ReadOnly = true;
            this.txtCAI.Size = new System.Drawing.Size(253, 21);
            this.txtCAI.TabIndex = 120;
            this.txtCAI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Location = new System.Drawing.Point(356, 102);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.ReadOnly = true;
            this.txtCorrelativo.Size = new System.Drawing.Size(112, 21);
            this.txtCorrelativo.TabIndex = 121;
            this.txtCorrelativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAplica);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtCorrelativo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCAI);
            this.groupBox1.Controls.Add(this.cboTipoFactura);
            this.groupBox1.Controls.Add(this.cboTipoMoneda);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboCliente);
            this.groupBox1.Controls.Add(this.btnBuscarBoletas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(662, 211);
            this.groupBox1.TabIndex = 122;
            this.groupBox1.TabStop = false;
            // 
            // chkAplica
            // 
            this.chkAplica.AutoSize = true;
            this.chkAplica.Location = new System.Drawing.Point(474, 78);
            this.chkAplica.Name = "chkAplica";
            this.chkAplica.Size = new System.Drawing.Size(79, 20);
            this.chkAplica.TabIndex = 122;
            this.chkAplica.Text = "Aplica ISV";
            this.chkAplica.UseVisualStyleBackColor = true;
            this.chkAplica.CheckedChanged += new System.EventHandler(this.chkAplica_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSAG);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtOrdenExenta);
            this.panel1.Controls.Add(this.lblExenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 33);
            this.panel1.TabIndex = 123;
            // 
            // txtSAG
            // 
            this.txtSAG.Location = new System.Drawing.Point(431, 6);
            this.txtSAG.Name = "txtSAG";
            this.txtSAG.Size = new System.Drawing.Size(164, 21);
            this.txtSAG.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "# Registro de SAG:";
            // 
            // txtOrdenExenta
            // 
            this.txtOrdenExenta.Location = new System.Drawing.Point(145, 6);
            this.txtOrdenExenta.Name = "txtOrdenExenta";
            this.txtOrdenExenta.Size = new System.Drawing.Size(164, 21);
            this.txtOrdenExenta.TabIndex = 1;
            // 
            // lblExenta
            // 
            this.lblExenta.AutoSize = true;
            this.lblExenta.Location = new System.Drawing.Point(41, 9);
            this.lblExenta.Name = "lblExenta";
            this.lblExenta.Size = new System.Drawing.Size(97, 16);
            this.lblExenta.TabIndex = 0;
            this.lblExenta.Text = "# Orden Exenta:";
            // 
            // FAC_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(662, 545);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbDetalle);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FAC_Factura";
            this.Load += new System.EventHandler(this.FAC_Factura_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.gbDetalle, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgvDetalle, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACProductosDetBindingSource)).EndInit();
            this.gbDetalle.ResumeLayout(false);
            this.gbDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fACProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoMonedaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarBoletas;
        private System.Windows.Forms.BindingSource fACTipoFacturasBindingSource;
        private System.Windows.Forms.BindingSource tRClientesBindingSource;
        private System.Windows.Forms.ComboBox cboTipoMoneda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.BindingSource fACProductosDetBindingSource;
        private System.Windows.Forms.BindingSource fACProductosBindingSource;
        private System.Windows.Forms.TextBox txtCAI;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.BindingSource fACTipoMonedaBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSAG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOrdenExenta;
        private System.Windows.Forms.Label lblExenta;
        private System.Windows.Forms.CheckBox chkAplica;
    }
}
