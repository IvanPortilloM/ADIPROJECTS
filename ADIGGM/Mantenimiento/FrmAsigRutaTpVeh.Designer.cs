namespace ADIGGM.Mantenimiento
{
    partial class FrmAsigRutaTpVeh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cboTipoVeh = new System.Windows.Forms.ComboBox();
            this.tRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.tR_TipoVehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter();
            this.gboTipoVeh = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRutaTpVeh = new System.Windows.Forms.DataGridView();
            this.idAsigRutaTipoVeh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRuta = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRRutasFiltradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKTRAsigRutaTipoVehTRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tR_AsigRutaTipoVehTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_AsigRutaTipoVehTableAdapter();
            this.tR_RutasFiltradasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_RutasFiltradasTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            this.gboTipoVeh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutaTpVeh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRRutasFiltradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRAsigRutaTipoVehTRTipoVehiculosBindingSource)).BeginInit();
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
            this.btnMax.Location = new System.Drawing.Point(520, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(480, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(560, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(420, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 407);
            this.pnlFooter.Size = new System.Drawing.Size(600, 23);
            // 
            // cboTipoVeh
            // 
            this.cboTipoVeh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTipoVeh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoVeh.DataSource = this.tRTipoVehiculosBindingSource;
            this.cboTipoVeh.DisplayMember = "TipoVehiculo";
            this.cboTipoVeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVeh.FormattingEnabled = true;
            this.cboTipoVeh.Location = new System.Drawing.Point(208, 19);
            this.cboTipoVeh.Name = "cboTipoVeh";
            this.cboTipoVeh.Size = new System.Drawing.Size(188, 24);
            this.cboTipoVeh.TabIndex = 103;
            this.cboTipoVeh.ValueMember = "IdTipoVehiculo";
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
            // tR_TipoVehiculosTableAdapter
            // 
            this.tR_TipoVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // gboTipoVeh
            // 
            this.gboTipoVeh.Controls.Add(this.label1);
            this.gboTipoVeh.Controls.Add(this.cboTipoVeh);
            this.gboTipoVeh.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboTipoVeh.Location = new System.Drawing.Point(0, 98);
            this.gboTipoVeh.Name = "gboTipoVeh";
            this.gboTipoVeh.Size = new System.Drawing.Size(600, 52);
            this.gboTipoVeh.TabIndex = 104;
            this.gboTipoVeh.TabStop = false;
            this.gboTipoVeh.Text = "Filtrar Por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 104;
            this.label1.Text = "Tipo de Vehículo";
            // 
            // dgvRutaTpVeh
            // 
            this.dgvRutaTpVeh.AllowUserToAddRows = false;
            this.dgvRutaTpVeh.AllowUserToDeleteRows = false;
            this.dgvRutaTpVeh.AutoGenerateColumns = false;
            this.dgvRutaTpVeh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutaTpVeh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsigRutaTipoVeh,
            this.idTipoVehiculo,
            this.idRuta,
            this.Tarifa});
            this.dgvRutaTpVeh.DataSource = this.fKTRAsigRutaTipoVehTRTipoVehiculosBindingSource;
            this.dgvRutaTpVeh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRutaTpVeh.Location = new System.Drawing.Point(0, 150);
            this.dgvRutaTpVeh.Name = "dgvRutaTpVeh";
            this.dgvRutaTpVeh.ReadOnly = true;
            this.dgvRutaTpVeh.Size = new System.Drawing.Size(600, 257);
            this.dgvRutaTpVeh.TabIndex = 105;
            this.dgvRutaTpVeh.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRutaTpVeh_ColumnHeaderMouseClick);
            this.dgvRutaTpVeh.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvRutaTpVeh_DataError);
            this.dgvRutaTpVeh.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvRutaTpVeh_RowsAdded);
            // 
            // idAsigRutaTipoVeh
            // 
            this.idAsigRutaTipoVeh.DataPropertyName = "IdAsigRutaTipoVeh";
            this.idAsigRutaTipoVeh.HeaderText = "IdAsigRutaTipoVeh";
            this.idAsigRutaTipoVeh.Name = "idAsigRutaTipoVeh";
            this.idAsigRutaTipoVeh.ReadOnly = true;
            this.idAsigRutaTipoVeh.Visible = false;
            // 
            // idTipoVehiculo
            // 
            this.idTipoVehiculo.DataPropertyName = "IdTipoVehiculo";
            this.idTipoVehiculo.HeaderText = "IdTipoVehiculo";
            this.idTipoVehiculo.Name = "idTipoVehiculo";
            this.idTipoVehiculo.ReadOnly = true;
            this.idTipoVehiculo.Visible = false;
            // 
            // idRuta
            // 
            this.idRuta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idRuta.DataPropertyName = "IdRuta";
            this.idRuta.DataSource = this.tRRutasFiltradasBindingSource;
            dataGridViewCellStyle1.NullValue = null;
            this.idRuta.DefaultCellStyle = dataGridViewCellStyle1;
            this.idRuta.DisplayMember = "Ruta";
            this.idRuta.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idRuta.HeaderText = "Ruta";
            this.idRuta.MaxDropDownItems = 4;
            this.idRuta.Name = "idRuta";
            this.idRuta.ReadOnly = true;
            this.idRuta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idRuta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idRuta.ValueMember = "IdRuta";
            // 
            // tRRutasFiltradasBindingSource
            // 
            this.tRRutasFiltradasBindingSource.DataMember = "TR_RutasFiltradas";
            this.tRRutasFiltradasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // Tarifa
            // 
            this.Tarifa.DataPropertyName = "Tarifa";
            dataGridViewCellStyle2.Format = "N4";
            dataGridViewCellStyle2.NullValue = null;
            this.Tarifa.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tarifa.HeaderText = "Tarifa";
            this.Tarifa.Name = "Tarifa";
            this.Tarifa.ReadOnly = true;
            // 
            // fKTRAsigRutaTipoVehTRTipoVehiculosBindingSource
            // 
            this.fKTRAsigRutaTipoVehTRTipoVehiculosBindingSource.DataMember = "FK_TR_AsigRutaTipoVeh_TR_TipoVehiculos";
            this.fKTRAsigRutaTipoVehTRTipoVehiculosBindingSource.DataSource = this.tRTipoVehiculosBindingSource;
            // 
            // tR_AsigRutaTipoVehTableAdapter
            // 
            this.tR_AsigRutaTipoVehTableAdapter.ClearBeforeFill = true;
            // 
            // tR_RutasFiltradasTableAdapter
            // 
            this.tR_RutasFiltradasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAsigRutaTpVeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(600, 430);
            this.Controls.Add(this.dgvRutaTpVeh);
            this.Controls.Add(this.gboTipoVeh);
            this.Name = "FrmAsigRutaTpVeh";
            this.Load += new System.EventHandler(this.FrmAsigRutaTpVeh_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.gboTipoVeh, 0);
            this.Controls.SetChildIndex(this.dgvRutaTpVeh, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            this.gboTipoVeh.ResumeLayout(false);
            this.gboTipoVeh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutaTpVeh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRRutasFiltradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRAsigRutaTipoVehTRTipoVehiculosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoVeh;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter tR_TipoVehiculosTableAdapter;
        private System.Windows.Forms.GroupBox gboTipoVeh;
        private System.Windows.Forms.DataGridView dgvRutaTpVeh;
        private System.Windows.Forms.BindingSource fKTRAsigRutaTipoVehTRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_AsigRutaTipoVehTableAdapter tR_AsigRutaTipoVehTableAdapter;
        private System.Windows.Forms.BindingSource tRRutasFiltradasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_RutasFiltradasTableAdapter tR_RutasFiltradasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsigRutaTipoVeh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoVehiculo;
        private System.Windows.Forms.DataGridViewComboBoxColumn idRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
    }
}
