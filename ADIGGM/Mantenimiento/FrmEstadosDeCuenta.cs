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
        public FrmEstadosDeCuenta()
        {
            InitializeComponent();
            HabilitarBtn();
            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvListaCorreos);
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
            this.cOD_DivisionesTableAdapter.Fill(this.dsCodeasAdiggm.COD_Divisiones);
            this.cOD_ListaCorreosTableAdapter.Fill(this.dsCodeasAdiggm.COD_ListaCorreos);
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
                client.Credentials = new System.Net.NetworkCredential("jlanza@adiggm.hn", "JuniorADI@19");
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
            }
            //catch (Exception ex)
            catch (Exception)
            {
                //MessageBox.Show("Ha ocurrido un error en el envío:\n" + ex.ToString(), "TransporteAdiggm", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dgvListaCorreos.Rows[IndexCorreo].Cells["Marcar"].Value = true;
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
            dgvListaCorreos.ReadOnly = false;
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
                    this.cOD_ListaCorreosTableAdapter.Update(this.dsCodeasAdiggm.COD_ListaCorreos);
                    dgvListaCorreos.CurrentCell = dgvListaCorreos.Rows[selectedIndex].Cells[1];
                    dgvListaCorreos.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvListaCorreos.ReadOnly = true;
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
                dgvListaCorreos.ReadOnly = false;
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

                this.cOD_ListaCorreosTableAdapter.Fill(this.dsCodeasAdiggm.COD_ListaCorreos);
                dgvListaCorreos.CurrentCell = dgvListaCorreos.Rows[selectedIndex].Cells[1];
                dgvListaCorreos.AllowUserToAddRows = false;

                dgvListaCorreos.ReadOnly = true;
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
            LocalReport rdlc = new LocalReport();
            rdlc.DataSources.Clear();
            rdlc.ReportEmbeddedResource = "ADIGGM.Informes.rptASMaestra.rdlc";
            DataTable COD_SlcASMaestra = dsCodeasAdiggm.COD_SlcASMaestras;
            rdlc.DataSources.Add(new ReportDataSource("DsASMaestras", COD_SlcASMaestra));
            DataTable COD_SlcEstadoCuenta = dsCodeasAdiggm.COD_SlcEstadoCuenta;
            rdlc.DataSources.Add(new ReportDataSource("DsEstadoCuenta", COD_SlcEstadoCuenta));
            DataTable COD_SlcEstadoCuentaDet = dsCodeasAdiggm.COD_SlcEstadoCuentaDet;
            rdlc.DataSources.Add(new ReportDataSource("DsEstadoCuentaDet", COD_SlcEstadoCuentaDet));

            ReportParameter[] reportParameters = new ReportParameter[1];
            reportParameters[0] = new ReportParameter("Usuario", VarGlobales.Usuario, false);
            rdlc.SetParameters(reportParameters);

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
                    this.cOD_SlcASMaestrasTableAdapter.Fill(this.dsCodeasAdiggm.COD_SlcASMaestras, row.Cells["identidad"].Value.ToString());
                    this.cOD_SlcEstadoCuentaTableAdapter.Fill(this.dsCodeasAdiggm.COD_SlcEstadoCuenta, row.Cells["identidad"].Value.ToString());
                    this.cOD_SlcEstadoCuentaDetTableAdapter.Fill(this.dsCodeasAdiggm.COD_SlcEstadoCuentaDet, row.Cells["identidad"].Value.ToString());

                    // Se refresca el reporte
                    rdlc.Refresh();

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
            LocalReport rdlc = new LocalReport();
            rdlc.DataSources.Clear();
            rdlc.ReportEmbeddedResource = "ADIGGM.Informes.rptASMaestra.rdlc";
            DataTable COD_SlcASMaestra = dsCodeasAdiggm.COD_SlcASMaestras;
            rdlc.DataSources.Add(new ReportDataSource("DsASMaestras", COD_SlcASMaestra));
            DataTable COD_SlcEstadoCuenta = dsCodeasAdiggm.COD_SlcEstadoCuenta;
            rdlc.DataSources.Add(new ReportDataSource("DsEstadoCuenta", COD_SlcEstadoCuenta));
            DataTable COD_SlcEstadoCuentaDet = dsCodeasAdiggm.COD_SlcEstadoCuentaDet;
            rdlc.DataSources.Add(new ReportDataSource("DsEstadoCuentaDet", COD_SlcEstadoCuentaDet));

            ReportParameter[] reportParameters = new ReportParameter[1];
            reportParameters[0] = new ReportParameter("Usuario", VarGlobales.Usuario, false);
            rdlc.SetParameters(reportParameters);

            // Se ejecuta la impresión de correos por cada asociado marcado
            foreach (DataGridViewRow row in dgvListaCorreos.Rows)
            {
                if (bool.Parse(row.Cells["Marcar"].Value.ToString()) == true && bool.Parse(row.Cells["activo"].Value.ToString()) == true)
                {
                    // Se llena el reporte instanciado con la informacion del usuario en cada recorrido.
                    this.cOD_SlcASMaestrasTableAdapter.Fill(this.dsCodeasAdiggm.COD_SlcASMaestras, row.Cells["identidad"].Value.ToString());
                    this.cOD_SlcEstadoCuentaTableAdapter.Fill(this.dsCodeasAdiggm.COD_SlcEstadoCuenta, row.Cells["identidad"].Value.ToString());
                    this.cOD_SlcEstadoCuentaDetTableAdapter.Fill(this.dsCodeasAdiggm.COD_SlcEstadoCuentaDet, row.Cells["identidad"].Value.ToString());

                    // Se refresca el reporte
                    rdlc.Refresh();

                    // Se envían los datos a la función de enviar correo.
                    ImpEstadoCuenta(rdlc);
                }
            }
        }
    }
}