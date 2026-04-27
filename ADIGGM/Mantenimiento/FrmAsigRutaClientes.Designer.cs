namespace ADIGGM.Mantenimiento
{
    partial class FrmAsigRutaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAsigRutaClientes));
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.tRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.dgvRutasNoAsignadas = new System.Windows.Forms.DataGridView();
            this.idRutaNoAsig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pRSelectRutaClienteNoAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvRutasAsignadas = new System.Windows.Forms.DataGridView();
            this.idRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pRSelectRutaClienteAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblClientes = new System.Windows.Forms.Label();
            this.lblRutasAsig = new System.Windows.Forms.Label();
            this.lblRutasNoAsig = new System.Windows.Forms.Label();
            this.txtRuta1 = new System.Windows.Forms.TextBox();
            this.txtRuta2 = new System.Windows.Forms.TextBox();
            this.lblBuscar1 = new System.Windows.Forms.Label();
            this.lblRutas2 = new System.Windows.Forms.Label();
            this.tR_ClientesTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter();
            this.pR_SelectRutaClienteNoAsigTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.PR_SelectRutaClienteNoAsigTableAdapter();
            this.pR_SelectRutaClienteAsigTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.PR_SelectRutaClienteAsigTableAdapter();
            this.btnAgregarTodo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasNoAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectRutaClienteNoAsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectRutaClienteAsigBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFooter.Size = new System.Drawing.Size(215, 19);
            this.lblFooter.Text = "ASIGNAR RUTAS A CLIENTES";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(718, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(678, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(758, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(618, 0);
            this.pgbProcesos.Margin = new System.Windows.Forms.Padding(4);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 485);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Size = new System.Drawing.Size(798, 23);
            // 
            // cboClientes
            // 
            this.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClientes.DataSource = this.tRClientesBindingSource;
            this.cboClientes.DisplayMember = "Cliente";
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(288, 53);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(222, 24);
            this.cboClientes.TabIndex = 2;
            this.cboClientes.ValueMember = "IdCliente";
            this.cboClientes.SelectedValueChanged += new System.EventHandler(this.cboClientes_SelectedValueChanged);
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
            // dgvRutasNoAsignadas
            // 
            this.dgvRutasNoAsignadas.AllowUserToAddRows = false;
            this.dgvRutasNoAsignadas.AllowUserToDeleteRows = false;
            this.dgvRutasNoAsignadas.AutoGenerateColumns = false;
            this.dgvRutasNoAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRutasNoAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutasNoAsignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRutaNoAsig,
            this.rutaDataGridViewTextBoxColumn,
            this.Seleccionar});
            this.dgvRutasNoAsignadas.DataSource = this.pRSelectRutaClienteNoAsigBindingSource;
            this.dgvRutasNoAsignadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvRutasNoAsignadas.Location = new System.Drawing.Point(0, 165);
            this.dgvRutasNoAsignadas.Name = "dgvRutasNoAsignadas";
            this.dgvRutasNoAsignadas.RowHeadersWidth = 51;
            this.dgvRutasNoAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutasNoAsignadas.Size = new System.Drawing.Size(370, 320);
            this.dgvRutasNoAsignadas.TabIndex = 3;
            this.dgvRutasNoAsignadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutasNoAsignadas_CellClick);
            // 
            // idRutaNoAsig
            // 
            this.idRutaNoAsig.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idRutaNoAsig.DataPropertyName = "IdRuta";
            this.idRutaNoAsig.HeaderText = "IdRuta";
            this.idRutaNoAsig.MinimumWidth = 6;
            this.idRutaNoAsig.Name = "idRutaNoAsig";
            this.idRutaNoAsig.ReadOnly = true;
            this.idRutaNoAsig.Visible = false;
            // 
            // rutaDataGridViewTextBoxColumn
            // 
            this.rutaDataGridViewTextBoxColumn.DataPropertyName = "Ruta";
            this.rutaDataGridViewTextBoxColumn.HeaderText = "Ruta";
            this.rutaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rutaDataGridViewTextBoxColumn.Name = "rutaDataGridViewTextBoxColumn";
            this.rutaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Seleccionar
            // 
            this.Seleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Visible = false;
            // 
            // pRSelectRutaClienteNoAsigBindingSource
            // 
            this.pRSelectRutaClienteNoAsigBindingSource.DataMember = "PR_SelectRutaClienteNoAsig";
            this.pRSelectRutaClienteNoAsigBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dgvRutasAsignadas
            // 
            this.dgvRutasAsignadas.AllowUserToAddRows = false;
            this.dgvRutasAsignadas.AllowUserToDeleteRows = false;
            this.dgvRutasAsignadas.AutoGenerateColumns = false;
            this.dgvRutasAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRutasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutasAsignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRuta,
            this.rutaDataGridViewTextBoxColumn1,
            this.Eliminar});
            this.dgvRutasAsignadas.DataSource = this.pRSelectRutaClienteAsigBindingSource;
            this.dgvRutasAsignadas.Location = new System.Drawing.Point(428, 165);
            this.dgvRutasAsignadas.Name = "dgvRutasAsignadas";
            this.dgvRutasAsignadas.RowHeadersWidth = 51;
            this.dgvRutasAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRutasAsignadas.Size = new System.Drawing.Size(370, 320);
            this.dgvRutasAsignadas.TabIndex = 4;
            this.dgvRutasAsignadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutasAsignadas_CellClick);
            // 
            // idRuta
            // 
            this.idRuta.DataPropertyName = "IdRuta";
            this.idRuta.HeaderText = "IdRuta";
            this.idRuta.MinimumWidth = 6;
            this.idRuta.Name = "idRuta";
            this.idRuta.ReadOnly = true;
            this.idRuta.Visible = false;
            // 
            // rutaDataGridViewTextBoxColumn1
            // 
            this.rutaDataGridViewTextBoxColumn1.DataPropertyName = "Ruta";
            this.rutaDataGridViewTextBoxColumn1.HeaderText = "Ruta";
            this.rutaDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.rutaDataGridViewTextBoxColumn1.Name = "rutaDataGridViewTextBoxColumn1";
            this.rutaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.LinkColor = System.Drawing.Color.Red;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            this.Eliminar.Visible = false;
            // 
            // pRSelectRutaClienteAsigBindingSource
            // 
            this.pRSelectRutaClienteAsigBindingSource.DataMember = "PR_SelectRutaClienteAsig";
            this.pRSelectRutaClienteAsigBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(218, 54);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(64, 16);
            this.lblClientes.TabIndex = 5;
            this.lblClientes.Text = "Clientes:";
            // 
            // lblRutasAsig
            // 
            this.lblRutasAsig.AutoSize = true;
            this.lblRutasAsig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutasAsig.Location = new System.Drawing.Point(591, 120);
            this.lblRutasAsig.Name = "lblRutasAsig";
            this.lblRutasAsig.Size = new System.Drawing.Size(117, 16);
            this.lblRutasAsig.TabIndex = 6;
            this.lblRutasAsig.Text = "Rutas Asignadas";
            // 
            // lblRutasNoAsig
            // 
            this.lblRutasNoAsig.AutoSize = true;
            this.lblRutasNoAsig.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutasNoAsig.Location = new System.Drawing.Point(128, 109);
            this.lblRutasNoAsig.Name = "lblRutasNoAsig";
            this.lblRutasNoAsig.Size = new System.Drawing.Size(139, 16);
            this.lblRutasNoAsig.TabIndex = 7;
            this.lblRutasNoAsig.Text = "Rutas No Asignadas";
            // 
            // txtRuta1
            // 
            this.txtRuta1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRuta1.Location = new System.Drawing.Point(113, 139);
            this.txtRuta1.Name = "txtRuta1";
            this.txtRuta1.Size = new System.Drawing.Size(220, 21);
            this.txtRuta1.TabIndex = 8;
            this.txtRuta1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuta1_KeyPress);
            // 
            // txtRuta2
            // 
            this.txtRuta2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRuta2.Location = new System.Drawing.Point(541, 139);
            this.txtRuta2.Name = "txtRuta2";
            this.txtRuta2.Size = new System.Drawing.Size(220, 21);
            this.txtRuta2.TabIndex = 9;
            this.txtRuta2.TextChanged += new System.EventHandler(this.txtRuta2_TextChanged);
            this.txtRuta2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRuta2_KeyPress);
            // 
            // lblBuscar1
            // 
            this.lblBuscar1.AutoSize = true;
            this.lblBuscar1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar1.Location = new System.Drawing.Point(12, 140);
            this.lblBuscar1.Name = "lblBuscar1";
            this.lblBuscar1.Size = new System.Drawing.Size(95, 16);
            this.lblBuscar1.TabIndex = 10;
            this.lblBuscar1.Text = "Buscar Rutas:";
            // 
            // lblRutas2
            // 
            this.lblRutas2.AutoSize = true;
            this.lblRutas2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutas2.Location = new System.Drawing.Point(440, 140);
            this.lblRutas2.Name = "lblRutas2";
            this.lblRutas2.Size = new System.Drawing.Size(95, 16);
            this.lblRutas2.TabIndex = 11;
            this.lblRutas2.Text = "Buscar Rutas:";
            // 
            // tR_ClientesTableAdapter
            // 
            this.tR_ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // pR_SelectRutaClienteNoAsigTableAdapter
            // 
            this.pR_SelectRutaClienteNoAsigTableAdapter.ClearBeforeFill = true;
            // 
            // pR_SelectRutaClienteAsigTableAdapter
            // 
            this.pR_SelectRutaClienteAsigTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregarTodo
            // 
            this.btnAgregarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarTodo.FlatAppearance.BorderSize = 0;
            this.btnAgregarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarTodo.Image")));
            this.btnAgregarTodo.Location = new System.Drawing.Point(377, 233);
            this.btnAgregarTodo.Name = "btnAgregarTodo";
            this.btnAgregarTodo.Size = new System.Drawing.Size(45, 35);
            this.btnAgregarTodo.TabIndex = 14;
            this.btnAgregarTodo.UseVisualStyleBackColor = true;
            this.btnAgregarTodo.Click += new System.EventHandler(this.btnAgregarTodo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(376, 339);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 35);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(376, 286);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 35);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarTodo.FlatAppearance.BorderSize = 0;
            this.btnEliminarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarTodo.Image")));
            this.btnEliminarTodo.Location = new System.Drawing.Point(377, 392);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(45, 35);
            this.btnEliminarTodo.TabIndex = 17;
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // FrmAsigRutaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(798, 508);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarTodo);
            this.Controls.Add(this.lblRutas2);
            this.Controls.Add(this.lblBuscar1);
            this.Controls.Add(this.txtRuta2);
            this.Controls.Add(this.txtRuta1);
            this.Controls.Add(this.lblRutasNoAsig);
            this.Controls.Add(this.lblRutasAsig);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.dgvRutasAsignadas);
            this.Controls.Add(this.dgvRutasNoAsignadas);
            this.Controls.Add(this.cboClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAsigRutaClientes";
            this.Load += new System.EventHandler(this.FrmAsigRutaClientes_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.cboClientes, 0);
            this.Controls.SetChildIndex(this.dgvRutasNoAsignadas, 0);
            this.Controls.SetChildIndex(this.dgvRutasAsignadas, 0);
            this.Controls.SetChildIndex(this.lblClientes, 0);
            this.Controls.SetChildIndex(this.lblRutasAsig, 0);
            this.Controls.SetChildIndex(this.lblRutasNoAsig, 0);
            this.Controls.SetChildIndex(this.txtRuta1, 0);
            this.Controls.SetChildIndex(this.txtRuta2, 0);
            this.Controls.SetChildIndex(this.lblBuscar1, 0);
            this.Controls.SetChildIndex(this.lblRutas2, 0);
            this.Controls.SetChildIndex(this.btnAgregarTodo, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnEliminarTodo, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasNoAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectRutaClienteNoAsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutasAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectRutaClienteAsigBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.DataGridView dgvRutasNoAsignadas;
        private System.Windows.Forms.DataGridView dgvRutasAsignadas;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.Label lblRutasAsig;
        private System.Windows.Forms.Label lblRutasNoAsig;
        private System.Windows.Forms.TextBox txtRuta1;
        private System.Windows.Forms.TextBox txtRuta2;
        private System.Windows.Forms.Label lblBuscar1;
        private System.Windows.Forms.Label lblRutas2;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRClientesBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ClientesTableAdapter tR_ClientesTableAdapter;
        private System.Windows.Forms.BindingSource pRSelectRutaClienteNoAsigBindingSource;
        private System.Windows.Forms.BindingSource pRSelectRutaClienteAsigBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.PR_SelectRutaClienteNoAsigTableAdapter pR_SelectRutaClienteNoAsigTableAdapter;
        private DataSets.DsTransporteAdiggmTableAdapters.PR_SelectRutaClienteAsigTableAdapter pR_SelectRutaClienteAsigTableAdapter;
        private System.Windows.Forms.Button btnAgregarTodo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRutaNoAsig;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        }
}
