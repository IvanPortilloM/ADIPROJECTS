
namespace ADIGGM.PRESUPUESTO.Mantenimiento
{
    partial class frmAsigDeptosAUsu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsigDeptosAUsu));
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.tRUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.dgvDeptosAsig = new System.Windows.Forms.DataGridView();
            this.idDepartamento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSelectDeptoUsuAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.pRSelectDeptoUsuNoAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDeptosNoAsig = new System.Windows.Forms.DataGridView();
            this.idDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarTodo = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.tR_UsuariosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_UsuariosTableAdapter();
            this.pR_SelectDeptoUsuNoAsigTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SelectDeptoUsuNoAsigTableAdapter();
            this.pR_SelectDeptoUsuAsigTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SelectDeptoUsuAsigTableAdapter();
            this.lblRutasNoAsig = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tRUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptosAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectDeptoUsuAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectDeptoUsuNoAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptosNoAsig)).BeginInit();
            this.SuspendLayout();
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboUsuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUsuarios.DataSource = this.tRUsuariosBindingSource;
            this.cboUsuarios.DisplayMember = "NombreApellido";
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(244, 48);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(290, 24);
            this.cboUsuarios.TabIndex = 1;
            this.cboUsuarios.ValueMember = "IdUsuario";
            this.cboUsuarios.SelectedValueChanged += new System.EventHandler(this.cboUsuarios_SelectedValueChanged);
            // 
            // tRUsuariosBindingSource
            // 
            this.tRUsuariosBindingSource.DataMember = "TR_Usuarios";
            this.tRUsuariosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvDeptosAsig
            // 
            this.dgvDeptosAsig.AllowUserToAddRows = false;
            this.dgvDeptosAsig.AllowUserToDeleteRows = false;
            this.dgvDeptosAsig.AutoGenerateColumns = false;
            this.dgvDeptosAsig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeptosAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeptosAsig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartamento2,
            this.departamento2});
            this.dgvDeptosAsig.DataSource = this.pRSelectDeptoUsuAsigBindingSource;
            this.dgvDeptosAsig.Location = new System.Drawing.Point(445, 152);
            this.dgvDeptosAsig.Name = "dgvDeptosAsig";
            this.dgvDeptosAsig.ReadOnly = true;
            this.dgvDeptosAsig.RowHeadersVisible = false;
            this.dgvDeptosAsig.RowHeadersWidth = 51;
            this.dgvDeptosAsig.RowTemplate.Height = 24;
            this.dgvDeptosAsig.Size = new System.Drawing.Size(313, 298);
            this.dgvDeptosAsig.TabIndex = 2;
            this.dgvDeptosAsig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeptosAsig_CellClick);
            this.dgvDeptosAsig.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDeptosAsig_DataError);
            // 
            // idDepartamento2
            // 
            this.idDepartamento2.DataPropertyName = "idDepartamento";
            this.idDepartamento2.HeaderText = "idDepartamento";
            this.idDepartamento2.MinimumWidth = 6;
            this.idDepartamento2.Name = "idDepartamento2";
            this.idDepartamento2.ReadOnly = true;
            this.idDepartamento2.Visible = false;
            // 
            // departamento2
            // 
            this.departamento2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departamento2.DataPropertyName = "Departamento";
            this.departamento2.HeaderText = "Departamento";
            this.departamento2.MinimumWidth = 6;
            this.departamento2.Name = "departamento2";
            this.departamento2.ReadOnly = true;
            // 
            // pRSelectDeptoUsuAsigBindingSource
            // 
            this.pRSelectDeptoUsuAsigBindingSource.DataMember = "PR_SelectDeptoUsuAsig";
            this.pRSelectDeptoUsuAsigBindingSource.DataSource = this.dsPresupuesto;
            // 
            // dsPresupuesto
            // 
            this.dsPresupuesto.DataSetName = "DsPresupuesto";
            this.dsPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRSelectDeptoUsuNoAsigBindingSource
            // 
            this.pRSelectDeptoUsuNoAsigBindingSource.DataMember = "PR_SelectDeptoUsuNoAsig";
            this.pRSelectDeptoUsuNoAsigBindingSource.DataSource = this.dsPresupuesto;
            // 
            // dgvDeptosNoAsig
            // 
            this.dgvDeptosNoAsig.AllowUserToAddRows = false;
            this.dgvDeptosNoAsig.AllowUserToDeleteRows = false;
            this.dgvDeptosNoAsig.AutoGenerateColumns = false;
            this.dgvDeptosNoAsig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeptosNoAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeptosNoAsig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartamento,
            this.departamento});
            this.dgvDeptosNoAsig.DataSource = this.pRSelectDeptoUsuNoAsigBindingSource;
            this.dgvDeptosNoAsig.Location = new System.Drawing.Point(0, 152);
            this.dgvDeptosNoAsig.Name = "dgvDeptosNoAsig";
            this.dgvDeptosNoAsig.ReadOnly = true;
            this.dgvDeptosNoAsig.RowHeadersVisible = false;
            this.dgvDeptosNoAsig.RowHeadersWidth = 51;
            this.dgvDeptosNoAsig.RowTemplate.Height = 24;
            this.dgvDeptosNoAsig.Size = new System.Drawing.Size(327, 298);
            this.dgvDeptosNoAsig.TabIndex = 3;
            this.dgvDeptosNoAsig.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeptosNoAsig_CellClick);
            this.dgvDeptosNoAsig.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDeptosNoAsig_DataError);
            // 
            // idDepartamento
            // 
            this.idDepartamento.DataPropertyName = "idDepartamento";
            this.idDepartamento.HeaderText = "idDepartamento";
            this.idDepartamento.MinimumWidth = 6;
            this.idDepartamento.Name = "idDepartamento";
            this.idDepartamento.ReadOnly = true;
            this.idDepartamento.Visible = false;
            // 
            // departamento
            // 
            this.departamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departamento.DataPropertyName = "Departamento";
            this.departamento.HeaderText = "Departamento";
            this.departamento.MinimumWidth = 6;
            this.departamento.Name = "departamento";
            this.departamento.ReadOnly = true;
            // 
            // btnAgregarTodo
            // 
            this.btnAgregarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarTodo.FlatAppearance.BorderSize = 0;
            this.btnAgregarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTodo.Image")));
            this.btnAgregarTodo.Location = new System.Drawing.Point(355, 370);
            this.btnAgregarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(56, 44);
            this.btnAgregarTodo.TabIndex = 15;
            this.btnAgregarTodo.UseVisualStyleBackColor = true;
            this.btnAgregarTodo.Click += new System.EventHandler(this.btnAgregarTodo_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarTodo.FlatAppearance.BorderSize = 0;
            this.btnEliminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarTodo.Image")));
            this.btnEliminarTodo.Location = new System.Drawing.Point(355, 205);
            this.btnEliminarTodo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(56, 44);
            this.btnEliminarTodo.TabIndex = 20;
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(355, 257);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(56, 44);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(355, 318);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(56, 44);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tR_UsuariosTableAdapter
            // 
            this.tR_UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // pR_SelectDeptoUsuNoAsigTableAdapter
            // 
            this.pR_SelectDeptoUsuNoAsigTableAdapter.ClearBeforeFill = true;
            // 
            // pR_SelectDeptoUsuAsigTableAdapter
            // 
            this.pR_SelectDeptoUsuAsigTableAdapter.ClearBeforeFill = true;
            // 
            // lblRutasNoAsig
            // 
            this.lblRutasNoAsig.AutoSize = true;
            this.lblRutasNoAsig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutasNoAsig.Location = new System.Drawing.Point(13, 130);
            this.lblRutasNoAsig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRutasNoAsig.Name = "lblRutasNoAsig";
            this.lblRutasNoAsig.Size = new System.Drawing.Size(255, 19);
            this.lblRutasNoAsig.TabIndex = 21;
            this.lblRutasNoAsig.Text = "Departamentos No Asignados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Departamentos Asignados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Usuarios:";
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
            this.btnSalir.Location = new System.Drawing.Point(614, 23);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 71);
            this.btnSalir.TabIndex = 69;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAsigDeptosAUsu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(758, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRutasNoAsig);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarTodo);
            this.Controls.Add(this.dgvDeptosNoAsig);
            this.Controls.Add(this.dgvDeptosAsig);
            this.Controls.Add(this.cboUsuarios);
            this.Name = "frmAsigDeptosAUsu";
            this.Text = "Asignar Departamentos a Usuarios";
            this.Load += new System.EventHandler(this.frmAsigDeptosAUsu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tRUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptosAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectDeptoUsuAsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectDeptoUsuNoAsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeptosNoAsig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.DataGridView dgvDeptosAsig;
        private System.Windows.Forms.DataGridView dgvDeptosNoAsig;
        private System.Windows.Forms.Button btnAgregarTodo;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.BindingSource pRSelectDeptoUsuNoAsigBindingSource;
        private DataSets.DsPresupuesto dsPresupuesto;
        private DataSets.DsPresupuestoTableAdapters.PR_SelectDeptoUsuNoAsigTableAdapter pR_SelectDeptoUsuNoAsigTableAdapter;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRUsuariosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_UsuariosTableAdapter tR_UsuariosTableAdapter;
        private System.Windows.Forms.BindingSource pRSelectDeptoUsuAsigBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_SelectDeptoUsuAsigTableAdapter pR_SelectDeptoUsuAsigTableAdapter;
        private System.Windows.Forms.Label lblRutasNoAsig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn departamento;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnSalir;
    }
}