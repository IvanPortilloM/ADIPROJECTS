namespace ADIGGM.Mantenimiento
{
    partial class FrmCierresBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCierresBuscar));
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvCierres = new System.Windows.Forms.DataGridView();
            this.tRCierresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRCierreClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoFac = new System.Windows.Forms.ComboBox();
            this.tRTipoFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.tRClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRCierresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRCierreClientesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(520, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(480, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(560, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(420, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 430);
            this.pnlFooter.Size = new System.Drawing.Size(600, 23);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.Location = new System.Drawing.Point(232, 10);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(80, 55);
            this.btnSeleccionar.TabIndex = 103;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvCierres
            // 
            this.dgvCierres.AllowUserToAddRows = false;
            this.dgvCierres.AllowUserToDeleteRows = false;
            this.dgvCierres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCierres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCierres.Location = new System.Drawing.Point(0, 100);
            this.dgvCierres.Name = "dgvCierres";
            this.dgvCierres.ReadOnly = true;
            this.dgvCierres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCierres.Size = new System.Drawing.Size(600, 259);
            this.dgvCierres.TabIndex = 104;
            // 
            // tRCierreClientesBindingSource
            // 
            this.tRCierreClientesBindingSource.DataMember = "TR_CierreClientes";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 71);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboTipoFac);
            this.groupBox2.Controls.Add(this.cboClientes);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 65);
            this.groupBox2.TabIndex = 106;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente y Tipo de Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elegir Tipo de Factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elegir Cliente";
            // 
            // cboTipoFac
            // 
            this.cboTipoFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTipoFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoFac.DataSource = this.tRTipoFacturasBindingSource;
            this.cboTipoFac.DisplayMember = "TipoFactura";
            this.cboTipoFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFac.FormattingEnabled = true;
            this.cboTipoFac.Location = new System.Drawing.Point(323, 36);
            this.cboTipoFac.Name = "cboTipoFac";
            this.cboTipoFac.Size = new System.Drawing.Size(216, 24);
            this.cboTipoFac.TabIndex = 1;
            this.cboTipoFac.ValueMember = "IdTipoFactura";
            this.cboTipoFac.SelectedValueChanged += new System.EventHandler(this.cboTipoFac_SelectedValueChanged);
            // 
            // cboClientes
            // 
            this.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClientes.DataSource = this.tRClientesBindingSource;
            this.cboClientes.DisplayMember = "Cliente";
            this.cboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(6, 36);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(201, 24);
            this.cboClientes.TabIndex = 0;
            this.cboClientes.ValueMember = "IdCliente";
            this.cboClientes.SelectedValueChanged += new System.EventHandler(this.cboClientes_SelectedValueChanged);
            // 
            // FrmCierresBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(600, 453);
            this.Controls.Add(this.dgvCierres);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmCierresBuscar";
            this.Load += new System.EventHandler(this.FrmCierresBuscar_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dgvCierres, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCierres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRCierresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRCierreClientesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRClientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvCierres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoFac;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.BindingSource tRCierreClientesBindingSource;
        private System.Windows.Forms.BindingSource tRCierresBindingSource;
        private System.Windows.Forms.BindingSource tRClientesBindingSource;
        private System.Windows.Forms.BindingSource tRTipoFacturasBindingSource;
    }
}
