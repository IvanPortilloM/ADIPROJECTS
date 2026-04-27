namespace ADIGGM.Mantenimiento
{
    partial class FrmTipoFac
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
            this.dgvTipoFac = new System.Windows.Forms.DataGridView();
            this.idTipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tRTipoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodeasAdiggm = new ADIGGM.DataSets.DsCodeasAdiggm();
            this.tR_TipoFacturasTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.TR_TipoFacturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoFac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).BeginInit();
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
            this.lblFooter.Size = new System.Drawing.Size(201, 19);
            this.lblFooter.Text = "Ingresar Tipo de Facturas";
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
            // dgvTipoFac
            // 
            this.dgvTipoFac.AllowUserToAddRows = false;
            this.dgvTipoFac.AllowUserToDeleteRows = false;
            this.dgvTipoFac.AutoGenerateColumns = false;
            this.dgvTipoFac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoFac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoFactura,
            this.tipoFactura,
            this.Activo});
            this.dgvTipoFac.DataSource = this.tRTipoFacturasBindingSource;
            this.dgvTipoFac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipoFac.Location = new System.Drawing.Point(0, 98);
            this.dgvTipoFac.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.dgvTipoFac.Name = "dgvTipoFac";
            this.dgvTipoFac.ReadOnly = true;
            this.dgvTipoFac.Size = new System.Drawing.Size(430, 309);
            this.dgvTipoFac.TabIndex = 103;
            this.dgvTipoFac.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTipoFac_DataError);
            // 
            // idTipoFactura
            // 
            this.idTipoFactura.DataPropertyName = "IdTipoFactura";
            this.idTipoFactura.HeaderText = "IdTipoFactura";
            this.idTipoFactura.Name = "idTipoFactura";
            this.idTipoFactura.ReadOnly = true;
            this.idTipoFactura.Visible = false;
            // 
            // tipoFactura
            // 
            this.tipoFactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoFactura.DataPropertyName = "TipoFactura";
            this.tipoFactura.HeaderText = "Tipo Factura";
            this.tipoFactura.Name = "tipoFactura";
            this.tipoFactura.ReadOnly = true;
            this.tipoFactura.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Activo
            // 
            this.Activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 43;
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
            // tR_TipoFacturasTableAdapter
            // 
            this.tR_TipoFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTipoFac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(430, 430);
            this.Controls.Add(this.dgvTipoFac);
            this.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.Name = "FrmTipoFac";
            this.Load += new System.EventHandler(this.FrmTipoFac_Load);
            this.Controls.SetChildIndex(this.dgvTipoFac, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoFac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipoFac;
        private DataSets.DsCodeasAdiggm dsCodeasAdiggm;
        private System.Windows.Forms.BindingSource tRTipoFacturasBindingSource;
        private DataSets.DsCodeasAdiggmTableAdapters.TR_TipoFacturasTableAdapter tR_TipoFacturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoFactura;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Activo;
    }
}
