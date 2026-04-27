
namespace ADIGGM.OC.Visores
{
    partial class VisOCSolicitudes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisOCSolicitudes));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.rdbCompletado = new System.Windows.Forms.RadioButton();
            this.rdbAutorizado = new System.Windows.Forms.RadioButton();
            this.rdbEnProceso = new System.Windows.Forms.RadioButton();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.dgvOC = new System.Windows.Forms.DataGridView();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(159, 19);
            this.lblFooter.Text = "Visor Solicitudes OC";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(1076, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(1036, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(1116, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(976, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 459);
            this.pnlFooter.Size = new System.Drawing.Size(1156, 23);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCompletar);
            this.splitContainer1.Panel1.Controls.Add(this.rdbCompletado);
            this.splitContainer1.Panel1.Controls.Add(this.rdbAutorizado);
            this.splitContainer1.Panel1.Controls.Add(this.rdbEnProceso);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefrescar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvOC);
            this.splitContainer1.Size = new System.Drawing.Size(1156, 424);
            this.splitContainer1.SplitterDistance = 88;
            this.splitContainer1.TabIndex = 106;
            // 
            // btnCompletar
            // 
            this.btnCompletar.BackColor = System.Drawing.Color.Transparent;
            this.btnCompletar.Image = ((System.Drawing.Image)(resources.GetObject("btnCompletar.Image")));
            this.btnCompletar.Location = new System.Drawing.Point(1006, 20);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(121, 57);
            this.btnCompletar.TabIndex = 4;
            this.btnCompletar.Text = "Completar Acción";
            this.btnCompletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompletar.UseVisualStyleBackColor = false;
            this.btnCompletar.Click += new System.EventHandler(this.btnCompletar_Click);
            // 
            // rdbCompletado
            // 
            this.rdbCompletado.AutoSize = true;
            this.rdbCompletado.Location = new System.Drawing.Point(266, 36);
            this.rdbCompletado.Name = "rdbCompletado";
            this.rdbCompletado.Size = new System.Drawing.Size(95, 20);
            this.rdbCompletado.TabIndex = 3;
            this.rdbCompletado.Text = "Completado";
            this.rdbCompletado.UseVisualStyleBackColor = true;
            this.rdbCompletado.CheckedChanged += new System.EventHandler(this.rdbCompletado_CheckedChanged);
            // 
            // rdbAutorizado
            // 
            this.rdbAutorizado.AutoSize = true;
            this.rdbAutorizado.Checked = true;
            this.rdbAutorizado.Location = new System.Drawing.Point(128, 37);
            this.rdbAutorizado.Name = "rdbAutorizado";
            this.rdbAutorizado.Size = new System.Drawing.Size(83, 20);
            this.rdbAutorizado.TabIndex = 2;
            this.rdbAutorizado.TabStop = true;
            this.rdbAutorizado.Text = "Autorizado";
            this.rdbAutorizado.UseVisualStyleBackColor = true;
            this.rdbAutorizado.CheckedChanged += new System.EventHandler(this.rdbAutorizado_CheckedChanged);
            // 
            // rdbEnProceso
            // 
            this.rdbEnProceso.AutoSize = true;
            this.rdbEnProceso.Location = new System.Drawing.Point(12, 37);
            this.rdbEnProceso.Name = "rdbEnProceso";
            this.rdbEnProceso.Size = new System.Drawing.Size(83, 20);
            this.rdbEnProceso.TabIndex = 1;
            this.rdbEnProceso.Text = "En Proceso";
            this.rdbEnProceso.UseVisualStyleBackColor = true;
            this.rdbEnProceso.CheckedChanged += new System.EventHandler(this.rdbEnProceso_CheckedChanged);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(912, 18);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(88, 57);
            this.btnRefrescar.TabIndex = 0;
            this.btnRefrescar.Text = "Recargar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // dgvOC
            // 
            this.dgvOC.AllowUserToAddRows = false;
            this.dgvOC.AllowUserToDeleteRows = false;
            this.dgvOC.AllowUserToResizeColumns = false;
            this.dgvOC.AllowUserToResizeRows = false;
            this.dgvOC.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvOC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOC.Location = new System.Drawing.Point(0, 0);
            this.dgvOC.MultiSelect = false;
            this.dgvOC.Name = "dgvOC";
            this.dgvOC.ReadOnly = true;
            this.dgvOC.RowTemplate.ReadOnly = true;
            this.dgvOC.Size = new System.Drawing.Size(1156, 332);
            this.dgvOC.TabIndex = 0;
            this.dgvOC.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvOC_DataError);
            // 
            // VisOCSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1156, 482);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VisOCSolicitudes";
            this.Text = "Visor Solicitudes OC";
            this.Load += new System.EventHandler(this.VisOCSolicitudes_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.RadioButton rdbCompletado;
        private System.Windows.Forms.RadioButton rdbAutorizado;
        private System.Windows.Forms.RadioButton rdbEnProceso;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.DataGridView dgvOC;
    }
}
