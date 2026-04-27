
namespace ADIGGM.PRESUPUESTO.Mantenimiento
{
    partial class frmAsigDeptosACtas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsigDeptosACtas));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoAsig = new System.Windows.Forms.Label();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarTodo = new System.Windows.Forms.Button();
            this.dgvCtasNoAsig = new System.Windows.Forms.DataGridView();
            this.idCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSelectDeptoCtasNoAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.dgvCtasAsig = new System.Windows.Forms.DataGridView();
            this.idCuenta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCuenta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaContable2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSelectDeptoCtasAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboDepartamentos = new System.Windows.Forms.ComboBox();
            this.pRDepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR_SelectDeptoCtasNoAsigTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SelectDeptoCtasNoAsigTableAdapter();
            this.pR_SelectDeptoCtasAsigTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SelectDeptoCtasAsigTableAdapter();
            this.pR_DepartamentosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter();
            this.txtCuenta1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuenta2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.pRctaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR_ctaCategoriaTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_ctaCategoriaTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtasNoAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectDeptoCtasNoAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtasAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectDeptoCtasAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Departamentos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Cuentas Asignados";
            // 
            // lblNoAsig
            // 
            this.lblNoAsig.AutoSize = true;
            this.lblNoAsig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAsig.Location = new System.Drawing.Point(59, 221);
            this.lblNoAsig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoAsig.Name = "lblNoAsig";
            this.lblNoAsig.Size = new System.Drawing.Size(197, 19);
            this.lblNoAsig.TabIndex = 31;
            this.lblNoAsig.Text = "Cuentas No Asignadas";
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarTodo.FlatAppearance.BorderSize = 0;
            this.btnEliminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarTodo.Image")));
            this.btnEliminarTodo.Location = new System.Drawing.Point(364, 337);
            this.btnEliminarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(56, 44);
            this.btnEliminarTodo.TabIndex = 30;
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(364, 389);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 44);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(364, 450);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 44);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarTodo
            // 
            this.btnAgregarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarTodo.FlatAppearance.BorderSize = 0;
            this.btnAgregarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTodo.Image")));
            this.btnAgregarTodo.Location = new System.Drawing.Point(364, 502);
            this.btnAgregarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(56, 44);
            this.btnAgregarTodo.TabIndex = 27;
            this.btnAgregarTodo.UseVisualStyleBackColor = true;
            this.btnAgregarTodo.Click += new System.EventHandler(this.btnAgregarTodo_Click);
            // 
            // dgvCtasNoAsig
            // 
            this.dgvCtasNoAsig.AllowUserToAddRows = false;
            this.dgvCtasNoAsig.AllowUserToDeleteRows = false;
            this.dgvCtasNoAsig.AutoGenerateColumns = false;
            this.dgvCtasNoAsig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCtasNoAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtasNoAsig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCuenta,
            this.codCuenta,
            this.cuentaContable});
            this.dgvCtasNoAsig.DataSource = this.pRSelectDeptoCtasNoAsigBindingSource;
            this.dgvCtasNoAsig.Location = new System.Drawing.Point(2, 295);
            this.dgvCtasNoAsig.Name = "dgvCtasNoAsig";
            this.dgvCtasNoAsig.ReadOnly = true;
            this.dgvCtasNoAsig.RowHeadersVisible = false;
            this.dgvCtasNoAsig.RowHeadersWidth = 51;
            this.dgvCtasNoAsig.RowTemplate.Height = 24;
            this.dgvCtasNoAsig.Size = new System.Drawing.Size(327, 298);
            this.dgvCtasNoAsig.TabIndex = 26;
            this.dgvCtasNoAsig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCtasNoAsig_CellClick);
            this.dgvCtasNoAsig.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCtasNoAsig_DataError);
            // 
            // idCuenta
            // 
            this.idCuenta.DataPropertyName = "idCuenta";
            this.idCuenta.HeaderText = "idCuenta";
            this.idCuenta.MinimumWidth = 6;
            this.idCuenta.Name = "idCuenta";
            this.idCuenta.ReadOnly = true;
            this.idCuenta.Visible = false;
            // 
            // codCuenta
            // 
            this.codCuenta.DataPropertyName = "codCuenta";
            this.codCuenta.HeaderText = "Cod. Cuenta";
            this.codCuenta.MinimumWidth = 6;
            this.codCuenta.Name = "codCuenta";
            this.codCuenta.ReadOnly = true;
            // 
            // cuentaContable
            // 
            this.cuentaContable.DataPropertyName = "cuentaContable";
            this.cuentaContable.HeaderText = "Cuenta";
            this.cuentaContable.MinimumWidth = 6;
            this.cuentaContable.Name = "cuentaContable";
            this.cuentaContable.ReadOnly = true;
            // 
            // pRSelectDeptoCtasNoAsigBindingSource
            // 
            this.pRSelectDeptoCtasNoAsigBindingSource.DataMember = "PR_SelectDeptoCtasNoAsig";
            this.pRSelectDeptoCtasNoAsigBindingSource.DataSource = this.dsPresupuesto;
            // 
            // dsPresupuesto
            // 
            this.dsPresupuesto.DataSetName = "DsPresupuesto";
            this.dsPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvCtasAsig
            // 
            this.dgvCtasAsig.AllowUserToAddRows = false;
            this.dgvCtasAsig.AllowUserToDeleteRows = false;
            this.dgvCtasAsig.AutoGenerateColumns = false;
            this.dgvCtasAsig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCtasAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtasAsig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCuenta2,
            this.codCuenta2,
            this.cuentaContable2});
            this.dgvCtasAsig.DataSource = this.pRSelectDeptoCtasAsigBindingSource;
            this.dgvCtasAsig.Location = new System.Drawing.Point(449, 295);
            this.dgvCtasAsig.Name = "dgvCtasAsig";
            this.dgvCtasAsig.ReadOnly = true;
            this.dgvCtasAsig.RowHeadersVisible = false;
            this.dgvCtasAsig.RowHeadersWidth = 51;
            this.dgvCtasAsig.RowTemplate.Height = 24;
            this.dgvCtasAsig.Size = new System.Drawing.Size(326, 298);
            this.dgvCtasAsig.TabIndex = 25;
            this.dgvCtasAsig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCtasAsig_CellClick);
            this.dgvCtasAsig.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCtasAsig_DataError);
            // 
            // idCuenta2
            // 
            this.idCuenta2.DataPropertyName = "idCuenta";
            this.idCuenta2.HeaderText = "idCuenta";
            this.idCuenta2.MinimumWidth = 6;
            this.idCuenta2.Name = "idCuenta2";
            this.idCuenta2.ReadOnly = true;
            this.idCuenta2.Visible = false;
            // 
            // codCuenta2
            // 
            this.codCuenta2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codCuenta2.DataPropertyName = "codCuenta";
            this.codCuenta2.HeaderText = "Cod. Cuenta";
            this.codCuenta2.MinimumWidth = 6;
            this.codCuenta2.Name = "codCuenta2";
            this.codCuenta2.ReadOnly = true;
            this.codCuenta2.Width = 115;
            // 
            // cuentaContable2
            // 
            this.cuentaContable2.DataPropertyName = "cuentaContable";
            this.cuentaContable2.HeaderText = "Cuenta";
            this.cuentaContable2.MinimumWidth = 6;
            this.cuentaContable2.Name = "cuentaContable2";
            this.cuentaContable2.ReadOnly = true;
            // 
            // pRSelectDeptoCtasAsigBindingSource
            // 
            this.pRSelectDeptoCtasAsigBindingSource.DataMember = "PR_SelectDeptoCtasAsig";
            this.pRSelectDeptoCtasAsigBindingSource.DataSource = this.dsPresupuesto;
            // 
            // cboDepartamentos
            // 
            this.cboDepartamentos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboDepartamentos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDepartamentos.DataSource = this.pRDepartamentosBindingSource;
            this.cboDepartamentos.DisplayMember = "Departamento";
            this.cboDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamentos.FormattingEnabled = true;
            this.cboDepartamentos.Location = new System.Drawing.Point(264, 72);
            this.cboDepartamentos.Name = "cboDepartamentos";
            this.cboDepartamentos.Size = new System.Drawing.Size(290, 24);
            this.cboDepartamentos.TabIndex = 24;
            this.cboDepartamentos.ValueMember = "idDepartamento";
            this.cboDepartamentos.SelectedValueChanged += new System.EventHandler(this.cboDepartamentos_SelectedValueChanged);
            // 
            // pRDepartamentosBindingSource
            // 
            this.pRDepartamentosBindingSource.DataMember = "PR_Departamentos";
            this.pRDepartamentosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // pR_SelectDeptoCtasNoAsigTableAdapter
            // 
            this.pR_SelectDeptoCtasNoAsigTableAdapter.ClearBeforeFill = true;
            // 
            // pR_SelectDeptoCtasAsigTableAdapter
            // 
            this.pR_SelectDeptoCtasAsigTableAdapter.ClearBeforeFill = true;
            // 
            // pR_DepartamentosTableAdapter
            // 
            this.pR_DepartamentosTableAdapter.ClearBeforeFill = true;
            // 
            // txtCuenta1
            // 
            this.txtCuenta1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCuenta1.Location = new System.Drawing.Point(130, 263);
            this.txtCuenta1.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuenta1.Name = "txtCuenta1";
            this.txtCuenta1.Size = new System.Drawing.Size(183, 22);
            this.txtCuenta1.TabIndex = 34;
            this.txtCuenta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuenta1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Buscar Cuenta:";
            // 
            // txtCuenta2
            // 
            this.txtCuenta2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCuenta2.Location = new System.Drawing.Point(575, 260);
            this.txtCuenta2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCuenta2.Name = "txtCuenta2";
            this.txtCuenta2.Size = new System.Drawing.Size(183, 22);
            this.txtCuenta2.TabIndex = 36;
            this.txtCuenta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuenta2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "Buscar Cuenta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Categoría:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCategoria.DataSource = this.pRctaCategoriaBindingSource;
            this.cboCategoria.DisplayMember = "Categoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(264, 117);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(290, 24);
            this.cboCategoria.TabIndex = 39;
            this.cboCategoria.ValueMember = "idCtaCategoria";
            this.cboCategoria.SelectedValueChanged += new System.EventHandler(this.cboCategoria_SelectedValueChanged);
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
            this.btnSalir.Location = new System.Drawing.Point(625, 77);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 71);
            this.btnSalir.TabIndex = 68;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAsigDeptosACtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 594);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuenta2);
            this.Controls.Add(this.txtCuenta1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNoAsig);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarTodo);
            this.Controls.Add(this.dgvCtasNoAsig);
            this.Controls.Add(this.dgvCtasAsig);
            this.Controls.Add(this.cboDepartamentos);
            this.Name = "frmAsigDeptosACtas";
            this.Text = "Asignar Departamentos a Cuentas";
            this.Load += new System.EventHandler(this.frmAsigDeptosCtas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtasNoAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectDeptoCtasNoAsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtasAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectDeptoCtasAsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoAsig;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarTodo;
        private System.Windows.Forms.DataGridView dgvCtasNoAsig;
        private System.Windows.Forms.DataGridView dgvCtasAsig;
        private System.Windows.Forms.ComboBox cboDepartamentos;
        private System.Windows.Forms.BindingSource pRSelectDeptoCtasNoAsigBindingSource;
        private DataSets.DsPresupuesto dsPresupuesto;
        private DataSets.DsPresupuestoTableAdapters.PR_SelectDeptoCtasNoAsigTableAdapter pR_SelectDeptoCtasNoAsigTableAdapter;
        private System.Windows.Forms.BindingSource pRSelectDeptoCtasAsigBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_SelectDeptoCtasAsigTableAdapter pR_SelectDeptoCtasAsigTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCuenta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCuenta2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaContable2;
        private System.Windows.Forms.BindingSource pRDepartamentosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter pR_DepartamentosTableAdapter;
        private System.Windows.Forms.TextBox txtCuenta1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuenta2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.BindingSource pRctaCategoriaBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_ctaCategoriaTableAdapter pR_ctaCategoriaTableAdapter;
        public System.Windows.Forms.Button btnSalir;
    }
}