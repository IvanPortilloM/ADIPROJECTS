namespace ADIGGM.SAC.Visores
{
    partial class frmVisorOrdenesSAC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisorOrdenesSAC));
            this.dgvVisor = new System.Windows.Forms.DataGridView();
            this.sACBuscarAsocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboOperador = new System.Windows.Forms.ComboBox();
            this.cboOrdenBusqueda = new System.Windows.Forms.ComboBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACBuscarAsocBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(1098, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(1058, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(1138, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(998, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 564);
            this.pnlFooter.Size = new System.Drawing.Size(1178, 23);
            // 
            // dgvVisor
            // 
            this.dgvVisor.AllowUserToAddRows = false;
            this.dgvVisor.AllowUserToDeleteRows = false;
            this.dgvVisor.AutoGenerateColumns = false;
            this.dgvVisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVisor.Location = new System.Drawing.Point(0, 139);
            this.dgvVisor.Name = "dgvVisor";
            this.dgvVisor.ReadOnly = true;
            this.dgvVisor.Size = new System.Drawing.Size(1178, 425);
            this.dgvVisor.TabIndex = 103;
            // 
            // sACBuscarAsocBindingSource
            // 
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboOperador);
            this.groupBox1.Controls.Add(this.cboOrdenBusqueda);
            this.groupBox1.Controls.Add(this.txtTexto);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 104);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 119;
            this.label1.Text = "Texto a buscar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 118;
            this.label4.Text = "Operador:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 117;
            this.label3.Text = "Orden de busqueda:";
            // 
            // cboOperador
            // 
            this.cboOperador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboOperador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperador.FormattingEnabled = true;
            this.cboOperador.Items.AddRange(new object[] {
            "IGUAL QUE",
            "CONTIENE"});
            this.cboOperador.Location = new System.Drawing.Point(534, 18);
            this.cboOperador.Name = "cboOperador";
            this.cboOperador.Size = new System.Drawing.Size(150, 24);
            this.cboOperador.TabIndex = 116;
            this.cboOperador.TabStop = false;
            // 
            // cboOrdenBusqueda
            // 
            this.cboOrdenBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboOrdenBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboOrdenBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenBusqueda.FormattingEnabled = true;
            this.cboOrdenBusqueda.Items.AddRange(new object[] {
            "DNI",
            "NOMBRE"});
            this.cboOrdenBusqueda.Location = new System.Drawing.Point(213, 18);
            this.cboOrdenBusqueda.Name = "cboOrdenBusqueda";
            this.cboOrdenBusqueda.Size = new System.Drawing.Size(150, 24);
            this.cboOrdenBusqueda.TabIndex = 115;
            this.cboOrdenBusqueda.TabStop = false;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(213, 62);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(308, 21);
            this.txtTexto.TabIndex = 107;
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(534, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(47, 48);
            this.btnBuscar.TabIndex = 106;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmVisorOrdenesSAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1178, 587);
            this.Controls.Add(this.dgvVisor);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVisorOrdenesSAC";
            this.Load += new System.EventHandler(this.frmVisorOrdenesSAC_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvVisor, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sACBuscarAsocBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboOperador;
        private System.Windows.Forms.ComboBox cboOrdenBusqueda;
        private System.Windows.Forms.BindingSource sACBuscarAsocBindingSource;
    }
}
