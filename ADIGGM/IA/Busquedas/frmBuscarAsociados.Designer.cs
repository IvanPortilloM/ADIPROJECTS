
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
            this.cidasociad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombreasoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccedulasocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dfechaingaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dfechasaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombcondaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombinstiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombdeptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombdivisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombtipopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cteletrabaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctelecelulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cextentrabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cteledomicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdireccasoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dfechanaciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsalarioasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nsalarioneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmuestclavDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dfechaingcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cconoccomoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cemailasocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombrecomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccoddelegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnombredelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cABuscarAsocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCA = new ADIGGM.DataSets.DsCA();
            this.cA_BuscarAsocTableAdapter = new ADIGGM.DataSets.DsCATableAdapters.CA_BuscarAsocTableAdapter();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRegistros)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsociados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABuscarAsocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCA)).BeginInit();
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
            this.dgvAsociados.AutoGenerateColumns = false;
            this.dgvAsociados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsociados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cidasociad,
            this.cnombreasoDataGridViewTextBoxColumn,
            this.ccedulasocDataGridViewTextBoxColumn,
            this.dfechaingaDataGridViewTextBoxColumn,
            this.dfechasaliDataGridViewTextBoxColumn,
            this.cnombcondaDataGridViewTextBoxColumn,
            this.cnombinstiDataGridViewTextBoxColumn,
            this.cnombdeptoDataGridViewTextBoxColumn,
            this.cnombdivisDataGridViewTextBoxColumn,
            this.cnombtipopDataGridViewTextBoxColumn,
            this.cteletrabaDataGridViewTextBoxColumn,
            this.ctelecelulDataGridViewTextBoxColumn,
            this.cextentrabDataGridViewTextBoxColumn,
            this.cteledomicDataGridViewTextBoxColumn,
            this.cdireccasoDataGridViewTextBoxColumn,
            this.dfechanaciDataGridViewTextBoxColumn,
            this.nsalarioasDataGridViewTextBoxColumn,
            this.nsalarioneDataGridViewTextBoxColumn,
            this.cmuestclavDataGridViewTextBoxColumn,
            this.dfechaingcDataGridViewTextBoxColumn,
            this.cconoccomoDataGridViewTextBoxColumn,
            this.cemailasocDataGridViewTextBoxColumn,
            this.aniosDataGridViewTextBoxColumn,
            this.mesesDataGridViewTextBoxColumn,
            this.diasDataGridViewTextBoxColumn,
            this.cnombrecomDataGridViewTextBoxColumn,
            this.ccoddelegaDataGridViewTextBoxColumn,
            this.cnombredelDataGridViewTextBoxColumn});
            this.dgvAsociados.DataSource = this.cABuscarAsocBindingSource;
            this.dgvAsociados.Location = new System.Drawing.Point(39, 123);
            this.dgvAsociados.Name = "dgvAsociados";
            this.dgvAsociados.ReadOnly = true;
            this.dgvAsociados.Size = new System.Drawing.Size(598, 202);
            this.dgvAsociados.TabIndex = 109;
            this.dgvAsociados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAsociados_KeyDown);
            // 
            // cidasociad
            // 
            this.cidasociad.DataPropertyName = "cidasociad";
            this.cidasociad.HeaderText = "Identificación";
            this.cidasociad.Name = "cidasociad";
            this.cidasociad.ReadOnly = true;
            // 
            // cnombreasoDataGridViewTextBoxColumn
            // 
            this.cnombreasoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnombreasoDataGridViewTextBoxColumn.DataPropertyName = "cnombreaso";
            this.cnombreasoDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.cnombreasoDataGridViewTextBoxColumn.Name = "cnombreasoDataGridViewTextBoxColumn";
            this.cnombreasoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccedulasocDataGridViewTextBoxColumn
            // 
            this.ccedulasocDataGridViewTextBoxColumn.DataPropertyName = "ccedulasoc";
            this.ccedulasocDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.ccedulasocDataGridViewTextBoxColumn.Name = "ccedulasocDataGridViewTextBoxColumn";
            this.ccedulasocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dfechaingaDataGridViewTextBoxColumn
            // 
            this.dfechaingaDataGridViewTextBoxColumn.DataPropertyName = "dfechainga";
            this.dfechaingaDataGridViewTextBoxColumn.HeaderText = "dfechainga";
            this.dfechaingaDataGridViewTextBoxColumn.Name = "dfechaingaDataGridViewTextBoxColumn";
            this.dfechaingaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dfechaingaDataGridViewTextBoxColumn.Visible = false;
            // 
            // dfechasaliDataGridViewTextBoxColumn
            // 
            this.dfechasaliDataGridViewTextBoxColumn.DataPropertyName = "dfechasali";
            this.dfechasaliDataGridViewTextBoxColumn.HeaderText = "dfechasali";
            this.dfechasaliDataGridViewTextBoxColumn.Name = "dfechasaliDataGridViewTextBoxColumn";
            this.dfechasaliDataGridViewTextBoxColumn.ReadOnly = true;
            this.dfechasaliDataGridViewTextBoxColumn.Visible = false;
            // 
            // cnombcondaDataGridViewTextBoxColumn
            // 
            this.cnombcondaDataGridViewTextBoxColumn.DataPropertyName = "cnombconda";
            this.cnombcondaDataGridViewTextBoxColumn.HeaderText = "Estátus";
            this.cnombcondaDataGridViewTextBoxColumn.Name = "cnombcondaDataGridViewTextBoxColumn";
            this.cnombcondaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnombinstiDataGridViewTextBoxColumn
            // 
            this.cnombinstiDataGridViewTextBoxColumn.DataPropertyName = "cnombinsti";
            this.cnombinstiDataGridViewTextBoxColumn.HeaderText = "cnombinsti";
            this.cnombinstiDataGridViewTextBoxColumn.Name = "cnombinstiDataGridViewTextBoxColumn";
            this.cnombinstiDataGridViewTextBoxColumn.ReadOnly = true;
            this.cnombinstiDataGridViewTextBoxColumn.Visible = false;
            // 
            // cnombdeptoDataGridViewTextBoxColumn
            // 
            this.cnombdeptoDataGridViewTextBoxColumn.DataPropertyName = "cnombdepto";
            this.cnombdeptoDataGridViewTextBoxColumn.HeaderText = "cnombdepto";
            this.cnombdeptoDataGridViewTextBoxColumn.Name = "cnombdeptoDataGridViewTextBoxColumn";
            this.cnombdeptoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cnombdeptoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cnombdivisDataGridViewTextBoxColumn
            // 
            this.cnombdivisDataGridViewTextBoxColumn.DataPropertyName = "cnombdivis";
            this.cnombdivisDataGridViewTextBoxColumn.HeaderText = "cnombdivis";
            this.cnombdivisDataGridViewTextBoxColumn.Name = "cnombdivisDataGridViewTextBoxColumn";
            this.cnombdivisDataGridViewTextBoxColumn.ReadOnly = true;
            this.cnombdivisDataGridViewTextBoxColumn.Visible = false;
            // 
            // cnombtipopDataGridViewTextBoxColumn
            // 
            this.cnombtipopDataGridViewTextBoxColumn.DataPropertyName = "cnombtipop";
            this.cnombtipopDataGridViewTextBoxColumn.HeaderText = "cnombtipop";
            this.cnombtipopDataGridViewTextBoxColumn.Name = "cnombtipopDataGridViewTextBoxColumn";
            this.cnombtipopDataGridViewTextBoxColumn.ReadOnly = true;
            this.cnombtipopDataGridViewTextBoxColumn.Visible = false;
            // 
            // cteletrabaDataGridViewTextBoxColumn
            // 
            this.cteletrabaDataGridViewTextBoxColumn.DataPropertyName = "cteletraba";
            this.cteletrabaDataGridViewTextBoxColumn.HeaderText = "cteletraba";
            this.cteletrabaDataGridViewTextBoxColumn.Name = "cteletrabaDataGridViewTextBoxColumn";
            this.cteletrabaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cteletrabaDataGridViewTextBoxColumn.Visible = false;
            // 
            // ctelecelulDataGridViewTextBoxColumn
            // 
            this.ctelecelulDataGridViewTextBoxColumn.DataPropertyName = "ctelecelul";
            this.ctelecelulDataGridViewTextBoxColumn.HeaderText = "ctelecelul";
            this.ctelecelulDataGridViewTextBoxColumn.Name = "ctelecelulDataGridViewTextBoxColumn";
            this.ctelecelulDataGridViewTextBoxColumn.ReadOnly = true;
            this.ctelecelulDataGridViewTextBoxColumn.Visible = false;
            // 
            // cextentrabDataGridViewTextBoxColumn
            // 
            this.cextentrabDataGridViewTextBoxColumn.DataPropertyName = "cextentrab";
            this.cextentrabDataGridViewTextBoxColumn.HeaderText = "cextentrab";
            this.cextentrabDataGridViewTextBoxColumn.Name = "cextentrabDataGridViewTextBoxColumn";
            this.cextentrabDataGridViewTextBoxColumn.ReadOnly = true;
            this.cextentrabDataGridViewTextBoxColumn.Visible = false;
            // 
            // cteledomicDataGridViewTextBoxColumn
            // 
            this.cteledomicDataGridViewTextBoxColumn.DataPropertyName = "cteledomic";
            this.cteledomicDataGridViewTextBoxColumn.HeaderText = "cteledomic";
            this.cteledomicDataGridViewTextBoxColumn.Name = "cteledomicDataGridViewTextBoxColumn";
            this.cteledomicDataGridViewTextBoxColumn.ReadOnly = true;
            this.cteledomicDataGridViewTextBoxColumn.Visible = false;
            // 
            // cdireccasoDataGridViewTextBoxColumn
            // 
            this.cdireccasoDataGridViewTextBoxColumn.DataPropertyName = "cdireccaso";
            this.cdireccasoDataGridViewTextBoxColumn.HeaderText = "cdireccaso";
            this.cdireccasoDataGridViewTextBoxColumn.Name = "cdireccasoDataGridViewTextBoxColumn";
            this.cdireccasoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cdireccasoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dfechanaciDataGridViewTextBoxColumn
            // 
            this.dfechanaciDataGridViewTextBoxColumn.DataPropertyName = "dfechanaci";
            this.dfechanaciDataGridViewTextBoxColumn.HeaderText = "dfechanaci";
            this.dfechanaciDataGridViewTextBoxColumn.Name = "dfechanaciDataGridViewTextBoxColumn";
            this.dfechanaciDataGridViewTextBoxColumn.ReadOnly = true;
            this.dfechanaciDataGridViewTextBoxColumn.Visible = false;
            // 
            // nsalarioasDataGridViewTextBoxColumn
            // 
            this.nsalarioasDataGridViewTextBoxColumn.DataPropertyName = "nsalarioas";
            this.nsalarioasDataGridViewTextBoxColumn.HeaderText = "nsalarioas";
            this.nsalarioasDataGridViewTextBoxColumn.Name = "nsalarioasDataGridViewTextBoxColumn";
            this.nsalarioasDataGridViewTextBoxColumn.ReadOnly = true;
            this.nsalarioasDataGridViewTextBoxColumn.Visible = false;
            // 
            // nsalarioneDataGridViewTextBoxColumn
            // 
            this.nsalarioneDataGridViewTextBoxColumn.DataPropertyName = "nsalarione";
            this.nsalarioneDataGridViewTextBoxColumn.HeaderText = "nsalarione";
            this.nsalarioneDataGridViewTextBoxColumn.Name = "nsalarioneDataGridViewTextBoxColumn";
            this.nsalarioneDataGridViewTextBoxColumn.ReadOnly = true;
            this.nsalarioneDataGridViewTextBoxColumn.Visible = false;
            // 
            // cmuestclavDataGridViewTextBoxColumn
            // 
            this.cmuestclavDataGridViewTextBoxColumn.DataPropertyName = "cmuestclav";
            this.cmuestclavDataGridViewTextBoxColumn.HeaderText = "cmuestclav";
            this.cmuestclavDataGridViewTextBoxColumn.Name = "cmuestclavDataGridViewTextBoxColumn";
            this.cmuestclavDataGridViewTextBoxColumn.ReadOnly = true;
            this.cmuestclavDataGridViewTextBoxColumn.Visible = false;
            // 
            // dfechaingcDataGridViewTextBoxColumn
            // 
            this.dfechaingcDataGridViewTextBoxColumn.DataPropertyName = "dfechaingc";
            this.dfechaingcDataGridViewTextBoxColumn.HeaderText = "dfechaingc";
            this.dfechaingcDataGridViewTextBoxColumn.Name = "dfechaingcDataGridViewTextBoxColumn";
            this.dfechaingcDataGridViewTextBoxColumn.ReadOnly = true;
            this.dfechaingcDataGridViewTextBoxColumn.Visible = false;
            // 
            // cconoccomoDataGridViewTextBoxColumn
            // 
            this.cconoccomoDataGridViewTextBoxColumn.DataPropertyName = "cconoccomo";
            this.cconoccomoDataGridViewTextBoxColumn.HeaderText = "cconoccomo";
            this.cconoccomoDataGridViewTextBoxColumn.Name = "cconoccomoDataGridViewTextBoxColumn";
            this.cconoccomoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cconoccomoDataGridViewTextBoxColumn.Visible = false;
            // 
            // cemailasocDataGridViewTextBoxColumn
            // 
            this.cemailasocDataGridViewTextBoxColumn.DataPropertyName = "cemailasoc";
            this.cemailasocDataGridViewTextBoxColumn.HeaderText = "cemailasoc";
            this.cemailasocDataGridViewTextBoxColumn.Name = "cemailasocDataGridViewTextBoxColumn";
            this.cemailasocDataGridViewTextBoxColumn.ReadOnly = true;
            this.cemailasocDataGridViewTextBoxColumn.Visible = false;
            // 
            // aniosDataGridViewTextBoxColumn
            // 
            this.aniosDataGridViewTextBoxColumn.DataPropertyName = "anios";
            this.aniosDataGridViewTextBoxColumn.HeaderText = "anios";
            this.aniosDataGridViewTextBoxColumn.Name = "aniosDataGridViewTextBoxColumn";
            this.aniosDataGridViewTextBoxColumn.ReadOnly = true;
            this.aniosDataGridViewTextBoxColumn.Visible = false;
            // 
            // mesesDataGridViewTextBoxColumn
            // 
            this.mesesDataGridViewTextBoxColumn.DataPropertyName = "meses";
            this.mesesDataGridViewTextBoxColumn.HeaderText = "meses";
            this.mesesDataGridViewTextBoxColumn.Name = "mesesDataGridViewTextBoxColumn";
            this.mesesDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesesDataGridViewTextBoxColumn.Visible = false;
            // 
            // diasDataGridViewTextBoxColumn
            // 
            this.diasDataGridViewTextBoxColumn.DataPropertyName = "dias";
            this.diasDataGridViewTextBoxColumn.HeaderText = "dias";
            this.diasDataGridViewTextBoxColumn.Name = "diasDataGridViewTextBoxColumn";
            this.diasDataGridViewTextBoxColumn.ReadOnly = true;
            this.diasDataGridViewTextBoxColumn.Visible = false;
            // 
            // cnombrecomDataGridViewTextBoxColumn
            // 
            this.cnombrecomDataGridViewTextBoxColumn.DataPropertyName = "cnombrecom";
            this.cnombrecomDataGridViewTextBoxColumn.HeaderText = "cnombrecom";
            this.cnombrecomDataGridViewTextBoxColumn.Name = "cnombrecomDataGridViewTextBoxColumn";
            this.cnombrecomDataGridViewTextBoxColumn.ReadOnly = true;
            this.cnombrecomDataGridViewTextBoxColumn.Visible = false;
            // 
            // ccoddelegaDataGridViewTextBoxColumn
            // 
            this.ccoddelegaDataGridViewTextBoxColumn.DataPropertyName = "ccoddelega";
            this.ccoddelegaDataGridViewTextBoxColumn.HeaderText = "ccoddelega";
            this.ccoddelegaDataGridViewTextBoxColumn.Name = "ccoddelegaDataGridViewTextBoxColumn";
            this.ccoddelegaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccoddelegaDataGridViewTextBoxColumn.Visible = false;
            // 
            // cnombredelDataGridViewTextBoxColumn
            // 
            this.cnombredelDataGridViewTextBoxColumn.DataPropertyName = "cnombredel";
            this.cnombredelDataGridViewTextBoxColumn.HeaderText = "cnombredel";
            this.cnombredelDataGridViewTextBoxColumn.Name = "cnombredelDataGridViewTextBoxColumn";
            this.cnombredelDataGridViewTextBoxColumn.ReadOnly = true;
            this.cnombredelDataGridViewTextBoxColumn.Visible = false;
            // 
            // cABuscarAsocBindingSource
            // 
            this.cABuscarAsocBindingSource.DataMember = "CA_BuscarAsoc";
            this.cABuscarAsocBindingSource.DataSource = this.dsCA;
            // 
            // dsCA
            // 
            this.dsCA.DataSetName = "DsCA";
            this.dsCA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cA_BuscarAsocTableAdapter
            // 
            this.cA_BuscarAsocTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dsCA)).EndInit();
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
        private DataSets.DsCA dsCA;
        private DataSets.DsCATableAdapters.CA_BuscarAsocTableAdapter cA_BuscarAsocTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidasociad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombreasoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccedulasocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfechaingaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfechasaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombcondaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombinstiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombdeptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombdivisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombtipopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cteletrabaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctelecelulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cextentrabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cteledomicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdireccasoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfechanaciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsalarioasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nsalarioneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmuestclavDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfechaingcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cconoccomoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cemailasocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombrecomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccoddelegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnombredelDataGridViewTextBoxColumn;
    }
}
