namespace ADIGGM.OC.Transacciones
{
    partial class TranOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranOrdenCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckbGuardarCor = new System.Windows.Forms.CheckBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvDetOrden = new System.Windows.Forms.DataGridView();
            this.IdVehiculo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.IdProducto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oCProductos1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC1 = new ADIGGM.DataSets.DsOC();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.oCUnidadCombustible1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Quitar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.oCProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkOmitirFecha = new System.Windows.Forms.CheckBox();
            this.lblCorrelativo = new System.Windows.Forms.Label();
            this.cboResponsable = new System.Windows.Forms.ComboBox();
            this.oCResponsablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtSolicitado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.oCDepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cboClaTra = new System.Windows.Forms.ComboBox();
            this.tRClaseTrabajosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblClaTra = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.oCProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboTipoOC = new System.Windows.Forms.ComboBox();
            this.oCTipoOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.oC_TipoOCTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_TipoOCTableAdapter();
            this.oC_ProveedoresTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFEstimada = new System.Windows.Forms.Label();
            this.dtpFechaEstimada = new System.Windows.Forms.DateTimePicker();
            this.ckbVehiculosEdit = new System.Windows.Forms.CheckBox();
            this.ckbVehiculos = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAplicaISV = new System.Windows.Forms.CheckBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.oCProductosCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtISV = new System.Windows.Forms.TextBox();
            this.cboVehiculo = new System.Windows.Forms.ComboBox();
            this.lblISV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.cboUnidad = new System.Windows.Forms.ComboBox();
            this.oCUnidadCombustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtObservacionServicio = new System.Windows.Forms.TextBox();
            this.lblObsServicio = new System.Windows.Forms.Label();
            this.lblInformacionVeh = new System.Windows.Forms.Label();
            this.lblMaxItems = new System.Windows.Forms.Label();
            this.tR_VehiculosTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.TR_VehiculosTableAdapter();
            this.oC_ProductosCategoriasTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProductosCategoriasTableAdapter();
            this.oC_ProductosTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProductosTableAdapter();
            this.oCOrdenCompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oC_OrdenCompraTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_OrdenCompraTableAdapter();
            this.oCOrdenCompraDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oC_OrdenCompraDetTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_OrdenCompraDetTableAdapter();
            this.tR_ClaseTrabajosTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.TR_ClaseTrabajosTableAdapter();
            this.oC_DepartamentosTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_DepartamentosTableAdapter();
            this.oC_Productos1TableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_Productos1TableAdapter();
            this.oC_ResponsablesTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ResponsablesTableAdapter();
            this.oC_UnidadCombustibleTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_UnidadCombustibleTableAdapter();
            this.oC_UnidadCombustible1TableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_UnidadCombustible1TableAdapter();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductos1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCUnidadCombustible1BindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCResponsablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCDepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClaseTrabajosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCTipoOCBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCUnidadCombustibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenCompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenCompraDetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Size = new System.Drawing.Size(152, 19);
            this.lblFooter.Text = "Orden de Compra";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(580, 0);
            this.btnMax.Visible = false;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(540, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(620, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(650, 0);
            this.pgbProcesos.Margin = new System.Windows.Forms.Padding(4);
            this.pgbProcesos.Size = new System.Drawing.Size(10, 23);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 542);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Size = new System.Drawing.Size(660, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.ckbGuardarCor);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 47);
            this.panel1.TabIndex = 104;
            // 
            // ckbGuardarCor
            // 
            this.ckbGuardarCor.AutoSize = true;
            this.ckbGuardarCor.Location = new System.Drawing.Point(115, 15);
            this.ckbGuardarCor.Name = "ckbGuardarCor";
            this.ckbGuardarCor.Size = new System.Drawing.Size(136, 20);
            this.ckbGuardarCor.TabIndex = 14;
            this.ckbGuardarCor.Text = "Guardar Correlativo";
            this.ckbGuardarCor.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(370, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 40);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(258, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 40);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvDetOrden);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 354);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 141);
            this.panel2.TabIndex = 111;
            // 
            // dgvDetOrden
            // 
            this.dgvDetOrden.AllowUserToAddRows = false;
            this.dgvDetOrden.AllowUserToDeleteRows = false;
            this.dgvDetOrden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetOrden.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetOrden.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDetOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVehiculo,
            this.IdProducto,
            this.Cantidad,
            this.Precio,
            this.ISV,
            this.Total,
            this.Observacion,
            this.Eliminar,
            this.Unidad,
            this.Quitar});
            this.dgvDetOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetOrden.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDetOrden.Location = new System.Drawing.Point(0, 0);
            this.dgvDetOrden.Name = "dgvDetOrden";
            this.dgvDetOrden.RowHeadersVisible = false;
            this.dgvDetOrden.RowHeadersWidth = 51;
            this.dgvDetOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetOrden.Size = new System.Drawing.Size(660, 121);
            this.dgvDetOrden.TabIndex = 106;
            this.dgvDetOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetOrden_CellContentClick);
            this.dgvDetOrden.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDetOrden_DataError);
            // 
            // IdVehiculo
            // 
            this.IdVehiculo.DataPropertyName = "IdVehiculo";
            this.IdVehiculo.DataSource = this.tRVehiculosBindingSource;
            this.IdVehiculo.DisplayMember = "Vehiculo";
            this.IdVehiculo.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IdVehiculo.FillWeight = 95.54291F;
            this.IdVehiculo.HeaderText = "Vehiculo";
            this.IdVehiculo.MinimumWidth = 6;
            this.IdVehiculo.Name = "IdVehiculo";
            this.IdVehiculo.ReadOnly = true;
            this.IdVehiculo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdVehiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdVehiculo.ValueMember = "IdVehiculo";
            // 
            // tRVehiculosBindingSource
            // 
            this.tRVehiculosBindingSource.DataMember = "TR_Vehiculos";
            this.tRVehiculosBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.DataSource = this.oCProductos1BindingSource;
            this.IdProducto.DisplayMember = "Producto";
            this.IdProducto.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.IdProducto.FillWeight = 162.4365F;
            this.IdProducto.HeaderText = "Producto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdProducto.ValueMember = "IdProducto";
            // 
            // oCProductos1BindingSource
            // 
            this.oCProductos1BindingSource.DataMember = "OC_Productos1";
            this.oCProductos1BindingSource.DataSource = this.dsOC1;
            // 
            // dsOC1
            // 
            this.dsOC1.DataSetName = "DsOC";
            this.dsOC1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N2";
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle1;
            this.Cantidad.FillWeight = 95.92021F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = null;
            this.Precio.DefaultCellStyle = dataGridViewCellStyle2;
            this.Precio.FillWeight = 82.80491F;
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // ISV
            // 
            this.ISV.DataPropertyName = "ISV";
            dataGridViewCellStyle3.Format = "N4";
            dataGridViewCellStyle3.NullValue = null;
            this.ISV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ISV.FillWeight = 74.24455F;
            this.ISV.HeaderText = "ISV";
            this.ISV.MinimumWidth = 6;
            this.ISV.Name = "ISV";
            this.ISV.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N4";
            dataGridViewCellStyle4.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.FillWeight = 83.66091F;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Observacion
            // 
            this.Observacion.DataPropertyName = "Observacion";
            this.Observacion.FillWeight = 142.0842F;
            this.Observacion.HeaderText = "Observación";
            this.Observacion.MinimumWidth = 6;
            this.Observacion.Name = "Observacion";
            this.Observacion.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.DataPropertyName = "Eliminar";
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Visible = false;
            // 
            // Unidad
            // 
            this.Unidad.DataPropertyName = "Unidad";
            this.Unidad.DataSource = this.oCUnidadCombustible1BindingSource;
            this.Unidad.DisplayMember = "Unidad";
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.MinimumWidth = 6;
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.ValueMember = "IdUnidad";
            // 
            // oCUnidadCombustible1BindingSource
            // 
            this.oCUnidadCombustible1BindingSource.DataMember = "OC_UnidadCombustible1";
            this.oCUnidadCombustible1BindingSource.DataSource = this.dsOC;
            // 
            // Quitar
            // 
            this.Quitar.DataPropertyName = "Quitar";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quitar.DefaultCellStyle = dataGridViewCellStyle5;
            this.Quitar.FillWeight = 63.30568F;
            this.Quitar.HeaderText = "Quitar";
            this.Quitar.LinkColor = System.Drawing.Color.Red;
            this.Quitar.MinimumWidth = 6;
            this.Quitar.Name = "Quitar";
            this.Quitar.Text = "Quitar";
            this.Quitar.UseColumnTextForLinkValue = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.lblTotal);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(660, 20);
            this.panel4.TabIndex = 0;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTotal.Location = new System.Drawing.Point(276, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(384, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oCProductosBindingSource
            // 
            this.oCProductosBindingSource.DataMember = "OC_Productos";
            this.oCProductosBindingSource.DataSource = this.dsOC;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.chkOmitirFecha);
            this.panel3.Controls.Add(this.lblCorrelativo);
            this.panel3.Controls.Add(this.cboResponsable);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtSolicitado);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cboDepartamento);
            this.panel3.Controls.Add(this.lblDepartamento);
            this.panel3.Controls.Add(this.cboClaTra);
            this.panel3.Controls.Add(this.lblClaTra);
            this.panel3.Controls.Add(this.txtObservaciones);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cboProveedor);
            this.panel3.Controls.Add(this.cboTipoOC);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpFecha);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(660, 130);
            this.panel3.TabIndex = 112;
            // 
            // chkOmitirFecha
            // 
            this.chkOmitirFecha.AutoSize = true;
            this.chkOmitirFecha.Location = new System.Drawing.Point(193, 23);
            this.chkOmitirFecha.Name = "chkOmitirFecha";
            this.chkOmitirFecha.Size = new System.Drawing.Size(107, 20);
            this.chkOmitirFecha.TabIndex = 127;
            this.chkOmitirFecha.Text = "Fecha Posterior";
            this.chkOmitirFecha.UseVisualStyleBackColor = true;
            this.chkOmitirFecha.CheckedChanged += new System.EventHandler(this.chkOmitirFecha_CheckedChanged);
            // 
            // lblCorrelativo
            // 
            this.lblCorrelativo.AutoSize = true;
            this.lblCorrelativo.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativo.Location = new System.Drawing.Point(5, 1);
            this.lblCorrelativo.Name = "lblCorrelativo";
            this.lblCorrelativo.Size = new System.Drawing.Size(70, 17);
            this.lblCorrelativo.TabIndex = 126;
            this.lblCorrelativo.Text = "Orden #: ";
            // 
            // cboResponsable
            // 
            this.cboResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboResponsable.DataSource = this.oCResponsablesBindingSource;
            this.cboResponsable.DisplayMember = "Nombre";
            this.cboResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboResponsable.FormattingEnabled = true;
            this.cboResponsable.Location = new System.Drawing.Point(89, 95);
            this.cboResponsable.Name = "cboResponsable";
            this.cboResponsable.Size = new System.Drawing.Size(177, 24);
            this.cboResponsable.TabIndex = 125;
            this.cboResponsable.ValueMember = "IdResponsable";
            // 
            // oCResponsablesBindingSource
            // 
            this.oCResponsablesBindingSource.DataMember = "OC_Responsables";
            this.oCResponsablesBindingSource.DataSource = this.dsOC;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 124;
            this.label9.Text = "Responsable:";
            // 
            // txtSolicitado
            // 
            this.txtSolicitado.Location = new System.Drawing.Point(89, 72);
            this.txtSolicitado.Name = "txtSolicitado";
            this.txtSolicitado.Size = new System.Drawing.Size(177, 21);
            this.txtSolicitado.TabIndex = 123;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 122;
            this.label11.Text = "Solicitado:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDepartamento.DataSource = this.oCDepartamentosBindingSource;
            this.cboDepartamento.DisplayMember = "Departamento";
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(409, 75);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(240, 24);
            this.cboDepartamento.TabIndex = 121;
            this.cboDepartamento.ValueMember = "IdDepartamento";
            // 
            // oCDepartamentosBindingSource
            // 
            this.oCDepartamentosBindingSource.DataMember = "OC_Departamentos";
            this.oCDepartamentosBindingSource.DataSource = this.dsOC;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(326, 82);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 120;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // cboClaTra
            // 
            this.cboClaTra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboClaTra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClaTra.DataSource = this.tRClaseTrabajosBindingSource;
            this.cboClaTra.DisplayMember = "ClaseTrabajo";
            this.cboClaTra.FormattingEnabled = true;
            this.cboClaTra.Location = new System.Drawing.Point(409, 101);
            this.cboClaTra.Name = "cboClaTra";
            this.cboClaTra.Size = new System.Drawing.Size(240, 24);
            this.cboClaTra.TabIndex = 119;
            this.cboClaTra.ValueMember = "IdClaseTrabajo";
            // 
            // tRClaseTrabajosBindingSource
            // 
            this.tRClaseTrabajosBindingSource.DataMember = "TR_ClaseTrabajos";
            this.tRClaseTrabajosBindingSource.DataSource = this.dsOC;
            // 
            // lblClaTra
            // 
            this.lblClaTra.AutoSize = true;
            this.lblClaTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaTra.Location = new System.Drawing.Point(328, 107);
            this.lblClaTra.Name = "lblClaTra";
            this.lblClaTra.Size = new System.Drawing.Size(75, 13);
            this.lblClaTra.TabIndex = 118;
            this.lblClaTra.Text = "Clase Trabajo:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(409, 33);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(240, 40);
            this.txtObservaciones.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 117;
            this.label4.Text = "Observaciones:";
            // 
            // cboProveedor
            // 
            this.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProveedor.DataSource = this.oCProveedoresBindingSource;
            this.cboProveedor.DisplayMember = "NombreProveedor";
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(409, 7);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(240, 24);
            this.cboProveedor.TabIndex = 3;
            this.cboProveedor.ValueMember = "IdProveedor";
            this.cboProveedor.SelectedIndexChanged += new System.EventHandler(this.cboProveedor_SelectedIndexChanged);
            // 
            // oCProveedoresBindingSource
            // 
            this.oCProveedoresBindingSource.DataMember = "OC_Proveedores";
            this.oCProveedoresBindingSource.DataSource = this.dsOC;
            // 
            // cboTipoOC
            // 
            this.cboTipoOC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTipoOC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoOC.DataSource = this.oCTipoOCBindingSource;
            this.cboTipoOC.DisplayMember = "TipoOC";
            this.cboTipoOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoOC.FormattingEnabled = true;
            this.cboTipoOC.Location = new System.Drawing.Point(89, 46);
            this.cboTipoOC.Name = "cboTipoOC";
            this.cboTipoOC.Size = new System.Drawing.Size(177, 24);
            this.cboTipoOC.TabIndex = 2;
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
            this.label3.Location = new System.Drawing.Point(344, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "Tipo de Orden:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(89, 23);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(98, 21);
            this.dtpFecha.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "Fecha:";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Khaki;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(495, 136);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(88, 40);
            this.btnNuevo.TabIndex = 166;
            this.btnNuevo.Text = "&Agregar";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnNuevo, "Agregar");
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // oC_TipoOCTableAdapter
            // 
            this.oC_TipoOCTableAdapter.ClearBeforeFill = true;
            // 
            // oC_ProveedoresTableAdapter
            // 
            this.oC_ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.lblFEstimada);
            this.groupBox1.Controls.Add(this.dtpFechaEstimada);
            this.groupBox1.Controls.Add(this.ckbVehiculosEdit);
            this.groupBox1.Controls.Add(this.ckbVehiculos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkAplicaISV);
            this.groupBox1.Controls.Add(this.cboProducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.txtISV);
            this.groupBox1.Controls.Add(this.cboVehiculo);
            this.groupBox1.Controls.Add(this.lblISV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblUnidad);
            this.groupBox1.Controls.Add(this.cboUnidad);
            this.groupBox1.Controls.Add(this.txtObservacionServicio);
            this.groupBox1.Controls.Add(this.lblObsServicio);
            this.groupBox1.Controls.Add(this.lblInformacionVeh);
            this.groupBox1.Controls.Add(this.lblMaxItems);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 189);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // lblFEstimada
            // 
            this.lblFEstimada.AutoSize = true;
            this.lblFEstimada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFEstimada.Location = new System.Drawing.Point(6, 40);
            this.lblFEstimada.Name = "lblFEstimada";
            this.lblFEstimada.Size = new System.Drawing.Size(62, 13);
            this.lblFEstimada.TabIndex = 172;
            this.lblFEstimada.Text = "F.Estimada:";
            // 
            // dtpFechaEstimada
            // 
            this.dtpFechaEstimada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstimada.Location = new System.Drawing.Point(74, 35);
            this.dtpFechaEstimada.Name = "dtpFechaEstimada";
            this.dtpFechaEstimada.Size = new System.Drawing.Size(103, 21);
            this.dtpFechaEstimada.TabIndex = 171;
            // 
            // ckbVehiculosEdit
            // 
            this.ckbVehiculosEdit.AutoSize = true;
            this.ckbVehiculosEdit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbVehiculosEdit.Location = new System.Drawing.Point(67, 164);
            this.ckbVehiculosEdit.Name = "ckbVehiculosEdit";
            this.ckbVehiculosEdit.Size = new System.Drawing.Size(79, 19);
            this.ckbVehiculosEdit.TabIndex = 170;
            this.ckbVehiculosEdit.Text = "Editar lote";
            this.ckbVehiculosEdit.UseVisualStyleBackColor = true;
            this.ckbVehiculosEdit.Visible = false;
            // 
            // ckbVehiculos
            // 
            this.ckbVehiculos.AutoSize = true;
            this.ckbVehiculos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbVehiculos.Location = new System.Drawing.Point(67, 147);
            this.ckbVehiculos.Name = "ckbVehiculos";
            this.ckbVehiculos.Size = new System.Drawing.Size(120, 19);
            this.ckbVehiculos.TabIndex = 169;
            this.ckbVehiculos.Text = "Vehículos en lote";
            this.ckbVehiculos.UseVisualStyleBackColor = true;
            this.ckbVehiculos.CheckedChanged += new System.EventHandler(this.ckbVehiculos_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 160;
            this.label5.Text = "Vehículo:";
            // 
            // chkAplicaISV
            // 
            this.chkAplicaISV.AutoSize = true;
            this.chkAplicaISV.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAplicaISV.Location = new System.Drawing.Point(228, 147);
            this.chkAplicaISV.Name = "chkAplicaISV";
            this.chkAplicaISV.Size = new System.Drawing.Size(80, 19);
            this.chkAplicaISV.TabIndex = 167;
            this.chkAplicaISV.Text = "Aplica ISV";
            this.chkAplicaISV.UseVisualStyleBackColor = true;
            this.chkAplicaISV.CheckedChanged += new System.EventHandler(this.chkAplicaISV_CheckedChanged);
            // 
            // cboProducto
            // 
            this.cboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProducto.DataSource = this.oCProductosBindingSource;
            this.cboProducto.DisplayMember = "Producto";
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(74, 107);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(241, 24);
            this.cboProducto.TabIndex = 156;
            this.cboProducto.ValueMember = "IdProducto";
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 161;
            this.label6.Text = "Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 162;
            this.label7.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DataSource = this.oCProductosCategoriasBindingSource;
            this.cboCategoria.DisplayMember = "Categoria";
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(74, 82);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(241, 24);
            this.cboCategoria.TabIndex = 155;
            this.cboCategoria.ValueMember = "IdCatProducto";
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // oCProductosCategoriasBindingSource
            // 
            this.oCProductosCategoriasBindingSource.DataMember = "OC_ProductosCategorias";
            this.oCProductosCategoriasBindingSource.DataSource = this.dsOC;
            // 
            // txtISV
            // 
            this.txtISV.Location = new System.Drawing.Point(390, 108);
            this.txtISV.Name = "txtISV";
            this.txtISV.ReadOnly = true;
            this.txtISV.Size = new System.Drawing.Size(61, 21);
            this.txtISV.TabIndex = 159;
            this.txtISV.Text = "0.0";
            this.txtISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboVehiculo
            // 
            this.cboVehiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVehiculo.DataSource = this.tRVehiculosBindingSource;
            this.cboVehiculo.DisplayMember = "Vehiculo";
            this.cboVehiculo.FormattingEnabled = true;
            this.cboVehiculo.Location = new System.Drawing.Point(74, 57);
            this.cboVehiculo.Name = "cboVehiculo";
            this.cboVehiculo.Size = new System.Drawing.Size(241, 24);
            this.cboVehiculo.TabIndex = 154;
            this.cboVehiculo.ValueMember = "IdVehiculo";
            this.cboVehiculo.SelectedIndexChanged += new System.EventHandler(this.cboVehiculo_SelectedIndexChanged);
            // 
            // lblISV
            // 
            this.lblISV.AutoSize = true;
            this.lblISV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISV.Location = new System.Drawing.Point(357, 114);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(27, 13);
            this.lblISV.TabIndex = 165;
            this.lblISV.Text = "ISV:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 163;
            this.label8.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(390, 84);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(61, 21);
            this.txtPrecio.TabIndex = 158;
            this.txtPrecio.Text = "0";
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(390, 60);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(61, 21);
            this.txtCantidad.TabIndex = 157;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(344, 88);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 164;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(492, 41);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(119, 16);
            this.lblUnidad.TabIndex = 151;
            this.lblUnidad.Text = "Unidad Combustible";
            // 
            // cboUnidad
            // 
            this.cboUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUnidad.DataSource = this.oCUnidadCombustibleBindingSource;
            this.cboUnidad.DisplayMember = "Unidad";
            this.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidad.FormattingEnabled = true;
            this.cboUnidad.Location = new System.Drawing.Point(483, 61);
            this.cboUnidad.Name = "cboUnidad";
            this.cboUnidad.Size = new System.Drawing.Size(139, 24);
            this.cboUnidad.TabIndex = 152;
            this.cboUnidad.ValueMember = "IdUnidad";
            // 
            // oCUnidadCombustibleBindingSource
            // 
            this.oCUnidadCombustibleBindingSource.DataMember = "OC_UnidadCombustible";
            this.oCUnidadCombustibleBindingSource.DataSource = this.dsOC;
            // 
            // txtObservacionServicio
            // 
            this.txtObservacionServicio.Location = new System.Drawing.Point(458, 60);
            this.txtObservacionServicio.Multiline = true;
            this.txtObservacionServicio.Name = "txtObservacionServicio";
            this.txtObservacionServicio.Size = new System.Drawing.Size(188, 70);
            this.txtObservacionServicio.TabIndex = 149;
            // 
            // lblObsServicio
            // 
            this.lblObsServicio.AutoSize = true;
            this.lblObsServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObsServicio.Location = new System.Drawing.Point(497, 42);
            this.lblObsServicio.Name = "lblObsServicio";
            this.lblObsServicio.Size = new System.Drawing.Size(111, 13);
            this.lblObsServicio.TabIndex = 150;
            this.lblObsServicio.Text = "Observación Servicio:";
            // 
            // lblInformacionVeh
            // 
            this.lblInformacionVeh.AutoSize = true;
            this.lblInformacionVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacionVeh.Location = new System.Drawing.Point(14, 21);
            this.lblInformacionVeh.Name = "lblInformacionVeh";
            this.lblInformacionVeh.Size = new System.Drawing.Size(0, 13);
            this.lblInformacionVeh.TabIndex = 141;
            // 
            // lblMaxItems
            // 
            this.lblMaxItems.AutoSize = true;
            this.lblMaxItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxItems.Location = new System.Drawing.Point(421, 21);
            this.lblMaxItems.Name = "lblMaxItems";
            this.lblMaxItems.Size = new System.Drawing.Size(0, 13);
            this.lblMaxItems.TabIndex = 143;
            // 
            // tR_VehiculosTableAdapter
            // 
            this.tR_VehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // oC_ProductosCategoriasTableAdapter
            // 
            this.oC_ProductosCategoriasTableAdapter.ClearBeforeFill = true;
            // 
            // oC_ProductosTableAdapter
            // 
            this.oC_ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // oCOrdenCompraBindingSource
            // 
            this.oCOrdenCompraBindingSource.DataMember = "OC_OrdenCompra";
            this.oCOrdenCompraBindingSource.DataSource = this.dsOC;
            // 
            // oC_OrdenCompraTableAdapter
            // 
            this.oC_OrdenCompraTableAdapter.ClearBeforeFill = true;
            // 
            // oCOrdenCompraDetBindingSource
            // 
            this.oCOrdenCompraDetBindingSource.DataMember = "OC_OrdenCompraDet";
            this.oCOrdenCompraDetBindingSource.DataSource = this.dsOC;
            // 
            // oC_OrdenCompraDetTableAdapter
            // 
            this.oC_OrdenCompraDetTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ClaseTrabajosTableAdapter
            // 
            this.tR_ClaseTrabajosTableAdapter.ClearBeforeFill = true;
            // 
            // oC_DepartamentosTableAdapter
            // 
            this.oC_DepartamentosTableAdapter.ClearBeforeFill = true;
            // 
            // oC_Productos1TableAdapter
            // 
            this.oC_Productos1TableAdapter.ClearBeforeFill = true;
            // 
            // oC_ResponsablesTableAdapter
            // 
            this.oC_ResponsablesTableAdapter.ClearBeforeFill = true;
            // 
            // oC_UnidadCombustibleTableAdapter
            // 
            this.oC_UnidadCombustibleTableAdapter.ClearBeforeFill = true;
            // 
            // oC_UnidadCombustible1TableAdapter
            // 
            this.oC_UnidadCombustible1TableAdapter.ClearBeforeFill = true;
            // 
            // TranOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(660, 565);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TranOrdenCompra";
            this.Text = "Orden de Compra";
            this.Load += new System.EventHandler(this.TranOrdenCompra_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductos1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCUnidadCombustible1BindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCResponsablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCDepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClaseTrabajosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCTipoOCBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCUnidadCombustibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenCompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenCompraDetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.ComboBox cboTipoOC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvDetOrden;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotal;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.BindingSource oCTipoOCBindingSource;
        private DataSets.DsOCTableAdapters.OC_TipoOCTableAdapter oC_TipoOCTableAdapter;
        private System.Windows.Forms.BindingSource oCProveedoresBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter oC_ProveedoresTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource tRVehiculosBindingSource;
        private DataSets.DsOCTableAdapters.TR_VehiculosTableAdapter tR_VehiculosTableAdapter;
        private System.Windows.Forms.BindingSource oCProductosCategoriasBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProductosCategoriasTableAdapter oC_ProductosCategoriasTableAdapter;
        private System.Windows.Forms.BindingSource oCProductosBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProductosTableAdapter oC_ProductosTableAdapter;
        private System.Windows.Forms.BindingSource oCOrdenCompraBindingSource;
        private DataSets.DsOCTableAdapters.OC_OrdenCompraTableAdapter oC_OrdenCompraTableAdapter;
        private System.Windows.Forms.BindingSource oCOrdenCompraDetBindingSource;
        private DataSets.DsOCTableAdapters.OC_OrdenCompraDetTableAdapter oC_OrdenCompraDetTableAdapter;
        private System.Windows.Forms.TextBox txtSolicitado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cboClaTra;
        private System.Windows.Forms.Label lblClaTra;
        private System.Windows.Forms.Label lblInformacionVeh;
        private System.Windows.Forms.BindingSource tRClaseTrabajosBindingSource;
        private DataSets.DsOCTableAdapters.TR_ClaseTrabajosTableAdapter tR_ClaseTrabajosTableAdapter;
        private System.Windows.Forms.BindingSource oCDepartamentosBindingSource;
        private DataSets.DsOCTableAdapters.OC_DepartamentosTableAdapter oC_DepartamentosTableAdapter;
        private DataSets.DsOC dsOC1;
        private System.Windows.Forms.BindingSource oCProductos1BindingSource;
        private DataSets.DsOCTableAdapters.OC_Productos1TableAdapter oC_Productos1TableAdapter;
        private System.Windows.Forms.Label lblMaxItems;
        private System.Windows.Forms.ComboBox cboResponsable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource oCResponsablesBindingSource;
        private DataSets.DsOCTableAdapters.OC_ResponsablesTableAdapter oC_ResponsablesTableAdapter;
        private System.Windows.Forms.BindingSource oCUnidadCombustibleBindingSource;
        private DataSets.DsOCTableAdapters.OC_UnidadCombustibleTableAdapter oC_UnidadCombustibleTableAdapter;
        private System.Windows.Forms.BindingSource oCUnidadCombustible1BindingSource;
        private DataSets.DsOCTableAdapters.OC_UnidadCombustible1TableAdapter oC_UnidadCombustible1TableAdapter;
        private System.Windows.Forms.Label lblCorrelativo;
        private System.Windows.Forms.CheckBox ckbGuardarCor;
        private System.Windows.Forms.ComboBox cboUnidad;
        private System.Windows.Forms.TextBox txtObservacionServicio;
        private System.Windows.Forms.Label lblObsServicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAplicaISV;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.ComboBox cboVehiculo;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.CheckBox ckbVehiculos;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdVehiculo;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eliminar;
        private System.Windows.Forms.DataGridViewComboBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewLinkColumn Quitar;
        private System.Windows.Forms.CheckBox ckbVehiculosEdit;
        private System.Windows.Forms.Label lblFEstimada;
        private System.Windows.Forms.DateTimePicker dtpFechaEstimada;
        private System.Windows.Forms.CheckBox chkOmitirFecha;
    }
}
