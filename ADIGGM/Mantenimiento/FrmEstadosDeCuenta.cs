using ADIGGM.CapaDatos;
using ADIGGM.Clases;
using Formularios_Base;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Mantenimiento
{
    // BackgroundWorker se utilizará para realizar una acción de ejecución prolongada
    // en un subproceso en segundo plano. Esto permite que la IU sea libre para hacer cambios,
    // así como para otras acciones que el usuario quiera realizar. El subproceso en segundo 
    // plano utilizará el evento ReportProgress para actualizar ProgressBar en el subproceso de la UI.
    public partial class FrmEstadosDeCuenta : FrmMantenimiento
    {
        private int m_currentPageIndex;
        private IList<Stream> m_streams;

        // Routine to provide to the report renderer, in order to
        //    save an image for each page of the report.
        private Stream CreateStream(string name,
          string fileNameExtension, Encoding encoding,
          string mimeType, bool willSeek)
        {
            Stream stream = new MemoryStream();
            m_streams.Add(stream);
            return stream;
        }

        int selectedIndex, IndexCorreo;
        private readonly RepositorioCodeas _repoCodeas = new RepositorioCodeas();
        private DataSet _ds;
        private DataTable _correos;
        // Diagnóstico de envío: el catch de SendMail re-marca la fila fallida; aquí además acumulamos
        // los errores y el conteo para informar UN resumen al final (antes el error se tragaba en silencio).
        private readonly List<string> _erroresEnvio = new List<string>();
        private int _enviados;
        public FrmEstadosDeCuenta()
        {
            InitializeComponent();
            ConfigurarColumnas();
            HabilitarBtn();
            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvListaCorreos);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para inmunizarlo al borrado del
        /// diseñador de VS — gotcha §11. dgvListaCorreos es hijo del combo de divisiones (DataRelation);
        /// "Marcar" es una columna CheckBox NO enlazada (selección para envío/impresión). El .cs accede a
        /// las celdas por Name → Names exactos. Edición vía GridColumnas.Edicion (§14.10).</summary>
        private void ConfigurarColumnas()
        {
            var CH = DataGridViewAutoSizeColumnMode.ColumnHeader;
            var Fill = DataGridViewAutoSizeColumnMode.Fill;
            dgvListaCorreos.AutoGenerateColumns = false;
            dgvListaCorreos.Columns.Clear();
            dgvListaCorreos.Columns.Add(GridColumnas.Texto("identidad", "Identidad", "Identidad", readOnly: false));
            dgvListaCorreos.Columns.Add(GridColumnas.Texto("nombres", "Nombres", "Nombres", autoSize: Fill, readOnly: false));
            dgvListaCorreos.Columns.Add(GridColumnas.Texto("correo", "Correo", "Correo", autoSize: Fill, readOnly: false));
            dgvListaCorreos.Columns.Add(GridColumnas.Check("activo", "Activo", "Activo", width: 48, autoSize: CH, readOnly: false));
            dgvListaCorreos.Columns.Add(GridColumnas.Check("Marcar", "", "Marcar", width: 72, autoSize: CH, readOnly: false));
            dgvListaCorreos.Columns.Add(GridColumnas.Texto("IdDivision", "IdDivision", "IdDivision", visible: false, readOnly: false));
            dgvListaCorreos.Columns.Add(GridColumnas.Texto("idAsociadoDataGridViewTextBoxColumn", "IdAsociado", "IdAsociado", visible: false, readOnly: false));
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void FrmEstadosDeCuenta_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        /// <summary>Arma el DataSet en memoria (divisiones=maestro, lista de correos=hijo) con la
        /// relación por IdDivision y enlaza el combo y el grid (patrón maestro-combo + grid por
        /// DataRelation, igual que frmSubMenu). El combo filtra el grid; las filas nuevas heredan el
        /// IdDivision del combo. El grid queda editable por defecto (como el diseño original) para que
        /// se puedan marcar correos.</summary>
        private void CargarDatos()
        {
            _ds = new DataSet();
            DataTable divisiones = _repoCodeas.ListarDivisiones();
            divisiones.TableName = "COD_Divisiones";
            _correos = _repoCodeas.ListarListaCorreos();
            _correos.TableName = "COD_ListaCorreos";
            _ds.Tables.Add(divisiones);
            _ds.Tables.Add(_correos);
            _ds.Relations.Add("FK_COD_ListaCorreos_COD_Divisiones",
                divisiones.Columns["IdDivision"], _correos.Columns["IdDivision"], false);

            cODDivisionesBindingSource.DataSource = _ds;
            cODDivisionesBindingSource.DataMember = "COD_Divisiones";
            fKCODListaCorreosCODDivisionesBindingSource.DataSource = cODDivisionesBindingSource;
            fKCODListaCorreosCODDivisionesBindingSource.DataMember = "FK_COD_ListaCorreos_COD_Divisiones";
            comboBox1.DataSource = cODDivisionesBindingSource;
            comboBox1.DisplayMember = "NombreDiv";
            comboBox1.ValueMember = "IdDivision";
            dgvListaCorreos.DataSource = fKCODListaCorreosCODDivisionesBindingSource;

            GridColumnas.Edicion(dgvListaCorreos, true);
            dgvListaCorreos.AllowUserToAddRows = false;
        }

        /// <summary>Refresca solo las filas de la lista de correos (preserva DataSet/relación/combo y
        /// la división seleccionada). Tras GuardarCambios el identity IdAsociado se obtiene al recargar.</summary>
        private void RecargarCorreos()
        {
            _correos.Clear();
            DataTable fresco = _repoCodeas.ListarListaCorreos();
            foreach (DataRow r in fresco.Rows)
                _correos.ImportRow(r);
            _correos.AcceptChanges();
        }
        private void SendMail(LocalReport rdlc, string Identidad, string Correo, string Nombre)
        {
            try
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
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = rdlc.Render
                ("PDF", deviceInfo, out mimeType, out encoding, out extension, out
                streamids, out warnings);

                MemoryStream memoryStream = new MemoryStream(bytes);
                memoryStream.Seek(0, SeekOrigin.Begin);

                SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential(ADIGGM.CapaDatos.AppConfig.SmtpEdoCtaUsuario, ADIGGM.CapaDatos.AppConfig.SmtpEdoCtaClave);
                MailAddress from = new MailAddress("jlanza@adiggm.hn", "Servidor A.D.I.-GGM");//, Encoding.UTF8);
                MailAddress to = new MailAddress(Correo);
                Attachment attachment = new Attachment(memoryStream, "Estado de Cuenta - " + Identidad + ".PDF");
                MailMessage message = new MailMessage(from, to);
                message.Body = @"<html>
                        <body>
                        <p>Buen día:</p>
                        <p>Se Adjunta Estado de Cuenta de Créditos y Aportaciones a la Fecha.</p>
                        <p></p>
                        <p></p>
                        <p><H6>Este mensaje ha sido enviado de forma automática a través del sistema de A.D.I.-GGM.
                        <br>Para consultas, comunicarse al correo jlanza@adiggm.hn.
                        <br>Si no desea recibir esta notificación, enviar un correo a jportillo@adiggm.hn.</br></br></H6></p>
                        </body>
                        </html>
                        ";
                message.IsBodyHtml = true;
                message.BodyEncoding = Encoding.UTF8;
                message.Subject = "A.D.I.-GGM - Estado de Cuenta - " + Nombre;
                //message.Subject = "Estado de Cuenta(Incluye Cap. de Excedentes 2025) - " + Nombre;
                message.Attachments.Add(attachment);
                message.SubjectEncoding = Encoding.UTF8;

                client.Send(message);

                memoryStream.Close();
                memoryStream.Dispose();
                dgvListaCorreos.Rows[IndexCorreo].Cells["Marcar"].Value = false;
                _enviados++;
            }
            catch (Exception ex)
            {
                // La fila queda marcada (feedback visual) y se acumula el error para el resumen final.
                dgvListaCorreos.Rows[IndexCorreo].Cells["Marcar"].Value = true;
                _erroresEnvio.Add(Identidad + " (" + Correo + "): " + ex.Message);
            }
        }

        public void ImpEstadoCuenta(LocalReport rdlc)
        {
            try
            {
                Export(rdlc);
                Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvListaCorreos.AllowUserToAddRows = true;
            GridColumnas.Edicion(dgvListaCorreos, true);
            dgvListaCorreos.FirstDisplayedScrollingRowIndex = dgvListaCorreos.RowCount - 1;
            var cantidadRow = dgvListaCorreos.RowCount - 1;
            dgvListaCorreos.CurrentCell = dgvListaCorreos.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListaCorreos.Rows.Count > 0 && dgvListaCorreos.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvListaCorreos.CurrentRow.Index;
                    dgvListaCorreos.EndEdit();
                    _repoCodeas.GuardarListaCorreos(_correos);
                    RecargarCorreos();
                    if (selectedIndex < dgvListaCorreos.RowCount)
                        dgvListaCorreos.CurrentCell = dgvListaCorreos.Rows[selectedIndex].Cells[1];
                    dgvListaCorreos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    GridColumnas.Edicion(dgvListaCorreos, false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvListaCorreos.Rows.Count > 0 && dgvListaCorreos.FirstDisplayedCell != null)
            {
                saveRow = dgvListaCorreos.FirstDisplayedCell.RowIndex;
                GridColumnas.Edicion(dgvListaCorreos, true);
                dgvListaCorreos.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvListaCorreos.Rows.Count)
                dgvListaCorreos.FirstDisplayedScrollingRowIndex = saveRow;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvListaCorreos.Rows.Count > 0 && dgvListaCorreos.FirstDisplayedCell != null)
            {
                selectedIndex = dgvListaCorreos.CurrentRow.Index;

                RecargarCorreos();
                if (selectedIndex < dgvListaCorreos.RowCount)
                    dgvListaCorreos.CurrentCell = dgvListaCorreos.Rows[selectedIndex].Cells[1];
                dgvListaCorreos.AllowUserToAddRows = false;

                GridColumnas.Edicion(dgvListaCorreos, false);
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void MarcarCorreo()
        {
            if (chkMarcar.Checked == true)
            {
                foreach (DataGridViewRow fila in dgvListaCorreos.Rows)
                {
                    fila.Cells["Marcar"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow fila in dgvListaCorreos.Rows)
                {
                    fila.Cells["Marcar"].Value = false;
                }
            }
        }
        private void chkMarcar_CheckedChanged(object sender, EventArgs e)
        {
            MarcarCorreo();
        }
        private void btnStartAsyncOperation_Click(object sender, EventArgs e)
        {
            // Cambia el estado de los botones en la interfaz de usuario en consecuencia.
            // El botón de inicio se desactiva tan pronto como se inicia la operación en segundo plano.
            // El botón Cancelar está habilitado para que el usuario pueda detener la operación en cualquier 
            // momento durante la ejecución.
            foreach (DataGridViewRow fila in dgvListaCorreos.Rows)
            {
                if (fila.Cells["Marcar"].Value == null)
                {
                    fila.Cells["Marcar"].Value = false;
                }
            }

            _erroresEnvio.Clear();
            _enviados = 0;

            pgbProcesos.Visible = true;
            btnStartAsyncOperation.Enabled = false;
            btnCancel.Enabled = true;

            // Inicia el subproceso para comenzar la función DoWork.
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }

            //chkMarcar.Checked = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                // Notifica al subproceso que se ha solicitado una cancelación.
                // La cancelación en realidad no sucederá hasta que el hilo en DoWork 
                // verifique el indicador m_oWorker.CancellationPending.
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // Se crea una instancia de LocalReport y se le asignan las propiedades
            // como ser la ruta del reporte, asi como el origenes de datos.
            LocalReport rdlc = CrearReporte();

            int totalselc = 0, i = 0;

            // Establece el total de correos marcados para ser enviados.
            foreach (DataGridViewRow row in dgvListaCorreos.Rows)
            {

                if (bool.Parse(row.Cells["Marcar"].Value.ToString()) == true && Convert.ToBoolean(row.Cells["activo"].Value.ToString()) == true)
                {
                    totalselc++;
                }
            }

            // Se ejecuta el envío de correos por cada usuario marcado en el datagrigview.
            foreach (DataGridViewRow row in dgvListaCorreos.Rows)
            {
                if (bool.Parse(row.Cells["Marcar"].Value.ToString()) == true && bool.Parse(row.Cells["activo"].Value.ToString()) == true)
                {
                    // Se llena el reporte instanciado con la informacion del usuario en cada recorrido.
                    CargarDatosReporte(rdlc, row.Cells["identidad"].Value.ToString());

                    // Esperamos 100 milisegundos por cada iteración.
                    //Thread.Sleep(100);

                    // Se envían los datos a la función de enviar correo.
                    IndexCorreo = row.Cells["Marcar"].RowIndex;
                    SendMail(rdlc, row.Cells["identidad"].Value.ToString(), row.Cells["correo"].Value.ToString(), row.Cells["nombres"].Value.ToString());

                    // Periódicamente se debe informar el progreso al hilo principal para que pueda actualizar
                    // la interfaz de usuario. En la mayoría de los casos, solo tendrá que enviar un número entero 
                    // que actualizará la barra de progreso.
                    i++;
                    backgroundWorker1.ReportProgress((100 * i) / totalselc);

                    // Periódicamente se revisa si una petición de cancelación está pendiente.
                    // Si el usuario hace clic en cancelar, m_AsyncWorker.CancelAsync() se activa; 
                    // lo que establecerá CancellationPending a verdadero.
                    // Se debe revisar este evento en cada ciclo.
                    // En caso de haber una cancelación, se establece e.Cancel a Verdadero y salimos del ciclo.
                    if (backgroundWorker1.CancellationPending)
                    {
                        // Establece e.Cancel en verdadero, por ende el evento WorkerCompleted
                        // sabe que el proceso fue cancelado.
                        e.Cancel = true;
                        backgroundWorker1.ReportProgress(0);
                        return;
                    }
                }
            }
            // Reporta el 100% de completación de la operación.
            backgroundWorker1.ReportProgress(100);
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Esta función se activa en el subproceso de la UI, 
            // por lo que es seguro editar el control de la UI directamente.
            // Se actualiza el progressBar con el número entero que nos ha 
            // proporcionado la función ReportProgress().
            pgbProcesos.Value = e.ProgressPercentage;

            if (pgbProcesos.Value > 0 && pgbProcesos.Value < 10)
            {
                lblFooter.Text = "Por Favor Espere... Iniciando Envíos..." + pgbProcesos.Value.ToString() + "%";
            }

            if (pgbProcesos.Value >= 10 && pgbProcesos.Value < 80)
            {
                lblFooter.Text = "Por Favor Espere... Enviando Correos..." + pgbProcesos.Value.ToString() + "%";
            }

            if (pgbProcesos.Value >= 80)
            {
                lblFooter.Text = "Por Favor Espere... Proceso Casi Completo..." + pgbProcesos.Value.ToString() + "%";
            }
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //El proceso en segundo plano esta completo. 
            //Se necesita inspeccionar los resultados
            //para ver si un error ocurrió, una cancelacion fue solicitada 
            //o si todo se completó satisfactoriamente
            if (e.Cancelled)
            {
                lblFooter.Text = "Proceso Cancelado.";
            }
            //Verifica si ocurrió un error en el proceso de segundo plano.
            else if (e.Error != null)
            {
                lblFooter.Text = "Ocurrió un Error Ejecutando la Operación en Segundo Plano";
            }
            else
            {
                //Todo el proceso se completó con normalidad
                lblFooter.Text = "Proceso Completado...";

                // Resumen del envío (antes los fallos se tragaban en silencio).
                if (_erroresEnvio.Count > 0)
                {
                    int mostrar = Math.Min(_erroresEnvio.Count, 10);
                    string detalle = string.Join("\n", _erroresEnvio.GetRange(0, mostrar));
                    if (_erroresEnvio.Count > mostrar) detalle += "\n...";
                    MessageBox.Show(
                        "Enviados: " + _enviados + "   Con error: " + _erroresEnvio.Count +
                        "\n\nLos correos con error siguen marcados.\n\nDetalle:\n" + detalle,
                        VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (_enviados == 0)
                {
                    MessageBox.Show("No se envió ningún correo. Verifique que marcó asociados ACTIVOS.",
                        VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Se enviaron " + _enviados + " correo(s) correctamente.",
                        VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Timer timer1 = new Timer();
                timer1.Interval = 5000;
                timer1.Tick += (s, a) => {
                    ((Timer)s).Stop();
                    lblFooter.Text = "Envío de Estados de Cuenta";
                    pgbProcesos.Visible = false;
                };
                timer1.Start();
            }
            btnStartAsyncOperation.Enabled = true;
            btnCancel.Enabled = false;
        }

        /// <summary>Crea el LocalReport del estado de cuenta con su recurso embebido y el parámetro Usuario.
        /// Los orígenes de datos se asignan por asociado con <see cref="CargarDatosReporte"/>.</summary>
        private LocalReport CrearReporte()
        {
            LocalReport rdlc = new LocalReport();
            rdlc.ReportEmbeddedResource = "ADIGGM.Informes.rptASMaestra.rdlc";
            rdlc.SetParameters(new ReportParameter[] { new ReportParameter("Usuario", VarGlobales.Usuario, false) });
            return rdlc;
        }

        /// <summary>Llena el reporte con los datos del asociado indicado (3 SP vía RepositorioCodeas).
        /// Reemplaza los Fill de los TableAdapters + rdlc.Refresh() del DataSet tipado.</summary>
        private void CargarDatosReporte(LocalReport rdlc, string identidad)
        {
            rdlc.DataSources.Clear();
            rdlc.DataSources.Add(new ReportDataSource("DsASMaestras", _repoCodeas.CargarASMaestras(identidad)));
            rdlc.DataSources.Add(new ReportDataSource("DsEstadoCuenta", _repoCodeas.CargarEstadoCuenta(identidad)));
            rdlc.DataSources.Add(new ReportDataSource("DsEstadoCuentaDet", _repoCodeas.CargarEstadoCuentaDet(identidad)));
        }

        // Export the given report as an EMF (Enhanced Metafile) file.
        private void Export(LocalReport report)
        {
            string deviceInfo =
              @"<DeviceInfo>
                <OutputFormat>EMF</OutputFormat>
                <PageWidth>8.5in</PageWidth>
                <PageHeight>11in</PageHeight>
                <MarginTop>0in</MarginTop>
                <MarginLeft>0in</MarginLeft>
                <MarginRight>0in</MarginRight>
                <MarginBottom>0in</MarginBottom>
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
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                m_currentPageIndex = 0;
                printDoc.Print();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow fila in dgvListaCorreos.Rows)
            {
                if (fila.Cells["Marcar"].Value == null)
                {
                    fila.Cells["Marcar"].Value = false;
                }
            }
            // Se crea una instancia de LocalReport y se le asignan las propiedades
            // como ser la ruta del reporte, asi como el origenes de datos.
            LocalReport rdlc = CrearReporte();

            // Se ejecuta la impresión de correos por cada asociado marcado
            foreach (DataGridViewRow row in dgvListaCorreos.Rows)
            {
                if (bool.Parse(row.Cells["Marcar"].Value.ToString()) == true && bool.Parse(row.Cells["activo"].Value.ToString()) == true)
                {
                    // Se llena el reporte instanciado con la informacion del usuario en cada recorrido.
                    CargarDatosReporte(rdlc, row.Cells["identidad"].Value.ToString());

                    // Se envían los datos a la función de enviar correo.
                    ImpEstadoCuenta(rdlc);
                }
            }
        }
    }
}