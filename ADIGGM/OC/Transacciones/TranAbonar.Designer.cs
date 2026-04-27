namespace ADIGGM.OC.Transacciones
{
    partial class TranAbonar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranAbonar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cPTipoDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.oCProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cP_TipoDocumentosTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.CP_TipoDocumentosTableAdapter();
            this.oC_ProveedoresTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVerFacturas = new System.Windows.Forms.Button();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cPFacturasEncontradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cP_FacturasEncontradasTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.CP_FacturasEncontradasTableAdapter();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.correlativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abonar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPTipoDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPFacturasEncontradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(68, 19);
            this.lblFooter.Text = "Abonar";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(522, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(482, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(562, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(422, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 438);
            this.pnlFooter.Size = new System.Drawing.Size(602, 23);
            // 
            // cPTipoDocumentosBindingSource
            // 
            this.cPTipoDocumentosBindingSource.DataMember = "CP_TipoDocumentos";
            this.cPTipoDocumentosBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oCProveedoresBindingSource
            // 
            this.oCProveedoresBindingSource.DataMember = "OC_Proveedores";
            this.oCProveedoresBindingSource.DataSource = this.dsOC;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 63);
            this.panel1.TabIndex = 115;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(320, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 45);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(191, 9);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 45);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cP_TipoDocumentosTableAdapter
            // 
            this.cP_TipoDocumentosTableAdapter.ClearBeforeFill = true;
            // 
            // oC_ProveedoresTableAdapter
            // 
            this.oC_ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnVerFacturas);
            this.panel2.Controls.Add(this.cboProveedor);
            this.panel2.Controls.Add(this.cboTipoDocumento);
            this.panel2.Controls.Add(this.dtpFecha);
            this.panel2.Controls.Add(this.txtDocumento);
            this.panel2.Controls.Add(this.txtMonto);
            this.panel2.Controls.Add(this.txtObservacion);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 138);
            this.panel2.TabIndex = 117;
            // 
            // btnVerFacturas
            // 
            this.btnVerFacturas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnVerFacturas.Location = new System.Drawing.Point(471, 100);
            this.btnVerFacturas.Name = "btnVerFacturas";
            this.btnVerFacturas.Size = new System.Drawing.Size(105, 23);
            this.btnVerFacturas.TabIndex = 129;
            this.btnVerFacturas.Text = "Ver Facturas";
            this.btnVerFacturas.UseVisualStyleBackColor = true;
            this.btnVerFacturas.Click += new System.EventHandler(this.btnVerFacturas_Click);
            // 
            // cboProveedor
            // 
            this.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProveedor.DataSource = this.oCProveedoresBindingSource;
            this.cboProveedor.DisplayMember = "NombreProveedor";
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(114, 40);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(230, 24);
            this.cboProveedor.TabIndex = 128;
            this.cboProveedor.ValueMember = "IdProveedor";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DataSource = this.cPTipoDocumentosBindingSource;
            this.cboTipoDocumento.DisplayMember = "TipoDocumento";
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Location = new System.Drawing.Point(114, 11);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(230, 24);
            this.cboTipoDocumento.TabIndex = 127;
            this.cboTipoDocumento.ValueMember = "IdCxpDocumento";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(449, 40);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(150, 21);
            this.dtpFecha.TabIndex = 126;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(449, 11);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(150, 21);
            this.txtDocumento.TabIndex = 125;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(449, 68);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(150, 21);
            this.txtMonto.TabIndex = 124;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(114, 70);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(230, 57);
            this.txtObservacion.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 122;
            this.label6.Text = "Observación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 121;
            this.label5.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 120;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 119;
            this.label3.Text = "# Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 118;
            this.label2.Text = "Proveedor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 117;
            this.label1.Text = "Tipo Documento:";
            // 
            // cPFacturasEncontradasBindingSource
            // 
            this.cPFacturasEncontradasBindingSource.DataMember = "CP_FacturasEncontradas";
            this.cPFacturasEncontradasBindingSource.DataSource = this.dsOC;
            // 
            // cP_FacturasEncontradasTableAdapter
            // 
            this.cP_FacturasEncontradasTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotal.Location = new System.Drawing.Point(0, 354);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(602, 21);
            this.lblTotal.TabIndex = 119;
            this.lblTotal.Text = "label7";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AutoGenerateColumns = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.correlativoDataGridViewTextBoxColumn,
            this.numFacturaDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.Abonar,
            this.Deuda});
            this.dgvFacturas.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cPFacturasEncontradasBindingSource, "TotalGral", true));
            this.dgvFacturas.DataSource = this.cPFacturasEncontradasBindingSource;
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFacturas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvFacturas.Location = new System.Drawing.Point(0, 173);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(602, 181);
            this.dgvFacturas.TabIndex = 120;
            // 
            // correlativoDataGridViewTextBoxColumn
            // 
            this.correlativoDataGridViewTextBoxColumn.DataPropertyName = "Correlativo";
            this.correlativoDataGridViewTextBoxColumn.FillWeight = 87.26025F;
            this.correlativoDataGridViewTextBoxColumn.HeaderText = "Correlativo";
            this.correlativoDataGridViewTextBoxColumn.Name = "correlativoDataGridViewTextBoxColumn";
            this.correlativoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numFacturaDataGridViewTextBoxColumn
            // 
            this.numFacturaDataGridViewTextBoxColumn.DataPropertyName = "NumFactura";
            this.numFacturaDataGridViewTextBoxColumn.FillWeight = 104.737F;
            this.numFacturaDataGridViewTextBoxColumn.HeaderText = "# Factura";
            this.numFacturaDataGridViewTextBoxColumn.Name = "numFacturaDataGridViewTextBoxColumn";
            this.numFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.FillWeight = 161.9163F;
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle1.Format = "N2";
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalDataGridViewTextBoxColumn.FillWeight = 90.16906F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Abonar
            // 
            this.Abonar.DataPropertyName = "Abonar";
            dataGridViewCellStyle2.Format = "N2";
            this.Abonar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Abonar.FillWeight = 79.77531F;
            this.Abonar.HeaderText = "Abonar";
            this.Abonar.Name = "Abonar";
            this.Abonar.ReadOnly = true;
            // 
            // Deuda
            // 
            this.Deuda.DataPropertyName = "Deuda";
            dataGridViewCellStyle3.Format = "N2";
            this.Deuda.DefaultCellStyle = dataGridViewCellStyle3;
            this.Deuda.FillWeight = 76.14214F;
            this.Deuda.HeaderText = "Deuda";
            this.Deuda.Name = "Deuda";
            this.Deuda.ReadOnly = true;
            // 
            // TranAbonar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(602, 461);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TranAbonar";
            this.Text = "Abonar";
            this.Load += new System.EventHandler(this.TranAbonar_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.dgvFacturas, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPTipoDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPFacturasEncontradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.BindingSource cPTipoDocumentosBindingSource;
        private DataSets.DsOCTableAdapters.CP_TipoDocumentosTableAdapter cP_TipoDocumentosTableAdapter;
        private System.Windows.Forms.BindingSource oCProveedoresBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter oC_ProveedoresTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVerFacturas;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cPFacturasEncontradasBindingSource;
        private DataSets.DsOCTableAdapters.CP_FacturasEncontradasTableAdapter cP_FacturasEncontradasTableAdapter;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abonar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
    }
}
