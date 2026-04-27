
namespace ADIGGM.PRESUPUESTO.Mantenimiento
{
    partial class frmMateriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateriales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.idMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUndMedida = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRundMedidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.idTipoMaterial = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRtipoMaterialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pRMaterialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR_MaterialesTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_MaterialesTableAdapter();
            this.pR_undMedidasTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_undMedidasTableAdapter();
            this.pR_tipoMaterialesTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_tipoMaterialesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRundMedidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRtipoMaterialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMaterialesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1270, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
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
            this.btnEditar.Location = new System.Drawing.Point(658, 22);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 71);
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
            this.btnGuardar.Location = new System.Drawing.Point(497, 22);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 71);
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
            this.btnSalir.Location = new System.Drawing.Point(969, 22);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 71);
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
            this.btnCancelar.Location = new System.Drawing.Point(815, 22);
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
            this.btnNuevo.Location = new System.Drawing.Point(339, 22);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 71);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AllowUserToAddRows = false;
            this.dgvMateriales.AllowUserToDeleteRows = false;
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
            this.idMaterialDataGridViewTextBoxColumn,
            this.codMaterial,
            this.material,
            this.descripcion,
            this.precioBase,
            this.porcentaje,
            this.precioReal,
            this.idUndMedida,
            this.idTipoMaterial,
            this.activoDataGridViewCheckBoxColumn});
            this.dgvMateriales.DataSource = this.pRMaterialesBindingSource;
            this.dgvMateriales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMateriales.Location = new System.Drawing.Point(0, 100);
            this.dgvMateriales.MultiSelect = false;
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.ReadOnly = true;
            this.dgvMateriales.RowHeadersVisible = false;
            this.dgvMateriales.RowHeadersWidth = 51;
            this.dgvMateriales.RowTemplate.Height = 24;
            this.dgvMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriales.Size = new System.Drawing.Size(1270, 231);
            this.dgvMateriales.TabIndex = 5;
            this.dgvMateriales.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriales_CellEndEdit);
            this.dgvMateriales.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvMateriales_CellValidating);
            this.dgvMateriales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateriales_CellValueChanged);
            this.dgvMateriales.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMateriales_DataError);
            this.dgvMateriales.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMateriales_EditingControlShowing);
            // 
            // idMaterialDataGridViewTextBoxColumn
            // 
            this.idMaterialDataGridViewTextBoxColumn.DataPropertyName = "idMaterial";
            this.idMaterialDataGridViewTextBoxColumn.HeaderText = "idMaterial";
            this.idMaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMaterialDataGridViewTextBoxColumn.Name = "idMaterialDataGridViewTextBoxColumn";
            this.idMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMaterialDataGridViewTextBoxColumn.Visible = false;
            this.idMaterialDataGridViewTextBoxColumn.Width = 125;
            // 
            // codMaterial
            // 
            this.codMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codMaterial.DataPropertyName = "codMaterial";
            this.codMaterial.HeaderText = "Código";
            this.codMaterial.MinimumWidth = 6;
            this.codMaterial.Name = "codMaterial";
            this.codMaterial.ReadOnly = true;
            this.codMaterial.Width = 81;
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
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // precioBase
            // 
            this.precioBase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.precioBase.DataPropertyName = "precioBase";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.precioBase.DefaultCellStyle = dataGridViewCellStyle2;
            this.precioBase.HeaderText = "Precio Base";
            this.precioBase.MinimumWidth = 6;
            this.precioBase.Name = "precioBase";
            this.precioBase.ReadOnly = true;
            this.precioBase.Width = 113;
            // 
            // porcentaje
            // 
            this.porcentaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.porcentaje.DataPropertyName = "Porcentaje";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.porcentaje.DefaultCellStyle = dataGridViewCellStyle3;
            this.porcentaje.HeaderText = "Porcentaje";
            this.porcentaje.MinimumWidth = 6;
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.ReadOnly = true;
            this.porcentaje.Width = 105;
            // 
            // precioReal
            // 
            this.precioReal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.precioReal.DataPropertyName = "precioReal";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "0";
            this.precioReal.DefaultCellStyle = dataGridViewCellStyle4;
            this.precioReal.HeaderText = "Precio Real";
            this.precioReal.MinimumWidth = 6;
            this.precioReal.Name = "precioReal";
            this.precioReal.ReadOnly = true;
            this.precioReal.Width = 110;
            // 
            // idUndMedida
            // 
            this.idUndMedida.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idUndMedida.DataPropertyName = "idUndMedida";
            this.idUndMedida.DataSource = this.pRundMedidasBindingSource;
            this.idUndMedida.DisplayMember = "unidadMedida";
            this.idUndMedida.HeaderText = "Und Medida";
            this.idUndMedida.MinimumWidth = 6;
            this.idUndMedida.Name = "idUndMedida";
            this.idUndMedida.ReadOnly = true;
            this.idUndMedida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idUndMedida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idUndMedida.ValueMember = "idUndMedida";
            this.idUndMedida.Width = 113;
            // 
            // pRundMedidasBindingSource
            // 
            this.pRundMedidasBindingSource.DataMember = "PR_undMedidas";
            this.pRundMedidasBindingSource.DataSource = this.dsPresupuesto;
            // 
            // dsPresupuesto
            // 
            this.dsPresupuesto.DataSetName = "DsPresupuesto";
            this.dsPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTipoMaterial
            // 
            this.idTipoMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idTipoMaterial.DataPropertyName = "idTipoMaterial";
            this.idTipoMaterial.DataSource = this.pRtipoMaterialesBindingSource;
            this.idTipoMaterial.DisplayMember = "tipoMaterial";
            this.idTipoMaterial.HeaderText = "Tipo Material";
            this.idTipoMaterial.MinimumWidth = 6;
            this.idTipoMaterial.Name = "idTipoMaterial";
            this.idTipoMaterial.ReadOnly = true;
            this.idTipoMaterial.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTipoMaterial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idTipoMaterial.ValueMember = "idTipoMaterial";
            this.idTipoMaterial.Width = 119;
            // 
            // pRtipoMaterialesBindingSource
            // 
            this.pRtipoMaterialesBindingSource.DataMember = "PR_tipoMateriales";
            this.pRtipoMaterialesBindingSource.DataSource = this.dsPresupuesto;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // pRMaterialesBindingSource
            // 
            this.pRMaterialesBindingSource.DataMember = "PR_Materiales";
            this.pRMaterialesBindingSource.DataSource = this.dsPresupuesto;
            // 
            // pR_MaterialesTableAdapter
            // 
            this.pR_MaterialesTableAdapter.ClearBeforeFill = true;
            // 
            // pR_undMedidasTableAdapter
            // 
            this.pR_undMedidasTableAdapter.ClearBeforeFill = true;
            // 
            // pR_tipoMaterialesTableAdapter
            // 
            this.pR_tipoMaterialesTableAdapter.ClearBeforeFill = true;
            // 
            // frmMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 331);
            this.Controls.Add(this.dgvMateriales);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMateriales";
            this.Text = "Materiales";
            this.Load += new System.EventHandler(this.frmMateriales_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRundMedidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRtipoMaterialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRMaterialesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private DataSets.DsPresupuesto dsPresupuesto;
        private System.Windows.Forms.BindingSource pRMaterialesBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_MaterialesTableAdapter pR_MaterialesTableAdapter;
        private System.Windows.Forms.BindingSource pRundMedidasBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_undMedidasTableAdapter pR_undMedidasTableAdapter;
        private System.Windows.Forms.BindingSource pRtipoMaterialesBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_tipoMaterialesTableAdapter pR_tipoMaterialesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioReal;
        private System.Windows.Forms.DataGridViewComboBoxColumn idUndMedida;
        private System.Windows.Forms.DataGridViewComboBoxColumn idTipoMaterial;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}