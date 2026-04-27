namespace ADIGGM.Mantenimiento
{
    partial class FrmCierresBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCierresBuscar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvCierres = new System.Windows.Forms.DataGridView();
            this.idCierre = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRCierresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSVCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cerrado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.anulado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tRCierreClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCodeasAdiggm = new ADIGGM.DataSets.DsCodeasAdiggm();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoFac = new System.Windows.Forms.ComboBox();
            this.tRTipoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.tRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tR_CierreClientesTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.TR_CierreClientesTableAdapter();
            this.tR_CierresTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_CierresTableAdapter();
            this.tR_ClientesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter();
            this.tR_TipoFacturasTableAdapter = new ADIGGM.DataSets.DsCodeasAdiggmTableAdapters.TR_TipoFacturasTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRCierresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRCierreClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(520, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(480, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(560, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(420, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 430);
            this.pnlFooter.Size = new System.Drawing.Size(600, 23);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.Location = new System.Drawing.Point(232, 10);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(80, 55);
            this.btnSeleccionar.TabIndex = 103;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvCierres
            // 
            this.dgvCierres.AllowUserToAddRows = false;
            this.dgvCierres.AllowUserToDeleteRows = false;
            this.dgvCierres.AutoGenerateColumns = false;
            this.dgvCierres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCierres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCierre,
            this.FechaInicio,
            this.FechaFin,
            this.idCliente,
            this.subTotalCierre,
            this.iSVCierre,
            this.totalCierre,
            this.cerrado,
            this.anulado});
            this.dgvCierres.DataSource = this.tRCierreClientesBindingSource;
            this.dgvCierres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCierres.Location = new System.Drawing.Point(0, 100);
            this.dgvCierres.Name = "dgvCierres";
            this.dgvCierres.ReadOnly = true;
            this.dgvCierres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCierres.Size = new System.Drawing.Size(600, 259);
            this.dgvCierres.TabIndex = 104;
            // 
            // idCierre
            // 
            this.idCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCierre.DataPropertyName = "IdCierre";
            this.idCierre.DataSource = this.tRCierresBindingSource;
            this.idCierre.DisplayMember = "Semana";
            this.idCierre.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idCierre.HeaderText = "Cierre";
            this.idCierre.Name = "idCierre";
            this.idCierre.ReadOnly = true;
            this.idCierre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCierre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idCierre.ValueMember = "IdCierre";
            // 
            // tRCierresBindingSource
            // 
            this.tRCierresBindingSource.DataMember = "TR_Cierres";
            this.tRCierresBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "F. Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 72;
            // 
            // FechaFin
            // 
            this.FechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "F. Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 58;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "IdCliente";
            this.idCliente.HeaderText = "IdCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // subTotalCierre
            // 
            this.subTotalCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.subTotalCierre.DataPropertyName = "SubTotalCierre";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.subTotalCierre.DefaultCellStyle = dataGridViewCellStyle1;
            this.subTotalCierre.HeaderText = "SubTotal";
            this.subTotalCierre.Name = "subTotalCierre";
            this.subTotalCierre.ReadOnly = true;
            this.subTotalCierre.Width = 80;
            // 
            // iSVCierre
            // 
            this.iSVCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iSVCierre.DataPropertyName = "ISVCierre";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.iSVCierre.DefaultCellStyle = dataGridViewCellStyle2;
            this.iSVCierre.HeaderText = "ISV";
            this.iSVCierre.Name = "iSVCierre";
            this.iSVCierre.ReadOnly = true;
            this.iSVCierre.Width = 49;
            // 
            // totalCierre
            // 
            this.totalCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.totalCierre.DataPropertyName = "TotalCierre";
            dataGridViewCellStyle3.Format = "C2";
            this.totalCierre.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalCierre.HeaderText = "Total";
            this.totalCierre.Name = "totalCierre";
            this.totalCierre.ReadOnly = true;
            this.totalCierre.Width = 59;
            // 
            // cerrado
            // 
            this.cerrado.DataPropertyName = "Cerrado";
            this.cerrado.HeaderText = "Cerrado";
            this.cerrado.Name = "cerrado";
            this.cerrado.ReadOnly = true;
            this.cerrado.Visible = false;
            // 
            // anulado
            // 
            this.anulado.DataPropertyName = "Anulado";
            this.anulado.HeaderText = "Anulado";
            this.anulado.Name = "anulado";
            this.anulado.ReadOnly = true;
            this.anulado.Visible = false;
            // 
            // tRCierreClientesBindingSource
            // 
            this.tRCierreClientesBindingSource.DataMember = "TR_CierreClientes";
            this.tRCierreClientesBindingSource.DataSource = this.dsCodeasAdiggm;
            // 
            // dsCodeasAdiggm
            // 
            this.dsCodeasAdiggm.DataSetName = "DsCodeasAdiggm";
            this.dsCodeasAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 71);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboTipoFac);
            this.groupBox2.Controls.Add(this.cboClientes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 65);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente y Tipo de Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elegir Tipo de Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elegir Cliente";
            // 
            // cboTipoFac
            // 
            this.cboTipoFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTipoFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoFac.DataSource = this.tRTipoFacturasBindingSource;
            this.cboTipoFac.DisplayMember = "TipoFactura";
            this.cboTipoFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFac.FormattingEnabled = true;
            this.cboTipoFac.Location = new System.Drawing.Point(323, 36);
            this.cboTipoFac.Name = "cboTipoFac";
            this.cboTipoFac.Size = new System.Drawing.Size(216, 24);
            this.cboTipoFac.TabIndex = 1;
            this.cboTipoFac.ValueMember = "IdTipoFactura";
            this.cboTipoFac.SelectedValueChanged += new System.EventHandler(this.cboTipoFac_SelectedValueChanged);
            // 
            // tRTipoFacturasBindingSource
            // 
            this.tRTipoFacturasBindingSource.DataMember = "TR_TipoFacturas";
            this.tRTipoFacturasBindingSource.DataSource = this.dsCodeasAdiggm;
            // 
            // cboClientes
            // 
            this.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClientes.DataSource = this.tRClientesBindingSource;
            this.cboClientes.DisplayMember = "Cliente";
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(6, 36);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(201, 24);
            this.cboClientes.TabIndex = 0;
            this.cboClientes.ValueMember = "IdCliente";
            this.cboClientes.SelectedValueChanged += new System.EventHandler(this.cboClientes_SelectedValueChanged);
            // 
            // tRClientesBindingSource
            // 
            this.tRClientesBindingSource.DataMember = "TR_Clientes";
            this.tRClientesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // tR_CierreClientesTableAdapter
            // 
            this.tR_CierreClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tR_CierresTableAdapter
            // 
            this.tR_CierresTableAdapter.ClearBeforeFill = true;
            // 
            // tR_ClientesTableAdapter
            // 
            this.tR_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tR_TipoFacturasTableAdapter
            // 
            this.tR_TipoFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCierresBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(600, 453);
            this.Controls.Add(this.dgvCierres);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmCierresBuscar";
            this.Load += new System.EventHandler(this.FrmCierresBuscar_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvCierres, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRCierresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRCierreClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCodeasAdiggm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvCierres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoFac;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.BindingSource tRCierreClientesBindingSource;
        private DataSets.DsCodeasAdiggm dsCodeasAdiggm;
        private DataSets.DsCodeasAdiggmTableAdapters.TR_CierreClientesTableAdapter tR_CierreClientesTableAdapter;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRCierresBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_CierresTableAdapter tR_CierresTableAdapter;
        private System.Windows.Forms.BindingSource tRClientesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter tR_ClientesTableAdapter;
        private System.Windows.Forms.BindingSource tRTipoFacturasBindingSource;
        private DataSets.DsCodeasAdiggmTableAdapters.TR_TipoFacturasTableAdapter tR_TipoFacturasTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn idCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSVCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCierre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cerrado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anulado;
    }
}
