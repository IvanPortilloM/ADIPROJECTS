namespace ADIGGM.OC.Mantenimiento
{
    partial class ManAsigCuentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManAsigCuentas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.oCProductosCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNoAsig = new System.Windows.Forms.DataGridView();
            this.idVehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratistaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoristaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selección = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vehiculosNoAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvAsig = new System.Windows.Forms.DataGridView();
            this.idVehiculoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selección2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratistaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoristaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculosAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda2 = new System.Windows.Forms.TextBox();
            this.vehiculosNoAsigTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.VehiculosNoAsigTableAdapter();
            this.vehiculosAsigTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.VehiculosAsigTableAdapter();
            this.oC_ProductosCategoriasTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProductosCategoriasTableAdapter();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosNoAsigBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosAsigBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(156, 19);
            this.lblFooter.Text = "Asignar Categorias";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(780, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(740, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(820, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(680, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 408);
            this.pnlFooter.Size = new System.Drawing.Size(860, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboCategoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 36);
            this.panel1.TabIndex = 104;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria:";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DataSource = this.oCProductosCategoriasBindingSource;
            this.cboCategoria.DisplayMember = "Categoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(325, 6);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(253, 24);
            this.cboCategoria.TabIndex = 1;
            this.cboCategoria.ValueMember = "IdCatProducto";
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // oCProductosCategoriasBindingSource
            // 
            this.oCProductosCategoriasBindingSource.DataMember = "OC_ProductosCategorias";
            this.oCProductosCategoriasBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvNoAsig);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 337);
            this.panel2.TabIndex = 105;
            // 
            // dgvNoAsig
            // 
            this.dgvNoAsig.AllowUserToAddRows = false;
            this.dgvNoAsig.AllowUserToDeleteRows = false;
            this.dgvNoAsig.AutoGenerateColumns = false;
            this.dgvNoAsig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNoAsig.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNoAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoAsig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculoDataGridViewTextBoxColumn,
            this.CodVehiculo,
            this.contratistaDataGridViewTextBoxColumn,
            this.placaDataGridViewTextBoxColumn,
            this.motoristaDataGridViewTextBoxColumn,
            this.cuentaDataGridViewTextBoxColumn,
            this.Selección});
            this.dgvNoAsig.DataSource = this.vehiculosNoAsigBindingSource;
            this.dgvNoAsig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNoAsig.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNoAsig.Location = new System.Drawing.Point(0, 40);
            this.dgvNoAsig.Name = "dgvNoAsig";
            this.dgvNoAsig.RowHeadersVisible = false;
            this.dgvNoAsig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoAsig.Size = new System.Drawing.Size(406, 297);
            this.dgvNoAsig.TabIndex = 106;
            // 
            // idVehiculoDataGridViewTextBoxColumn
            // 
            this.idVehiculoDataGridViewTextBoxColumn.DataPropertyName = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.HeaderText = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn.Name = "idVehiculoDataGridViewTextBoxColumn";
            this.idVehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVehiculoDataGridViewTextBoxColumn.Visible = false;
            // 
            // CodVehiculo
            // 
            this.CodVehiculo.DataPropertyName = "CodVehiculo";
            this.CodVehiculo.FillWeight = 61.18918F;
            this.CodVehiculo.HeaderText = "Codigo";
            this.CodVehiculo.Name = "CodVehiculo";
            this.CodVehiculo.ReadOnly = true;
            // 
            // contratistaDataGridViewTextBoxColumn
            // 
            this.contratistaDataGridViewTextBoxColumn.DataPropertyName = "Contratista";
            this.contratistaDataGridViewTextBoxColumn.FillWeight = 161.8989F;
            this.contratistaDataGridViewTextBoxColumn.HeaderText = "Contratista";
            this.contratistaDataGridViewTextBoxColumn.Name = "contratistaDataGridViewTextBoxColumn";
            this.contratistaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.FillWeight = 89.58385F;
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // motoristaDataGridViewTextBoxColumn
            // 
            this.motoristaDataGridViewTextBoxColumn.DataPropertyName = "Motorista";
            this.motoristaDataGridViewTextBoxColumn.FillWeight = 113.0288F;
            this.motoristaDataGridViewTextBoxColumn.HeaderText = "Motorista";
            this.motoristaDataGridViewTextBoxColumn.Name = "motoristaDataGridViewTextBoxColumn";
            this.motoristaDataGridViewTextBoxColumn.ReadOnly = true;
            this.motoristaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cuentaDataGridViewTextBoxColumn
            // 
            this.cuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn.FillWeight = 135.9565F;
            this.cuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn.Name = "cuentaDataGridViewTextBoxColumn";
            // 
            // Selección
            // 
            this.Selección.FillWeight = 38.34297F;
            this.Selección.HeaderText = "";
            this.Selección.Name = "Selección";
            // 
            // vehiculosNoAsigBindingSource
            // 
            this.vehiculosNoAsigBindingSource.DataMember = "VehiculosNoAsig";
            this.vehiculosNoAsigBindingSource.DataSource = this.dsOC;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.txtBusqueda1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(406, 40);
            this.panel5.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehiculo:";
            // 
            // txtBusqueda1
            // 
            this.txtBusqueda1.Location = new System.Drawing.Point(95, 10);
            this.txtBusqueda1.Name = "txtBusqueda1";
            this.txtBusqueda1.Size = new System.Drawing.Size(256, 21);
            this.txtBusqueda1.TabIndex = 2;
            this.txtBusqueda1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda1_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvAsig);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(465, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 337);
            this.panel3.TabIndex = 106;
            // 
            // dgvAsig
            // 
            this.dgvAsig.AllowUserToAddRows = false;
            this.dgvAsig.AllowUserToDeleteRows = false;
            this.dgvAsig.AutoGenerateColumns = false;
            this.dgvAsig.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsig.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVehiculoDataGridViewTextBoxColumn1,
            this.Selección2,
            this.dataGridViewTextBoxColumn1,
            this.contratistaDataGridViewTextBoxColumn1,
            this.placaDataGridViewTextBoxColumn1,
            this.motoristaDataGridViewTextBoxColumn1,
            this.cuentaDataGridViewTextBoxColumn1});
            this.dgvAsig.DataSource = this.vehiculosAsigBindingSource;
            this.dgvAsig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsig.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvAsig.Location = new System.Drawing.Point(0, 40);
            this.dgvAsig.Name = "dgvAsig";
            this.dgvAsig.RowHeadersVisible = false;
            this.dgvAsig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsig.Size = new System.Drawing.Size(395, 297);
            this.dgvAsig.TabIndex = 106;
            this.dgvAsig.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsig_CellValueChanged);
            // 
            // idVehiculoDataGridViewTextBoxColumn1
            // 
            this.idVehiculoDataGridViewTextBoxColumn1.DataPropertyName = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn1.HeaderText = "IdVehiculo";
            this.idVehiculoDataGridViewTextBoxColumn1.Name = "idVehiculoDataGridViewTextBoxColumn1";
            this.idVehiculoDataGridViewTextBoxColumn1.Visible = false;
            // 
            // Selección2
            // 
            this.Selección2.FillWeight = 36.47503F;
            this.Selección2.HeaderText = "";
            this.Selección2.Name = "Selección2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodVehiculo";
            this.dataGridViewTextBoxColumn1.FillWeight = 64.54115F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // contratistaDataGridViewTextBoxColumn1
            // 
            this.contratistaDataGridViewTextBoxColumn1.DataPropertyName = "Contratista";
            this.contratistaDataGridViewTextBoxColumn1.FillWeight = 157.8051F;
            this.contratistaDataGridViewTextBoxColumn1.HeaderText = "Contratista";
            this.contratistaDataGridViewTextBoxColumn1.Name = "contratistaDataGridViewTextBoxColumn1";
            this.contratistaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn1
            // 
            this.placaDataGridViewTextBoxColumn1.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn1.FillWeight = 86.31226F;
            this.placaDataGridViewTextBoxColumn1.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn1.Name = "placaDataGridViewTextBoxColumn1";
            this.placaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // motoristaDataGridViewTextBoxColumn1
            // 
            this.motoristaDataGridViewTextBoxColumn1.DataPropertyName = "Motorista";
            this.motoristaDataGridViewTextBoxColumn1.FillWeight = 121.1881F;
            this.motoristaDataGridViewTextBoxColumn1.HeaderText = "Motorista";
            this.motoristaDataGridViewTextBoxColumn1.Name = "motoristaDataGridViewTextBoxColumn1";
            this.motoristaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.motoristaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // cuentaDataGridViewTextBoxColumn1
            // 
            this.cuentaDataGridViewTextBoxColumn1.DataPropertyName = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn1.FillWeight = 133.6785F;
            this.cuentaDataGridViewTextBoxColumn1.HeaderText = "Cuenta";
            this.cuentaDataGridViewTextBoxColumn1.Name = "cuentaDataGridViewTextBoxColumn1";
            // 
            // vehiculosAsigBindingSource
            // 
            this.vehiculosAsigBindingSource.DataMember = "VehiculosAsig";
            this.vehiculosAsigBindingSource.DataSource = this.dsOC;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtBusqueda2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 40);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vehiculo:";
            // 
            // txtBusqueda2
            // 
            this.txtBusqueda2.Location = new System.Drawing.Point(123, 10);
            this.txtBusqueda2.Name = "txtBusqueda2";
            this.txtBusqueda2.Size = new System.Drawing.Size(232, 21);
            this.txtBusqueda2.TabIndex = 1;
            this.txtBusqueda2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda2_KeyPress);
            // 
            // vehiculosNoAsigTableAdapter
            // 
            this.vehiculosNoAsigTableAdapter.ClearBeforeFill = true;
            // 
            // vehiculosAsigTableAdapter
            // 
            this.vehiculosAsigTableAdapter.ClearBeforeFill = true;
            // 
            // oC_ProductosCategoriasTableAdapter
            // 
            this.oC_ProductosCategoriasTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(413, 208);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(45, 35);
            this.btnAgregar.TabIndex = 108;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(413, 261);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(45, 35);
            this.btnEliminar.TabIndex = 107;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // ManAsigCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(860, 431);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManAsigCuentas";
            this.Text = "Asignar Categorias";
            this.Load += new System.EventHandler(this.ManAsigCuentas_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosNoAsigBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosAsigBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBusqueda2;
        private System.Windows.Forms.DataGridView dgvNoAsig;
        private System.Windows.Forms.BindingSource vehiculosNoAsigBindingSource;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.DataGridView dgvAsig;
        private DataSets.DsOCTableAdapters.VehiculosNoAsigTableAdapter vehiculosNoAsigTableAdapter;
        private System.Windows.Forms.BindingSource vehiculosAsigBindingSource;
        private DataSets.DsOCTableAdapters.VehiculosAsigTableAdapter vehiculosAsigTableAdapter;
        private System.Windows.Forms.BindingSource oCProductosCategoriasBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProductosCategoriasTableAdapter oC_ProductosCategoriasTableAdapter;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn contratistaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoristaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selección;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVehiculoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selección2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contratistaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn motoristaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaDataGridViewTextBoxColumn1;
    }
}
