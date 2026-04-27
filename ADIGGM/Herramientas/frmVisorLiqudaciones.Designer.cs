namespace ADIGGM.Herramientas
{
    partial class frmVisorLiqudaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisorLiqudaciones));
            this.dgvLiqRe = new System.Windows.Forms.DataGridView();
            this.dtpFecIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFecFin = new System.Windows.Forms.DateTimePicker();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.rdbLiq = new System.Windows.Forms.RadioButton();
            this.rdbRenun = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIncRev = new System.Windows.Forms.CheckBox();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.tRUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.tR_UsuariosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_UsuariosTableAdapter();
            this.btnExportar = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiqRe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(1079, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(1039, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(1119, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(979, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 584);
            this.pnlFooter.Size = new System.Drawing.Size(1159, 23);
            // 
            // dgvLiqRe
            // 
            this.dgvLiqRe.AllowUserToAddRows = false;
            this.dgvLiqRe.AllowUserToDeleteRows = false;
            this.dgvLiqRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiqRe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLiqRe.Location = new System.Drawing.Point(0, 117);
            this.dgvLiqRe.Name = "dgvLiqRe";
            this.dgvLiqRe.ReadOnly = true;
            this.dgvLiqRe.RowHeadersVisible = false;
            this.dgvLiqRe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLiqRe.Size = new System.Drawing.Size(1159, 467);
            this.dgvLiqRe.TabIndex = 103;
            // 
            // dtpFecIni
            // 
            this.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecIni.Location = new System.Drawing.Point(12, 60);
            this.dtpFecIni.Name = "dtpFecIni";
            this.dtpFecIni.Size = new System.Drawing.Size(96, 21);
            this.dtpFecIni.TabIndex = 104;
            // 
            // dtpFecFin
            // 
            this.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecFin.Location = new System.Drawing.Point(125, 60);
            this.dtpFecFin.Name = "dtpFecFin";
            this.dtpFecFin.Size = new System.Drawing.Size(96, 21);
            this.dtpFecFin.TabIndex = 105;
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "NDB",
            "ORD",
            "CKS"});
            this.cboTipoDoc.Location = new System.Drawing.Point(256, 86);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(75, 24);
            this.cboTipoDoc.TabIndex = 106;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(840, 44);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(69, 57);
            this.btnVisualizar.TabIndex = 107;
            this.btnVisualizar.Text = "Ejecutar";
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // rdbLiq
            // 
            this.rdbLiq.AutoSize = true;
            this.rdbLiq.Checked = true;
            this.rdbLiq.Location = new System.Drawing.Point(247, 60);
            this.rdbLiq.Name = "rdbLiq";
            this.rdbLiq.Size = new System.Drawing.Size(99, 20);
            this.rdbLiq.TabIndex = 108;
            this.rdbLiq.TabStop = true;
            this.rdbLiq.Text = "Liquidaciones";
            this.rdbLiq.UseVisualStyleBackColor = true;
            // 
            // rdbRenun
            // 
            this.rdbRenun.AutoSize = true;
            this.rdbRenun.Location = new System.Drawing.Point(347, 60);
            this.rdbRenun.Name = "rdbRenun";
            this.rdbRenun.Size = new System.Drawing.Size(81, 20);
            this.rdbRenun.TabIndex = 109;
            this.rdbRenun.Text = "Renuncias";
            this.rdbRenun.UseVisualStyleBackColor = true;
            this.rdbRenun.CheckedChanged += new System.EventHandler(this.rdbRenun_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "Fecha Inicio";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(199, 90);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(51, 16);
            this.lblTipoDoc.TabIndex = 111;
            this.lblTipoDoc.Text = "TipoDoc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 112;
            this.label3.Text = "Fecha Fin";
            // 
            // chkIncRev
            // 
            this.chkIncRev.AutoSize = true;
            this.chkIncRev.Location = new System.Drawing.Point(434, 60);
            this.chkIncRev.Name = "chkIncRev";
            this.chkIncRev.Size = new System.Drawing.Size(120, 20);
            this.chkIncRev.TabIndex = 113;
            this.chkIncRev.Text = "Incluir reversadas";
            this.chkIncRev.UseVisualStyleBackColor = true;
            this.chkIncRev.Visible = false;
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DataSource = this.tRUsuariosBindingSource;
            this.cboUsuarios.DisplayMember = "NombreUsuario";
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(347, 87);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(106, 24);
            this.cboUsuarios.TabIndex = 114;
            this.cboUsuarios.ValueMember = "NombreUsuario";
            // 
            // tRUsuariosBindingSource
            // 
            this.tRUsuariosBindingSource.DataMember = "TR_Usuarios";
            this.tRUsuariosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tR_UsuariosTableAdapter
            // 
            this.tR_UsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.Transparent;
            this.btnExportar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Location = new System.Drawing.Point(1092, 35);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(67, 82);
            this.btnExportar.TabIndex = 115;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frmVisorLiqudaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1159, 607);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.cboUsuarios);
            this.Controls.Add(this.chkIncRev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbRenun);
            this.Controls.Add(this.rdbLiq);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.dtpFecFin);
            this.Controls.Add(this.dtpFecIni);
            this.Controls.Add(this.dgvLiqRe);
            this.Name = "frmVisorLiqudaciones";
            this.Load += new System.EventHandler(this.frmVisorLiqudaciones_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvLiqRe, 0);
            this.Controls.SetChildIndex(this.dtpFecIni, 0);
            this.Controls.SetChildIndex(this.dtpFecFin, 0);
            this.Controls.SetChildIndex(this.cboTipoDoc, 0);
            this.Controls.SetChildIndex(this.btnVisualizar, 0);
            this.Controls.SetChildIndex(this.rdbLiq, 0);
            this.Controls.SetChildIndex(this.rdbRenun, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTipoDoc, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.chkIncRev, 0);
            this.Controls.SetChildIndex(this.cboUsuarios, 0);
            this.Controls.SetChildIndex(this.btnExportar, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiqRe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLiqRe;
        private System.Windows.Forms.DateTimePicker dtpFecIni;
        private System.Windows.Forms.DateTimePicker dtpFecFin;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.RadioButton rdbLiq;
        private System.Windows.Forms.RadioButton rdbRenun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIncRev;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRUsuariosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_UsuariosTableAdapter tR_UsuariosTableAdapter;
        private System.Windows.Forms.Button btnExportar;
    }
}
