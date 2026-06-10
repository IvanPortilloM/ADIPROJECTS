
namespace ADIGGM.Seguridad
{
    partial class frmMenuSistema
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
            this.dgvMenuSistema = new System.Windows.Forms.DataGridView();
            this.idMenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreFormulario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iconoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuSistema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
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
            this.btnMax.Location = new System.Drawing.Point(724, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(684, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(764, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(624, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 427);
            this.pnlFooter.Size = new System.Drawing.Size(804, 23);
            // 
            // dgvMenuSistema
            // 
            this.dgvMenuSistema.AllowUserToAddRows = false;
            this.dgvMenuSistema.AllowUserToDeleteRows = false;
            this.dgvMenuSistema.AutoGenerateColumns = false;
            this.dgvMenuSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuSistema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMenuDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.NombreFormulario,
            this.NombreMenu,
            this.iconoDataGridViewTextBoxColumn});
            this.dgvMenuSistema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenuSistema.Location = new System.Drawing.Point(0, 98);
            this.dgvMenuSistema.Name = "dgvMenuSistema";
            this.dgvMenuSistema.ReadOnly = true;
            this.dgvMenuSistema.RowHeadersVisible = false;
            this.dgvMenuSistema.Size = new System.Drawing.Size(804, 329);
            this.dgvMenuSistema.TabIndex = 103;
            this.dgvMenuSistema.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMenuSistema_DataError);
            this.dgvMenuSistema.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMenuSistema_RowsAdded);
            this.dgvMenuSistema.SelectionChanged += new System.EventHandler(this.dgvMenuSistema_SelectionChanged);
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
            // NombreFormulario
            // 
            this.NombreFormulario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreFormulario.DataPropertyName = "NombreFormulario";
            this.NombreFormulario.HeaderText = "Formulario";
            this.NombreFormulario.Name = "NombreFormulario";
            this.NombreFormulario.ReadOnly = true;
            // 
            // NombreMenu
            // 
            this.NombreMenu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreMenu.DataPropertyName = "NombreMenu";
            this.NombreMenu.HeaderText = "Menu";
            this.NombreMenu.Name = "NombreMenu";
            this.NombreMenu.ReadOnly = true;
            // 
            // iconoDataGridViewTextBoxColumn
            // 
            this.iconoDataGridViewTextBoxColumn.DataPropertyName = "Icono";
            this.iconoDataGridViewTextBoxColumn.HeaderText = "Icono";
            this.iconoDataGridViewTextBoxColumn.Name = "iconoDataGridViewTextBoxColumn";
            this.iconoDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // frmMenuSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.dgvMenuSistema);
            this.Name = "frmMenuSistema";
            this.Text = "frmMenuSistema";
            this.Load += new System.EventHandler(this.frmMenuSistema_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvMenuSistema, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuSistema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenuSistema;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreFormulario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn iconoDataGridViewTextBoxColumn;
    }
}