namespace ADIGGM.HE
{
    partial class frmAsistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsistencias));
            this.dgvAsistencia = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.chkMostrarInactivos = new System.Windows.Forms.CheckBox();
            this.btnHorasExtras = new System.Windows.Forms.Button();
            this.chkIncluirSubcontratistas = new System.Windows.Forms.CheckBox();
            this.btnCerrarPeriodo = new System.Windows.Forms.Button();
            this.btnFeriados = new System.Windows.Forms.Button();
            this.cboFiltroPolitica = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPoliticas = new System.Windows.Forms.Button();
            this.btnTiposAsistencia = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(1118, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(1078, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(1158, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(1018, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 551);
            this.pnlFooter.Size = new System.Drawing.Size(1198, 23);
            // 
            // dgvAsistencia
            // 
            this.dgvAsistencia.AllowUserToAddRows = false;
            this.dgvAsistencia.AllowUserToDeleteRows = false;
            this.dgvAsistencia.AllowUserToResizeColumns = false;
            this.dgvAsistencia.AllowUserToResizeRows = false;
            this.dgvAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsistencia.Location = new System.Drawing.Point(0, 94);
            this.dgvAsistencia.Name = "dgvAsistencia";
            this.dgvAsistencia.ReadOnly = true;
            this.dgvAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsistencia.Size = new System.Drawing.Size(1198, 410);
            this.dgvAsistencia.TabIndex = 103;
            this.dgvAsistencia.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellDoubleClick);
            this.dgvAsistencia.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAsistencia_CellFormatting);
            this.dgvAsistencia.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellMouseEnter);
            this.dgvAsistencia.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsistencia_CellMouseLeave);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCargar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.Location = new System.Drawing.Point(795, 8);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(95, 45);
            this.btnCargar.TabIndex = 105;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // chkMostrarInactivos
            // 
            this.chkMostrarInactivos.AutoSize = true;
            this.chkMostrarInactivos.Location = new System.Drawing.Point(628, 8);
            this.chkMostrarInactivos.Name = "chkMostrarInactivos";
            this.chkMostrarInactivos.Size = new System.Drawing.Size(119, 20);
            this.chkMostrarInactivos.TabIndex = 106;
            this.chkMostrarInactivos.Text = "Mostrar Inactivos";
            this.chkMostrarInactivos.UseVisualStyleBackColor = true;
            this.chkMostrarInactivos.CheckedChanged += new System.EventHandler(this.chkMostrarInactivos_CheckedChanged);
            // 
            // btnHorasExtras
            // 
            this.btnHorasExtras.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHorasExtras.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnHorasExtras.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnHorasExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHorasExtras.Image = ((System.Drawing.Image)(resources.GetObject("btnHorasExtras.Image")));
            this.btnHorasExtras.Location = new System.Drawing.Point(1103, 0);
            this.btnHorasExtras.Name = "btnHorasExtras";
            this.btnHorasExtras.Size = new System.Drawing.Size(95, 47);
            this.btnHorasExtras.TabIndex = 107;
            this.btnHorasExtras.Text = "R. Horas Extras";
            this.btnHorasExtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHorasExtras.UseVisualStyleBackColor = false;
            this.btnHorasExtras.Click += new System.EventHandler(this.btnHorasExtras_Click);
            // 
            // chkIncluirSubcontratistas
            // 
            this.chkIncluirSubcontratistas.AutoSize = true;
            this.chkIncluirSubcontratistas.Location = new System.Drawing.Point(628, 33);
            this.chkIncluirSubcontratistas.Name = "chkIncluirSubcontratistas";
            this.chkIncluirSubcontratistas.Size = new System.Drawing.Size(143, 20);
            this.chkIncluirSubcontratistas.TabIndex = 108;
            this.chkIncluirSubcontratistas.Text = "Incluir Subcontratistas";
            this.chkIncluirSubcontratistas.UseVisualStyleBackColor = true;
            this.chkIncluirSubcontratistas.CheckedChanged += new System.EventHandler(this.chkIncluirSubcontratistas_CheckedChanged);
            // 
            // btnCerrarPeriodo
            // 
            this.btnCerrarPeriodo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCerrarPeriodo.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCerrarPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarPeriodo.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarPeriodo.Image")));
            this.btnCerrarPeriodo.Location = new System.Drawing.Point(0, 0);
            this.btnCerrarPeriodo.Name = "btnCerrarPeriodo";
            this.btnCerrarPeriodo.Size = new System.Drawing.Size(98, 47);
            this.btnCerrarPeriodo.TabIndex = 109;
            this.btnCerrarPeriodo.Text = "Cerrar Periodos";
            this.btnCerrarPeriodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarPeriodo.UseVisualStyleBackColor = true;
            this.btnCerrarPeriodo.Click += new System.EventHandler(this.btnCerrarPeriodo_Click);
            // 
            // btnFeriados
            // 
            this.btnFeriados.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFeriados.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnFeriados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeriados.Image = ((System.Drawing.Image)(resources.GetObject("btnFeriados.Image")));
            this.btnFeriados.Location = new System.Drawing.Point(98, 0);
            this.btnFeriados.Name = "btnFeriados";
            this.btnFeriados.Size = new System.Drawing.Size(97, 47);
            this.btnFeriados.TabIndex = 110;
            this.btnFeriados.Text = "Feriados";
            this.btnFeriados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeriados.UseVisualStyleBackColor = true;
            this.btnFeriados.Click += new System.EventHandler(this.btnFeriados_Click);
            // 
            // cboFiltroPolitica
            // 
            this.cboFiltroPolitica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroPolitica.FormattingEnabled = true;
            this.cboFiltroPolitica.Location = new System.Drawing.Point(445, 19);
            this.cboFiltroPolitica.Name = "cboFiltroPolitica";
            this.cboFiltroPolitica.Size = new System.Drawing.Size(177, 24);
            this.cboFiltroPolitica.TabIndex = 111;
            this.cboFiltroPolitica.SelectedIndexChanged += new System.EventHandler(this.cboFiltroPolitica_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 112;
            this.label1.Text = "Política HE:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpFin);
            this.panel1.Controls.Add(this.dtpInicio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.cboFiltroPolitica);
            this.panel1.Controls.Add(this.chkMostrarInactivos);
            this.panel1.Controls.Add(this.chkIncluirSubcontratistas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1198, 59);
            this.panel1.TabIndex = 113;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(144, 18);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(88, 21);
            this.dtpFin.TabIndex = 114;
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(12, 18);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(88, 21);
            this.dtpInicio.TabIndex = 113;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnPoliticas);
            this.panel2.Controls.Add(this.btnTiposAsistencia);
            this.panel2.Controls.Add(this.btnFeriados);
            this.panel2.Controls.Add(this.btnCerrarPeriodo);
            this.panel2.Controls.Add(this.btnHorasExtras);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1198, 47);
            this.panel2.TabIndex = 114;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(411, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 47);
            this.button1.TabIndex = 113;
            this.button1.Text = "Accion de Personal";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnPoliticas
            // 
            this.btnPoliticas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPoliticas.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnPoliticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoliticas.Image = ((System.Drawing.Image)(resources.GetObject("btnPoliticas.Image")));
            this.btnPoliticas.Location = new System.Drawing.Point(296, 0);
            this.btnPoliticas.Name = "btnPoliticas";
            this.btnPoliticas.Size = new System.Drawing.Size(115, 47);
            this.btnPoliticas.TabIndex = 112;
            this.btnPoliticas.Text = "Políticas de Pago";
            this.btnPoliticas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPoliticas.UseVisualStyleBackColor = true;
            this.btnPoliticas.Click += new System.EventHandler(this.btnPoliticas_Click);
            // 
            // btnTiposAsistencia
            // 
            this.btnTiposAsistencia.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTiposAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnTiposAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiposAsistencia.Image = ((System.Drawing.Image)(resources.GetObject("btnTiposAsistencia.Image")));
            this.btnTiposAsistencia.Location = new System.Drawing.Point(195, 0);
            this.btnTiposAsistencia.Name = "btnTiposAsistencia";
            this.btnTiposAsistencia.Size = new System.Drawing.Size(101, 47);
            this.btnTiposAsistencia.TabIndex = 111;
            this.btnTiposAsistencia.Text = "Tipos de Asistencia";
            this.btnTiposAsistencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTiposAsistencia.UseVisualStyleBackColor = true;
            this.btnTiposAsistencia.Click += new System.EventHandler(this.btnTiposAsistencia_Click);
            // 
            // frmAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1198, 574);
            this.Controls.Add(this.dgvAsistencia);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmAsistencias";
            this.Load += new System.EventHandler(this.frmAsistencias_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dgvAsistencia, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencia)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsistencia;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.CheckBox chkMostrarInactivos;
        private System.Windows.Forms.Button btnHorasExtras;
        private System.Windows.Forms.CheckBox chkIncluirSubcontratistas;
        private System.Windows.Forms.Button btnCerrarPeriodo;
        private System.Windows.Forms.Button btnFeriados;
        private System.Windows.Forms.ComboBox cboFiltroPolitica;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPoliticas;
        private System.Windows.Forms.Button btnTiposAsistencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
    }
}
