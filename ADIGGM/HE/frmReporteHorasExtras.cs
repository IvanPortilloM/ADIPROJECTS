using ADIGGM.Clases;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using ADIGGM.CapaDatos;
using ADIGGM.CapaModelo;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ADIGGM.HE
{
    public partial class frmReporteHorasExtras : FrmPrincipal
    {
        private readonly RepositorioMotoristas _repoMotoristas = new RepositorioMotoristas();
        private readonly RepositorioReporteHoras _repoReporte = new RepositorioReporteHoras();

        public frmReporteHorasExtras()
        {
            InitializeComponent();
        }

        private void frmReporteHorasExtras_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CargarMotoristas();

            // Configurar fechas por defecto (ej. quincena actual)
            DateTime hoy = DateTime.Today;
            if (hoy.Day <= 15)
            {
                dtpInicio.Value = new DateTime(hoy.Year, hoy.Month, 1);
                dtpFin.Value = new DateTime(hoy.Year, hoy.Month, 15);
            }
            else
            {
                dtpInicio.Value = new DateTime(hoy.Year, hoy.Month, 16);
                dtpFin.Value = new DateTime(hoy.Year, hoy.Month, DateTime.DaysInMonth(hoy.Year, hoy.Month));
            }
        }

        private void ConfigurarGrid()
        {
            dgvReporte.Columns.Clear();
            dgvReporte.AutoGenerateColumns = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            // Columnas de Información
            dgvReporte.Columns.Add("colMotorista", "Motorista");
            dgvReporte.Columns.Add("colIdentidad", "Identidad");
            dgvReporte.Columns["colIdentidad"].Visible = false;
            dgvReporte.Columns.Add("colSalarioBase", "Salario Base");
            dgvReporte.Columns["colSalarioBase"].Visible = false;
            dgvReporte.Columns.Add("colFecha", "Fecha");
            dgvReporte.Columns.Add("colDia", "Día");
            dgvReporte.Columns.Add("colHorario", "Horario");
            dgvReporte.Columns["colHorario"].DefaultCellStyle.WrapMode = DataGridViewTriState.True; // Permitir varias líneas

            // Columnas de Horas Regulares
            AgregarColumnaNumerica("colTotal", "T.Hrs");
            AgregarColumnaNumerica("colRegD", "Hrs.Diur.");
            AgregarColumnaNumerica("colRegN", "Hrs.Noct.");

            // --- Columnas de Extras (Horas y Lempiras) ---
            AgregarColumnaNumerica("colExt25", "Hrs.25%");
            AgregarColumnaMoneda("colLps25", "Lps.25%");

            AgregarColumnaNumerica("colExt50", "Hrs.50%");
            AgregarColumnaMoneda("colLps50", "Lps.50%");

            AgregarColumnaNumerica("colExt75", "Hrs.75%");
            AgregarColumnaMoneda("colLps75", "Lps.75%");

            AgregarColumnaNumerica("colExt100", "Hrs.100%");
            AgregarColumnaMoneda("colLps100", "Lps.100%");

            // --- Columna de Total Pago ---
            AgregarColumnaMoneda("colTotalLps", "Total.Extras");
            dgvReporte.Columns["colTotalLps"].DefaultCellStyle.Font = new Font(dgvReporte.Font, FontStyle.Bold);

            dgvReporte.Columns["colMotorista"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReporte.Columns["colDia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
        }

        private void AgregarColumnaNumerica(string name, string header)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = name;
            col.HeaderText = header;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col.DefaultCellStyle.Format = "N2";
            dgvReporte.Columns.Add(col);
        }

        private void AgregarColumnaMoneda(string name, string header)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = name;
            col.HeaderText = header;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col.DefaultCellStyle.Format = "C2";
            dgvReporte.Columns.Add(col);
        }

        private void CargarMotoristas()
        {
            try
            {
                var lista = _repoMotoristas.ListarEmpleadosActivos();
                lista.Insert(0, new MotoristaItem { IdMotorista = 0, Motorista = "(Todos los Motoristas)" });

                cboMotoristas.DisplayMember = "Motorista";
                cboMotoristas.ValueMember = "IdMotorista";
                cboMotoristas.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar motoristas: " + ex.Message);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;
            int idMotoristaSeleccionado = (int)cboMotoristas.SelectedValue;
            bool mostrarTodos = chkMostrarTodosLosDias.Checked;

            dgvReporte.Rows.Clear();

            DataTable datosCrudos = ObtenerDatosCrudos(fechaInicio, fechaFin, idMotoristaSeleccionado);

            if (datosCrudos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron registros de asistencia para los filtros seleccionados.");
                return;
            }

            ProcesarYMostrarDatos(datosCrudos, mostrarTodos);
            CalcularYMostrarTotales();
        }

        private DataTable ObtenerDatosCrudos(DateTime inicio, DateTime fin, int idMotorista)
        {
            try
            {
                return _repoReporte.ObtenerDatos(inicio, fin, idMotorista);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos: " + ex.Message);
                return new DataTable();
            }
        }

        private void ProcesarYMostrarDatos(DataTable dt, bool mostrarTodos)
        {
            var agrupadoPorMotorista = dt.AsEnumerable()
                .GroupBy(row => new { Id = row.Field<int>("IdMotorista"), Nombre = row.Field<string>("Motorista") });

            foreach (var grupoMotorista in agrupadoPorMotorista)
            {
                string nombreMotorista = grupoMotorista.Key.Nombre;
                var filaInfo = grupoMotorista.First();

                PoliticaPago politicaMotorista = new PoliticaPago
                {
                    PagaExtrasDiarias = filaInfo.Field<bool>("PagaExtrasDiarias"),
                    PagaDomingos = filaInfo.Field<bool>("PagaDomingos"),
                    PagaFeriados = filaInfo.Field<bool>("PagaFeriados"),
                    AplicaJornadaMixta = filaInfo.Field<bool>("AplicaJornadaMixta")
                };

                string identidad = filaInfo.Field<string>("Identidad") ?? "";

                var diasDelMotorista = grupoMotorista.GroupBy(row => row.Field<DateTime>("Fecha"));

                foreach (var grupoDia in diasDelMotorista)
                {
                    DateTime fecha = grupoDia.Key;

                    // --- NUEVA LÓGICA: CÁLCULO DE SALARIO Y TASAS POR DÍA ---
                    decimal? salarioDelDia = grupoDia.First().Field<decimal?>("SalarioQuincenal");
                    decimal valorHoraBase = 0;

                    if (salarioDelDia.HasValue && salarioDelDia.Value > 0)
                    {
                        valorHoraBase = (salarioDelDia.Value / 15m) / 8m;
                    }

                    decimal tasaPago25 = valorHoraBase * 1.25m;
                    decimal tasaPago50 = valorHoraBase * 1.50m;
                    decimal tasaPago75 = valorHoraBase * 1.75m;
                    decimal tasaPago100 = valorHoraBase * 2.00m;
                    // --------------------------------------------------------

                    bool esFeriado = grupoDia.First().Field<int>("EsFeriado") == 1;

                    List<RangoHora> rangosDelDia = new List<RangoHora>();
                    foreach (DataRow filaRango in grupoDia)
                    {
                        rangosDelDia.Add(new RangoHora
                        {
                            Inicio = filaRango.Field<DateTime>("HoraInicio"),
                            Fin = filaRango.Field<DateTime>("HoraFin")
                        });
                    }

                    ResultadoDia resultado = CalculadoraHoras.CalcularDia(fecha, rangosDelDia, esFeriado, politicaMotorista);

                    decimal horasRegularesTotales = resultado.RegularesDiurnas + resultado.RegularesNocturnas;
                    string horarioMostrar = GenerarTextoHorarioExtras(rangosDelDia, horasRegularesTotales);

                    decimal lps25 = resultado.Extras25 * tasaPago25;
                    decimal lps50 = resultado.Extras50 * tasaPago50;
                    decimal lps75 = resultado.Extras75 * tasaPago75;
                    decimal lps100 = resultado.Extras100 * tasaPago100;
                    decimal totalLpsDia = lps25 + lps50 + lps75 + lps100;

                    decimal totalHorasExtrasDelDia = resultado.Extras25 + resultado.Extras50 + resultado.Extras75 + resultado.Extras100;

                    if (mostrarTodos || totalHorasExtrasDelDia > 0)
                    {
                        if (resultado.TotalHoras > 0)
                        {
                            string diaSemana = fecha.ToString("ddd", new CultureInfo("es-ES"));

                            dgvReporte.Rows.Add(
                                nombreMotorista,
                                identidad,
                                salarioDelDia ?? 0, // Guardamos el salario exacto de este día
                                fecha.ToShortDateString(),
                                diaSemana.ToUpper(),
                                horarioMostrar,
                                resultado.TotalHoras,
                                resultado.RegularesDiurnas,
                                resultado.RegularesNocturnas,
                                resultado.Extras25,
                                lps25,
                                resultado.Extras50,
                                lps50,
                                resultado.Extras75,
                                lps75,
                                resultado.Extras100,
                                lps100,
                                totalLpsDia
                            );
                        }
                    }
                }
            }
        }

        private void CalcularYMostrarTotales()
        {
            decimal totalRegDiurnas = 0, totalRegNocturnas = 0;
            decimal totalExt25 = 0, totalExt50 = 0, totalExt75 = 0, totalExt100 = 0;
            decimal granTotalLps = 0;

            foreach (DataGridViewRow row in dgvReporte.Rows)
            {
                try
                {
                    totalRegDiurnas += Convert.ToDecimal(row.Cells["colRegD"].Value);
                    totalRegNocturnas += Convert.ToDecimal(row.Cells["colRegN"].Value);
                    totalExt25 += Convert.ToDecimal(row.Cells["colLps25"].Value);
                    totalExt50 += Convert.ToDecimal(row.Cells["colLps50"].Value);
                    totalExt75 += Convert.ToDecimal(row.Cells["colLps75"].Value);
                    totalExt100 += Convert.ToDecimal(row.Cells["colLps100"].Value);
                    granTotalLps += Convert.ToDecimal(row.Cells["colTotalLps"].Value);
                }
                catch { }
            }

            lblTotalRegulares.Text = $"Regulares: {(totalRegDiurnas + totalRegNocturnas).ToString("N2")}";
            lblTotalExtras25.Text = $"Extras 25%: {totalExt25.ToString("C2")}";
            lblTotalExtras50.Text = $"Extras 50%: {totalExt50.ToString("C2")}";
            lblTotalExtras75.Text = $"Extras 75%: {totalExt75.ToString("C2")}";
            lblTotalExtras100.Text = $"Extras 100%: {totalExt100.ToString("C2")}";
            lblGranTotalLps.Text = $"Total a Pagar (Extras): {granTotalLps.ToString("C2")}";

            pnlTotales.Visible = true;
        }

        private void chkMostrarTodosLosDias_CheckedChanged(object sender, EventArgs e)
        {
            btnGenerar_Click(null, null); // Reutilizamos el evento
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nombreArchivo = $"Reporte_HE_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                string rutaCompleta = Path.Combine(Path.GetTempPath(), nombreArchivo);

                ExportarReporteEstiloImagen(rutaCompleta);

                var processInfo = new System.Diagnostics.ProcessStartInfo(rutaCompleta) { UseShellExecute = true };
                System.Diagnostics.Process.Start(processInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar o abrir el Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarReporteEstiloImagen(string rutaArchivo)
        {
            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Horas Extras");

                ws.PageSetup.PageOrientation = XLPageOrientation.Landscape;
                ws.PageSetup.Footer.Center.AddText("Pág. ", XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(XLHFPredefinedText.PageNumber, XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(" de ", XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(XLHFPredefinedText.NumberOfPages, XLHFOccurrence.AllPages);

                string quincena = dtpFin.Value.Day <= 15 ? "PRIMERA" : "SEGUNDA";
                string mesNombre = dtpFin.Value.ToString("MMMM", new CultureInfo("es-ES")).ToUpper();
                string anio = dtpFin.Value.Year.ToString();
                string subtitulo = $"PERSONAL DE TRANSPORTE - {quincena} QUINCENA {mesNombre} {anio}";

                var logoBitmap = Properties.Resources.logo;
                if (logoBitmap != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        logoBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ms.Seek(0, SeekOrigin.Begin);
                        var image = ws.AddPicture(ms).MoveTo(ws.Cell(2, 3), 55, 5).Scale(0.7);
                    }
                }

                int filaActual = 2;
                int colInicioTitulos = 1;
                int colFinTitulos = 12;

                ws.Cell(filaActual, colInicioTitulos).Value = "REPORTE CONTROL DE HORAS EXTRAS";
                ws.Range(filaActual, colInicioTitulos, filaActual, colFinTitulos).Merge().Style
                    .Font.SetBold().Font.SetFontSize(16)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                filaActual++;

                ws.Cell(filaActual, colInicioTitulos).Value = subtitulo;
                ws.Range(filaActual, colInicioTitulos, filaActual, colFinTitulos).Merge().Style
                    .Font.SetBold().Font.SetFontSize(12)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                filaActual++;

                ws.Cell(filaActual, colInicioTitulos).Value = $"Del {dtpInicio.Value:dd-MM-yyyy} al {dtpFin.Value:dd-MM-yyyy}";
                ws.Range(filaActual, colInicioTitulos, filaActual, colFinTitulos).Merge().Style
                    .Font.SetFontSize(11)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                filaActual += 2;

                string motoristaActual = "";
                string identidadActualCache = "";
                decimal salarioActualCache = 0;

                decimal sumTotalHorasExtras = 0;
                decimal sumLps25 = 0, sumLps50 = 0, sumLps75 = 0, sumLps100 = 0;
                decimal granTotalLps = 0;

                for (int i = 0; i < dgvReporte.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvReporte.Rows[i];
                    string motoristaFila = row.Cells["colMotorista"].Value.ToString();
                    string identidadFila = row.Cells["colIdentidad"].Value?.ToString() ?? "";

                    decimal salarioFila = 0;
                    if (row.Cells["colSalarioBase"].Value != null)
                        decimal.TryParse(row.Cells["colSalarioBase"].Value.ToString(), out salarioFila);

                    if (motoristaFila != motoristaActual)
                    {
                        if (!string.IsNullOrEmpty(motoristaActual))
                        {
                            ImprimirPieGrupo(ws, ref filaActual, sumTotalHorasExtras, sumLps25, sumLps50, sumLps75, sumLps100, salarioActualCache);
                            filaActual++;
                            granTotalLps += (sumLps25 + sumLps50 + sumLps75 + sumLps100);
                        }

                        motoristaActual = motoristaFila;
                        identidadActualCache = identidadFila;
                        salarioActualCache = salarioFila; // Al inicio toma el primer salario de su rango

                        sumTotalHorasExtras = 0; sumLps25 = 0; sumLps50 = 0; sumLps75 = 0; sumLps100 = 0;

                        ws.Cell(filaActual, 1).Value = $"Nombre Empleado: {motoristaActual}";
                        ws.Cell(filaActual, 1).Style.Font.SetBold().Font.SetFontSize(11);
                        ws.Range(filaActual, 1, filaActual, 6).Merge();

                        ws.Cell(filaActual, 8).Value = $"Identidad: {identidadActualCache}";
                        ws.Cell(filaActual, 8).Style.Font.SetBold();
                        ws.Range(filaActual, 8, filaActual, 11).Merge();

                        filaActual++;
                        ImprimirEncabezadosTabla(ws, ref filaActual);
                    }
                    else
                    {
                        // Si cambia de salario a medio periodo, actualizamos el caché para 
                        // que el bloque final imprima el salario MÁS RECIENTE.
                        salarioActualCache = salarioFila;
                    }

                    ws.Row(filaActual).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);
                    ws.Cell(filaActual, 1).Value = row.Cells["colFecha"].Value.ToString();
                    ws.Cell(filaActual, 2).Value = row.Cells["colDia"].Value.ToString();
                    ws.Cell(filaActual, 3).Value = row.Cells["colHorario"].Value.ToString();
                    ws.Cell(filaActual, 3).Style.Alignment.WrapText = true;

                    decimal hrs25 = ObtenerValorDecimal(row, "colExt25");
                    decimal hrs50 = ObtenerValorDecimal(row, "colExt50");
                    decimal hrs75 = ObtenerValorDecimal(row, "colExt75");
                    decimal hrs100 = ObtenerValorDecimal(row, "colExt100");

                    decimal totalExtrasFila = hrs25 + hrs50 + hrs75 + hrs100;

                    if (totalExtrasFila == 0) ws.Cell(filaActual, 4).Value = "-";
                    else ws.Cell(filaActual, 4).Value = totalExtrasFila;
                    ws.Cell(filaActual, 4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    EscribirCeldaMonedaCondicional(ws, filaActual, 5, hrs25, false);
                    EscribirCeldaMonedaCondicional(ws, filaActual, 6, ObtenerValorDecimal(row, "colLps25"), true);

                    EscribirCeldaMonedaCondicional(ws, filaActual, 7, hrs50, false);
                    EscribirCeldaMonedaCondicional(ws, filaActual, 8, ObtenerValorDecimal(row, "colLps50"), true);

                    EscribirCeldaMonedaCondicional(ws, filaActual, 9, hrs75, false);
                    EscribirCeldaMonedaCondicional(ws, filaActual, 10, ObtenerValorDecimal(row, "colLps75"), true);

                    EscribirCeldaMonedaCondicional(ws, filaActual, 11, hrs100, false);
                    EscribirCeldaMonedaCondicional(ws, filaActual, 12, ObtenerValorDecimal(row, "colLps100"), true);

                    sumTotalHorasExtras += totalExtrasFila;
                    sumLps25 += Convert.ToDecimal(row.Cells["colLps25"].Value);
                    sumLps50 += Convert.ToDecimal(row.Cells["colLps50"].Value);
                    sumLps75 += Convert.ToDecimal(row.Cells["colLps75"].Value);
                    sumLps100 += Convert.ToDecimal(row.Cells["colLps100"].Value);

                    ws.Range(filaActual, 1, filaActual, 12).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    ws.Range(filaActual, 1, filaActual, 12).Style.Border.BottomBorderColor = XLColor.LightGray;

                    filaActual++;
                }

                if (!string.IsNullOrEmpty(motoristaActual))
                {
                    ImprimirPieGrupo(ws, ref filaActual, sumTotalHorasExtras, sumLps25, sumLps50, sumLps75, sumLps100, salarioActualCache);
                    granTotalLps += (sumLps25 + sumLps50 + sumLps75 + sumLps100);
                }

                filaActual += 2;
                ws.Range(filaActual, 1, filaActual, 10).Merge().Value = "TOTAL HRS EXTRAS:";
                ws.Range(filaActual, 1, filaActual, 10).Style.Font.SetBold().Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);
                ws.Range(filaActual, 11, filaActual, 12).Merge().Value = granTotalLps;
                ws.Range(filaActual, 11, filaActual, 12).Style.Font.SetBold().NumberFormat.Format = "\"L. \"#,##0.00";
                ws.Range(filaActual, 11, filaActual, 12).Style.Fill.BackgroundColor = XLColor.Yellow;

                filaActual += 6;
                var rangoElaborado = ws.Range(filaActual, 2, filaActual, 4);
                rangoElaborado.Merge().Value = "Elaborado Por: Darwin Noe Flores";
                rangoElaborado.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangoElaborado.Style.Font.SetBold().Border.TopBorder = XLBorderStyleValues.Thin;

                var rangoAutorizado = ws.Range(filaActual, 8, filaActual, 11);
                rangoAutorizado.Merge().Value = "Autorizado Por: Julio Cesar Flores";
                rangoAutorizado.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangoAutorizado.Style.Font.SetBold().Border.TopBorder = XLBorderStyleValues.Thin;

                ws.Columns().AdjustToContents();
                ws.Column(3).Width = 28;
                ws.Column(2).Width = 10;
                for (int c = 5; c <= 12; c++) { if (ws.Column(c).Width < 10) ws.Column(c).Width = 10; }

                workbook.SaveAs(rutaArchivo);
            }
        }

        private decimal ObtenerValorDecimal(DataGridViewRow row, string colName)
        {
            if (row.Cells[colName].Value != null && row.Cells[colName].Value != DBNull.Value)
            {
                if (decimal.TryParse(row.Cells[colName].Value.ToString(), out decimal val))
                    return val;
            }
            return 0;
        }

        private void EscribirCeldaMonedaCondicional(IXLWorksheet ws, int fila, int col, decimal valor, bool esLempiras)
        {
            if (valor == 0)
            {
                ws.Cell(fila, col).Value = "-";
                ws.Cell(fila, col).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            }
            else
            {
                ws.Cell(fila, col).Value = valor;
                if (esLempiras)
                    ws.Cell(fila, col).Style.NumberFormat.Format = "\"L. \"#,##0.00";
                else
                    ws.Cell(fila, col).Style.NumberFormat.Format = "#,##0.00";
            }
        }

        private void EscribirCeldaMoneda(IXLWorksheet ws, int fila, int col, decimal valor)
        {
            EscribirCeldaMonedaCondicional(ws, fila, col, valor, true);
        }

        private void ImprimirEncabezadosTabla(IXLWorksheet ws, ref int fila)
        {
            var estiloHeader = ws.Range(fila, 5, fila, 12).Style;
            estiloHeader.Fill.BackgroundColor = XLColor.Gray;
            estiloHeader.Font.FontColor = XLColor.White;
            estiloHeader.Font.SetBold();
            estiloHeader.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            ws.Cell(fila, 5).Value = "Horas 25%"; ws.Range(fila, 5, fila, 6).Merge();
            ws.Cell(fila, 7).Value = "Horas 50%"; ws.Range(fila, 7, fila, 8).Merge();
            ws.Cell(fila, 9).Value = "Horas 75%"; ws.Range(fila, 9, fila, 10).Merge();
            ws.Cell(fila, 11).Value = "Horas 100%"; ws.Range(fila, 11, fila, 12).Merge();
            fila++;

            var estiloSub = ws.Range(fila, 1, fila, 12).Style;
            estiloSub.Fill.BackgroundColor = XLColor.LightGray;
            estiloSub.Font.SetBold();
            estiloSub.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            ws.Cell(fila, 1).Value = "Fecha";
            ws.Cell(fila, 2).Value = "Día";
            ws.Cell(fila, 3).Value = "Horario";
            ws.Cell(fila, 4).Value = "Tot. Extras";

            for (int c = 5; c <= 11; c += 2) { ws.Cell(fila, c).Value = "Hrs"; ws.Cell(fila, c + 1).Value = "LPS"; }
            fila++;
        }

        private void ImprimirPieGrupo(IXLWorksheet ws, ref int fila, decimal totHrs, decimal lps25, decimal lps50, decimal lps75, decimal lps100, decimal salarioBase)
        {
            var rango = ws.Range(fila, 1, fila, 12);
            rango.Style.Fill.BackgroundColor = XLColor.DimGray;
            rango.Style.Font.FontColor = XLColor.White;
            rango.Style.Font.SetBold();

            ws.Cell(fila, 1).Value = "TOTAL HORAS EXTRAS";
            ws.Range(fila, 1, fila, 3).Merge();

            ws.Cell(fila, 4).Value = totHrs;
            ws.Cell(fila, 6).Value = lps25; ws.Cell(fila, 6).Style.NumberFormat.Format = "\"L. \"#,##0.00";
            ws.Cell(fila, 8).Value = lps50; ws.Cell(fila, 8).Style.NumberFormat.Format = "\"L. \"#,##0.00";
            ws.Cell(fila, 10).Value = lps75; ws.Cell(fila, 10).Style.NumberFormat.Format = "\"L. \"#,##0.00";
            ws.Cell(fila, 12).Value = lps100; ws.Cell(fila, 12).Style.NumberFormat.Format = "\"L. \"#,##0.00";

            decimal totalSoloExtras = lps25 + lps50 + lps75 + lps100;

            fila++;
            ws.Cell(fila, 9).Value = "Salario Quincenal:";
            ws.Range(fila, 9, fila, 11).Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            ws.Range(fila, 9, fila, 11).Style.Font.SetBold();
            ws.Cell(fila, 12).Value = salarioBase;
            ws.Cell(fila, 12).Style.NumberFormat.Format = "\"L. \"#,##0.00";

            fila++;
            ws.Cell(fila, 9).Value = "(+) Total Extras:";
            ws.Range(fila, 9, fila, 11).Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            ws.Range(fila, 9, fila, 11).Style.Font.SetBold();
            ws.Cell(fila, 12).Value = totalSoloExtras;
            ws.Cell(fila, 12).Style.NumberFormat.Format = "\"L. \"#,##0.00";
            ws.Cell(fila, 12).Style.Border.BottomBorder = XLBorderStyleValues.Thin;

            fila++;
            ws.Cell(fila, 9).Value = "TOTAL A PAGAR:";
            ws.Range(fila, 9, fila, 11).Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            ws.Range(fila, 9, fila, 11).Style.Font.SetBold();

            decimal granTotalQuincena = salarioBase + totalSoloExtras;
            var celdaTotal = ws.Cell(fila, 12);
            celdaTotal.Value = granTotalQuincena;
            celdaTotal.Style.Font.SetBold().Fill.BackgroundColor = XLColor.LightGreen;
            celdaTotal.Style.NumberFormat.Format = "\"L. \"#,##0.00";
            celdaTotal.Style.Border.BottomBorder = XLBorderStyleValues.Double;
        }

        private string GenerarTextoHorarioExtras(List<RangoHora> rangos, decimal horasRegularesDelDia)
        {
            if (horasRegularesDelDia == 0)
            {
                List<string> textos = new List<string>();
                foreach (var r in rangos) textos.Add($"{r.Inicio:hh:mm tt} - {r.Fin:hh:mm tt}");
                return string.Join("\n", textos);
            }

            List<string> rangosExtras = new List<string>();
            double minutosRegularesPorConsumir = (double)horasRegularesDelDia * 60;

            foreach (var rango in rangos.OrderBy(r => r.Inicio))
            {
                double duracionMinutos = (rango.Fin - rango.Inicio).TotalMinutes;

                if (minutosRegularesPorConsumir >= duracionMinutos)
                {
                    minutosRegularesPorConsumir -= duracionMinutos;
                }
                else if (minutosRegularesPorConsumir > 0)
                {
                    DateTime inicioExtra = rango.Inicio.AddMinutes(minutosRegularesPorConsumir);
                    rangosExtras.Add($"{inicioExtra:hh:mm tt} - {rango.Fin:hh:mm tt}");
                    minutosRegularesPorConsumir = 0;
                }
                else
                {
                    rangosExtras.Add($"{rango.Inicio:hh:mm tt} - {rango.Fin:hh:mm tt}");
                }
            }

            if (rangosExtras.Count == 0) return "Sin Extras";
            return string.Join("\n", rangosExtras);
        }

        public class ResumenEmpleado
        {
            public string Nombre { get; set; }
            public string Identidad { get; set; }
            public decimal SalarioBase { get; set; }

            public decimal SumHrs25 { get; set; }
            public decimal SumHrs50 { get; set; }
            public decimal SumHrs75 { get; set; }
            public decimal SumHrs100 { get; set; }

            public decimal TotalLps25 { get; set; }
            public decimal TotalLps50 { get; set; }
            public decimal TotalLps75 { get; set; }
            public decimal TotalLps100 { get; set; }

            public decimal TotalHorasExtras => SumHrs25 + SumHrs50 + SumHrs75 + SumHrs100;
            public decimal TotalDineroExtras => TotalLps25 + TotalLps50 + TotalLps75 + TotalLps100;
            public decimal GranTotalPagar => SalarioBase + TotalDineroExtras;
        }

        private void btnExportarConsolidado_Click(object sender, EventArgs e)
        {
            if (dgvReporte.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            Dictionary<string, ResumenEmpleado> consolidados = new Dictionary<string, ResumenEmpleado>();

            foreach (DataGridViewRow row in dgvReporte.Rows)
            {
                string nombre = row.Cells["colMotorista"].Value.ToString();

                if (!consolidados.ContainsKey(nombre))
                {
                    string identidad = row.Cells["colIdentidad"].Value?.ToString() ?? "";
                    consolidados[nombre] = new ResumenEmpleado
                    {
                        Nombre = nombre,
                        Identidad = identidad
                    };
                }

                var emp = consolidados[nombre];

                // ACTUALIZAR SIEMPRE EL SALARIO: Así se quedará con el salario del último día del rango
                if (row.Cells["colSalarioBase"].Value != null)
                {
                    decimal.TryParse(row.Cells["colSalarioBase"].Value.ToString(), out decimal salarioFila);
                    emp.SalarioBase = salarioFila;
                }

                emp.SumHrs25 += ObtenerValorDecimal(row, "colExt25");
                emp.SumHrs50 += ObtenerValorDecimal(row, "colExt50");
                emp.SumHrs75 += ObtenerValorDecimal(row, "colExt75");
                emp.SumHrs100 += ObtenerValorDecimal(row, "colExt100");

                emp.TotalLps25 += ObtenerValorDecimal(row, "colLps25");
                emp.TotalLps50 += ObtenerValorDecimal(row, "colLps50");
                emp.TotalLps75 += ObtenerValorDecimal(row, "colLps75");
                emp.TotalLps100 += ObtenerValorDecimal(row, "colLps100");
            }

            string nombreArchivo = Path.Combine(Path.GetTempPath(), $"Consolidado_Planilla_{DateTime.Now:yyyyMMdd_HHmm}.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Resumen Planilla");

                ws.PageSetup.PageOrientation = XLPageOrientation.Landscape;
                ws.PageSetup.Footer.Center.AddText("Pág. ", XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(XLHFPredefinedText.PageNumber, XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(" de ", XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(XLHFPredefinedText.NumberOfPages, XLHFOccurrence.AllPages);

                string quincena = dtpFin.Value.Day <= 15 ? "PRIMERA" : "SEGUNDA";
                string mesNombre = dtpFin.Value.ToString("MMMM", new CultureInfo("es-ES")).ToUpper();
                string anio = dtpFin.Value.Year.ToString();
                string subtitulo = $"PERSONAL DE TRANSPORTE - {quincena} QUINCENA {mesNombre} {anio}";

                var logoBitmap = Properties.Resources.logo;
                if (logoBitmap != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        logoBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ms.Seek(0, SeekOrigin.Begin);
                        var image = ws.AddPicture(ms).MoveTo(ws.Cell(2, 3), 175, 5).Scale(0.7);
                    }
                }

                int fila = 2;
                int colFinTabla = 14;

                ws.Cell(fila, 1).Value = "RESUMEN CONSOLIDADO DE PAGO DE HORAS EXTRAS";
                ws.Range(fila, 1, fila, colFinTabla).Merge().Style.Font.SetBold().Font.SetFontSize(16).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                fila++;

                ws.Cell(fila, 1).Value = subtitulo;
                ws.Range(fila, 1, fila, colFinTabla).Merge().Style.Font.SetBold().Font.SetFontSize(12).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                fila++;

                ws.Cell(fila, 1).Value = $"Del {dtpInicio.Value:dd-MM-yyyy} al {dtpFin.Value:dd-MM-yyyy}";
                ws.Range(fila, 1, fila, colFinTabla).Merge().Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                fila += 2;

                string[] headers = {
                    "No.", "Identidad", "Nombre Empleado",
                    "Hrs 25%", "Lps 25%",
                    "Hrs 50%", "Lps 50%",
                    "Hrs 75%", "Lps 75%",
                    "Hrs 100%", "Lps 100%",
                    "Tot. Extras (L)", "Salario Base", "NETO A PAGAR"
                };

                for (int i = 0; i < headers.Length; i++)
                {
                    ws.Cell(fila, i + 1).Value = headers[i];
                    ws.Cell(fila, i + 1).Style.Fill.BackgroundColor = XLColor.DimGray;
                    ws.Cell(fila, i + 1).Style.Font.FontColor = XLColor.White;
                    ws.Cell(fila, i + 1).Style.Font.SetBold();
                    ws.Cell(fila, i + 1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                }
                fila++;

                decimal sumaLps25 = 0, sumaLps50 = 0, sumaLps75 = 0, sumaLps100 = 0;
                decimal sumaTotalExtras = 0, sumaSalarios = 0, sumaGranTotal = 0;
                int correlativo = 1;

                foreach (var item in consolidados.Values)
                {
                    ws.Cell(fila, 1).Value = correlativo++;
                    ws.Cell(fila, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    ws.Cell(fila, 2).Value = item.Identidad;
                    ws.Cell(fila, 3).Value = item.Nombre;

                    EscribirHora(ws, fila, 4, item.SumHrs25);
                    EscribirMoneda(ws, fila, 5, item.TotalLps25);

                    EscribirHora(ws, fila, 6, item.SumHrs50);
                    EscribirMoneda(ws, fila, 7, item.TotalLps50);

                    EscribirHora(ws, fila, 8, item.SumHrs75);
                    EscribirMoneda(ws, fila, 9, item.TotalLps75);

                    EscribirHora(ws, fila, 10, item.SumHrs100);
                    EscribirMoneda(ws, fila, 11, item.TotalLps100);

                    EscribirMoneda(ws, fila, 12, item.TotalDineroExtras);
                    EscribirMoneda(ws, fila, 13, item.SalarioBase);
                    EscribirMoneda(ws, fila, 14, item.GranTotalPagar);

                    ws.Cell(fila, 12).Style.Font.SetBold();
                    ws.Cell(fila, 14).Style.Font.SetBold().Fill.BackgroundColor = XLColor.LightGray;
                    ws.Range(fila, 1, fila, 14).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    ws.Range(fila, 1, fila, 14).Style.Border.BottomBorderColor = XLColor.LightGray;

                    sumaLps25 += item.TotalLps25;
                    sumaLps50 += item.TotalLps50;
                    sumaLps75 += item.TotalLps75;
                    sumaLps100 += item.TotalLps100;
                    sumaTotalExtras += item.TotalDineroExtras;
                    sumaSalarios += item.SalarioBase;
                    sumaGranTotal += item.GranTotalPagar;

                    fila++;
                }

                var rangoLabel = ws.Range(fila, 1, fila, 3);
                rangoLabel.Merge().Value = "TOTALES:";
                rangoLabel.Style.Font.SetBold().Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);
                rangoLabel.Style.Fill.BackgroundColor = XLColor.DimGray;
                rangoLabel.Style.Font.FontColor = XLColor.White;

                ws.Range(fila, 4, fila, 14).Style.Fill.BackgroundColor = XLColor.DimGray;
                ws.Range(fila, 4, fila, 14).Style.Font.FontColor = XLColor.White;
                ws.Range(fila, 4, fila, 14).Style.Font.SetBold();

                EscribirMoneda(ws, fila, 5, sumaLps25);
                EscribirMoneda(ws, fila, 7, sumaLps50);
                EscribirMoneda(ws, fila, 9, sumaLps75);
                EscribirMoneda(ws, fila, 11, sumaLps100);

                EscribirMoneda(ws, fila, 12, sumaTotalExtras);
                EscribirMoneda(ws, fila, 13, sumaSalarios);
                EscribirMoneda(ws, fila, 14, sumaGranTotal);
                ws.Cell(fila, 14).Style.NumberFormat.Format = "\"L. \"#,##0.00";

                fila += 6;
                var rangoElaborado = ws.Range(fila, 3, fila, 3);
                rangoElaborado.Merge().Value = "Elaborado Por:";
                rangoElaborado.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangoElaborado.Style.Border.TopBorder = XLBorderStyleValues.Thin;

                var rangoAutorizado = ws.Range(fila, 10, fila, 13);
                rangoAutorizado.Merge().Value = "Autorizado Por:";
                rangoAutorizado.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangoAutorizado.Style.Border.TopBorder = XLBorderStyleValues.Thin;

                ws.Columns().AdjustToContents();
                ws.Column(1).Width = 5;
                for (int c = 4; c <= 14; c++) { if (ws.Column(c).Width < 10) ws.Column(c).Width = 10; }

                workbook.SaveAs(nombreArchivo);
            }
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(nombreArchivo) { UseShellExecute = true });
        }

        private void EscribirMoneda(IXLWorksheet ws, int fila, int col, decimal valor)
        {
            ws.Cell(fila, col).Value = valor;
            ws.Cell(fila, col).Style.NumberFormat.Format = "\"L. \"#,##0.00";
        }

        private void EscribirHora(IXLWorksheet ws, int fila, int col, decimal valor)
        {
            if (valor == 0) ws.Cell(fila, col).Value = "-";
            else ws.Cell(fila, col).Value = valor;
            ws.Cell(fila, col).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        }
    }
}