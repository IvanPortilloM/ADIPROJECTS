namespace ADIGGM.Mantenimiento
{
    partial class FrmAsigFincaClientes
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
            this.gboClientes = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.tRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.dgvAsigFincaClientes = new System.Windows.Forms.DataGridView();
            this.idAsigFincaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFinca = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tRFincasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKTRAsigFincaClienteTRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tR_ClientesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter();
            this.tR_AsigFincaClienteTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_AsigFincaClienteTableAdapter();
            this.tR_FincasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_FincasTableAdapter();
            this.gboClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigFincaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRFincasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRAsigFincaClienteTRClientesBindingSource)).BeginInit();
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
            this.lblFooter.Size = new System.Drawing.Size(194, 19);
            this.lblFooter.Text = "Asignar Finca a Clientes";
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
            // gboClientes
            // 
            this.gboClientes.Controls.Add(this.label1);
            this.gboClientes.Controls.Add(this.cboCliente);
            this.gboClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gboClientes.Location = new System.Drawing.Point(0, 98);
            this.gboClientes.Name = "gboClientes";
            this.gboClientes.Size = new System.Drawing.Size(430, 54);
            this.gboClientes.TabIndex = 105;
            this.gboClientes.TabStop = false;
            this.gboClientes.Text = "Filtrar Por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Clientes";
            // 
            // cboCliente
            // 
            this.cboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCliente.DataSource = this.tRClientesBindingSource;
            this.cboCliente.DisplayMember = "Cliente";
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(141, 19);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(188, 21);
            this.cboCliente.TabIndex = 103;
            this.cboCliente.ValueMember = "IdCliente";
            // 
            // tRClientesBindingSource
            // 
            this.tRClientesBindingSource.DataMember = "TR_Clientes";
            this.tRClientesBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvAsigFincaClientes
            // 
            this.dgvAsigFincaClientes.AllowUserToAddRows = false;
            this.dgvAsigFincaClientes.AllowUserToDeleteRows = false;
            this.dgvAsigFincaClientes.AutoGenerateColumns = false;
            this.dgvAsigFincaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsigFincaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAsigFincaCliente,
            this.idFinca,
            this.idCliente});
            this.dgvAsigFincaClientes.DataSource = this.fKTRAsigFincaClienteTRClientesBindingSource;
            this.dgvAsigFincaClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsigFincaClientes.Location = new System.Drawing.Point(0, 152);
            this.dgvAsigFincaClientes.Name = "dgvAsigFincaClientes";
            this.dgvAsigFincaClientes.ReadOnly = true;
            this.dgvAsigFincaClientes.Size = new System.Drawing.Size(430, 255);
            this.dgvAsigFincaClientes.TabIndex = 106;
            // 
            // idAsigFincaCliente
            // 
            this.idAsigFincaCliente.DataPropertyName = "IdAsigFincaCliente";
            this.idAsigFincaCliente.HeaderText = "IdAsigFincaCliente";
            this.idAsigFincaCliente.Name = "idAsigFincaCliente";
            this.idAsigFincaCliente.ReadOnly = true;
            this.idAsigFincaCliente.Visible = false;
            // 
            // idFinca
            // 
            this.idFinca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idFinca.DataPropertyName = "IdFinca";
            this.idFinca.DataSource = this.tRFincasBindingSource;
            this.idFinca.DisplayMember = "Finca";
            this.idFinca.HeaderText = "Finca";
            this.idFinca.Name = "idFinca";
            this.idFinca.ReadOnly = true;
            this.idFinca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idFinca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idFinca.ValueMember = "IdFinca";
            // 
            // tRFincasBindingSource
            // 
            this.tRFincasBindingSource.DataMember = "TR_Fincas";
            this.tRFincasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // idCliente
            // 
            this.idCliente.DataPropertyName = "IdCliente";
            this.idCliente.HeaderText = "IdCliente";
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            // 
            // fKTRAsigFincaClienteTRClientesBindingSource
            // 
            this.fKTRAsigFincaClienteTRClientesBindingSource.DataMember = "FK_TR_AsigFincaCliente_TR_Clientes";
            this.fKTRAsigFincaClienteTRClientesBindingSource.DataSource = this.tRClientesBindingSource;
            // 
            // tR_ClientesTableAdapter
            // 
            this.tR_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // tR_AsigFincaClienteTableAdapter
            // 
            this.tR_AsigFincaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tR_FincasTableAdapter
            // 
            this.tR_FincasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmAsigFincaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(430, 430);
            this.Controls.Add(this.dgvAsigFincaClientes);
            this.Controls.Add(this.gboClientes);
            this.Name = "FrmAsigFincaClientes";
            this.Load += new System.EventHandler(this.FrmAsigFincaClientes_Load);
            this.Controls.SetChildIndex(this.gboClientes, 0);
            this.Controls.SetChildIndex(this.dgvAsigFincaClientes, 0);
            this.gboClientes.ResumeLayout(false);
            this.gboClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsigFincaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRFincasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKTRAsigFincaClienteTRClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.DataGridView dgvAsigFincaClientes;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRClientesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter tR_ClientesTableAdapter;
        private System.Windows.Forms.BindingSource fKTRAsigFincaClienteTRClientesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_AsigFincaClienteTableAdapter tR_AsigFincaClienteTableAdapter;
        private System.Windows.Forms.BindingSource tRFincasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_FincasTableAdapter tR_FincasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAsigFincaCliente;
        private System.Windows.Forms.DataGridViewComboBoxColumn idFinca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
    }
}
