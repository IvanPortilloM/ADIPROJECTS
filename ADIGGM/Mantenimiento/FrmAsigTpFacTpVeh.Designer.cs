namespace ADIGGM.Mantenimiento
{
    partial class FrmAsigTpFacTpVeh
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
            this.cboTipoFac = new System.Windows.Forms.ComboBox();
            this.tRTipoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodeasAdiggm = new ADIGGM.DataSets.DsCodeasAdiggm();
            this.gboTipoVeh = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvAsigTipoFac = new System.Windows.Forms.DataGridView();
            this.idAsigFacTipoVehDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoVehiculo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.fKTRAsigFacTipoVehTRTipoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tR_TipoFacturasTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.TR_TipoFacturasTableAdapter();
            this.tR_AsigFacTipoVehTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.TR_AsigFacTipoVehTableAdapter();
            this.tR_TipoVehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).BeginInit();
            this.gboTipoVeh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigTipoFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRAsigFacTipoVehTRTipoFacturasBindingSource)).BeginInit();
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
            this.lblFooter.Size = new System.Drawing.Size(316, 19);
            this.lblFooter.Text = "Asignar Tipo Factura a Tipo de Vehiculo";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 407);
            // 
            // cboTipoFac
            // 
            this.cboTipoFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTipoFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoFac.DataSource = this.tRTipoFacturasBindingSource;
            this.cboTipoFac.DisplayMember = "TipoFactura";
            this.cboTipoFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFac.FormattingEnabled = true;
            this.cboTipoFac.Location = new System.Drawing.Point(154, 19);
            this.cboTipoFac.Name = "cboTipoFac";
            this.cboTipoFac.Size = new System.Drawing.Size(188, 24);
            this.cboTipoFac.TabIndex = 103;
            this.cboTipoFac.ValueMember = "IdTipoFactura";
            // 
            // tRTipoFacturasBindingSource
            // 
            this.tRTipoFacturasBindingSource.DataMember = "TR_TipoFacturas";
            this.tRTipoFacturasBindingSource.DataSource = this.dsCodeasAdiggm;
            // 
            // dsCodeasAdiggm
            // 
            this.dsCodeasAdiggm.DataSetName = "DsCodeasAdiggm";
            this.dsCodeasAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gboTipoVeh
            // 
            this.gboTipoVeh.Controls.Add(this.label1);
            this.gboTipoVeh.Controls.Add(this.cboTipoFac);
            this.gboTipoVeh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboTipoVeh.Location = new System.Drawing.Point(0, 98);
            this.gboTipoVeh.Name = "gboTipoVeh";
            this.gboTipoVeh.Size = new System.Drawing.Size(430, 52);
            this.gboTipoVeh.TabIndex = 104;
            this.gboTipoVeh.TabStop = false;
            this.gboTipoVeh.Text = "Filtrar Por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "Tipo de Factura";
            // 
            // dgvAsigTipoFac
            // 
            this.dgvAsigTipoFac.AllowUserToAddRows = false;
            this.dgvAsigTipoFac.AllowUserToDeleteRows = false;
            this.dgvAsigTipoFac.AutoGenerateColumns = false;
            this.dgvAsigTipoFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsigTipoFac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsigFacTipoVehDataGridViewTextBoxColumn,
            this.idTipoFacturaDataGridViewTextBoxColumn,
            this.idTipoVehiculo});
            this.dgvAsigTipoFac.DataSource = this.fKTRAsigFacTipoVehTRTipoFacturasBindingSource;
            this.dgvAsigTipoFac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsigTipoFac.Location = new System.Drawing.Point(0, 150);
            this.dgvAsigTipoFac.Name = "dgvAsigTipoFac";
            this.dgvAsigTipoFac.ReadOnly = true;
            this.dgvAsigTipoFac.Size = new System.Drawing.Size(430, 257);
            this.dgvAsigTipoFac.TabIndex = 105;
            this.dgvAsigTipoFac.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvAsigTipoFac_DataError);
            this.dgvAsigTipoFac.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAsigTipoFac_RowsAdded);
            // 
            // idAsigFacTipoVehDataGridViewTextBoxColumn
            // 
            this.idAsigFacTipoVehDataGridViewTextBoxColumn.DataPropertyName = "IdAsigFacTipoVeh";
            this.idAsigFacTipoVehDataGridViewTextBoxColumn.HeaderText = "IdAsigFacTipoVeh";
            this.idAsigFacTipoVehDataGridViewTextBoxColumn.Name = "idAsigFacTipoVehDataGridViewTextBoxColumn";
            this.idAsigFacTipoVehDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAsigFacTipoVehDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTipoFacturaDataGridViewTextBoxColumn
            // 
            this.idTipoFacturaDataGridViewTextBoxColumn.DataPropertyName = "IdTipoFactura";
            this.idTipoFacturaDataGridViewTextBoxColumn.HeaderText = "IdTipoFactura";
            this.idTipoFacturaDataGridViewTextBoxColumn.Name = "idTipoFacturaDataGridViewTextBoxColumn";
            this.idTipoFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoFacturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTipoVehiculo
            // 
            this.idTipoVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idTipoVehiculo.DataPropertyName = "IdTipoVehiculo";
            this.idTipoVehiculo.DataSource = this.tRTipoVehiculosBindingSource;
            this.idTipoVehiculo.DisplayMember = "TipoVehiculo";
            this.idTipoVehiculo.HeaderText = "Tipo de Vehiculo";
            this.idTipoVehiculo.Name = "idTipoVehiculo";
            this.idTipoVehiculo.ReadOnly = true;
            this.idTipoVehiculo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idTipoVehiculo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idTipoVehiculo.ValueMember = "IdTipoVehiculo";
            // 
            // tRTipoVehiculosBindingSource
            // 
            this.tRTipoVehiculosBindingSource.DataMember = "TR_TipoVehiculos";
            this.tRTipoVehiculosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKTRAsigFacTipoVehTRTipoFacturasBindingSource
            // 
            this.fKTRAsigFacTipoVehTRTipoFacturasBindingSource.DataMember = "FK_TR_AsigFacTipoVeh_TR_TipoFacturas";
            this.fKTRAsigFacTipoVehTRTipoFacturasBindingSource.DataSource = this.tRTipoFacturasBindingSource;
            // 
            // tR_TipoFacturasTableAdapter
            // 
            this.tR_TipoFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // tR_AsigFacTipoVehTableAdapter
            // 
            this.tR_AsigFacTipoVehTableAdapter.ClearBeforeFill = true;
            // 
            // tR_TipoVehiculosTableAdapter
            // 
            this.tR_TipoVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAsigTpFacTpVeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(430, 430);
            this.Controls.Add(this.dgvAsigTipoFac);
            this.Controls.Add(this.gboTipoVeh);
            this.Name = "FrmAsigTpFacTpVeh";
            this.Load += new System.EventHandler(this.FrmAsigTpFacTpVeh_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.gboTipoVeh, 0);
            this.Controls.SetChildIndex(this.dgvAsigTipoFac, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).EndInit();
            this.gboTipoVeh.ResumeLayout(false);
            this.gboTipoVeh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigTipoFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRAsigFacTipoVehTRTipoFacturasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoFac;
        private System.Windows.Forms.GroupBox gboTipoVeh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAsigTipoFac;
        private DataSets.DsCodeasAdiggm dsCodeasAdiggm;
        private System.Windows.Forms.BindingSource tRTipoFacturasBindingSource;
        private DataSets.DsCodeasAdiggmTableAdapters.TR_TipoFacturasTableAdapter tR_TipoFacturasTableAdapter;
        private System.Windows.Forms.BindingSource fKTRAsigFacTipoVehTRTipoFacturasBindingSource;
        private DataSets.DsCodeasAdiggmTableAdapters.TR_AsigFacTipoVehTableAdapter tR_AsigFacTipoVehTableAdapter;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter tR_TipoVehiculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsigFacTipoVehDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idTipoVehiculo;
    }
}
