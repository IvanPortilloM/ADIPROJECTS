
namespace ADIGGM.OC.Visores
{
    partial class VisCambioAceite
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisCambioAceite));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvCambioAceite = new System.Windows.Forms.DataGridView();
            this.idCambioAceiteDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativoOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odometroInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odometroActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odometroProxCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomenclatura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.anuladoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oCCambioAceiteVisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.dgvCambioAceiteDet = new System.Windows.Forms.DataGridView();
            this.idCambioAceiteDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCambioAceite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativoOCDet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odometro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anulado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.oCCambioAceiteVisorOCCambioAceiteDetVisorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.oC_CambioAceiteVisorTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_CambioAceiteVisorTableAdapter();
            this.oC_CambioAceiteDetVisorTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_CambioAceiteDetVisorTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambioAceite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCCambioAceiteVisorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambioAceiteDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCCambioAceiteVisorOCCambioAceiteDetVisorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(167, 19);
            this.lblFooter.Text = "Visor Cambio Aceite";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(766, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(726, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(806, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(666, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 482);
            this.pnlFooter.Size = new System.Drawing.Size(846, 23);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 109);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvCambioAceite);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvCambioAceiteDet);
            this.splitContainer1.Size = new System.Drawing.Size(846, 373);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 105;
            // 
            // dgvCambioAceite
            // 
            this.dgvCambioAceite.AllowUserToAddRows = false;
            this.dgvCambioAceite.AllowUserToDeleteRows = false;
            this.dgvCambioAceite.AutoGenerateColumns = false;
            this.dgvCambioAceite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCambioAceite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCambioAceiteDGV,
            this.idOCDataGridViewTextBoxColumn,
            this.correlativoOC,
            this.codVehiculo,
            this.fechaInicio,
            this.fechaFin,
            this.odometroInicial,
            this.odometroActual,
            this.odometroProxCambio,
            this.Diferencia,
            this.nomenclatura,
            this.completado,
            this.anuladoDataGridViewCheckBoxColumn,
            this.usuario});
            this.dgvCambioAceite.DataSource = this.oCCambioAceiteVisorBindingSource;
            this.dgvCambioAceite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCambioAceite.Location = new System.Drawing.Point(0, 0);
            this.dgvCambioAceite.Name = "dgvCambioAceite";
            this.dgvCambioAceite.ReadOnly = true;
            this.dgvCambioAceite.Size = new System.Drawing.Size(846, 182);
            this.dgvCambioAceite.TabIndex = 0;
            this.dgvCambioAceite.SelectionChanged += new System.EventHandler(this.dgvCambioAceite_SelectionChanged);
            // 
            // idCambioAceiteDGV
            // 
            this.idCambioAceiteDGV.DataPropertyName = "IdCambioAceite";
            this.idCambioAceiteDGV.HeaderText = "IdCambioAceite";
            this.idCambioAceiteDGV.Name = "idCambioAceiteDGV";
            this.idCambioAceiteDGV.ReadOnly = true;
            this.idCambioAceiteDGV.Visible = false;
            // 
            // idOCDataGridViewTextBoxColumn
            // 
            this.idOCDataGridViewTextBoxColumn.DataPropertyName = "IdOC";
            this.idOCDataGridViewTextBoxColumn.HeaderText = "IdOC";
            this.idOCDataGridViewTextBoxColumn.Name = "idOCDataGridViewTextBoxColumn";
            this.idOCDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOCDataGridViewTextBoxColumn.Visible = false;
            // 
            // correlativoOC
            // 
            this.correlativoOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correlativoOC.DataPropertyName = "Correlativo";
            this.correlativoOC.HeaderText = "Correlativo";
            this.correlativoOC.Name = "correlativoOC";
            this.correlativoOC.ReadOnly = true;
            // 
            // codVehiculo
            // 
            this.codVehiculo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.codVehiculo.DataPropertyName = "CodVehiculo";
            this.codVehiculo.HeaderText = "Vehículo";
            this.codVehiculo.Name = "codVehiculo";
            this.codVehiculo.ReadOnly = true;
            this.codVehiculo.Width = 78;
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaInicio.DataPropertyName = "FechaInicio";
            this.fechaInicio.HeaderText = "F. Inicio";
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.ReadOnly = true;
            this.fechaInicio.Width = 71;
            // 
            // fechaFin
            // 
            this.fechaFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fechaFin.DataPropertyName = "FechaFin";
            this.fechaFin.HeaderText = "F. Final";
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.ReadOnly = true;
            this.fechaFin.Width = 67;
            // 
            // odometroInicial
            // 
            this.odometroInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.odometroInicial.DataPropertyName = "OdometroInicial";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.odometroInicial.DefaultCellStyle = dataGridViewCellStyle1;
            this.odometroInicial.HeaderText = "Odo. Inicial";
            this.odometroInicial.Name = "odometroInicial";
            this.odometroInicial.ReadOnly = true;
            this.odometroInicial.Width = 94;
            // 
            // odometroActual
            // 
            this.odometroActual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.odometroActual.DataPropertyName = "OdometroActual";
            dataGridViewCellStyle2.Format = "N2";
            this.odometroActual.DefaultCellStyle = dataGridViewCellStyle2;
            this.odometroActual.HeaderText = "Odo. Actual";
            this.odometroActual.Name = "odometroActual";
            this.odometroActual.ReadOnly = true;
            this.odometroActual.Width = 98;
            // 
            // odometroProxCambio
            // 
            this.odometroProxCambio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.odometroProxCambio.DataPropertyName = "OdometroProxCambio";
            dataGridViewCellStyle3.Format = "N2";
            this.odometroProxCambio.DefaultCellStyle = dataGridViewCellStyle3;
            this.odometroProxCambio.HeaderText = "Prox. Cambio";
            this.odometroProxCambio.Name = "odometroProxCambio";
            this.odometroProxCambio.ReadOnly = true;
            this.odometroProxCambio.Width = 105;
            // 
            // Diferencia
            // 
            this.Diferencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Diferencia.DataPropertyName = "Diferencia";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Diferencia.DefaultCellStyle = dataGridViewCellStyle4;
            this.Diferencia.HeaderText = "Dif.";
            this.Diferencia.Name = "Diferencia";
            this.Diferencia.ReadOnly = true;
            this.Diferencia.Width = 48;
            // 
            // nomenclatura
            // 
            this.nomenclatura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nomenclatura.DataPropertyName = "Nomenclatura";
            this.nomenclatura.HeaderText = "U.M.";
            this.nomenclatura.Name = "nomenclatura";
            this.nomenclatura.ReadOnly = true;
            this.nomenclatura.Width = 57;
            // 
            // completado
            // 
            this.completado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.completado.DataPropertyName = "Completado";
            this.completado.HeaderText = "Compt.";
            this.completado.Name = "completado";
            this.completado.ReadOnly = true;
            this.completado.Width = 54;
            // 
            // anuladoDataGridViewCheckBoxColumn
            // 
            this.anuladoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.anuladoDataGridViewCheckBoxColumn.DataPropertyName = "Anulado";
            this.anuladoDataGridViewCheckBoxColumn.HeaderText = "Nulo";
            this.anuladoDataGridViewCheckBoxColumn.Name = "anuladoDataGridViewCheckBoxColumn";
            this.anuladoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.anuladoDataGridViewCheckBoxColumn.Width = 37;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "Usuario";
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Visible = false;
            // 
            // oCCambioAceiteVisorBindingSource
            // 
            this.oCCambioAceiteVisorBindingSource.DataMember = "OC_CambioAceiteVisor";
            this.oCCambioAceiteVisorBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvCambioAceiteDet
            // 
            this.dgvCambioAceiteDet.AllowUserToAddRows = false;
            this.dgvCambioAceiteDet.AllowUserToDeleteRows = false;
            this.dgvCambioAceiteDet.AutoGenerateColumns = false;
            this.dgvCambioAceiteDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCambioAceiteDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCambioAceiteDet,
            this.idCambioAceite,
            this.idOC,
            this.correlativoOCDet,
            this.fechaData,
            this.odometro,
            this.anulado});
            this.dgvCambioAceiteDet.DataSource = this.oCCambioAceiteVisorOCCambioAceiteDetVisorBindingSource;
            this.dgvCambioAceiteDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCambioAceiteDet.Location = new System.Drawing.Point(0, 0);
            this.dgvCambioAceiteDet.Name = "dgvCambioAceiteDet";
            this.dgvCambioAceiteDet.ReadOnly = true;
            this.dgvCambioAceiteDet.Size = new System.Drawing.Size(846, 187);
            this.dgvCambioAceiteDet.TabIndex = 0;
            // 
            // idCambioAceiteDet
            // 
            this.idCambioAceiteDet.DataPropertyName = "IdCambioAceiteDet";
            this.idCambioAceiteDet.HeaderText = "IdCambioAceiteDet";
            this.idCambioAceiteDet.Name = "idCambioAceiteDet";
            this.idCambioAceiteDet.ReadOnly = true;
            this.idCambioAceiteDet.Visible = false;
            // 
            // idCambioAceite
            // 
            this.idCambioAceite.DataPropertyName = "IdCambioAceite";
            this.idCambioAceite.HeaderText = "IdCambioAceite";
            this.idCambioAceite.Name = "idCambioAceite";
            this.idCambioAceite.ReadOnly = true;
            this.idCambioAceite.Visible = false;
            // 
            // idOC
            // 
            this.idOC.DataPropertyName = "IdOC";
            this.idOC.HeaderText = "IdOC";
            this.idOC.Name = "idOC";
            this.idOC.ReadOnly = true;
            this.idOC.Visible = false;
            // 
            // correlativoOCDet
            // 
            this.correlativoOCDet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.correlativoOCDet.DataPropertyName = "Correlativo";
            this.correlativoOCDet.HeaderText = "Correlativo";
            this.correlativoOCDet.Name = "correlativoOCDet";
            this.correlativoOCDet.ReadOnly = true;
            // 
            // fechaData
            // 
            this.fechaData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fechaData.DataPropertyName = "Fecha";
            this.fechaData.HeaderText = "Fecha";
            this.fechaData.Name = "fechaData";
            this.fechaData.ReadOnly = true;
            // 
            // odometro
            // 
            this.odometro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.odometro.DataPropertyName = "Odometro";
            dataGridViewCellStyle5.Format = "N2";
            this.odometro.DefaultCellStyle = dataGridViewCellStyle5;
            this.odometro.HeaderText = "Odometro";
            this.odometro.Name = "odometro";
            this.odometro.ReadOnly = true;
            // 
            // anulado
            // 
            this.anulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.anulado.DataPropertyName = "Anulado";
            this.anulado.HeaderText = "Anulado";
            this.anulado.Name = "anulado";
            this.anulado.ReadOnly = true;
            this.anulado.Width = 59;
            // 
            // oCCambioAceiteVisorOCCambioAceiteDetVisorBindingSource
            // 
            this.oCCambioAceiteVisorOCCambioAceiteDetVisorBindingSource.DataMember = "OC_CambioAceiteVisor_OC_CambioAceiteDetVisor";
            this.oCCambioAceiteVisorOCCambioAceiteDetVisorBindingSource.DataSource = this.oCCambioAceiteVisorBindingSource;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnVisualizar);
            this.panel1.Controls.Add(this.dtpHasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDesde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 74);
            this.panel1.TabIndex = 106;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(592, 13);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(54, 49);
            this.btnVisualizar.TabIndex = 125;
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(320, 28);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(195, 21);
            this.dtpHasta.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 124;
            this.label2.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(73, 27);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(171, 21);
            this.dtpDesde.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 122;
            this.label1.Text = "Desde:";
            // 
            // oC_CambioAceiteVisorTableAdapter
            // 
            this.oC_CambioAceiteVisorTableAdapter.ClearBeforeFill = true;
            // 
            // oC_CambioAceiteDetVisorTableAdapter
            // 
            this.oC_CambioAceiteDetVisorTableAdapter.ClearBeforeFill = true;
            // 
            // VisCambioAceite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(846, 505);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "VisCambioAceite";
            this.Text = "Visor Cambio Aceite";
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambioAceite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCCambioAceiteVisorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCambioAceiteDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCCambioAceiteVisorOCCambioAceiteDetVisorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvCambioAceite;
        private System.Windows.Forms.DataGridView dgvCambioAceiteDet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource oCCambioAceiteVisorBindingSource;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.BindingSource oCCambioAceiteVisorOCCambioAceiteDetVisorBindingSource;
        private DataSets.DsOCTableAdapters.OC_CambioAceiteVisorTableAdapter oC_CambioAceiteVisorTableAdapter;
        private DataSets.DsOCTableAdapters.OC_CambioAceiteDetVisorTableAdapter oC_CambioAceiteDetVisorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCambioAceiteDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCambioAceite;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlativoOCDet;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn odometro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCambioAceiteDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlativoOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn codVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn odometroInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn odometroActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn odometroProxCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomenclatura;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anuladoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    }
}
