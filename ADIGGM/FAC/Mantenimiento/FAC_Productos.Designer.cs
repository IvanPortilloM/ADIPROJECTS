namespace ADIGGM.FAC.Mantenimiento
{
    partial class FAC_Productos
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoEx = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fACTipoExBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFAC = new ADIGGM.DataSets.DsFAC();
            this.IdTipoFactura = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRTipoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAC_ProductosTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.FAC_ProductosTableAdapter();
            this.fAC_TipoExTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.FAC_TipoExTableAdapter();
            this.tR_TipoFacturasTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.TR_TipoFacturasTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoExBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACProductosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(823, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(783, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(863, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(723, 0);
            this.pgbProcesos.Margin = new System.Windows.Forms.Padding(5);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 393);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(5);
            this.pnlFooter.Size = new System.Drawing.Size(903, 23);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.codProductoDataGridViewTextBoxColumn,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.Descripcion,
            this.IdTipoEx,
            this.IdTipoFactura});
            this.dgvProductos.DataSource = this.fACProductosBindingSource;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvProductos.Location = new System.Drawing.Point(0, 98);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(903, 295);
            this.dgvProductos.TabIndex = 109;
            this.dgvProductos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvProductos_DataError);
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "IdProducto";
            this.idProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codProductoDataGridViewTextBoxColumn
            // 
            this.codProductoDataGridViewTextBoxColumn.DataPropertyName = "CodProducto";
            this.codProductoDataGridViewTextBoxColumn.FillWeight = 108.5312F;
            this.codProductoDataGridViewTextBoxColumn.HeaderText = "Cod Producto";
            this.codProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codProductoDataGridViewTextBoxColumn.Name = "codProductoDataGridViewTextBoxColumn";
            this.codProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "NombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.FillWeight = 165.4462F;
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Nombre Producto";
            this.nombreProductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.FillWeight = 46.61534F;
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.FillWeight = 176.1199F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // IdTipoEx
            // 
            this.IdTipoEx.DataPropertyName = "IdTipoEx";
            this.IdTipoEx.DataSource = this.fACTipoExBindingSource;
            this.IdTipoEx.DisplayMember = "Tipo";
            this.IdTipoEx.FillWeight = 87.0173F;
            this.IdTipoEx.HeaderText = "Tipo";
            this.IdTipoEx.MinimumWidth = 6;
            this.IdTipoEx.Name = "IdTipoEx";
            this.IdTipoEx.ReadOnly = true;
            this.IdTipoEx.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdTipoEx.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdTipoEx.ValueMember = "IdTipoEx";
            // 
            // fACTipoExBindingSource
            // 
            this.fACTipoExBindingSource.DataMember = "FAC_TipoEx";
            this.fACTipoExBindingSource.DataSource = this.dsFAC;
            // 
            // dsFAC
            // 
            this.dsFAC.DataSetName = "DsFAC";
            this.dsFAC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IdTipoFactura
            // 
            this.IdTipoFactura.DataPropertyName = "IdTipoFactura";
            this.IdTipoFactura.DataSource = this.tRTipoFacturasBindingSource;
            this.IdTipoFactura.DisplayMember = "TipoFactura";
            this.IdTipoFactura.FillWeight = 148.721F;
            this.IdTipoFactura.HeaderText = "Tipo Factura";
            this.IdTipoFactura.Name = "IdTipoFactura";
            this.IdTipoFactura.ReadOnly = true;
            this.IdTipoFactura.ValueMember = "IdTipoFactura";
            // 
            // tRTipoFacturasBindingSource
            // 
            this.tRTipoFacturasBindingSource.DataMember = "TR_TipoFacturas";
            this.tRTipoFacturasBindingSource.DataSource = this.dsFAC;
            // 
            // fACProductosBindingSource
            // 
            this.fACProductosBindingSource.DataMember = "FAC_Productos";
            this.fACProductosBindingSource.DataSource = this.dsFAC;
            // 
            // fAC_ProductosTableAdapter
            // 
            this.fAC_ProductosTableAdapter.ClearBeforeFill = true;
            // 
            // fAC_TipoExTableAdapter
            // 
            this.fAC_TipoExTableAdapter.ClearBeforeFill = true;
            // 
            // tR_TipoFacturasTableAdapter
            // 
            this.tR_TipoFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // FAC_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(903, 416);
            this.Controls.Add(this.dgvProductos);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FAC_Productos";
            this.Load += new System.EventHandler(this.FAC_Productos_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvProductos, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoExBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACProductosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private DataSets.DsFAC dsFAC;
        private System.Windows.Forms.BindingSource fACProductosBindingSource;
        private DataSets.DsFACTableAdapters.FAC_ProductosTableAdapter fAC_ProductosTableAdapter;
        private System.Windows.Forms.BindingSource fACTipoExBindingSource;
        private DataSets.DsFACTableAdapters.FAC_TipoExTableAdapter fAC_TipoExTableAdapter;
        private System.Windows.Forms.BindingSource tRTipoFacturasBindingSource;
        private DataSets.DsFACTableAdapters.TR_TipoFacturasTableAdapter tR_TipoFacturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdTipoEx;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdTipoFactura;
    }
}
