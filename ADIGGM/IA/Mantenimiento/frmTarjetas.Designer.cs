
namespace ADIGGM.IA.Mantenimiento
{
    partial class frmTarjetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTarjetas));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtInst = new System.Windows.Forms.TextBox();
            this.txtAreaTrab = new System.Windows.Forms.TextBox();
            this.btnGenPIN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.btnFotoCapt = new System.Windows.Forms.Button();
            this.dtpFecExp = new System.Windows.Forms.DateTimePicker();
            this.dtpFecCrea = new System.Windows.Forms.DateTimePicker();
            this.lblFecCrea = new System.Windows.Forms.Label();
            this.lblFecExp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.mktPIN = new System.Windows.Forms.MaskedTextBox();
            this.lblRutaImg = new System.Windows.Forms.Label();
            this.btnFotoArch = new System.Windows.Forms.Button();
            this.cboCamara = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkReimprimir = new System.Windows.Forms.CheckBox();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(341, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(301, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(381, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(241, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 552);
            this.pnlFooter.Size = new System.Drawing.Size(421, 23);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(274, 496);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(59, 53);
            this.btnSalir.TabIndex = 116;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(174, 496);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(81, 53);
            this.btnGuardar.TabIndex = 115;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 388);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 21);
            this.txtNombre.TabIndex = 117;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtInst
            // 
            this.txtInst.Location = new System.Drawing.Point(150, 415);
            this.txtInst.Name = "txtInst";
            this.txtInst.Size = new System.Drawing.Size(261, 21);
            this.txtInst.TabIndex = 118;
            this.txtInst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInst.TextChanged += new System.EventHandler(this.txtInst_TextChanged);
            // 
            // txtAreaTrab
            // 
            this.txtAreaTrab.Location = new System.Drawing.Point(150, 442);
            this.txtAreaTrab.Name = "txtAreaTrab";
            this.txtAreaTrab.Size = new System.Drawing.Size(261, 21);
            this.txtAreaTrab.TabIndex = 119;
            this.txtAreaTrab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAreaTrab.TextChanged += new System.EventHandler(this.txtAreaTrab_TextChanged);
            // 
            // btnGenPIN
            // 
            this.btnGenPIN.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGenPIN.FlatAppearance.BorderSize = 0;
            this.btnGenPIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenPIN.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenPIN.ForeColor = System.Drawing.Color.White;
            this.btnGenPIN.Image = ((System.Drawing.Image)(resources.GetObject("btnGenPIN.Image")));
            this.btnGenPIN.Location = new System.Drawing.Point(8, 266);
            this.btnGenPIN.Name = "btnGenPIN";
            this.btnGenPIN.Size = new System.Drawing.Size(100, 69);
            this.btnGenPIN.TabIndex = 120;
            this.btnGenPIN.Text = "Generar PIN";
            this.btnGenPIN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGenPIN.UseVisualStyleBackColor = false;
            this.btnGenPIN.Click += new System.EventHandler(this.btnGenPIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 122;
            this.label1.Text = "Nombre de Asociado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 123;
            this.label2.Text = "Institución/Puesto(ADI):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 124;
            this.label3.Text = "Departamento:";
            // 
            // ptbFoto
            // 
            this.ptbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbFoto.ErrorImage = global::ADIGGM.Properties.Resources.no_image;
            this.ptbFoto.Image = global::ADIGGM.Properties.Resources.no_image;
            this.ptbFoto.InitialImage = null;
            this.ptbFoto.Location = new System.Drawing.Point(121, 37);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(290, 290);
            this.ptbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbFoto.TabIndex = 125;
            this.ptbFoto.TabStop = false;
            this.ptbFoto.DoubleClick += new System.EventHandler(this.ptbFoto_DoubleClick);
            // 
            // btnFotoCapt
            // 
            this.btnFotoCapt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFotoCapt.FlatAppearance.BorderSize = 0;
            this.btnFotoCapt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoCapt.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFotoCapt.ForeColor = System.Drawing.Color.White;
            this.btnFotoCapt.Image = ((System.Drawing.Image)(resources.GetObject("btnFotoCapt.Image")));
            this.btnFotoCapt.Location = new System.Drawing.Point(22, 39);
            this.btnFotoCapt.Name = "btnFotoCapt";
            this.btnFotoCapt.Size = new System.Drawing.Size(73, 80);
            this.btnFotoCapt.TabIndex = 126;
            this.btnFotoCapt.Text = "Abrir Cámara";
            this.btnFotoCapt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFotoCapt.UseVisualStyleBackColor = false;
            this.btnFotoCapt.Click += new System.EventHandler(this.btnFotoCapt_Click);
            // 
            // dtpFecExp
            // 
            this.dtpFecExp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecExp.Location = new System.Drawing.Point(326, 469);
            this.dtpFecExp.Name = "dtpFecExp";
            this.dtpFecExp.Size = new System.Drawing.Size(85, 21);
            this.dtpFecExp.TabIndex = 127;
            this.dtpFecExp.ValueChanged += new System.EventHandler(this.dtpFecExp_ValueChanged);
            // 
            // dtpFecCrea
            // 
            this.dtpFecCrea.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecCrea.Location = new System.Drawing.Point(150, 469);
            this.dtpFecCrea.Name = "dtpFecCrea";
            this.dtpFecCrea.Size = new System.Drawing.Size(85, 21);
            this.dtpFecCrea.TabIndex = 128;
            // 
            // lblFecCrea
            // 
            this.lblFecCrea.AutoSize = true;
            this.lblFecCrea.Location = new System.Drawing.Point(40, 472);
            this.lblFecCrea.Name = "lblFecCrea";
            this.lblFecCrea.Size = new System.Drawing.Size(103, 16);
            this.lblFecCrea.TabIndex = 129;
            this.lblFecCrea.Text = "Fec. de Creación:";
            // 
            // lblFecExp
            // 
            this.lblFecExp.AutoSize = true;
            this.lblFecExp.Location = new System.Drawing.Point(241, 472);
            this.lblFecExp.Name = "lblFecExp";
            this.lblFecExp.Size = new System.Drawing.Size(78, 16);
            this.lblFecExp.TabIndex = 130;
            this.lblFecExp.Text = "Fec. de Expir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 132;
            this.label6.Text = "Id del Asociado:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 361);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(126, 21);
            this.txtId.TabIndex = 131;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mktPIN
            // 
            this.mktPIN.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktPIN.ForeColor = System.Drawing.Color.DarkBlue;
            this.mktPIN.Location = new System.Drawing.Point(8, 236);
            this.mktPIN.Mask = "0000";
            this.mktPIN.Name = "mktPIN";
            this.mktPIN.ReadOnly = true;
            this.mktPIN.Size = new System.Drawing.Size(100, 31);
            this.mktPIN.TabIndex = 133;
            this.mktPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRutaImg
            // 
            this.lblRutaImg.AutoSize = true;
            this.lblRutaImg.Location = new System.Drawing.Point(39, 54);
            this.lblRutaImg.Name = "lblRutaImg";
            this.lblRutaImg.Size = new System.Drawing.Size(0, 16);
            this.lblRutaImg.TabIndex = 134;
            this.lblRutaImg.Visible = false;
            // 
            // btnFotoArch
            // 
            this.btnFotoArch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFotoArch.FlatAppearance.BorderSize = 0;
            this.btnFotoArch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFotoArch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFotoArch.ForeColor = System.Drawing.Color.White;
            this.btnFotoArch.Image = ((System.Drawing.Image)(resources.GetObject("btnFotoArch.Image")));
            this.btnFotoArch.Location = new System.Drawing.Point(22, 168);
            this.btnFotoArch.Name = "btnFotoArch";
            this.btnFotoArch.Size = new System.Drawing.Size(73, 73);
            this.btnFotoArch.TabIndex = 135;
            this.btnFotoArch.Text = "Subir Foto\r\n(Archivo)";
            this.btnFotoArch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFotoArch.UseVisualStyleBackColor = false;
            this.btnFotoArch.Click += new System.EventHandler(this.btnFotoArch_Click);
            // 
            // cboCamara
            // 
            this.cboCamara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCamara.FormattingEnabled = true;
            this.cboCamara.Location = new System.Drawing.Point(150, 332);
            this.cboCamara.Name = "cboCamara";
            this.cboCamara.Size = new System.Drawing.Size(261, 24);
            this.cboCamara.TabIndex = 136;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(180, 496);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 53);
            this.btnCancelar.TabIndex = 137;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkReimprimir
            // 
            this.chkReimprimir.AutoSize = true;
            this.chkReimprimir.Location = new System.Drawing.Point(282, 363);
            this.chkReimprimir.Name = "chkReimprimir";
            this.chkReimprimir.Size = new System.Drawing.Size(80, 20);
            this.chkReimprimir.TabIndex = 138;
            this.chkReimprimir.Text = "Reimprimir";
            this.chkReimprimir.UseVisualStyleBackColor = true;
            this.chkReimprimir.Visible = false;
            // 
            // btnExpandir
            // 
            this.btnExpandir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnExpandir.FlatAppearance.BorderSize = 0;
            this.btnExpandir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandir.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandir.ForeColor = System.Drawing.Color.White;
            this.btnExpandir.Image = ((System.Drawing.Image)(resources.GetObject("btnExpandir.Image")));
            this.btnExpandir.Location = new System.Drawing.Point(22, 115);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(73, 66);
            this.btnExpandir.TabIndex = 139;
            this.btnExpandir.Text = "Expandir";
            this.btnExpandir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpandir.UseVisualStyleBackColor = false;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // frmTarjetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(421, 575);
            this.Controls.Add(this.mktPIN);
            this.Controls.Add(this.btnGenPIN);
            this.Controls.Add(this.btnFotoArch);
            this.Controls.Add(this.btnExpandir);
            this.Controls.Add(this.chkReimprimir);
            this.Controls.Add(this.cboCamara);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblFecExp);
            this.Controls.Add(this.lblFecCrea);
            this.Controls.Add(this.dtpFecCrea);
            this.Controls.Add(this.dtpFecExp);
            this.Controls.Add(this.btnFotoCapt);
            this.Controls.Add(this.ptbFoto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAreaTrab);
            this.Controls.Add(this.txtInst);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblRutaImg);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmTarjetas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTarjetas_FormClosed);
            this.Load += new System.EventHandler(this.frmTarjetas_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblRutaImg, 0);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtInst, 0);
            this.Controls.SetChildIndex(this.txtAreaTrab, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ptbFoto, 0);
            this.Controls.SetChildIndex(this.btnFotoCapt, 0);
            this.Controls.SetChildIndex(this.dtpFecExp, 0);
            this.Controls.SetChildIndex(this.dtpFecCrea, 0);
            this.Controls.SetChildIndex(this.lblFecCrea, 0);
            this.Controls.SetChildIndex(this.lblFecExp, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.cboCamara, 0);
            this.Controls.SetChildIndex(this.chkReimprimir, 0);
            this.Controls.SetChildIndex(this.btnExpandir, 0);
            this.Controls.SetChildIndex(this.btnFotoArch, 0);
            this.Controls.SetChildIndex(this.btnGenPIN, 0);
            this.Controls.SetChildIndex(this.mktPIN, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtInst;
        private System.Windows.Forms.TextBox txtAreaTrab;
        private System.Windows.Forms.Button btnGenPIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbFoto;
        private System.Windows.Forms.Button btnFotoCapt;
        private System.Windows.Forms.DateTimePicker dtpFecExp;
        private System.Windows.Forms.DateTimePicker dtpFecCrea;
        private System.Windows.Forms.Label lblFecCrea;
        private System.Windows.Forms.Label lblFecExp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.MaskedTextBox mktPIN;
        private System.Windows.Forms.Label lblRutaImg;
        private System.Windows.Forms.Button btnFotoArch;
        private System.Windows.Forms.ComboBox cboCamara;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkReimprimir;
        private System.Windows.Forms.Button btnExpandir;
    }
}
