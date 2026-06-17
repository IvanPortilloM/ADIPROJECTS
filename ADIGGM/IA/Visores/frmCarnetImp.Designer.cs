
namespace ADIGGM.IA.Visores
{
    partial class frmCarnetImp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarnetImp));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCarnetsImp = new System.Windows.Forms.DataGridView();
            this.cACarnetsAsocImpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnImpCarnets = new System.Windows.Forms.Button();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarnetsImp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cACarnetsAsocImpBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(981, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(941, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(1021, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(881, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 436);
            this.pnlFooter.Size = new System.Drawing.Size(1061, 23);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCarnetsImp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 310);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // dgvCarnetsImp
            // 
            this.dgvCarnetsImp.AllowUserToAddRows = false;
            this.dgvCarnetsImp.AllowUserToDeleteRows = false;
            this.dgvCarnetsImp.AllowUserToResizeRows = false;
            this.dgvCarnetsImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarnetsImp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCarnetsImp.Location = new System.Drawing.Point(3, 17);
            this.dgvCarnetsImp.Name = "dgvCarnetsImp";
            this.dgvCarnetsImp.RowHeadersVisible = false;
            this.dgvCarnetsImp.Size = new System.Drawing.Size(1055, 290);
            this.dgvCarnetsImp.TabIndex = 0;
            this.dgvCarnetsImp.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCarnetsImp_DataError);
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.btnImpCarnets);
            this.groupBox2.Controls.Add(this.btnImp);
            this.groupBox2.Controls.Add(this.btnRecargar);
            this.groupBox2.Controls.Add(this.btnExport);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1061, 91);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btnImpCarnets
            // 
            this.btnImpCarnets.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnImpCarnets.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnImpCarnets.FlatAppearance.BorderSize = 0;
            this.btnImpCarnets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImpCarnets.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpCarnets.ForeColor = System.Drawing.Color.White;
            this.btnImpCarnets.Image = ((System.Drawing.Image)(resources.GetObject("btnImpCarnets.Image")));
            this.btnImpCarnets.Location = new System.Drawing.Point(3, 17);
            this.btnImpCarnets.Name = "btnImpCarnets";
            this.btnImpCarnets.Size = new System.Drawing.Size(123, 71);
            this.btnImpCarnets.TabIndex = 119;
            this.btnImpCarnets.Text = "Imprimir y Entregar";
            this.btnImpCarnets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImpCarnets.UseVisualStyleBackColor = true;
            this.btnImpCarnets.Click += new System.EventHandler(this.btnImpCarnets_Click);
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
            this.btnImp.Location = new System.Drawing.Point(858, 17);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(40, 71);
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
            this.btnRecargar.Location = new System.Drawing.Point(898, 17);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(74, 71);
            this.btnRecargar.TabIndex = 120;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(972, 17);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(86, 71);
            this.btnExport.TabIndex = 117;
            this.btnExport.Text = "Exportar lista";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            //
            // frmCarnetImp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1061, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCarnetImp";
            this.Load += new System.EventHandler(this.frmCarnetImp_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarnetsImp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cACarnetsAsocImpBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCarnetsImp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource cACarnetsAsocImpBindingSource;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.Button btnImpCarnets;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}
