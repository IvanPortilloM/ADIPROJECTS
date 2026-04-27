
namespace ADIGGM.PRESUPUESTO.Mantenimiento
{
    partial class frmAsigCtasMatPrev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsigCtasMatPrev));
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.pRctaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregarTodo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaterial1 = new System.Windows.Forms.TextBox();
            this.lblNoAsig = new System.Windows.Forms.Label();
            this.dgvMatNoAsig = new System.Windows.Forms.DataGridView();
            this.idMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSelectCtasMatPrevioNoAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaterial2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMatAsig = new System.Windows.Forms.DataGridView();
            this.idMaterial2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMaterial2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSelectCtasMatPrevioAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cboCuenta = new System.Windows.Forms.ComboBox();
            this.pRctaCategoriaPRCuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR_SelectCtasMatPrevioNoAsigTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SelectCtasMatPrevioNoAsigTableAdapter();
            this.pR_SelectCtasMatPrevioAsigTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SelectCtasMatPrevioAsigTableAdapter();
            this.pR_ctaCategoriaTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_ctaCategoriaTableAdapter();
            this.pR_CuentasTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_CuentasTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatNoAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectCtasMatPrevioNoAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectCtasMatPrevioAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaPRCuentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 25;
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
            this.cboCategoria.Location = new System.Drawing.Point(238, 53);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(290, 24);
            this.cboCategoria.TabIndex = 24;
            this.cboCategoria.ValueMember = "idCtaCategoria";
            this.cboCategoria.SelectedValueChanged += new System.EventHandler(this.cboCategoria_SelectedValueChanged_1);
            // 
            // pRctaCategoriaBindingSource
            // 
            this.pRctaCategoriaBindingSource.DataMember = "PR_ctaCategoria";
            this.pRctaCategoriaBindingSource.DataSource = this.dsPresupuesto;
            // 
            // dsPresupuesto
            // 
            this.dsPresupuesto.DataSetName = "DsPresupuesto";
            this.dsPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarTodo.FlatAppearance.BorderSize = 0;
            this.btnEliminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarTodo.Image")));
            this.btnEliminarTodo.Location = new System.Drawing.Point(361, 322);
            this.btnEliminarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(56, 44);
            this.btnEliminarTodo.TabIndex = 31;
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(361, 374);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 44);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(361, 435);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 44);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregarTodo
            // 
            this.btnAgregarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarTodo.FlatAppearance.BorderSize = 0;
            this.btnAgregarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTodo.Image")));
            this.btnAgregarTodo.Location = new System.Drawing.Point(361, 487);
            this.btnAgregarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(56, 44);
            this.btnAgregarTodo.TabIndex = 28;
            this.btnAgregarTodo.UseVisualStyleBackColor = true;
            this.btnAgregarTodo.Click += new System.EventHandler(this.btnAgregarTodo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Buscar Materiales:";
            // 
            // txtMaterial1
            // 
            this.txtMaterial1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMaterial1.Location = new System.Drawing.Point(144, 240);
            this.txtMaterial1.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaterial1.Name = "txtMaterial1";
            this.txtMaterial1.Size = new System.Drawing.Size(183, 22);
            this.txtMaterial1.TabIndex = 41;
            this.txtMaterial1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaterial1_KeyPress);
            // 
            // lblNoAsig
            // 
            this.lblNoAsig.AutoSize = true;
            this.lblNoAsig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAsig.Location = new System.Drawing.Point(57, 198);
            this.lblNoAsig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoAsig.Name = "lblNoAsig";
            this.lblNoAsig.Size = new System.Drawing.Size(214, 19);
            this.lblNoAsig.TabIndex = 40;
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
            this.codMaterial,
            this.material});
            this.dgvMatNoAsig.DataSource = this.pRSelectCtasMatPrevioNoAsigBindingSource;
            this.dgvMatNoAsig.Location = new System.Drawing.Point(0, 272);
            this.dgvMatNoAsig.Name = "dgvMatNoAsig";
            this.dgvMatNoAsig.ReadOnly = true;
            this.dgvMatNoAsig.RowHeadersVisible = false;
            this.dgvMatNoAsig.RowHeadersWidth = 51;
            this.dgvMatNoAsig.RowTemplate.Height = 24;
            this.dgvMatNoAsig.Size = new System.Drawing.Size(327, 298);
            this.dgvMatNoAsig.TabIndex = 39;
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
            // codMaterial
            // 
            this.codMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codMaterial.DataPropertyName = "codMaterial";
            this.codMaterial.HeaderText = "Cod.";
            this.codMaterial.MinimumWidth = 6;
            this.codMaterial.Name = "codMaterial";
            this.codMaterial.ReadOnly = true;
            this.codMaterial.Width = 66;
            // 
            // material
            // 
            this.material.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.material.DataPropertyName = "Material";
            this.material.HeaderText = "Material";
            this.material.MinimumWidth = 6;
            this.material.Name = "material";
            this.material.ReadOnly = true;
            // 
            // pRSelectCtasMatPrevioNoAsigBindingSource
            // 
            this.pRSelectCtasMatPrevioNoAsigBindingSource.DataMember = "PR_SelectCtasMatPrevioNoAsig";
            this.pRSelectCtasMatPrevioNoAsigBindingSource.DataSource = this.dsPresupuesto;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Buscar Materiales:";
            // 
            // txtMaterial2
            // 
            this.txtMaterial2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMaterial2.Location = new System.Drawing.Point(581, 240);
            this.txtMaterial2.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaterial2.Name = "txtMaterial2";
            this.txtMaterial2.Size = new System.Drawing.Size(183, 22);
            this.txtMaterial2.TabIndex = 45;
            this.txtMaterial2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaterial2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(532, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Materiales Asignados";
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
            this.dgvMatAsig.DataSource = this.pRSelectCtasMatPrevioAsigBindingSource;
            this.dgvMatAsig.Location = new System.Drawing.Point(449, 272);
            this.dgvMatAsig.Name = "dgvMatAsig";
            this.dgvMatAsig.ReadOnly = true;
            this.dgvMatAsig.RowHeadersVisible = false;
            this.dgvMatAsig.RowHeadersWidth = 51;
            this.dgvMatAsig.RowTemplate.Height = 24;
            this.dgvMatAsig.Size = new System.Drawing.Size(326, 298);
            this.dgvMatAsig.TabIndex = 43;
            this.dgvMatAsig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatAsig_CellClick);
            this.dgvMatAsig.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMatAsig_DataError);
            // 
            // idMaterial2
            // 
            this.idMaterial2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idMaterial2.DataPropertyName = "idMaterial";
            this.idMaterial2.HeaderText = "idMaterial";
            this.idMaterial2.MinimumWidth = 6;
            this.idMaterial2.Name = "idMaterial2";
            this.idMaterial2.ReadOnly = true;
            this.idMaterial2.Visible = false;
            this.idMaterial2.Width = 91;
            // 
            // codMaterial2
            // 
            this.codMaterial2.DataPropertyName = "codMaterial";
            this.codMaterial2.HeaderText = "Cod.";
            this.codMaterial2.MinimumWidth = 6;
            this.codMaterial2.Name = "codMaterial2";
            this.codMaterial2.ReadOnly = true;
            // 
            // material2
            // 
            this.material2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.material2.DataPropertyName = "Material";
            this.material2.HeaderText = "Material";
            this.material2.MinimumWidth = 6;
            this.material2.Name = "material2";
            this.material2.ReadOnly = true;
            // 
            // pRSelectCtasMatPrevioAsigBindingSource
            // 
            this.pRSelectCtasMatPrevioAsigBindingSource.DataMember = "PR_SelectCtasMatPrevioAsig";
            this.pRSelectCtasMatPrevioAsigBindingSource.DataSource = this.dsPresupuesto;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 48;
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
            this.cboCuenta.Location = new System.Drawing.Point(238, 105);
            this.cboCuenta.Name = "cboCuenta";
            this.cboCuenta.Size = new System.Drawing.Size(290, 24);
            this.cboCuenta.TabIndex = 47;
            this.cboCuenta.ValueMember = "idCuenta";
            this.cboCuenta.SelectedValueChanged += new System.EventHandler(this.cboCuenta_SelectedValueChanged);
            // 
            // pRctaCategoriaPRCuentasBindingSource
            // 
            this.pRctaCategoriaPRCuentasBindingSource.DataMember = "PR_ctaCategoria_PR_Cuentas";
            this.pRctaCategoriaPRCuentasBindingSource.DataSource = this.pRctaCategoriaBindingSource;
            // 
            // pR_SelectCtasMatPrevioNoAsigTableAdapter
            // 
            this.pR_SelectCtasMatPrevioNoAsigTableAdapter.ClearBeforeFill = true;
            // 
            // pR_SelectCtasMatPrevioAsigTableAdapter
            // 
            this.pR_SelectCtasMatPrevioAsigTableAdapter.ClearBeforeFill = true;
            // 
            // pR_ctaCategoriaTableAdapter
            // 
            this.pR_ctaCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // pR_CuentasTableAdapter
            // 
            this.pR_CuentasTableAdapter.ClearBeforeFill = true;
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
            this.btnSalir.Location = new System.Drawing.Point(604, 58);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 71);
            this.btnSalir.TabIndex = 68;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAsigCtasMatPrev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 571);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboCuenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaterial2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMatAsig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaterial1);
            this.Controls.Add(this.lblNoAsig);
            this.Controls.Add(this.dgvMatNoAsig);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarTodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCategoria);
            this.Name = "frmAsigCtasMatPrev";
            this.Text = "Asignar Cuentas a Material Previo";
            this.Load += new System.EventHandler(this.frmAsigCtasMatPrev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatNoAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectCtasMatPrevioNoAsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectCtasMatPrevioAsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRctaCategoriaPRCuentasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregarTodo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaterial1;
        private System.Windows.Forms.Label lblNoAsig;
        private System.Windows.Forms.DataGridView dgvMatNoAsig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaterial2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMatAsig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCuenta;
        private DataSets.DsPresupuesto dsPresupuesto;
        private System.Windows.Forms.BindingSource pRSelectCtasMatPrevioNoAsigBindingSource;
        private System.Windows.Forms.BindingSource pRSelectCtasMatPrevioAsigBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_SelectCtasMatPrevioNoAsigTableAdapter pR_SelectCtasMatPrevioNoAsigTableAdapter;
        private DataSets.DsPresupuestoTableAdapters.PR_SelectCtasMatPrevioAsigTableAdapter pR_SelectCtasMatPrevioAsigTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterial2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMaterial2;
        private System.Windows.Forms.DataGridViewTextBoxColumn material2;
        private System.Windows.Forms.BindingSource pRctaCategoriaBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_ctaCategoriaTableAdapter pR_ctaCategoriaTableAdapter;
        private System.Windows.Forms.BindingSource pRctaCategoriaPRCuentasBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_CuentasTableAdapter pR_CuentasTableAdapter;
        public System.Windows.Forms.Button btnSalir;
    }
}