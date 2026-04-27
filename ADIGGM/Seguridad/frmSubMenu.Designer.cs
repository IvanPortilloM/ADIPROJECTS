
namespace ADIGGM.Seguridad
{
    partial class frmSubMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvSubMenu = new System.Windows.Forms.DataGridView();
            this.idSubMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreFormularioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKSubMenuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPermisos = new ADIGGM.DataSets.DsPermisos();
            this.cboMenuPadre = new System.Windows.Forms.ComboBox();
            this.menuTableAdapter = new ADIGGM.DataSets.DsPermisosTableAdapters.MenuTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.subMenuTableAdapter = new ADIGGM.DataSets.DsPermisosTableAdapters.SubMenuTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSubMenuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPermisos)).BeginInit();
            this.panel1.SuspendLayout();
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
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(720, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(680, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(760, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(620, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 427);
            this.pnlFooter.Size = new System.Drawing.Size(800, 23);
            // 
            // dgvSubMenu
            // 
            this.dgvSubMenu.AllowUserToAddRows = false;
            this.dgvSubMenu.AllowUserToDeleteRows = false;
            this.dgvSubMenu.AutoGenerateColumns = false;
            this.dgvSubMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSubMenuDataGridViewTextBoxColumn,
            this.idMenuDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nombreFormularioDataGridViewTextBoxColumn,
            this.nombreMenuDataGridViewTextBoxColumn});
            this.dgvSubMenu.DataSource = this.fKSubMenuBindingSource;
            this.dgvSubMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSubMenu.Location = new System.Drawing.Point(0, 135);
            this.dgvSubMenu.Name = "dgvSubMenu";
            this.dgvSubMenu.ReadOnly = true;
            this.dgvSubMenu.RowHeadersVisible = false;
            this.dgvSubMenu.Size = new System.Drawing.Size(800, 292);
            this.dgvSubMenu.TabIndex = 103;
            this.dgvSubMenu.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvSubMenu_DataError_1);
            this.dgvSubMenu.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvSubMenu_RowsAdded);
            // 
            // idSubMenuDataGridViewTextBoxColumn
            // 
            this.idSubMenuDataGridViewTextBoxColumn.DataPropertyName = "IdSubMenu";
            this.idSubMenuDataGridViewTextBoxColumn.HeaderText = "IdSubMenu";
            this.idSubMenuDataGridViewTextBoxColumn.Name = "idSubMenuDataGridViewTextBoxColumn";
            this.idSubMenuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSubMenuDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMenuDataGridViewTextBoxColumn
            // 
            this.idMenuDataGridViewTextBoxColumn.DataPropertyName = "IdMenu";
            this.idMenuDataGridViewTextBoxColumn.HeaderText = "IdMenu";
            this.idMenuDataGridViewTextBoxColumn.Name = "idMenuDataGridViewTextBoxColumn";
            this.idMenuDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMenuDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Texto";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreFormularioDataGridViewTextBoxColumn
            // 
            this.nombreFormularioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreFormularioDataGridViewTextBoxColumn.DataPropertyName = "NombreFormulario";
            this.nombreFormularioDataGridViewTextBoxColumn.HeaderText = "Formulario";
            this.nombreFormularioDataGridViewTextBoxColumn.Name = "nombreFormularioDataGridViewTextBoxColumn";
            this.nombreFormularioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreMenuDataGridViewTextBoxColumn
            // 
            this.nombreMenuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreMenuDataGridViewTextBoxColumn.DataPropertyName = "NombreMenu";
            this.nombreMenuDataGridViewTextBoxColumn.HeaderText = "Menú";
            this.nombreMenuDataGridViewTextBoxColumn.Name = "nombreMenuDataGridViewTextBoxColumn";
            this.nombreMenuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fKSubMenuBindingSource
            // 
            this.fKSubMenuBindingSource.DataMember = "FK_SubMenu_Menu";
            this.fKSubMenuBindingSource.DataSource = this.menuBindingSource;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "Menu";
            this.menuBindingSource.DataSource = this.dsPermisos;
            // 
            // dsPermisos
            // 
            this.dsPermisos.DataSetName = "DsPermisos";
            this.dsPermisos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboMenuPadre
            // 
            this.cboMenuPadre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboMenuPadre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMenuPadre.DataSource = this.menuBindingSource;
            this.cboMenuPadre.DisplayMember = "Nombre";
            this.cboMenuPadre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMenuPadre.FormattingEnabled = true;
            this.cboMenuPadre.Location = new System.Drawing.Point(300, 6);
            this.cboMenuPadre.Name = "cboMenuPadre";
            this.cboMenuPadre.Size = new System.Drawing.Size(195, 24);
            this.cboMenuPadre.TabIndex = 104;
            this.cboMenuPadre.ValueMember = "IdMenu";
            this.cboMenuPadre.SelectionChangeCommitted += new System.EventHandler(this.cboMenuPadre_SelectionChangeCommitted);
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboMenuPadre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Menú Padre:";
            // 
            // subMenuTableAdapter
            // 
            this.subMenuTableAdapter.ClearBeforeFill = true;
            // 
            // frmSubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSubMenu);
            this.Controls.Add(this.panel1);
            this.Name = "frmSubMenu";
            this.Text = "frmSubMenu";
            this.Load += new System.EventHandler(this.frmSubMenu_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgvSubMenu, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSubMenuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPermisos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubMenu;
        private System.Windows.Forms.ComboBox cboMenuPadre;
        private DataSets.DsPermisos dsPermisos;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private DataSets.DsPermisosTableAdapters.MenuTableAdapter menuTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fKSubMenuBindingSource;
        private DataSets.DsPermisosTableAdapters.SubMenuTableAdapter subMenuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreFormularioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMenuDataGridViewTextBoxColumn;
    }
}