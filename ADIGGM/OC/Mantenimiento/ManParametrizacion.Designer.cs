namespace ADIGGM.OC.Mantenimiento
{
    partial class ManParametrizacion
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
            this.dgvParametrizacion = new System.Windows.Forms.DataGridView();
            this.idParametrizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCParametrizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.oC_ParametrizacionTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ParametrizacionTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametrizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCParametrizacionBindingSource)).BeginInit();
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
            this.btnNuevo.Visible = false;
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(136, 19);
            this.lblFooter.Text = "Parametrización";
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
            // dgvParametrizacion
            // 
            this.dgvParametrizacion.AllowUserToAddRows = false;
            this.dgvParametrizacion.AllowUserToDeleteRows = false;
            this.dgvParametrizacion.AutoGenerateColumns = false;
            this.dgvParametrizacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParametrizacion.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvParametrizacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametrizacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParametrizacionDataGridViewTextBoxColumn,
            this.iSVDataGridViewTextBoxColumn});
            this.dgvParametrizacion.DataSource = this.oCParametrizacionBindingSource;
            this.dgvParametrizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParametrizacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvParametrizacion.Location = new System.Drawing.Point(0, 98);
            this.dgvParametrizacion.Name = "dgvParametrizacion";
            this.dgvParametrizacion.ReadOnly = true;
            this.dgvParametrizacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParametrizacion.Size = new System.Drawing.Size(430, 216);
            this.dgvParametrizacion.TabIndex = 107;
            // 
            // idParametrizacionDataGridViewTextBoxColumn
            // 
            this.idParametrizacionDataGridViewTextBoxColumn.DataPropertyName = "IdParametrizacion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idParametrizacionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idParametrizacionDataGridViewTextBoxColumn.HeaderText = "IdParametrizacion";
            this.idParametrizacionDataGridViewTextBoxColumn.Name = "idParametrizacionDataGridViewTextBoxColumn";
            this.idParametrizacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idParametrizacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // iSVDataGridViewTextBoxColumn
            // 
            this.iSVDataGridViewTextBoxColumn.DataPropertyName = "ISV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.iSVDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.iSVDataGridViewTextBoxColumn.HeaderText = "ISV";
            this.iSVDataGridViewTextBoxColumn.Name = "iSVDataGridViewTextBoxColumn";
            this.iSVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oCParametrizacionBindingSource
            // 
            this.oCParametrizacionBindingSource.DataMember = "OC_Parametrizacion";
            this.oCParametrizacionBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oC_ParametrizacionTableAdapter
            // 
            this.oC_ParametrizacionTableAdapter.ClearBeforeFill = true;
            // 
            // ManParametrizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(430, 337);
            this.Controls.Add(this.dgvParametrizacion);
            this.Name = "ManParametrizacion";
            this.Text = "Parametrización";
            this.Load += new System.EventHandler(this.ManParametrizacion_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvParametrizacion, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametrizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCParametrizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvParametrizacion;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.BindingSource oCParametrizacionBindingSource;
        private DataSets.DsOCTableAdapters.OC_ParametrizacionTableAdapter oC_ParametrizacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParametrizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSVDataGridViewTextBoxColumn;
    }
}
