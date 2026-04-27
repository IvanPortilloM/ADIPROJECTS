
namespace ADIGGM.Herramientas
{
    partial class frmDigitarEstadoCuentaBCO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDigitarEstadoCuentaBCO));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eliminarColumna = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnValidar = new System.Windows.Forms.Button();
            this.cboInst = new System.Windows.Forms.ComboBox();
            this.cODSlcInstBancariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.cboCta = new System.Windows.Forms.ComboBox();
            this.cODSlcInstBancariaCODSlcCcBancariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCodBanco = new System.Windows.Forms.Label();
            this.lblCuentaBCO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumMes = new System.Windows.Forms.Label();
            this.lblNombreMes = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cOD_SlcInstBancariaTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.COD_SlcInstBancariaTableAdapter();
            this.cOD_SlcCcBancariaTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.COD_SlcCcBancariaTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcInstBancariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcInstBancariaCODSlcCcBancariaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(877, 0);
            this.btnMax.Visible = false;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(837, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(917, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(777, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 471);
            this.pnlFooter.Size = new System.Drawing.Size(957, 23);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eliminarColumna});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(957, 299);
            this.dataGridView1.TabIndex = 103;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // eliminarColumna
            // 
            this.eliminarColumna.HeaderText = "Quitar";
            this.eliminarColumna.Name = "eliminarColumna";
            this.eliminarColumna.ReadOnly = true;
            this.eliminarColumna.Text = "Quitar";
            this.eliminarColumna.UseColumnTextForButtonValue = true;
            this.eliminarColumna.Width = 47;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(482, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 131);
            this.btnGuardar.TabIndex = 104;
            this.btnGuardar.Text = "Guardar en Codeas";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.Location = new System.Drawing.Point(3, 3);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(145, 131);
            this.btnCargar.TabIndex = 105;
            this.btnCargar.Text = "Cargar datos de Excel";
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(0, 153);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(42, 16);
            this.lblSuma.TabIndex = 106;
            this.lblSuma.Text = "Total:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.Controls.Add(this.btnValidar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCargar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGuardar, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(341, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(616, 137);
            this.tableLayoutPanel1.TabIndex = 108;
            // 
            // btnValidar
            // 
            this.btnValidar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnValidar.Enabled = false;
            this.btnValidar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.Image = ((System.Drawing.Image)(resources.GetObject("btnValidar.Image")));
            this.btnValidar.Location = new System.Drawing.Point(154, 3);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(171, 131);
            this.btnValidar.TabIndex = 106;
            this.btnValidar.Text = "Validar datos";
            this.btnValidar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // cboInst
            // 
            this.cboInst.DataSource = this.cODSlcInstBancariaBindingSource;
            this.cboInst.DisplayMember = "cnombbanca";
            this.cboInst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInst.FormattingEnabled = true;
            this.cboInst.Location = new System.Drawing.Point(3, 41);
            this.cboInst.Name = "cboInst";
            this.cboInst.Size = new System.Drawing.Size(231, 24);
            this.cboInst.TabIndex = 109;
            this.cboInst.ValueMember = "ccodibanca";
            this.cboInst.SelectedIndexChanged += new System.EventHandler(this.cboInst_SelectedIndexChanged);
            // 
            // cODSlcInstBancariaBindingSource
            // 
            this.cODSlcInstBancariaBindingSource.DataMember = "COD_SlcInstBancaria";
            this.cODSlcInstBancariaBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboCta
            // 
            this.cboCta.DataSource = this.cODSlcInstBancariaCODSlcCcBancariaBindingSource;
            this.cboCta.DisplayMember = "cbenefbanc";
            this.cboCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCta.FormattingEnabled = true;
            this.cboCta.Location = new System.Drawing.Point(3, 71);
            this.cboCta.Name = "cboCta";
            this.cboCta.Size = new System.Drawing.Size(231, 24);
            this.cboCta.TabIndex = 110;
            this.cboCta.ValueMember = "cctabancar";
            // 
            // cODSlcInstBancariaCODSlcCcBancariaBindingSource
            // 
            this.cODSlcInstBancariaCODSlcCcBancariaBindingSource.DataMember = "COD_SlcInstBancaria_COD_SlcCcBancaria";
            this.cODSlcInstBancariaCODSlcCcBancariaBindingSource.DataSource = this.cODSlcInstBancariaBindingSource;
            // 
            // lblCodBanco
            // 
            this.lblCodBanco.AutoSize = true;
            this.lblCodBanco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cODSlcInstBancariaBindingSource, "ccodibanca", true));
            this.lblCodBanco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodBanco.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCodBanco.Location = new System.Drawing.Point(240, 43);
            this.lblCodBanco.Name = "lblCodBanco";
            this.lblCodBanco.Size = new System.Drawing.Size(73, 16);
            this.lblCodBanco.TabIndex = 111;
            this.lblCodBanco.Text = "Institución";
            // 
            // lblCuentaBCO
            // 
            this.lblCuentaBCO.AutoSize = true;
            this.lblCuentaBCO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cODSlcInstBancariaCODSlcCcBancariaBindingSource, "cctabancar", true));
            this.lblCuentaBCO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuentaBCO.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCuentaBCO.Location = new System.Drawing.Point(240, 73);
            this.lblCuentaBCO.Name = "lblCuentaBCO";
            this.lblCuentaBCO.Size = new System.Drawing.Size(83, 16);
            this.lblCuentaBCO.TabIndex = 112;
            this.lblCuentaBCO.Text = "CuentaBCO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 113;
            this.label1.Text = "Mes Conciliación:";
            // 
            // lblNumMes
            // 
            this.lblNumMes.AutoSize = true;
            this.lblNumMes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMes.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNumMes.Location = new System.Drawing.Point(131, 98);
            this.lblNumMes.Name = "lblNumMes";
            this.lblNumMes.Size = new System.Drawing.Size(63, 16);
            this.lblNumMes.TabIndex = 114;
            this.lblNumMes.Text = "NumMes";
            // 
            // lblNombreMes
            // 
            this.lblNombreMes.AutoSize = true;
            this.lblNombreMes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMes.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblNombreMes.Location = new System.Drawing.Point(201, 98);
            this.lblNombreMes.Name = "lblNombreMes";
            this.lblNombreMes.Size = new System.Drawing.Size(33, 16);
            this.lblNombreMes.TabIndex = 115;
            this.lblNombreMes.Text = "Mes";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblAnio.Location = new System.Drawing.Point(131, 114);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(63, 16);
            this.lblAnio.TabIndex = 117;
            this.lblAnio.Text = "NumAño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 116;
            this.label3.Text = "Año Conciliación:";
            // 
            // cOD_SlcInstBancariaTableAdapter
            // 
            this.cOD_SlcInstBancariaTableAdapter.ClearBeforeFill = true;
            // 
            // cOD_SlcCcBancariaTableAdapter
            // 
            this.cOD_SlcCcBancariaTableAdapter.ClearBeforeFill = true;
            // 
            // frmDigitarEstadoCuentaBCO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(957, 494);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombreMes);
            this.Controls.Add(this.lblNumMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCuentaBCO);
            this.Controls.Add(this.lblCodBanco);
            this.Controls.Add(this.cboCta);
            this.Controls.Add(this.cboInst);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDigitarEstadoCuentaBCO";
            this.Load += new System.EventHandler(this.frmDigitarEstadoCuentaBCO_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.lblSuma, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.cboInst, 0);
            this.Controls.SetChildIndex(this.cboCta, 0);
            this.Controls.SetChildIndex(this.lblCodBanco, 0);
            this.Controls.SetChildIndex(this.lblCuentaBCO, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblNumMes, 0);
            this.Controls.SetChildIndex(this.lblNombreMes, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblAnio, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcInstBancariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcInstBancariaCODSlcCcBancariaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarColumna;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.ComboBox cboInst;
        private System.Windows.Forms.BindingSource cODSlcInstBancariaBindingSource;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.ComboBox cboCta;
        private System.Windows.Forms.BindingSource cODSlcInstBancariaCODSlcCcBancariaBindingSource;
        private System.Windows.Forms.Label lblCodBanco;
        private System.Windows.Forms.Label lblCuentaBCO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumMes;
        private System.Windows.Forms.Label lblNombreMes;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label label3;
        private DataSets.DsOCTableAdapters.COD_SlcInstBancariaTableAdapter cOD_SlcInstBancariaTableAdapter;
        private DataSets.DsOCTableAdapters.COD_SlcCcBancariaTableAdapter cOD_SlcCcBancariaTableAdapter;
    }
}
