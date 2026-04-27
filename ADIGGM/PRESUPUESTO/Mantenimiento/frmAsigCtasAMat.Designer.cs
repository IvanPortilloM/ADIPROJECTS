
namespace ADIGGM.PRESUPUESTO.Mantenimiento
{
    partial class frmAsigCtasAMat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsigCtasAMat));
            this.label5 = new System.Windows.Forms.Label();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.pRDepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaterial1 = new System.Windows.Forms.TextBox();
            this.lblNoAsig = new System.Windows.Forms.Label();
            this.dgvMatNoAsig = new System.Windows.Forms.DataGridView();
            this.idMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMaterial1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSelectCtasMatNoAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaterial2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvMatAsig = new System.Windows.Forms.DataGridView();
            this.idMaterial2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMaterial2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSelectCtasMatAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarTodo = new System.Windows.Forms.Button();
            this.pR_SelectCtasMatNoAsigTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SelectCtasMatNoAsigTableAdapter();
            this.pR_SelectCtasMatAsigTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SelectCtasMatAsigTableAdapter();
            this.pR_DepartamentosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pRctaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR_ctaCategoriaTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_ctaCategoriaTableAdapter();
            this.pRctaCategoriaPRCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR_CuentasTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_CuentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatNoAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectCtasMatNoAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectCtasMatAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaPRCuentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(148, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "Cuenta:";
            // 
            // cboCuenta
            // 
            this.cboCuenta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboCuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCuenta.DataSource = this.pRctaCategoriaPRCuentasBindingSource;
            this.cboCuenta.DisplayMember = "cuentaContable";
            this.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuenta.FormattingEnabled = true;
            this.cboCuenta.Location = new System.Drawing.Point(281, 154);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(290, 24);
            this.cboCuenta.TabIndex = 51;
            this.cboCuenta.ValueMember = "idCuenta";
            this.cboCuenta.SelectedValueChanged += new System.EventHandler(this.cboCuenta_SelectedValueChanged);
            // 
            // dsPresupuesto
            // 
            this.dsPresupuesto.DataSetName = "DsPresupuesto";
            this.dsPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCategoria.DataSource = this.pRctaCategoriaBindingSource;
            this.cboCategoria.DisplayMember = "Categoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(281, 102);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(290, 24);
            this.cboCategoria.TabIndex = 49;
            this.cboCategoria.ValueMember = "idCtaCategoria";
            this.cboCategoria.SelectedValueChanged += new System.EventHandler(this.cboCategoria_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Departamento:";
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDepartamento.DataSource = this.pRDepartamentosBindingSource;
            this.cboDepartamento.DisplayMember = "Departamento";
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(281, 42);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(290, 24);
            this.cboDepartamento.TabIndex = 53;
            this.cboDepartamento.ValueMember = "idDepartamento";
            this.cboDepartamento.SelectedValueChanged += new System.EventHandler(this.cboDepartamento_SelectedValueChanged);
            // 
            // pRDepartamentosBindingSource
            // 
            this.pRDepartamentosBindingSource.DataMember = "PR_Departamentos";
            this.pRDepartamentosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 58;
            this.label4.Text = "Buscar Materiales:";
            // 
            // txtMaterial1
            // 
            this.txtMaterial1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMaterial1.Location = new System.Drawing.Point(146, 284);
            this.txtMaterial1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaterial1.Name = "txtMaterial1";
            this.txtMaterial1.Size = new System.Drawing.Size(183, 22);
            this.txtMaterial1.TabIndex = 57;
            this.txtMaterial1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaterial1_KeyPress);
            // 
            // lblNoAsig
            // 
            this.lblNoAsig.AutoSize = true;
            this.lblNoAsig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAsig.Location = new System.Drawing.Point(59, 242);
            this.lblNoAsig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoAsig.Name = "lblNoAsig";
            this.lblNoAsig.Size = new System.Drawing.Size(214, 19);
            this.lblNoAsig.TabIndex = 56;
            this.lblNoAsig.Text = "Materiales No Asignadas";
            // 
            // dgvMatNoAsig
            // 
            this.dgvMatNoAsig.AllowUserToAddRows = false;
            this.dgvMatNoAsig.AllowUserToDeleteRows = false;
            this.dgvMatNoAsig.AutoGenerateColumns = false;
            this.dgvMatNoAsig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatNoAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatNoAsig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterial,
            this.codMaterial1,
            this.material1});
            this.dgvMatNoAsig.DataSource = this.pRSelectCtasMatNoAsigBindingSource;
            this.dgvMatNoAsig.Location = new System.Drawing.Point(2, 316);
            this.dgvMatNoAsig.Name = "dgvMatNoAsig";
            this.dgvMatNoAsig.ReadOnly = true;
            this.dgvMatNoAsig.RowHeadersVisible = false;
            this.dgvMatNoAsig.RowHeadersWidth = 51;
            this.dgvMatNoAsig.RowTemplate.Height = 24;
            this.dgvMatNoAsig.Size = new System.Drawing.Size(327, 298);
            this.dgvMatNoAsig.TabIndex = 55;
            this.dgvMatNoAsig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatNoAsig_CellClick);
            this.dgvMatNoAsig.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMatNoAsig_DataError);
            // 
            // idMaterial
            // 
            this.idMaterial.DataPropertyName = "idMaterial";
            this.idMaterial.HeaderText = "idMaterial";
            this.idMaterial.MinimumWidth = 6;
            this.idMaterial.Name = "idMaterial";
            this.idMaterial.ReadOnly = true;
            this.idMaterial.Visible = false;
            // 
            // codMaterial1
            // 
            this.codMaterial1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codMaterial1.DataPropertyName = "codMaterial";
            this.codMaterial1.HeaderText = "Cod.";
            this.codMaterial1.MinimumWidth = 6;
            this.codMaterial1.Name = "codMaterial1";
            this.codMaterial1.ReadOnly = true;
            this.codMaterial1.Width = 66;
            // 
            // material1
            // 
            this.material1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.material1.DataPropertyName = "Material";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.material1.DefaultCellStyle = dataGridViewCellStyle5;
            this.material1.HeaderText = "Material";
            this.material1.MinimumWidth = 6;
            this.material1.Name = "material1";
            this.material1.ReadOnly = true;
            // 
            // pRSelectCtasMatNoAsigBindingSource
            // 
            this.pRSelectCtasMatNoAsigBindingSource.DataMember = "PR_SelectCtasMatNoAsig";
            this.pRSelectCtasMatNoAsigBindingSource.DataSource = this.dsPresupuesto;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Buscar Materiales:";
            // 
            // txtMaterial2
            // 
            this.txtMaterial2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMaterial2.Location = new System.Drawing.Point(606, 284);
            this.txtMaterial2.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaterial2.Name = "txtMaterial2";
            this.txtMaterial2.Size = new System.Drawing.Size(183, 22);
            this.txtMaterial2.TabIndex = 61;
            this.txtMaterial2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaterial2_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(557, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 19);
            this.label6.TabIndex = 60;
            this.label6.Text = "Materiales Asignados";
            // 
            // dgvMatAsig
            // 
            this.dgvMatAsig.AllowUserToAddRows = false;
            this.dgvMatAsig.AllowUserToDeleteRows = false;
            this.dgvMatAsig.AutoGenerateColumns = false;
            this.dgvMatAsig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatAsig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterial2,
            this.codMaterial2,
            this.material2});
            this.dgvMatAsig.DataSource = this.pRSelectCtasMatAsigBindingSource;
            this.dgvMatAsig.Location = new System.Drawing.Point(474, 316);
            this.dgvMatAsig.Name = "dgvMatAsig";
            this.dgvMatAsig.ReadOnly = true;
            this.dgvMatAsig.RowHeadersVisible = false;
            this.dgvMatAsig.RowHeadersWidth = 51;
            this.dgvMatAsig.RowTemplate.Height = 24;
            this.dgvMatAsig.Size = new System.Drawing.Size(326, 298);
            this.dgvMatAsig.TabIndex = 59;
            this.dgvMatAsig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatAsig_CellClick);
            this.dgvMatAsig.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMatAsig_DataError);
            // 
            // idMaterial2
            // 
            this.idMaterial2.DataPropertyName = "idMaterial";
            this.idMaterial2.HeaderText = "idMaterial";
            this.idMaterial2.MinimumWidth = 6;
            this.idMaterial2.Name = "idMaterial2";
            this.idMaterial2.ReadOnly = true;
            this.idMaterial2.Visible = false;
            // 
            // codMaterial2
            // 
            this.codMaterial2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codMaterial2.DataPropertyName = "codMaterial";
            this.codMaterial2.HeaderText = "Cod.";
            this.codMaterial2.MinimumWidth = 6;
            this.codMaterial2.Name = "codMaterial2";
            this.codMaterial2.ReadOnly = true;
            this.codMaterial2.Width = 66;
            // 
            // material2
            // 
            this.material2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.material2.DataPropertyName = "Material";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.material2.DefaultCellStyle = dataGridViewCellStyle6;
            this.material2.HeaderText = "Material";
            this.material2.MinimumWidth = 6;
            this.material2.Name = "material2";
            this.material2.ReadOnly = true;
            // 
            // pRSelectCtasMatAsigBindingSource
            // 
            this.pRSelectCtasMatAsigBindingSource.DataMember = "PR_SelectCtasMatAsig";
            this.pRSelectCtasMatAsigBindingSource.DataSource = this.dsPresupuesto;
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarTodo.FlatAppearance.BorderSize = 0;
            this.btnEliminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarTodo.Image")));
            this.btnEliminarTodo.Location = new System.Drawing.Point(372, 355);
            this.btnEliminarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(56, 44);
            this.btnEliminarTodo.TabIndex = 66;
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(372, 407);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 44);
            this.btnAgregar.TabIndex = 65;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(372, 468);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 44);
            this.btnEliminar.TabIndex = 64;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarTodo
            // 
            this.btnAgregarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarTodo.FlatAppearance.BorderSize = 0;
            this.btnAgregarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTodo.Image")));
            this.btnAgregarTodo.Location = new System.Drawing.Point(372, 520);
            this.btnAgregarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(56, 44);
            this.btnAgregarTodo.TabIndex = 63;
            this.btnAgregarTodo.UseVisualStyleBackColor = true;
            this.btnAgregarTodo.Click += new System.EventHandler(this.btnAgregarTodo_Click);
            // 
            // pR_SelectCtasMatNoAsigTableAdapter
            // 
            this.pR_SelectCtasMatNoAsigTableAdapter.ClearBeforeFill = true;
            // 
            // pR_SelectCtasMatAsigTableAdapter
            // 
            this.pR_SelectCtasMatAsigTableAdapter.ClearBeforeFill = true;
            // 
            // pR_DepartamentosTableAdapter
            // 
            this.pR_DepartamentosTableAdapter.ClearBeforeFill = true;
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
            this.btnSalir.Location = new System.Drawing.Point(656, 82);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 71);
            this.btnSalir.TabIndex = 67;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pRctaCategoriaBindingSource
            // 
            this.pRctaCategoriaBindingSource.DataMember = "PR_ctaCategoria";
            this.pRctaCategoriaBindingSource.DataSource = this.dsPresupuesto;
            // 
            // pR_ctaCategoriaTableAdapter
            // 
            this.pR_ctaCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // pRctaCategoriaPRCuentasBindingSource
            // 
            this.pRctaCategoriaPRCuentasBindingSource.DataMember = "PR_ctaCategoria_PR_Cuentas";
            this.pRctaCategoriaPRCuentasBindingSource.DataSource = this.pRctaCategoriaBindingSource;
            // 
            // pR_CuentasTableAdapter
            // 
            this.pR_CuentasTableAdapter.ClearBeforeFill = true;
            // 
            // frmAsigCtasAMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarTodo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaterial2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvMatAsig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaterial1);
            this.Controls.Add(this.lblNoAsig);
            this.Controls.Add(this.dgvMatNoAsig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCategoria);
            this.Name = "frmAsigCtasAMat";
            this.Text = "Asignar Cuentas a Materiales";
            this.Load += new System.EventHandler(this.frmAsigCtasAMat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatNoAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectCtasMatNoAsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectCtasMatAsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaPRCuentasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaterial1;
        private System.Windows.Forms.Label lblNoAsig;
        private System.Windows.Forms.DataGridView dgvMatNoAsig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaterial2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvMatAsig;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarTodo;
        private DataSets.DsPresupuesto dsPresupuesto;
        private System.Windows.Forms.BindingSource pRSelectCtasMatNoAsigBindingSource;
        private System.Windows.Forms.BindingSource pRSelectCtasMatAsigBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_SelectCtasMatNoAsigTableAdapter pR_SelectCtasMatNoAsigTableAdapter;
        private DataSets.DsPresupuestoTableAdapters.PR_SelectCtasMatAsigTableAdapter pR_SelectCtasMatAsigTableAdapter;
        private System.Windows.Forms.BindingSource pRDepartamentosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter pR_DepartamentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMaterial1;
        private System.Windows.Forms.DataGridViewTextBoxColumn material1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterial2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMaterial2;
        private System.Windows.Forms.DataGridViewTextBoxColumn material2;
        public System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource pRctaCategoriaBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_ctaCategoriaTableAdapter pR_ctaCategoriaTableAdapter;
        private System.Windows.Forms.BindingSource pRctaCategoriaPRCuentasBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_CuentasTableAdapter pR_CuentasTableAdapter;
    }
}