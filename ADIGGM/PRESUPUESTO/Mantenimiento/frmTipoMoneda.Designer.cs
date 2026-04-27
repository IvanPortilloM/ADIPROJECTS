
namespace ADIGGM.PRESUPUESTO.Mantenimiento
{
    partial class frmTipoMoneda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoMoneda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAños = new System.Windows.Forms.ComboBox();
            this.pRAniosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvTipoMoneda = new System.Windows.Forms.DataGridView();
            this.idTipoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoMoneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKPRtipoMonedaPRAniosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR_AniosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_AniosTableAdapter();
            this.pR_tipoMonedaTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_tipoMonedaTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAniosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMoneda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRtipoMonedaPRAniosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboAños);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 52;
            this.label2.Text = "Año:";
            // 
            // cboAños
            // 
            this.cboAños.DataSource = this.pRAniosBindingSource;
            this.cboAños.DisplayMember = "Anio";
            this.cboAños.FormattingEnabled = true;
            this.cboAños.Location = new System.Drawing.Point(189, 115);
            this.cboAños.Name = "cboAños";
            this.cboAños.Size = new System.Drawing.Size(169, 24);
            this.cboAños.TabIndex = 12;
            this.cboAños.ValueMember = "idAnio";
            // 
            // pRAniosBindingSource
            // 
            this.pRAniosBindingSource.DataMember = "PR_Anios";
            this.pRAniosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // dsPresupuesto
            // 
            this.dsPresupuesto.DataSetName = "DsPresupuesto";
            this.dsPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(209, 22);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 71);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(108, 22);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 71);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(411, 22);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(86, 71);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(310, 22);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 71);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Transparent;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(7, 22);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(86, 71);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvTipoMoneda
            // 
            this.dgvTipoMoneda.AllowUserToAddRows = false;
            this.dgvTipoMoneda.AllowUserToDeleteRows = false;
            this.dgvTipoMoneda.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTipoMoneda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipoMoneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoMoneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTipoMoneda,
            this.tipoMoneda,
            this.simbolo,
            this.tasa,
            this.idAnio});
            this.dgvTipoMoneda.DataSource = this.fKPRtipoMonedaPRAniosBindingSource;
            this.dgvTipoMoneda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTipoMoneda.Location = new System.Drawing.Point(0, 155);
            this.dgvTipoMoneda.Name = "dgvTipoMoneda";
            this.dgvTipoMoneda.ReadOnly = true;
            this.dgvTipoMoneda.RowHeadersVisible = false;
            this.dgvTipoMoneda.RowHeadersWidth = 51;
            this.dgvTipoMoneda.RowTemplate.Height = 24;
            this.dgvTipoMoneda.Size = new System.Drawing.Size(502, 177);
            this.dgvTipoMoneda.TabIndex = 3;
            this.dgvTipoMoneda.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTipoMoneda_DataError);
            // 
            // idTipoMoneda
            // 
            this.idTipoMoneda.DataPropertyName = "idTipoMoneda";
            this.idTipoMoneda.HeaderText = "idTipoMoneda";
            this.idTipoMoneda.MinimumWidth = 6;
            this.idTipoMoneda.Name = "idTipoMoneda";
            this.idTipoMoneda.ReadOnly = true;
            this.idTipoMoneda.Visible = false;
            this.idTipoMoneda.Width = 125;
            // 
            // tipoMoneda
            // 
            this.tipoMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoMoneda.DataPropertyName = "tipoMoneda";
            this.tipoMoneda.HeaderText = "Moneda";
            this.tipoMoneda.MinimumWidth = 6;
            this.tipoMoneda.Name = "tipoMoneda";
            this.tipoMoneda.ReadOnly = true;
            // 
            // simbolo
            // 
            this.simbolo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.simbolo.DataPropertyName = "Simbolo";
            this.simbolo.HeaderText = "Símbolo";
            this.simbolo.MinimumWidth = 6;
            this.simbolo.Name = "simbolo";
            this.simbolo.ReadOnly = true;
            this.simbolo.Width = 87;
            // 
            // tasa
            // 
            this.tasa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tasa.DataPropertyName = "Tasa";
            this.tasa.HeaderText = "Tasa";
            this.tasa.MinimumWidth = 6;
            this.tasa.Name = "tasa";
            this.tasa.ReadOnly = true;
            this.tasa.Width = 69;
            // 
            // idAnio
            // 
            this.idAnio.DataPropertyName = "idAnio";
            this.idAnio.HeaderText = "idAnio";
            this.idAnio.MinimumWidth = 6;
            this.idAnio.Name = "idAnio";
            this.idAnio.ReadOnly = true;
            this.idAnio.Visible = false;
            this.idAnio.Width = 125;
            // 
            // fKPRtipoMonedaPRAniosBindingSource
            // 
            this.fKPRtipoMonedaPRAniosBindingSource.DataMember = "FK_PR_tipoMoneda_PR_Anios";
            this.fKPRtipoMonedaPRAniosBindingSource.DataSource = this.pRAniosBindingSource;
            // 
            // pR_AniosTableAdapter
            // 
            this.pR_AniosTableAdapter.ClearBeforeFill = true;
            // 
            // pR_tipoMonedaTableAdapter
            // 
            this.pR_tipoMonedaTableAdapter.ClearBeforeFill = true;
            // 
            // frmTipoMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 332);
            this.Controls.Add(this.dgvTipoMoneda);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "frmTipoMoneda";
            this.Text = "Tipo de Monedas";
            this.Load += new System.EventHandler(this.frmTipoMoneda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAniosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoMoneda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPRtipoMonedaPRAniosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvTipoMoneda;
        private System.Windows.Forms.ComboBox cboAños;
        private DataSets.DsPresupuesto dsPresupuesto;
        private System.Windows.Forms.BindingSource pRAniosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_AniosTableAdapter pR_AniosTableAdapter;
        private System.Windows.Forms.BindingSource fKPRtipoMonedaPRAniosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_tipoMonedaTableAdapter pR_tipoMonedaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoMoneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn simbolo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAnio;
        private System.Windows.Forms.Label label2;
    }
}