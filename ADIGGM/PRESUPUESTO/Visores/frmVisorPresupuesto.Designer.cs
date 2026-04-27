
namespace ADIGGM.PRESUPUESTO.Visores
{
    partial class frmVisorPresupuesto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisorPresupuesto));
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verPresupuestoSemanalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSueldosYSalariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPresupuesto = new System.Windows.Forms.DataGridView();
            this.idPresupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRAniosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cerrado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aprobado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.anulado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRVisorPresupuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pR_VisorPresupuestoTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_VisorPresupuestoTableAdapter();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.pRDepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.pR_AniosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_AniosTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pR_DepartamentosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAniosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRVisorPresupuestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsPresupuesto
            // 
            this.dsPresupuesto.DataSetName = "DsPresupuesto";
            this.dsPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verPresupuestoSemanalToolStripMenuItem,
            this.verSueldosYSalariosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 48);
            // 
            // verPresupuestoSemanalToolStripMenuItem
            // 
            this.verPresupuestoSemanalToolStripMenuItem.Name = "verPresupuestoSemanalToolStripMenuItem";
            this.verPresupuestoSemanalToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.verPresupuestoSemanalToolStripMenuItem.Text = "Ver Presupuesto Semanal";
            this.verPresupuestoSemanalToolStripMenuItem.Click += new System.EventHandler(this.verPresupuestoSemanalToolStripMenuItem_Click);
            // 
            // verSueldosYSalariosToolStripMenuItem
            // 
            this.verSueldosYSalariosToolStripMenuItem.Name = "verSueldosYSalariosToolStripMenuItem";
            this.verSueldosYSalariosToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.verSueldosYSalariosToolStripMenuItem.Text = "Ver Sueldos y Salarios";
            this.verSueldosYSalariosToolStripMenuItem.Click += new System.EventHandler(this.verSueldosYSalariosToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPresupuesto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 156);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 228);
            this.panel2.TabIndex = 2;
            // 
            // dgvPresupuesto
            // 
            this.dgvPresupuesto.AllowUserToAddRows = false;
            this.dgvPresupuesto.AllowUserToDeleteRows = false;
            this.dgvPresupuesto.AllowUserToResizeRows = false;
            this.dgvPresupuesto.AutoGenerateColumns = false;
            this.dgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPresupuesto,
            this.idDepartamento,
            this.fecInicio,
            this.fecFinal,
            this.idAnio,
            this.cerrado,
            this.aprobado,
            this.anulado,
            this.observacion});
            this.dgvPresupuesto.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPresupuesto.DataSource = this.pRVisorPresupuestoBindingSource;
            this.dgvPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPresupuesto.Location = new System.Drawing.Point(0, 0);
            this.dgvPresupuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPresupuesto.Name = "dgvPresupuesto";
            this.dgvPresupuesto.ReadOnly = true;
            this.dgvPresupuesto.RowHeadersVisible = false;
            this.dgvPresupuesto.RowHeadersWidth = 51;
            this.dgvPresupuesto.RowTemplate.Height = 24;
            this.dgvPresupuesto.Size = new System.Drawing.Size(607, 228);
            this.dgvPresupuesto.TabIndex = 0;
            this.dgvPresupuesto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvPresupuesto_MouseDown);
            // 
            // idPresupuesto
            // 
            this.idPresupuesto.DataPropertyName = "idPresupuesto";
            this.idPresupuesto.HeaderText = "idPresupuesto";
            this.idPresupuesto.MinimumWidth = 6;
            this.idPresupuesto.Name = "idPresupuesto";
            this.idPresupuesto.ReadOnly = true;
            this.idPresupuesto.Visible = false;
            this.idPresupuesto.Width = 125;
            // 
            // idDepartamento
            // 
            this.idDepartamento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idDepartamento.DataPropertyName = "idDepartamento";
            this.idDepartamento.HeaderText = "Departamento";
            this.idDepartamento.MinimumWidth = 6;
            this.idDepartamento.Name = "idDepartamento";
            this.idDepartamento.ReadOnly = true;
            this.idDepartamento.Visible = false;
            // 
            // fecInicio
            // 
            this.fecInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fecInicio.DataPropertyName = "fecInicio";
            this.fecInicio.HeaderText = "Fecha Inicio";
            this.fecInicio.MinimumWidth = 6;
            this.fecInicio.Name = "fecInicio";
            this.fecInicio.ReadOnly = true;
            this.fecInicio.Width = 90;
            // 
            // fecFinal
            // 
            this.fecFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fecFinal.DataPropertyName = "fecFinal";
            this.fecFinal.HeaderText = "Fecha Final";
            this.fecFinal.MinimumWidth = 6;
            this.fecFinal.Name = "fecFinal";
            this.fecFinal.ReadOnly = true;
            this.fecFinal.Width = 87;
            // 
            // idAnio
            // 
            this.idAnio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.idAnio.DataPropertyName = "idAnio";
            this.idAnio.DataSource = this.pRAniosBindingSource;
            this.idAnio.DisplayMember = "Anio";
            this.idAnio.HeaderText = "Año";
            this.idAnio.MinimumWidth = 6;
            this.idAnio.Name = "idAnio";
            this.idAnio.ReadOnly = true;
            this.idAnio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idAnio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idAnio.ValueMember = "idAnio";
            this.idAnio.Width = 51;
            // 
            // pRAniosBindingSource
            // 
            this.pRAniosBindingSource.DataMember = "PR_Anios";
            this.pRAniosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // cerrado
            // 
            this.cerrado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cerrado.DataPropertyName = "Cerrado";
            this.cerrado.HeaderText = "Cerrado";
            this.cerrado.MinimumWidth = 6;
            this.cerrado.Name = "cerrado";
            this.cerrado.ReadOnly = true;
            this.cerrado.Width = 50;
            // 
            // aprobado
            // 
            this.aprobado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aprobado.DataPropertyName = "Aprobado";
            this.aprobado.HeaderText = "Aprobado";
            this.aprobado.MinimumWidth = 6;
            this.aprobado.Name = "aprobado";
            this.aprobado.ReadOnly = true;
            this.aprobado.Width = 59;
            // 
            // anulado
            // 
            this.anulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.anulado.DataPropertyName = "Anulado";
            this.anulado.HeaderText = "Anulado";
            this.anulado.MinimumWidth = 6;
            this.anulado.Name = "anulado";
            this.anulado.ReadOnly = true;
            this.anulado.Width = 52;
            // 
            // observacion
            // 
            this.observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observacion.DataPropertyName = "Observacion";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.observacion.DefaultCellStyle = dataGridViewCellStyle1;
            this.observacion.HeaderText = "Observación";
            this.observacion.MinimumWidth = 6;
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            // 
            // pRVisorPresupuestoBindingSource
            // 
            this.pRVisorPresupuestoBindingSource.DataMember = "PR_VisorPresupuesto";
            this.pRVisorPresupuestoBindingSource.DataSource = this.dsPresupuesto;
            // 
            // pR_VisorPresupuestoTableAdapter
            // 
            this.pR_VisorPresupuestoTableAdapter.ClearBeforeFill = true;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboDepartamento.DataSource = this.pRDepartamentosBindingSource;
            this.cboDepartamento.DisplayMember = "Departamento";
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(233, 43);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(181, 21);
            this.cboDepartamento.TabIndex = 3;
            this.cboDepartamento.ValueMember = "idDepartamento";
            this.cboDepartamento.SelectedValueChanged += new System.EventHandler(this.cboDepartamento_SelectedValueChanged);
            // 
            // pRDepartamentosBindingSource
            // 
            this.pRDepartamentosBindingSource.DataMember = "PR_Departamentos";
            this.pRDepartamentosBindingSource.DataSource = this.dsPresupuesto;
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
            this.btnSalir.Location = new System.Drawing.Point(455, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 65);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pR_AniosTableAdapter
            // 
            this.pR_AniosTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.cboDepartamento);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 110);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "Departamento:";
            // 
            // pR_DepartamentosTableAdapter
            // 
            this.pR_DepartamentosTableAdapter.ClearBeforeFill = true;
            // 
            // frmVisorPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 384);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmVisorPresupuesto";
            this.Text = "Visor Presupuesto Semanal";
            this.Load += new System.EventHandler(this.frmVisorPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAniosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRVisorPresupuestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvPresupuesto;
        private DataSets.DsPresupuesto dsPresupuesto;
        private System.Windows.Forms.BindingSource pRVisorPresupuestoBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_VisorPresupuestoTableAdapter pR_VisorPresupuestoTableAdapter;
        private System.Windows.Forms.ComboBox cboDepartamento;
        public System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.BindingSource pRAniosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_AniosTableAdapter pR_AniosTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verPresupuestoSemanalToolStripMenuItem;
        private System.Windows.Forms.BindingSource pRDepartamentosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter pR_DepartamentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPresupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecFinal;
        private System.Windows.Forms.DataGridViewComboBoxColumn idAnio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cerrado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aprobado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn anulado;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem verSueldosYSalariosToolStripMenuItem;
    }
}