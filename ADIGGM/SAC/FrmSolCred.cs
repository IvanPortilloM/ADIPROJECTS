namespace ADIGGM.SAC
{
    using ADIGGM.CapaDatos;
    using ADIGGM.Clases;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Drawing.Printing;
    using System.Globalization;
    using System.IO;
    using System.Management;
    using System.Text;
    using System.Windows.Forms;
    public partial class FrmSolCred : FrmPrincipal, IContract
    {
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        // Rutina para proporcionar al procesador de informes para guardar una imagen por cada página del informe.
        private Stream CreateStream(string name,
                                    string fileNameExtension, 
                                    Encoding encoding,
                                    string mimeType, 
                                    bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }
        private readonly RepositorioCodeas _repoCodeas = new RepositorioCodeas();
        private readonly RepositorioCA _repoCA = new RepositorioCA();
        //campos usados para editar préstamos
        string Identidad = "";
        int IdAsociado = 0, IdSolicitud = 0, Capitalizacion = 24, FrecuPago = 15;
        decimal TotalAport = 0, TotalAhorroNav = 0, TotalCred = 0, TasaInt = 14;
        bool PermitirMontoPres = true, PermitirPrestamito = false, PermitirPrestamitoPend = false;
        DateTime Fecha = DateTime.Now;
        readonly bool Editar = false, EditarDatosAct = false;
        string TipoSolicitud = "";
        public FrmSolCred(bool Editar, bool EditarDatosAct, int IdAsociado, int IdSolicitud, string Identidad, string TipoSolicitud)
        {
            InitializeComponent();
            this.Editar = Editar;
            this.EditarDatosAct = EditarDatosAct;
            this.IdAsociado = IdAsociado;
            this.IdSolicitud = IdSolicitud;
            this.Identidad = Identidad;
            this.TipoSolicitud = TipoSolicitud;
        }
        private void mskId_Leave(object sender, EventArgs e)
        {
            var debe = 0;
            // Copiar el texto del TextBox al portapapeles (SetText lanza con texto vacío)
            if (!string.IsNullOrEmpty(mskId.Text))
                Clipboard.SetText(mskId.Text);
            if (!Editar && !EditarDatosAct)
            {
                cambioTipoSol();
                this.LlenarDgv();
                string str = this.mskId.Text.Replace("-", "").Replace(" ", "");
                if (str != "")
                    this.btnEstado.Enabled = true;
                else if (str == "")
                    this.btnEstado.Enabled = false;
            }

            if(dgvCreditos.RowCount > 0)
            {                
                foreach (DataGridViewRow row in dgvCreditos.Rows)
                {
                    if (row.Cells["ccodigogest"].Value.ToString() != "0000" )
                    {
                        debe += 1;
                    }
                }
            }

            if (debe != 0)
            {
                MessageBox.Show("El Asociado tiene una o más cuotas pendientes sin pagar", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>Suma de cuotas en tránsito ("T") y pendientes ("P") por crédito, vía repositorio
        /// parametrizado (antes era un EXEC por concatenación con la cadena legacy de Settings).</summary>
        private void CalcularTransitoPendientes(DataGridView dgvCredito, string colOperacion, string colTransito, string colPendientes)
        {
            foreach (DataGridViewRow row in dgvCredito.Rows)
            {
                decimal ncuotaT = 0, ncuotaP = 0;
                string numOperacion = row.Cells[colOperacion].Value.ToString();

                foreach (DataRow pRow in _repoCA.CargarPlanCredito(numOperacion, "T").Rows)
                {
                    ncuotaT += Convert.ToDecimal(pRow["ncuota"]);
                }

                foreach (DataRow pRow in _repoCA.CargarPlanCredito(numOperacion, "P").Rows)
                {
                    ncuotaP += Convert.ToDecimal(pRow["ncuota"]);
                }

                row.Cells[colTransito].Value = ncuotaT;
                row.Cells[colPendientes].Value = ncuotaP;
            }
        }
        private void GetAllPrinterList()
        {
            ManagementScope objScope = new ManagementScope(ManagementPath.DefaultPath); //For the local Access
            objScope.Connect();

            SelectQuery selectQuery = new SelectQuery();
            selectQuery.QueryString = "Select * from win32_Printer";
            ManagementObjectSearcher MOS = new ManagementObjectSearcher(objScope, selectQuery);
            ManagementObjectCollection MOC = MOS.Get();
            foreach (ManagementObject mo in MOC)
            {
                cboPrinterList.Items.Add(mo["Name"].ToString());
            }
            PrintDocument printDocument = new PrintDocument();

            var defaultPrinter = printDocument.PrinterSettings.PrinterName;
            cboPrinterList.Text = defaultPrinter;
        }
        private void FrmSolCred_Load(object sender, EventArgs e)
        {
            if (!Editar && !EditarDatosAct)
            {
                txtMontoPrestamo.Text = $"{0:n}";
                txtConsumos.Text = $"{0:n}";
                txtTotDesemb.Text = $"{0:n}";
                txtNCuotaSug.Text = $"{0:n0}";
                txtNCuotaAsig.Text = $"{0:n0}";
                txtCuotaNiv.Text = $"{0:n}";
                txtTasaInt.Text = $"{TasaInt:n}";
                txtNCapitalizacion.Text = $"{Capitalizacion:n0}";
                mskFecha.Text = Fecha.ToString("dd/MM/yyyy");
                dgvAportes.Visible = true;
                dgvCreditos.Visible = true;
                dgvAportes.Dock = DockStyle.Fill;
                dgvCreditos.Dock = DockStyle.Fill;
                cboSolicitud.SelectedIndex = 0;
                btnGenerar.Enabled = false;
                btnImprimir.Enabled = false;
                sACFechasCorteBindingSource.DataMember = "";
                sACFechasCorteBindingSource.DataSource = _repoCodeas.ListarFechasCorteActivas();
                cboFormalizacion.SelectedIndex = 0;
                dtpFormalizacion.Visible = false;
                dtpPrimerPago.Enabled = false;

                LlenarTotales("", "dgvAportes", "dgvCreditos");

                foreach (DataGridViewRow row in dgvCreditos.Rows)
                {
                    if (Convert.ToBoolean((row.Cells["Marcar"] as DataGridViewCheckBoxCell).Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                        row.DefaultCellStyle.BackColor = Color.White;
                }
                mskId.Focus();
            }
            else
                if (Editar && !EditarDatosAct)
            {
                LlenarDgvEditar();
                LlenarTotales("", "dgvAportesEdit", "dgvCreditosEdit");
                cboSolicitud.Enabled = false;
                cboSolicitud.SelectedItem = TipoSolicitud;
                cboFormalizacion.Visible = false;
                lblcperiodpag.Visible = false;
                foreach (DataGridViewRow row in dgvCreditosEdit.Rows)
                {
                    if (Convert.ToBoolean((row.Cells["seleccionado"] as DataGridViewCheckBoxCell).Value))
                    {
                        row.DefaultCellStyle.BackColor = Color.YellowGreen;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else
                        row.DefaultCellStyle.BackColor = Color.White;
                }
            }
            else
                if (Editar && EditarDatosAct)
            {
                LlenarDgvEditar();
                LlenarTotales("", "dgvAportes", "dgvCreditos");
                cboSolicitud.Enabled = false;
                cboSolicitud.SelectedItem = TipoSolicitud;
                cboFormalizacion.Visible = false;
                lblcperiodpag.Visible = false;
            }
            GetAllPrinterList();
        }   
        public bool ValidarCantidad(int code)
        {
            bool resultado;

            if ((((code >= 48) && (code <= 57)) || (code == 8))) //se evalúan las teclas válidas
            {
                resultado = false;
            }
            else if (!PermitirMontoPres)
            {
                resultado = PermitirMontoPres;
            }
            else
            {
                resultado = true;
            }
            return resultado;
        }
        public bool ValidarMonto(int code, string NombreControl)
        {
            bool resultado = true;
            Control[] ctrls = Controls.Find(NombreControl, true);

            if (ctrls.Length > 0)
            {
                TextBox ControlTexbox = ctrls[0] as TextBox;

                if (code == 46 && ControlTexbox.Text == "") //se evalúa si es punto y revisa si el texto está vacío.
                {
                    resultado = true;
                }
                if (code == 46 && ControlTexbox.Text.Contains(".")) //se evalúa si es punto y revisa si ya existe en el textbox
                {
                    resultado = true;
                }
                else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evalúan las teclas válidas
                {
                    resultado = false;
                }
                else if (!PermitirMontoPres)
                {
                    resultado = PermitirMontoPres;
                }
                else
                {
                    resultado = true;
                }
            }
                return resultado;
        }
        public void Ejecutar(int Var1, int Var2, int Var3, DateTime Fec1, DateTime Fec2, string Var4)
        {
            this.mskId.Text = Var4;
        }
        public void LlenarDgv()
        {
            txtNombreCompleto.DataBindings.Clear();
            txtAreaTrab.DataBindings.Clear();
            txtDomicilio.DataBindings.Clear();
            mskCel.DataBindings.Clear();
            cboEstadoCivil.DataBindings.Clear();
            cboTipoEmpleado.DataBindings.Clear();

            string t = this.mskId.Text.Replace("-", "").Replace(" ", "");

            if (t != Identidad)
            {
                int ExisteAsoc = 0;

                // El DataSource de los grids se asigna aquí y NO en el Designer (gotcha del diseñador de VS)
                cODSlcAportesBindingSource.DataMember = "";
                cODSlcAportesBindingSource.DataSource = _repoCodeas.CargarAportesAsociado(t);
                dgvAportes.DataSource = cODSlcAportesBindingSource;
                cODSlcCreditosBindingSource.DataMember = "";
                cODSlcCreditosBindingSource.DataSource = _repoCodeas.CargarCreditosAsociado(t);
                dgvCreditos.DataSource = cODSlcCreditosBindingSource;
                cODSlcASMaestrasBindingSource.DataMember = "";
                cODSlcASMaestrasBindingSource.DataSource = _repoCodeas.CargarASMaestras(t);
                sACAsociadosBindingSource.DataMember = "";
                sACAsociadosBindingSource.DataSource = _repoCodeas.CargarAsociadoPorCodigo(t);

                CalcularTransitoPendientes(dgvCreditos, "cnumoperac", "Transito", "Pendientes");

                ExisteAsoc = _repoCodeas.ExisteAsociado(t);

                if (ExisteAsoc == 0)
                {
                    Limpiar();
                    mskId.Text = t;
                    MessageBox.Show("El número de identidad ingresado no existe", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(ExisteAsoc == 1)
                {
                    txtNombreCompleto.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "NombreCompleto", false));
                    txtAreaTrab.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "AreaTrabajo", false));
                    mskCel.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "Telefono", false));
                    txtDomicilio.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "Domicilio", false));
                    cboEstadoCivil.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "EstadoCivil", false));
                    cboTipoEmpleado.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "TipoEmpleado", false));
                }
                else if (ExisteAsoc == 2)
                {
                    txtNombreCompleto.DataBindings.Add(new Binding("Text", this.cODSlcASMaestrasBindingSource, "cnombreaso", false));
                    txtAreaTrab.DataBindings.Add(new Binding("Text", this.cODSlcASMaestrasBindingSource, "cnombdivis", false));
                    mskCel.Text = "";
                    txtDomicilio.DataBindings.Add(new Binding("Text", this.cODSlcASMaestrasBindingSource, "cdireccaso", false));
                    cboEstadoCivil.SelectedIndex = -1;
                    cboTipoEmpleado.SelectedIndex = -1;
                }
                LlenarTotales("", "dgvAportes", "dgvCreditos");
            }else if (t == "")
            {
                cODSlcAportesBindingSource.DataMember = "";
                cODSlcAportesBindingSource.DataSource = _repoCodeas.CargarAportesAsociado(t);
                dgvAportes.DataSource = cODSlcAportesBindingSource;
                cODSlcCreditosBindingSource.DataMember = "";
                cODSlcCreditosBindingSource.DataSource = _repoCodeas.CargarCreditosAsociado(t);
                dgvCreditos.DataSource = cODSlcCreditosBindingSource;
            }
            Identidad = t;
        }
        private void LlenarDgvEditar()
        {
            mskId.Enabled = false;
            btnBuscar.Enabled = false;
            cboEstadoCivil.DataBindings.Clear();
            mskCel.DataBindings.Clear();
            cboTipoEmpleado.DataBindings.Clear();
            txtNombreCompleto.DataBindings.Clear();
            txtAreaTrab.DataBindings.Clear();
            txtDomicilio.DataBindings.Clear();
            txtanios.DataBindings.Clear();
            txtmeses.DataBindings.Clear();
            txtdias.DataBindings.Clear();

            string Codigo = this.Identidad.Replace("-", "").Replace(" ", "");

            sACAsociadosBindingSource.DataMember = "";
            sACAsociadosBindingSource.DataSource = _repoCodeas.CargarAsociadoPorCodigo(Codigo);
            sACSolicitudesBindingSource.DataMember = "";
            sACSolicitudesBindingSource.DataSource = _repoCodeas.CargarSolicitud(IdSolicitud);

            if (EditarDatosAct == false)
            {
                dgvAportesEdit.Visible = true;
                dgvCreditosEdit.Visible = true;
                dgvAportesEdit.Dock = DockStyle.Fill;
                dgvCreditosEdit.Dock = DockStyle.Fill;
                sACAportesBindingSource.DataMember = "";
                sACAportesBindingSource.DataSource = _repoCodeas.CargarEstadoFinancieroAportes(IdSolicitud);
                dgvAportesEdit.DataSource = sACAportesBindingSource;
                sACCreditosBindingSource.DataMember = "";
                sACCreditosBindingSource.DataSource = _repoCodeas.CargarEstadoFinancieroCreditos(IdSolicitud);
                dgvCreditosEdit.DataSource = sACCreditosBindingSource;

                // Fix: antes los acumuladores se declaraban fuera del loop y los valores de
                // Tránsito/Pendientes se iban sumando de una fila a la siguiente (montos inflados)
                CalcularTransitoPendientes(dgvCreditosEdit, "NumOperacion", "Transito1", "Pendientes1");
            }
            else
            {
                dgvAportes.Visible = true;
                dgvCreditos.Visible = true;
                dgvAportes.Dock = DockStyle.Fill;
                dgvCreditos.Dock = DockStyle.Fill;
                cODSlcAportesBindingSource.DataMember = "";
                cODSlcAportesBindingSource.DataSource = _repoCodeas.CargarAportesAsociado(Codigo);
                dgvAportes.DataSource = cODSlcAportesBindingSource;
                cODSlcCreditosBindingSource.DataMember = "";
                cODSlcCreditosBindingSource.DataSource = _repoCodeas.CargarCreditosAsociado(Codigo);
                dgvCreditos.DataSource = cODSlcCreditosBindingSource;

                CalcularTransitoPendientes(dgvCreditos, "cnumoperac", "Transito", "Pendientes");
            }
            //------------------------------------------------------------------------------------------------
            mskId.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "CodigoAsociado", false));
            txtMontoPrestamo.DataBindings.Add(new Binding("Text", this.sACSolicitudesBindingSource, "CantSolicitada", true, DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            mskFecha.DataBindings.Add(new Binding("Text", this.sACSolicitudesBindingSource, "FechaSolicitud", true, DataSourceUpdateMode.OnPropertyChanged, null, "dd/MM/yyyy"));
            cboEstadoCivil.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "EstadoCivil", false));
            cboMotivoPres.DataBindings.Add(new Binding("Text", this.sACSolicitudesBindingSource, "Motivo", false));
            mskCel.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "Telefono", false));
            cboTipoEmpleado.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "TipoEmpleado", false));
            //------------------------------------------------------------------------------------------------
            txtNombreCompleto.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "NombreCompleto", false));
            txtAreaTrab.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "AreaTrabajo", false));
            txtDomicilio.DataBindings.Add(new Binding("Text", this.sACAsociadosBindingSource, "Domicilio", false));
            txtanios.DataBindings.Add(new Binding("Text", this.sACSolicitudesBindingSource, "Anios", false));
            txtmeses.DataBindings.Add(new Binding("Text", this.sACSolicitudesBindingSource, "Meses", false));
            txtdias.DataBindings.Add(new Binding("Text", this.sACSolicitudesBindingSource, "Dias", false));
            //------------------------------------------------------------------------------------------------
            txtNCuotaAsig.DataBindings.Add(new Binding("Text", this.sACSolicitudesBindingSource, "Periodo", false));
            txtNCuotaSug.DataBindings.Add(new Binding("Text", this.sACSolicitudesBindingSource, "PeriodoSug", false));
            txtTasaInt.DataBindings.Add(new Binding("Text", this.sACSolicitudesBindingSource, "Tasa", false));
            TasaInt = Convert.ToDecimal(txtTasaInt.Text);
            txtNCapitalizacion.DataBindings.Add(new Binding("Text", this.sACSolicitudesBindingSource, "Capitalizacion", false));
            dtpFormalizacion.DataBindings.Add(new Binding("Value", this.sACSolicitudesBindingSource, "dfecformal", false));
            dtpPrimerPago.DataBindings.Add(new Binding("Value", this.sACSolicitudesBindingSource, "dfecpripag", false));
            Capitalizacion = Convert.ToInt32(txtNCapitalizacion.Text);
            cboFormalizacion.Visible = false;
        }
        public void LlenarTotales(string CtrlTxt, string CtrlDgvApor, string CtrlDgvCred)
        {
            Control[] DgvApor = Controls.Find(CtrlDgvApor, true);
            Control[] DgvCred = Controls.Find(CtrlDgvCred, true);
            DataGridView dgvAporte = DgvApor[0] as DataGridView;
            DataGridView dgvCredito = DgvCred[0] as DataGridView;

            //------------------------------------------
            Numalet let;
            let = new Numalet();
            let.MascaraSalidaDecimal = "00/100 Lempiras";
            let.SeparadorDecimalSalida = "Con";
            let.ConvertirDecimales = false;
            //------------------------------------------
            string TotalAportDgv = "", CodigoDgv = "", SeleccionDgv = "", SaldoDgv = "", srtEnTransito = "", srtPendientes = "";

            if ((Editar == false && EditarDatosAct == false) || (Editar == true && EditarDatosAct == true))
            {
                TotalAportDgv = "nmtoprinci";
                CodigoDgv = "codigo";
                SaldoDgv = "nsaldocred";
                SeleccionDgv = "Marcar";
                srtEnTransito = "Transito";
                srtPendientes = "Pendientes";
            }
            else
                if(Editar == true && EditarDatosAct == false)
            {
                TotalAportDgv = "principal";
                CodigoDgv = "Operacion";
                SaldoDgv = "saldo";
                SeleccionDgv = "seleccionado";
                srtEnTransito = "Transito1";
                srtPendientes = "Pendientes1";
            }
            //------------------------------------------
            TotalAport = 0;TotalAhorroNav = 0; TotalCred = 0;
            decimal MontoPres, TotalDesem = 0, Interes = 0, CuotaNiv = 0, enTransito = 0, Pendientes = 0;
            string MontoPrestamo = txtMontoPrestamo.Text;

            MontoPrestamo = MontoPrestamo.Replace(",", "");
            string t = this.mskId.Text.Replace("-", "").Replace(" ", "");

            if (MontoPrestamo.Length < 1 || MontoPrestamo == "." & ((cboSolicitud.Text != "PRÉSTAMO" || cboSolicitud.Text != "RETIRO PARCIAL")))
            {
                MontoPres = 0;
                txtCuotaNiv.Text = $"{0:n}";
                if (cboSolicitud.Text == "PRÉSTAMO" || cboSolicitud.Text == "REFINANCIAMIENTO" || cboSolicitud.Text == "RETIRO PARCIAL")
                {
                    btnGenerar.Enabled = false;
                    btnImprimir.Enabled = false;
                }
            }
            else
            {
                MontoPres = Convert.ToDecimal(MontoPrestamo);
                if (t == "")
                {
                    btnGenerar.Enabled = false;
                    btnImprimir.Enabled = false;
                }
                else
                {
                    //if (cboSolicitud.Text != "PRÉSTAMO" && cboSolicitud.Text != "REFINANCIAMIENTO" && cboSolicitud.Text != "RETIRO PARCIAL")
                    //{
                        btnGenerar.Enabled = true;
                        btnImprimir.Enabled = true;
                    //}
                }
                foreach (var series in chartPosFin.Series)
                {
                    series.Points.Clear();
                }

                if (dgvAporte.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvAporte.Rows)
                    {
                        this.TotalAport += Convert.ToDecimal(string.Format("{0:n}", row.Cells[TotalAportDgv].Value));
                        if (Convert.ToString(row.Cells[CodigoDgv].Value) == "0003-001")
                            TotalAhorroNav += Convert.ToDecimal(string.Format("{0:n}", row.Cells[TotalAportDgv].Value));
                    }
                    if (dgvCredito.RowCount > 0)
                    {
                        foreach (DataGridViewRow row in dgvCredito.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[SeleccionDgv].Value) == true)
                            {
                                TotalDesem += Convert.ToDecimal($"{row.Cells[SaldoDgv].Value:n}");
                            }

                            TotalCred += Convert.ToDecimal($"{row.Cells[SaldoDgv].Value:n}");
                            enTransito += Convert.ToDecimal($"{row.Cells[srtEnTransito].Value:n}");
                            Pendientes += Convert.ToDecimal($"{row.Cells[srtPendientes].Value:n}");
                        }
                        lblTotalCreditos.Text = "| Total de Créditos: " + $"{TotalCred:n} | En Tránsito: " + $"{enTransito:n} | Saldos Pendientes: " + $"{Pendientes:n} | Total: " + $"{enTransito+Pendientes:n} |";
                        txtConsumos.Text = $"{TotalDesem:n}";
                        txtTotDesemb.Text = $"{(MontoPres - TotalDesem):n}";
                        chartPosFin.Series["Posicion"].Points.AddXY("Créditos", TotalCred);
                    }
                    else
                    {
                        lblTotalCreditos.Text = "| Total de Créditos: " + $"{0:n} | En Tránsito: " + $"{0:n} | Saldos Pendientes: " + $"{0:n} | Total: " + $"{0:n} |";
                        txtConsumos.Text = $"{0:n}";
                        txtTotDesemb.Text = $"{(MontoPres - 0):n}";
                    }
                    lblTotalAportes.Text = "| Total de Aportes: " + $"{TotalAport:n} |";
                    chartPosFin.Series["Posicion"].Points.AddXY("Patrimonio", TotalAport - TotalAhorroNav);
                    lblTotalPosFin.Text = "| Posición Financiera Neta: " + $"{((TotalAport - TotalAhorroNav) - TotalCred):n}" + " | 80%: " + $"{((TotalAport - TotalAhorroNav) * Convert.ToDecimal(0.8)):n} |";
                }
                else
                {
                    lblTotalAportes.Text = "| Total de Aportes: " + $"{0:n} |";
                    lblTotalCreditos.Text = "| Total de Créditos: " + $"{0:n} | Saldos en Tránsito: " + $"{0:n} | Saldos Pendientes: " + $"{0:n} | Total: " + $"{0:n} |";
                    txtConsumos.Text = $"{0:n}";
                    txtTotDesemb.Text = $"{(MontoPres - 0):n}";
                    lblTotalPosFin.Text = "| Posición Financiera Neta: " + $"{0:n}" + " | 80%: " + $"{0:n} |";
                }

                if (MontoPres < 1)
                {
                    txtNCuotaSug.Text = $"{0:n0}";
                    if (cboSolicitud.Text == "PRÉSTAMO" || cboSolicitud.Text == "REFINANCIAMIENTO" || cboSolicitud.Text == "RETIRO PARCIAL")
                    {
                        btnGenerar.Enabled = false;
                        btnImprimir.Enabled = false;
                    }
                }
                else if (MontoPres <= 10000)
                {
                    txtNCuotaSug.Text = $"{24:n0}";
                }
                else if (MontoPres <= 25000)
                {
                    txtNCuotaSug.Text = $"{48:n0}";
                }
                else if (MontoPres <= 45000)
                {
                    txtNCuotaSug.Text = $"{72:n0}";
                }
                else if (MontoPres <= 70000)
                {
                    txtNCuotaSug.Text = $"{96:n0}";
                }
                else if (MontoPres <= 100000)
                {
                    txtNCuotaSug.Text = $"{120:n0}";
                }
                else if (MontoPres <= 300000)
                {
                    txtNCuotaSug.Text = $"{144:n0}";
                }
                else if (MontoPres <= 500000)
                {
                    txtNCuotaSug.Text = $"{168:n0}";
                }
                else
                {
                    txtNCuotaSug.Text = $"{192:n0}";
                }

                if (CtrlTxt == "txtMontoPrestamo")
                {
                    txtNCuotaAsig.Text = txtNCuotaSug.Text;
                }
                try
                {
                    if (MontoPres > 0)
                    {
                        Interes = (Convert.ToDecimal(txtTasaInt.Text) / 100) / Convert.ToDecimal(txtNCapitalizacion.Text);
                        CuotaNiv = (MontoPres * Interes) / Convert.ToDecimal(1 - Math.Pow(1 + Convert.ToDouble(Interes), -Convert.ToInt32(txtNCuotaAsig.Text)));
                        txtCuotaNiv.Text = $"{CuotaNiv:n}";
                        txtInteres.Text = $"{(CuotaNiv * Convert.ToDecimal(txtNCuotaAsig.Text)) - Convert.ToDecimal(txtMontoPrestamo.Text):n}";
                        txtMontoNeto.Text = $"{CuotaNiv * Convert.ToDecimal(txtNCuotaAsig.Text):n}";
                    }
                    else
                    {
                        txtCuotaNiv.Text = $"{0:n}";
                        txtInteres.Text = $"{0:n}";
                        txtMontoNeto.Text = $"{0:n}";
                    }
                }
                catch
                {
                    txtCuotaNiv.Text = $"{0:n}";
                    txtInteres.Text = $"{0:n}";
                    txtMontoNeto.Text = $"{0:n}";
                }
            }
        }
        private void dgvCreditos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCreditos.Columns[e.ColumnIndex].Name == "Marcar")
            {
                LlenarTotales("", "dgvAportes", "dgvCreditos");

                DataGridViewRow row = dgvCreditos.Rows[e.RowIndex];

                if (Convert.ToBoolean((row.Cells["Marcar"] as DataGridViewCheckBoxCell).Value))
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void dgvCreditos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCreditos.IsCurrentCellDirty)
            {
                dgvCreditos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void txtMontoPrestamo_TextChanged(object sender, EventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            if(Editar == false) {
                LlenarTotales(Convert.ToString(ctrl.Name), "dgvAportes", "dgvCreditos");
            }
            else
            {
                LlenarTotales(Convert.ToString(ctrl.Name), "dgvAportesEdit", "dgvCreditosEdit");
            }
        }
        private void txtMontoPrestamo_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtMontoPrestamo.SelectAll();
            });
        }
        private void txtMontoPrestamo_Leave(object sender, EventArgs e)
        {
            string t = this.mskId.Text.Replace("-", "").Replace(" ", "");
            if (string.IsNullOrEmpty(txtMontoPrestamo.Text) || txtMontoPrestamo.Text == ".")
            {
                txtMontoPrestamo.Text = $"{0:n}";
                if (cboSolicitud.Text == "PRÉSTAMO" || cboSolicitud.Text == "REFINANCIAMIENTO" || cboSolicitud.Text == "RETIRO PARCIAL")
                {
                    btnGenerar.Enabled = false;
                    btnImprimir.Enabled = false;
                }
            }
            else
            {
                txtMontoPrestamo.Text = string.Format("{0:#,##0.00}", double.Parse(txtMontoPrestamo.Text));
            }
            if (t == "")
            {
                btnGenerar.Enabled = false;
                btnImprimir.Enabled = false;
            }
        }
        private void txtMontoPrestamo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtMontoPrestamo.Text))
            {
                MessageBox.Show("Ingrese un valor mayor a cero", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMontoPrestamo.Text = $"{0:n}";
                if (cboSolicitud.Text == "PRÉSTAMO" || cboSolicitud.Text == "REFINANCIAMIENTO" || cboSolicitud.Text == "RETIRO PARCIAL")
                {
                    btnGenerar.Enabled = false;
                    btnImprimir.Enabled = false;
                }
                txtMontoPrestamo.Focus();
            }
        }
        private void txtMontoPrestamo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtMontoPrestamo.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void txtMontoPrestamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            e.Handled = ValidarMonto(Convert.ToInt32(e.KeyChar),Convert.ToString(ctrl.Name)); //llamada a la función que evalúa qué tecla es aceptada
        }
        private void Generar(string ctrl)
        {
            int validar = 0;
            if (!Editar)
                validar = ValidarCampos("dgvCreditos");
            else if (Editar && !EditarDatosAct)
                validar = ValidarCampos("dgvCreditosEdit");
            else if (Editar && EditarDatosAct)
                validar = ValidarCampos("dgvCreditos");

            if (validar == 1)
            {
                Numalet let;
                let = new Numalet();
                let.MascaraSalidaDecimal = "00/100 Lempiras";
                let.SeparadorDecimalSalida = "Con";
                let.ConvertirDecimales = false;

                DateTime Fecha = DateTime.ParseExact(mskFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string Identidad = Convert.ToString(mskId.Text.Trim()),
                    CodigoAsoc = Identidad.Replace("-", ""),
                    NombreCompleto = Convert.ToString(txtNombreCompleto.Text.Trim()),
                    AreaTrabajo = Convert.ToString(txtAreaTrab.Text.Trim()),
                    Domicilio = Convert.ToString(txtDomicilio.Text.Trim()),
                    EstadoCivil = Convert.ToString(cboEstadoCivil.Text),
                    TipoEmpleado = Convert.ToString(cboTipoEmpleado.Text),
                    Telefono = Convert.ToString(mskCel.Text);
                //-----------------------------------------------
                double Prestamo = Convert.ToDouble(txtMontoPrestamo.Text),
                    Tasa = Convert.ToDouble(txtTasaInt.Text);
                decimal CantSolicitada = Convert.ToDecimal(txtMontoPrestamo.Text),
                    CantConsumo = Convert.ToDecimal(txtConsumos.Text),
                    CantAprobada = Convert.ToDecimal(txtTotDesemb.Text),
                    MontoCuota = Convert.ToDecimal(txtCuotaNiv.Text);
                string Motivo = Convert.ToString(cboMotivoPres.Text.Trim());
                TipoSolicitud = Convert.ToString(cboSolicitud.Text.Trim());
                int Periodo = Convert.ToInt32(txtNCuotaAsig.Text),
                    PeriodoSug = Convert.ToInt32(txtNCuotaSug.Text),
                    Anios = Convert.ToInt32(txtanios.Text),
                    Meses = Convert.ToInt32(txtmeses.Text),
                    Dias = Convert.ToInt32(txtdias.Text),
                    Capitalizacion = Convert.ToInt32(txtNCapitalizacion.Text);

                try
                {
                    IdAsociado = _repoCodeas.InsertarAsociado(CodigoAsoc, Identidad, NombreCompleto, AreaTrabajo, Domicilio, EstadoCivil, TipoEmpleado, Telefono);
                    IdSolicitud = _repoCodeas.InsertarSolicitud(IdAsociado, IdSolicitud, TotalAport, TotalCred, Fecha, CantSolicitada, let.ToCustomCardinal(CantSolicitada).ToUpper(),
                                                                                                CantConsumo, CantAprobada, MontoCuota, let.ToCustomCardinal(MontoCuota).ToUpper(), Periodo, PeriodoSug,
                                                                                                Convert.ToDecimal(Tasa), Capitalizacion, Motivo, Anios, Meses, Dias, VarGlobales.Division, TipoSolicitud,
                                                                                                dtpFormalizacion.Value.Date, dtpPrimerPago.Value.Date, FrecuPago, VarGlobales.Usuario);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    if (cboSolicitud.Text == "PRÉSTAMO" || cboSolicitud.Text == "REFINANCIAMIENTO")
                    {
                        _repoCodeas.GenerarTablaAmortizacion(Prestamo, Periodo, Capitalizacion, Tasa, IdSolicitud);
                    }
                    if (Editar == false || (Editar == true && EditarDatosAct == true))
                    {
                        if (dgvAportes.RowCount > 0)
                        {
                            foreach (DataGridViewRow row in dgvAportes.Rows)
                            {
                                _repoCodeas.InsertarEstadoFinanciero(IdSolicitud,
                                                                            row.Cells["codigo"].Value.ToString(),
                                                                            decimal.Parse(row.Cells["nmtoprinci"].Value.ToString()),
                                                                            0,
                                                                            decimal.Parse(row.Cells["nmtocuotas"].Value.ToString()),
                                                                            0,
                                                                            int.Parse(row.Cells["cnumepagos"].Value.ToString()),
                                                                            0,
                                                                            row.Cells["cdesdeducc"].Value.ToString(),
                                                                            "0001",
                                                                            "PATRIMONIALES",
                                                                            Convert.ToDateTime(row.Cells["dfecactman"].Value.ToString()),
                                                                            row.Cells["cCODIGOGES"].Value.ToString(),
                                                                            row.Cells["cdetagesti"].Value.ToString(),
                                                                            int.Parse(row.Cells["ccolorgest"].Value.ToString()),
                                                                            "",
                                                                            false);
                            }
                        }
                        if (dgvCreditos.RowCount > 0)
                        {
                            foreach (DataGridViewRow row in dgvCreditos.Rows)
                            {
                                if (row.Cells["Marcar"].Value == null)
                                {
                                    row.Cells["Marcar"].Value = false;
                                }
                                _repoCodeas.InsertarEstadoFinanciero(IdSolicitud,
                                                                            row.Cells["cnumoperac"].Value.ToString(),
                                                                            decimal.Parse(row.Cells["nmontoapro"].Value.ToString()),
                                                                            decimal.Parse(row.Cells["nsaldocred"].Value.ToString()),
                                                                            decimal.Parse(row.Cells["ncuotapres"].Value.ToString()),
                                                                            int.Parse(row.Cells["ntasainter"].Value.ToString()),
                                                                            int.Parse(row.Cells["npagosefec"].Value.ToString()),
                                                                            int.Parse(row.Cells["nnumcuotas"].Value.ToString()),
                                                                            row.Cells["cdetalleli"].Value.ToString(),
                                                                            "001",
                                                                            "CREDITOS",
                                                                            Convert.ToDateTime(row.Cells["dfepagreal"].Value.ToString()),
                                                                            row.Cells["ccodigogest"].Value.ToString(),
                                                                            row.Cells["cdetagestion"].Value.ToString(),
                                                                            int.Parse(row.Cells["ccolorgestion"].Value.ToString()),
                                                                            row.Cells["ccomentari"].Value.ToString(),
                                                                            bool.Parse(row.Cells["Marcar"].Value.ToString()));

                            }
                        }
                        ImpSolicitud(IdAsociado, IdSolicitud, ctrl, Convert.ToInt32(txtNCuotaAsig.Text), Convert.ToInt32(txtNCuotaSug.Text));

                        if (Editar == true && EditarDatosAct == true)
                        {
                            this.DialogResult = DialogResult.OK;
                        }
                        Limpiar();
                        LlenarDgv();
                        LlenarTotales("", "dgvAportes", "dgvCreditos");

                        lblFooter.Text = "Datos Guardados Exitosamente";

                        Timer timer1 = new Timer();
                        timer1.Interval = 10000;

                        timer1.Tick += (s, a) =>
                        {
                            ((Timer)s).Stop();
                            lblFooter.Text = "";
                        };
                        timer1.Start();
                    }
                    else if (Editar == true && EditarDatosAct == false)
                    {
                        if (dgvAportesEdit.RowCount > 0)
                        {
                            foreach (DataGridViewRow row in dgvAportesEdit.Rows)
                            {
                                _repoCodeas.InsertarEstadoFinanciero(IdSolicitud,
                                                                            row.Cells["Operacion"].Value.ToString(),
                                                                            decimal.Parse(row.Cells["principal"].Value.ToString()),
                                                                            0,
                                                                            decimal.Parse(row.Cells["cuotas"].Value.ToString()),
                                                                            0,
                                                                            int.Parse(row.Cells["Pagos"].Value.ToString()),
                                                                            0,
                                                                            row.Cells["descripcion"].Value.ToString(),
                                                                            "0001",
                                                                            "PATRIMONIALES",
                                                                            Convert.ToDateTime(row.Cells["Fecha_Mov"].Value.ToString()),
                                                                            row.Cells["CodGestion"].Value.ToString(),
                                                                            row.Cells["DetGestion"].Value.ToString(),
                                                                            int.Parse(row.Cells["ColorGestion"].Value.ToString()),
                                                                            "",
                                                                            false);
                            }
                        }
                        if (dgvCreditosEdit.RowCount > 0)
                        {
                            foreach (DataGridViewRow row in dgvCreditosEdit.Rows)
                            {
                                if (row.Cells["seleccionado"].Value == null)
                                {
                                    row.Cells["seleccionado"].Value = false;
                                }
                                _repoCodeas.InsertarEstadoFinanciero(IdSolicitud,
                                                                            row.Cells["NumOperacion"].Value.ToString(),
                                                                            decimal.Parse(row.Cells["MontoAprob"].Value.ToString()),
                                                                            decimal.Parse(row.Cells["saldo"].Value.ToString()),
                                                                            decimal.Parse(row.Cells["cuota"].Value.ToString()),
                                                                            int.Parse(row.Cells["Tasa"].Value.ToString()),
                                                                            int.Parse(row.Cells["PagosEfec"].Value.ToString()),
                                                                            int.Parse(row.Cells["ncuotas"].Value.ToString()),
                                                                            row.Cells["Detalle"].Value.ToString(),
                                                                            "001",
                                                                            "CREDITOS",
                                                                            Convert.ToDateTime(row.Cells["FechaMov"].Value.ToString()),
                                                                            row.Cells["CodigoGest"].Value.ToString(),
                                                                            row.Cells["DetGest"].Value.ToString(),
                                                                            int.Parse(row.Cells["ColorGest"].Value.ToString()),
                                                                            row.Cells["Comentario"].Value.ToString(),
                                                                            bool.Parse(row.Cells["seleccionado"].Value.ToString()));
                            }
                        }
                        ImpSolicitud(IdAsociado, IdSolicitud, ctrl, Convert.ToInt32(txtNCuotaAsig.Text), Convert.ToInt32(txtNCuotaSug.Text));
                        Limpiar();

                        this.DialogResult = DialogResult.OK;

                        lblFooter.Text = "Datos Actualizados Exitosamente";
                        mskId.Focus();

                        Timer timer1 = new Timer();
                        timer1.Interval = 5000;

                        timer1.Tick += (s, a) =>
                        {
                            ((Timer)s).Stop();
                            lblFooter.Text = "";
                        };

                        timer1.Start();
                    }
                    PermitirPrestamito = false;
                    PermitirPrestamitoPend = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (validar == 2)
            {
                MessageBox.Show("Ingrese un número de identidad", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskId.Focus();
            }
            else if (validar == 3)
                MessageBox.Show("El número de identidad debe contener al menos 13 dígitos", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 4)
                MessageBox.Show("Ingrese un monto", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 5)
                MessageBox.Show("El monto solicitado debe de ser mayor que cero", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 6)
                MessageBox.Show("La fecha ingresada no puede ser mayor a la fecha actual", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 7)
                MessageBox.Show("Ingrese una fecha válida", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 8)
                MessageBox.Show("Seleccione un estado civil", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (validar == 9)
                MessageBox.Show("Elija el tipo de empleado", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (validar == 10)
                MessageBox.Show("Ingrese un número de teléfono", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (validar == 11)
                MessageBox.Show("El número de teléfono debe contener al menos 8 dígitos", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 12)
                MessageBox.Show("Seleccione el motivo de la solicitud", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (validar == 13)
                MessageBox.Show("El monto solicitado no puede ser mayor al aporte", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 14)
                MessageBox.Show("El monto solicitado no puede ser mayor a la posición financiera", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 15)
                MessageBox.Show("El total de desembolso debe ser mayor que cero", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 16)
                MessageBox.Show("El número de cuotas asignadas no puede ser mayor que el número de cuotas sugeridas.", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (validar == 17)
            {
                if (MessageBox.Show("El asociado tiene préstamos actualmente: \n\n" +
                         "1) Para continuar con el préstamo, haga clic en SI e imprima la solicitud nuevamente, o \n\n" +
                         "2) Marque las lineas que correspondan a préstamo sobre aportación para consolidar la deuda.", VarGlobales.nombreSistema, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    PermitirPrestamitoPend = true;

                    btnImprimir.PerformClick();
                }
                else
                {
                    PermitirPrestamitoPend = false;
                }
            }
            //else if (validar == 18)
            //{
            //    if (MessageBox.Show("El Asociado aplica para un REFINANCIAMIENTO: \n\n" +
            //        "1) Para continuar con el " + "'" + "PRÉSTAMO" + "'" + " normal haga clic en SI e imprima la solicitud nuevamente, o \n\n" +
            //        "2) Haga clic en NO para cambiar el tipo de solicitud a " + "'" + "REFINANCIAMIENTO" + "'", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        PermitirPrestamito = true;

            //        btnImprimir.PerformClick();
            //    }
            //    else
            //    {
            //        PermitirPrestamito = false;
            //    }
            //}
            else if (validar == 19)
                MessageBox.Show("¡La fecha de Formalización del Préstamo no puede ser mayor a la fecha del Primer Pago!", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (validar == 20) 
                MessageBox.Show("Ha ocurrido un cambio en las lineas de crédito del asociado, por favor verificar", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (validar == 21)
                MessageBox.Show("Cuando el motivo del prestamo es Readecuación, el total de desembolso tiene que ser igual a cero.", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Button ctrl = sender as Button;
            Generar(Convert.ToString(ctrl.Name));
        }
        private void CargarCorte()
        {
            System.Collections.Generic.Dictionary<string, string> corte = _repoCodeas.ConsultarFechaCorte(Convert.ToInt32(cboFormalizacion.SelectedValue));
            lblcperiodpag.Text = corte["cperiodpag"];
            if (corte["dfecpripag"] != "" && corte["dfechforma"] != "")
            {
                dtpFormalizacion.Value = Convert.ToDateTime(corte["dfechforma"]);
                dtpPrimerPago.Value = Convert.ToDateTime(corte["dfecpripag"]);
            }
        }
        private void Limpiar()
        {
            Identidad = "";
            IdSolicitud = 0;
            mskId.Text = "";
            txtMontoPrestamo.Text = $"{0:n}";
            mskFecha.Text = Fecha.ToString("dd/MM/yyyy");
            mskCel.Text = "";
            cboEstadoCivil.SelectedIndex = -1;
            cboMotivoPres.SelectedIndex = -1;
            cboTipoEmpleado.SelectedIndex = -1;
            cboSolicitud.SelectedIndex = 0;
            btnGenerar.Enabled = false;
            btnImprimir.Enabled = false;
            btnEstado.Enabled = false;
            txtNombreCompleto.Text = "";
            txtAreaTrab.Text = "";
            txtDomicilio.Text = "";
            txtanios.Text = "";
            txtmeses.Text = "";
            txtdias.Text = "";
            txtConsumos.Text = $"{0:n}";
        }
        public int ValidarCampos(string CtrlDgvCred)
        {
            int resultado = 0, contador = 0, refinanc = 0;
            DataGridView dgvCredito = Controls.Find(CtrlDgvCred, true)[0] as DataGridView;
            string CodigoDgv = "";
            string SeleccionDgv = "";

            if (!Editar || (Editar && EditarDatosAct))
            {
                CodigoDgv = "ccodigolin";
                SeleccionDgv = "Marcar";
            }
            else if (Editar && !EditarDatosAct)
            {
                CodigoDgv = "Descripci";
                SeleccionDgv = "seleccionado";
            }
            foreach (DataGridViewRow row in dgvCredito.Rows)
            {
                string codigo = Convert.ToString(row.Cells[CodigoDgv].Value);

                bool seleccion = Convert.ToBoolean(row.Cells[SeleccionDgv].Value);

                //if ((codigo == "0000000001" || codigo == "PRESTAMO SOBRE APORTACION") && this.cboSolicitud.Text == "PRÉSTAMO")
                //    ++refinanc;

                if ((codigo == "0000000001" || codigo == "PRESTAMO SOBRE APORTACION") && !seleccion && (this.cboSolicitud.Text == "PRÉSTAMO" || this.cboSolicitud.Text == "REFINANCIAMIENTO"))
                    ++contador;
            }

            DateTime MskFecha = DateTime.ParseExact(mskFecha.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string Id = this.mskId.Text.Replace("-", "").Replace(" ", "");
            string Fec = this.mskFecha.Text.Replace("/", "").Replace(" ", "");
            this.mskCel.Text.Replace("-", "").Replace(" ", "");
            //--------------------Identidad---------------------
            if (Id == string.Empty)
            {
                resultado = 2; //Ingresar Identidad
            }
            else if (Id.Length < 13 || Id.Length == 0)
            {
                resultado = 3; //Ingresar Numero de Identidad Completo NETEO DE DEUDAS NETEO DE PRÉSTAMO
            }
            //---------------Monto del Prestamo-----------------
            else if (txtMontoPrestamo.Text == string.Empty && (cboSolicitud.Text == "PRÉSTAMO" || cboSolicitud.Text == "REFINANCIAMIENTO"))
            {
                resultado = 4; //Ingresar Monto
            }
            else if (Convert.ToDecimal(txtMontoPrestamo.Text) < 1 && (cboSolicitud.Text == "PRÉSTAMO" || cboSolicitud.Text == "REFINANCIAMIENTO"))
            {
                resultado = 5; //Ingresar valor mayor a cero
            }
            //----------------------Fecha-----------------------
            else if (MskFecha > DateTime.Now.Date)
            {
                resultado = 6; //Ingresar fecha correcta
            }
            else if (Fec.Length < 8 || Fec.Length == 0)
            {
                resultado = 7; //Ingresar fecha
            }
            //------------------Estado Civil--------------------
            else if (cboEstadoCivil.SelectedIndex == -1)
            {
                resultado = 8; //Ingresar Estado Civil
            }
            //----------------Tipo de Empleado------------------
            else if (cboTipoEmpleado.SelectedIndex == -1)
            {
                resultado = 9; //Ingresar Tipo de Empleado
            }
            //---------------------Celular----------------------
            //else if (Cel == string.Empty )
            //{
            //    resultado = 10; //Ingresar Celular
            //}
            //else if (Cel.Length < 8 || Cel.Length == 0)
            //{
            //    resultado = 11; //Ingresar Numero Completo de Celular
            //}
            //------------------Motivo-------------------------
            else if (cboMotivoPres.SelectedIndex == -1)
            {
                resultado = 12; //Ingresar Motivo del Préstamo
            }
            //Validaciones de préstamo
            else if (Convert.ToDecimal(txtMontoPrestamo.Text) > (TotalAport - TotalAhorroNav))
            {
                resultado = 13; //El monto solicitado no puede ser mayor al aporte.
            }
            else if (Convert.ToDecimal(txtTotDesemb.Text) > ((TotalAport - TotalAhorroNav) - TotalCred))
            {
                resultado = 14; //El monto solicitado no puede ser mayor a la posición financiera.
            }
            else if (Convert.ToDecimal(txtTotDesemb.Text) < 0)
            {
                resultado = 15; //El total de desembolso no puede ser menor a cero
            }
            else if (Convert.ToInt32(txtNCuotaAsig.Text) > Convert.ToInt32(txtNCuotaSug.Text))
            {
                resultado = 16; //La cuota asignada no puede ser mayor a la cuota sugerida
            }
            else if (contador > 0 && PermitirPrestamitoPend == false)
            {
                resultado = 17; //El asociado ya cuenta con un préstamo
            }
            //else if (refinanc > 0 && PermitirPrestamito == false)
            //{
            //    resultado = 18; //Validar si es refinanciamiento
            //}
            else if (dtpPrimerPago.Value.Date < dtpFormalizacion.Value.Date)
            {
                resultado = 19; //Validar si la fecha de formalización es menor a la del primer pago
            }
            else if ((_repoCodeas.TotalCreditosAsociado(Identidad) > TotalCred) && (!Editar || (Editar && EditarDatosAct)))
            {
                resultado = 20;
            }
            else if (cboMotivoPres.Text == "READECUACIÓN" && Convert.ToDecimal(txtTotDesemb.Text) != 0)
            {
                resultado = 21;
            }
            else
            {
                resultado = 1;
            }
            return resultado;
        }
        public void ImpSolicitud(int IdAsociado, int IdSolicitud, string NombreControl, int Periodo, int Periodosug)
        {
            Control[] ctrls = Controls.Find(NombreControl, true);

            LocalReport rdlc = new LocalReport();
            rdlc.DataSources.Clear();
            rdlc.ReportEmbeddedResource = "ADIGGM.Informes.rptSacSolPres.rdlc";

            LocalReport rdlcImpDir = new LocalReport();
            rdlcImpDir.DataSources.Clear();
            rdlcImpDir.ReportEmbeddedResource = "ADIGGM.Informes.rptSacSolPresImpDir.rdlc";

            LocalReport rdlcPagare = new LocalReport();
            rdlcPagare.DataSources.Clear();
            rdlcPagare.ReportEmbeddedResource = "ADIGGM.Informes.rptSacSolPresPagare.rdlc";

            LocalReport rdlcRecibo = new LocalReport();
            rdlcRecibo.DataSources.Clear();
            rdlcRecibo.ReportEmbeddedResource = "ADIGGM.Informes.rptSacSolPresRecibo.rdlc";

            LocalReport rdlcNCuotas = new LocalReport();
            rdlcNCuotas.DataSources.Clear();
            rdlcNCuotas.ReportEmbeddedResource = "ADIGGM.Informes.rptSacSolPresNCuota.rdlc";

            LocalReport rdlcReadecuacion = new LocalReport();
            rdlcReadecuacion.DataSources.Clear();
            rdlcReadecuacion.ReportEmbeddedResource = "ADIGGM.Informes.rptSacSolPresReadecuacion.rdlc";

            LocalReport rdlcEstadoCta = new LocalReport();
            rdlcEstadoCta.DataSources.Clear();
            rdlcEstadoCta.ReportEmbeddedResource = "ADIGGM.Informes.rptASMaestra.rdlc";

            LocalReport rdlcEstadoCtav2 = new LocalReport();
            rdlcEstadoCtav2.DataSources.Clear();
            rdlcEstadoCtav2.ReportEmbeddedResource = "ADIGGM.Informes.rptASMaestrav2.rdlc";

            LocalReport rdlcRetiroParcial = new LocalReport();
            rdlcRetiroParcial.DataSources.Clear();
            rdlcRetiroParcial.ReportEmbeddedResource = "ADIGGM.Informes.rptSacSolPresRetParcial.rdlc";

            LocalReport rdlcNeteo = new LocalReport();
            rdlcNeteo.DataSources.Clear();
            rdlcNeteo.ReportEmbeddedResource = "ADIGGM.Informes.rptSacSolPresNeteo.rdlc";

            // Cargar PRIMERO los datos (vía repositorio); los BindingSources se refrescan igual
            // que lo hacían los Fill originales para que los textboxes enlazados se actualicen.
            sACAsociadosBindingSource.DataMember = "";
            sACAsociadosBindingSource.DataSource = _repoCodeas.CargarAsociadoPorId(IdAsociado);
            sACSolicitudesBindingSource.DataMember = "";
            sACSolicitudesBindingSource.DataSource = _repoCodeas.CargarSolicitud(IdSolicitud);
            if (Editar == true)
            {
                cODSlcASMaestrasBindingSource.DataMember = "";
                cODSlcASMaestrasBindingSource.DataSource = _repoCodeas.CargarASMaestras(Identidad);
            }

            DataTable SAC_Asociados = (DataTable)sACAsociadosBindingSource.DataSource;
            rdlc.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));
            rdlcImpDir.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));
            rdlcPagare.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));
            rdlcNCuotas.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));
            rdlcReadecuacion.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));
            rdlcRetiroParcial.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));
            rdlcNeteo.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));

            DataTable SAC_Solicitudes = (DataTable)sACSolicitudesBindingSource.DataSource;
            rdlc.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));
            rdlcImpDir.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));
            rdlcPagare.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));
            rdlcRecibo.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));
            rdlcNCuotas.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));
            rdlcRetiroParcial.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));
            rdlcNeteo.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));

            DataTable SAC_EstadoFinanciero = _repoCodeas.CargarEstadoFinanciero(IdSolicitud);
            rdlc.DataSources.Add(new ReportDataSource("DsEstadoFinanciero", SAC_EstadoFinanciero));
            rdlcImpDir.DataSources.Add(new ReportDataSource("DsEstadoFinanciero", SAC_EstadoFinanciero));

            DataTable SAC_Amortizaciones = _repoCodeas.CargarAmortizaciones(IdSolicitud);
            rdlc.DataSources.Add(new ReportDataSource("DsAmortizaciones", SAC_Amortizaciones));
            rdlcImpDir.DataSources.Add(new ReportDataSource("DsAmortizaciones", SAC_Amortizaciones));

            DataTable COD_SlcASMaestra = (DataTable)cODSlcASMaestrasBindingSource.DataSource ?? new DataTable();
            rdlcEstadoCta.DataSources.Add(new ReportDataSource("DsASMaestras", COD_SlcASMaestra));
            rdlcEstadoCtav2.DataSources.Add(new ReportDataSource("DsASMaestras", COD_SlcASMaestra));

            DataTable COD_SlcEstadoCuenta = _repoCodeas.CargarEstadoCuenta(Identidad);
            rdlcEstadoCta.DataSources.Add(new ReportDataSource("DsEstadoCuenta", COD_SlcEstadoCuenta));
            rdlcEstadoCtav2.DataSources.Add(new ReportDataSource("DsEstadoCuenta", COD_SlcEstadoCuenta));

            DataTable COD_SlcEstadoCuentaDet = _repoCodeas.CargarEstadoCuentaDet(Identidad);
            rdlcEstadoCta.DataSources.Add(new ReportDataSource("DsEstadoCuentaDet", COD_SlcEstadoCuentaDet));
            //-----------------------------------------------------------------------------------
            ReportParameter[] ParametroSolicitud = new ReportParameter[1];
            ParametroSolicitud[0] = new ReportParameter("TipoSolicitud", cboSolicitud.Text, false);
            rdlc.SetParameters(ParametroSolicitud);

            ReportParameter[] ParametroRecibo = new ReportParameter[1];
            ParametroRecibo[0] = new ReportParameter("Motivo", cboSolicitud.Text, false);
            rdlcRecibo.SetParameters(ParametroRecibo);

            ReportParameter[] ParametroRetiro = new ReportParameter[1];
            ParametroRetiro[0] = new ReportParameter("Motivo", cboMotivoPres.Text, false);
            rdlcRetiroParcial.SetParameters(ParametroRetiro);

            ReportParameter[] ParametroNeteo = new ReportParameter[1];
            ParametroNeteo[0] = new ReportParameter("TipoNeteo", cboSolicitud.Text, false);
            rdlcNeteo.SetParameters(ParametroNeteo);

            ReportParameter[] ParametroEstado = new ReportParameter[1];
            ParametroEstado[0] = new ReportParameter("Usuario", VarGlobales.Usuario, false);
            rdlcEstadoCta.SetParameters(ParametroEstado);
            rdlcEstadoCtav2.SetParameters(ParametroEstado);

            try
            {
                if (ctrls.Length > 0)
                { 
                    //Button ControlButton = ctrls[0] as Button;
                    if (NombreControl == "btnImprimir" && (cboSolicitud.Text == "PRÉSTAMO" || cboSolicitud.Text == "REFINANCIAMIENTO"))
                    {
                        Export(rdlcImpDir);
                        Print();
                        PrimerPag(rdlcImpDir);
                        Print();
                        Export(rdlcPagare);
                        Print();
                        Export(rdlcRecibo);
                        Print();
                        
                        if (Periodo != Periodosug)
                        {
                            Export(rdlcNCuotas);
                            Print();
                        }
                        if (cboMotivoPres.Text == "READECUACIÓN")
                        {
                            Export(rdlcReadecuacion);
                            Print();
                        }
                        if ((Editar == false) || (Editar == true && EditarDatosAct == true))
                        {
                            Export(rdlcEstadoCtav2);
                            Print();
                        }
                        /////////////////////////////////////////////////////////////////
                        if (File.Exists(VarGlobales.dirEstadosDeCuenta + Identidad + " " + IdSolicitud + ".pdf"))
                        {
                            File.Delete(VarGlobales.dirEstadosDeCuenta + Identidad + " " + IdSolicitud + ".pdf");
                        }
                            string deviceInfo =
                            "<DeviceInfo>" +
                            " <OutputFormat>PDF</OutputFormat>" +
                            " <PageWidth>8.5in</PageWidth>" +
                            " <PageHeight>11in</PageHeight>" +
                            " <MarginTop>0.19685in</MarginTop>" +
                            " <MarginLeft>0in</MarginLeft>" +
                            " <MarginRight>0in</MarginRight>" +
                            " <MarginBottom>0.19685in</MarginBottom>" +
                            " <EmbedFonts>EmbedAll</EmbedFonts>" +
                            "</DeviceInfo>";

                            Warning[] warnings;
                            string[] streamids;
                            string mimeType;
                            string encoding;
                            string extension;

                            byte[] bytes = rdlcEstadoCtav2.Render(
                               "PDF", deviceInfo, out mimeType, out encoding,
                                out extension,
                               out streamids, out warnings);

                            FileStream fs = new FileStream(VarGlobales.dirEstadosDeCuenta + Identidad + " " + IdSolicitud +".pdf",
                               FileMode.Create);
                            fs.Write(bytes, 0, bytes.Length);
                            fs.Close();
                        /////////////////////////////////////////////////////////////////
                    }
                    else if (NombreControl == "btnImprimir" && cboSolicitud.Text == "RETIRO PARCIAL")
                    {
                        Export(rdlcRetiroParcial);
                        Print();
                        PrimerPag(rdlcRetiroParcial);
                        Print();
                        Export(rdlcRecibo);
                        Print();
                        if ((Editar == false) || (Editar == true && EditarDatosAct == true))
                        {
                            Export(rdlcEstadoCtav2);
                            Print();
                        }
                    }
                    else if (NombreControl == "btnImprimir" && (cboSolicitud.Text == "NETEO DE DEUDAS" || cboSolicitud.Text == "NETEO DE PRÉSTAMO"))
                    {
                        Export(rdlcNeteo);
                        Print();
                        PrimerPag(rdlcNeteo);
                        Print();
                        Export(rdlcReadecuacion);
                        Print();
                        if ((Editar == false) || (Editar == true && EditarDatosAct == true))
                        {
                            Export(rdlcEstadoCtav2);
                            Print();
                        }
                    }
                    else if (NombreControl == "btnGenerar" && (cboSolicitud.Text == "PRÉSTAMO" || cboSolicitud.Text == "REFINANCIAMIENTO"))
                    {
                        Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string extension;

                        byte[] bytes = rdlc.Render(
                           "PDF", null, out mimeType, out encoding,
                            out extension,
                           out streamids, out warnings);

                        FileStream fs = new FileStream(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf",
                           FileMode.Create);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                        Process.Start(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf");

                        if (Convert.ToInt32(txtNCuotaAsig.Text) != Convert.ToInt32(txtNCuotaSug.Text))
                        {
                            Export(rdlcNCuotas);
                            Print();
                        }
                        if (cboMotivoPres.Text == "READECUACIÓN")
                        {
                            Export(rdlcReadecuacion);
                            Print();
                        }
                        if ((Editar == false) || (Editar == true && EditarDatosAct == true))
                        {
                            Export(rdlcEstadoCtav2);
                            Print();
                        }
                    }
                    else if (NombreControl == "btnGenerar" && cboSolicitud.Text == "RETIRO PARCIAL")
                    {
                        Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string extension;

                        byte[] bytes = rdlcRetiroParcial.Render(
                           "PDF", null, out mimeType, out encoding,
                            out extension,
                           out streamids, out warnings);

                        FileStream fs = new FileStream(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf",
                           FileMode.Create);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                        Process.Start(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf");

                        Export(rdlcRecibo);
                        Print();

                        if ((Editar == false) || (Editar == true && EditarDatosAct == true))
                        {
                            Export(rdlcEstadoCtav2);
                            Print();
                        }
                    }
                    else if (NombreControl == "btnGenerar" && (cboSolicitud.Text == "NETEO DE DEUDAS" || cboSolicitud.Text == "NETEO DE PRÉSTAMO"))
                    {
                        Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string extension;

                        byte[] bytes = rdlcNeteo.Render(
                           "PDF", null, out mimeType, out encoding,
                            out extension,
                           out streamids, out warnings);

                        FileStream fs = new FileStream(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf",
                           FileMode.Create);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                        Process.Start(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf");

                        Export(rdlcEstadoCtav2);
                        Print();
                    }
                    else if (NombreControl == "btnEstado")
                    {
                        string deviceInfo =
                        "<DeviceInfo>" +
                        " <OutputFormat>PDF</OutputFormat>" +
                        " <PageWidth>8.5in</PageWidth>" +
                        " <PageHeight>11in</PageHeight>" +
                        " <MarginTop>0.19685in</MarginTop>" +
                        " <MarginLeft>0in</MarginLeft>" +
                        " <MarginRight>0in</MarginRight>" +
                        " <MarginBottom>0.19685in</MarginBottom>" +
                        " <EmbedFonts>EmbedAll</EmbedFonts>" +
                        "</DeviceInfo>";

                        Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string extension;

                        //byte[] bytes = rdlcReadecuacion.Render(
                        byte[] bytes = rdlcEstadoCta.Render(
                           "PDF", deviceInfo, out mimeType, out encoding,
                            out extension,
                           out streamids, out warnings);

                        FileStream fs = new FileStream(@Path.GetTempPath() + "\\Estado de Cuenta #" + Identidad + ".pdf",
                           FileMode.Create);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                        Process.Start(@Path.GetTempPath() + "\\Estado de Cuenta #" + Identidad + ".pdf");
                    }
                    PermitirPrestamito = false;
                    PermitirPrestamitoPend = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtCuotaNiv_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtCuotaNiv.SelectAll();
            });
        }
        private void txtanios_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtanios.SelectAll();
            });
        }
        private void txtmeses_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtmeses.SelectAll();
            });
        }

        private void txtdias_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtdias.SelectAll();
            });
        }
        private void txtCuotaNiv_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuotaNiv.Text) || txtCuotaNiv.Text == ".")
            {
                txtCuotaNiv.Text = $"{0:n}";
            }
            else
                txtCuotaNiv.Text = string.Format("{0:#,##0.00}", double.Parse(txtCuotaNiv.Text));
        }
        private void txtNCuotaAsig_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNCuotaAsig.Text) || txtNCuotaAsig.Text == ".")
            {
                txtNCuotaAsig.Text = string.Format("{0:n0}", 0);
            }
            else
                txtNCuotaAsig.Text = string.Format("{0:n0}", double.Parse(txtNCuotaAsig.Text));
        }
        private void txtNCuotaAsig_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNCuotaAsig.Text))
            {
                MessageBox.Show("Ingrese un valor mayor a cero", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNCuotaAsig.Text = string.Format("{0:n0}", 0);
                txtNCuotaAsig.Focus();
            }
        }
        private void txtNCuotaAsig_Enter(object sender, EventArgs e)
        {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    txtNCuotaAsig.SelectAll();
                });
        }
        private void txtNCuotaAsig_TextChanged(object sender, EventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            if(Editar == false)
            {
                LlenarTotales(Convert.ToString(ctrl.Name), "dgvAportes", "dgvCreditos");
            }
            else
            {
                LlenarTotales(Convert.ToString(ctrl.Name), "dgvAportesEdit", "dgvCreditosEdit");
            }
        }
        private void txtNCuotaSug_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtNCuotaSug.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void txtNCuotaAsig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtNCuotaAsig.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void txtCuotaNiv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtCuotaNiv.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void txtNCuotaAsig_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCantidad(Convert.ToInt32(e.KeyChar)); //llamada a la función que evalúa qué tecla es aceptada
        }
        private void txtCuotaNiv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuotaNiv.Text))
            {
                MessageBox.Show("Ingrese un valor mayor a cero", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCuotaNiv.Text = string.Format("{0:#,##0.00}", 0);
                txtCuotaNiv.Focus();
            }
        }
        private void txtCuotaNiv_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            e.Handled = ValidarMonto(Convert.ToInt32(e.KeyChar), Convert.ToString(ctrl.Name)); //llamada a la función que evalúa qué tecla es aceptada
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmAsocBuscar asocBuscar = new FrmAsocBuscar();
            asocBuscar.contrato = this;
            if (asocBuscar.ShowDialog(this) == DialogResult.OK)
            {
                var debe = 0;
                string t = mskId.Text.Replace("-", "");
                t = t.Replace(" ", "");
                if (t != "")
                {
                    btnEstado.Enabled = true;
                }
                else if (t == "") 
                { 
                    btnEstado.Enabled = false;
                }

                LlenarDgv();

                if (Editar == false)
                {
                    LlenarTotales("", "dgvAportes", "dgvCreditos");
                }
                else
                {
                    LlenarTotales("", "dgvAportesEdit", "dgvCreditosEdit");
                }
                if (dgvCreditos.RowCount > 0)
                {
                    foreach (DataGridViewRow row in dgvCreditos.Rows)
                    {
                        if (row.Cells["ccodigogest"].Value.ToString() != "0000")
                        {
                            debe += 1;
                        }
                    }
                }
                if (debe != 0)
                {
                    MessageBox.Show("El Asociado tiene una o más cuotas pendientes sin pagar", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void mskId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string t = mskId.Text.Replace("-", "");
                t = t.Replace(" ", "");
                if (t != "")
                {
                    //e.Handled = true; 
                    SendKeys.Send("{TAB}");
                }
            }
        }
        private void Export(LocalReport report) // Export the given report as an EMF (Enhanced Metafile) file.
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0.19685in</MarginTop>
                <MarginLeft>0in</MarginLeft>
                <MarginRight>0in</MarginRight>
                <MarginBottom>0.19685in</MarginBottom>
                <EmbedFonts>EmbedAll</EmbedFonts>
            </DeviceInfo>";
            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream,
               out warnings);
            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }
        private void PrimerPag(LocalReport report) // Export the given report as an EMF (Enhanced Metafile) file.
        {
            string deviceInfo =
              @"<DeviceInfo>
            <OutputFormat>EMF</OutputFormat>
            <PageWidth>8.5in</PageWidth>
            <PageHeight>11in</PageHeight>
            <MarginTop>0.19685in</MarginTop>
            <MarginLeft>0in</MarginLeft>
            <MarginRight>0in</MarginRight>
            <MarginBottom>0.19685in</MarginBottom>
            <EmbedFonts>EmbedAll</EmbedFonts>
              </DeviceInfo>";

            Warning[] warnings;
            m_streams = new List<Stream>();
            report.Render("Image", deviceInfo, CreateStream, out warnings);

            // Considerando que solo queremos la primera página, limpiamos las demás:
            if (m_streams is List<Stream> streamList && streamList.Count > 1)
            {
                for (int i = 1; i < streamList.Count; i++)
                {
                    streamList[i].Close();
                }
                streamList.RemoveRange(1, streamList.Count - 1);
            }

            foreach (Stream stream in m_streams)
                stream.Position = 0;
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Button ctrl = sender as Button;
            Generar(Convert.ToString(ctrl.Name));
        }
        private void txtNCapitalizacion_TextChanged(object sender, EventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            if (Editar == false)
            {
                LlenarTotales(Convert.ToString(ctrl.Name), "dgvAportes", "dgvCreditos");
            }
            else
            {
                LlenarTotales(Convert.ToString(ctrl.Name), "dgvAportesEdit", "dgvCreditosEdit");
            }
        }
        private void txtTasaInt_TextChanged(object sender, EventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            if (Editar == false)
            {
                LlenarTotales(Convert.ToString(ctrl.Name), "dgvAportes", "dgvCreditos");
            }
            else
            {
                LlenarTotales(Convert.ToString(ctrl.Name), "dgvAportesEdit", "dgvCreditosEdit");
            }
        }
        private void txtNCapitalizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidarCantidad(Convert.ToInt32(e.KeyChar)); //llamada a la función que evalúa qué tecla es aceptada
        }
        private void txtTasaInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            e.Handled = ValidarMonto(Convert.ToInt32(e.KeyChar), Convert.ToString(ctrl.Name)); //llamada a la función que evalúa qué tecla es aceptada
        }
        private void txtNCapitalizacion_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNCapitalizacion.Text))
            {
                txtNCapitalizacion.Text = string.Format("{0:n0}", 0);
            }
            else
                txtNCapitalizacion.Text = string.Format("{0:n0}", double.Parse(txtNCapitalizacion.Text));
        }
        private void txtTasaInt_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTasaInt.Text) || txtTasaInt.Text == ".")
            {
                txtTasaInt.Text = $"{0:n}";
            }
            else
                txtTasaInt.Text = string.Format("{0:#,##0.00}", double.Parse(txtTasaInt.Text));
        }
        private void dgvCreditosEdit_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCreditosEdit.Columns[e.ColumnIndex].Name == "seleccionado")
            {
                LlenarTotales("", "dgvAportesEdit", "dgvCreditosEdit");

                DataGridViewRow row = dgvCreditosEdit.Rows[e.RowIndex];

                DataGridViewCheckBoxCell cellSelecion = row.Cells["seleccionado"] as DataGridViewCheckBoxCell;

                if (Convert.ToBoolean(cellSelecion.Value))
                {
                    row.DefaultCellStyle.BackColor = Color.YellowGreen;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                    row.DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void dgvCreditosEdit_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCreditosEdit.IsCurrentCellDirty)
            {
                dgvCreditosEdit.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void btnEstado_Click(object sender, EventArgs e)
        {
            Button ctrl = sender as Button;
            ImpSolicitud(IdAsociado, IdSolicitud, Convert.ToString(ctrl.Name),0,0);
            Limpiar();
            LlenarDgv();
            LlenarTotales("", "dgvAportes", "dgvCreditos");
        }
        private void txtNCapitalizacion_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtNCapitalizacion.SelectAll();
            });
        }
        private void dgvCreditos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvCreditos.RowCount; i++)
            {
                //for (int j = 0; j < dgvCreditos.ColumnCount; j++)
                //{
                if (dgvCreditos.Rows[i].Cells["ccodigogest"].Value.ToString() == "0000" && e.RowIndex == i)
                {
                    //e.CellStyle.BackColor = Color.Yellow;//color de la celda
                    e.CellStyle.ForeColor = Color.Green;// color del text
                }
                else
                if (dgvCreditos.Rows[i].Cells["ccodigogest"].Value.ToString() == "0001" && e.RowIndex == i)
                    {
                        //e.CellStyle.BackColor = Color.Yellow;//color de la celda
                        e.CellStyle.ForeColor = Color.Blue;// color del text
                    }
                else
                if (dgvCreditos.Rows[i].Cells["ccodigogest"].Value.ToString() == "0002" && e.RowIndex == i)
                {
                    //e.CellStyle.BackColor = Color.Yellow;//color de la celda
                    e.CellStyle.ForeColor = Color.Gray;// color del text
                }
                else
                if (dgvCreditos.Rows[i].Cells["ccodigogest"].Value.ToString() == "0003" && e.RowIndex == i)
                {
                    //e.CellStyle.BackColor = Color.Yellow;//color de la celda
                    e.CellStyle.ForeColor = Color.Orange;// color del text
                }
                else
                if (dgvCreditos.Rows[i].Cells["ccodigogest"].Value.ToString() == "0004" && e.RowIndex == i)
                {
                    //e.CellStyle.BackColor = Color.Yellow;//color de la celda
                    e.CellStyle.ForeColor = Color.Red;// color del text
                }
                //}
            }
        }
        private void mskId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
            }
        }
        private void cboMotivoPres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string MontoPrestamo = txtMontoPrestamo.Text;
            MontoPrestamo = MontoPrestamo.Replace(",", "");
            decimal MontoPres = Convert.ToDecimal(MontoPrestamo);

            string TotDesemb = txtTotDesemb.Text;
            TotDesemb = TotDesemb.Replace(",", "");
            decimal TotDesem = Convert.ToDecimal(TotDesemb);

            if (cboMotivoPres.Text == "READECUACIÓN") { 

            }

        }
        private void cboFormalizacion_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarCorte();
        }
        private void dgvCreditosEdit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgvCreditosEdit.RowCount; i++)
            {
                //for (int j = 0; j < dgvCreditos.ColumnCount; j++)
                //{
                if (dgvCreditosEdit.Rows[i].Cells["CodigoGest"].Value.ToString() == "0000" && e.RowIndex == i)
                {
                    //e.CellStyle.BackColor = Color.Yellow;//color de la celda
                    e.CellStyle.ForeColor = Color.Green;// color del text
                }
                else
                if (dgvCreditosEdit.Rows[i].Cells["CodigoGest"].Value.ToString() == "0001" && e.RowIndex == i)
                {
                    //e.CellStyle.BackColor = Color.Yellow;//color de la celda
                    e.CellStyle.ForeColor = Color.Blue;// color del text
                }
                else
                if (dgvCreditosEdit.Rows[i].Cells["CodigoGest"].Value.ToString() == "0002" && e.RowIndex == i)
                {
                    //e.CellStyle.BackColor = Color.Yellow;//color de la celda
                    e.CellStyle.ForeColor = Color.Gray;// color del text
                }
                else
                if (dgvCreditosEdit.Rows[i].Cells["CodigoGest"].Value.ToString() == "0003" && e.RowIndex == i)
                {
                    //e.CellStyle.BackColor = Color.Yellow;//color de la celda
                    e.CellStyle.ForeColor = Color.Orange;// color del text
                }
                else
                if (dgvCreditosEdit.Rows[i].Cells["CodigoGest"].Value.ToString() == "0004" && e.RowIndex == i)
                {
                    //e.CellStyle.BackColor = Color.Yellow;//color de la celda
                    e.CellStyle.ForeColor = Color.Red;// color del text
                }
                //}
            }
        }
        private void cboSolicitud_SelectedIndexChanged(object sender, EventArgs e)
        {
            cambioTipoSol();
        }
        private void cambioTipoSol()
        {
            string MontoPrestamo = txtMontoPrestamo.Text;
            MontoPrestamo = MontoPrestamo.Replace(",", "");
            decimal MontoPres = Convert.ToDecimal(MontoPrestamo);
            string t = mskId.Text.Replace("-", "");
            t = t.Replace(" ", "");

            if (t == "")
            {
                btnGenerar.Enabled = false;
                btnImprimir.Enabled = false;
            }
            else
            if (MontoPres <= 0 && (cboSolicitud.Text == "PRÉSTAMO" || cboSolicitud.Text == "REFINANCIAMIENTO" || cboSolicitud.Text == "RETIRO PARCIAL"))
            {
                btnGenerar.Enabled = false;
                btnImprimir.Enabled = false;
                dgvCreditos.Enabled = true;
                txtMontoPrestamo.Enabled = true;
            }
            else
            if (MontoPres >= 1 && (cboSolicitud.Text == "PRÉSTAMO" || cboSolicitud.Text == "REFINANCIAMIENTO" || cboSolicitud.Text == "RETIRO PARCIAL"))
            {
                btnGenerar.Enabled = true;
                btnImprimir.Enabled = true;
                dgvCreditos.Enabled = true;
                txtMontoPrestamo.Enabled = true;
            }
            else
            if (cboSolicitud.Text != "PRÉSTAMO" && cboSolicitud.Text != "REFINANCIAMIENTO" && cboSolicitud.Text != "RETIRO PARCIAL")
            {
                foreach (DataGridViewRow row in dgvCreditos.Rows)
                {
                    if (Convert.ToBoolean((row.Cells["Marcar"] as DataGridViewCheckBoxCell).Value))
                    {
                        row.Cells["Marcar"].Value = false;
                    }
                }
                btnGenerar.Enabled = true;
                btnImprimir.Enabled = true;
                dgvCreditos.Enabled = false;
                txtMontoPrestamo.Enabled = false;

                txtMontoPrestamo.Text = $"{0:n}";
            }
        }
        private void txtTasaInt_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtTasaInt.SelectAll();
            });
        }
        private void txtNCapitalizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtNCapitalizacion.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        private void txtTasaInt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtTasaInt.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }
        // Handler for PrintPageEvents
        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new
            Metafile(m_streams[m_currentPageIndex]);

            // Adjust rectangular area with printer margins.
            Rectangle adjustedRect = new Rectangle(
                ev.PageBounds.Left - (int)ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int)ev.PageSettings.HardMarginY,
                ev.PageBounds.Width,
                ev.PageBounds.Height);

            // Draw a white background for the report
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);

            // Draw the report content
            ev.Graphics.DrawImage(pageImage, adjustedRect);

            // Prepare for the next page. Make sure we haven't hit the end.
            m_currentPageIndex++;
            ev.HasMorePages = (m_currentPageIndex < m_streams.Count);
        }
        private void Print()
        {
            if (m_streams == null || m_streams.Count == 0)
                throw new Exception("Error: no hay datos para imprimir.");
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = cboPrinterList.Text;
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: no se pudo encontrar la impresora predeterminada.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }
    }
}