namespace ADIGGM.Herramientas
{
    partial class frmAccionPersonalTrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccionPersonalTrans));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaAccion = new System.Windows.Forms.DateTimePicker();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCompensacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCompensacion2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaTrabajada1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbObservacion = new System.Windows.Forms.ComboBox();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.tRMotoristasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsTransporteAdiggm = new ADIGGM.DataSets.DsTransporteAdiggm();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAño = new System.Windows.Forms.ComboBox();
            this.tR_MotoristasTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_MotoristasTableAdapter();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.listBoxDiasLibres = new System.Windows.Forms.ListBox();
            this.txtCantidadLibres = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.dtpFechaTrabajada2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTrabajada3 = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTrabajada6 = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTrabajada5 = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaTrabajada4 = new System.Windows.Forms.DateTimePicker();
            this.ckbYN = new System.Windows.Forms.CheckBox();
            this.ckbIC = new System.Windows.Forms.CheckBox();
            this.ckbFecha2 = new System.Windows.Forms.CheckBox();
            this.ckbFecha3 = new System.Windows.Forms.CheckBox();
            this.ckbFecha5 = new System.Windows.Forms.CheckBox();
            this.ckbFecha4 = new System.Windows.Forms.CheckBox();
            this.ckbFecha6 = new System.Windows.Forms.CheckBox();
            this.tR_AccionesPersonalTableAdapter = new ADIGGM.DataSets.DsTransporteAdiggmTableAdapters.TR_AccionesPersonalTableAdapter();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRMotoristasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMax
            // 
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(850, 0);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Location = new System.Drawing.Point(810, 0);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(890, 0);
            // 
            // pgbProcesos
            // 
            this.pgbProcesos.Location = new System.Drawing.Point(750, 0);
            // 
            // pnlFooter
            // 
            this.pnlFooter.Location = new System.Drawing.Point(0, 627);
            this.pnlFooter.Size = new System.Drawing.Size(930, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 103;
            this.label1.Text = "FECHA DE ACCIÓN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "CANTIDAD LIBRES:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 105;
            this.label3.Text = "OBSERVACIÓN:";
            // 
            // btnCrear
            // 
            this.btnCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnCrear.Image")));
            this.btnCrear.Location = new System.Drawing.Point(205, 539);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(74, 72);
            this.btnCrear.TabIndex = 106;
            this.btnCrear.Text = "CREAR ACCIÓN";
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(750, 509);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 72);
            this.btnLimpiar.TabIndex = 107;
            this.btnLimpiar.Text = "LIMPIAR DATOS";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 108;
            this.label4.Text = "DÍAS LIBRES:";
            // 
            // dtpFechaAccion
            // 
            this.dtpFechaAccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAccion.Location = new System.Drawing.Point(130, 117);
            this.dtpFechaAccion.Name = "dtpFechaAccion";
            this.dtpFechaAccion.Size = new System.Drawing.Size(81, 21);
            this.dtpFechaAccion.TabIndex = 113;
            // 
            // cmbMes
            // 
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(130, 198);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(117, 24);
            this.cmbMes.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 115;
            this.label5.Text = "MES:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 116;
            this.label6.Text = "AÑO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 117;
            this.label7.Text = "COMPENSACIÓN:";
            // 
            // cmbCompensacion
            // 
            this.cmbCompensacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompensacion.DropDownWidth = 150;
            this.cmbCompensacion.FormattingEnabled = true;
            this.cmbCompensacion.Location = new System.Drawing.Point(130, 241);
            this.cmbCompensacion.Name = "cmbCompensacion";
            this.cmbCompensacion.Size = new System.Drawing.Size(117, 24);
            this.cmbCompensacion.TabIndex = 118;
            this.cmbCompensacion.SelectedIndexChanged += new System.EventHandler(this.cmbCompensacion_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 119;
            this.label8.Text = "Y";
            // 
            // cmbCompensacion2
            // 
            this.cmbCompensacion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompensacion2.DropDownWidth = 150;
            this.cmbCompensacion2.FormattingEnabled = true;
            this.cmbCompensacion2.Location = new System.Drawing.Point(130, 271);
            this.cmbCompensacion2.Name = "cmbCompensacion2";
            this.cmbCompensacion2.Size = new System.Drawing.Size(117, 24);
            this.cmbCompensacion2.TabIndex = 120;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(282, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 121;
            this.label9.Text = "F. TRABAJADA:";
            // 
            // dtpFechaTrabajada1
            // 
            this.dtpFechaTrabajada1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTrabajada1.Location = new System.Drawing.Point(368, 157);
            this.dtpFechaTrabajada1.Name = "dtpFechaTrabajada1";
            this.dtpFechaTrabajada1.ShowCheckBox = true;
            this.dtpFechaTrabajada1.Size = new System.Drawing.Size(101, 21);
            this.dtpFechaTrabajada1.TabIndex = 122;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(627, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(282, 403);
            this.dataGridView1.TabIndex = 123;
            // 
            // cmbObservacion
            // 
            this.cmbObservacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObservacion.FormattingEnabled = true;
            this.cmbObservacion.Location = new System.Drawing.Point(130, 155);
            this.cmbObservacion.Name = "cmbObservacion";
            this.cmbObservacion.Size = new System.Drawing.Size(117, 24);
            this.cmbObservacion.TabIndex = 124;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboEmpleado.DataSource = this.tRMotoristasBindingSource;
            this.cboEmpleado.DisplayMember = "Motorista";
            this.cboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(130, 62);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(137, 24);
            this.cboEmpleado.TabIndex = 125;
            this.cboEmpleado.ValueMember = "IdMotorista";
            // 
            // tRMotoristasBindingSource
            // 
            this.tRMotoristasBindingSource.DataMember = "TR_Motoristas";
            this.tRMotoristasBindingSource.DataSource = this.dsTransporteAdiggm;
            // 
            // dsTransporteAdiggm
            // 
            this.dsTransporteAdiggm.DataSetName = "DsTransporteAdiggm";
            this.dsTransporteAdiggm.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 126;
            this.label10.Text = "EMPLEADO:";
            // 
            // cmbAño
            // 
            this.cmbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAño.FormattingEnabled = true;
            this.cmbAño.Location = new System.Drawing.Point(381, 115);
            this.cmbAño.Name = "cmbAño";
            this.cmbAño.Size = new System.Drawing.Size(59, 24);
            this.cmbAño.TabIndex = 127;
            // 
            // tR_MotoristasTableAdapter
            // 
            this.tR_MotoristasTableAdapter.ClearBeforeFill = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(23, 408);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(474, 110);
            this.txtResultado.TabIndex = 140;
            // 
            // listBoxDiasLibres
            // 
            this.listBoxDiasLibres.FormattingEnabled = true;
            this.listBoxDiasLibres.ItemHeight = 16;
            this.listBoxDiasLibres.Location = new System.Drawing.Point(513, 63);
            this.listBoxDiasLibres.Name = "listBoxDiasLibres";
            this.listBoxDiasLibres.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxDiasLibres.Size = new System.Drawing.Size(99, 548);
            this.listBoxDiasLibres.TabIndex = 141;
            // 
            // txtCantidadLibres
            // 
            this.txtCantidadLibres.Location = new System.Drawing.Point(412, 62);
            this.txtCantidadLibres.Name = "txtCantidadLibres";
            this.txtCantidadLibres.Size = new System.Drawing.Size(57, 21);
            this.txtCantidadLibres.TabIndex = 142;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(23, 381);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(474, 21);
            this.txtMotivo.TabIndex = 143;
            // 
            // dtpFechaTrabajada2
            // 
            this.dtpFechaTrabajada2.Checked = false;
            this.dtpFechaTrabajada2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTrabajada2.Location = new System.Drawing.Point(368, 178);
            this.dtpFechaTrabajada2.Name = "dtpFechaTrabajada2";
            this.dtpFechaTrabajada2.ShowCheckBox = true;
            this.dtpFechaTrabajada2.Size = new System.Drawing.Size(101, 21);
            this.dtpFechaTrabajada2.TabIndex = 144;
            // 
            // dtpFechaTrabajada3
            // 
            this.dtpFechaTrabajada3.Checked = false;
            this.dtpFechaTrabajada3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTrabajada3.Location = new System.Drawing.Point(368, 199);
            this.dtpFechaTrabajada3.Name = "dtpFechaTrabajada3";
            this.dtpFechaTrabajada3.ShowCheckBox = true;
            this.dtpFechaTrabajada3.Size = new System.Drawing.Size(101, 21);
            this.dtpFechaTrabajada3.TabIndex = 145;
            // 
            // dtpFechaTrabajada6
            // 
            this.dtpFechaTrabajada6.Checked = false;
            this.dtpFechaTrabajada6.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTrabajada6.Location = new System.Drawing.Point(368, 262);
            this.dtpFechaTrabajada6.Name = "dtpFechaTrabajada6";
            this.dtpFechaTrabajada6.ShowCheckBox = true;
            this.dtpFechaTrabajada6.Size = new System.Drawing.Size(101, 21);
            this.dtpFechaTrabajada6.TabIndex = 148;
            // 
            // dtpFechaTrabajada5
            // 
            this.dtpFechaTrabajada5.Checked = false;
            this.dtpFechaTrabajada5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTrabajada5.Location = new System.Drawing.Point(368, 241);
            this.dtpFechaTrabajada5.Name = "dtpFechaTrabajada5";
            this.dtpFechaTrabajada5.ShowCheckBox = true;
            this.dtpFechaTrabajada5.Size = new System.Drawing.Size(101, 21);
            this.dtpFechaTrabajada5.TabIndex = 147;
            // 
            // dtpFechaTrabajada4
            // 
            this.dtpFechaTrabajada4.Checked = false;
            this.dtpFechaTrabajada4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaTrabajada4.Location = new System.Drawing.Point(368, 220);
            this.dtpFechaTrabajada4.Name = "dtpFechaTrabajada4";
            this.dtpFechaTrabajada4.ShowCheckBox = true;
            this.dtpFechaTrabajada4.Size = new System.Drawing.Size(101, 21);
            this.dtpFechaTrabajada4.TabIndex = 146;
            // 
            // ckbYN
            // 
            this.ckbYN.AutoSize = true;
            this.ckbYN.Checked = true;
            this.ckbYN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbYN.Location = new System.Drawing.Point(252, 160);
            this.ckbYN.Name = "ckbYN";
            this.ckbYN.Size = new System.Drawing.Size(15, 14);
            this.ckbYN.TabIndex = 149;
            this.ckbYN.UseVisualStyleBackColor = true;
            // 
            // ckbIC
            // 
            this.ckbIC.AutoSize = true;
            this.ckbIC.Checked = true;
            this.ckbIC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIC.Location = new System.Drawing.Point(252, 247);
            this.ckbIC.Name = "ckbIC";
            this.ckbIC.Size = new System.Drawing.Size(15, 14);
            this.ckbIC.TabIndex = 150;
            this.ckbIC.UseVisualStyleBackColor = true;
            this.ckbIC.Visible = false;
            // 
            // ckbFecha2
            // 
            this.ckbFecha2.AutoSize = true;
            this.ckbFecha2.Location = new System.Drawing.Point(475, 163);
            this.ckbFecha2.Name = "ckbFecha2";
            this.ckbFecha2.Size = new System.Drawing.Size(15, 14);
            this.ckbFecha2.TabIndex = 151;
            this.ckbFecha2.UseVisualStyleBackColor = true;
            this.ckbFecha2.Visible = false;
            this.ckbFecha2.CheckedChanged += new System.EventHandler(this.ckbFecha2_CheckedChanged);
            // 
            // ckbFecha3
            // 
            this.ckbFecha3.AutoSize = true;
            this.ckbFecha3.Location = new System.Drawing.Point(475, 184);
            this.ckbFecha3.Name = "ckbFecha3";
            this.ckbFecha3.Size = new System.Drawing.Size(15, 14);
            this.ckbFecha3.TabIndex = 152;
            this.ckbFecha3.UseVisualStyleBackColor = true;
            this.ckbFecha3.Visible = false;
            this.ckbFecha3.CheckedChanged += new System.EventHandler(this.ckbFecha3_CheckedChanged);
            // 
            // ckbFecha5
            // 
            this.ckbFecha5.AutoSize = true;
            this.ckbFecha5.Location = new System.Drawing.Point(475, 226);
            this.ckbFecha5.Name = "ckbFecha5";
            this.ckbFecha5.Size = new System.Drawing.Size(15, 14);
            this.ckbFecha5.TabIndex = 154;
            this.ckbFecha5.UseVisualStyleBackColor = true;
            this.ckbFecha5.Visible = false;
            this.ckbFecha5.CheckedChanged += new System.EventHandler(this.ckbFecha5_CheckedChanged);
            // 
            // ckbFecha4
            // 
            this.ckbFecha4.AutoSize = true;
            this.ckbFecha4.Location = new System.Drawing.Point(475, 205);
            this.ckbFecha4.Name = "ckbFecha4";
            this.ckbFecha4.Size = new System.Drawing.Size(15, 14);
            this.ckbFecha4.TabIndex = 153;
            this.ckbFecha4.UseVisualStyleBackColor = true;
            this.ckbFecha4.Visible = false;
            this.ckbFecha4.CheckedChanged += new System.EventHandler(this.ckbFecha4_CheckedChanged);
            // 
            // ckbFecha6
            // 
            this.ckbFecha6.AutoSize = true;
            this.ckbFecha6.Location = new System.Drawing.Point(475, 247);
            this.ckbFecha6.Name = "ckbFecha6";
            this.ckbFecha6.Size = new System.Drawing.Size(15, 14);
            this.ckbFecha6.TabIndex = 155;
            this.ckbFecha6.UseVisualStyleBackColor = true;
            this.ckbFecha6.Visible = false;
            this.ckbFecha6.CheckedChanged += new System.EventHandler(this.ckbFecha6_CheckedChanged);
            // 
            // tR_AccionesPersonalTableAdapter
            // 
            this.tR_AccionesPersonalTableAdapter.ClearBeforeFill = true;
            // 
            // txtId
            // 
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRMotoristasBindingSource, "Identidad", true));
            this.txtId.Location = new System.Drawing.Point(295, 65);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(102, 21);
            this.txtId.TabIndex = 156;
            // 
            // txtPuesto
            // 
            this.txtPuesto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tRMotoristasBindingSource, "Puesto", true));
            this.txtPuesto.Location = new System.Drawing.Point(295, 88);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(102, 21);
            this.txtPuesto.TabIndex = 157;
            // 
            // frmAccionPersonalTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(930, 650);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.ckbFecha6);
            this.Controls.Add(this.ckbFecha5);
            this.Controls.Add(this.ckbFecha4);
            this.Controls.Add(this.ckbFecha3);
            this.Controls.Add(this.ckbFecha2);
            this.Controls.Add(this.ckbIC);
            this.Controls.Add(this.ckbYN);
            this.Controls.Add(this.dtpFechaTrabajada6);
            this.Controls.Add(this.dtpFechaTrabajada5);
            this.Controls.Add(this.dtpFechaTrabajada4);
            this.Controls.Add(this.dtpFechaTrabajada3);
            this.Controls.Add(this.dtpFechaTrabajada2);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtCantidadLibres);
            this.Controls.Add(this.listBoxDiasLibres);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.cmbAño);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboEmpleado);
            this.Controls.Add(this.cmbObservacion);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpFechaTrabajada1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbCompensacion2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCompensacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.dtpFechaAccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAccionPersonalTrans";
            this.Load += new System.EventHandler(this.frmAccionPersonalTrans_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnCrear, 0);
            this.Controls.SetChildIndex(this.btnLimpiar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.dtpFechaAccion, 0);
            this.Controls.SetChildIndex(this.cmbMes, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.cmbCompensacion, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.cmbCompensacion2, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.dtpFechaTrabajada1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.cmbObservacion, 0);
            this.Controls.SetChildIndex(this.cboEmpleado, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.cmbAño, 0);
            this.Controls.SetChildIndex(this.txtResultado, 0);
            this.Controls.SetChildIndex(this.listBoxDiasLibres, 0);
            this.Controls.SetChildIndex(this.txtCantidadLibres, 0);
            this.Controls.SetChildIndex(this.txtMotivo, 0);
            this.Controls.SetChildIndex(this.pnlFooter, 0);
            this.Controls.SetChildIndex(this.dtpFechaTrabajada2, 0);
            this.Controls.SetChildIndex(this.dtpFechaTrabajada3, 0);
            this.Controls.SetChildIndex(this.dtpFechaTrabajada4, 0);
            this.Controls.SetChildIndex(this.dtpFechaTrabajada5, 0);
            this.Controls.SetChildIndex(this.dtpFechaTrabajada6, 0);
            this.Controls.SetChildIndex(this.ckbYN, 0);
            this.Controls.SetChildIndex(this.ckbIC, 0);
            this.Controls.SetChildIndex(this.ckbFecha2, 0);
            this.Controls.SetChildIndex(this.ckbFecha3, 0);
            this.Controls.SetChildIndex(this.ckbFecha4, 0);
            this.Controls.SetChildIndex(this.ckbFecha5, 0);
            this.Controls.SetChildIndex(this.ckbFecha6, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.txtPuesto, 0);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRMotoristasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTransporteAdiggm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaAccion;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCompensacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCompensacion2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaTrabajada1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbObservacion;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbAño;
        private DataSets.DsTransporteAdiggm dsTransporteAdiggm;
        private System.Windows.Forms.BindingSource tRMotoristasBindingSource;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_MotoristasTableAdapter tR_MotoristasTableAdapter;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.ListBox listBoxDiasLibres;
        private System.Windows.Forms.TextBox txtCantidadLibres;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.DateTimePicker dtpFechaTrabajada2;
        private System.Windows.Forms.DateTimePicker dtpFechaTrabajada3;
        private System.Windows.Forms.DateTimePicker dtpFechaTrabajada6;
        private System.Windows.Forms.DateTimePicker dtpFechaTrabajada5;
        private System.Windows.Forms.DateTimePicker dtpFechaTrabajada4;
        private System.Windows.Forms.CheckBox ckbYN;
        private System.Windows.Forms.CheckBox ckbIC;
        private System.Windows.Forms.CheckBox ckbFecha2;
        private System.Windows.Forms.CheckBox ckbFecha3;
        private System.Windows.Forms.CheckBox ckbFecha5;
        private System.Windows.Forms.CheckBox ckbFecha4;
        private System.Windows.Forms.CheckBox ckbFecha6;
        private DataSets.DsTransporteAdiggmTableAdapters.TR_AccionesPersonalTableAdapter tR_AccionesPersonalTableAdapter;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPuesto;
    }
}
