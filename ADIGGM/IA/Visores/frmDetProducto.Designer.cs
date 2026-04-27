
namespace ADIGGM.IA.Visores
{
    partial class frmDetProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetProducto));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDetProd = new System.Windows.Forms.DataGridView();
            this.dfechamovi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnumconsec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmontomovi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nintermovi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmtocargos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncomisinte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsaldprinc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nporctasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnumrecibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnumasient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctipasient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctipasient1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccodmovimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombretip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corigmovim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdescmovim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnomusuari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnumoperac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cctabancar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nnumdocume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctipodocum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnumdeducc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdescrip01 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdescrip02 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSPSelCobrosCargarMovimientosProductosFilterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCA = new ADIGGM.DataSets.DsCA();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnObs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcdesdeducc = new System.Windows.Forms.TextBox();
            this.uSP_Sel_Cobros_CargarMovimientosProductos_FilterTableAdapter = new ADIGGM.DataSets.DsCATableAdapters.USP_Sel_Cobros_CargarMovimientosProductos_FilterTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPSelCobrosCargarMovimientosProductosFilterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(704, 0);
            this.btnMax.Visible = false;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(664, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(744, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(604, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 467);
            this.pnlFooter.Size = new System.Drawing.Size(784, 23);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 98);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSalir);
            this.splitContainer1.Panel2.Controls.Add(this.btnObs);
            this.splitContainer1.Size = new System.Drawing.Size(784, 369);
            this.splitContainer1.SplitterDistance = 302;
            this.splitContainer1.TabIndex = 103;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 302);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvDetProd);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movimientos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvDetProd
            // 
            this.dgvDetProd.AllowUserToAddRows = false;
            this.dgvDetProd.AllowUserToDeleteRows = false;
            this.dgvDetProd.AllowUserToResizeColumns = false;
            this.dgvDetProd.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.YellowGreen;
            this.dgvDetProd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetProd.AutoGenerateColumns = false;
            this.dgvDetProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDetProd.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dfechamovi,
            this.nnumconsec,
            this.nmontomovi,
            this.nintermovi,
            this.nmtocargos,
            this.ncomisinte,
            this.nsaldprinc,
            this.nporctasa,
            this.cnumrecibo,
            this.cnumasient,
            this.ctipasient,
            this.ctipasient1,
            this.ccodmovimi,
            this.cnombretip,
            this.corigmovim,
            this.cdescmovim,
            this.cnomusuari,
            this.cnumoperac,
            this.cctabancar,
            this.nnumdocume,
            this.ctipodocum,
            this.cnumdeducc1,
            this.cdescrip01,
            this.cdescrip02});
            this.dgvDetProd.DataSource = this.uSPSelCobrosCargarMovimientosProductosFilterBindingSource;
            this.dgvDetProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetProd.Location = new System.Drawing.Point(3, 3);
            this.dgvDetProd.Name = "dgvDetProd";
            this.dgvDetProd.ReadOnly = true;
            this.dgvDetProd.RowHeadersVisible = false;
            this.dgvDetProd.Size = new System.Drawing.Size(770, 267);
            this.dgvDetProd.TabIndex = 0;
            // 
            // dfechamovi
            // 
            this.dfechamovi.DataPropertyName = "dfechamovi";
            this.dfechamovi.HeaderText = "Fecha";
            this.dfechamovi.Name = "dfechamovi";
            this.dfechamovi.ReadOnly = true;
            this.dfechamovi.Width = 66;
            // 
            // nnumconsec
            // 
            this.nnumconsec.DataPropertyName = "nnumconsec";
            this.nnumconsec.HeaderText = "Recibo";
            this.nnumconsec.Name = "nnumconsec";
            this.nnumconsec.ReadOnly = true;
            this.nnumconsec.Width = 70;
            // 
            // nmontomovi
            // 
            this.nmontomovi.DataPropertyName = "nmontomovi";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.nmontomovi.DefaultCellStyle = dataGridViewCellStyle2;
            this.nmontomovi.HeaderText = "Monto";
            this.nmontomovi.Name = "nmontomovi";
            this.nmontomovi.ReadOnly = true;
            this.nmontomovi.Width = 68;
            // 
            // nintermovi
            // 
            this.nintermovi.DataPropertyName = "nintermovi";
            dataGridViewCellStyle3.Format = "N2";
            this.nintermovi.DefaultCellStyle = dataGridViewCellStyle3;
            this.nintermovi.HeaderText = "Interés";
            this.nintermovi.Name = "nintermovi";
            this.nintermovi.ReadOnly = true;
            this.nintermovi.Width = 67;
            // 
            // nmtocargos
            // 
            this.nmtocargos.DataPropertyName = "nmtocargos";
            dataGridViewCellStyle4.NullValue = "N2";
            this.nmtocargos.DefaultCellStyle = dataGridViewCellStyle4;
            this.nmtocargos.HeaderText = "Cargos";
            this.nmtocargos.Name = "nmtocargos";
            this.nmtocargos.ReadOnly = true;
            this.nmtocargos.Width = 70;
            // 
            // ncomisinte
            // 
            this.ncomisinte.DataPropertyName = "ncomisinte";
            dataGridViewCellStyle5.Format = "N2";
            this.ncomisinte.DefaultCellStyle = dataGridViewCellStyle5;
            this.ncomisinte.HeaderText = "Comisión";
            this.ncomisinte.Name = "ncomisinte";
            this.ncomisinte.ReadOnly = true;
            this.ncomisinte.Width = 80;
            // 
            // nsaldprinc
            // 
            this.nsaldprinc.DataPropertyName = "nsaldprinc";
            dataGridViewCellStyle6.Format = "N2";
            this.nsaldprinc.DefaultCellStyle = dataGridViewCellStyle6;
            this.nsaldprinc.HeaderText = "Saldo";
            this.nsaldprinc.Name = "nsaldprinc";
            this.nsaldprinc.ReadOnly = true;
            this.nsaldprinc.Width = 63;
            // 
            // nporctasa
            // 
            this.nporctasa.DataPropertyName = "nporctasa";
            dataGridViewCellStyle7.Format = "N2";
            this.nporctasa.DefaultCellStyle = dataGridViewCellStyle7;
            this.nporctasa.HeaderText = "Tasa";
            this.nporctasa.Name = "nporctasa";
            this.nporctasa.ReadOnly = true;
            this.nporctasa.Width = 57;
            // 
            // cnumrecibo
            // 
            this.cnumrecibo.DataPropertyName = "cnumrecibo";
            this.cnumrecibo.HeaderText = "Recibo.Caja";
            this.cnumrecibo.Name = "cnumrecibo";
            this.cnumrecibo.ReadOnly = true;
            // 
            // cnumasient
            // 
            this.cnumasient.DataPropertyName = "cnumasient";
            this.cnumasient.HeaderText = "Asiento";
            this.cnumasient.Name = "cnumasient";
            this.cnumasient.ReadOnly = true;
            this.cnumasient.Width = 70;
            // 
            // ctipasient
            // 
            this.ctipasient.DataPropertyName = "ctipasient";
            this.ctipasient.HeaderText = "Tip.Asi.";
            this.ctipasient.Name = "ctipasient";
            this.ctipasient.ReadOnly = true;
            this.ctipasient.Width = 66;
            // 
            // ctipasient1
            // 
            this.ctipasient1.DataPropertyName = "ctipasient1";
            this.ctipasient1.HeaderText = "ctipasient1";
            this.ctipasient1.Name = "ctipasient1";
            this.ctipasient1.ReadOnly = true;
            this.ctipasient1.Visible = false;
            // 
            // ccodmovimi
            // 
            this.ccodmovimi.DataPropertyName = "ccodmovimi";
            this.ccodmovimi.HeaderText = "Cod.Mov.";
            this.ccodmovimi.Name = "ccodmovimi";
            this.ccodmovimi.ReadOnly = true;
            this.ccodmovimi.Width = 88;
            // 
            // cnombretip
            // 
            this.cnombretip.DataPropertyName = "cnombretip";
            this.cnombretip.HeaderText = "Desc.Mov.";
            this.cnombretip.Name = "cnombretip";
            this.cnombretip.ReadOnly = true;
            this.cnombretip.Width = 90;
            // 
            // corigmovim
            // 
            this.corigmovim.DataPropertyName = "corigmovim";
            this.corigmovim.HeaderText = "Cod.Origen";
            this.corigmovim.Name = "corigmovim";
            this.corigmovim.ReadOnly = true;
            this.corigmovim.Width = 95;
            // 
            // cdescmovim
            // 
            this.cdescmovim.DataPropertyName = "cdescmovim";
            this.cdescmovim.HeaderText = "Desc.Origen";
            this.cdescmovim.Name = "cdescmovim";
            this.cdescmovim.ReadOnly = true;
            this.cdescmovim.Width = 97;
            // 
            // cnomusuari
            // 
            this.cnomusuari.DataPropertyName = "cnomusuari";
            this.cnomusuari.HeaderText = "Usuario";
            this.cnomusuari.Name = "cnomusuari";
            this.cnomusuari.ReadOnly = true;
            this.cnomusuari.Width = 71;
            // 
            // cnumoperac
            // 
            this.cnumoperac.DataPropertyName = "cnumoperac";
            this.cnumoperac.HeaderText = "Referencia";
            this.cnumoperac.Name = "cnumoperac";
            this.cnumoperac.ReadOnly = true;
            this.cnumoperac.Width = 90;
            // 
            // cctabancar
            // 
            this.cctabancar.DataPropertyName = "cctabancar";
            this.cctabancar.HeaderText = "Cta.Bancaria";
            this.cctabancar.Name = "cctabancar";
            this.cctabancar.ReadOnly = true;
            this.cctabancar.Width = 105;
            // 
            // nnumdocume
            // 
            this.nnumdocume.DataPropertyName = "nnumdocume";
            this.nnumdocume.HeaderText = "Documento";
            this.nnumdocume.Name = "nnumdocume";
            this.nnumdocume.ReadOnly = true;
            this.nnumdocume.Width = 96;
            // 
            // ctipodocum
            // 
            this.ctipodocum.DataPropertyName = "ctipodocum";
            this.ctipodocum.HeaderText = "Tipo.Docum.";
            this.ctipodocum.Name = "ctipodocum";
            this.ctipodocum.ReadOnly = true;
            this.ctipodocum.Width = 99;
            // 
            // cnumdeducc1
            // 
            this.cnumdeducc1.DataPropertyName = "cnumdeducc";
            this.cnumdeducc1.HeaderText = "cnumdeducc";
            this.cnumdeducc1.Name = "cnumdeducc1";
            this.cnumdeducc1.ReadOnly = true;
            this.cnumdeducc1.Visible = false;
            // 
            // cdescrip01
            // 
            this.cdescrip01.DataPropertyName = "cdescrip01";
            this.cdescrip01.HeaderText = "cdescrip01";
            this.cdescrip01.Name = "cdescrip01";
            this.cdescrip01.ReadOnly = true;
            this.cdescrip01.Visible = false;
            // 
            // cdescrip02
            // 
            this.cdescrip02.DataPropertyName = "cdescrip02";
            this.cdescrip02.HeaderText = "cdescrip02";
            this.cdescrip02.Name = "cdescrip02";
            this.cdescrip02.ReadOnly = true;
            this.cdescrip02.Visible = false;
            // 
            // uSPSelCobrosCargarMovimientosProductosFilterBindingSource
            // 
            this.uSPSelCobrosCargarMovimientosProductosFilterBindingSource.DataMember = "USP_Sel_Cobros_CargarMovimientosProductos_Filter";
            this.uSPSelCobrosCargarMovimientosProductosFilterBindingSource.DataSource = this.dsCA;
            // 
            // dsCA
            // 
            this.dsCA.DataSetName = "DsCA";
            this.dsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(737, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 63);
            this.btnSalir.TabIndex = 117;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnObs
            // 
            this.btnObs.Location = new System.Drawing.Point(318, 22);
            this.btnObs.Name = "btnObs";
            this.btnObs.Size = new System.Drawing.Size(138, 21);
            this.btnObs.TabIndex = 0;
            this.btnObs.Text = "Mostrar Observación";
            this.btnObs.UseVisualStyleBackColor = true;
            this.btnObs.Click += new System.EventHandler(this.btnObs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcdesdeducc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 63);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            // 
            // txtcdesdeducc
            // 
            this.txtcdesdeducc.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtcdesdeducc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcdesdeducc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcdesdeducc.Enabled = false;
            this.txtcdesdeducc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcdesdeducc.Location = new System.Drawing.Point(3, 17);
            this.txtcdesdeducc.Name = "txtcdesdeducc";
            this.txtcdesdeducc.Size = new System.Drawing.Size(778, 20);
            this.txtcdesdeducc.TabIndex = 0;
            this.txtcdesdeducc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uSP_Sel_Cobros_CargarMovimientosProductos_FilterTableAdapter
            // 
            this.uSP_Sel_Cobros_CargarMovimientosProductos_FilterTableAdapter.ClearBeforeFill = true;
            // 
            // frmDetProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(784, 490);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDetProducto";
            this.Load += new System.EventHandler(this.frmDetProducto_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPSelCobrosCargarMovimientosProductosFilterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvDetProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcdesdeducc;
        private System.Windows.Forms.BindingSource uSPSelCobrosCargarMovimientosProductosFilterBindingSource;
        private DataSets.DsCA dsCA;
        private DataSets.DsCATableAdapters.USP_Sel_Cobros_CargarMovimientosProductos_FilterTableAdapter uSP_Sel_Cobros_CargarMovimientosProductos_FilterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfechamovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnumconsec;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmontomovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nintermovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmtocargos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncomisinte;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsaldprinc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nporctasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnumrecibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnumasient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctipasient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctipasient1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccodmovimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombretip;
        private System.Windows.Forms.DataGridViewTextBoxColumn corigmovim;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdescmovim;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnomusuari;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnumoperac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cctabancar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nnumdocume;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctipodocum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnumdeducc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdescrip01;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdescrip02;
        private System.Windows.Forms.Button btnObs;
        private System.Windows.Forms.Button btnSalir;
    }
}
