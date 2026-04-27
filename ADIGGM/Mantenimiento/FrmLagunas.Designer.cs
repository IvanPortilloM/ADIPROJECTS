namespace ADIGGM.Mantenimiento
{
    partial class FrmLagunas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFincas = new System.Windows.Forms.ComboBox();
            this.tRFincasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.dgvLaguanas = new System.Windows.Forms.DataGridView();
            this.idLagunaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laguna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdZona = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRZonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdBloque = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRBloquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idFincaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKTRLagunasTRFincasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tR_FincasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_FincasTableAdapter();
            this.tR_LagunasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_LagunasTableAdapter();
            this.tR_ZonasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ZonasTableAdapter();
            this.tR_BloquesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_BloquesTableAdapter();
            this.pnlFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRFincasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaguanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRZonasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRBloquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRLagunasTRFincasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblFooter.Size = new System.Drawing.Size(141, 19);
            this.lblFooter.Text = "Ingresar Lagunas";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboFincas);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.groupBox1.Size = new System.Drawing.Size(600, 50);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fincas:";
            // 
            // cboFincas
            // 
            this.cboFincas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboFincas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboFincas.DataSource = this.tRFincasBindingSource;
            this.cboFincas.DisplayMember = "Finca";
            this.cboFincas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFincas.FormattingEnabled = true;
            this.cboFincas.Location = new System.Drawing.Point(224, 20);
            this.cboFincas.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.cboFincas.Name = "cboFincas";
            this.cboFincas.Size = new System.Drawing.Size(167, 24);
            this.cboFincas.TabIndex = 0;
            this.cboFincas.ValueMember = "IdFinca";
            this.cboFincas.SelectionChangeCommitted += new System.EventHandler(this.CboFincas_SelectionChangeCommitted);
            // 
            // tRFincasBindingSource
            // 
            this.tRFincasBindingSource.DataMember = "TR_Fincas";
            this.tRFincasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvLaguanas
            // 
            this.dgvLaguanas.AllowUserToAddRows = false;
            this.dgvLaguanas.AllowUserToDeleteRows = false;
            this.dgvLaguanas.AutoGenerateColumns = false;
            this.dgvLaguanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaguanas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLagunaDataGridViewTextBoxColumn,
            this.laguna,
            this.IdZona,
            this.IdBloque,
            this.activo,
            this.idFincaDataGridViewTextBoxColumn});
            this.dgvLaguanas.DataSource = this.fKTRLagunasTRFincasBindingSource;
            this.dgvLaguanas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLaguanas.Location = new System.Drawing.Point(0, 148);
            this.dgvLaguanas.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.dgvLaguanas.Name = "dgvLaguanas";
            this.dgvLaguanas.ReadOnly = true;
            this.dgvLaguanas.Size = new System.Drawing.Size(600, 259);
            this.dgvLaguanas.TabIndex = 104;
            this.dgvLaguanas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DgvLaguanas_DataError);
            this.dgvLaguanas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvLaguanas_RowsAdded);
            // 
            // idLagunaDataGridViewTextBoxColumn
            // 
            this.idLagunaDataGridViewTextBoxColumn.DataPropertyName = "IdLaguna";
            this.idLagunaDataGridViewTextBoxColumn.HeaderText = "IdLaguna";
            this.idLagunaDataGridViewTextBoxColumn.Name = "idLagunaDataGridViewTextBoxColumn";
            this.idLagunaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLagunaDataGridViewTextBoxColumn.Visible = false;
            // 
            // laguna
            // 
            this.laguna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.laguna.DataPropertyName = "Laguna";
            this.laguna.HeaderText = "Laguna";
            this.laguna.Name = "laguna";
            this.laguna.ReadOnly = true;
            // 
            // IdZona
            // 
            this.IdZona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdZona.DataPropertyName = "IdZona";
            this.IdZona.DataSource = this.tRZonasBindingSource;
            this.IdZona.DisplayMember = "Zona";
            this.IdZona.HeaderText = "Zona";
            this.IdZona.Name = "IdZona";
            this.IdZona.ReadOnly = true;
            this.IdZona.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdZona.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdZona.ValueMember = "IdZona";
            // 
            // tRZonasBindingSource
            // 
            this.tRZonasBindingSource.DataMember = "TR_Zonas";
            this.tRZonasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // IdBloque
            // 
            this.IdBloque.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdBloque.DataPropertyName = "IdBloque";
            this.IdBloque.DataSource = this.tRBloquesBindingSource;
            this.IdBloque.DisplayMember = "Bloque";
            this.IdBloque.HeaderText = "Bloque";
            this.IdBloque.Name = "IdBloque";
            this.IdBloque.ReadOnly = true;
            this.IdBloque.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdBloque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdBloque.ValueMember = "IdBloque";
            // 
            // tRBloquesBindingSource
            // 
            this.tRBloquesBindingSource.DataMember = "TR_Bloques";
            this.tRBloquesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // activo
            // 
            this.activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.activo.DataPropertyName = "Activo";
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Width = 48;
            // 
            // idFincaDataGridViewTextBoxColumn
            // 
            this.idFincaDataGridViewTextBoxColumn.DataPropertyName = "IdFinca";
            this.idFincaDataGridViewTextBoxColumn.HeaderText = "IdFinca";
            this.idFincaDataGridViewTextBoxColumn.Name = "idFincaDataGridViewTextBoxColumn";
            this.idFincaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idFincaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fKTRLagunasTRFincasBindingSource
            // 
            this.fKTRLagunasTRFincasBindingSource.DataMember = "FK_TR_Lagunas_TR_Fincas";
            this.fKTRLagunasTRFincasBindingSource.DataSource = this.tRFincasBindingSource;
            // 
            // tR_FincasTableAdapter
            // 
            this.tR_FincasTableAdapter.ClearBeforeFill = true;
            // 
            // tR_LagunasTableAdapter
            // 
            this.tR_LagunasTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ZonasTableAdapter
            // 
            this.tR_ZonasTableAdapter.ClearBeforeFill = true;
            // 
            // tR_BloquesTableAdapter
            // 
            this.tR_BloquesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmLagunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(600, 430);
            this.Controls.Add(this.dgvLaguanas);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.Name = "FrmLagunas";
            this.Load += new System.EventHandler(this.FrmLagunas_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvLaguanas, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRFincasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaguanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRZonasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRBloquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRLagunasTRFincasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboFincas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLaguanas;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRFincasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_FincasTableAdapter tR_FincasTableAdapter;
        private System.Windows.Forms.BindingSource fKTRLagunasTRFincasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_LagunasTableAdapter tR_LagunasTableAdapter;
        private System.Windows.Forms.BindingSource tRZonasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ZonasTableAdapter tR_ZonasTableAdapter;
        private System.Windows.Forms.BindingSource tRBloquesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_BloquesTableAdapter tR_BloquesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLagunaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laguna;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdZona;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdBloque;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFincaDataGridViewTextBoxColumn;
    }
}
