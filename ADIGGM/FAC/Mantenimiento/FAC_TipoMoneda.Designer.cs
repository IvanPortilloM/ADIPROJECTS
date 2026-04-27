namespace ADIGGM.FAC.Mantenimiento
{
    partial class FAC_TipoMoneda
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
            this.dgvTipoMoneda = new System.Windows.Forms.DataGridView();
            this.dsFAC = new ADIGGM.DataSets.DsFAC();
            this.fACTipoMonedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fAC_TipoMonedaTableAdapter = new ADIGGM.DataSets.DsFACTableAdapters.FAC_TipoMonedaTableAdapter();
            this.idTipoMonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMonedaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simboloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorLempirasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFAC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoMonedaBindingSource)).BeginInit();
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
            this.btnMax.Location = new System.Drawing.Point(396, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(356, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(436, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(296, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 287);
            this.pnlFooter.Size = new System.Drawing.Size(476, 23);
            // 
            // dgvTipoMoneda
            // 
            this.dgvTipoMoneda.AllowUserToAddRows = false;
            this.dgvTipoMoneda.AllowUserToDeleteRows = false;
            this.dgvTipoMoneda.AutoGenerateColumns = false;
            this.dgvTipoMoneda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoMoneda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTipoMoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoMoneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoMonedaDataGridViewTextBoxColumn,
            this.tipoMonedaDataGridViewTextBoxColumn,
            this.simboloDataGridViewTextBoxColumn,
            this.valorLempirasDataGridViewTextBoxColumn});
            this.dgvTipoMoneda.DataSource = this.fACTipoMonedaBindingSource;
            this.dgvTipoMoneda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipoMoneda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTipoMoneda.Location = new System.Drawing.Point(0, 98);
            this.dgvTipoMoneda.Name = "dgvTipoMoneda";
            this.dgvTipoMoneda.ReadOnly = true;
            this.dgvTipoMoneda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoMoneda.Size = new System.Drawing.Size(476, 189);
            this.dgvTipoMoneda.TabIndex = 110;
            // 
            // dsFAC
            // 
            this.dsFAC.DataSetName = "DsFAC";
            this.dsFAC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fACTipoMonedaBindingSource
            // 
            this.fACTipoMonedaBindingSource.DataMember = "FAC_TipoMoneda";
            this.fACTipoMonedaBindingSource.DataSource = this.dsFAC;
            // 
            // fAC_TipoMonedaTableAdapter
            // 
            this.fAC_TipoMonedaTableAdapter.ClearBeforeFill = true;
            // 
            // idTipoMonedaDataGridViewTextBoxColumn
            // 
            this.idTipoMonedaDataGridViewTextBoxColumn.DataPropertyName = "IdTipoMoneda";
            this.idTipoMonedaDataGridViewTextBoxColumn.HeaderText = "IdTipoMoneda";
            this.idTipoMonedaDataGridViewTextBoxColumn.Name = "idTipoMonedaDataGridViewTextBoxColumn";
            this.idTipoMonedaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoMonedaDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoMonedaDataGridViewTextBoxColumn
            // 
            this.tipoMonedaDataGridViewTextBoxColumn.DataPropertyName = "TipoMoneda";
            this.tipoMonedaDataGridViewTextBoxColumn.HeaderText = "TipoMoneda";
            this.tipoMonedaDataGridViewTextBoxColumn.Name = "tipoMonedaDataGridViewTextBoxColumn";
            this.tipoMonedaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // simboloDataGridViewTextBoxColumn
            // 
            this.simboloDataGridViewTextBoxColumn.DataPropertyName = "Simbolo";
            this.simboloDataGridViewTextBoxColumn.HeaderText = "Simbolo";
            this.simboloDataGridViewTextBoxColumn.Name = "simboloDataGridViewTextBoxColumn";
            this.simboloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorLempirasDataGridViewTextBoxColumn
            // 
            this.valorLempirasDataGridViewTextBoxColumn.DataPropertyName = "ValorLempiras";
            dataGridViewCellStyle1.Format = "N2";
            this.valorLempirasDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.valorLempirasDataGridViewTextBoxColumn.HeaderText = "ValorLempiras";
            this.valorLempirasDataGridViewTextBoxColumn.Name = "valorLempirasDataGridViewTextBoxColumn";
            this.valorLempirasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FAC_TipoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(476, 310);
            this.Controls.Add(this.dgvTipoMoneda);
            this.Name = "FAC_TipoMoneda";
            this.Load += new System.EventHandler(this.FAC_TipoMoneda_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvTipoMoneda, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFAC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTipoMonedaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoMoneda;
        private DataSets.DsFAC dsFAC;
        private System.Windows.Forms.BindingSource fACTipoMonedaBindingSource;
        private DataSets.DsFACTableAdapters.FAC_TipoMonedaTableAdapter fAC_TipoMonedaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoMonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMonedaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn simboloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorLempirasDataGridViewTextBoxColumn;
    }
}
