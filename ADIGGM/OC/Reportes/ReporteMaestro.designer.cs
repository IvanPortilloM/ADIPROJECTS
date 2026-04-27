namespace ADIGGM.OC.Reportes
{
    partial class ReporteMaestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteMaestro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.oCProductosCategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProveedores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAsignacion = new System.Windows.Forms.RadioButton();
            this.rdbProductos = new System.Windows.Forms.RadioButton();
            this.rdbProveedores = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.oC_ProductosCategoriasTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_ProductosCategoriasTableAdapter();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(722, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(682, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(762, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(622, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 507);
            this.pnlFooter.Size = new System.Drawing.Size(802, 23);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 73);
            this.panel1.TabIndex = 103;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(322, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 73);
            this.panel2.TabIndex = 104;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVisualizar);
            this.groupBox2.Controls.Add(this.cboCategoria);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtProveedores);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 73);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parametros";
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnVisualizar.FlatAppearance.BorderSize = 0;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(395, 13);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(69, 52);
            this.btnVisualizar.TabIndex = 121;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DataSource = this.oCProductosCategoriasBindingSource;
            this.cboCategoria.DisplayMember = "Categoria";
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(120, 43);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(255, 24);
            this.cboCategoria.TabIndex = 117;
            this.cboCategoria.ValueMember = "IdCatProducto";
            // 
            // oCProductosCategoriasBindingSource
            // 
            this.oCProductosCategoriasBindingSource.DataMember = "OC_ProductosCategorias";
            this.oCProductosCategoriasBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría:";
            // 
            // txtProveedores
            // 
            this.txtProveedores.Location = new System.Drawing.Point(120, 18);
            this.txtProveedores.Name = "txtProveedores";
            this.txtProveedores.Size = new System.Drawing.Size(255, 21);
            this.txtProveedores.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RTN/Proveedor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAsignacion);
            this.groupBox1.Controls.Add(this.rdbProductos);
            this.groupBox1.Controls.Add(this.rdbProveedores);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reportes";
            // 
            // rdbAsignacion
            // 
            this.rdbAsignacion.AutoSize = true;
            this.rdbAsignacion.Location = new System.Drawing.Point(123, 19);
            this.rdbAsignacion.Name = "rdbAsignacion";
            this.rdbAsignacion.Size = new System.Drawing.Size(187, 20);
            this.rdbAsignacion.TabIndex = 2;
            this.rdbAsignacion.TabStop = true;
            this.rdbAsignacion.Text = "Asignación Cuentas/Vehículos";
            this.rdbAsignacion.UseVisualStyleBackColor = true;
            this.rdbAsignacion.CheckedChanged += new System.EventHandler(this.rdbAsignacion_CheckedChanged);
            // 
            // rdbProductos
            // 
            this.rdbProductos.AutoSize = true;
            this.rdbProductos.Location = new System.Drawing.Point(12, 42);
            this.rdbProductos.Name = "rdbProductos";
            this.rdbProductos.Size = new System.Drawing.Size(79, 20);
            this.rdbProductos.TabIndex = 1;
            this.rdbProductos.TabStop = true;
            this.rdbProductos.Text = "Productos";
            this.rdbProductos.UseVisualStyleBackColor = true;
            this.rdbProductos.CheckedChanged += new System.EventHandler(this.rdbProductos_CheckedChanged);
            // 
            // rdbProveedores
            // 
            this.rdbProveedores.AutoSize = true;
            this.rdbProveedores.Location = new System.Drawing.Point(12, 19);
            this.rdbProveedores.Name = "rdbProveedores";
            this.rdbProveedores.Size = new System.Drawing.Size(93, 20);
            this.rdbProveedores.TabIndex = 0;
            this.rdbProveedores.TabStop = true;
            this.rdbProveedores.Text = "Proveedores";
            this.rdbProveedores.UseVisualStyleBackColor = true;
            this.rdbProveedores.CheckedChanged += new System.EventHandler(this.rdbProveedores_CheckedChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 108);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(802, 399);
            this.reportViewer1.TabIndex = 104;
            // 
            // oC_ProductosCategoriasTableAdapter
            // 
            this.oC_ProductosCategoriasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(802, 530);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "ReporteMaestro";
            this.Text = "Reporte Maestro";
            this.Load += new System.EventHandler(this.ReporteMaestro_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oCProductosCategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProveedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbAsignacion;
        private System.Windows.Forms.RadioButton rdbProductos;
        private System.Windows.Forms.RadioButton rdbProveedores;
        private System.Windows.Forms.ComboBox cboCategoria;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnVisualizar;
        private DataSets.DsOC dsOC;
        private System.Windows.Forms.BindingSource oCProductosCategoriasBindingSource;
        private DataSets.DsOCTableAdapters.OC_ProductosCategoriasTableAdapter oC_ProductosCategoriasTableAdapter;
    }
}
