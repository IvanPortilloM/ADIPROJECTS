namespace ADIGGM.Mantenimiento
{
    partial class FrmContratistas
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
            this.dgvContratistas = new System.Windows.Forms.DataGridView();
            this.contratistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tRContratistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.tR_ContratistasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ContratistasTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRContratistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
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
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Size = new System.Drawing.Size(120, 19);
            this.lblFooter.Text = "CONTRATISTAS";
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
            // pgbProcesos
            // 
            this.pgbProcesos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 407);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            // 
            // dgvContratistas
            // 
            this.dgvContratistas.AllowUserToAddRows = false;
            this.dgvContratistas.AllowUserToDeleteRows = false;
            this.dgvContratistas.AutoGenerateColumns = false;
            this.dgvContratistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratistas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contratistaDataGridViewTextBoxColumn,
            this.ISR,
            this.activoDataGridViewCheckBoxColumn});
            this.dgvContratistas.DataSource = this.tRContratistasBindingSource;
            this.dgvContratistas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContratistas.Location = new System.Drawing.Point(0, 98);
            this.dgvContratistas.Name = "dgvContratistas";
            this.dgvContratistas.ReadOnly = true;
            this.dgvContratistas.RowHeadersWidth = 51;
            this.dgvContratistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContratistas.Size = new System.Drawing.Size(430, 309);
            this.dgvContratistas.TabIndex = 2;
            this.dgvContratistas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvContratistas_DataError);
            this.dgvContratistas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvContratistas_RowsAdded);
            // 
            // contratistaDataGridViewTextBoxColumn
            // 
            this.contratistaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contratistaDataGridViewTextBoxColumn.DataPropertyName = "Contratista";
            this.contratistaDataGridViewTextBoxColumn.HeaderText = "Contratista";
            this.contratistaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contratistaDataGridViewTextBoxColumn.Name = "contratistaDataGridViewTextBoxColumn";
            this.contratistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ISR
            // 
            this.ISR.DataPropertyName = "ISR";
            this.ISR.HeaderText = "Paga ISR";
            this.ISR.MinimumWidth = 6;
            this.ISR.Name = "ISR";
            this.ISR.ReadOnly = true;
            this.ISR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ISR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ISR.Width = 125;
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
            // tRContratistasBindingSource
            // 
            this.tRContratistasBindingSource.DataMember = "TR_Contratistas";
            this.tRContratistasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tR_ContratistasTableAdapter
            // 
            this.tR_ContratistasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmContratistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(430, 430);
            this.Controls.Add(this.dgvContratistas);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmContratistas";
            this.Load += new System.EventHandler(this.FrmContratistas_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvContratistas, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRContratistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContratistas;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRContratistasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ContratistasTableAdapter tR_ContratistasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn contratistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ISR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
    }
}
