namespace ADIGGM.Mantenimiento
{
    partial class FrmMotoristas
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
            this.dgvMotoristas = new System.Windows.Forms.DataGridView();
            this.tRMotoristasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.label2 = new System.Windows.Forms.Label();
            this.tR_MotoristasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_MotoristasTableAdapter();
            this.hEPoliticasPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hE_PoliticasPagoTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.HE_PoliticasPagoTableAdapter();
            this.idMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioQuincenal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoliticaID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EsEmpleado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRMotoristasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hEPoliticasPagoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.Margin = new System.Windows.Forms.Padding(48, 0, 48, 0);
            this.lblFooter.Size = new System.Drawing.Size(198, 19);
            this.lblFooter.Text = "INGRESO DE MOTORISTAS";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(796, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(756, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(836, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(696, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 407);
            this.pnlFooter.Size = new System.Drawing.Size(876, 23);
            // 
            // dgvMotoristas
            // 
            this.dgvMotoristas.AllowUserToAddRows = false;
            this.dgvMotoristas.AllowUserToDeleteRows = false;
            this.dgvMotoristas.AutoGenerateColumns = false;
            this.dgvMotoristas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMotoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotoristas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMotorista,
            this.motorista,
            this.identidad,
            this.SalarioQuincenal,
            this.PoliticaID,
            this.EsEmpleado,
            this.activo,
            this.usuario});
            this.dgvMotoristas.DataSource = this.tRMotoristasBindingSource;
            this.dgvMotoristas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMotoristas.Location = new System.Drawing.Point(0, 98);
            this.dgvMotoristas.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.dgvMotoristas.Name = "dgvMotoristas";
            this.dgvMotoristas.ReadOnly = true;
            this.dgvMotoristas.Size = new System.Drawing.Size(876, 309);
            this.dgvMotoristas.TabIndex = 2;
            this.dgvMotoristas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMotoristas_DataError);
            this.dgvMotoristas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvMotoristas_RowsAdded);
            // 
            // tRMotoristasBindingSource
            // 
            this.tRMotoristasBindingSource.DataMember = "TR_Motoristas";
            this.tRMotoristasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "MOTORISTAS";
            // 
            // tR_MotoristasTableAdapter
            // 
            this.tR_MotoristasTableAdapter.ClearBeforeFill = true;
            // 
            // hEPoliticasPagoBindingSource
            // 
            this.hEPoliticasPagoBindingSource.DataMember = "HE_PoliticasPago";
            this.hEPoliticasPagoBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // hE_PoliticasPagoTableAdapter
            // 
            this.hE_PoliticasPagoTableAdapter.ClearBeforeFill = true;
            // 
            // idMotorista
            // 
            this.idMotorista.DataPropertyName = "IdMotorista";
            this.idMotorista.HeaderText = "IdMotorista";
            this.idMotorista.Name = "idMotorista";
            this.idMotorista.ReadOnly = true;
            this.idMotorista.Visible = false;
            // 
            // motorista
            // 
            this.motorista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.motorista.DataPropertyName = "Motorista";
            this.motorista.HeaderText = "Motorista";
            this.motorista.Name = "motorista";
            this.motorista.ReadOnly = true;
            // 
            // identidad
            // 
            this.identidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.identidad.DataPropertyName = "Identidad";
            this.identidad.HeaderText = "Identidad";
            this.identidad.Name = "identidad";
            this.identidad.ReadOnly = true;
            this.identidad.Width = 87;
            // 
            // SalarioQuincenal
            // 
            this.SalarioQuincenal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SalarioQuincenal.DataPropertyName = "SalarioQuincenal";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.SalarioQuincenal.DefaultCellStyle = dataGridViewCellStyle1;
            this.SalarioQuincenal.HeaderText = "Salario Quinc.";
            this.SalarioQuincenal.Name = "SalarioQuincenal";
            this.SalarioQuincenal.ReadOnly = true;
            this.SalarioQuincenal.Width = 107;
            // 
            // PoliticaID
            // 
            this.PoliticaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PoliticaID.DataPropertyName = "PoliticaID";
            this.PoliticaID.DataSource = this.hEPoliticasPagoBindingSource;
            this.PoliticaID.DisplayMember = "NombrePolitica";
            this.PoliticaID.HeaderText = "Politica HE";
            this.PoliticaID.Name = "PoliticaID";
            this.PoliticaID.ReadOnly = true;
            this.PoliticaID.ValueMember = "PoliticaID";
            this.PoliticaID.Width = 69;
            // 
            // EsEmpleado
            // 
            this.EsEmpleado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EsEmpleado.DataPropertyName = "EsEmpleado";
            this.EsEmpleado.HeaderText = "EsEmpleado";
            this.EsEmpleado.Name = "EsEmpleado";
            this.EsEmpleado.ReadOnly = true;
            this.EsEmpleado.Width = 79;
            // 
            // activo
            // 
            this.activo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.activo.DataPropertyName = "Activo";
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Width = 48;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "Usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // FrmMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(876, 430);
            this.Controls.Add(this.dgvMotoristas);
            this.Margin = new System.Windows.Forms.Padding(48, 22, 48, 22);
            this.Name = "FrmMotoristas";
            this.Load += new System.EventHandler(this.FrmMotorista_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvMotoristas, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRMotoristasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hEPoliticasPagoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMotoristas;
        private System.Windows.Forms.Label label2;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRMotoristasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_MotoristasTableAdapter tR_MotoristasTableAdapter;
        private System.Windows.Forms.BindingSource hEPoliticasPagoBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.HE_PoliticasPagoTableAdapter hE_PoliticasPagoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMotorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn motorista;
        private System.Windows.Forms.DataGridViewTextBoxColumn identidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioQuincenal;
        private System.Windows.Forms.DataGridViewComboBoxColumn PoliticaID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EsEmpleado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    }
}
