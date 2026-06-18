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
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.lblProceso = new System.Windows.Forms.Label();
            this.rbBase = new System.Windows.Forms.RadioButton();
            this.rbAsignada = new System.Windows.Forms.RadioButton();
            this.rbViajes = new System.Windows.Forms.RadioButton();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.lblTipoVeh = new System.Windows.Forms.Label();
            this.cboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.lblClase = new System.Windows.Forms.Label();
            this.cboClaseTrabajo = new System.Windows.Forms.ComboBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.nudPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.btnPrevia = new System.Windows.Forms.Button();
            this.dgvPrevia = new System.Windows.Forms.DataGridView();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            this.gbFiltros.SuspendLayout();
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
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbFiltros.Controls.Add(this.lblProceso);
            this.gbFiltros.Controls.Add(this.rbBase);
            this.gbFiltros.Controls.Add(this.rbAsignada);
            this.gbFiltros.Controls.Add(this.rbViajes);
            this.gbFiltros.Controls.Add(this.lblCliente);
            this.gbFiltros.Controls.Add(this.cboCliente);
            this.gbFiltros.Controls.Add(this.lblTipoVeh);
            this.gbFiltros.Controls.Add(this.cboTipoVehiculo);
            this.gbFiltros.Controls.Add(this.lblClase);
            this.gbFiltros.Controls.Add(this.cboClaseTrabajo);
            this.gbFiltros.Controls.Add(this.lblRuta);
            this.gbFiltros.Controls.Add(this.txtRuta);
            this.gbFiltros.Controls.Add(this.lblDesde);
            this.gbFiltros.Controls.Add(this.dtpDesde);
            this.gbFiltros.Controls.Add(this.lblHasta);
            this.gbFiltros.Controls.Add(this.dtpHasta);
            this.gbFiltros.Controls.Add(this.lblPorcentaje);
            this.gbFiltros.Controls.Add(this.nudPorcentaje);
            this.gbFiltros.Controls.Add(this.btnPrevia);
            this.gbFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.gbFiltros.Location = new System.Drawing.Point(6, 38);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(806, 152);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(12, 26);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(57, 13);
            this.lblProceso.TabIndex = 0;
            this.lblProceso.Text = "Proceso:";
            // 
            // rbBase
            // 
            this.rbBase.AutoSize = true;
            this.rbBase.Checked = true;
            this.rbBase.Location = new System.Drawing.Point(95, 24);
            this.rbBase.Name = "rbBase";
            this.rbBase.Size = new System.Drawing.Size(89, 17);
            this.rbBase.TabIndex = 1;
            this.rbBase.TabStop = true;
            this.rbBase.Text = "Tarifa base";
            this.rbBase.UseVisualStyleBackColor = true;
            this.rbBase.CheckedChanged += new System.EventHandler(this.Proceso_CheckedChanged);
            // 
            // rbAsignada
            // 
            this.rbAsignada.AutoSize = true;
            this.rbAsignada.Location = new System.Drawing.Point(210, 24);
            this.rbAsignada.Name = "rbAsignada";
            this.rbAsignada.Size = new System.Drawing.Size(113, 17);
            this.rbAsignada.TabIndex = 2;
            this.rbAsignada.Text = "Tarifa asignada";
            this.rbAsignada.UseVisualStyleBackColor = true;
            this.rbAsignada.CheckedChanged += new System.EventHandler(this.Proceso_CheckedChanged);
            // 
            // rbViajes
            // 
            this.rbViajes.AutoSize = true;
            this.rbViajes.Location = new System.Drawing.Point(360, 24);
            this.rbViajes.Name = "rbViajes";
            this.rbViajes.Size = new System.Drawing.Size(112, 17);
            this.rbViajes.TabIndex = 3;
            this.rbViajes.Text = "Boletas (viajes)";
            this.rbViajes.UseVisualStyleBackColor = true;
            this.rbViajes.CheckedChanged += new System.EventHandler(this.Proceso_CheckedChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 61);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(50, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente:";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(95, 58);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(190, 21);
            this.cboCliente.TabIndex = 5;
            // 
            // lblTipoVeh
            // 
            this.lblTipoVeh.AutoSize = true;
            this.lblTipoVeh.Location = new System.Drawing.Point(300, 61);
            this.lblTipoVeh.Name = "lblTipoVeh";
            this.lblTipoVeh.Size = new System.Drawing.Size(66, 13);
            this.lblTipoVeh.TabIndex = 6;
            this.lblTipoVeh.Text = "Tipo Veh.:";
            // 
            // cboTipoVehiculo
            // 
            this.cboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVehiculo.FormattingEnabled = true;
            this.cboTipoVehiculo.Location = new System.Drawing.Point(365, 58);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(160, 21);
            this.cboTipoVehiculo.TabIndex = 7;
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(540, 61);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(76, 13);
            this.lblClase.TabIndex = 8;
            this.lblClase.Text = "Clase Trab.:";
            // 
            // cboClaseTrabajo
            // 
            this.cboClaseTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClaseTrabajo.FormattingEnabled = true;
            this.cboClaseTrabajo.Location = new System.Drawing.Point(615, 58);
            this.cboClaseTrabajo.Name = "cboClaseTrabajo";
            this.cboClaseTrabajo.Size = new System.Drawing.Size(180, 21);
            this.cboClaseTrabajo.TabIndex = 9;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(12, 93);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(38, 13);
            this.lblRuta.TabIndex = 10;
            this.lblRuta.Text = "Ruta (opc.):";
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(95, 90);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(190, 20);
            this.txtRuta.TabIndex = 11;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(300, 93);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(47, 13);
            this.lblDesde.TabIndex = 12;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(365, 90);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(110, 20);
            this.dtpDesde.TabIndex = 13;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(490, 93);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(44, 13);
            this.lblHasta.TabIndex = 14;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(545, 90);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(110, 20);
            this.dtpHasta.TabIndex = 15;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(12, 124);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(85, 13);
            this.lblPorcentaje.TabIndex = 16;
            this.lblPorcentaje.Text = "Porcentaje %:";
            // 
            // nudPorcentaje
            // 
            this.nudPorcentaje.DecimalPlaces = 2;
            this.nudPorcentaje.Location = new System.Drawing.Point(110, 121);
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
            this.nudPorcentaje.Size = new System.Drawing.Size(90, 20);
            this.nudPorcentaje.TabIndex = 17;
            this.nudPorcentaje.ThousandsSeparator = true;
            this.nudPorcentaje.ValueChanged += new System.EventHandler(this.nudPorcentaje_ValueChanged);
            // 
            // btnPrevia
            // 
            this.btnPrevia.Location = new System.Drawing.Point(230, 117);
            this.btnPrevia.Name = "btnPrevia";
            this.btnPrevia.Size = new System.Drawing.Size(120, 28);
            this.btnPrevia.TabIndex = 18;
            this.btnPrevia.Text = "Vista previa";
            this.btnPrevia.UseVisualStyleBackColor = true;
            this.btnPrevia.Click += new System.EventHandler(this.btnPrevia_Click);
            // 
            // dgvPrevia
            // 
            this.dgvPrevia.AllowUserToAddRows = false;
            this.dgvPrevia.AllowUserToDeleteRows = false;
            this.dgvPrevia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrevia.Location = new System.Drawing.Point(6, 197);
            this.dgvPrevia.Name = "dgvPrevia";
            this.dgvPrevia.RowHeadersVisible = false;
            this.dgvPrevia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrevia.Size = new System.Drawing.Size(806, 300);
            this.dgvPrevia.TabIndex = 19;
            this.dgvPrevia.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrevia_CellEndEdit);
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblRegistros.Location = new System.Drawing.Point(12, 508);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(75, 13);
            this.lblRegistros.TabIndex = 20;
            this.lblRegistros.Text = "Registros: 0";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(610, 502);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(95, 30);
            this.btnAplicar.TabIndex = 21;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(712, 502);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 30);
            this.btnSalir.TabIndex = 22;
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
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.dgvPrevia);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmActualizarTarifas";
            this.Text = "Actualizar Tarifas";
            this.Load += new System.EventHandler(this.FrmActualizarTarifas_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnAplicar, 0);
            this.Controls.SetChildIndex(this.lblRegistros, 0);
            this.Controls.SetChildIndex(this.dgvPrevia, 0);
            this.Controls.SetChildIndex(this.gbFiltros, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrevia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.RadioButton rbBase;
        private System.Windows.Forms.RadioButton rbAsignada;
        private System.Windows.Forms.RadioButton rbViajes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label lblTipoVeh;
        private System.Windows.Forms.ComboBox cboTipoVehiculo;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.ComboBox cboClaseTrabajo;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.NumericUpDown nudPorcentaje;
        private System.Windows.Forms.Button btnPrevia;
        private System.Windows.Forms.DataGridView dgvPrevia;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnSalir;
    }
}
