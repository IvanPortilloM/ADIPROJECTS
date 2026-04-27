namespace ADIGGM.Mantenimiento
{
    partial class FrmZonas
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
            this.dgvZonas = new System.Windows.Forms.DataGridView();
            this.idZona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tRZonasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.tR_ZonasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ZonasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRZonasBindingSource)).BeginInit();
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
            this.lblFooter.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblFooter.Size = new System.Drawing.Size(120, 19);
            this.lblFooter.Text = "Ingresar Zonas";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // dgvZonas
            // 
            this.dgvZonas.AllowUserToAddRows = false;
            this.dgvZonas.AllowUserToDeleteRows = false;
            this.dgvZonas.AutoGenerateColumns = false;
            this.dgvZonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZona,
            this.Zona,
            this.activo});
            this.dgvZonas.DataSource = this.tRZonasBindingSource;
            this.dgvZonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZonas.Location = new System.Drawing.Point(0, 98);
            this.dgvZonas.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.dgvZonas.Name = "dgvZonas";
            this.dgvZonas.ReadOnly = true;
            this.dgvZonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZonas.Size = new System.Drawing.Size(430, 309);
            this.dgvZonas.TabIndex = 103;
            this.dgvZonas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvZonas_DataError);
            this.dgvZonas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvZonas_RowsAdded);
            // 
            // idZona
            // 
            this.idZona.DataPropertyName = "IdZona";
            this.idZona.HeaderText = "IdZona";
            this.idZona.Name = "idZona";
            this.idZona.ReadOnly = true;
            this.idZona.Visible = false;
            // 
            // Zona
            // 
            this.Zona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Zona.DataPropertyName = "Zona";
            this.Zona.HeaderText = "Zona";
            this.Zona.Name = "Zona";
            this.Zona.ReadOnly = true;
            // 
            // activo
            // 
            this.activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.activo.DataPropertyName = "Activo";
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Width = 43;
            // 
            // tRZonasBindingSource
            // 
            this.tRZonasBindingSource.DataMember = "TR_Zonas";
            this.tRZonasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tR_ZonasTableAdapter
            // 
            this.tR_ZonasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmZonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(430, 430);
            this.Controls.Add(this.dgvZonas);
            this.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.Name = "FrmZonas";
            this.Load += new System.EventHandler(this.FrmZonas_Load);
            this.Controls.SetChildIndex(this.dgvZonas, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRZonasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZonas;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRZonasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ZonasTableAdapter tR_ZonasTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zona;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
    }
}
