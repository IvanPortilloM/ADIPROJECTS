using ADIGGM.Clases;
using ADIGGM.CapaDatos;
using ADIGGM.DataSets;
using ClosedXML.Excel;
using ClosedXML.Report;
using Microsoft.Reporting.WinForms;
using System; // Para DateTime
using System.Collections.Generic; // Para List<string>
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization; // Para NumberStyles
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms; // Para MessageBox
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace ADIGGM.Visores
{
    public partial class FrmVisorPrestamos : FrmPrincipal
    {
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        private readonly RepositorioCodeas _repoCodeas = new RepositorioCodeas();
        private DataTable _solicitudes;

        // Rutina para proporcionar al procesador de informes para guardar una imagen por cada página del informe.
        private Stream CreateStream(string name,
          string fileNameExtension, Encoding encoding,
          string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
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
        public FrmVisorPrestamos()
        {
            InitializeComponent();
            ConfigurarColumnas();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvPrestamos);
            LimpiarContextMenuStrip();
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para inmunizarlo al borrado del
        /// diseñador de VS — gotcha §11. Visor de solo lectura (dgvPrestamos.ReadOnly=true); el .cs accede
        /// a muchas celdas por Name → Names exactos. "Marcar" es una columna no enlazada (vestigial).</summary>
        private void ConfigurarColumnas()
        {
            var DC = DataGridViewAutoSizeColumnMode.DisplayedCells;
            var CH = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dgvPrestamos.AutoGenerateColumns = false;
            dgvPrestamos.Columns.Clear();
            dgvPrestamos.Columns.Add(GridColumnas.Check("Marcar", "", "X", width: 20, autoSize: CH));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("idAsociado", "IdAsociado", "IdAsociado", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("IdSolicitud", "IdSolicitud", "N°", width: 44, autoSize: CH));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("codigo", "CodigoAsociado", "Código", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("fecha", "FechaSolicitud", "Fecha", width: 66, autoSize: DC));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("identidad", "Identidad", "Identidad", width: 87, autoSize: DC));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("nombreCompleto", "NombreCompleto", "Nombre", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("areaTrabajo", "AreaTrabajo", "Área de Trabajo", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("domicilio", "Domicilio", "Domicilio", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("estadoCivil", "EstadoCivil", "Estado Civil", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("tipoEmpleado", "TipoEmpleado", "Tipo de Empleado", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("telefono", "Telefono", "Teléfono", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("cantSolicitada", "CantSolicitada", "Préstamo", format: "N2", width: 82, autoSize: DC));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("aporte", "Aporte", "Aporte", format: "N2", width: 68, autoSize: DC));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("credito", "Credito", "Crédito", format: "N2", width: 72, autoSize: DC));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("cantConsumo", "CantConsumo", "Cant. Consumo", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("cantAprobada", "CantAprobada", "Cant. Aprobada", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("cuota", "Cuota", "Cuota", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("periodo", "Periodo", "Período", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("periodoSug", "PeriodoSug", "Período Sug.", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("tasa", "Tasa", "Tasa", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("capitalizacion", "Capitalizacion", "Capitalización", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("motivo", "Motivo", "Motivo", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Check("aprobado", "Aprobado", "Aprobado", width: 69, autoSize: CH));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("fechaAprobacion", "FechaAprobacion", "Fecha Aprob.", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Check("Anulado", "Anulado", "Anulado", width: 59, autoSize: CH));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("TipoSolicitud", "TipoSolicitud", "TipoSolicitud", visible: false, width: 125));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("Dependencia", "Dependencia", "Dependencia", width: 108, autoSize: CH));
            dgvPrestamos.Columns.Add(GridColumnas.Texto("Usuario", "Usuario", "Usuario", width: 71, autoSize: DC));
            dgvPrestamos.DataSource = sACSolicitudesDgvBindingSource;
        }
        private void FrmVisorPrestamos_Load(object sender, EventArgs e)
        {
            //this.Dock = DockStyle.Fill;
            // (la carga real del grid la hace LlenarDgv() más abajo, vía RepositorioCodeas)

            dtpFechaDesde.Value = DateTime.Now;
            dtpFechaHasta.Value = DateTime.Now;
            txtNSolDesde.Text = "0";
            txtNSolHasta.Text = "0";
            cboFDependencia.SelectedIndex = 0;
            GetAllPrinterList();

            if (RdbCodigo.Checked)
            {
                mskCodigo.Enabled = true;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
                txtNSolDesde.Enabled = false;
                txtNSolHasta.Enabled = false;
            }
            else 
            if(RdbRangoFecha.Checked)
            {
                mskCodigo.Enabled = false;
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
                txtNSolDesde.Enabled = false;
                txtNSolHasta.Enabled = false;
            }
            else
            if (RdbRangoSolicitud.Checked)
            {
                mskCodigo.Enabled = false;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
                txtNSolDesde.Enabled = true;
                txtNSolHasta.Enabled = true;
            }

            LlenarDgv();
            LlenarDetalles(0);
            mskCodigo.Focus();
            btnEditar.Enabled = false;
            btnGenerar.Enabled = false;
            btnImprimir.Enabled = false;

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            LlenarDgv();
            LlenarDetalles(0);
        }

        public void LlenarDgv()
        {
            DateTime FechaDesde = Convert.ToDateTime(dtpFechaDesde.Value);
            DateTime FechaHasta = Convert.ToDateTime(dtpFechaHasta.Value);
            string Codigo = mskCodigo.Text;
            int NSolDesde = Convert.ToInt32(txtNSolDesde.Text);
            int NSolHasta = Convert.ToInt32(txtNSolHasta.Text);

            Codigo = Codigo.Replace("-", "");

            // Ambas ramas del original llamaban al MISMO FillByVisor → una sola llamada al repo.
            _solicitudes = _repoCodeas.BuscarSolicitudesVisor(Codigo, FechaDesde, FechaHasta, NSolDesde, NSolHasta,
                RdbCodigo.Checked, RdbRangoFecha.Checked, RdbRangoSolicitud.Checked, cboFDependencia.Text);
            sACSolicitudesDgvBindingSource.DataSource = _solicitudes;

            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                CmsOpciones.Enabled = true;
            }
            else
            {
                CmsOpciones.Enabled = false;
            }
        }

        public void LlenarDetalles(int IndiceDgv)
        {
            try
            {
                if (dgvPrestamos.RowCount > 0)
                {
                    txtTelefono.Text = dgvPrestamos.Rows[IndiceDgv].Cells["telefono"].Value.ToString();
                    txtAreaTrab.Text = dgvPrestamos.Rows[IndiceDgv].Cells["areaTrabajo"].Value.ToString();
                    txtEstadoCivil.Text = dgvPrestamos.Rows[IndiceDgv].Cells["estadoCivil"].Value.ToString();
                    txtTipoEmp.Text = dgvPrestamos.Rows[IndiceDgv].Cells["tipoEmpleado"].Value.ToString();
                    txtDomicilio.Text = dgvPrestamos.Rows[IndiceDgv].Cells["domicilio"].Value.ToString();
                    txtCantAprob.Text = $"{Convert.ToDouble(dgvPrestamos.Rows[IndiceDgv].Cells["cantAprobada"].Value.ToString()):n}";
                    txtCuota.Text = $"{Convert.ToDouble(dgvPrestamos.Rows[IndiceDgv].Cells["cuota"].Value.ToString()):n}";
                    txtCantConsumo.Text = $"{Convert.ToDouble(dgvPrestamos.Rows[IndiceDgv].Cells["cantConsumo"].Value.ToString()):n}";
                    txtFecAprob.Text = dgvPrestamos.Rows[IndiceDgv].Cells["fechaAprobacion"].Value.ToString();
                    if (dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "PRÉSTAMO" || dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "REFINANCIAMIENTO")
                    {
                        lblTipoSol.Text = dgvPrestamos.Rows[IndiceDgv].Cells["TipoSolicitud"].Value.ToString();
                        txtMotivo.Text = dgvPrestamos.Rows[IndiceDgv].Cells["motivo"].Value.ToString();
                    }
                    else
                    {
                        lblTipoSol.Text = "";
                        txtMotivo.Text = dgvPrestamos.Rows[IndiceDgv].Cells["TipoSolicitud"].Value.ToString();
                    }
                    txtPeriodo.Text = dgvPrestamos.Rows[IndiceDgv].Cells["periodo"].Value.ToString();
                    txtPeriodoSug.Text = dgvPrestamos.Rows[IndiceDgv].Cells["periodoSug"].Value.ToString();
                    txtTasa.Text = $"{Convert.ToDouble(dgvPrestamos.Rows[IndiceDgv].Cells["tasa"].Value)/100:P2}";
                    txtCapitalizacion.Text = dgvPrestamos.Rows[IndiceDgv].Cells["capitalizacion"].Value.ToString();
                }
                else
                {
                    txtTelefono.Text = "";
                    txtAreaTrab.Text = "";
                    txtEstadoCivil.Text = "";
                    txtTipoEmp.Text = "";
                    txtDomicilio.Text = "";
                    txtCantAprob.Text = $"{0:n}";
                    txtCuota.Text = $"{0:n}";
                    txtCantConsumo.Text = $"{0:n}";
                    txtFecAprob.Text = "";
                    txtMotivo.Text = "";
                    txtPeriodo.Text = $"{0:n0}";
                    txtPeriodoSug.Text = $"{0:n0}";
                    txtTasa.Text = $"{0:P2}";
                    txtCapitalizacion.Text = $"{0:n0}";
                    lblTipoSol.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPrestamos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrestamos.RowCount > 0)
            {
                LlenarDetalles(dgvPrestamos.CurrentRow.Index);

                if (bool.Parse(this.dgvPrestamos.CurrentRow.Cells["Anulado"].Value.ToString()) == false &&
                        bool.Parse(this.dgvPrestamos.CurrentRow.Cells["aprobado"].Value.ToString()) == false)
                {
                    btnEditar.Enabled = true;
                    btnGenerar.Enabled = true;
                    btnImprimir.Enabled = true;
                    pnlDatosPres.Visible = true;
                    gboParametros.Visible = true;
                }
                else
                    if (bool.Parse(this.dgvPrestamos.CurrentRow.Cells["Anulado"].Value.ToString()) == true &&
                        bool.Parse(this.dgvPrestamos.CurrentRow.Cells["aprobado"].Value.ToString()) == false)
                {
                    btnEditar.Enabled = false;
                    btnGenerar.Enabled = false;
                    btnImprimir.Enabled = false;
                    pnlDatosPres.Visible = true;
                    gboParametros.Visible = true;
                }
                else
                    if (bool.Parse(this.dgvPrestamos.CurrentRow.Cells["Anulado"].Value.ToString()) == false &&
                        bool.Parse(this.dgvPrestamos.CurrentRow.Cells["aprobado"].Value.ToString()) == true)
                {
                    btnEditar.Enabled = false;
                    btnGenerar.Enabled = false;
                    btnImprimir.Enabled = false;
                    pnlDatosPres.Visible = true;
                    gboParametros.Visible = true;
                }else
                {
                    btnEditar.Enabled = false;
                    btnGenerar.Enabled = true;
                    btnImprimir.Enabled = false;
                    pnlDatosPres.Visible = false;
                    gboParametros.Visible = false;
                }
            }
            else
            {
                btnEditar.Enabled = false;
                btnGenerar.Enabled = false;
                btnImprimir.Enabled = false;
                pnlDatosPres.Visible = false;
                gboParametros.Visible = false;
            }
        }

        private void dgvPrestamos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool EditarDatosAct;
            DialogResult dialogResult = MessageBox.Show("¿Desea que se carguen las lineas de créditos actualizadas a la fecha de hoy?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                EditarDatosAct = true;
            }
            else
            {
                EditarDatosAct = false;
            }
            int IdAsociado = int.Parse(dgvPrestamos.CurrentRow.Cells["idAsociado"].Value.ToString());
            int IdSolicitud = int.Parse(dgvPrestamos.CurrentRow.Cells["IdSolicitud"].Value.ToString());
            string Identidad = dgvPrestamos.CurrentRow.Cells["codigo"].Value.ToString(),
                    TipoSolicitud = dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString();
            SAC.FrmSolCred solCred = new SAC.FrmSolCred(true, EditarDatosAct, IdAsociado, IdSolicitud, Identidad,TipoSolicitud);

            if (solCred.ShowDialog(this) == DialogResult.OK)
            {
                LlenarDgv();
                LlenarDetalles(0);
            }
        }

        public void ImpSolicitud(int IdAsociado, int IdSolicitud, string NombreControl)
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

            LocalReport rdlcReadecuacion = new LocalReport();
            rdlcReadecuacion.DataSources.Clear();
            rdlcReadecuacion.ReportEmbeddedResource = "ADIGGM.Informes.rptSacSolPresReadecuacion.rdlc";

            LocalReport rdlcRetiroParcial = new LocalReport();
            rdlcRetiroParcial.DataSources.Clear();
            rdlcRetiroParcial.ReportEmbeddedResource = "ADIGGM.Informes.rptSacSolPresRetParcial.rdlc";

            LocalReport rdlcNeteo = new LocalReport();
            rdlcNeteo.DataSources.Clear();
            rdlcNeteo.ReportEmbeddedResource = "ADIGGM.Informes.rptSacSolPresNeteo.rdlc";

            DataTable SAC_Asociados = _repoCodeas.CargarAsociadoPorId(IdAsociado);
            rdlc.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));
            rdlcImpDir.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));
            rdlcPagare.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));
            rdlcRetiroParcial.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));
            rdlcNeteo.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));
            rdlcReadecuacion.DataSources.Add(new ReportDataSource("DsAsociados", SAC_Asociados));

            DataTable SAC_Solicitudes = _repoCodeas.CargarSolicitud(IdSolicitud);
            rdlc.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));
            rdlcImpDir.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));
            rdlcPagare.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));
            rdlcRecibo.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));            
            rdlcRetiroParcial.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));
            rdlcNeteo.DataSources.Add(new ReportDataSource("DsSolicitudes", SAC_Solicitudes));

            DataTable SAC_EstadoFinanciero = _repoCodeas.CargarEstadoFinanciero(IdSolicitud);
            rdlc.DataSources.Add(new ReportDataSource("DsEstadoFinanciero", SAC_EstadoFinanciero));
            rdlcImpDir.DataSources.Add(new ReportDataSource("DsEstadoFinanciero", SAC_EstadoFinanciero));

            DataTable SAC_Amortizaciones = _repoCodeas.CargarAmortizaciones(IdSolicitud);
            rdlc.DataSources.Add(new ReportDataSource("DsAmortizaciones", SAC_Amortizaciones));
            rdlcImpDir.DataSources.Add(new ReportDataSource("DsAmortizaciones", SAC_Amortizaciones));
            //-----------------------------------------------------------------------------------
            ReportParameter[] ParametroSolicitud = new ReportParameter[1];
            ParametroSolicitud[0] = new ReportParameter("TipoSolicitud", dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString(), false);
            rdlc.SetParameters(ParametroSolicitud);

            ReportParameter[] ParametroRecibo = new ReportParameter[1];
            ParametroRecibo[0] = new ReportParameter("Motivo", dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString(), false);
            rdlcRecibo.SetParameters(ParametroRecibo);

            ReportParameter[] ParametroRetiro = new ReportParameter[1];
            ParametroRetiro[0] = new ReportParameter("Motivo", dgvPrestamos.CurrentRow.Cells["motivo"].Value.ToString(), false);
            rdlcRetiroParcial.SetParameters(ParametroRetiro);

            ReportParameter[] ParametroNeteo = new ReportParameter[1];
            ParametroNeteo[0] = new ReportParameter("TipoNeteo", dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString(), false);
            rdlcNeteo.SetParameters(ParametroNeteo);

            try
            {
                if (ctrls.Length > 0)
                {
                    Button ControlButton = ctrls[0] as Button;

                    if (NombreControl == "btnImprimir" && (dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "PRÉSTAMO" || dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "REFINANCIAMIENTO"))
                    {
                        Export(rdlcImpDir);
                        Print();
                        Export(rdlcPagare);
                        Print();
                        Export(rdlcRecibo);
                        Print();
                        if (dgvPrestamos.CurrentRow.Cells["motivo"].Value.ToString() == "READECUACIÓN")
                        {
                            Export(rdlcReadecuacion);
                            Print();
                        }
                    }
                    else if (NombreControl == "btnImprimir" && dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "RETIRO PARCIAL")
                    {
                        Export(rdlcRetiroParcial);
                        Print();
                        Export(rdlcRecibo);
                        Print();
                    }
                    else if (NombreControl == "btnImprimir" && (dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "NETEO DE DEUDAS" || dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "NETEO DE PRÉSTAMO"))
                    {
                        Export(rdlcNeteo);
                        Print();
                        Export(rdlcReadecuacion);
                        Print();
                    }
                    else if (NombreControl == "btnGenerar" && (dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "PRÉSTAMO" || dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "REFINANCIAMIENTO"))
                    {
                        Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string extension;
                        string deviceInfo =
                          @"<DeviceInfo>
                            <OutputFormat>PDF</OutputFormat>
                            <PageWidth>8.5in</PageWidth>
                            <PageHeight>11in</PageHeight>
                            <MarginTop>0.19685in</MarginTop>
                            <MarginLeft>0in</MarginLeft>
                            <MarginRight>0in</MarginRight>
                            <MarginBottom>0.19685in</MarginBottom>
                            <EmbedFonts>EmbedAll</EmbedFonts>
                        </DeviceInfo>";

                        byte[] bytes = rdlc.Render(
                           "PDF", deviceInfo, out mimeType, out encoding,
                            out extension,
                           out streamids, out warnings);

                        FileStream fs = new FileStream(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf",
                           FileMode.Create);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                        Process.Start(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf");
                    }
                    else if (NombreControl == "btnGenerar" && dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "RETIRO PARCIAL")
                    {
                        Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string extension;
                        string deviceInfo =
                          @"<DeviceInfo>
                            <OutputFormat>PDF</OutputFormat>
                            <PageWidth>8.5in</PageWidth>
                            <PageHeight>11in</PageHeight>
                            <MarginTop>0.19685in</MarginTop>
                            <MarginLeft>0in</MarginLeft>
                            <MarginRight>0in</MarginRight>
                            <MarginBottom>0.19685in</MarginBottom>
                            <EmbedFonts>EmbedAll</EmbedFonts>
                        </DeviceInfo>";

                        byte[] bytes = rdlcRetiroParcial.Render(
                           "PDF", deviceInfo, out mimeType, out encoding,
                            out extension,
                           out streamids, out warnings);

                        FileStream fs = new FileStream(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf",
                           FileMode.Create);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                        Process.Start(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf");
                    }
                    else if (NombreControl == "btnGenerar" && (dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "NETEO DE DEUDAS" || dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString() == "NETEO DE PRÉSTAMO"))
                    {
                        Warning[] warnings;
                        string[] streamids;
                        string mimeType;
                        string encoding;
                        string extension;
                        string deviceInfo =
                          @"<DeviceInfo>
                            <OutputFormat>PDF</OutputFormat>
                            <PageWidth>8.5in</PageWidth>
                            <PageHeight>11in</PageHeight>
                            <MarginTop>0.19685in</MarginTop>
                            <MarginLeft>0in</MarginLeft>
                            <MarginRight>0in</MarginRight>
                            <MarginBottom>0.19685in</MarginBottom>
                            <EmbedFonts>EmbedAll</EmbedFonts>
                        </DeviceInfo>";

                        byte[] bytes = rdlcNeteo.Render(
                           "PDF", deviceInfo, out mimeType, out encoding,
                            out extension,
                           out streamids, out warnings);

                        FileStream fs = new FileStream(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf",
                           FileMode.Create);
                        fs.Write(bytes, 0, bytes.Length);
                        fs.Close();
                        Process.Start(@Path.GetTempPath() + "\\Solicitud #" + IdAsociado + "-" + IdSolicitud + ".pdf");}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Export(LocalReport report)
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
        private void LimpiarContextMenuStrip()
        {
            CmsOpciones.Items[0].Visible = false;
            CmsOpciones.Items[1].Visible = false;
            CmsOpciones.Items[2].Visible = false;
            CmsOpciones.Items[3].Visible = false;
            CmsOpciones.Items[4].Visible = false;
        }

        private void dgvPrestamos_MouseDown(object sender, MouseEventArgs e)
        {
            LimpiarContextMenuStrip();
            if (dgvPrestamos.RowCount > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (bool.Parse(this.dgvPrestamos.CurrentRow.Cells["Anulado"].Value.ToString()) == false &&
                        bool.Parse(this.dgvPrestamos.CurrentRow.Cells["aprobado"].Value.ToString()) == false)
                    {
                        CmsOpciones.Items[0].Visible = true;
                        CmsOpciones.Items[1].Visible = true;
                        CmsOpciones.Items[2].Visible = false;
                        CmsOpciones.Items[3].Visible = true;
                        CmsOpciones.Items[4].Visible = false;
                    }
                    else 
                    if (bool.Parse(this.dgvPrestamos.CurrentRow.Cells["Anulado"].Value.ToString()) == true && 
                        bool.Parse(this.dgvPrestamos.CurrentRow.Cells["aprobado"].Value.ToString()) == false)
                    {
                        CmsOpciones.Items[0].Visible = false;
                        CmsOpciones.Items[1].Visible = false;
                        CmsOpciones.Items[2].Visible = false;
                        CmsOpciones.Items[3].Visible = false;
                        CmsOpciones.Items[4].Visible = true;
                    }
                    else 
                    if (bool.Parse(this.dgvPrestamos.CurrentRow.Cells["Anulado"].Value.ToString()) == false && 
                        bool.Parse(this.dgvPrestamos.CurrentRow.Cells["aprobado"].Value.ToString()) == true)
                    {
                        CmsOpciones.Items[0].Visible = false;
                        CmsOpciones.Items[1].Visible = false;
                        CmsOpciones.Items[2].Visible = true;
                        CmsOpciones.Items[3].Visible = false;
                        CmsOpciones.Items[4].Visible = false;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbCodigo.Checked)
            {
                mskCodigo.Enabled = true;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
                txtNSolDesde.Enabled = false;
                txtNSolHasta.Enabled = false;
            }
            else
            if (RdbRangoFecha.Checked)
            {
                mskCodigo.Enabled = false;
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
                txtNSolDesde.Enabled = false;
                txtNSolHasta.Enabled = false;
            }
            else
            if (RdbRangoSolicitud.Checked)
            {
                mskCodigo.Enabled = false;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
                txtNSolDesde.Enabled = true;
                txtNSolHasta.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            SAC.FrmSolCred solCred = new SAC.FrmSolCred(false,false,0,0,"","");
            solCred.ShowDialog(this);
            LlenarDgv();
            LlenarDetalles(0);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int IdAsociado = int.Parse(dgvPrestamos.CurrentRow.Cells["idAsociado"].Value.ToString());
            int IdSolicitud = int.Parse(dgvPrestamos.CurrentRow.Cells["IdSolicitud"].Value.ToString());
            Button ctrl = sender as Button;
            ImpSolicitud(IdAsociado, IdSolicitud, Convert.ToString(ctrl.Name));
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int IdAsociado = int.Parse(dgvPrestamos.CurrentRow.Cells["idAsociado"].Value.ToString());
            int IdSolicitud = int.Parse(dgvPrestamos.CurrentRow.Cells["IdSolicitud"].Value.ToString());
            string Identidad = dgvPrestamos.CurrentRow.Cells["codigo"].Value.ToString();

            Button ctrl = sender as Button;
            ImpSolicitud(IdAsociado, IdSolicitud, Convert.ToString(ctrl.Name));

            try
            {
                Process.Start(VarGlobales.dirEstadosDeCuenta + Identidad + " " + IdSolicitud + ".pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontrar el estado de cuenta de esta solicitud." + ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mskCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (mskCodigo.Text != "")
                {
                    if (RdbCodigo.Checked)
                    {
                        btnVisualizar.PerformClick();
                    }
                    else
                        e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void mskCodigo_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mskCodigo.SelectAll();
            });
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            bool EditarDatosAct;
            DialogResult dialogResult = MessageBox.Show("¿Desea que se carguen las lineas de créditos actualizadas a la fecha de hoy?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                EditarDatosAct = true;
            }
            else
            {
                EditarDatosAct = false;
            }
            int IdAsociado = int.Parse(dgvPrestamos.CurrentRow.Cells["idAsociado"].Value.ToString());
            int IdSolicitud = int.Parse(dgvPrestamos.CurrentRow.Cells["IdSolicitud"].Value.ToString());
            string Identidad = dgvPrestamos.CurrentRow.Cells["codigo"].Value.ToString(),
            TipoSolicitud = dgvPrestamos.CurrentRow.Cells["TipoSolicitud"].Value.ToString();
            SAC.FrmSolCred solCred = new SAC.FrmSolCred(true, EditarDatosAct, IdAsociado, IdSolicitud, Identidad,TipoSolicitud);

            if (solCred.ShowDialog(this) == DialogResult.OK)
            {
                LlenarDgv();
                LlenarDetalles(0);
            }
        }

        //try
        //{
        //    Warning[] warnings;
        //    string[] streamids;
        //    string mimeType;
        //    string encoding;
        //    string extension;

        //    byte[] bytes = rdlc.Render(
        //       "Excel", null, out mimeType, out encoding,
        //        out extension,
        //       out streamids, out warnings);

        //    FileStream fs = new FileStream(@Path.GetTempPath() + "\\" + "\\Solicitudes de Crédito del " + dtpFechaDesde.Value.ToString("dd-MM-yyyy") + " Hasta el " + dtpFechaHasta.Value.ToString("dd-MM-yyyy") + ".xls",
        //       FileMode.Create);
        //    fs.Write(bytes, 0, bytes.Length);
        //    fs.Close();
        //    Process.Start(@Path.GetTempPath() + "\\Solicitudes de Crédito del " + dtpFechaDesde.Value.ToString("dd-MM-yyyy") + " Hasta el "+ dtpFechaHasta.Value.ToString("dd-MM-yyyy") + ".xls");

        //}

private void btnExportar_Click(object sender, EventArgs e)
    {
        DateTime FechaDesde = Convert.ToDateTime(dtpFechaDesde.Value);
        DateTime FechaHasta = Convert.ToDateTime(dtpFechaHasta.Value);
        string Codigo = mskCodigo.Text;
        int NSolDesde = Convert.ToInt32(txtNSolDesde.Text);
        int NSolHasta = Convert.ToInt32(txtNSolHasta.Text);

        DataTable dt = _repoCodeas.ReporteSolicitudes(
            Codigo, FechaDesde, FechaHasta, NSolDesde, NSolHasta,
            RdbCodigo.Checked, RdbRangoFecha.Checked, RdbRangoSolicitud.Checked,
            cboFDependencia.Text);

        foreach (DataColumn column in dt.Columns)
        {
            column.ColumnName = column.ColumnName.Trim();
        }

        DataTable dtCloned = new DataTable();

        var columnsToConvert = new List<string>
    {
        "MontoAprobado",
        "DepositoNeto",
        "MontoDenegado",
        "Ahorro",
        "Cuota"
    };

        foreach (DataColumn oldCol in dt.Columns)
        {
            string colName = oldCol.ColumnName;
            if (columnsToConvert.Contains(colName))
            {
                DataColumn newNumCol = new DataColumn(colName, typeof(decimal));
                newNumCol.AllowDBNull = true;
                dtCloned.Columns.Add(newNumCol);
            }
            else
            {
                dtCloned.Columns.Add(colName, oldCol.DataType);
            }
        }

        foreach (DataRow oldRow in dt.Rows)
        {
            DataRow newRow = dtCloned.NewRow();
            foreach (DataColumn col in dtCloned.Columns)
            {
                string colName = col.ColumnName;
                if (columnsToConvert.Contains(colName))
                {
                    string stringValue = oldRow[colName].ToString();
                    decimal decimalValue;

                    if (decimal.TryParse(stringValue, NumberStyles.Any, CultureInfo.InvariantCulture, out decimalValue))
                    {
                        newRow[colName] = decimalValue;
                    }
                    else
                    {
                        newRow[colName] = 0.0m; 
                    }
                }
                else
                {
                    newRow[colName] = oldRow[colName];
                }
            }
            dtCloned.Rows.Add(newRow);
        }

        dt = dtCloned;                       

        int numColumnas = dt.Columns.Count;
        string formatoMoneda = "\"L \"#,##0.00";

        try
        {
            using (var wb = new XLWorkbook())
            {
                var wsDatos = wb.AddWorksheet(dt, "Historial Créditos");
                var tablaDatos = wsDatos.Tables.First();
                tablaDatos.Name = "TablaPrincipalDeDatos";

                if (dt.Columns.Contains("IdSolicitud"))
                {
                    int colIndex = dt.Columns["IdSolicitud"].Ordinal;
                    wsDatos.Column(colIndex + 1).Hide();
                }

                wsDatos.Row(1).InsertRowsAbove(3);
                string anioActual = DateTime.Now.Year.ToString();
                string titulo = "Historial de Créditos A.D.I.-GGM " + anioActual;
                string subtitulo = "Del " + FechaDesde.ToString("dd 'de' MMMM 'de' yyyy") + " al " + FechaHasta.ToString("dd 'de' MMMM 'de' yyyy");

                var celdaTitulo = wsDatos.Cell("B1");
                celdaTitulo.Value = titulo;
                var rangoTitulo = wsDatos.Range(1, 2, 1, numColumnas);
                rangoTitulo.Merge();
                celdaTitulo.Style.Font.Bold = true;
                celdaTitulo.Style.Font.FontSize = 16;
                celdaTitulo.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                var celdaSubtitulo = wsDatos.Cell("B2");
                celdaSubtitulo.Value = subtitulo;
                var rangoSubtitulo = wsDatos.Range(2, 2, 2, numColumnas);
                rangoSubtitulo.Merge();
                celdaSubtitulo.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;

                tablaDatos.Theme = XLTableTheme.TableStyleLight16;
                tablaDatos.ShowTotalsRow = true;

                try
                {
                    tablaDatos.Field(dt.Columns[1].ColumnName).TotalsRowLabel = "TOTALES:";
                }
                catch { }

                if (dt.Columns.Contains("MontoAprobado"))
                {
                    tablaDatos.Field("MontoAprobado").TotalsRowFunction = XLTotalsRowFunction.Sum;
                    int colIndex = dt.Columns["MontoAprobado"].Ordinal;
                    wsDatos.Column(colIndex + 1).Style.NumberFormat.Format = formatoMoneda;
                }

                if (dt.Columns.Contains("DepositoNeto"))
                {
                    tablaDatos.Field("DepositoNeto").TotalsRowFunction = XLTotalsRowFunction.Sum;
                    int colIndex = dt.Columns["DepositoNeto"].Ordinal;
                    wsDatos.Column(colIndex + 1).Style.NumberFormat.Format = formatoMoneda;
                }

                if (dt.Columns.Contains("MontoDenegado"))
                {
                    int colIndex = dt.Columns["MontoDenegado"].Ordinal;
                    wsDatos.Column(colIndex + 1).Style.NumberFormat.Format = formatoMoneda;
                }
                if (dt.Columns.Contains("Ahorro"))
                {
                    int colIndex = dt.Columns["Ahorro"].Ordinal;
                    wsDatos.Column(colIndex + 1).Style.NumberFormat.Format = formatoMoneda;
                }
                if (dt.Columns.Contains("Cuota"))
                {
                    int colIndex = dt.Columns["Cuota"].Ordinal;
                    wsDatos.Column(colIndex + 1).Style.NumberFormat.Format = formatoMoneda;
                }

                int filaActual = tablaDatos.LastRow().RowNumber();
                filaActual += 4;

                string textoFirmas = "Otros Temas (Comentarios):___________________________                                                                                                                                                                                                                                        Responsable:___________________________";
                var celdaFirmas = wsDatos.Cell(filaActual, 2);
                celdaFirmas.Value = textoFirmas;

                var rangoFirmas = wsDatos.Range(filaActual, 2, filaActual, numColumnas);
                rangoFirmas.Merge();
                //rangoFirmas.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangoFirmas.Style.Font.Bold = true;

                int filaInicioPivot = filaActual + 2;
                var pivotTable = wsDatos.PivotTables.Add("ResumenSolicitudes", wsDatos.Cell(filaInicioPivot, 2), tablaDatos);

                var fTipo = pivotTable.RowLabels.Add("TipoSolicitud");
                fTipo.CustomName = "Tipo de Solicitud"; 

                var fDestino = pivotTable.RowLabels.Add("DestinoPrestamo");
                fDestino.CustomName = "Destino del Préstamo";

                var campoDeposito = pivotTable.Values.Add("DepositoNeto");
                campoDeposito.SetSummaryFormula(XLPivotSummary.Sum);
                campoDeposito.NumberFormat.Format = formatoMoneda;
                campoDeposito.CustomName = "Total Depósito Neto"; 

                pivotTable.Layout = XLPivotLayout.Tabular;

                fTipo.RepeatItemLabels = true;
                fDestino.RepeatItemLabels = true;

                pivotTable.ShowExpandCollapseButtons = false;

                wsDatos.Columns().AdjustToContents();

                string nombreArchivo = "Solicitudes de Crédito del " + dtpFechaDesde.Value.ToString("dd-MM-yyyy") + " Hasta el " + dtpFechaHasta.Value.ToString("dd-MM-yyyy") + ".xlsx";
                string rutaCompleta = Path.Combine(Path.GetTempPath(), nombreArchivo);

                if (File.Exists(rutaCompleta))
                {
                    File.Delete(rutaCompleta);
                }

                wb.SaveAs(rutaCompleta);
                Process.Start(rutaCompleta);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al generar Excel: " + ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void txtNSolDesde_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNSolDesde.Text) || txtNSolDesde.Text == ".")
            {
                txtNSolDesde.Text = "0";
            }
        }

        private void txtNSolHasta_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNSolHasta.Text) || txtNSolHasta.Text == ".")
            {
                txtNSolHasta.Text = "0";
            }
        }
        private void RdbRangoFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbCodigo.Checked)
            {
                mskCodigo.Enabled = true;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
                txtNSolDesde.Enabled = false;
                txtNSolHasta.Enabled = false;
            }
            else
            if (RdbRangoFecha.Checked)
            {
                mskCodigo.Enabled = false;
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
                txtNSolDesde.Enabled = false;
                txtNSolHasta.Enabled = false;
            }
            else
            if (RdbRangoSolicitud.Checked)
            {
                mskCodigo.Enabled = false;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
                txtNSolDesde.Enabled = true;
                txtNSolHasta.Enabled = true;
            }
        }

        private void RdbRangoSolicitud_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbCodigo.Checked)
            {
                mskCodigo.Enabled = true;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
                txtNSolDesde.Enabled = false;
                txtNSolHasta.Enabled = false;
            }
            else
            if (RdbRangoFecha.Checked)
            {
                mskCodigo.Enabled = false;
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
                txtNSolDesde.Enabled = false;
                txtNSolHasta.Enabled = false;
            }
            else
            if (RdbRangoSolicitud.Checked)
            {
                mskCodigo.Enabled = false;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
                txtNSolDesde.Enabled = true;
                txtNSolHasta.Enabled = true;
            }
        }
        private void MostrarMensajeConfirmacion(string mensaje, Action accion)
        {
            DialogResult dialogResult = MessageBox.Show(mensaje,Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                accion();
            }
        }
        private void AprobarPrestamo()
        {
            int IdSolicitud = ObtenerIdSolicitudActual();
            _repoCodeas.AprobarSolicitud(IdSolicitud, 1);
            LlenarDgv();
            LlenarDetalles(0);
        }
        private void ReversarAprobacion()
        {
            int IdSolicitud = ObtenerIdSolicitudActual();
            _repoCodeas.AprobarSolicitud(IdSolicitud, 0);
            LlenarDgv();
            LlenarDetalles(0);
        }

        private void AnularPrestamo()
        {
            int IdSolicitud = ObtenerIdSolicitudActual();
            _repoCodeas.AnularSolicitud(IdSolicitud, 1);
            LlenarDgv();
            LlenarDetalles(0);
        }

        private void ReversarAnulacion()
        {
            int IdSolicitud = ObtenerIdSolicitudActual();
            _repoCodeas.AnularSolicitud(IdSolicitud, 0);
            LlenarDgv();
            LlenarDetalles(0);
        }

        private int ObtenerIdSolicitudActual()
        {
            return int.Parse(dgvPrestamos.CurrentRow.Cells["IdSolicitud"].Value.ToString());
        }
        private void aprobarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarMensajeConfirmacion("¿Esta seguro que desea aprobar este préstamo?", AprobarPrestamo);
        }

        private void reversarAprobaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarMensajeConfirmacion("¿Esta seguro que desea reversar este préstamo?", ReversarAprobacion);
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarMensajeConfirmacion("¿Esta seguro que desea anular este préstamo?", AnularPrestamo);
        }

        private void reversarAnulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarMensajeConfirmacion("¿Esta seguro que desea reversar la anulación de este préstamo?", ReversarAnulacion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Credenciales de Twilio: ahora se leen de App.config (<appSettings>), NO se hardcodean.
            var accountSid = System.Configuration.ConfigurationManager.AppSettings["TwilioAccountSid"];
            var authToken = System.Configuration.ConfigurationManager.AppSettings["TwilioAuthToken"];
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
              new PhoneNumber("+50432672130"));
            //new PhoneNumber("+50498784279"));
            messageOptions.From = new PhoneNumber("+14322878856");
            messageOptions.Body = "Esto es una prueba";

            var message = MessageResource.Create(messageOptions);
            Console.WriteLine(message.Body);
        }
    }
}