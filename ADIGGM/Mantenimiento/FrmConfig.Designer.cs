namespace ADIGGM.Mantenimiento
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.txtISV = new System.Windows.Forms.TextBox();
            this.tRConfiguracionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.cboTipoVeh = new System.Windows.Forms.ComboBox();
            this.tRTipoVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboRuta = new System.Windows.Forms.ComboBox();
            this.tRRutasFiltradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm1 = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskCtaISR = new System.Windows.Forms.MaskedTextBox();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCtaISV = new System.Windows.Forms.MaskedTextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tR_ConfiguracionTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_ConfiguracionTableAdapter();
            this.tR_TipoVehiculosTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tR_RutasFiltradasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_RutasFiltradasTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRConfiguracionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRRutasFiltradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(143, 19);
            this.lblFooter.Text = "CONFIGURACIÓN";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(350, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(310, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(390, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(250, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 227);
            this.pnlFooter.Size = new System.Drawing.Size(430, 23);
            // 
            // txtISV
            // 
            this.txtISV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRConfiguracionBindingSource, "ISV", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.txtISV.Enabled = false;
            this.txtISV.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISV.Location = new System.Drawing.Point(6, 40);
            this.txtISV.Name = "txtISV";
            this.txtISV.Size = new System.Drawing.Size(39, 21);
            this.txtISV.TabIndex = 106;
            this.txtISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtISV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtISV_KeyPress);
            // 
            // tRConfiguracionBindingSource
            // 
            this.tRConfiguracionBindingSource.DataMember = "TR_Configuracion";
            this.tRConfiguracionBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboTipoVeh
            // 
            this.cboTipoVeh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboTipoVeh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoVeh.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tRConfiguracionBindingSource, "IdRetro", true));
            this.cboTipoVeh.DataSource = this.tRTipoVehiculosBindingSource;
            this.cboTipoVeh.DisplayMember = "TipoVehiculo";
            this.cboTipoVeh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVeh.Enabled = false;
            this.cboTipoVeh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoVeh.FormattingEnabled = true;
            this.cboTipoVeh.Location = new System.Drawing.Point(6, 42);
            this.cboTipoVeh.Name = "cboTipoVeh";
            this.cboTipoVeh.Size = new System.Drawing.Size(163, 24);
            this.cboTipoVeh.TabIndex = 107;
            this.cboTipoVeh.ValueMember = "IdTipoVehiculo";
            // 
            // tRTipoVehiculosBindingSource
            // 
            this.tRTipoVehiculosBindingSource.DataMember = "TR_TipoVehiculos";
            this.tRTipoVehiculosBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboRuta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTarifa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTipoVeh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 80);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conf. de RetroExcavadoras";
            // 
            // cboRuta
            // 
            this.cboRuta.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboRuta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboRuta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tRConfiguracionBindingSource, "IdRutaRetro", true));
            this.cboRuta.DataSource = this.tRRutasFiltradasBindingSource;
            this.cboRuta.DisplayMember = "Ruta";
            this.cboRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRuta.Enabled = false;
            this.cboRuta.FormattingEnabled = true;
            this.cboRuta.Location = new System.Drawing.Point(257, 42);
            this.cboRuta.Name = "cboRuta";
            this.cboRuta.Size = new System.Drawing.Size(167, 24);
            this.cboRuta.TabIndex = 113;
            this.cboRuta.ValueMember = "IdRuta";
            // 
            // tRRutasFiltradasBindingSource
            // 
            this.tRRutasFiltradasBindingSource.DataMember = "TR_RutasFiltradas";
            this.tRRutasFiltradasBindingSource.DataSource = this.dsTransporteAdiggm1;
            // 
            // dsTransporteAdiggm1
            // 
            this.dsTransporteAdiggm1.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 112;
            this.label3.Text = "Ruta Neutral:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 111;
            this.label2.Text = "Tarifa:";
            // 
            // txtTarifa
            // 
            this.txtTarifa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRConfiguracionBindingSource, "TarifaRetro", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.txtTarifa.Enabled = false;
            this.txtTarifa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarifa.Location = new System.Drawing.Point(184, 44);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(60, 21);
            this.txtTarifa.TabIndex = 110;
            this.txtTarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTarifa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTarifa_KeyPress);
            this.txtTarifa.Leave += new System.EventHandler(this.TxtTarifa_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 109;
            this.label1.Text = "Tipo de Vehiculo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mskCtaISR);
            this.groupBox2.Controls.Add(this.txtISR);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.mskCtaISV);
            this.groupBox2.Controls.Add(this.txtISV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 112);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conf. General";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 120;
            this.label7.Text = "Cta. Contable ISR:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 119;
            this.label8.Text = "ISR %:";
            // 
            // mskCtaISR
            // 
            this.mskCtaISR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRConfiguracionBindingSource, "CtaISR", true));
            this.mskCtaISR.Enabled = false;
            this.mskCtaISR.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCtaISR.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskCtaISR.Location = new System.Drawing.Point(74, 84);
            this.mskCtaISR.Mask = "0-000-000-000-000";
            this.mskCtaISR.Name = "mskCtaISR";
            this.mskCtaISR.Size = new System.Drawing.Size(107, 21);
            this.mskCtaISR.TabIndex = 117;
            this.mskCtaISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCtaISR.ValidatingType = typeof(int);
            // 
            // txtISR
            // 
            this.txtISR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRConfiguracionBindingSource, "ISR", true));
            this.txtISR.Enabled = false;
            this.txtISR.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISR.Location = new System.Drawing.Point(6, 83);
            this.txtISR.Name = "txtISR";
            this.txtISR.Size = new System.Drawing.Size(39, 21);
            this.txtISR.TabIndex = 116;
            this.txtISR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtISR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISR_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 115;
            this.label6.Text = "Cta. Contable ISV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 114;
            this.label5.Text = "ISV %:";
            // 
            // mskCtaISV
            // 
            this.mskCtaISV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRConfiguracionBindingSource, "CtaISV", true));
            this.mskCtaISV.Enabled = false;
            this.mskCtaISV.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCtaISV.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.mskCtaISV.Location = new System.Drawing.Point(74, 41);
            this.mskCtaISV.Mask = "0-000-000-000-000";
            this.mskCtaISV.Name = "mskCtaISV";
            this.mskCtaISV.Size = new System.Drawing.Size(107, 21);
            this.mskCtaISV.TabIndex = 107;
            this.mskCtaISV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCtaISV.ValidatingType = typeof(int);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(9, 31);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(69, 57);
            this.btnEditar.TabIndex = 112;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(84, 31);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 57);
            this.btnCancelar.TabIndex = 113;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // tR_ConfiguracionTableAdapter
            // 
            this.tR_ConfiguracionTableAdapter.ClearBeforeFill = true;
            // 
            // tR_TipoVehiculosTableAdapter
            // 
            this.tR_TipoVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(159, 31);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 57);
            this.btnGuardar.TabIndex = 114;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // tR_RutasFiltradasTableAdapter
            // 
            this.tR_RutasFiltradasTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Controls.Add(this.btnGuardar);
            this.groupBox3.Controls.Add(this.btnCancelar);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(194, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 112);
            this.groupBox3.TabIndex = 115;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(430, 250);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConfig";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRConfiguracionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRTipoVehiculosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRRutasFiltradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.ComboBox cboTipoVeh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskCtaISV;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRConfiguracionBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_ConfiguracionTableAdapter tR_ConfiguracionTableAdapter;
        private System.Windows.Forms.BindingSource tRTipoVehiculosBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_TipoVehiculosTableAdapter tR_TipoVehiculosTableAdapter;
        private System.Windows.Forms.TextBox txtTarifa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboRuta;
        private System.Windows.Forms.BindingSource tRRutasFiltradasBindingSource;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm1;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_RutasFiltradasTableAdapter tR_RutasFiltradasTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskCtaISR;
        private System.Windows.Forms.TextBox txtISR;
    }
}
