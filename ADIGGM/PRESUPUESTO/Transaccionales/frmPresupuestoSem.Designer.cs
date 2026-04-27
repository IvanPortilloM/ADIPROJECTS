
namespace ADIGGM.PRESUPUESTO.Transaccionales
{
    partial class frmPresupuestoSem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuestoSem));
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.idMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPresupuestoSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSelectMatCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.dgvSemanas = new System.Windows.Forms.DataGridView();
            this.idDetPresupuestoSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSemana = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRSemanasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidad3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSelectMatCuentasCantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCuentas = new System.Windows.Forms.DataGridView();
            this.idCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idCtaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pR_CuentasTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_CuentasTableAdapter();
            this.pR_SelectMatCuentasTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SelectMatCuentasTableAdapter();
            this.pR_SelectMatCuentasCantTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SelectMatCuentasCantTableAdapter();
            this.pR_SemanasTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SemanasTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.idCtaCategoria1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRctaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto1 = new ADIGGM.DataSets.DsPresupuesto();
            this.pR_ctaCategoriaTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_ctaCategoriaTableAdapter();
            this.coD_DivisionesTableAdapter1 = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.COD_DivisionesTableAdapter();
            this.btnSincronizarMat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectMatCuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSemanasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectMatCuentasCantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRCuentasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AllowUserToAddRows = false;
            this.dgvMateriales.AllowUserToDeleteRows = false;
            this.dgvMateriales.AllowUserToResizeRows = false;
            this.dgvMateriales.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterial,
            this.codMaterial,
            this.idPresupuestoSem,
            this.material,
            this.precioUnit,
            this.cantidad,
            this.total});
            this.dgvMateriales.DataSource = this.pRSelectMatCuentasBindingSource;
            this.dgvMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMateriales.Location = new System.Drawing.Point(540, 2);
            this.dgvMateriales.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.ReadOnly = true;
            this.dgvMateriales.RowHeadersVisible = false;
            this.dgvMateriales.RowHeadersWidth = 51;
            this.dgvMateriales.RowTemplate.Height = 24;
            this.dgvMateriales.Size = new System.Drawing.Size(340, 364);
            this.dgvMateriales.TabIndex = 2;
            this.dgvMateriales.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMateriales_DataError);
            this.dgvMateriales.SelectionChanged += new System.EventHandler(this.dgvMateriales_SelectionChanged);
            // 
            // idMaterial
            // 
            this.idMaterial.DataPropertyName = "idMaterial";
            this.idMaterial.HeaderText = "idMaterial";
            this.idMaterial.MinimumWidth = 6;
            this.idMaterial.Name = "idMaterial";
            this.idMaterial.ReadOnly = true;
            this.idMaterial.Visible = false;
            this.idMaterial.Width = 125;
            // 
            // codMaterial
            // 
            this.codMaterial.DataPropertyName = "codMaterial";
            this.codMaterial.HeaderText = "codMaterial";
            this.codMaterial.MinimumWidth = 6;
            this.codMaterial.Name = "codMaterial";
            this.codMaterial.ReadOnly = true;
            this.codMaterial.Visible = false;
            this.codMaterial.Width = 125;
            // 
            // idPresupuestoSem
            // 
            this.idPresupuestoSem.DataPropertyName = "idPresupuestoSem";
            this.idPresupuestoSem.HeaderText = "idPresupuestoSem";
            this.idPresupuestoSem.MinimumWidth = 6;
            this.idPresupuestoSem.Name = "idPresupuestoSem";
            this.idPresupuestoSem.ReadOnly = true;
            this.idPresupuestoSem.Visible = false;
            this.idPresupuestoSem.Width = 125;
            // 
            // material
            // 
            this.material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.material.DataPropertyName = "Material";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.material.DefaultCellStyle = dataGridViewCellStyle2;
            this.material.HeaderText = "Material";
            this.material.MinimumWidth = 6;
            this.material.Name = "material";
            this.material.ReadOnly = true;
            // 
            // precioUnit
            // 
            this.precioUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.precioUnit.DataPropertyName = "PrecioUnit";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.precioUnit.DefaultCellStyle = dataGridViewCellStyle3;
            this.precioUnit.HeaderText = "Precio";
            this.precioUnit.MinimumWidth = 6;
            this.precioUnit.Name = "precioUnit";
            this.precioUnit.ReadOnly = true;
            this.precioUnit.Width = 62;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.cantidad.HeaderText = "Cant.";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 57;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.total.DataPropertyName = "Total";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle5;
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 56;
            // 
            // pRSelectMatCuentasBindingSource
            // 
            this.pRSelectMatCuentasBindingSource.DataMember = "PR_SelectMatCuentas";
            this.pRSelectMatCuentasBindingSource.DataSource = this.dsPresupuesto;
            // 
            // dsPresupuesto
            // 
            this.dsPresupuesto.DataSetName = "DsPresupuesto";
            this.dsPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvSemanas
            // 
            this.dgvSemanas.AllowUserToAddRows = false;
            this.dgvSemanas.AllowUserToDeleteRows = false;
            this.dgvSemanas.AllowUserToResizeRows = false;
            this.dgvSemanas.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSemanas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSemanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemanas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetPresupuestoSem,
            this.idSemana,
            this.cantidad3});
            this.dgvSemanas.DataSource = this.pRSelectMatCuentasCantBindingSource;
            this.dgvSemanas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSemanas.Location = new System.Drawing.Point(884, 2);
            this.dgvSemanas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSemanas.Name = "dgvSemanas";
            this.dgvSemanas.ReadOnly = true;
            this.dgvSemanas.RowHeadersVisible = false;
            this.dgvSemanas.RowHeadersWidth = 51;
            this.dgvSemanas.RowTemplate.Height = 24;
            this.dgvSemanas.Size = new System.Drawing.Size(142, 364);
            this.dgvSemanas.TabIndex = 1;
            this.dgvSemanas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSemanas_DataError);
            // 
            // idDetPresupuestoSem
            // 
            this.idDetPresupuestoSem.DataPropertyName = "idDetPresupuestoSem";
            this.idDetPresupuestoSem.HeaderText = "idDetPresupuestoSem";
            this.idDetPresupuestoSem.MinimumWidth = 6;
            this.idDetPresupuestoSem.Name = "idDetPresupuestoSem";
            this.idDetPresupuestoSem.ReadOnly = true;
            this.idDetPresupuestoSem.Visible = false;
            this.idDetPresupuestoSem.Width = 125;
            // 
            // idSemana
            // 
            this.idSemana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idSemana.DataPropertyName = "idSemana";
            this.idSemana.DataSource = this.pRSemanasBindingSource;
            this.idSemana.DisplayMember = "Semana";
            this.idSemana.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idSemana.HeaderText = "Semana";
            this.idSemana.MinimumWidth = 6;
            this.idSemana.Name = "idSemana";
            this.idSemana.ReadOnly = true;
            this.idSemana.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idSemana.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idSemana.ValueMember = "idSemana";
            // 
            // pRSemanasBindingSource
            // 
            this.pRSemanasBindingSource.DataMember = "PR_Semanas";
            this.pRSemanasBindingSource.DataSource = this.dsPresupuesto;
            // 
            // cantidad3
            // 
            this.cantidad3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cantidad3.DataPropertyName = "Cantidad";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.cantidad3.DefaultCellStyle = dataGridViewCellStyle7;
            this.cantidad3.HeaderText = "Cant.";
            this.cantidad3.MinimumWidth = 6;
            this.cantidad3.Name = "cantidad3";
            this.cantidad3.ReadOnly = true;
            this.cantidad3.Width = 57;
            // 
            // pRSelectMatCuentasCantBindingSource
            // 
            this.pRSelectMatCuentasCantBindingSource.DataMember = "PR_SelectMatCuentasCant";
            this.pRSelectMatCuentasCantBindingSource.DataSource = this.dsPresupuesto;
            // 
            // dgvCuentas
            // 
            this.dgvCuentas.AllowUserToAddRows = false;
            this.dgvCuentas.AllowUserToDeleteRows = false;
            this.dgvCuentas.AllowUserToResizeRows = false;
            this.dgvCuentas.AutoGenerateColumns = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCuenta,
            this.codCuenta,
            this.cuentaContable,
            this.activo,
            this.idCtaCategoria});
            this.dgvCuentas.DataSource = this.pRCuentasBindingSource;
            this.dgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCuentas.Location = new System.Drawing.Point(276, 2);
            this.dgvCuentas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCuentas.Name = "dgvCuentas";
            this.dgvCuentas.ReadOnly = true;
            this.dgvCuentas.RowHeadersVisible = false;
            this.dgvCuentas.RowHeadersWidth = 51;
            this.dgvCuentas.RowTemplate.Height = 24;
            this.dgvCuentas.Size = new System.Drawing.Size(260, 364);
            this.dgvCuentas.TabIndex = 0;
            this.dgvCuentas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCuentas_DataError);
            this.dgvCuentas.SelectionChanged += new System.EventHandler(this.dgvCuentas_SelectionChanged);
            // 
            // idCuenta
            // 
            this.idCuenta.DataPropertyName = "idCuenta";
            this.idCuenta.HeaderText = "idCuenta";
            this.idCuenta.MinimumWidth = 6;
            this.idCuenta.Name = "idCuenta";
            this.idCuenta.ReadOnly = true;
            this.idCuenta.Visible = false;
            this.idCuenta.Width = 125;
            // 
            // codCuenta
            // 
            this.codCuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codCuenta.DataPropertyName = "codCuenta";
            this.codCuenta.HeaderText = "Cod.";
            this.codCuenta.MinimumWidth = 6;
            this.codCuenta.Name = "codCuenta";
            this.codCuenta.ReadOnly = true;
            this.codCuenta.Width = 54;
            // 
            // cuentaContable
            // 
            this.cuentaContable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cuentaContable.DataPropertyName = "cuentaContable";
            this.cuentaContable.HeaderText = "Cuenta";
            this.cuentaContable.MinimumWidth = 6;
            this.cuentaContable.Name = "cuentaContable";
            this.cuentaContable.ReadOnly = true;
            // 
            // activo
            // 
            this.activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.activo.DataPropertyName = "Activo";
            this.activo.HeaderText = "Activo";
            this.activo.MinimumWidth = 6;
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Visible = false;
            // 
            // idCtaCategoria
            // 
            this.idCtaCategoria.DataPropertyName = "idCtaCategoria";
            this.idCtaCategoria.HeaderText = "idCtaCategoria";
            this.idCtaCategoria.MinimumWidth = 6;
            this.idCtaCategoria.Name = "idCtaCategoria";
            this.idCtaCategoria.ReadOnly = true;
            this.idCtaCategoria.Visible = false;
            this.idCtaCategoria.Width = 125;
            // 
            // pRCuentasBindingSource
            // 
            this.pRCuentasBindingSource.DataMember = "PR_Cuentas";
            this.pRCuentasBindingSource.DataSource = this.dsPresupuesto;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnSincronizarMat);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 102);
            this.panel1.TabIndex = 2;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(478, 24);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(64, 58);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(386, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 58);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(548, 24);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 58);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(632, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 58);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pR_CuentasTableAdapter
            // 
            this.pR_CuentasTableAdapter.ClearBeforeFill = true;
            // 
            // pR_SelectMatCuentasTableAdapter
            // 
            this.pR_SelectMatCuentasTableAdapter.ClearBeforeFill = true;
            // 
            // pR_SelectMatCuentasCantTableAdapter
            // 
            this.pR_SelectMatCuentasCantTableAdapter.ClearBeforeFill = true;
            // 
            // pR_SemanasTableAdapter
            // 
            this.pR_SemanasTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.95109F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.04891F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 344F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Controls.Add(this.dgvCuentas, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvCategoria, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvSemanas, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvMateriales, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 102);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 368);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AllowUserToResizeRows = false;
            this.dgvCategoria.AutoGenerateColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCtaCategoria1,
            this.codCategoria,
            this.categoria});
            this.dgvCategoria.DataSource = this.pRctaCategoriaBindingSource;
            this.dgvCategoria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategoria.Location = new System.Drawing.Point(3, 3);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.Size = new System.Drawing.Size(268, 362);
            this.dgvCategoria.TabIndex = 3;
            this.dgvCategoria.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCategoria_DataError);
            this.dgvCategoria.SelectionChanged += new System.EventHandler(this.dgvCategoria_SelectionChanged);
            // 
            // idCtaCategoria1
            // 
            this.idCtaCategoria1.DataPropertyName = "idCtaCategoria";
            this.idCtaCategoria1.HeaderText = "idCtaCategoria";
            this.idCtaCategoria1.MinimumWidth = 6;
            this.idCtaCategoria1.Name = "idCtaCategoria1";
            this.idCtaCategoria1.ReadOnly = true;
            this.idCtaCategoria1.Visible = false;
            this.idCtaCategoria1.Width = 125;
            // 
            // codCategoria
            // 
            this.codCategoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codCategoria.DataPropertyName = "codCategoria";
            this.codCategoria.HeaderText = "Cod.";
            this.codCategoria.MinimumWidth = 6;
            this.codCategoria.Name = "codCategoria";
            this.codCategoria.ReadOnly = true;
            this.codCategoria.Width = 54;
            // 
            // categoria
            // 
            this.categoria.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoria.DataPropertyName = "Categoria";
            this.categoria.HeaderText = "Categoría";
            this.categoria.MinimumWidth = 6;
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // pRctaCategoriaBindingSource
            // 
            this.pRctaCategoriaBindingSource.DataMember = "PR_ctaCategoria";
            this.pRctaCategoriaBindingSource.DataSource = this.dsPresupuesto1;
            // 
            // dsPresupuesto1
            // 
            this.dsPresupuesto1.DataSetName = "DsPresupuesto";
            this.dsPresupuesto1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pR_ctaCategoriaTableAdapter
            // 
            this.pR_ctaCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // coD_DivisionesTableAdapter1
            // 
            this.coD_DivisionesTableAdapter1.ClearBeforeFill = true;
            // 
            // btnSincronizarMat
            // 
            this.btnSincronizarMat.BackColor = System.Drawing.Color.Transparent;
            this.btnSincronizarMat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSincronizarMat.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSincronizarMat.FlatAppearance.BorderSize = 0;
            this.btnSincronizarMat.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSincronizarMat.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSincronizarMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSincronizarMat.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSincronizarMat.Image = ((System.Drawing.Image)(resources.GetObject("btnSincronizarMat.Image")));
            this.btnSincronizarMat.Location = new System.Drawing.Point(841, 12);
            this.btnSincronizarMat.Name = "btnSincronizarMat";
            this.btnSincronizarMat.Size = new System.Drawing.Size(102, 78);
            this.btnSincronizarMat.TabIndex = 13;
            this.btnSincronizarMat.Text = "Sincronizar Materiales";
            this.btnSincronizarMat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSincronizarMat.UseVisualStyleBackColor = false;
            this.btnSincronizarMat.Click += new System.EventHandler(this.btnSincronizarMat_Click);
            // 
            // frmPresupuestoSem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 470);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPresupuestoSem";
            this.Text = "Presupuesto Semanal";
            this.Load += new System.EventHandler(this.frmPresupuestoSem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectMatCuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSemanasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectMatCuentasCantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRCuentasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.DataGridView dgvSemanas;
        private System.Windows.Forms.DataGridView dgvCuentas;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnCancelar;
        private DataSets.DsPresupuesto dsPresupuesto;
        private System.Windows.Forms.BindingSource pRCuentasBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_CuentasTableAdapter pR_CuentasTableAdapter;
        private System.Windows.Forms.BindingSource pRSelectMatCuentasBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_SelectMatCuentasTableAdapter pR_SelectMatCuentasTableAdapter;
        private System.Windows.Forms.BindingSource pRSelectMatCuentasCantBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_SelectMatCuentasCantTableAdapter pR_SelectMatCuentasCantTableAdapter;
        private System.Windows.Forms.BindingSource pRSemanasBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_SemanasTableAdapter pR_SemanasTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private DataSets.DsPresupuesto dsPresupuesto1;
        private System.Windows.Forms.BindingSource pRctaCategoriaBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_ctaCategoriaTableAdapter pR_ctaCategoriaTableAdapter;
        private DataSets.DsCodeasAdiggmTableAdapters.COD_DivisionesTableAdapter coD_DivisionesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPresupuestoSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaContable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCtaCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCtaCategoria1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetPresupuestoSem;
        private System.Windows.Forms.DataGridViewComboBoxColumn idSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad3;
        public System.Windows.Forms.Button btnSincronizarMat;
    }
}