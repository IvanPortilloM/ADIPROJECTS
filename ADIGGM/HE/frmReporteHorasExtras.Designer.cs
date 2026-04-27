namespace ADIGGM.HE
{
    partial class frmReporteHorasExtras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteHorasExtras));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportarConsolidado = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.chkMostrarTodosLosDias = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cboMotoristas = new System.Windows.Forms.ComboBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.lblTotalExtras75 = new System.Windows.Forms.Label();
            this.lblTotalExtras100 = new System.Windows.Forms.Label();
            this.lblTotalExtras50 = new System.Windows.Forms.Label();
            this.lblTotalExtras25 = new System.Windows.Forms.Label();
            this.lblGranTotalLps = new System.Windows.Forms.Label();
            this.lblTotalRegulares = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.pnlTotales.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(1201, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(1161, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(1241, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(1101, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 597);
            this.pnlFooter.Size = new System.Drawing.Size(1281, 23);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportarConsolidado);
            this.groupBox1.Controls.Add(this.btnExportarExcel);
            this.groupBox1.Controls.Add(this.chkMostrarTodosLosDias);
            this.groupBox1.Controls.Add(this.btnGenerar);
            this.groupBox1.Controls.Add(this.cboMotoristas);
            this.groupBox1.Controls.Add(this.dtpFin);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1281, 82);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnExportarConsolidado
            // 
            this.btnExportarConsolidado.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExportarConsolidado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarConsolidado.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarConsolidado.Image")));
            this.btnExportarConsolidado.Location = new System.Drawing.Point(1092, 20);
            this.btnExportarConsolidado.Name = "btnExportarConsolidado";
            this.btnExportarConsolidado.Size = new System.Drawing.Size(165, 51);
            this.btnExportarConsolidado.TabIndex = 9;
            this.btnExportarConsolidado.Text = "Exportar Resumen";
            this.btnExportarConsolidado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarConsolidado.UseVisualStyleBackColor = true;
            this.btnExportarConsolidado.Click += new System.EventHandler(this.btnExportarConsolidado_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.Image")));
            this.btnExportarExcel.Location = new System.Drawing.Point(893, 20);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(155, 51);
            this.btnExportarExcel.TabIndex = 8;
            this.btnExportarExcel.Text = "Exportar Detalle Hrs Extras";
            this.btnExportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // chkMostrarTodosLosDias
            // 
            this.chkMostrarTodosLosDias.AutoSize = true;
            this.chkMostrarTodosLosDias.Location = new System.Drawing.Point(397, 35);
            this.chkMostrarTodosLosDias.Name = "chkMostrarTodosLosDias";
            this.chkMostrarTodosLosDias.Size = new System.Drawing.Size(225, 20);
            this.chkMostrarTodosLosDias.TabIndex = 7;
            this.chkMostrarTodosLosDias.Text = "Mostrar todos los días (incluir 0 extras)";
            this.chkMostrarTodosLosDias.UseVisualStyleBackColor = true;
            this.chkMostrarTodosLosDias.Visible = false;
            this.chkMostrarTodosLosDias.CheckedChanged += new System.EventHandler(this.chkMostrarTodosLosDias_CheckedChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerar.Image")));
            this.btnGenerar.Location = new System.Drawing.Point(628, 21);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(115, 48);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cboMotoristas
            // 
            this.cboMotoristas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboMotoristas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMotoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotoristas.FormattingEnabled = true;
            this.cboMotoristas.Location = new System.Drawing.Point(93, 46);
            this.cboMotoristas.Name = "cboMotoristas";
            this.cboMotoristas.Size = new System.Drawing.Size(285, 24);
            this.cboMotoristas.TabIndex = 5;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(282, 19);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(96, 21);
            this.dtpFin.TabIndex = 4;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(93, 19);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(96, 21);
            this.dtpInicio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Motorista:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Fin:";
            // 
            // dgvReporte
            // 
            this.dgvReporte.AllowUserToAddRows = false;
            this.dgvReporte.AllowUserToDeleteRows = false;
            this.dgvReporte.AllowUserToResizeColumns = false;
            this.dgvReporte.AllowUserToResizeRows = false;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReporte.Location = new System.Drawing.Point(0, 117);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.ReadOnly = true;
            this.dgvReporte.RowHeadersVisible = false;
            this.dgvReporte.Size = new System.Drawing.Size(1281, 400);
            this.dgvReporte.TabIndex = 104;
            // 
            // pnlTotales
            // 
            this.pnlTotales.Controls.Add(this.lblTotalExtras75);
            this.pnlTotales.Controls.Add(this.lblTotalExtras100);
            this.pnlTotales.Controls.Add(this.lblTotalExtras50);
            this.pnlTotales.Controls.Add(this.lblTotalExtras25);
            this.pnlTotales.Controls.Add(this.lblGranTotalLps);
            this.pnlTotales.Controls.Add(this.lblTotalRegulares);
            this.pnlTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotales.Location = new System.Drawing.Point(0, 517);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(1281, 80);
            this.pnlTotales.TabIndex = 105;
            // 
            // lblTotalExtras75
            // 
            this.lblTotalExtras75.AutoSize = true;
            this.lblTotalExtras75.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalExtras75.Location = new System.Drawing.Point(609, 32);
            this.lblTotalExtras75.Name = "lblTotalExtras75";
            this.lblTotalExtras75.Size = new System.Drawing.Size(0, 16);
            this.lblTotalExtras75.TabIndex = 5;
            // 
            // lblTotalExtras100
            // 
            this.lblTotalExtras100.AutoSize = true;
            this.lblTotalExtras100.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalExtras100.Location = new System.Drawing.Point(761, 32);
            this.lblTotalExtras100.Name = "lblTotalExtras100";
            this.lblTotalExtras100.Size = new System.Drawing.Size(0, 16);
            this.lblTotalExtras100.TabIndex = 4;
            // 
            // lblTotalExtras50
            // 
            this.lblTotalExtras50.AutoSize = true;
            this.lblTotalExtras50.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalExtras50.Location = new System.Drawing.Point(457, 32);
            this.lblTotalExtras50.Name = "lblTotalExtras50";
            this.lblTotalExtras50.Size = new System.Drawing.Size(0, 16);
            this.lblTotalExtras50.TabIndex = 3;
            // 
            // lblTotalExtras25
            // 
            this.lblTotalExtras25.AutoSize = true;
            this.lblTotalExtras25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalExtras25.Location = new System.Drawing.Point(305, 32);
            this.lblTotalExtras25.Name = "lblTotalExtras25";
            this.lblTotalExtras25.Size = new System.Drawing.Size(0, 16);
            this.lblTotalExtras25.TabIndex = 2;
            // 
            // lblGranTotalLps
            // 
            this.lblGranTotalLps.AutoSize = true;
            this.lblGranTotalLps.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGranTotalLps.Location = new System.Drawing.Point(919, 32);
            this.lblGranTotalLps.Name = "lblGranTotalLps";
            this.lblGranTotalLps.Size = new System.Drawing.Size(0, 16);
            this.lblGranTotalLps.TabIndex = 1;
            // 
            // lblTotalRegulares
            // 
            this.lblTotalRegulares.AutoSize = true;
            this.lblTotalRegulares.Location = new System.Drawing.Point(144, 32);
            this.lblTotalRegulares.Name = "lblTotalRegulares";
            this.lblTotalRegulares.Size = new System.Drawing.Size(0, 16);
            this.lblTotalRegulares.TabIndex = 0;
            // 
            // frmReporteHorasExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1281, 620);
            this.Controls.Add(this.dgvReporte);
            this.Controls.Add(this.pnlTotales);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReporteHorasExtras";
            this.Load += new System.EventHandler(this.frmReporteHorasExtras_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pnlTotales, 0);
            this.Controls.SetChildIndex(this.dgvReporte, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.ComboBox cboMotoristas;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.Label lblTotalExtras75;
        private System.Windows.Forms.Label lblTotalExtras100;
        private System.Windows.Forms.Label lblTotalExtras50;
        private System.Windows.Forms.Label lblTotalExtras25;
        private System.Windows.Forms.Label lblGranTotalLps;
        private System.Windows.Forms.Label lblTotalRegulares;
        private System.Windows.Forms.CheckBox chkMostrarTodosLosDias;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnExportarConsolidado;
    }
}
