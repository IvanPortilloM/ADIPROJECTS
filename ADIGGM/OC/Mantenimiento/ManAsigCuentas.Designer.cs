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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNoAsig = new System.Windows.Forms.DataGridView();
            this.vehiculosNoAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvAsig = new System.Windows.Forms.DataGridView();
            this.vehiculosAsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusqueda2 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasBindingSource)).BeginInit();
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
            this.dgvNoAsig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNoAsig.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNoAsig.Location = new System.Drawing.Point(0, 40);
            this.dgvNoAsig.Name = "dgvNoAsig";
            this.dgvNoAsig.RowHeadersVisible = false;
            this.dgvNoAsig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNoAsig.Size = new System.Drawing.Size(406, 297);
            this.dgvNoAsig.TabIndex = 106;
            //
            // vehiculosNoAsigBindingSource
            // 
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
            // vehiculosAsigBindingSource
            // 
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
        private System.Windows.Forms.DataGridView dgvAsig;
        private System.Windows.Forms.BindingSource vehiculosAsigBindingSource;
        private System.Windows.Forms.BindingSource oCProductosCategoriasBindingSource;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
