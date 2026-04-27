
namespace ADIGGM.PRESUPUESTO.Transaccionales
{
    partial class frmGenerarPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarPresupuesto));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.pRAniosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.pR_AniosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_AniosTableAdapter();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.pRDepartamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.pR_DepartamentosTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRAniosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.LightGreen;
            this.btnIniciar.Location = new System.Drawing.Point(87, 302);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(132, 52);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Generar Presupuesto";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // cboAño
            // 
            this.cboAño.DataSource = this.pRAniosBindingSource;
            this.cboAño.DisplayMember = "Anio";
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(190, 35);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(117, 24);
            this.cboAño.TabIndex = 1;
            this.cboAño.ValueMember = "idAnio";
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
            // pR_AniosTableAdapter
            // 
            this.pR_AniosTableAdapter.ClearBeforeFill = true;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DataSource = this.pRDepartamentosBindingSource;
            this.cboDepartamento.DisplayMember = "Departamento";
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(190, 81);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(190, 24);
            this.cboDepartamento.TabIndex = 3;
            this.cboDepartamento.ValueMember = "idDepartamento";
            // 
            // pRDepartamentosBindingSource
            // 
            this.pRDepartamentosBindingSource.DataMember = "PR_Departamentos";
            this.pRDepartamentosBindingSource.DataSource = this.dsPresupuesto;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(190, 132);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(235, 122);
            this.txtObservacion.TabIndex = 5;
            // 
            // pR_DepartamentosTableAdapter
            // 
            this.pR_DepartamentosTableAdapter.ClearBeforeFill = true;
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
            this.btnSalir.Location = new System.Drawing.Point(287, 287);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(93, 80);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "Observación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 53;
            this.label3.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Año:";
            // 
            // frmGenerarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.cboAño);
            this.Controls.Add(this.btnIniciar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGenerarPresupuesto";
            this.Text = "Generar Presupuesto";
            this.Load += new System.EventHandler(this.frmGenerarPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAniosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRDepartamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.ComboBox cboAño;
        private DataSets.DsPresupuesto dsPresupuesto;
        private System.Windows.Forms.BindingSource pRAniosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_AniosTableAdapter pR_AniosTableAdapter;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.BindingSource pRDepartamentosBindingSource;
        private DataSets.DsPresupuestoTableAdapters.PR_DepartamentosTableAdapter pR_DepartamentosTableAdapter;
        public System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}