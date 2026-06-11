namespace ADIGGM.Herramientas
{
    partial class frmDevoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevoluciones));
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnCorregir = new System.Windows.Forms.Button();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.dgvDatosOriginales = new System.Windows.Forms.DataGridView();
            this.dgvDatosCorregidos = new System.Windows.Forms.DataGridView();
            this.cboPuntos = new System.Windows.Forms.ComboBox();
            this.cCPuntosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosOriginales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCorregidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCPuntosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(940, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(900, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(980, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(840, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 461);
            this.pnlFooter.Size = new System.Drawing.Size(1020, 23);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Image = ((System.Drawing.Image)(resources.GetObject("btnVerificar.Image")));
            this.btnVerificar.Location = new System.Drawing.Point(463, 41);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(119, 53);
            this.btnVerificar.TabIndex = 103;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnCorregir
            // 
            this.btnCorregir.Image = ((System.Drawing.Image)(resources.GetObject("btnCorregir.Image")));
            this.btnCorregir.Location = new System.Drawing.Point(469, 412);
            this.btnCorregir.Name = "btnCorregir";
            this.btnCorregir.Size = new System.Drawing.Size(108, 41);
            this.btnCorregir.TabIndex = 104;
            this.btnCorregir.Text = "Corregir";
            this.btnCorregir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCorregir.UseVisualStyleBackColor = true;
            this.btnCorregir.Click += new System.EventHandler(this.btnCorregir_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(118, 57);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(112, 21);
            this.txtDocumento.TabIndex = 105;
            this.txtDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocumento_KeyDown);
            this.txtDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocumento_KeyPress);
            // 
            // dgvDatosOriginales
            // 
            this.dgvDatosOriginales.AllowUserToAddRows = false;
            this.dgvDatosOriginales.AllowUserToDeleteRows = false;
            this.dgvDatosOriginales.AllowUserToResizeRows = false;
            this.dgvDatosOriginales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosOriginales.Location = new System.Drawing.Point(12, 115);
            this.dgvDatosOriginales.Name = "dgvDatosOriginales";
            this.dgvDatosOriginales.ReadOnly = true;
            this.dgvDatosOriginales.RowHeadersVisible = false;
            this.dgvDatosOriginales.Size = new System.Drawing.Size(508, 291);
            this.dgvDatosOriginales.TabIndex = 106;
            this.dgvDatosOriginales.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDatosOriginales_DataError);
            // 
            // dgvDatosCorregidos
            // 
            this.dgvDatosCorregidos.AllowUserToAddRows = false;
            this.dgvDatosCorregidos.AllowUserToDeleteRows = false;
            this.dgvDatosCorregidos.AllowUserToResizeRows = false;
            this.dgvDatosCorregidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosCorregidos.Location = new System.Drawing.Point(526, 115);
            this.dgvDatosCorregidos.Name = "dgvDatosCorregidos";
            this.dgvDatosCorregidos.ReadOnly = true;
            this.dgvDatosCorregidos.RowHeadersVisible = false;
            this.dgvDatosCorregidos.Size = new System.Drawing.Size(482, 291);
            this.dgvDatosCorregidos.TabIndex = 107;
            this.dgvDatosCorregidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDatosCorregidos_CellFormatting);
            this.dgvDatosCorregidos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDatosCorregidos_DataError);
            // 
            // cboPuntos
            // 
            this.cboPuntos.DataSource = this.cCPuntosBindingSource;
            this.cboPuntos.DisplayMember = "NombrePunto";
            this.cboPuntos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPuntos.FormattingEnabled = true;
            this.cboPuntos.Location = new System.Drawing.Point(307, 55);
            this.cboPuntos.Name = "cboPuntos";
            this.cboPuntos.Size = new System.Drawing.Size(135, 24);
            this.cboPuntos.TabIndex = 110;
            this.cboPuntos.ValueMember = "IdPunto";
            this.cboPuntos.SelectedValueChanged += new System.EventHandler(this.cboPuntos_SelectedValueChanged);
            //
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 108;
            this.label1.Text = "No. Factura o \r\nAsiento Contable:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 111;
            this.label2.Text = "Caja:";
            //
            // frmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(1020, 484);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboPuntos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatosCorregidos);
            this.Controls.Add(this.dgvDatosOriginales);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.btnCorregir);
            this.Controls.Add(this.btnVerificar);
            this.Name = "frmDevoluciones";
            this.Load += new System.EventHandler(this.frmDevoluciones_Load);
            this.Controls.SetChildIndex(this.btnVerificar, 0);
            this.Controls.SetChildIndex(this.btnCorregir, 0);
            this.Controls.SetChildIndex(this.txtDocumento, 0);
            this.Controls.SetChildIndex(this.dgvDatosOriginales, 0);
            this.Controls.SetChildIndex(this.dgvDatosCorregidos, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cboPuntos, 0);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosOriginales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosCorregidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCPuntosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnCorregir;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.DataGridView dgvDatosOriginales;
        private System.Windows.Forms.DataGridView dgvDatosCorregidos;
        private System.Windows.Forms.ComboBox cboPuntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource cCPuntosBindingSource;
    }
}
