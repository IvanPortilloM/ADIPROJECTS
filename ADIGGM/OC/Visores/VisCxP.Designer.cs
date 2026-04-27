namespace ADIGGM.OC.Visores
{
    partial class VisCxP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisCxP));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResumen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTodas = new System.Windows.Forms.RadioButton();
            this.rdbCanceladas = new System.Windows.Forms.RadioButton();
            this.rdbActivas = new System.Windows.Forms.RadioButton();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.oCProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOCDet = new System.Windows.Forms.DataGridView();
            this.idCxPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDesdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoAbonadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cPCxPVisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oC_ProveedoresTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter();
            this.cP_CxPVisorTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.CP_CxPVisorTableAdapter();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOCDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPCxPVisorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(193, 19);
            this.lblFooter.Text = "Visor Cuentas por Pagar";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(783, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(743, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(823, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(683, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 432);
            this.pnlFooter.Size = new System.Drawing.Size(863, 23);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResumen);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.btnAbonar);
            this.panel1.Controls.Add(this.chkTodos);
            this.panel1.Controls.Add(this.btnVisualizar);
            this.panel1.Controls.Add(this.cboProveedor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 68);
            this.panel1.TabIndex = 106;
            // 
            // btnResumen
            // 
            this.btnResumen.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnResumen.FlatAppearance.BorderSize = 0;
            this.btnResumen.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumen.Image = ((System.Drawing.Image)(resources.GetObject("btnResumen.Image")));
            this.btnResumen.Location = new System.Drawing.Point(701, 5);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(76, 54);
            this.btnResumen.TabIndex = 140;
            this.btnResumen.Text = "Resumen";
            this.btnResumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnResumen.UseVisualStyleBackColor = false;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTodas);
            this.groupBox1.Controls.Add(this.rdbCanceladas);
            this.groupBox1.Controls.Add(this.rdbActivas);
            this.groupBox1.Location = new System.Drawing.Point(231, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 38);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mostrar";
            // 
            // rdbTodas
            // 
            this.rdbTodas.AutoSize = true;
            this.rdbTodas.Checked = true;
            this.rdbTodas.Location = new System.Drawing.Point(5, 15);
            this.rdbTodas.Name = "rdbTodas";
            this.rdbTodas.Size = new System.Drawing.Size(57, 20);
            this.rdbTodas.TabIndex = 2;
            this.rdbTodas.TabStop = true;
            this.rdbTodas.Text = "Todas";
            this.rdbTodas.UseVisualStyleBackColor = true;
            // 
            // rdbCanceladas
            // 
            this.rdbCanceladas.AutoSize = true;
            this.rdbCanceladas.Location = new System.Drawing.Point(135, 15);
            this.rdbCanceladas.Name = "rdbCanceladas";
            this.rdbCanceladas.Size = new System.Drawing.Size(93, 20);
            this.rdbCanceladas.TabIndex = 1;
            this.rdbCanceladas.TabStop = true;
            this.rdbCanceladas.Text = "Canceladas";
            this.rdbCanceladas.UseVisualStyleBackColor = true;
            // 
            // rdbActivas
            // 
            this.rdbActivas.AutoSize = true;
            this.rdbActivas.Location = new System.Drawing.Point(66, 15);
            this.rdbActivas.Name = "rdbActivas";
            this.rdbActivas.Size = new System.Drawing.Size(65, 20);
            this.rdbActivas.TabIndex = 0;
            this.rdbActivas.TabStop = true;
            this.rdbActivas.Text = "Activas";
            this.rdbActivas.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(619, 6);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(76, 54);
            this.btnReporte.TabIndex = 138;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnAbonar
            // 
            this.btnAbonar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAbonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAbonar.Location = new System.Drawing.Point(786, 13);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(70, 41);
            this.btnAbonar.TabIndex = 122;
            this.btnAbonar.Text = "ABONAR";
            this.btnAbonar.UseVisualStyleBackColor = false;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(469, 7);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(57, 20);
            this.chkTodos.TabIndex = 121;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(532, 6);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(78, 54);
            this.btnVisualizar.TabIndex = 120;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // cboProveedor
            // 
            this.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProveedor.DataSource = this.oCProveedoresBindingSource;
            this.cboProveedor.DisplayMember = "NombreProveedor";
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(258, 3);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(195, 24);
            this.cboProveedor.TabIndex = 118;
            this.cboProveedor.ValueMember = "IdProveedor";
            // 
            // oCProveedoresBindingSource
            // 
            this.oCProveedoresBindingSource.DataMember = "OC_Proveedores";
            this.oCProveedoresBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 119;
            this.label4.Text = "Proveedor:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(53, 33);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(130, 21);
            this.dtpHasta.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(53, 3);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(130, 21);
            this.dtpDesde.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Desde:";
            // 
            // dgvOCDet
            // 
            this.dgvOCDet.AllowUserToAddRows = false;
            this.dgvOCDet.AllowUserToDeleteRows = false;
            this.dgvOCDet.AutoGenerateColumns = false;
            this.dgvOCDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOCDet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOCDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOCDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCxPDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.correlativoDataGridViewTextBoxColumn,
            this.tipoOCDataGridViewTextBoxColumn,
            this.nombreProveedorDataGridViewTextBoxColumn,
            this.fechaDesdeDataGridViewTextBoxColumn,
            this.FechaHasta,
            this.montoTotalDataGridViewTextBoxColumn,
            this.montoAbonadoDataGridViewTextBoxColumn,
            this.Deuda,
            this.activaDataGridViewCheckBoxColumn});
            this.dgvOCDet.DataSource = this.cPCxPVisorBindingSource;
            this.dgvOCDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOCDet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOCDet.Location = new System.Drawing.Point(0, 103);
            this.dgvOCDet.Name = "dgvOCDet";
            this.dgvOCDet.ReadOnly = true;
            this.dgvOCDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOCDet.Size = new System.Drawing.Size(863, 329);
            this.dgvOCDet.TabIndex = 109;
            // 
            // idCxPDataGridViewTextBoxColumn
            // 
            this.idCxPDataGridViewTextBoxColumn.DataPropertyName = "IdCxP";
            this.idCxPDataGridViewTextBoxColumn.HeaderText = "IdCxP";
            this.idCxPDataGridViewTextBoxColumn.Name = "idCxPDataGridViewTextBoxColumn";
            this.idCxPDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCxPDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.FillWeight = 84.47308F;
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correlativoDataGridViewTextBoxColumn
            // 
            this.correlativoDataGridViewTextBoxColumn.DataPropertyName = "Correlativo";
            this.correlativoDataGridViewTextBoxColumn.FillWeight = 76.3353F;
            this.correlativoDataGridViewTextBoxColumn.HeaderText = "Correlativo";
            this.correlativoDataGridViewTextBoxColumn.Name = "correlativoDataGridViewTextBoxColumn";
            this.correlativoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoOCDataGridViewTextBoxColumn
            // 
            this.tipoOCDataGridViewTextBoxColumn.DataPropertyName = "TipoOC";
            this.tipoOCDataGridViewTextBoxColumn.FillWeight = 174.4806F;
            this.tipoOCDataGridViewTextBoxColumn.HeaderText = "Tipo Orden";
            this.tipoOCDataGridViewTextBoxColumn.Name = "tipoOCDataGridViewTextBoxColumn";
            this.tipoOCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreProveedorDataGridViewTextBoxColumn
            // 
            this.nombreProveedorDataGridViewTextBoxColumn.DataPropertyName = "NombreProveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.FillWeight = 174.4806F;
            this.nombreProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.nombreProveedorDataGridViewTextBoxColumn.Name = "nombreProveedorDataGridViewTextBoxColumn";
            this.nombreProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDesdeDataGridViewTextBoxColumn
            // 
            this.fechaDesdeDataGridViewTextBoxColumn.DataPropertyName = "FechaDesde";
            this.fechaDesdeDataGridViewTextBoxColumn.FillWeight = 78.73636F;
            this.fechaDesdeDataGridViewTextBoxColumn.HeaderText = "Desde";
            this.fechaDesdeDataGridViewTextBoxColumn.Name = "fechaDesdeDataGridViewTextBoxColumn";
            this.fechaDesdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FechaHasta
            // 
            this.FechaHasta.DataPropertyName = "FechaHasta";
            this.FechaHasta.FillWeight = 79.72378F;
            this.FechaHasta.HeaderText = "Hasta";
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.ReadOnly = true;
            // 
            // montoTotalDataGridViewTextBoxColumn
            // 
            this.montoTotalDataGridViewTextBoxColumn.DataPropertyName = "MontoTotal";
            dataGridViewCellStyle1.Format = "N2";
            this.montoTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.montoTotalDataGridViewTextBoxColumn.FillWeight = 95.78857F;
            this.montoTotalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.montoTotalDataGridViewTextBoxColumn.Name = "montoTotalDataGridViewTextBoxColumn";
            this.montoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montoAbonadoDataGridViewTextBoxColumn
            // 
            this.montoAbonadoDataGridViewTextBoxColumn.DataPropertyName = "MontoAbonado";
            dataGridViewCellStyle2.Format = "N2";
            this.montoAbonadoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.montoAbonadoDataGridViewTextBoxColumn.FillWeight = 89.30296F;
            this.montoAbonadoDataGridViewTextBoxColumn.HeaderText = "Abonado";
            this.montoAbonadoDataGridViewTextBoxColumn.Name = "montoAbonadoDataGridViewTextBoxColumn";
            this.montoAbonadoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // activaDataGridViewCheckBoxColumn
            // 
            this.activaDataGridViewCheckBoxColumn.DataPropertyName = "Activa";
            this.activaDataGridViewCheckBoxColumn.FillWeight = 70.53665F;
            this.activaDataGridViewCheckBoxColumn.HeaderText = "Activa";
            this.activaDataGridViewCheckBoxColumn.Name = "activaDataGridViewCheckBoxColumn";
            this.activaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cPCxPVisorBindingSource
            // 
            this.cPCxPVisorBindingSource.DataMember = "CP_CxPVisor";
            this.cPCxPVisorBindingSource.DataSource = this.dsOC;
            // 
            // oC_ProveedoresTableAdapter
            // 
            this.oC_ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // cP_CxPVisorTableAdapter
            // 
            this.cP_CxPVisorTableAdapter.ClearBeforeFill = true;
            // 
            // VisCxP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(863, 455);
            this.Controls.Add(this.dgvOCDet);
            this.Controls.Add(this.panel1);
            this.Name = "VisCxP";
            this.Text = "Visor CXP";
            this.Load += new System.EventHandler(this.VisCxP_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgvOCDet, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOCDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cPCxPVisorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.DataGridView dgvOCDet;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.BindingSource oCProveedoresBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter oC_ProveedoresTableAdapter;
        private System.Windows.Forms.BindingSource cPCxPVisorBindingSource;
        private DataSets.DsOCTableAdapters.CP_CxPVisorTableAdapter cP_CxPVisorTableAdapter;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCxPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDesdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoAbonadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deuda;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbTodas;
        private System.Windows.Forms.RadioButton rdbCanceladas;
        private System.Windows.Forms.RadioButton rdbActivas;
        private System.Windows.Forms.Button btnResumen;
    }
}
