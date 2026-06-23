namespace ADIGGM.SAC
{
    partial class FrmAsocBuscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvAsoc = new System.Windows.Forms.DataGridView();
            this.cODSlcASMaestrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAsocBuscar = new System.Windows.Forms.TextBox();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcASMaestrasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(520, 0);
            this.btnMax.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(480, 0);
            this.btnMin.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(560, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(32, 15, 32, 15);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(420, 0);
            this.pgbProcesos.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 407);
            this.pnlFooter.Size = new System.Drawing.Size(600, 23);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(420, 25);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(91, 33);
            this.btnSeleccionar.TabIndex = 103;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvAsoc
            // 
            this.dgvAsoc.AllowUserToAddRows = false;
            this.dgvAsoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAsoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsoc.AutoGenerateColumns = false;
            this.dgvAsoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsoc.Location = new System.Drawing.Point(0, 103);
            this.dgvAsoc.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.dgvAsoc.Name = "dgvAsoc";
            this.dgvAsoc.ReadOnly = true;
            this.dgvAsoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsoc.Size = new System.Drawing.Size(600, 304);
            this.dgvAsoc.TabIndex = 104;
            // 
            // cODSlcASMaestrasBindingSource
            // 
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAsocBuscar);
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.groupBox1.Size = new System.Drawing.Size(600, 68);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Asociados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Identidad o Nombre";
            // 
            // txtAsocBuscar
            // 
            this.txtAsocBuscar.Location = new System.Drawing.Point(208, 31);
            this.txtAsocBuscar.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.txtAsocBuscar.Name = "txtAsocBuscar";
            this.txtAsocBuscar.Size = new System.Drawing.Size(208, 21);
            this.txtAsocBuscar.TabIndex = 104;
            this.txtAsocBuscar.TextChanged += new System.EventHandler(this.txtAsocBuscar_TextChanged);
            this.txtAsocBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAsocBuscar_KeyDown);
            this.txtAsocBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAsocBuscar_KeyPress);
            this.txtAsocBuscar.Leave += new System.EventHandler(this.txtAsocBuscar_Leave);
            // 
            // FrmAsocBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(600, 430);
            this.Controls.Add(this.dgvAsoc);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.Name = "FrmAsocBuscar";
            this.Load += new System.EventHandler(this.FrmAsocBuscar_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvAsoc, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcASMaestrasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvAsoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAsocBuscar;
        private System.Windows.Forms.BindingSource cODSlcASMaestrasBindingSource;
    }
}
