
namespace ADIGGM.Seguridad
{
    partial class frmAsigPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsigPermisos));
            this.dgvPermisosAsig = new System.Windows.Forms.DataGridView();
            this.uspCargarPermisosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.tRUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImp = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosAsig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspCargarPermisosBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRUsuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(731, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(691, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(771, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(631, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 718);
            this.pnlFooter.Size = new System.Drawing.Size(811, 23);
            // 
            // dgvPermisosAsig
            // 
            this.dgvPermisosAsig.AllowUserToAddRows = false;
            this.dgvPermisosAsig.AllowUserToDeleteRows = false;
            this.dgvPermisosAsig.AllowUserToResizeRows = false;
            this.dgvPermisosAsig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisosAsig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPermisosAsig.Location = new System.Drawing.Point(0, 131);
            this.dgvPermisosAsig.Name = "dgvPermisosAsig";
            this.dgvPermisosAsig.RowHeadersVisible = false;
            this.dgvPermisosAsig.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermisosAsig.Size = new System.Drawing.Size(811, 587);
            this.dgvPermisosAsig.TabIndex = 103;
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboUsuarios);
            this.groupBox2.Controls.Add(this.btnImp);
            this.groupBox2.Controls.Add(this.btnRecargar);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 96);
            this.groupBox2.TabIndex = 105;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 122;
            this.label1.Text = "Usuario:";
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboUsuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUsuarios.DataSource = this.tRUsuariosBindingSource;
            this.cboUsuarios.DisplayMember = "NombreApellido";
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(197, 45);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(311, 24);
            this.cboUsuarios.TabIndex = 121;
            this.cboUsuarios.ValueMember = "IdUsuario";
            this.cboUsuarios.SelectionChangeCommitted += new System.EventHandler(this.cboUsuarios_SelectionChangeCommitted);
            // 
            // btnImp
            // 
            this.btnImp.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImp.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnImp.FlatAppearance.BorderSize = 0;
            this.btnImp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImp.ForeColor = System.Drawing.Color.White;
            this.btnImp.Image = global::ADIGGM.Properties.Resources.select_all_off;
            this.btnImp.Location = new System.Drawing.Point(608, 17);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(40, 76);
            this.btnImp.TabIndex = 118;
            this.btnImp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            // 
            // btnRecargar
            // 
            this.btnRecargar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRecargar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnRecargar.FlatAppearance.BorderSize = 0;
            this.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRecargar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.ForeColor = System.Drawing.Color.White;
            this.btnRecargar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargar.Image")));
            this.btnRecargar.Location = new System.Drawing.Point(648, 17);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(74, 76);
            this.btnRecargar.TabIndex = 120;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(722, 17);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 76);
            this.btnGuardar.TabIndex = 117;
            this.btnGuardar.Text = "Guardar Permisos";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //
            // frmAsigPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(811, 741);
            this.Controls.Add(this.dgvPermisosAsig);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmAsigPermisos";
            this.Load += new System.EventHandler(this.frmAsigPermisos_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.dgvPermisosAsig, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosAsig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspCargarPermisosBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRUsuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPermisosAsig;
        private System.Windows.Forms.BindingSource uspCargarPermisosBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.BindingSource tRUsuariosBindingSource;
        private System.Windows.Forms.Label label1;
    }
}
