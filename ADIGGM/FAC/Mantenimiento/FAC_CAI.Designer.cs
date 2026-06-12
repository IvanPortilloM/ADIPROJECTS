namespace ADIGGM.FAC.Mantenimiento
{
    partial class FAC_CAI
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
            this.dgvCAI = new System.Windows.Forms.DataGridView();
            this.idCaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fragmentoSARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDesdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDesdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroHastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.anuladoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fACCAIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACCAIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(733, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(693, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(773, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(633, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 390);
            this.pnlFooter.Size = new System.Drawing.Size(813, 23);
            // 
            // dgvCAI
            // 
            this.dgvCAI.AllowUserToAddRows = false;
            this.dgvCAI.AllowUserToDeleteRows = false;
            this.dgvCAI.AutoGenerateColumns = false;
            this.dgvCAI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCAI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCAI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCaiDataGridViewTextBoxColumn,
            this.caiDataGridViewTextBoxColumn,
            this.fragmentoSARDataGridViewTextBoxColumn,
            this.fechaDesdeDataGridViewTextBoxColumn,
            this.fechaHastaDataGridViewTextBoxColumn,
            this.numeroDesdeDataGridViewTextBoxColumn,
            this.numeroHastaDataGridViewTextBoxColumn,
            this.activoDataGridViewCheckBoxColumn,
            this.anuladoDataGridViewCheckBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.nombreEquipoDataGridViewTextBoxColumn,
            this.idSucursalDataGridViewTextBoxColumn});
            this.dgvCAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCAI.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCAI.Location = new System.Drawing.Point(0, 98);
            this.dgvCAI.Name = "dgvCAI";
            this.dgvCAI.ReadOnly = true;
            this.dgvCAI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCAI.Size = new System.Drawing.Size(813, 292);
            this.dgvCAI.TabIndex = 108;
            // 
            // idCaiDataGridViewTextBoxColumn
            // 
            this.idCaiDataGridViewTextBoxColumn.DataPropertyName = "IdCai";
            this.idCaiDataGridViewTextBoxColumn.HeaderText = "IdCai";
            this.idCaiDataGridViewTextBoxColumn.Name = "idCaiDataGridViewTextBoxColumn";
            this.idCaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCaiDataGridViewTextBoxColumn.Visible = false;
            // 
            // caiDataGridViewTextBoxColumn
            // 
            this.caiDataGridViewTextBoxColumn.DataPropertyName = "Cai";
            this.caiDataGridViewTextBoxColumn.FillWeight = 113.8018F;
            this.caiDataGridViewTextBoxColumn.HeaderText = "Cai";
            this.caiDataGridViewTextBoxColumn.Name = "caiDataGridViewTextBoxColumn";
            this.caiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fragmentoSARDataGridViewTextBoxColumn
            // 
            this.fragmentoSARDataGridViewTextBoxColumn.DataPropertyName = "FragmentoSAR";
            this.fragmentoSARDataGridViewTextBoxColumn.FillWeight = 113.8018F;
            this.fragmentoSARDataGridViewTextBoxColumn.HeaderText = "FragmentoSAR";
            this.fragmentoSARDataGridViewTextBoxColumn.Name = "fragmentoSARDataGridViewTextBoxColumn";
            this.fragmentoSARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDesdeDataGridViewTextBoxColumn
            // 
            this.fechaDesdeDataGridViewTextBoxColumn.DataPropertyName = "FechaDesde";
            this.fechaDesdeDataGridViewTextBoxColumn.FillWeight = 113.8018F;
            this.fechaDesdeDataGridViewTextBoxColumn.HeaderText = "FechaDesde";
            this.fechaDesdeDataGridViewTextBoxColumn.Name = "fechaDesdeDataGridViewTextBoxColumn";
            this.fechaDesdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaHastaDataGridViewTextBoxColumn
            // 
            this.fechaHastaDataGridViewTextBoxColumn.DataPropertyName = "FechaHasta";
            this.fechaHastaDataGridViewTextBoxColumn.FillWeight = 113.8018F;
            this.fechaHastaDataGridViewTextBoxColumn.HeaderText = "FechaHasta";
            this.fechaHastaDataGridViewTextBoxColumn.Name = "fechaHastaDataGridViewTextBoxColumn";
            this.fechaHastaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDesdeDataGridViewTextBoxColumn
            // 
            this.numeroDesdeDataGridViewTextBoxColumn.DataPropertyName = "NumeroDesde";
            this.numeroDesdeDataGridViewTextBoxColumn.FillWeight = 113.8018F;
            this.numeroDesdeDataGridViewTextBoxColumn.HeaderText = "NumeroDesde";
            this.numeroDesdeDataGridViewTextBoxColumn.Name = "numeroDesdeDataGridViewTextBoxColumn";
            this.numeroDesdeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroHastaDataGridViewTextBoxColumn
            // 
            this.numeroHastaDataGridViewTextBoxColumn.DataPropertyName = "NumeroHasta";
            this.numeroHastaDataGridViewTextBoxColumn.FillWeight = 113.8018F;
            this.numeroHastaDataGridViewTextBoxColumn.HeaderText = "NumeroHasta";
            this.numeroHastaDataGridViewTextBoxColumn.Name = "numeroHastaDataGridViewTextBoxColumn";
            this.numeroHastaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activoDataGridViewCheckBoxColumn
            // 
            this.activoDataGridViewCheckBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewCheckBoxColumn.FillWeight = 56.2756F;
            this.activoDataGridViewCheckBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewCheckBoxColumn.Name = "activoDataGridViewCheckBoxColumn";
            this.activoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // anuladoDataGridViewCheckBoxColumn
            // 
            this.anuladoDataGridViewCheckBoxColumn.DataPropertyName = "Anulado";
            this.anuladoDataGridViewCheckBoxColumn.FillWeight = 60.9137F;
            this.anuladoDataGridViewCheckBoxColumn.HeaderText = "Anulado";
            this.anuladoDataGridViewCheckBoxColumn.Name = "anuladoDataGridViewCheckBoxColumn";
            this.anuladoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.anuladoDataGridViewCheckBoxColumn.Visible = false;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreEquipoDataGridViewTextBoxColumn
            // 
            this.nombreEquipoDataGridViewTextBoxColumn.DataPropertyName = "NombreEquipo";
            this.nombreEquipoDataGridViewTextBoxColumn.HeaderText = "NombreEquipo";
            this.nombreEquipoDataGridViewTextBoxColumn.Name = "nombreEquipoDataGridViewTextBoxColumn";
            this.nombreEquipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreEquipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSucursalDataGridViewTextBoxColumn
            // 
            this.idSucursalDataGridViewTextBoxColumn.DataPropertyName = "IdSucursal";
            this.idSucursalDataGridViewTextBoxColumn.HeaderText = "IdSucursal";
            this.idSucursalDataGridViewTextBoxColumn.Name = "idSucursalDataGridViewTextBoxColumn";
            this.idSucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSucursalDataGridViewTextBoxColumn.Visible = false;
            //
            // FAC_CAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(813, 413);
            this.Controls.Add(this.dgvCAI);
            this.Name = "FAC_CAI";
            this.Load += new System.EventHandler(this.FAC_CAI_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dgvCAI, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACCAIBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCAI;
        private System.Windows.Forms.BindingSource fACCAIBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fragmentoSARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDesdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHastaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDesdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroHastaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anuladoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursalDataGridViewTextBoxColumn;
    }
}
