namespace ADIGGM.OC.Mantenimiento
{
    partial class ManTipoOC
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
            this.dgvTiposOC = new System.Windows.Forms.DataGridView();
            this.idTipoOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.combustibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.materialesDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.serviciosDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCTipoOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.oC_TipoOCTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_TipoOCTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCTipoOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
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
            this.lblFooter.Size = new System.Drawing.Size(210, 19);
            this.lblFooter.Text = "Tipos Ordenes de Compra";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(531, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(491, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(571, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(431, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Size = new System.Drawing.Size(611, 23);
            // 
            // dgvTiposOC
            // 
            this.dgvTiposOC.AllowUserToAddRows = false;
            this.dgvTiposOC.AllowUserToDeleteRows = false;
            this.dgvTiposOC.AutoGenerateColumns = false;
            this.dgvTiposOC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiposOC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTiposOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposOC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoOCDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.tipoOCDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.combustibleDataGridViewCheckBoxColumn,
            this.materialesDataGridViewCheckBoxColumn,
            this.serviciosDataGridViewCheckBoxColumn,
            this.Usuario,
            this.NombreEquipo});
            this.dgvTiposOC.DataSource = this.oCTipoOCBindingSource;
            this.dgvTiposOC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTiposOC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTiposOC.Location = new System.Drawing.Point(0, 98);
            this.dgvTiposOC.Name = "dgvTiposOC";
            this.dgvTiposOC.ReadOnly = true;
            this.dgvTiposOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiposOC.Size = new System.Drawing.Size(611, 216);
            this.dgvTiposOC.TabIndex = 106;
            this.dgvTiposOC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiposOC_CellContentClick);
            this.dgvTiposOC.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvTiposOC_CellValueNeeded);
            this.dgvTiposOC.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTiposOC_RowsAdded);
            // 
            // idTipoOCDataGridViewTextBoxColumn
            // 
            this.idTipoOCDataGridViewTextBoxColumn.DataPropertyName = "IdTipoOC";
            this.idTipoOCDataGridViewTextBoxColumn.HeaderText = "IdTipoOC";
            this.idTipoOCDataGridViewTextBoxColumn.Name = "idTipoOCDataGridViewTextBoxColumn";
            this.idTipoOCDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoOCDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.FillWeight = 82.12695F;
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoOCDataGridViewTextBoxColumn
            // 
            this.tipoOCDataGridViewTextBoxColumn.DataPropertyName = "TipoOC";
            this.tipoOCDataGridViewTextBoxColumn.FillWeight = 145.3647F;
            this.tipoOCDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoOCDataGridViewTextBoxColumn.Name = "tipoOCDataGridViewTextBoxColumn";
            this.tipoOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.FillWeight = 74.98145F;
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // combustibleDataGridViewCheckBoxColumn
            // 
            this.combustibleDataGridViewCheckBoxColumn.DataPropertyName = "Combustible";
            this.combustibleDataGridViewCheckBoxColumn.FillWeight = 106.5633F;
            this.combustibleDataGridViewCheckBoxColumn.HeaderText = "Combustible";
            this.combustibleDataGridViewCheckBoxColumn.Name = "combustibleDataGridViewCheckBoxColumn";
            this.combustibleDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // materialesDataGridViewCheckBoxColumn
            // 
            this.materialesDataGridViewCheckBoxColumn.DataPropertyName = "Materiales";
            this.materialesDataGridViewCheckBoxColumn.FillWeight = 99.59302F;
            this.materialesDataGridViewCheckBoxColumn.HeaderText = "Materiales";
            this.materialesDataGridViewCheckBoxColumn.Name = "materialesDataGridViewCheckBoxColumn";
            this.materialesDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // serviciosDataGridViewCheckBoxColumn
            // 
            this.serviciosDataGridViewCheckBoxColumn.DataPropertyName = "Servicios";
            this.serviciosDataGridViewCheckBoxColumn.FillWeight = 91.37056F;
            this.serviciosDataGridViewCheckBoxColumn.HeaderText = "Servicios";
            this.serviciosDataGridViewCheckBoxColumn.Name = "serviciosDataGridViewCheckBoxColumn";
            this.serviciosDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            this.Usuario.Visible = false;
            // 
            // NombreEquipo
            // 
            this.NombreEquipo.DataPropertyName = "NombreEquipo";
            this.NombreEquipo.HeaderText = "NombreEquipo";
            this.NombreEquipo.Name = "NombreEquipo";
            this.NombreEquipo.ReadOnly = true;
            this.NombreEquipo.Visible = false;
            // 
            // oCTipoOCBindingSource
            // 
            this.oCTipoOCBindingSource.DataMember = "OC_TipoOC";
            this.oCTipoOCBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oC_TipoOCTableAdapter
            // 
            this.oC_TipoOCTableAdapter.ClearBeforeFill = true;
            // 
            // ManTipoOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(611, 337);
            this.Controls.Add(this.dgvTiposOC);
            this.Name = "ManTipoOC";
            this.Text = "Tipos OC";
            this.Load += new System.EventHandler(this.ManTipoOC_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvTiposOC, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCTipoOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTiposOC;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.BindingSource oCTipoOCBindingSource;
        private DataSets.DsOCTableAdapters.OC_TipoOCTableAdapter oC_TipoOCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn combustibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn materialesDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn serviciosDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEquipo;
    }
}
