
namespace ADIGGM.PRESUPUESTO.Transaccionales
{
    partial class frmPrestaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestaciones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPrestaciones = new System.Windows.Forms.DataGridView();
            this.idSueldo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPresupuesto1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaRetiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniosServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesesServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldoDiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preaviso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cesantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proporcionalCesantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proporcionalAguinaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacacionesProporcional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proporcional14Vo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrestaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRSelectPrestacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPresupuesto = new ADIGGM.DataSets.DsPresupuesto();
            this.pR_SelectPrestacionesTableAdapter = new ADIGGM.DataSets.DsPresupuestoTableAdapters.PR_SelectPrestacionesTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp14Vo = new System.Windows.Forms.DateTimePicker();
            this.dtpCesantia = new System.Windows.Forms.DateTimePicker();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectPrestacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvPrestaciones);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 330);
            this.panel1.TabIndex = 0;
            // 
            // dgvPrestaciones
            // 
            this.dgvPrestaciones.AllowUserToAddRows = false;
            this.dgvPrestaciones.AllowUserToDeleteRows = false;
            this.dgvPrestaciones.AllowUserToResizeRows = false;
            this.dgvPrestaciones.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrestaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrestaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSueldo1,
            this.idPresupuesto1,
            this.idEmpleado,
            this.codigo,
            this.nombre,
            this.fechaIngreso,
            this.sueldoBase,
            this.mesIngreso,
            this.diaIngreso,
            this.mesRetiro,
            this.diaRetiro,
            this.aniosServicio,
            this.mesesServicio,
            this.diasServicio,
            this.totalDias,
            this.sueldoDiario,
            this.preaviso,
            this.cesantia,
            this.proporcionalCesantia,
            this.proporcionalAguinaldo,
            this.vacacionesProporcional,
            this.proporcional14Vo,
            this.totalPrestaciones});
            this.dgvPrestaciones.DataSource = this.pRSelectPrestacionesBindingSource;
            this.dgvPrestaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrestaciones.Location = new System.Drawing.Point(0, 0);
            this.dgvPrestaciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPrestaciones.Name = "dgvPrestaciones";
            this.dgvPrestaciones.ReadOnly = true;
            this.dgvPrestaciones.RowHeadersVisible = false;
            this.dgvPrestaciones.RowHeadersWidth = 51;
            this.dgvPrestaciones.RowTemplate.Height = 24;
            this.dgvPrestaciones.Size = new System.Drawing.Size(1028, 330);
            this.dgvPrestaciones.TabIndex = 0;
            // 
            // idSueldo1
            // 
            this.idSueldo1.DataPropertyName = "idSueldo";
            this.idSueldo1.HeaderText = "idSueldo";
            this.idSueldo1.MinimumWidth = 6;
            this.idSueldo1.Name = "idSueldo1";
            this.idSueldo1.ReadOnly = true;
            this.idSueldo1.Visible = false;
            this.idSueldo1.Width = 125;
            // 
            // idPresupuesto1
            // 
            this.idPresupuesto1.DataPropertyName = "idPresupuesto";
            this.idPresupuesto1.HeaderText = "idPresupuesto";
            this.idPresupuesto1.MinimumWidth = 6;
            this.idPresupuesto1.Name = "idPresupuesto1";
            this.idPresupuesto1.ReadOnly = true;
            this.idPresupuesto1.Visible = false;
            this.idPresupuesto1.Width = 125;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "idEmpleado";
            this.idEmpleado.MinimumWidth = 6;
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Visible = false;
            this.idEmpleado.Width = 125;
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codigo.DataPropertyName = "Codigo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.codigo.HeaderText = "DNI";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 51;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombre.DataPropertyName = "Nombre";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 69;
            // 
            // fechaIngreso
            // 
            this.fechaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.fechaIngreso.DataPropertyName = "fechaIngreso";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.fechaIngreso.DefaultCellStyle = dataGridViewCellStyle4;
            this.fechaIngreso.HeaderText = "Fecha Ingreso";
            this.fechaIngreso.MinimumWidth = 6;
            this.fechaIngreso.Name = "fechaIngreso";
            this.fechaIngreso.ReadOnly = true;
            this.fechaIngreso.Width = 92;
            // 
            // sueldoBase
            // 
            this.sueldoBase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sueldoBase.DataPropertyName = "sueldoBase";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.sueldoBase.DefaultCellStyle = dataGridViewCellStyle5;
            this.sueldoBase.HeaderText = "Sueldo Base";
            this.sueldoBase.MinimumWidth = 6;
            this.sueldoBase.Name = "sueldoBase";
            this.sueldoBase.ReadOnly = true;
            this.sueldoBase.Width = 85;
            // 
            // mesIngreso
            // 
            this.mesIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.mesIngreso.DataPropertyName = "mesIngreso";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = null;
            this.mesIngreso.DefaultCellStyle = dataGridViewCellStyle6;
            this.mesIngreso.HeaderText = "Mes Ingreso";
            this.mesIngreso.MinimumWidth = 6;
            this.mesIngreso.Name = "mesIngreso";
            this.mesIngreso.ReadOnly = true;
            this.mesIngreso.Width = 83;
            // 
            // diaIngreso
            // 
            this.diaIngreso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diaIngreso.DataPropertyName = "diaIngreso";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = null;
            this.diaIngreso.DefaultCellStyle = dataGridViewCellStyle7;
            this.diaIngreso.HeaderText = "Día Ingreso";
            this.diaIngreso.MinimumWidth = 6;
            this.diaIngreso.Name = "diaIngreso";
            this.diaIngreso.ReadOnly = true;
            this.diaIngreso.Width = 81;
            // 
            // mesRetiro
            // 
            this.mesRetiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.mesRetiro.DataPropertyName = "mesRetiro";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.NullValue = null;
            this.mesRetiro.DefaultCellStyle = dataGridViewCellStyle8;
            this.mesRetiro.HeaderText = "Mes Retiro";
            this.mesRetiro.MinimumWidth = 6;
            this.mesRetiro.Name = "mesRetiro";
            this.mesRetiro.ReadOnly = true;
            this.mesRetiro.Width = 77;
            // 
            // diaRetiro
            // 
            this.diaRetiro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diaRetiro.DataPropertyName = "diaRetiro";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.NullValue = null;
            this.diaRetiro.DefaultCellStyle = dataGridViewCellStyle9;
            this.diaRetiro.HeaderText = "Día Retiro";
            this.diaRetiro.MinimumWidth = 6;
            this.diaRetiro.Name = "diaRetiro";
            this.diaRetiro.ReadOnly = true;
            this.diaRetiro.Width = 75;
            // 
            // aniosServicio
            // 
            this.aniosServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.aniosServicio.DataPropertyName = "aniosServicio";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = null;
            this.aniosServicio.DefaultCellStyle = dataGridViewCellStyle10;
            this.aniosServicio.HeaderText = "Años Servicio";
            this.aniosServicio.MinimumWidth = 6;
            this.aniosServicio.Name = "aniosServicio";
            this.aniosServicio.ReadOnly = true;
            this.aniosServicio.Width = 89;
            // 
            // mesesServicio
            // 
            this.mesesServicio.DataPropertyName = "mesesServicio";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mesesServicio.DefaultCellStyle = dataGridViewCellStyle11;
            this.mesesServicio.HeaderText = "Meses Servicio";
            this.mesesServicio.MinimumWidth = 6;
            this.mesesServicio.Name = "mesesServicio";
            this.mesesServicio.ReadOnly = true;
            this.mesesServicio.Width = 125;
            // 
            // diasServicio
            // 
            this.diasServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.diasServicio.DataPropertyName = "diasServicio";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.diasServicio.DefaultCellStyle = dataGridViewCellStyle12;
            this.diasServicio.HeaderText = "Días Servicio";
            this.diasServicio.MinimumWidth = 6;
            this.diasServicio.Name = "diasServicio";
            this.diasServicio.ReadOnly = true;
            this.diasServicio.Width = 88;
            // 
            // totalDias
            // 
            this.totalDias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalDias.DataPropertyName = "totalDias";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.totalDias.DefaultCellStyle = dataGridViewCellStyle13;
            this.totalDias.HeaderText = "Total Días";
            this.totalDias.MinimumWidth = 6;
            this.totalDias.Name = "totalDias";
            this.totalDias.ReadOnly = true;
            this.totalDias.Width = 76;
            // 
            // sueldoDiario
            // 
            this.sueldoDiario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.sueldoDiario.DataPropertyName = "sueldoDiario";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "C2";
            dataGridViewCellStyle14.NullValue = null;
            this.sueldoDiario.DefaultCellStyle = dataGridViewCellStyle14;
            this.sueldoDiario.HeaderText = "Sueldo Diario";
            this.sueldoDiario.MinimumWidth = 6;
            this.sueldoDiario.Name = "sueldoDiario";
            this.sueldoDiario.ReadOnly = true;
            this.sueldoDiario.Width = 87;
            // 
            // preaviso
            // 
            this.preaviso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.preaviso.DataPropertyName = "Preaviso";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "C2";
            dataGridViewCellStyle15.NullValue = null;
            this.preaviso.DefaultCellStyle = dataGridViewCellStyle15;
            this.preaviso.HeaderText = "Preaviso";
            this.preaviso.MinimumWidth = 6;
            this.preaviso.Name = "preaviso";
            this.preaviso.ReadOnly = true;
            this.preaviso.Width = 73;
            // 
            // cesantia
            // 
            this.cesantia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cesantia.DataPropertyName = "Cesantia";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "C2";
            dataGridViewCellStyle16.NullValue = null;
            this.cesantia.DefaultCellStyle = dataGridViewCellStyle16;
            this.cesantia.HeaderText = "Cesantía";
            this.cesantia.MinimumWidth = 6;
            this.cesantia.Name = "cesantia";
            this.cesantia.ReadOnly = true;
            this.cesantia.Width = 75;
            // 
            // proporcionalCesantia
            // 
            this.proporcionalCesantia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.proporcionalCesantia.DataPropertyName = "proporcionalCesantia";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Format = "C2";
            dataGridViewCellStyle17.NullValue = null;
            this.proporcionalCesantia.DefaultCellStyle = dataGridViewCellStyle17;
            this.proporcionalCesantia.HeaderText = "Prop. Cesantía";
            this.proporcionalCesantia.MinimumWidth = 6;
            this.proporcionalCesantia.Name = "proporcionalCesantia";
            this.proporcionalCesantia.ReadOnly = true;
            this.proporcionalCesantia.Width = 95;
            // 
            // proporcionalAguinaldo
            // 
            this.proporcionalAguinaldo.DataPropertyName = "proporcionalAguinaldo";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.Format = "C2";
            dataGridViewCellStyle18.NullValue = null;
            this.proporcionalAguinaldo.DefaultCellStyle = dataGridViewCellStyle18;
            this.proporcionalAguinaldo.HeaderText = "Prop. Aguinaldo";
            this.proporcionalAguinaldo.MinimumWidth = 6;
            this.proporcionalAguinaldo.Name = "proporcionalAguinaldo";
            this.proporcionalAguinaldo.ReadOnly = true;
            this.proporcionalAguinaldo.Width = 125;
            // 
            // vacacionesProporcional
            // 
            this.vacacionesProporcional.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.vacacionesProporcional.DataPropertyName = "vacacionesProporcional";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.Format = "C2";
            dataGridViewCellStyle19.NullValue = null;
            this.vacacionesProporcional.DefaultCellStyle = dataGridViewCellStyle19;
            this.vacacionesProporcional.HeaderText = "Vacaciones Prop.";
            this.vacacionesProporcional.MinimumWidth = 6;
            this.vacacionesProporcional.Name = "vacacionesProporcional";
            this.vacacionesProporcional.ReadOnly = true;
            this.vacacionesProporcional.Width = 106;
            // 
            // proporcional14Vo
            // 
            this.proporcional14Vo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.proporcional14Vo.DataPropertyName = "proporcional14Vo";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.Format = "C2";
            dataGridViewCellStyle20.NullValue = null;
            this.proporcional14Vo.DefaultCellStyle = dataGridViewCellStyle20;
            this.proporcional14Vo.HeaderText = "Prop. 14Vo";
            this.proporcional14Vo.MinimumWidth = 6;
            this.proporcional14Vo.Name = "proporcional14Vo";
            this.proporcional14Vo.ReadOnly = true;
            this.proporcional14Vo.Width = 78;
            // 
            // totalPrestaciones
            // 
            this.totalPrestaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalPrestaciones.DataPropertyName = "totalPrestaciones";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Format = "C2";
            dataGridViewCellStyle21.NullValue = null;
            this.totalPrestaciones.DefaultCellStyle = dataGridViewCellStyle21;
            this.totalPrestaciones.HeaderText = "Total Prestaciones";
            this.totalPrestaciones.MinimumWidth = 6;
            this.totalPrestaciones.Name = "totalPrestaciones";
            this.totalPrestaciones.ReadOnly = true;
            this.totalPrestaciones.Width = 110;
            // 
            // pRSelectPrestacionesBindingSource
            // 
            this.pRSelectPrestacionesBindingSource.DataMember = "PR_SelectPrestaciones";
            this.pRSelectPrestacionesBindingSource.DataSource = this.dsPresupuesto;
            // 
            // dsPresupuesto
            // 
            this.dsPresupuesto.DataSetName = "DsPresupuesto";
            this.dsPresupuesto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pR_SelectPrestacionesTableAdapter
            // 
            this.pR_SelectPrestacionesTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.btnRefrescar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtp14Vo);
            this.panel2.Controls.Add(this.dtpCesantia);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 119);
            this.panel2.TabIndex = 1;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.Transparent;
            this.btnRefrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.btnRefrescar.FlatAppearance.BorderSize = 0;
            this.btnRefrescar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRefrescar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefrescar.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(116, 29);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(77, 68);
            this.btnRefrescar.TabIndex = 18;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefrescar.UseVisualStyleBackColor = false;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(760, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fecha14vo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Fecha Cesantía:";
            // 
            // dtp14Vo
            // 
            this.dtp14Vo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp14Vo.Location = new System.Drawing.Point(826, 96);
            this.dtp14Vo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp14Vo.Name = "dtp14Vo";
            this.dtp14Vo.Size = new System.Drawing.Size(84, 20);
            this.dtp14Vo.TabIndex = 15;
            this.dtp14Vo.Value = new System.DateTime(2021, 6, 30, 0, 0, 0, 0);
            // 
            // dtpCesantia
            // 
            this.dtpCesantia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCesantia.Location = new System.Drawing.Point(649, 96);
            this.dtpCesantia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpCesantia.Name = "dtpCesantia";
            this.dtpCesantia.Size = new System.Drawing.Size(86, 20);
            this.dtpCesantia.TabIndex = 14;
            this.dtpCesantia.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
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
            this.btnSalir.Location = new System.Drawing.Point(24, 29);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 68);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrestaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 449);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrestaciones";
            this.Text = "Prestaciones";
            this.Load += new System.EventHandler(this.frmPrestaciones_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRSelectPrestacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPresupuesto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPrestaciones;
        private System.Windows.Forms.BindingSource pRSelectPrestacionesBindingSource;
        private DataSets.DsPresupuesto dsPresupuesto;
        private DataSets.DsPresupuestoTableAdapters.PR_SelectPrestacionesTableAdapter pR_SelectPrestacionesTableAdapter;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpCesantia;
        private System.Windows.Forms.DateTimePicker dtp14Vo;
        public System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSueldo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPresupuesto1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaRetiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniosServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesesServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldoDiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn preaviso;
        private System.Windows.Forms.DataGridViewTextBoxColumn cesantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn proporcionalCesantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn proporcionalAguinaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacacionesProporcional;
        private System.Windows.Forms.DataGridViewTextBoxColumn proporcional14Vo;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrestaciones;
    }
}