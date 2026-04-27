namespace ADIGGM.OC.Visores
{
    partial class VisOCCodeasDet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumOrden = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOCDet = new System.Windows.Forms.DataGridView();
            this.vehiculoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadConfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioConfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSVConfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalConfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.oCOrdenTrabajoDetCODEASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsOC = new ADIGGM.DataSets.DsOC();
            this.oC_OrdenTrabajoDetCODEASTableAdapter = new ADIGGM.DataSets.DsOCTableAdapters.OC_OrdenTrabajoDetCODEASTableAdapter();
            this.pnlFooter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOCDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenTrabajoDetCODEASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFooter
            // 
            this.lblFooter.Size = new System.Drawing.Size(116, 19);
            this.lblFooter.Text = "Detalle Orden";
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(661, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(621, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(701, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(561, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 340);
            this.pnlFooter.Size = new System.Drawing.Size(741, 23);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblVehiculo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMonto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNumOrden);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 46);
            this.panel1.TabIndex = 106;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.ForeColor = System.Drawing.Color.Maroon;
            this.lblVehiculo.Location = new System.Drawing.Point(363, 11);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(49, 25);
            this.lblVehiculo.TabIndex = 5;
            this.lblVehiculo.Text = "vehi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(262, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vehiculo:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Maroon;
            this.lblMonto.Location = new System.Drawing.Point(558, 11);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(73, 25);
            this.lblMonto.TabIndex = 3;
            this.lblMonto.Text = "monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(474, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto:";
            // 
            // lblNumOrden
            // 
            this.lblNumOrden.AutoSize = true;
            this.lblNumOrden.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOrden.ForeColor = System.Drawing.Color.Maroon;
            this.lblNumOrden.Location = new System.Drawing.Point(140, 11);
            this.lblNumOrden.Name = "lblNumOrden";
            this.lblNumOrden.Size = new System.Drawing.Size(80, 25);
            this.lblNumOrden.TabIndex = 1;
            this.lblNumOrden.Text = "#Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "#Orden:";
            // 
            // dgvOCDet
            // 
            this.dgvOCDet.AllowUserToAddRows = false;
            this.dgvOCDet.AllowUserToDeleteRows = false;
            this.dgvOCDet.AutoGenerateColumns = false;
            this.dgvOCDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOCDet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOCDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOCDet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehiculoDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.cantidadConfDataGridViewTextBoxColumn,
            this.precioConfDataGridViewTextBoxColumn,
            this.iSVConfDataGridViewTextBoxColumn,
            this.totalConfDataGridViewTextBoxColumn,
            this.confirmadoDataGridViewCheckBoxColumn});
            this.dgvOCDet.DataSource = this.oCOrdenTrabajoDetCODEASBindingSource;
            this.dgvOCDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOCDet.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOCDet.Location = new System.Drawing.Point(0, 81);
            this.dgvOCDet.Name = "dgvOCDet";
            this.dgvOCDet.ReadOnly = true;
            this.dgvOCDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOCDet.Size = new System.Drawing.Size(741, 259);
            this.dgvOCDet.TabIndex = 108;
            // 
            // vehiculoDataGridViewTextBoxColumn
            // 
            this.vehiculoDataGridViewTextBoxColumn.DataPropertyName = "Vehiculo";
            this.vehiculoDataGridViewTextBoxColumn.FillWeight = 140.4929F;
            this.vehiculoDataGridViewTextBoxColumn.HeaderText = "Vehiculo";
            this.vehiculoDataGridViewTextBoxColumn.Name = "vehiculoDataGridViewTextBoxColumn";
            this.vehiculoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.FillWeight = 140.4929F;
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadConfDataGridViewTextBoxColumn
            // 
            this.cantidadConfDataGridViewTextBoxColumn.DataPropertyName = "CantidadConf";
            dataGridViewCellStyle1.Format = "N2";
            this.cantidadConfDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cantidadConfDataGridViewTextBoxColumn.FillWeight = 95.24942F;
            this.cantidadConfDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadConfDataGridViewTextBoxColumn.Name = "cantidadConfDataGridViewTextBoxColumn";
            this.cantidadConfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioConfDataGridViewTextBoxColumn
            // 
            this.precioConfDataGridViewTextBoxColumn.DataPropertyName = "PrecioConf";
            dataGridViewCellStyle2.Format = "N2";
            this.precioConfDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.precioConfDataGridViewTextBoxColumn.FillWeight = 90.13716F;
            this.precioConfDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioConfDataGridViewTextBoxColumn.Name = "precioConfDataGridViewTextBoxColumn";
            this.precioConfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSVConfDataGridViewTextBoxColumn
            // 
            this.iSVConfDataGridViewTextBoxColumn.DataPropertyName = "ISVConf";
            dataGridViewCellStyle3.Format = "N2";
            this.iSVConfDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.iSVConfDataGridViewTextBoxColumn.FillWeight = 84.44724F;
            this.iSVConfDataGridViewTextBoxColumn.HeaderText = "ISV";
            this.iSVConfDataGridViewTextBoxColumn.Name = "iSVConfDataGridViewTextBoxColumn";
            this.iSVConfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalConfDataGridViewTextBoxColumn
            // 
            this.totalConfDataGridViewTextBoxColumn.DataPropertyName = "TotalConf";
            dataGridViewCellStyle4.Format = "N2";
            this.totalConfDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.totalConfDataGridViewTextBoxColumn.FillWeight = 78.1144F;
            this.totalConfDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalConfDataGridViewTextBoxColumn.Name = "totalConfDataGridViewTextBoxColumn";
            this.totalConfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // confirmadoDataGridViewCheckBoxColumn
            // 
            this.confirmadoDataGridViewCheckBoxColumn.DataPropertyName = "Confirmado";
            this.confirmadoDataGridViewCheckBoxColumn.FillWeight = 71.06599F;
            this.confirmadoDataGridViewCheckBoxColumn.HeaderText = "Confirmado";
            this.confirmadoDataGridViewCheckBoxColumn.Name = "confirmadoDataGridViewCheckBoxColumn";
            this.confirmadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // oCOrdenTrabajoDetCODEASBindingSource
            // 
            this.oCOrdenTrabajoDetCODEASBindingSource.DataMember = "OC_OrdenTrabajoDetCODEAS";
            this.oCOrdenTrabajoDetCODEASBindingSource.DataSource = this.dsOC;
            // 
            // dsOC
            // 
            this.dsOC.DataSetName = "DsOC";
            this.dsOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oC_OrdenTrabajoDetCODEASTableAdapter
            // 
            this.oC_OrdenTrabajoDetCODEASTableAdapter.ClearBeforeFill = true;
            // 
            // VisOCCodeasDet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(741, 363);
            this.Controls.Add(this.dgvOCDet);
            this.Controls.Add(this.panel1);
            this.Name = "VisOCCodeasDet";
            this.Text = "Detalle OC";
            this.Load += new System.EventHandler(this.VisOCCodeasDet_Load);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgvOCDet, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOCDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oCOrdenTrabajoDetCODEASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOCDet;
        private System.Windows.Forms.BindingSource oCOrdenTrabajoDetCODEASBindingSource;
        private DataSets.DsOC dsOC;
        private DataSets.DsOCTableAdapters.OC_OrdenTrabajoDetCODEASTableAdapter oC_OrdenTrabajoDetCODEASTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadConfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioConfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSVConfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalConfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmadoDataGridViewCheckBoxColumn;
    }
}
