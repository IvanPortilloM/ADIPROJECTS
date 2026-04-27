namespace ADIGGM.FAC.Mantenimiento
{
    partial class FAC_TipoFacturas
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
            this.dgvTipoFactura = new System.Windows.Forms.DataGridView();
            this.fACTipoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFAC = new ADIGGM.DataSets.DsFAC();
            this.fAC_TipoFacturasTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.FAC_TipoFacturasTableAdapter();
            this.idTipoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codTipoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EsTransporte = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFAC)).BeginInit();
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
            this.btnMax.Location = new System.Drawing.Point(497, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(457, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(537, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(397, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 340);
            this.pnlFooter.Size = new System.Drawing.Size(577, 23);
            // 
            // dgvTipoFactura
            // 
            this.dgvTipoFactura.AllowUserToAddRows = false;
            this.dgvTipoFactura.AllowUserToDeleteRows = false;
            this.dgvTipoFactura.AutoGenerateColumns = false;
            this.dgvTipoFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTipoFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoFacturaDataGridViewTextBoxColumn,
            this.codTipoFacturaDataGridViewTextBoxColumn,
            this.tipoFacturaDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.EsTransporte});
            this.dgvTipoFactura.DataSource = this.fACTipoFacturasBindingSource;
            this.dgvTipoFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipoFactura.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTipoFactura.Location = new System.Drawing.Point(0, 98);
            this.dgvTipoFactura.Name = "dgvTipoFactura";
            this.dgvTipoFactura.ReadOnly = true;
            this.dgvTipoFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoFactura.Size = new System.Drawing.Size(577, 242);
            this.dgvTipoFactura.TabIndex = 110;
            // 
            // fACTipoFacturasBindingSource
            // 
            this.fACTipoFacturasBindingSource.DataMember = "FAC_TipoFacturas";
            this.fACTipoFacturasBindingSource.DataSource = this.dsFAC;
            // 
            // dsFAC
            // 
            this.dsFAC.DataSetName = "DsFAC";
            this.dsFAC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fAC_TipoFacturasTableAdapter
            // 
            this.fAC_TipoFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // idTipoFacturaDataGridViewTextBoxColumn
            // 
            this.idTipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "IdTipoFactura";
            this.idTipoFacturaDataGridViewTextBoxColumn.HeaderText = "IdTipoFactura";
            this.idTipoFacturaDataGridViewTextBoxColumn.Name = "idTipoFacturaDataGridViewTextBoxColumn";
            this.idTipoFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoFacturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // codTipoFacturaDataGridViewTextBoxColumn
            // 
            this.codTipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "CodTipoFactura";
            this.codTipoFacturaDataGridViewTextBoxColumn.FillWeight = 100.5413F;
            this.codTipoFacturaDataGridViewTextBoxColumn.HeaderText = "Cod Tipo Factura";
            this.codTipoFacturaDataGridViewTextBoxColumn.Name = "codTipoFacturaDataGridViewTextBoxColumn";
            this.codTipoFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoFacturaDataGridViewTextBoxColumn
            // 
            this.tipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "TipoFactura";
            this.tipoFacturaDataGridViewTextBoxColumn.FillWeight = 202.1742F;
            this.tipoFacturaDataGridViewTextBoxColumn.HeaderText = "Tipo Factura";
            this.tipoFacturaDataGridViewTextBoxColumn.Name = "tipoFacturaDataGridViewTextBoxColumn";
            this.tipoFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.FillWeight = 36.3709F;
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // EsTransporte
            // 
            this.EsTransporte.DataPropertyName = "EsTransporte";
            this.EsTransporte.FillWeight = 60.91371F;
            this.EsTransporte.HeaderText = "Es Transporte";
            this.EsTransporte.Name = "EsTransporte";
            this.EsTransporte.ReadOnly = true;
            // 
            // FAC_TipoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(577, 363);
            this.Controls.Add(this.dgvTipoFactura);
            this.Name = "FAC_TipoFacturas";
            this.Load += new System.EventHandler(this.FAC_TipoFacturas_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvTipoFactura, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFAC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoFactura;
        private DataSets.DsFAC dsFAC;
        private System.Windows.Forms.BindingSource fACTipoFacturasBindingSource;
        private DataSets.DsFACTableAdapters.FAC_TipoFacturasTableAdapter fAC_TipoFacturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsTransporte;
    }
}
