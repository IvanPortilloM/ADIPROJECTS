namespace ADIGGM.OC.Visores
{
    partial class VisOCCodeas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisOCCodeas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkAprobarTodo = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAgregarLinea = new System.Windows.Forms.Button();
            this.cboTipoMov = new System.Windows.Forms.ComboBox();
            this.lnkEditarDet = new System.Windows.Forms.LinkLabel();
            this.chkAplicarDesc = new System.Windows.Forms.CheckBox();
            this.chkAplicarCxC = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMontoDesc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMontoCxC = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.txtDescripDetalle = new System.Windows.Forms.TextBox();
            this.txtDescripHeader = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtConsecutivo = new System.Windows.Forms.TextBox();
            this.txtTipoDoc = new System.Windows.Forms.TextBox();
            this.oCTipoDocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNumCta = new System.Windows.Forms.ComboBox();
            this.cODSlcInstBancariaCODSlcCcBancariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cODSlcInstBancariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cboInstBancaria = new System.Windows.Forms.ComboBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.oCProveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoOC = new System.Windows.Forms.ComboBox();
            this.oCTipoOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblContador = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiferencia = new System.Windows.Forms.TextBox();
            this.txtHaber = new System.Windows.Forms.TextBox();
            this.txtDebe = new System.Windows.Forms.TextBox();
            this.btnSincronizar = new System.Windows.Forms.Button();
            this.dgvOC = new System.Windows.Forms.DataGridView();
            this.idOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConfirmacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoMov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctaContable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleBtn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Aprobar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.oCDetalleOrdenCodeasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oCOrdenTrabajoCODEASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oC_TipoOCTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_TipoOCTableAdapter();
            this.oC_ProveedoresTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter();
            this.oC_OrdenTrabajoCODEASTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_OrdenTrabajoCODEASTableAdapter();
            this.cOD_SlcInstBancariaTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.COD_SlcInstBancariaTableAdapter();
            this.cOD_SlcCcBancariaTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.COD_SlcCcBancariaTableAdapter();
            this.oC_TipoDocumentosTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_TipoDocumentosTableAdapter();
            this.oC_DetalleOrdenCodeasTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_DetalleOrdenCodeasTableAdapter();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCTipoDocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcInstBancariaCODSlcCcBancariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcInstBancariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCTipoOCBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCDetalleOrdenCodeasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenTrabajoCODEASBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(276, 19);
            this.lblFooter.Text = "Visor Ordenes de Compra CODEAS";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(1117, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(1077, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(1157, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(1017, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 476);
            this.pnlFooter.Size = new System.Drawing.Size(1197, 23);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkAprobarTodo);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btnAgregarLinea);
            this.panel1.Controls.Add(this.cboTipoMov);
            this.panel1.Controls.Add(this.lnkEditarDet);
            this.panel1.Controls.Add(this.chkAplicarDesc);
            this.panel1.Controls.Add(this.chkAplicarCxC);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txtMontoDesc);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtMontoCxC);
            this.panel1.Controls.Add(this.btnReporte);
            this.panel1.Controls.Add(this.txtDescripDetalle);
            this.panel1.Controls.Add(this.txtDescripHeader);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtMonto);
            this.panel1.Controls.Add(this.txtConsecutivo);
            this.panel1.Controls.Add(this.txtTipoDoc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cboTipoDoc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cboNumCta);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboInstBancaria);
            this.panel1.Controls.Add(this.btnVisualizar);
            this.panel1.Controls.Add(this.cboProveedor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboTipoOC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtProveedor);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 150);
            this.panel1.TabIndex = 105;
            // 
            // chkAprobarTodo
            // 
            this.chkAprobarTodo.AutoSize = true;
            this.chkAprobarTodo.Location = new System.Drawing.Point(1101, 129);
            this.chkAprobarTodo.Name = "chkAprobarTodo";
            this.chkAprobarTodo.Size = new System.Drawing.Size(92, 20);
            this.chkAprobarTodo.TabIndex = 153;
            this.chkAprobarTodo.Text = "Aprob. Todo";
            this.chkAprobarTodo.UseVisualStyleBackColor = true;
            this.chkAprobarTodo.CheckedChanged += new System.EventHandler(this.chkAprobarTodo_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(312, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 16);
            this.label17.TabIndex = 152;
            this.label17.Text = "Tipo Mov:";
            // 
            // btnAgregarLinea
            // 
            this.btnAgregarLinea.Location = new System.Drawing.Point(476, 106);
            this.btnAgregarLinea.Name = "btnAgregarLinea";
            this.btnAgregarLinea.Size = new System.Drawing.Size(75, 24);
            this.btnAgregarLinea.TabIndex = 151;
            this.btnAgregarLinea.Text = "Agregar";
            this.btnAgregarLinea.UseVisualStyleBackColor = true;
            this.btnAgregarLinea.Click += new System.EventHandler(this.btnAgregarLinea_Click);
            // 
            // cboTipoMov
            // 
            this.cboTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMov.FormattingEnabled = true;
            this.cboTipoMov.Items.AddRange(new object[] {
            "CR",
            "DB"});
            this.cboTipoMov.Location = new System.Drawing.Point(392, 106);
            this.cboTipoMov.Name = "cboTipoMov";
            this.cboTipoMov.Size = new System.Drawing.Size(78, 24);
            this.cboTipoMov.TabIndex = 150;
            // 
            // lnkEditarDet
            // 
            this.lnkEditarDet.AutoSize = true;
            this.lnkEditarDet.Location = new System.Drawing.Point(886, 130);
            this.lnkEditarDet.Name = "lnkEditarDet";
            this.lnkEditarDet.Size = new System.Drawing.Size(79, 16);
            this.lnkEditarDet.TabIndex = 146;
            this.lnkEditarDet.TabStop = true;
            this.lnkEditarDet.Text = "Editar Detalle";
            this.lnkEditarDet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditarDet_LinkClicked);
            // 
            // chkAplicarDesc
            // 
            this.chkAplicarDesc.AutoSize = true;
            this.chkAplicarDesc.Location = new System.Drawing.Point(572, 83);
            this.chkAplicarDesc.Name = "chkAplicarDesc";
            this.chkAplicarDesc.Size = new System.Drawing.Size(92, 20);
            this.chkAplicarDesc.TabIndex = 144;
            this.chkAplicarDesc.Text = "Aplicar Desc";
            this.chkAplicarDesc.UseVisualStyleBackColor = true;
            // 
            // chkAplicarCxC
            // 
            this.chkAplicarCxC.AutoSize = true;
            this.chkAplicarCxC.Location = new System.Drawing.Point(392, 83);
            this.chkAplicarCxC.Name = "chkAplicarCxC";
            this.chkAplicarCxC.Size = new System.Drawing.Size(90, 20);
            this.chkAplicarCxC.TabIndex = 143;
            this.chkAplicarCxC.Text = "Aplicar CxC";
            this.chkAplicarCxC.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(490, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 16);
            this.label16.TabIndex = 142;
            this.label16.Text = "Monto Desc:";
            // 
            // txtMontoDesc
            // 
            this.txtMontoDesc.Location = new System.Drawing.Point(572, 56);
            this.txtMontoDesc.Name = "txtMontoDesc";
            this.txtMontoDesc.Size = new System.Drawing.Size(80, 21);
            this.txtMontoDesc.TabIndex = 141;
            this.txtMontoDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoDesc.Enter += new System.EventHandler(this.txtMontoDesc_Enter);
            this.txtMontoDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMontoDesc_KeyDown);
            this.txtMontoDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoDesc_KeyPress);
            this.txtMontoDesc.Leave += new System.EventHandler(this.txtMontoDesc_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(312, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 16);
            this.label15.TabIndex = 140;
            this.label15.Text = "Monto CxC:";
            // 
            // txtMontoCxC
            // 
            this.txtMontoCxC.Location = new System.Drawing.Point(392, 56);
            this.txtMontoCxC.Name = "txtMontoCxC";
            this.txtMontoCxC.Size = new System.Drawing.Size(80, 21);
            this.txtMontoCxC.TabIndex = 139;
            this.txtMontoCxC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoCxC.Enter += new System.EventHandler(this.txtMontoCxC_Enter);
            this.txtMontoCxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMontoCxC_KeyDown);
            this.txtMontoCxC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoCxC_KeyPress);
            this.txtMontoCxC.Leave += new System.EventHandler(this.txtMontoCxC_Leave);
            // 
            // btnReporte
            // 
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(1106, 8);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(72, 54);
            this.btnReporte.TabIndex = 137;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // txtDescripDetalle
            // 
            this.txtDescripDetalle.Location = new System.Drawing.Point(670, 88);
            this.txtDescripDetalle.Multiline = true;
            this.txtDescripDetalle.Name = "txtDescripDetalle";
            this.txtDescripDetalle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripDetalle.Size = new System.Drawing.Size(402, 37);
            this.txtDescripDetalle.TabIndex = 135;
            // 
            // txtDescripHeader
            // 
            this.txtDescripHeader.Location = new System.Drawing.Point(670, 24);
            this.txtDescripHeader.Multiline = true;
            this.txtDescripHeader.Name = "txtDescripHeader";
            this.txtDescripHeader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripHeader.Size = new System.Drawing.Size(402, 42);
            this.txtDescripHeader.TabIndex = 133;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(163, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 132;
            this.label9.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(216, 83);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(81, 21);
            this.txtMonto.TabIndex = 131;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMonto.Enter += new System.EventHandler(this.txtMonto_Enter);
            this.txtMonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMonto_KeyDown);
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            this.txtMonto.Leave += new System.EventHandler(this.txtMonto_Leave);
            this.txtMonto.Validating += new System.ComponentModel.CancelEventHandler(this.txtMonto_Validating);
            // 
            // txtConsecutivo
            // 
            this.txtConsecutivo.Location = new System.Drawing.Point(96, 83);
            this.txtConsecutivo.Name = "txtConsecutivo";
            this.txtConsecutivo.ReadOnly = true;
            this.txtConsecutivo.Size = new System.Drawing.Size(61, 21);
            this.txtConsecutivo.TabIndex = 130;
            this.txtConsecutivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTipoDoc
            // 
            this.txtTipoDoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oCTipoDocumentosBindingSource, "Nomenclatura", true));
            this.txtTipoDoc.Location = new System.Drawing.Point(240, 57);
            this.txtTipoDoc.Multiline = true;
            this.txtTipoDoc.Name = "txtTipoDoc";
            this.txtTipoDoc.ReadOnly = true;
            this.txtTipoDoc.Size = new System.Drawing.Size(57, 24);
            this.txtTipoDoc.TabIndex = 129;
            this.txtTipoDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTipoDoc.TextChanged += new System.EventHandler(this.txtTipoDoc_TextChanged);
            // 
            // oCTipoDocumentosBindingSource
            // 
            this.oCTipoDocumentosBindingSource.DataMember = "OC_TipoDocumentos";
            this.oCTipoDocumentosBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 127;
            this.label8.Text = "Tipo Doc.:";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DataSource = this.oCTipoDocumentosBindingSource;
            this.cboTipoDoc.DisplayMember = "Descripcion";
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(96, 57);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(144, 24);
            this.cboTipoDoc.TabIndex = 126;
            this.cboTipoDoc.ValueMember = "ColumnaCodeas";
            this.cboTipoDoc.SelectedValueChanged += new System.EventHandler(this.cboTipoDoc_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 125;
            this.label7.Text = "Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 124;
            this.label6.Text = "N° Cuenta:";
            // 
            // cboNumCta
            // 
            this.cboNumCta.DataSource = this.cODSlcInstBancariaCODSlcCcBancariaBindingSource;
            this.cboNumCta.DisplayMember = "cctabancar";
            this.cboNumCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumCta.FormattingEnabled = true;
            this.cboNumCta.Location = new System.Drawing.Point(96, 31);
            this.cboNumCta.Name = "cboNumCta";
            this.cboNumCta.Size = new System.Drawing.Size(201, 24);
            this.cboNumCta.TabIndex = 123;
            this.cboNumCta.ValueMember = "cctabancar";
            this.cboNumCta.SelectedValueChanged += new System.EventHandler(this.cboNumCta_SelectedValueChanged);
            // 
            // cODSlcInstBancariaCODSlcCcBancariaBindingSource
            // 
            this.cODSlcInstBancariaCODSlcCcBancariaBindingSource.DataMember = "COD_SlcInstBancaria_COD_SlcCcBancaria";
            this.cODSlcInstBancariaCODSlcCcBancariaBindingSource.DataSource = this.cODSlcInstBancariaBindingSource;
            // 
            // cODSlcInstBancariaBindingSource
            // 
            this.cODSlcInstBancariaBindingSource.DataMember = "COD_SlcInstBancaria";
            this.cODSlcInstBancariaBindingSource.DataSource = this.dsOC;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 122;
            this.label5.Text = "Inst. Bancaria:";
            // 
            // cboInstBancaria
            // 
            this.cboInstBancaria.DataSource = this.cODSlcInstBancariaBindingSource;
            this.cboInstBancaria.DisplayMember = "cnombbanca";
            this.cboInstBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInstBancaria.FormattingEnabled = true;
            this.cboInstBancaria.Location = new System.Drawing.Point(96, 5);
            this.cboInstBancaria.Name = "cboInstBancaria";
            this.cboInstBancaria.Size = new System.Drawing.Size(201, 24);
            this.cboInstBancaria.TabIndex = 121;
            this.cboInstBancaria.ValueMember = "ccodibanca";
            this.cboInstBancaria.SelectedValueChanged += new System.EventHandler(this.cboInstBancaria_SelectedValueChanged);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(1106, 69);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(72, 55);
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
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(392, 30);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(260, 24);
            this.cboProveedor.TabIndex = 118;
            this.cboProveedor.ValueMember = "IdProveedor";
            // 
            // oCProveedoresBindingSource
            // 
            this.oCProveedoresBindingSource.DataMember = "OC_Proveedores";
            this.oCProveedoresBindingSource.DataSource = this.dsOC;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 119;
            this.label4.Text = "Proveedor:";
            // 
            // cboTipoOC
            // 
            this.cboTipoOC.DataSource = this.oCTipoOCBindingSource;
            this.cboTipoOC.DisplayMember = "TipoOC";
            this.cboTipoOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoOC.FormattingEnabled = true;
            this.cboTipoOC.Location = new System.Drawing.Point(96, 106);
            this.cboTipoOC.Name = "cboTipoOC";
            this.cboTipoOC.Size = new System.Drawing.Size(201, 24);
            this.cboTipoOC.TabIndex = 116;
            this.cboTipoOC.ValueMember = "IdTipoOC";
            // 
            // oCTipoOCBindingSource
            // 
            this.oCTipoOCBindingSource.DataMember = "OC_TipoOC";
            this.oCTipoOCBindingSource.DataSource = this.dsOC;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 117;
            this.label3.Text = "Tipo de Orden:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(555, 6);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(97, 21);
            this.dtpHasta.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(392, 5);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(100, 21);
            this.dtpDesde.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Desde:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oCProveedoresBindingSource, "NombreProveedor", true));
            this.txtProveedor.Location = new System.Drawing.Point(395, 31);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.ReadOnly = true;
            this.txtProveedor.Size = new System.Drawing.Size(119, 21);
            this.txtProveedor.TabIndex = 138;
            this.txtProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(667, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 16);
            this.label11.TabIndex = 136;
            this.label11.Text = "Descripción del Detalle:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 16);
            this.label10.TabIndex = 134;
            this.label10.Text = "Descripción General:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblContador);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtDiferencia);
            this.panel2.Controls.Add(this.txtHaber);
            this.panel2.Controls.Add(this.txtDebe);
            this.panel2.Controls.Add(this.btnSincronizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 433);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 43);
            this.panel2.TabIndex = 106;
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(685, 18);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 16);
            this.lblContador.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1112, 2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Dif:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1003, 2);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "Haber:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(899, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Debe:";
            // 
            // txtDiferencia
            // 
            this.txtDiferencia.Location = new System.Drawing.Point(1078, 18);
            this.txtDiferencia.Name = "txtDiferencia";
            this.txtDiferencia.Size = new System.Drawing.Size(100, 21);
            this.txtDiferencia.TabIndex = 3;
            // 
            // txtHaber
            // 
            this.txtHaber.Location = new System.Drawing.Point(972, 18);
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.Size = new System.Drawing.Size(100, 21);
            this.txtHaber.TabIndex = 2;
            // 
            // txtDebe
            // 
            this.txtDebe.Location = new System.Drawing.Point(866, 18);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Size = new System.Drawing.Size(100, 21);
            this.txtDebe.TabIndex = 1;
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSincronizar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSincronizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSincronizar.Location = new System.Drawing.Point(315, 12);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(364, 29);
            this.btnSincronizar.TabIndex = 0;
            this.btnSincronizar.Text = "SINCRONIZAR A CODEAS";
            this.btnSincronizar.UseVisualStyleBackColor = false;
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // dgvOC
            // 
            this.dgvOC.AllowUserToAddRows = false;
            this.dgvOC.AllowUserToDeleteRows = false;
            this.dgvOC.AutoGenerateColumns = false;
            this.dgvOC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOC,
            this.idVehiculo,
            this.FechaConfirmacion,
            this.TipoMov,
            this.ctaContable,
            this.descripcion,
            this.debe,
            this.haber,
            this.nDoc,
            this.detalle,
            this.Correlativo,
            this.CodVehiculo,
            this.DetalleBtn,
            this.seleccionar,
            this.Aprobar});
            this.dgvOC.DataSource = this.oCDetalleOrdenCodeasBindingSource;
            this.dgvOC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOC.Location = new System.Drawing.Point(0, 185);
            this.dgvOC.MultiSelect = false;
            this.dgvOC.Name = "dgvOC";
            this.dgvOC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOC.Size = new System.Drawing.Size(1197, 248);
            this.dgvOC.TabIndex = 112;
            this.dgvOC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOC_CellContentClick);
            this.dgvOC.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvOC_CurrentCellDirtyStateChanged);
            // 
            // idOC
            // 
            this.idOC.DataPropertyName = "IdOC";
            this.idOC.HeaderText = "IdOC";
            this.idOC.Name = "idOC";
            this.idOC.ReadOnly = true;
            this.idOC.Visible = false;
            // 
            // idVehiculo
            // 
            this.idVehiculo.DataPropertyName = "IdVehiculo";
            this.idVehiculo.HeaderText = "IdVehiculo";
            this.idVehiculo.Name = "idVehiculo";
            this.idVehiculo.ReadOnly = true;
            this.idVehiculo.Visible = false;
            // 
            // FechaConfirmacion
            // 
            this.FechaConfirmacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FechaConfirmacion.DataPropertyName = "FechaConfirmacion";
            this.FechaConfirmacion.HeaderText = "Fecha";
            this.FechaConfirmacion.Name = "FechaConfirmacion";
            this.FechaConfirmacion.ReadOnly = true;
            this.FechaConfirmacion.Width = 66;
            // 
            // TipoMov
            // 
            this.TipoMov.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TipoMov.DataPropertyName = "TipoMov";
            this.TipoMov.HeaderText = "Mov.";
            this.TipoMov.Name = "TipoMov";
            this.TipoMov.ReadOnly = true;
            this.TipoMov.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TipoMov.Width = 42;
            // 
            // ctaContable
            // 
            this.ctaContable.DataPropertyName = "CtaContable";
            this.ctaContable.FillWeight = 102.7738F;
            this.ctaContable.HeaderText = "Cuenta Contable";
            this.ctaContable.Name = "ctaContable";
            this.ctaContable.ReadOnly = true;
            this.ctaContable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.FillWeight = 137.8026F;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // debe
            // 
            this.debe.DataPropertyName = "Debe";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.debe.DefaultCellStyle = dataGridViewCellStyle1;
            this.debe.FillWeight = 60.43084F;
            this.debe.HeaderText = "Debe";
            this.debe.Name = "debe";
            this.debe.ReadOnly = true;
            this.debe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // haber
            // 
            this.haber.DataPropertyName = "Haber";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.haber.DefaultCellStyle = dataGridViewCellStyle2;
            this.haber.FillWeight = 54.05405F;
            this.haber.HeaderText = "Haber";
            this.haber.Name = "haber";
            this.haber.ReadOnly = true;
            this.haber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nDoc
            // 
            this.nDoc.DataPropertyName = "NDoc";
            this.nDoc.FillWeight = 116.0355F;
            this.nDoc.HeaderText = "N° Doc.";
            this.nDoc.Name = "nDoc";
            this.nDoc.ReadOnly = true;
            this.nDoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // detalle
            // 
            this.detalle.DataPropertyName = "Detalle";
            this.detalle.FillWeight = 137.8026F;
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Correlativo
            // 
            this.Correlativo.DataPropertyName = "Correlativo";
            this.Correlativo.HeaderText = "Correlativo";
            this.Correlativo.Name = "Correlativo";
            this.Correlativo.ReadOnly = true;
            this.Correlativo.Visible = false;
            // 
            // CodVehiculo
            // 
            this.CodVehiculo.DataPropertyName = "CodVehiculo";
            this.CodVehiculo.HeaderText = "CodVehiculo";
            this.CodVehiculo.Name = "CodVehiculo";
            this.CodVehiculo.ReadOnly = true;
            this.CodVehiculo.Visible = false;
            // 
            // DetalleBtn
            // 
            this.DetalleBtn.FillWeight = 44.21473F;
            this.DetalleBtn.HeaderText = "Acción";
            this.DetalleBtn.LinkColor = System.Drawing.Color.Green;
            this.DetalleBtn.Name = "DetalleBtn";
            this.DetalleBtn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DetalleBtn.Text = "Detalle";
            this.DetalleBtn.UseColumnTextForLinkValue = true;
            // 
            // seleccionar
            // 
            this.seleccionar.DataPropertyName = "Seleccionar";
            this.seleccionar.HeaderText = "Seleccionar";
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.ReadOnly = true;
            this.seleccionar.Visible = false;
            // 
            // Aprobar
            // 
            this.Aprobar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Aprobar.FalseValue = "0";
            this.Aprobar.HeaderText = "Aprobar";
            this.Aprobar.Name = "Aprobar";
            this.Aprobar.TrueValue = "1";
            this.Aprobar.Width = 57;
            // 
            // oCDetalleOrdenCodeasBindingSource
            // 
            this.oCDetalleOrdenCodeasBindingSource.DataMember = "OC_DetalleOrdenCodeas";
            this.oCDetalleOrdenCodeasBindingSource.DataSource = this.dsOC;
            // 
            // oCOrdenTrabajoCODEASBindingSource
            // 
            this.oCOrdenTrabajoCODEASBindingSource.DataMember = "OC_OrdenTrabajoCODEAS";
            this.oCOrdenTrabajoCODEASBindingSource.DataSource = this.dsOC;
            // 
            // oC_TipoOCTableAdapter
            // 
            this.oC_TipoOCTableAdapter.ClearBeforeFill = true;
            // 
            // oC_ProveedoresTableAdapter
            // 
            this.oC_ProveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // oC_OrdenTrabajoCODEASTableAdapter
            // 
            this.oC_OrdenTrabajoCODEASTableAdapter.ClearBeforeFill = true;
            // 
            // cOD_SlcInstBancariaTableAdapter
            // 
            this.cOD_SlcInstBancariaTableAdapter.ClearBeforeFill = true;
            // 
            // cOD_SlcCcBancariaTableAdapter
            // 
            this.cOD_SlcCcBancariaTableAdapter.ClearBeforeFill = true;
            // 
            // oC_TipoDocumentosTableAdapter
            // 
            this.oC_TipoDocumentosTableAdapter.ClearBeforeFill = true;
            // 
            // oC_DetalleOrdenCodeasTableAdapter
            // 
            this.oC_DetalleOrdenCodeasTableAdapter.ClearBeforeFill = true;
            // 
            // VisOCCodeas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 499);
            this.Controls.Add(this.dgvOC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "VisOCCodeas";
            this.Text = "Visor OC Codeas";
            this.Load += new System.EventHandler(this.VisOCCodeas_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvOC, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCTipoDocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcInstBancariaCODSlcCcBancariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcInstBancariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCProveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCTipoOCBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCDetalleOrdenCodeasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenTrabajoCODEASBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoOC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvOC;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.BindingSource oCTipoOCBindingSource;
        private DataSets.DsOCTableAdapters.OC_TipoOCTableAdapter oC_TipoOCTableAdapter;
        private System.Windows.Forms.BindingSource oCProveedoresBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProveedoresTableAdapter oC_ProveedoresTableAdapter;
        private System.Windows.Forms.BindingSource oCOrdenTrabajoCODEASBindingSource;
        private DataSets.DsOCTableAdapters.OC_OrdenTrabajoCODEASTableAdapter oC_OrdenTrabajoCODEASTableAdapter;
        private System.Windows.Forms.Button btnSincronizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboInstBancaria;
        private System.Windows.Forms.BindingSource cODSlcInstBancariaBindingSource;
        private DataSets.DsOCTableAdapters.COD_SlcInstBancariaTableAdapter cOD_SlcInstBancariaTableAdapter;
        private System.Windows.Forms.ComboBox cboNumCta;
        private System.Windows.Forms.BindingSource cODSlcInstBancariaCODSlcCcBancariaBindingSource;
        private DataSets.DsOCTableAdapters.COD_SlcCcBancariaTableAdapter cOD_SlcCcBancariaTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource oCTipoDocumentosBindingSource;
        private DataSets.DsOCTableAdapters.OC_TipoDocumentosTableAdapter oC_TipoDocumentosTableAdapter;
        private System.Windows.Forms.TextBox txtTipoDoc;
        private System.Windows.Forms.TextBox txtConsecutivo;
        private System.Windows.Forms.TextBox txtDescripHeader;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.BindingSource oCDetalleOrdenCodeasBindingSource;
        private DataSets.DsOCTableAdapters.OC_DetalleOrdenCodeasTableAdapter oC_DetalleOrdenCodeasTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescripDetalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiferencia;
        private System.Windows.Forms.TextBox txtHaber;
        private System.Windows.Forms.TextBox txtDebe;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtMontoCxC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMontoDesc;
        private System.Windows.Forms.CheckBox chkAplicarDesc;
        private System.Windows.Forms.CheckBox chkAplicarCxC;
        private System.Windows.Forms.LinkLabel lnkEditarDet;
        private System.Windows.Forms.ComboBox cboTipoMov;
        private System.Windows.Forms.Button btnAgregarLinea;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkAprobarTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConfirmacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctaContable;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correlativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodVehiculo;
        private System.Windows.Forms.DataGridViewLinkColumn DetalleBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn seleccionar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Aprobar;
        private System.Windows.Forms.Label lblContador;
    }
}
