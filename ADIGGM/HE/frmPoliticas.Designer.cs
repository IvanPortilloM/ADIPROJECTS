namespace ADIGGM.HE
{
    partial class frmPoliticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPoliticas));
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.chkPagaExtrasDiarias = new System.Windows.Forms.CheckBox();
            this.chkPagaDomingos = new System.Windows.Forms.CheckBox();
            this.chkPagaFeriados = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvPoliticas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkAplicaMixta = new System.Windows.Forms.CheckBox();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliticas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(637, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(597, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(677, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(537, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 413);
            this.pnlFooter.Size = new System.Drawing.Size(717, 23);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(411, 21);
            this.txtNombre.TabIndex = 103;
            // 
            // chkPagaExtrasDiarias
            // 
            this.chkPagaExtrasDiarias.AutoSize = true;
            this.chkPagaExtrasDiarias.Location = new System.Drawing.Point(149, 100);
            this.chkPagaExtrasDiarias.Name = "chkPagaExtrasDiarias";
            this.chkPagaExtrasDiarias.Size = new System.Drawing.Size(199, 20);
            this.chkPagaExtrasDiarias.TabIndex = 104;
            this.chkPagaExtrasDiarias.Text = "¿Paga Extras Diarias (25/50/75)?";
            this.chkPagaExtrasDiarias.UseVisualStyleBackColor = true;
            // 
            // chkPagaDomingos
            // 
            this.chkPagaDomingos.AutoSize = true;
            this.chkPagaDomingos.Location = new System.Drawing.Point(149, 126);
            this.chkPagaDomingos.Name = "chkPagaDomingos";
            this.chkPagaDomingos.Size = new System.Drawing.Size(168, 20);
            this.chkPagaDomingos.TabIndex = 105;
            this.chkPagaDomingos.Text = "¿Paga Domingos al 100%?";
            this.chkPagaDomingos.UseVisualStyleBackColor = true;
            // 
            // chkPagaFeriados
            // 
            this.chkPagaFeriados.AutoSize = true;
            this.chkPagaFeriados.Location = new System.Drawing.Point(149, 152);
            this.chkPagaFeriados.Name = "chkPagaFeriados";
            this.chkPagaFeriados.Size = new System.Drawing.Size(160, 20);
            this.chkPagaFeriados.TabIndex = 106;
            this.chkPagaFeriados.Text = "¿Paga Feriados al 100%?";
            this.chkPagaFeriados.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 107;
            this.label1.Text = "Nombre de la Política:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(321, 347);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(68, 61);
            this.btnEliminar.TabIndex = 109;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(404, 119);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(70, 61);
            this.btnGuardar.TabIndex = 108;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvPoliticas
            // 
            this.dgvPoliticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPoliticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoliticas.Location = new System.Drawing.Point(20, 206);
            this.dgvPoliticas.Name = "dgvPoliticas";
            this.dgvPoliticas.Size = new System.Drawing.Size(677, 135);
            this.dgvPoliticas.TabIndex = 110;
            this.dgvPoliticas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPoliticas_CellDoubleClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(490, 119);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 61);
            this.btnCancelar.TabIndex = 111;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkAplicaMixta
            // 
            this.chkAplicaMixta.AutoSize = true;
            this.chkAplicaMixta.Location = new System.Drawing.Point(149, 178);
            this.chkAplicaMixta.Name = "chkAplicaMixta";
            this.chkAplicaMixta.Size = new System.Drawing.Size(232, 20);
            this.chkAplicaMixta.TabIndex = 112;
            this.chkAplicaMixta.Text = "Aplicar Reducción Jornada Mixta (7h)";
            this.chkAplicaMixta.UseVisualStyleBackColor = true;
            // 
            // frmPoliticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(717, 436);
            this.Controls.Add(this.chkAplicaMixta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvPoliticas);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkPagaFeriados);
            this.Controls.Add(this.chkPagaDomingos);
            this.Controls.Add(this.chkPagaExtrasDiarias);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmPoliticas";
            this.Load += new System.EventHandler(this.frmPoliticas_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.chkPagaExtrasDiarias, 0);
            this.Controls.SetChildIndex(this.chkPagaDomingos, 0);
            this.Controls.SetChildIndex(this.chkPagaFeriados, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.dgvPoliticas, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.chkAplicaMixta, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoliticas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox chkPagaExtrasDiarias;
        private System.Windows.Forms.CheckBox chkPagaDomingos;
        private System.Windows.Forms.CheckBox chkPagaFeriados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvPoliticas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkAplicaMixta;
    }
}
