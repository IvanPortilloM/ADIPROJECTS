namespace ADIGGM.Mantenimiento
{
    partial class FrmVehiculos
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
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.idVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctaContableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMotoristaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRMotoristasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.idContratistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRContratistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKTRVehiculosTRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTipoVehiculo = new System.Windows.Forms.Label();
            this.cboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.tR_TipoVehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter();
            this.tR_VehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_VehiculosTableAdapter();
            this.tR_MotoristasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_MotoristasTableAdapter();
            this.tR_ContratistasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ContratistasTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRMotoristasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRContratistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRVehiculosTRTipoVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // lblFooter
            // 
            this.lblFooter.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblFooter.Size = new System.Drawing.Size(93, 19);
            this.lblFooter.Text = "VEHICULOS";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(864, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(824, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(904, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(764, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 477);
            this.pnlFooter.Size = new System.Drawing.Size(944, 23);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AllowUserToAddRows = false;
            this.dgvVehiculos.AllowUserToDeleteRows = false;
            this.dgvVehiculos.AutoGenerateColumns = false;
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculoDataGridViewTextBoxColumn,
            this.codVehiculoDataGridViewTextBoxColumn,
            this.ctaContableDataGridViewTextBoxColumn,
            this.idTipoVehiculoDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.idMotoristaDataGridViewTextBoxColumn,
            this.idContratistaDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dgvVehiculos.DataSource = this.fKTRVehiculosTRTipoVehiculosBindingSource;
            this.dgvVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehiculos.Location = new System.Drawing.Point(0, 166);
            this.dgvVehiculos.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.Size = new System.Drawing.Size(944, 311);
            this.dgvVehiculos.TabIndex = 2;
            this.dgvVehiculos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvVehiculos_DataError);
            this.dgvVehiculos.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvVehiculos_RowsAdded);
            // 
            // idVehiculoDataGridViewTextBoxColumn
            // 
            this.idVehiculoDataGridViewTextBoxColumn.DataPropertyName = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.HeaderText = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.Name = "idVehiculoDataGridViewTextBoxColumn";
            this.idVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVehiculoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codVehiculoDataGridViewTextBoxColumn
            // 
            this.codVehiculoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codVehiculoDataGridViewTextBoxColumn.DataPropertyName = "CodVehiculo";
            this.codVehiculoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codVehiculoDataGridViewTextBoxColumn.Name = "codVehiculoDataGridViewTextBoxColumn";
            this.codVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codVehiculoDataGridViewTextBoxColumn.Width = 73;
            // 
            // ctaContableDataGridViewTextBoxColumn
            // 
            this.ctaContableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ctaContableDataGridViewTextBoxColumn.DataPropertyName = "CtaContable";
            this.ctaContableDataGridViewTextBoxColumn.HeaderText = "CtaContable";
            this.ctaContableDataGridViewTextBoxColumn.Name = "ctaContableDataGridViewTextBoxColumn";
            this.ctaContableDataGridViewTextBoxColumn.ReadOnly = true;
            this.ctaContableDataGridViewTextBoxColumn.Width = 106;
            // 
            // idTipoVehiculoDataGridViewTextBoxColumn
            // 
            this.idTipoVehiculoDataGridViewTextBoxColumn.DataPropertyName = "IdTipoVehiculo";
            this.idTipoVehiculoDataGridViewTextBoxColumn.HeaderText = "Tipo de Vehículo";
            this.idTipoVehiculoDataGridViewTextBoxColumn.Name = "idTipoVehiculoDataGridViewTextBoxColumn";
            this.idTipoVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoVehiculoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTipoVehiculoDataGridViewTextBoxColumn.Visible = false;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            this.placaDataGridViewTextBoxColumn.Width = 65;
            // 
            // idMotoristaDataGridViewTextBoxColumn
            // 
            this.idMotoristaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idMotoristaDataGridViewTextBoxColumn.DataPropertyName = "IdMotorista";
            this.idMotoristaDataGridViewTextBoxColumn.DataSource = this.tRMotoristasBindingSource;
            this.idMotoristaDataGridViewTextBoxColumn.DisplayMember = "Motorista";
            this.idMotoristaDataGridViewTextBoxColumn.HeaderText = "Motorista";
            this.idMotoristaDataGridViewTextBoxColumn.Name = "idMotoristaDataGridViewTextBoxColumn";
            this.idMotoristaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMotoristaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idMotoristaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idMotoristaDataGridViewTextBoxColumn.ValueMember = "IdMotorista";
            // 
            // tRMotoristasBindingSource
            // 
            this.tRMotoristasBindingSource.DataMember = "TR_Motoristas";
            this.tRMotoristasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idContratistaDataGridViewTextBoxColumn
            // 
            this.idContratistaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idContratistaDataGridViewTextBoxColumn.DataPropertyName = "IdContratista";
            this.idContratistaDataGridViewTextBoxColumn.DataSource = this.tRContratistasBindingSource;
            this.idContratistaDataGridViewTextBoxColumn.DisplayMember = "Contratista";
            this.idContratistaDataGridViewTextBoxColumn.HeaderText = "Contratista";
            this.idContratistaDataGridViewTextBoxColumn.Name = "idContratistaDataGridViewTextBoxColumn";
            this.idContratistaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idContratistaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idContratistaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idContratistaDataGridViewTextBoxColumn.ValueMember = "IdContratista";
            // 
            // tRContratistasBindingSource
            // 
            this.tRContratistasBindingSource.DataMember = "TR_Contratistas";
            this.tRContratistasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Width = 49;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // fKTRVehiculosTRTipoVehiculosBindingSource
            // 
            this.fKTRVehiculosTRTipoVehiculosBindingSource.DataMember = "FK_TR_Vehiculos_TR_TipoVehiculos";
            this.fKTRVehiculosTRTipoVehiculosBindingSource.DataSource = this.tRTipoVehiculosBindingSource;
            // 
            // tRTipoVehiculosBindingSource
            // 
            this.tRTipoVehiculosBindingSource.DataMember = "TR_TipoVehiculos";
            this.tRTipoVehiculosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTipoVehiculo);
            this.groupBox1.Controls.Add(this.cboTipoVehiculo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.groupBox1.Size = new System.Drawing.Size(944, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por:";
            // 
            // lblTipoVehiculo
            // 
            this.lblTipoVehiculo.AutoSize = true;
            this.lblTipoVehiculo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoVehiculo.Location = new System.Drawing.Point(238, 28);
            this.lblTipoVehiculo.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblTipoVehiculo.Name = "lblTipoVehiculo";
            this.lblTipoVehiculo.Size = new System.Drawing.Size(110, 16);
            this.lblTipoVehiculo.TabIndex = 1;
            this.lblTipoVehiculo.Text = "Tipo de Vehículo:";
            // 
            // cboTipoVehiculo
            // 
            this.cboTipoVehiculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTipoVehiculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoVehiculo.DataSource = this.tRTipoVehiculosBindingSource;
            this.cboTipoVehiculo.DisplayMember = "TipoVehiculo";
            this.cboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVehiculo.FormattingEnabled = true;
            this.cboTipoVehiculo.Location = new System.Drawing.Point(370, 25);
            this.cboTipoVehiculo.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(209, 24);
            this.cboTipoVehiculo.TabIndex = 0;
            this.cboTipoVehiculo.ValueMember = "IdTipoVehiculo";
            this.cboTipoVehiculo.SelectionChangeCommitted += new System.EventHandler(this.cboTipoVehiculo_SelectionChangeCommitted);
            // 
            // tR_TipoVehiculosTableAdapter
            // 
            this.tR_TipoVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_VehiculosTableAdapter
            // 
            this.tR_VehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // tR_MotoristasTableAdapter
            // 
            this.tR_MotoristasTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ContratistasTableAdapter
            // 
            this.tR_ContratistasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(944, 500);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.Name = "FrmVehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvVehiculos, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRMotoristasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRContratistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRVehiculosTRTipoVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTipoVehiculo;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter tR_TipoVehiculosTableAdapter;
        private System.Windows.Forms.BindingSource fKTRVehiculosTRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_VehiculosTableAdapter tR_VehiculosTableAdapter;
        private System.Windows.Forms.BindingSource tRMotoristasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_MotoristasTableAdapter tR_MotoristasTableAdapter;
        private System.Windows.Forms.BindingSource tRContratistasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ContratistasTableAdapter tR_ContratistasTableAdapter;
        private System.Windows.Forms.Label lblTipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctaContableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idMotoristaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idContratistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
    }
}
