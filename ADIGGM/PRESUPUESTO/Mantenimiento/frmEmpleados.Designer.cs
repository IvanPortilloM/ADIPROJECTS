
namespace ADIGGM.PRESUPUESTO.Mantenimiento
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.pRCargosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.pRtipoContratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRGeneroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKPREmpleadosPRDepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRDepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pREmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDepartamentos = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pR_EmpleadosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_EmpleadosTableAdapter();
            this.pR_CargosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_CargosTableAdapter();
            this.dsPresupuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR_tipoContratosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_tipoContratosTableAdapter();
            this.pR_GeneroTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_GeneroTableAdapter();
            this.pR_DepartamentosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCargo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sueldoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoContrato = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGenero = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fechaCancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aplicaRecontratacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pagoDinamico = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRCargosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRtipoContratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRGeneroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPREmpleadosPRDepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREmpleadosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AutoGenerateColumns = false;
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.codigo,
            this.nombre,
            this.idCargo,
            this.sueldoBase,
            this.sueldoDiario,
            this.idTipoContrato,
            this.fechaIngreso,
            this.idGenero,
            this.fechaCancelacion,
            this.cancelacion,
            this.aplicaRecontratacion,
            this.pagoDinamico,
            this.activo});
            this.dgvEmpleados.DataSource = this.fKPREmpleadosPRDepartamentosBindingSource;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 268);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.RowHeadersVisible = false;
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(1556, 374);
            this.dgvEmpleados.TabIndex = 0;
            this.dgvEmpleados.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvEmpleados_DataError);
            // 
            // pRCargosBindingSource
            // 
            this.pRCargosBindingSource.DataMember = "PR_Cargos";
            this.pRCargosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // dsPresupuesto
            // 
            this.dsPresupuesto.DataSetName = "DsPresupuesto";
            this.dsPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRtipoContratosBindingSource
            // 
            this.pRtipoContratosBindingSource.DataMember = "PR_tipoContratos";
            this.pRtipoContratosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // pRGeneroBindingSource
            // 
            this.pRGeneroBindingSource.DataMember = "PR_Genero";
            this.pRGeneroBindingSource.DataSource = this.dsPresupuesto;
            // 
            // fKPREmpleadosPRDepartamentosBindingSource
            // 
            this.fKPREmpleadosPRDepartamentosBindingSource.DataMember = "FK_PR_Empleados_PR_Departamentos";
            this.fKPREmpleadosPRDepartamentosBindingSource.DataSource = this.pRDepartamentosBindingSource;
            // 
            // pRDepartamentosBindingSource
            // 
            this.pRDepartamentosBindingSource.DataMember = "PR_Departamentos";
            this.pRDepartamentosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // pREmpleadosBindingSource
            // 
            this.pREmpleadosBindingSource.DataMember = "PR_Empleados";
            this.pREmpleadosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(791, 57);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(201, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboDepartamentos);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1556, 268);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(650, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 66;
            this.label3.Text = "Departamentos:";
            // 
            // cboDepartamentos
            // 
            this.cboDepartamentos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboDepartamentos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDepartamentos.DataSource = this.pRDepartamentosBindingSource;
            this.cboDepartamentos.DisplayMember = "Departamento";
            this.cboDepartamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamentos.FormattingEnabled = true;
            this.cboDepartamentos.Location = new System.Drawing.Point(791, 103);
            this.cboDepartamentos.Name = "cboDepartamentos";
            this.cboDepartamentos.Size = new System.Drawing.Size(290, 24);
            this.cboDepartamentos.TabIndex = 65;
            this.cboDepartamentos.ValueMember = "idDepartamento";
            this.cboDepartamentos.SelectedValueChanged += new System.EventHandler(this.cboDepartamentos_SelectedValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(715, 57);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 19);
            this.label15.TabIndex = 64;
            this.label15.Text = "Buscar:";
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
            this.btnEditar.Location = new System.Drawing.Point(811, 162);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 71);
            this.btnEditar.TabIndex = 9;
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
            this.btnGuardar.Location = new System.Drawing.Point(710, 162);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 71);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnSalir.Location = new System.Drawing.Point(1013, 162);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 71);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnCancelar.Location = new System.Drawing.Point(911, 162);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 71);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(609, 162);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 71);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pR_EmpleadosTableAdapter
            // 
            this.pR_EmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // pR_CargosTableAdapter
            // 
            this.pR_CargosTableAdapter.ClearBeforeFill = true;
            // 
            // dsPresupuestoBindingSource
            // 
            this.dsPresupuestoBindingSource.DataSource = this.dsPresupuesto;
            this.dsPresupuestoBindingSource.Position = 0;
            // 
            // pR_tipoContratosTableAdapter
            // 
            this.pR_tipoContratosTableAdapter.ClearBeforeFill = true;
            // 
            // pR_GeneroTableAdapter
            // 
            this.pR_GeneroTableAdapter.ClearBeforeFill = true;
            // 
            // pR_DepartamentosTableAdapter
            // 
            this.pR_DepartamentosTableAdapter.ClearBeforeFill = true;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "idEmpleado";
            this.idEmpleado.MinimumWidth = 6;
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Visible = false;
            this.idEmpleado.Width = 125;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codigo.DataPropertyName = "Codigo";
            this.codigo.HeaderText = "DNI";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // idCargo
            // 
            this.idCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCargo.DataPropertyName = "idCargo";
            this.idCargo.DataSource = this.pRCargosBindingSource;
            this.idCargo.DisplayMember = "Cargo";
            this.idCargo.HeaderText = "Cargo";
            this.idCargo.MinimumWidth = 6;
            this.idCargo.Name = "idCargo";
            this.idCargo.ReadOnly = true;
            this.idCargo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCargo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCargo.ValueMember = "idCargo";
            // 
            // sueldoBase
            // 
            this.sueldoBase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sueldoBase.DataPropertyName = "sueldoBase";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.sueldoBase.DefaultCellStyle = dataGridViewCellStyle2;
            this.sueldoBase.HeaderText = "Sueldo Base";
            this.sueldoBase.MinimumWidth = 6;
            this.sueldoBase.Name = "sueldoBase";
            this.sueldoBase.ReadOnly = true;
            this.sueldoBase.Width = 117;
            // 
            // sueldoDiario
            // 
            this.sueldoDiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sueldoDiario.DataPropertyName = "sueldoDiario";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.sueldoDiario.DefaultCellStyle = dataGridViewCellStyle3;
            this.sueldoDiario.HeaderText = "Sueldo Diario";
            this.sueldoDiario.MinimumWidth = 6;
            this.sueldoDiario.Name = "sueldoDiario";
            this.sueldoDiario.ReadOnly = true;
            this.sueldoDiario.Width = 122;
            // 
            // idTipoContrato
            // 
            this.idTipoContrato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idTipoContrato.DataPropertyName = "idTipoContrato";
            this.idTipoContrato.DataSource = this.pRtipoContratosBindingSource;
            this.idTipoContrato.DisplayMember = "Abreviatura";
            this.idTipoContrato.HeaderText = "Tipo Contrato";
            this.idTipoContrato.MinimumWidth = 6;
            this.idTipoContrato.Name = "idTipoContrato";
            this.idTipoContrato.ReadOnly = true;
            this.idTipoContrato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTipoContrato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idTipoContrato.ValueMember = "idTipoContrato";
            this.idTipoContrato.Width = 123;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fechaIngreso.DataPropertyName = "fechaIngreso";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.fechaIngreso.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaIngreso.HeaderText = "Fecha Ingreso";
            this.fechaIngreso.MinimumWidth = 6;
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            this.fechaIngreso.Width = 127;
            // 
            // idGenero
            // 
            this.idGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idGenero.DataPropertyName = "idGenero";
            this.idGenero.DataSource = this.pRGeneroBindingSource;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.idGenero.DefaultCellStyle = dataGridViewCellStyle5;
            this.idGenero.DisplayMember = "Abreviatura";
            this.idGenero.HeaderText = "Género";
            this.idGenero.MinimumWidth = 6;
            this.idGenero.Name = "idGenero";
            this.idGenero.ReadOnly = true;
            this.idGenero.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idGenero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idGenero.ValueMember = "idGenero";
            this.idGenero.Width = 85;
            // 
            // fechaCancelacion
            // 
            this.fechaCancelacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fechaCancelacion.DataPropertyName = "fechaCancelacion";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.fechaCancelacion.DefaultCellStyle = dataGridViewCellStyle6;
            this.fechaCancelacion.HeaderText = "Fecha Cancelación";
            this.fechaCancelacion.MinimumWidth = 6;
            this.fechaCancelacion.Name = "fechaCancelacion";
            this.fechaCancelacion.ReadOnly = true;
            this.fechaCancelacion.Width = 144;
            // 
            // cancelacion
            // 
            this.cancelacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cancelacion.DataPropertyName = "Cancelacion";
            this.cancelacion.HeaderText = "Cancelación";
            this.cancelacion.MinimumWidth = 6;
            this.cancelacion.Name = "cancelacion";
            this.cancelacion.ReadOnly = true;
            this.cancelacion.Width = 91;
            // 
            // aplicaRecontratacion
            // 
            this.aplicaRecontratacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aplicaRecontratacion.DataPropertyName = "aplicaRecontratacion";
            this.aplicaRecontratacion.HeaderText = "Aplica Recontrat.";
            this.aplicaRecontratacion.MinimumWidth = 6;
            this.aplicaRecontratacion.Name = "aplicaRecontratacion";
            this.aplicaRecontratacion.ReadOnly = true;
            this.aplicaRecontratacion.Width = 110;
            // 
            // pagoDinamico
            // 
            this.pagoDinamico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pagoDinamico.DataPropertyName = "pagoDinamico";
            this.pagoDinamico.HeaderText = "Pago Dinámico";
            this.pagoDinamico.MinimumWidth = 6;
            this.pagoDinamico.Name = "pagoDinamico";
            this.pagoDinamico.ReadOnly = true;
            this.pagoDinamico.Width = 98;
            // 
            // activo
            // 
            this.activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.activo.DataPropertyName = "Activo";
            this.activo.FalseValue = "";
            this.activo.HeaderText = "Activo";
            this.activo.MinimumWidth = 6;
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.TrueValue = "";
            this.activo.Width = 52;
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 642);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRCargosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRtipoContratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRGeneroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPREmpleadosPRDepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pREmpleadosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuestoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label15;
        private DataSets.DsPresupuesto dsPresupuesto;
        private System.Windows.Forms.BindingSource pREmpleadosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_EmpleadosTableAdapter pR_EmpleadosTableAdapter;
        private System.Windows.Forms.BindingSource pRCargosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_CargosTableAdapter pR_CargosTableAdapter;
        private System.Windows.Forms.BindingSource dsPresupuestoBindingSource;
        private System.Windows.Forms.BindingSource pRtipoContratosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_tipoContratosTableAdapter pR_tipoContratosTableAdapter;
        private System.Windows.Forms.BindingSource pRGeneroBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_GeneroTableAdapter pR_GeneroTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDepartamentos;
        private System.Windows.Forms.BindingSource pRDepartamentosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter pR_DepartamentosTableAdapter;
        private System.Windows.Forms.BindingSource fKPREmpleadosPRDepartamentosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoDiario;
        private System.Windows.Forms.DataGridViewComboBoxColumn idTipoContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewComboBoxColumn idGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCancelacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cancelacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aplicaRecontratacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagoDinamico;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
    }
}