namespace ADIGGM.Mantenimiento
{
    partial class FrmActualizarTarifas
    {
        /// <summary>Variable del diseñador necesaria.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Limpiar los recursos que se estén usando.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.tabsProceso = new System.Windows.Forms.TabControl();
            this.tpBase = new System.Windows.Forms.TabPage();
            this.lblTvBase = new System.Windows.Forms.Label();
            this.cboTvBase = new System.Windows.Forms.ComboBox();
            this.tpAsig = new System.Windows.Forms.TabPage();
            this.lblClienteA = new System.Windows.Forms.Label();
            this.cboClienteAsig = new System.Windows.Forms.ComboBox();
            this.lblTvA = new System.Windows.Forms.Label();
            this.cboTvAsig = new System.Windows.Forms.ComboBox();
            this.lblClaseA = new System.Windows.Forms.Label();
            this.cboClaseAsig = new System.Windows.Forms.ComboBox();
            this.tpViaje = new System.Windows.Forms.TabPage();
            this.lblClienteV = new System.Windows.Forms.Label();
            this.cboClienteViaje = new System.Windows.Forms.ComboBox();
            this.lblTvV = new System.Windows.Forms.Label();
            this.cboTvViaje = new System.Windows.Forms.ComboBox();
            this.lblClaseV = new System.Windows.Forms.Label();
            this.cboClaseViaje = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.nudPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.lblModo = new System.Windows.Forms.Label();
            this.cboModoCalculo = new System.Windows.Forms.ComboBox();
            this.btnPrevia = new System.Windows.Forms.Button();
            this.dgvPrevia = new System.Windows.Forms.DataGridView();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            this.tabsProceso.SuspendLayout();
            this.tpBase.SuspendLayout();
            this.tpAsig.SuspendLayout();
            this.tpViaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(303, 19);
            this.lblFooter.Text = "ACTUALIZAR TARIFAS POR PORCENTAJE";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(740, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(700, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(780, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(640, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 537);
            this.pnlFooter.Size = new System.Drawing.Size(820, 23);
            // 
            // tabsProceso
            // 
            this.tabsProceso.Controls.Add(this.tpBase);
            this.tabsProceso.Controls.Add(this.tpAsig);
            this.tabsProceso.Controls.Add(this.tpViaje);
            this.tabsProceso.Location = new System.Drawing.Point(6, 40);
            this.tabsProceso.Name = "tabsProceso";
            this.tabsProceso.SelectedIndex = 0;
            this.tabsProceso.Size = new System.Drawing.Size(806, 108);
            this.tabsProceso.TabIndex = 0;
            this.tabsProceso.SelectedIndexChanged += new System.EventHandler(this.tabsProceso_SelectedIndexChanged);
            // 
            // tpBase
            // 
            this.tpBase.BackColor = System.Drawing.SystemColors.Control;
            this.tpBase.Controls.Add(this.lblTvBase);
            this.tpBase.Controls.Add(this.cboTvBase);
            this.tpBase.Location = new System.Drawing.Point(4, 25);
            this.tpBase.Name = "tpBase";
            this.tpBase.Padding = new System.Windows.Forms.Padding(3);
            this.tpBase.Size = new System.Drawing.Size(798, 79);
            this.tpBase.TabIndex = 0;
            this.tpBase.Text = "Tarifa base";
            // 
            // lblTvBase
            // 
            this.lblTvBase.AutoSize = true;
            this.lblTvBase.Location = new System.Drawing.Point(15, 28);
            this.lblTvBase.Name = "lblTvBase";
            this.lblTvBase.Size = new System.Drawing.Size(99, 16);
            this.lblTvBase.TabIndex = 0;
            this.lblTvBase.Text = "Tipo de Vehículo:";
            // 
            // cboTvBase
            // 
            this.cboTvBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTvBase.FormattingEnabled = true;
            this.cboTvBase.Location = new System.Drawing.Point(140, 25);
            this.cboTvBase.Name = "cboTvBase";
            this.cboTvBase.Size = new System.Drawing.Size(220, 24);
            this.cboTvBase.TabIndex = 1;
            // 
            // tpAsig
            // 
            this.tpAsig.BackColor = System.Drawing.SystemColors.Control;
            this.tpAsig.Controls.Add(this.lblClienteA);
            this.tpAsig.Controls.Add(this.cboClienteAsig);
            this.tpAsig.Controls.Add(this.lblTvA);
            this.tpAsig.Controls.Add(this.cboTvAsig);
            this.tpAsig.Controls.Add(this.lblClaseA);
            this.tpAsig.Controls.Add(this.cboClaseAsig);
            this.tpAsig.Location = new System.Drawing.Point(4, 25);
            this.tpAsig.Name = "tpAsig";
            this.tpAsig.Padding = new System.Windows.Forms.Padding(3);
            this.tpAsig.Size = new System.Drawing.Size(798, 79);
            this.tpAsig.TabIndex = 1;
            this.tpAsig.Text = "Tarifa asignada";
            // 
            // lblClienteA
            // 
            this.lblClienteA.AutoSize = true;
            this.lblClienteA.Location = new System.Drawing.Point(15, 31);
            this.lblClienteA.Name = "lblClienteA";
            this.lblClienteA.Size = new System.Drawing.Size(48, 16);
            this.lblClienteA.TabIndex = 0;
            this.lblClienteA.Text = "Cliente:";
            // 
            // cboClienteAsig
            // 
            this.cboClienteAsig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClienteAsig.FormattingEnabled = true;
            this.cboClienteAsig.Location = new System.Drawing.Point(80, 28);
            this.cboClienteAsig.Name = "cboClienteAsig";
            this.cboClienteAsig.Size = new System.Drawing.Size(190, 24);
            this.cboClienteAsig.TabIndex = 1;
            // 
            // lblTvA
            // 
            this.lblTvA.AutoSize = true;
            this.lblTvA.Location = new System.Drawing.Point(285, 31);
            this.lblTvA.Name = "lblTvA";
            this.lblTvA.Size = new System.Drawing.Size(59, 16);
            this.lblTvA.TabIndex = 2;
            this.lblTvA.Text = "Tipo Veh.:";
            // 
            // cboTvAsig
            // 
            this.cboTvAsig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTvAsig.FormattingEnabled = true;
            this.cboTvAsig.Location = new System.Drawing.Point(355, 28);
            this.cboTvAsig.Name = "cboTvAsig";
            this.cboTvAsig.Size = new System.Drawing.Size(150, 24);
            this.cboTvAsig.TabIndex = 3;
            // 
            // lblClaseA
            // 
            this.lblClaseA.AutoSize = true;
            this.lblClaseA.Location = new System.Drawing.Point(520, 31);
            this.lblClaseA.Name = "lblClaseA";
            this.lblClaseA.Size = new System.Drawing.Size(70, 16);
            this.lblClaseA.TabIndex = 4;
            this.lblClaseA.Text = "Clase Trab.:";
            // 
            // cboClaseAsig
            // 
            this.cboClaseAsig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClaseAsig.FormattingEnabled = true;
            this.cboClaseAsig.Location = new System.Drawing.Point(600, 28);
            this.cboClaseAsig.Name = "cboClaseAsig";
            this.cboClaseAsig.Size = new System.Drawing.Size(185, 24);
            this.cboClaseAsig.TabIndex = 5;
            // 
            // tpViaje
            // 
            this.tpViaje.BackColor = System.Drawing.SystemColors.Control;
            this.tpViaje.Controls.Add(this.lblClienteV);
            this.tpViaje.Controls.Add(this.cboClienteViaje);
            this.tpViaje.Controls.Add(this.lblTvV);
            this.tpViaje.Controls.Add(this.cboTvViaje);
            this.tpViaje.Controls.Add(this.lblClaseV);
            this.tpViaje.Controls.Add(this.cboClaseViaje);
            this.tpViaje.Controls.Add(this.lblDesde);
            this.tpViaje.Controls.Add(this.dtpDesde);
            this.tpViaje.Controls.Add(this.lblHasta);
            this.tpViaje.Controls.Add(this.dtpHasta);
            this.tpViaje.Location = new System.Drawing.Point(4, 25);
            this.tpViaje.Name = "tpViaje";
            this.tpViaje.Padding = new System.Windows.Forms.Padding(3);
            this.tpViaje.Size = new System.Drawing.Size(798, 79);
            this.tpViaje.TabIndex = 2;
            this.tpViaje.Text = "Boletas (viajes)";
            // 
            // lblClienteV
            // 
            this.lblClienteV.AutoSize = true;
            this.lblClienteV.Location = new System.Drawing.Point(15, 18);
            this.lblClienteV.Name = "lblClienteV";
            this.lblClienteV.Size = new System.Drawing.Size(48, 16);
            this.lblClienteV.TabIndex = 0;
            this.lblClienteV.Text = "Cliente:";
            // 
            // cboClienteViaje
            // 
            this.cboClienteViaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClienteViaje.FormattingEnabled = true;
            this.cboClienteViaje.Location = new System.Drawing.Point(80, 15);
            this.cboClienteViaje.Name = "cboClienteViaje";
            this.cboClienteViaje.Size = new System.Drawing.Size(190, 24);
            this.cboClienteViaje.TabIndex = 1;
            // 
            // lblTvV
            // 
            this.lblTvV.AutoSize = true;
            this.lblTvV.Location = new System.Drawing.Point(285, 18);
            this.lblTvV.Name = "lblTvV";
            this.lblTvV.Size = new System.Drawing.Size(59, 16);
            this.lblTvV.TabIndex = 2;
            this.lblTvV.Text = "Tipo Veh.:";
            // 
            // cboTvViaje
            // 
            this.cboTvViaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTvViaje.FormattingEnabled = true;
            this.cboTvViaje.Location = new System.Drawing.Point(355, 15);
            this.cboTvViaje.Name = "cboTvViaje";
            this.cboTvViaje.Size = new System.Drawing.Size(150, 24);
            this.cboTvViaje.TabIndex = 3;
            // 
            // lblClaseV
            // 
            this.lblClaseV.AutoSize = true;
            this.lblClaseV.Location = new System.Drawing.Point(520, 18);
            this.lblClaseV.Name = "lblClaseV";
            this.lblClaseV.Size = new System.Drawing.Size(70, 16);
            this.lblClaseV.TabIndex = 4;
            this.lblClaseV.Text = "Clase Trab.:";
            // 
            // cboClaseViaje
            // 
            this.cboClaseViaje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClaseViaje.FormattingEnabled = true;
            this.cboClaseViaje.Location = new System.Drawing.Point(600, 15);
            this.cboClaseViaje.Name = "cboClaseViaje";
            this.cboClaseViaje.Size = new System.Drawing.Size(185, 24);
            this.cboClaseViaje.TabIndex = 5;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(15, 52);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(44, 16);
            this.lblDesde.TabIndex = 6;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(80, 49);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(120, 21);
            this.dtpDesde.TabIndex = 7;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(220, 52);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(42, 16);
            this.lblHasta.TabIndex = 8;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(275, 49);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(120, 21);
            this.dtpHasta.TabIndex = 9;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPorcentaje.Location = new System.Drawing.Point(12, 160);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(85, 13);
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.Text = "Porcentaje %:";
            // 
            // nudPorcentaje
            // 
            this.nudPorcentaje.DecimalPlaces = 2;
            this.nudPorcentaje.Location = new System.Drawing.Point(110, 157);
            this.nudPorcentaje.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPorcentaje.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudPorcentaje.Name = "nudPorcentaje";
            this.nudPorcentaje.Size = new System.Drawing.Size(90, 21);
            this.nudPorcentaje.TabIndex = 2;
            this.nudPorcentaje.ThousandsSeparator = true;
            this.nudPorcentaje.ValueChanged += new System.EventHandler(this.nudPorcentaje_ValueChanged);
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblModo.Location = new System.Drawing.Point(380, 160);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(42, 13);
            this.lblModo.TabIndex = 8;
            this.lblModo.Text = "Modo:";
            // 
            // cboModoCalculo
            // 
            this.cboModoCalculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModoCalculo.FormattingEnabled = true;
            this.cboModoCalculo.Items.AddRange(new object[] {
            "Reversible",
            "Directo"});
            this.cboModoCalculo.Location = new System.Drawing.Point(425, 157);
            this.cboModoCalculo.Name = "cboModoCalculo";
            this.cboModoCalculo.Size = new System.Drawing.Size(120, 24);
            this.cboModoCalculo.TabIndex = 9;
            this.cboModoCalculo.SelectedIndexChanged += new System.EventHandler(this.cboModoCalculo_SelectedIndexChanged);
            // 
            // btnPrevia
            // 
            this.btnPrevia.Location = new System.Drawing.Point(230, 153);
            this.btnPrevia.Name = "btnPrevia";
            this.btnPrevia.Size = new System.Drawing.Size(120, 28);
            this.btnPrevia.TabIndex = 3;
            this.btnPrevia.Text = "Vista previa";
            this.btnPrevia.UseVisualStyleBackColor = true;
            this.btnPrevia.Click += new System.EventHandler(this.btnPrevia_Click);
            // 
            // dgvPrevia
            // 
            this.dgvPrevia.AllowUserToAddRows = false;
            this.dgvPrevia.AllowUserToDeleteRows = false;
            this.dgvPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrevia.Location = new System.Drawing.Point(6, 188);
            this.dgvPrevia.Name = "dgvPrevia";
            this.dgvPrevia.RowHeadersVisible = false;
            this.dgvPrevia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrevia.Size = new System.Drawing.Size(806, 300);
            this.dgvPrevia.TabIndex = 4;
            this.dgvPrevia.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrevia_CellEndEdit);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRegistros.Location = new System.Drawing.Point(12, 500);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(75, 13);
            this.lblRegistros.TabIndex = 5;
            this.lblRegistros.Text = "Registros: 0";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(610, 495);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(95, 30);
            this.btnAplicar.TabIndex = 6;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(712, 495);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 30);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmActualizarTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 560);
            this.Controls.Add(this.tabsProceso);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.nudPorcentaje);
            this.Controls.Add(this.btnPrevia);
            this.Controls.Add(this.dgvPrevia);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.cboModoCalculo);
            this.Name = "FrmActualizarTarifas";
            this.Text = "Actualizar Tarifas";
            this.Load += new System.EventHandler(this.FrmActualizarTarifas_Load);
            this.Controls.SetChildIndex(this.cboModoCalculo, 0);
            this.Controls.SetChildIndex(this.lblModo, 0);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnAplicar, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.dgvPrevia, 0);
            this.Controls.SetChildIndex(this.btnPrevia, 0);
            this.Controls.SetChildIndex(this.nudPorcentaje, 0);
            this.Controls.SetChildIndex(this.lblPorcentaje, 0);
            this.Controls.SetChildIndex(this.tabsProceso, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.tabsProceso.ResumeLayout(false);
            this.tpBase.ResumeLayout(false);
            this.tpBase.PerformLayout();
            this.tpAsig.ResumeLayout(false);
            this.tpAsig.PerformLayout();
            this.tpViaje.ResumeLayout(false);
            this.tpViaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabsProceso;
        private System.Windows.Forms.TabPage tpBase;
        private System.Windows.Forms.Label lblTvBase;
        private System.Windows.Forms.ComboBox cboTvBase;
        private System.Windows.Forms.TabPage tpAsig;
        private System.Windows.Forms.Label lblClienteA;
        private System.Windows.Forms.ComboBox cboClienteAsig;
        private System.Windows.Forms.Label lblTvA;
        private System.Windows.Forms.ComboBox cboTvAsig;
        private System.Windows.Forms.Label lblClaseA;
        private System.Windows.Forms.ComboBox cboClaseAsig;
        private System.Windows.Forms.TabPage tpViaje;
        private System.Windows.Forms.Label lblClienteV;
        private System.Windows.Forms.ComboBox cboClienteViaje;
        private System.Windows.Forms.Label lblTvV;
        private System.Windows.Forms.ComboBox cboTvViaje;
        private System.Windows.Forms.Label lblClaseV;
        private System.Windows.Forms.ComboBox cboClaseViaje;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.NumericUpDown nudPorcentaje;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.ComboBox cboModoCalculo;
        private System.Windows.Forms.Button btnPrevia;
        private System.Windows.Forms.DataGridView dgvPrevia;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnSalir;
    }
}
