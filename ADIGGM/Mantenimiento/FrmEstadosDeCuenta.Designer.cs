namespace ADIGGM.Mantenimiento
{
    partial class FrmEstadosDeCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadosDeCuenta));
            this.cODSlcASMaestrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cODSlcEstadoCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvListaCorreos = new System.Windows.Forms.DataGridView();
            this.fKCODListaCorreosCODDivisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cODDivisionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cODListaCorreosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnStartAsyncOperation = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chkMarcar = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcASMaestrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcEstadoCuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCorreos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCODListaCorreosCODDivisionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODDivisionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODListaCorreosBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.Location = new System.Drawing.Point(455, 3);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.Location = new System.Drawing.Point(368, 3);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.Location = new System.Drawing.Point(281, 3);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.Location = new System.Drawing.Point(194, 3);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.Location = new System.Drawing.Point(107, 3);
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(221, 19);
            this.lblFooter.Text = "Envío de Estados de Cuenta";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(554, 0);
            this.btnMax.Visible = false;
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(514, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(594, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(434, 0);
            this.pgbProcesos.Size = new System.Drawing.Size(200, 23);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 535);
            this.pnlFooter.Size = new System.Drawing.Size(634, 23);
            // 
            // cODSlcASMaestrasBindingSource
            // 
            this.cODSlcASMaestrasBindingSource.DataMember = "COD_SlcASMaestras";
            // 
            // cODSlcEstadoCuentaBindingSource
            // 
            this.cODSlcEstadoCuentaBindingSource.DataMember = "COD_SlcEstadoCuenta";
            // 
            // dgvListaCorreos
            // 
            this.dgvListaCorreos.AllowUserToAddRows = false;
            this.dgvListaCorreos.AllowUserToDeleteRows = false;
            this.dgvListaCorreos.AutoGenerateColumns = false;
            this.dgvListaCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCorreos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaCorreos.Location = new System.Drawing.Point(0, 147);
            this.dgvListaCorreos.Name = "dgvListaCorreos";
            this.dgvListaCorreos.Size = new System.Drawing.Size(634, 388);
            this.dgvListaCorreos.TabIndex = 104;
            // 
            // fKCODListaCorreosCODDivisionesBindingSource
            // 
            // (DataMember/DataSource de la relación y del combo se asignan en código en CargarDatos:
            //  el DataSet con la relación FK_COD_ListaCorreos_COD_Divisiones no existe en InitializeComponent)
            // 
            // cODListaCorreosBindingSource
            // 
            this.cODListaCorreosBindingSource.DataMember = "COD_ListaCorreos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.btnImprimir);
            this.panel3.Controls.Add(this.btnStartAsyncOperation);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.chkMarcar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 49);
            this.panel3.TabIndex = 113;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(279, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(97, 49);
            this.btnImprimir.TabIndex = 112;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnStartAsyncOperation
            // 
            this.btnStartAsyncOperation.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnStartAsyncOperation.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnStartAsyncOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartAsyncOperation.Image = ((System.Drawing.Image)(resources.GetObject("btnStartAsyncOperation.Image")));
            this.btnStartAsyncOperation.Location = new System.Drawing.Point(376, 0);
            this.btnStartAsyncOperation.Name = "btnStartAsyncOperation";
            this.btnStartAsyncOperation.Size = new System.Drawing.Size(97, 49);
            this.btnStartAsyncOperation.TabIndex = 111;
            this.btnStartAsyncOperation.Text = "Enviar Correos";
            this.btnStartAsyncOperation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStartAsyncOperation.UseVisualStyleBackColor = true;
            this.btnStartAsyncOperation.Click += new System.EventHandler(this.btnStartAsyncOperation_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(473, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 49);
            this.btnCancel.TabIndex = 110;
            this.btnCancel.Text = "Cancelar Envío";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 107;
            this.label2.Text = "Seleccionar:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.cODDivisionesBindingSource;
            this.comboBox1.DisplayMember = "NombreDiv";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 24);
            this.comboBox1.TabIndex = 106;
            this.comboBox1.ValueMember = "IdDivision";
            // 
            // chkMarcar
            // 
            this.chkMarcar.AutoSize = true;
            this.chkMarcar.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkMarcar.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkMarcar.Location = new System.Drawing.Point(583, 0);
            this.chkMarcar.Name = "chkMarcar";
            this.chkMarcar.Size = new System.Drawing.Size(51, 49);
            this.chkMarcar.TabIndex = 108;
            this.chkMarcar.Text = "Marcar";
            this.chkMarcar.UseVisualStyleBackColor = true;
            this.chkMarcar.CheckedChanged += new System.EventHandler(this.chkMarcar_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FrmEstadosDeCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(634, 558);
            this.Controls.Add(this.dgvListaCorreos);
            this.Controls.Add(this.panel3);
            this.Name = "FrmEstadosDeCuenta";
            this.Load += new System.EventHandler(this.FrmEstadosDeCuenta_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.dgvListaCorreos, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcASMaestrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODSlcEstadoCuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCorreos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCODListaCorreosCODDivisionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODDivisionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cODListaCorreosBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cODSlcASMaestrasBindingSource;
        private System.Windows.Forms.BindingSource cODSlcEstadoCuentaBindingSource;
        private System.Windows.Forms.DataGridView dgvListaCorreos;
        private System.Windows.Forms.BindingSource cODListaCorreosBindingSource;
        private System.Windows.Forms.BindingSource cODDivisionesBindingSource;
        private System.Windows.Forms.BindingSource fKCODListaCorreosCODDivisionesBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnStartAsyncOperation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox chkMarcar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnImprimir;
    }
}
