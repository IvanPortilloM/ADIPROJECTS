namespace ADIGGM.HE
{
    partial class frmEditarAsistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarAsistencia));
            this.lblInfo = new System.Windows.Forms.Label();
            this.cboTipoAsistencia = new System.Windows.Forms.ComboBox();
            this.pnlTiempos = new System.Windows.Forms.Panel();
            this.dgvTiempos = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkAplicarRango = new System.Windows.Forms.CheckBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            this.pnlTiempos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(353, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(313, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(393, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(253, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 486);
            this.pnlFooter.Size = new System.Drawing.Size(433, 23);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(12, 72);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(39, 16);
            this.lblInfo.TabIndex = 103;
            this.lblInfo.Text = "lblInfo";
            // 
            // cboTipoAsistencia
            // 
            this.cboTipoAsistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAsistencia.FormattingEnabled = true;
            this.cboTipoAsistencia.Location = new System.Drawing.Point(7, 45);
            this.cboTipoAsistencia.Name = "cboTipoAsistencia";
            this.cboTipoAsistencia.Size = new System.Drawing.Size(173, 24);
            this.cboTipoAsistencia.TabIndex = 104;
            this.cboTipoAsistencia.SelectedIndexChanged += new System.EventHandler(this.cboTipoAsistencia_SelectedIndexChanged);
            // 
            // pnlTiempos
            // 
            this.pnlTiempos.Controls.Add(this.dgvTiempos);
            this.pnlTiempos.Location = new System.Drawing.Point(53, 237);
            this.pnlTiempos.Name = "pnlTiempos";
            this.pnlTiempos.Size = new System.Drawing.Size(325, 172);
            this.pnlTiempos.TabIndex = 105;
            // 
            // dgvTiempos
            // 
            this.dgvTiempos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiempos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiempos.Location = new System.Drawing.Point(20, 17);
            this.dgvTiempos.Name = "dgvTiempos";
            this.dgvTiempos.Size = new System.Drawing.Size(282, 140);
            this.dgvTiempos.TabIndex = 0;
            //
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(251, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 60);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(96, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 60);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkAplicarRango
            // 
            this.chkAplicarRango.AutoSize = true;
            this.chkAplicarRango.Location = new System.Drawing.Point(7, 123);
            this.chkAplicarRango.Name = "chkAplicarRango";
            this.chkAplicarRango.Size = new System.Drawing.Size(183, 20);
            this.chkAplicarRango.TabIndex = 106;
            this.chkAplicarRango.Text = "Aplicar a un rango de fechas";
            this.chkAplicarRango.UseVisualStyleBackColor = true;
            this.chkAplicarRango.CheckedChanged += new System.EventHandler(this.chkAplicarRango_CheckedChanged);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(196, 120);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(101, 21);
            this.dtpHasta.TabIndex = 107;
            this.dtpHasta.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 108;
            this.label1.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(53, 170);
            this.txtObservaciones.MaxLength = 500;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(330, 50);
            this.txtObservaciones.TabIndex = 109;
            // 
            // btnCopiar
            // 
            this.btnCopiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCopiar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiar.Image = ((System.Drawing.Image)(resources.GetObject("btnCopiar.Image")));
            this.btnCopiar.Location = new System.Drawing.Point(346, 41);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(75, 60);
            this.btnCopiar.TabIndex = 111;
            this.btnCopiar.Text = "Copiar a...";
            this.btnCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // frmEditarAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(433, 509);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.chkAplicarRango);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pnlTiempos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cboTipoAsistencia);
            this.Controls.Add(this.lblInfo);
            this.Name = "frmEditarAsistencia";
            this.Load += new System.EventHandler(this.frmEditarAsistencia_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.lblInfo, 0);
            this.Controls.SetChildIndex(this.cboTipoAsistencia, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.pnlTiempos, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.chkAplicarRango, 0);
            this.Controls.SetChildIndex(this.dtpHasta, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtObservaciones, 0);
            this.Controls.SetChildIndex(this.btnCopiar, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlTiempos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiempos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ComboBox cboTipoAsistencia;
        private System.Windows.Forms.Panel pnlTiempos;
        private System.Windows.Forms.DataGridView dgvTiempos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkAplicarRango;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnCopiar;
    }
}
