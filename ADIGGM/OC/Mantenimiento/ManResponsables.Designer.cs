namespace ADIGGM.OC.Mantenimiento
{
    partial class ManResponsables
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
            this.dgvResponsables = new System.Windows.Forms.DataGridView();
            this.idResponsableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioFirmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewImageColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCResponsablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.oC_ResponsablesTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ResponsablesTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCResponsablesBindingSource)).BeginInit();
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
            this.lblFooter.Size = new System.Drawing.Size(113, 19);
            this.lblFooter.Text = "Responsables";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(488, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(448, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(528, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(388, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 409);
            this.pnlFooter.Size = new System.Drawing.Size(568, 23);
            // 
            // dgvResponsables
            // 
            this.dgvResponsables.AllowUserToAddRows = false;
            this.dgvResponsables.AllowUserToDeleteRows = false;
            this.dgvResponsables.AutoGenerateColumns = false;
            this.dgvResponsables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idResponsableDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.usuarioFirmaDataGridViewTextBoxColumn,
            this.Firma,
            this.activoDataGridViewCheckBoxColumn,
            this.Usuario,
            this.NombreEquipo});
            this.dgvResponsables.DataSource = this.oCResponsablesBindingSource;
            this.dgvResponsables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResponsables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvResponsables.Location = new System.Drawing.Point(0, 98);
            this.dgvResponsables.Name = "dgvResponsables";
            this.dgvResponsables.ReadOnly = true;
            this.dgvResponsables.RowTemplate.Height = 40;
            this.dgvResponsables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResponsables.Size = new System.Drawing.Size(568, 311);
            this.dgvResponsables.TabIndex = 106;
            this.dgvResponsables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvResponsables.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsables_CellContentDoubleClick);
            this.dgvResponsables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResponsables_CellDoubleClick);
            // 
            // idResponsableDataGridViewTextBoxColumn
            // 
            this.idResponsableDataGridViewTextBoxColumn.DataPropertyName = "IdResponsable";
            this.idResponsableDataGridViewTextBoxColumn.HeaderText = "IdResponsable";
            this.idResponsableDataGridViewTextBoxColumn.Name = "idResponsableDataGridViewTextBoxColumn";
            this.idResponsableDataGridViewTextBoxColumn.ReadOnly = true;
            this.idResponsableDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.FillWeight = 113.0288F;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioFirmaDataGridViewTextBoxColumn
            // 
            this.usuarioFirmaDataGridViewTextBoxColumn.DataPropertyName = "UsuarioFirma";
            this.usuarioFirmaDataGridViewTextBoxColumn.FillWeight = 113.0288F;
            this.usuarioFirmaDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioFirmaDataGridViewTextBoxColumn.Name = "usuarioFirmaDataGridViewTextBoxColumn";
            this.usuarioFirmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Firma
            // 
            this.Firma.DataPropertyName = "Firma";
            this.Firma.FillWeight = 113.0288F;
            this.Firma.HeaderText = "Firma";
            this.Firma.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Firma.Name = "Firma";
            this.Firma.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.FillWeight = 60.9137F;
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
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
            // oCResponsablesBindingSource
            // 
            this.oCResponsablesBindingSource.DataMember = "OC_Responsables";
            this.oCResponsablesBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oC_ResponsablesTableAdapter
            // 
            this.oC_ResponsablesTableAdapter.ClearBeforeFill = true;
            // 
            // ManResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(568, 432);
            this.Controls.Add(this.dgvResponsables);
            this.Name = "ManResponsables";
            this.Text = "Responsables";
            this.Load += new System.EventHandler(this.ManResponsables_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvResponsables, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCResponsablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResponsables;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.BindingSource oCResponsablesBindingSource;
        private DataSets.DsOCTableAdapters.OC_ResponsablesTableAdapter oC_ResponsablesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResponsableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioFirmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Firma;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEquipo;
    }
}
