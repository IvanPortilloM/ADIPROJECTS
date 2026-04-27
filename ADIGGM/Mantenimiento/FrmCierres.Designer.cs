namespace ADIGGM.Mantenimiento
{
    partial class FrmCierres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCierres));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.CmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDetallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarFechaCierreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCierre = new System.Windows.Forms.DataGridView();
            this.numSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISVCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cerrado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.anulado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tRCierresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.tR_CierresTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_CierresTableAdapter();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CmsOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRCierresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(61, 19);
            this.lblFooter.Text = "Cierres";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(557, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(517, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(597, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(457, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 407);
            this.pnlFooter.Size = new System.Drawing.Size(637, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 63);
            this.panel1.TabIndex = 104;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(211, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(69, 57);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(367, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 57);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // CmsOpciones
            // 
            this.CmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.verDetallesToolStripMenuItem,
            this.cerrarToolStripMenuItem,
            this.editarFechaCierreToolStripMenuItem});
            this.CmsOpciones.Name = "CmsOpciones";
            this.CmsOpciones.Size = new System.Drawing.Size(173, 92);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // verDetallesToolStripMenuItem
            // 
            this.verDetallesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("verDetallesToolStripMenuItem.Image")));
            this.verDetallesToolStripMenuItem.Name = "verDetallesToolStripMenuItem";
            this.verDetallesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.verDetallesToolStripMenuItem.Text = "Ver Detalles";
            this.verDetallesToolStripMenuItem.Click += new System.EventHandler(this.verDetallesToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cerrarToolStripMenuItem.Image")));
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // editarFechaCierreToolStripMenuItem
            // 
            this.editarFechaCierreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarFechaCierreToolStripMenuItem.Image")));
            this.editarFechaCierreToolStripMenuItem.Name = "editarFechaCierreToolStripMenuItem";
            this.editarFechaCierreToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editarFechaCierreToolStripMenuItem.Text = "Editar Fecha Cierre";
            this.editarFechaCierreToolStripMenuItem.Click += new System.EventHandler(this.editarFechaCierreToolStripMenuItem_Click);
            // 
            // dgvCierre
            // 
            this.dgvCierre.AllowUserToAddRows = false;
            this.dgvCierre.AllowUserToDeleteRows = false;
            this.dgvCierre.AutoGenerateColumns = false;
            this.dgvCierre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCierre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSemana,
            this.semana,
            this.idCierre,
            this.fechaInicio,
            this.fechaFin,
            this.SubTotalCierre,
            this.ISVCierre,
            this.totalCierre,
            this.usuario,
            this.cerrado,
            this.anulado});
            this.dgvCierre.ContextMenuStrip = this.CmsOpciones;
            this.dgvCierre.DataSource = this.tRCierresBindingSource;
            this.dgvCierre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCierre.Location = new System.Drawing.Point(0, 98);
            this.dgvCierre.Name = "dgvCierre";
            this.dgvCierre.ReadOnly = true;
            this.dgvCierre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCierre.Size = new System.Drawing.Size(637, 309);
            this.dgvCierre.TabIndex = 105;
            this.dgvCierre.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCierre_DataError);
            this.dgvCierre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvCierre_MouseDown);
            // 
            // numSemana
            // 
            this.numSemana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numSemana.DataPropertyName = "NumSemana";
            this.numSemana.HeaderText = "NumSemana";
            this.numSemana.Name = "numSemana";
            this.numSemana.ReadOnly = true;
            this.numSemana.Visible = false;
            // 
            // semana
            // 
            this.semana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.semana.DataPropertyName = "Semana";
            this.semana.HeaderText = "Semana";
            this.semana.Name = "semana";
            this.semana.ReadOnly = true;
            this.semana.Width = 78;
            // 
            // idCierre
            // 
            this.idCierre.DataPropertyName = "IdCierre";
            this.idCierre.HeaderText = "IdCierre";
            this.idCierre.Name = "idCierre";
            this.idCierre.ReadOnly = true;
            this.idCierre.Visible = false;
            this.idCierre.Width = 110;
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaInicio.DataPropertyName = "FechaInicio";
            this.fechaInicio.HeaderText = "Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            this.fechaInicio.Width = 60;
            // 
            // fechaFin
            // 
            this.fechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaFin.DataPropertyName = "FechaFin";
            this.fechaFin.HeaderText = "Fin";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            this.fechaFin.Width = 46;
            // 
            // SubTotalCierre
            // 
            this.SubTotalCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SubTotalCierre.DataPropertyName = "SubTotalCierre";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.SubTotalCierre.DefaultCellStyle = dataGridViewCellStyle1;
            this.SubTotalCierre.HeaderText = "SubTotal";
            this.SubTotalCierre.Name = "SubTotalCierre";
            this.SubTotalCierre.ReadOnly = true;
            // 
            // ISVCierre
            // 
            this.ISVCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ISVCierre.DataPropertyName = "ISVCierre";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.ISVCierre.DefaultCellStyle = dataGridViewCellStyle2;
            this.ISVCierre.HeaderText = "ISV";
            this.ISVCierre.Name = "ISVCierre";
            this.ISVCierre.ReadOnly = true;
            // 
            // totalCierre
            // 
            this.totalCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalCierre.DataPropertyName = "TotalCierre";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.totalCierre.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalCierre.HeaderText = "Total";
            this.totalCierre.Name = "totalCierre";
            this.totalCierre.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "Usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // cerrado
            // 
            this.cerrado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cerrado.DataPropertyName = "Cerrado";
            this.cerrado.HeaderText = "Cerrado";
            this.cerrado.Name = "cerrado";
            this.cerrado.ReadOnly = true;
            this.cerrado.Width = 58;
            // 
            // anulado
            // 
            this.anulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.anulado.DataPropertyName = "Anulado";
            this.anulado.HeaderText = "Anulado";
            this.anulado.Name = "anulado";
            this.anulado.ReadOnly = true;
            this.anulado.Width = 59;
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
            // tR_CierresTableAdapter
            // 
            this.tR_CierresTableAdapter.ClearBeforeFill = true;
            // 
            // FrmCierres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(637, 430);
            this.Controls.Add(this.dgvCierre);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCierres";
            this.Load += new System.EventHandler(this.FrmCierres_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgvCierre, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CmsOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRCierresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ContextMenuStrip CmsOpciones;
        private System.Windows.Forms.DataGridView dgvCierre;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRCierresBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_CierresTableAdapter tR_CierresTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDetallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarFechaCierreToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISVCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cerrado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anulado;
    }
}
