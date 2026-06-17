
namespace ADIGGM.IA.Busquedas
{
    partial class frmBuscarAsociados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarAsociados));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cboOrdenBusqueda = new System.Windows.Forms.ComboBox();
            this.cboOperador = new System.Windows.Forms.ComboBox();
            this.rdbAscendente = new System.Windows.Forms.RadioButton();
            this.rdbDescendente = new System.Windows.Forms.RadioButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.nudRegistros = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAsociados = new System.Windows.Forms.DataGridView();
            this.cABuscarAsocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegistros)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsociados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABuscarAsocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(195, 19);
            this.lblFooter.Text = "Busqueda de asociados";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(597, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(557, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(637, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(497, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 448);
            this.pnlFooter.Size = new System.Drawing.Size(677, 23);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(229, 390);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(65, 50);
            this.btnAceptar.TabIndex = 113;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(365, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 50);
            this.btnSalir.TabIndex = 114;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(166, 88);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(33, 29);
            this.btnBuscar.TabIndex = 105;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboOrdenBusqueda
            // 
            this.cboOrdenBusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboOrdenBusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboOrdenBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrdenBusqueda.FormattingEnabled = true;
            this.cboOrdenBusqueda.Items.AddRange(new object[] {
            "DNI",
            "NOMBRE"});
            this.cboOrdenBusqueda.Location = new System.Drawing.Point(166, 58);
            this.cboOrdenBusqueda.Name = "cboOrdenBusqueda";
            this.cboOrdenBusqueda.Size = new System.Drawing.Size(150, 24);
            this.cboOrdenBusqueda.TabIndex = 106;
            this.cboOrdenBusqueda.TabStop = false;
            // 
            // cboOperador
            // 
            this.cboOperador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cboOperador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboOperador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOperador.FormattingEnabled = true;
            this.cboOperador.Items.AddRange(new object[] {
            "IGUAL QUE",
            "CONTIENE"});
            this.cboOperador.Location = new System.Drawing.Point(487, 58);
            this.cboOperador.Name = "cboOperador";
            this.cboOperador.Size = new System.Drawing.Size(150, 24);
            this.cboOperador.TabIndex = 107;
            this.cboOperador.TabStop = false;
            // 
            // rdbAscendente
            // 
            this.rdbAscendente.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbAscendente.AutoSize = true;
            this.rdbAscendente.Checked = true;
            this.rdbAscendente.Location = new System.Drawing.Point(417, 16);
            this.rdbAscendente.Name = "rdbAscendente";
            this.rdbAscendente.Size = new System.Drawing.Size(36, 26);
            this.rdbAscendente.TabIndex = 111;
            this.rdbAscendente.TabStop = true;
            this.rdbAscendente.Text = "A..Z";
            this.rdbAscendente.UseVisualStyleBackColor = true;
            this.rdbAscendente.CheckedChanged += new System.EventHandler(this.rdbAscendente_CheckedChanged);
            // 
            // rdbDescendente
            // 
            this.rdbDescendente.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbDescendente.AutoSize = true;
            this.rdbDescendente.Location = new System.Drawing.Point(460, 16);
            this.rdbDescendente.Name = "rdbDescendente";
            this.rdbDescendente.Size = new System.Drawing.Size(36, 26);
            this.rdbDescendente.TabIndex = 112;
            this.rdbDescendente.Text = "Z..A";
            this.rdbDescendente.UseVisualStyleBackColor = true;
            this.rdbDescendente.CheckedChanged += new System.EventHandler(this.rdbDescendente_CheckedChanged);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(205, 92);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(266, 21);
            this.txtBusqueda.TabIndex = 108;
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
            // 
            // nudRegistros
            // 
            this.nudRegistros.Location = new System.Drawing.Point(137, 19);
            this.nudRegistros.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRegistros.Name = "nudRegistros";
            this.nudRegistros.Size = new System.Drawing.Size(56, 21);
            this.nudRegistros.TabIndex = 110;
            this.nudRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRegistros.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudRegistros);
            this.panel1.Controls.Add(this.rdbAscendente);
            this.panel1.Controls.Add(this.rdbDescendente);
            this.panel1.Location = new System.Drawing.Point(85, 331);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 53);
            this.panel1.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 113;
            this.label2.Text = "Orden de visualización:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 112;
            this.label1.Text = "Registros a consultar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 113;
            this.label3.Text = "Orden de busqueda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 114;
            this.label4.Text = "Operador:";
            // 
            // dgvAsociados
            // 
            this.dgvAsociados.AllowUserToAddRows = false;
            this.dgvAsociados.AllowUserToDeleteRows = false;
            this.dgvAsociados.AllowUserToOrderColumns = true;
            this.dgvAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsociados.Location = new System.Drawing.Point(39, 123);
            this.dgvAsociados.Name = "dgvAsociados";
            this.dgvAsociados.ReadOnly = true;
            this.dgvAsociados.Size = new System.Drawing.Size(598, 202);
            this.dgvAsociados.TabIndex = 109;
            this.dgvAsociados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAsociados_KeyDown);
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            //
            // frmBuscarAsociados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(677, 471);
            this.Controls.Add(this.dgvAsociados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cboOperador);
            this.Controls.Add(this.cboOrdenBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmBuscarAsociados";
            this.Load += new System.EventHandler(this.frmBuscarAsociados_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.cboOrdenBusqueda, 0);
            this.Controls.SetChildIndex(this.cboOperador, 0);
            this.Controls.SetChildIndex(this.txtBusqueda, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dgvAsociados, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegistros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsociados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABuscarAsocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cboOrdenBusqueda;
        private System.Windows.Forms.ComboBox cboOperador;
        private System.Windows.Forms.RadioButton rdbAscendente;
        private System.Windows.Forms.RadioButton rdbDescendente;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.NumericUpDown nudRegistros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAsociados;
        private System.Windows.Forms.BindingSource cABuscarAsocBindingSource;
    }
}
