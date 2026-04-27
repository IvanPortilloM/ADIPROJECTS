namespace ADIGGM.Mantenimiento
{
    partial class FrmBloques
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
            this.dgvBloques = new System.Windows.Forms.DataGridView();
            this.idBloqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tRBloquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.tR_BloquesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_BloquesTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRBloquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
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
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Size = new System.Drawing.Size(135, 19);
            this.lblFooter.Text = "Ingresar Bloques";
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
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(5);
            // 
            // dgvBloques
            // 
            this.dgvBloques.AllowUserToAddRows = false;
            this.dgvBloques.AllowUserToDeleteRows = false;
            this.dgvBloques.AutoGenerateColumns = false;
            this.dgvBloques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBloqueDataGridViewTextBoxColumn,
            this.bloqueDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn});
            this.dgvBloques.DataSource = this.tRBloquesBindingSource;
            this.dgvBloques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBloques.Location = new System.Drawing.Point(0, 98);
            this.dgvBloques.Name = "dgvBloques";
            this.dgvBloques.ReadOnly = true;
            this.dgvBloques.RowHeadersWidth = 51;
            this.dgvBloques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBloques.Size = new System.Drawing.Size(430, 309);
            this.dgvBloques.TabIndex = 103;
            this.dgvBloques.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvBloques_DataError);
            this.dgvBloques.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvBloques_RowsAdded);
            // 
            // idBloqueDataGridViewTextBoxColumn
            // 
            this.idBloqueDataGridViewTextBoxColumn.DataPropertyName = "IdBloque";
            this.idBloqueDataGridViewTextBoxColumn.HeaderText = "IdBloque";
            this.idBloqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idBloqueDataGridViewTextBoxColumn.Name = "idBloqueDataGridViewTextBoxColumn";
            this.idBloqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.idBloqueDataGridViewTextBoxColumn.Visible = false;
            this.idBloqueDataGridViewTextBoxColumn.Width = 125;
            // 
            // bloqueDataGridViewTextBoxColumn
            // 
            this.bloqueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bloqueDataGridViewTextBoxColumn.DataPropertyName = "Bloque";
            this.bloqueDataGridViewTextBoxColumn.HeaderText = "Bloque";
            this.bloqueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bloqueDataGridViewTextBoxColumn.Name = "bloqueDataGridViewTextBoxColumn";
            this.bloqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.activoDataGridViewCheckBoxColumn.Width = 48;
            // 
            // tRBloquesBindingSource
            // 
            this.tRBloquesBindingSource.DataMember = "TR_Bloques";
            this.tRBloquesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tR_BloquesTableAdapter
            // 
            this.tR_BloquesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBloques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(430, 430);
            this.Controls.Add(this.dgvBloques);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmBloques";
            this.Load += new System.EventHandler(this.FrmBloques_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvBloques, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRBloquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBloques;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRBloquesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_BloquesTableAdapter tR_BloquesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBloqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}
