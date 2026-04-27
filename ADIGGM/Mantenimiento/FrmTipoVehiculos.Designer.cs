namespace ADIGGM.Mantenimiento
{
    partial class FrmTipoVehiculos
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
            this.dgvTipoVehiculos = new System.Windows.Forms.DataGridView();
            this.fACTipoExBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.tRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tR_TipoVehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter();
            this.fAC_TipoExTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.FAC_TipoExTableAdapter();
            this.tipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagaISVDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoExBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblFooter.Size = new System.Drawing.Size(187, 20);
            this.lblFooter.Text = "TIPO DE VEHICULOS";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(388, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(348, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(428, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(288, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 407);
            this.pnlFooter.Size = new System.Drawing.Size(468, 23);
            // 
            // dgvTipoVehiculos
            // 
            this.dgvTipoVehiculos.AllowUserToAddRows = false;
            this.dgvTipoVehiculos.AllowUserToDeleteRows = false;
            this.dgvTipoVehiculos.AutoGenerateColumns = false;
            this.dgvTipoVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoVehiculoDataGridViewTextBoxColumn,
            this.pagaISVDataGridViewCheckBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.dgvTipoVehiculos.DataSource = this.tRTipoVehiculosBindingSource;
            this.dgvTipoVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipoVehiculos.Location = new System.Drawing.Point(0, 98);
            this.dgvTipoVehiculos.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.dgvTipoVehiculos.Name = "dgvTipoVehiculos";
            this.dgvTipoVehiculos.ReadOnly = true;
            this.dgvTipoVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoVehiculos.Size = new System.Drawing.Size(468, 309);
            this.dgvTipoVehiculos.TabIndex = 2;
            this.dgvTipoVehiculos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTipoVehiculos_DataError);
            this.dgvTipoVehiculos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTipoVehiculos_RowsAdded);
            // 
            // fACTipoExBindingSource
            // 
            this.fACTipoExBindingSource.DataMember = "FAC_TipoEx";
            this.fACTipoExBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tRTipoVehiculosBindingSource
            // 
            this.tRTipoVehiculosBindingSource.DataMember = "TR_TipoVehiculos";
            this.tRTipoVehiculosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // tR_TipoVehiculosTableAdapter
            // 
            this.tR_TipoVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // fAC_TipoExTableAdapter
            // 
            this.fAC_TipoExTableAdapter.ClearBeforeFill = true;
            // 
            // tipoVehiculoDataGridViewTextBoxColumn
            // 
            this.tipoVehiculoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "TipoVehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.HeaderText = "Tipo de Vehiculo";
            this.tipoVehiculoDataGridViewTextBoxColumn.Name = "tipoVehiculoDataGridViewTextBoxColumn";
            this.tipoVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pagaISVDataGridViewCheckBoxColumn
            // 
            this.pagaISVDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.pagaISVDataGridViewCheckBoxColumn.DataPropertyName = "PagaISV";
            this.pagaISVDataGridViewCheckBoxColumn.HeaderText = "PagaISV";
            this.pagaISVDataGridViewCheckBoxColumn.Name = "pagaISVDataGridViewCheckBoxColumn";
            this.pagaISVDataGridViewCheckBoxColumn.ReadOnly = true;
            this.pagaISVDataGridViewCheckBoxColumn.Width = 55;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Width = 43;
            // 
            // FrmTipoVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(468, 430);
            this.Controls.Add(this.dgvTipoVehiculos);
            this.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.Name = "FrmTipoVehiculos";
            this.Load += new System.EventHandler(this.FrmTipoVehiculos_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvTipoVehiculos, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoExBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoVehiculos;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter tR_TipoVehiculosTableAdapter;
        private System.Windows.Forms.BindingSource fACTipoExBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.FAC_TipoExTableAdapter fAC_TipoExTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagaISVDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}
