using ADIGGM.Clases;
using ClosedXML.Excel;
using ClosedXML.Report.Utils;
using DocumentFormat.OpenXml.Vml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ADIGGM.HE
{
    public partial class frmReporteHorasExtras : FrmPrincipal
    {
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
            AgregarColumnaMoneda("colLps25", "Lps.25%"); // NUEVA

            AgregarColumnaNumerica("colExt50", "Hrs.50%");
            AgregarColumnaMoneda("colLps50", "Lps.50%"); // NUEVA

            AgregarColumnaNumerica("colExt75", "Hrs.75%");
            AgregarColumnaMoneda("colLps75", "Lps.75%"); // NUEVA

            AgregarColumnaNumerica("colExt100", "Hrs.100%");
            AgregarColumnaMoneda("colLps100", "Lps.100%"); // NUEVA

            // --- Columna de Total Pago ---
            AgregarColumnaMoneda("colTotalLps", "Total.Extras"); // NUEVA
            dgvReporte.Columns["colTotalLps"].DefaultCellStyle.Font = new Font(dgvReporte.Font, FontStyle.Bold);

            dgvReporte.Columns["colMotorista"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvReporte.Columns["colDia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

        }

        // Este método ya lo tienes
        private void AgregarColumnaNumerica(string name, string header)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = name;
            col.HeaderText = header;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col.DefaultCellStyle.Format = "N2"; // Formato numérico (ej. 8.00)
            dgvReporte.Columns.Add(col);
        }

        // --- NUEVO MÉTODO AUXILIAR ---
        // (Es igual que el anterior, pero usa "C2" para formato de Moneda)
        private void AgregarColumnaMoneda(string name, string header)
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            col.Name = name;
            col.HeaderText = header;
            col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            col.DefaultCellStyle.Format = "C2"; // Usamos N2 (ej. 1,234.56)
                                                // Nota: "C2" (formato Moneda) usaría "L." pero puede variar con la cultura del PC.
                                                // "N2" es más seguro y universal.
            dgvReporte.Columns.Add(col);
        }

        private void CargarMotoristas()
        {
            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();
                    // Traemos todos para el reporte, incluso inactivos si tuvieron horas en ese periodo
                    string query = "SELECT IdMotorista, Motorista FROM dbo.TR_Motoristas WHERE Activo = 1 AND EsEmpleado = 1 ORDER BY Motorista";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Agregar fila "(Todos)" al inicio
                    DataRow rowTodos = dt.NewRow();
                    rowTodos["IdMotorista"] = 0; // ID 0 representará a "Todos"
                    rowTodos["Motorista"] = "(Todos los Motoristas)";
                    dt.Rows.InsertAt(rowTodos, 0);

                    cboMotoristas.DisplayMember = "Motorista";
                    cboMotoristas.ValueMember = "IdMotorista";
                    cboMotoristas.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar motoristas: " + ex.Message);
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // 1. Obtener filtros
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;
            int idMotoristaSeleccionado = (int)cboMotoristas.SelectedValue;

            // --- NUEVA LÍNEA ---
            // Lee el valor del nuevo CheckBox. Si es 'false', solo queremos extras.
            bool mostrarTodos = chkMostrarTodosLosDias.Checked;

            // Limpiar grid antes de empezar
            dgvReporte.Rows.Clear();
            // pnlTotales.Visible = false; // (Si tienes el panel de totales)

            // 2. Obtener los datos crudos
            DataTable datosCrudos = ObtenerDatosCrudos(fechaInicio, fechaFin, idMotoristaSeleccionado);

            if (datosCrudos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron registros de asistencia para los filtros seleccionados.");
                return;
            }

            // 3. Procesar los datos, pasando el nuevo filtro
            // --- LÍNEA MODIFICADA ---
            ProcesarYMostrarDatos(datosCrudos, mostrarTodos);

            // 4. Calcular totales
            CalcularYMostrarTotales();
        }

        // MÉTODOS AUXILIARES

        private DataTable ObtenerDatosCrudos(DateTime inicio, DateTime fin, int idMotorista)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    m.Motorista,
                    m.IdMotorista,
                    m.Identidad,
                    m.SalarioQuincenal,
                    ISNULL(p.PagaExtrasDiarias, 1) as PagaExtrasDiarias, 
                    ISNULL(p.PagaDomingos, 1) as PagaDomingos,
                    ISNULL(p.PagaFeriados, 1) as PagaFeriados,
                    ISNULL(p.AplicaJornadaMixta, 0) as AplicaJornadaMixta,
                    ra.Fecha,
                    rt.HoraInicio,
                    rt.HoraFin,
                    CASE WHEN df.Fecha IS NOT NULL THEN 1 ELSE 0 END AS EsFeriado
                FROM dbo.HE_RegistrosAsistencia ra
                INNER JOIN dbo.TR_Motoristas m ON ra.IdMotorista = m.IdMotorista
                LEFT JOIN dbo.HE_PoliticasPago p ON m.PoliticaID = p.PoliticaID
                INNER JOIN dbo.HE_RegistrosTiempos rt ON ra.RegistroAsistenciaID = rt.RegistroAsistenciaID
                LEFT JOIN dbo.HE_DiasFeriados df ON ra.Fecha = df.Fecha
                WHERE ra.Fecha >= @FechaInicio AND ra.Fecha <= @FechaFin
                  AND (@IdMotorista = 0 OR ra.IdMotorista = @IdMotorista)
                ORDER BY m.Motorista, ra.Fecha, rt.HoraInicio";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FechaInicio", inicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fin);
                    cmd.Parameters.AddWithValue("@IdMotorista", idMotorista);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message);
                }
            }
            return dt;
        }
        private void ProcesarYMostrarDatos(DataTable dt, bool mostrarTodos)
        {
            // Agrupamos por Motorista
            var agrupadoPorMotorista = dt.AsEnumerable()
                .GroupBy(row => new { Id = row.Field<int>("IdMotorista"), Nombre = row.Field<string>("Motorista") });

            foreach (var grupoMotorista in agrupadoPorMotorista)
            {
                string nombreMotorista = grupoMotorista.Key.Nombre;

                // LEER LA POLÍTICA DEL MOTORISTA (de la primera fila del grupo)
                var filaInfo = grupoMotorista.First();
                PoliticaPago politicaMotorista = new PoliticaPago
                {
                    PagaExtrasDiarias = filaInfo.Field<bool>("PagaExtrasDiarias"),
                    PagaDomingos = filaInfo.Field<bool>("PagaDomingos"),
                    PagaFeriados = filaInfo.Field<bool>("PagaFeriados"),
                    AplicaJornadaMixta = filaInfo.Field<bool>("AplicaJornadaMixta")
                };

                string identidad = grupoMotorista.First().Field<string>("Identidad") ?? "";
                decimal salarioBase = grupoMotorista.First().Field<decimal?>("SalarioQuincenal") ?? 0;

                // --- INICIO: CÁLCULO DE TASAS DE PAGO ---
                // 1. Obtener SalarioQuincenal (de la primera fila, es el mismo para todo el motorista)
                // Lo leemos como 'decimal?' para manejar de forma segura si el valor es NULL en la BD
                decimal? salarioQuincenal = grupoMotorista.First().Field<decimal?>("SalarioQuincenal");
                decimal valorHoraBase = 0;

                if (salarioQuincenal.HasValue && salarioQuincenal.Value > 0)
                {
                    // Aplicamos tu fórmula de negocio
                    valorHoraBase = (salarioQuincenal.Value / 15m) / 8m; // 'm' para forzar aritmética decimal
                }

                // 2. Calcular las tasas de pago por hora (basado en Opción A)
                decimal tasaPago25 = valorHoraBase * 1.25m;
                decimal tasaPago50 = valorHoraBase * 1.50m;
                decimal tasaPago75 = valorHoraBase * 1.75m;
                decimal tasaPago100 = valorHoraBase * 2.00m;
                                                             // --- FIN: CÁLCULO DE TASAS DE PAGO ---

                // Ahora agrupamos por día para ese motorista
                var diasDelMotorista = grupoMotorista.GroupBy(row => row.Field<DateTime>("Fecha"));


                foreach (var grupoDia in diasDelMotorista)
                {
                    DateTime fecha = grupoDia.Key;

                    // 1. Determinar si es Feriado o Domingo
                    bool esFeriado = grupoDia.First().Field<int>("EsFeriado") == 1;
                    //bool esDomingo = fecha.DayOfWeek == DayOfWeek.Sunday;
                    //bool esDiaEspecial = esFeriado || esDomingo;

                    // 2. Construir la lista de rangos para la calculadora
                    List<RangoHora> rangosDelDia = new List<RangoHora>();
                    List<string> textosRangos = new List<string>(); // Lista para guardar los textos

                    foreach (DataRow filaRango in grupoDia)
                    {
                        DateTime inicio = filaRango.Field<DateTime>("HoraInicio");
                        DateTime fin = filaRango.Field<DateTime>("HoraFin");

                        rangosDelDia.Add(new RangoHora { Inicio = inicio, Fin = fin });

                        // Formateamos: "06:00 a.m. - 02:00 p.m."
                        string texto = $"{inicio:hh:mm tt} - {fin:hh:mm tt}";
                        textosRangos.Add(texto);
                    }

                    // 3. LLAMAR A LA CALCULADORA (obtiene el conteo de horas)
                    ResultadoDia resultado = CalculadoraHoras.CalcularDia(fecha, rangosDelDia, esFeriado, politicaMotorista);

                    // --- CAMBIO CLAVE PARA EL TEXTO DEL HORARIO ---
                    // Calculamos cuántas horas regulares hubo en total
                    decimal horasRegularesTotales = resultado.RegularesDiurnas + resultado.RegularesNocturnas;

                    // Generamos el texto SOLO de los rangos que exceden esas horas regulares
                    string horarioMostrar = GenerarTextoHorarioExtras(rangosDelDia, horasRegularesTotales);
                    // ----------------------------------------------

                    // 4. Calcular los Lempiras para ESTE DÍA
                    decimal lps25 = resultado.Extras25 * tasaPago25;
                    decimal lps50 = resultado.Extras50 * tasaPago50;
                    decimal lps75 = resultado.Extras75 * tasaPago75;
                    decimal lps100 = resultado.Extras100 * tasaPago100;
                    decimal totalLpsDia = lps25 + lps50 + lps75 + lps100;

                    // Sumamos todas las horas extras de CUALQUIER tipo
                    decimal totalHorasExtrasDelDia = resultado.Extras25 +
                                                       resultado.Extras50 +
                                                       resultado.Extras75 +
                                                       resultado.Extras100;

                    // 5. Mostrar el resultado en la cuadrícula
                    if (mostrarTodos || totalHorasExtrasDelDia > 0)
                    {
                        // 6. Mostrar el resultado en la cuadrícula
                        if (resultado.TotalHoras > 0) // (Mantenemos esta verificación de seguridad)
                        {
                            string diaSemana = fecha.ToString("ddd", new System.Globalization.CultureInfo("es-ES"));

                            dgvReporte.Rows.Add(
                                nombreMotorista,
                                identidad,
                                salarioBase,
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
                    } // --- FIN DE LA LÓGICA DE FILTRADO ---
                }
            }
        }
        private void CalcularYMostrarTotales()
        {
            // Variables para sumar
            decimal totalRegDiurnas = 0;
            decimal totalRegNocturnas = 0;
            decimal totalExt25 = 0;
            decimal totalExt50 = 0;
            decimal totalExt75 = 0;
            decimal totalExt100 = 0;
            decimal granTotalLps = 0;

            // Recorremos la cuadrícula (dgvReporte) que acabamos de llenar
            foreach (DataGridViewRow row in dgvReporte.Rows)
            {
                // Usamos Convert.ToDecimal para sumar los valores de las celdas
                // Es importante usar 'Value' y no 'FormattedValue'
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
                catch (Exception ex)
                {
                    // Manejar error si una celda no es un número (no debería pasar)
                    MessageBox.Show("Error al sumar totales: " + ex.Message);
                }
            }

            // Ahora mostramos los resultados en las etiquetas (Labels)
            // Usamos 'N2' para formato numérico con 2 decimales (ej. 15.50)

            // Suponiendo que tienes etiquetas con estos nombres:
            lblTotalRegulares.Text = $"Regulares: {(totalRegDiurnas + totalRegNocturnas).ToString("N2")}";
            lblTotalExtras25.Text = $"Extras 25%: {totalExt25.ToString("C2")}";
            lblTotalExtras50.Text = $"Extras 50%: {totalExt50.ToString("C2")}";
            lblTotalExtras75.Text = $"Extras 75%: {totalExt75.ToString("C2")}";
            lblTotalExtras100.Text = $"Extras 100%: {totalExt100.ToString("C2")}";
            lblGranTotalLps.Text = $"Total a Pagar (Extras): {granTotalLps.ToString("C2")}";

            // Haz visible el panel de totales
            pnlTotales.Visible = true;
        }

        private void chkMostrarTodosLosDias_CheckedChanged(object sender, EventArgs e)
        {
            // 1. Obtener filtros
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;
            int idMotoristaSeleccionado = (int)cboMotoristas.SelectedValue;

            // --- NUEVA LÍNEA ---
            // Lee el valor del nuevo CheckBox. Si es 'false', solo queremos extras.
            bool mostrarTodos = chkMostrarTodosLosDias.Checked;

            // Limpiar grid antes de empezar
            dgvReporte.Rows.Clear();
            // pnlTotales.Visible = false; // (Si tienes el panel de totales)

            // 2. Obtener los datos crudos
            DataTable datosCrudos = ObtenerDatosCrudos(fechaInicio, fechaFin, idMotoristaSeleccionado);

            if (datosCrudos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron registros de asistencia para los filtros seleccionados.");
                return;
            }

            // 3. Procesar los datos, pasando el nuevo filtro
            // --- LÍNEA MODIFICADA ---
            ProcesarYMostrarDatos(datosCrudos, mostrarTodos);

            // 4. Calcular totales
            CalcularYMostrarTotales();
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
                // Generamos una ruta temporal única
                string nombreArchivo = $"Reporte_HE_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
                string rutaCompleta = System.IO.Path.Combine(System.IO.Path.GetTempPath(), nombreArchivo);

                // Llamamos a la función de exportar pasando la ruta temporal
                ExportarReporteEstiloImagen(rutaCompleta);

                // Abrimos el archivo automáticamente
                // Excel se encargará de preguntar si guardar cambios al cerrar
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

                // Configuración de Impresión (Páginas)
                ws.PageSetup.PageOrientation = XLPageOrientation.Landscape; // Horizontal para que quepan las columnas
                ws.PageSetup.Footer.Center.AddText("Pág. ", XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(XLHFPredefinedText.PageNumber, XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(" de ", XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(XLHFPredefinedText.NumberOfPages, XLHFOccurrence.AllPages);

                // Título y subtítulo
                string quincena = dtpFin.Value.Day <= 15 ? "PRIMERA" : "SEGUNDA";
                string mesNombre = dtpFin.Value.ToString("MMMM", new System.Globalization.CultureInfo("es-ES")).ToUpper();
                string anio = dtpFin.Value.Year.ToString();
                string subtitulo = $"PERSONAL DE TRANSPORTE - {quincena} QUINCENA {mesNombre} {anio}";

                // --- 1. INSERTAR LOGO ---
                //string rutaLogo = "logo.png";
                //if (File.Exists(rutaLogo))
                //{
                //    var image = ws.AddPicture(rutaLogo)
                //                  .MoveTo(ws.Cell(2, 3),55,5)
                //                  .Scale(0.7);
                //}

                // NO USAMOS RUTA DE ARCHIVO, USAMOS EL RECURSO
                // 'Properties.Resources.logo' es como se llama tu imagen en los recursos
                var logoBitmap = Properties.Resources.logo;

                if (logoBitmap != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        // Convertimos la imagen interna a un flujo de memoria que Excel entienda
                        logoBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ms.Seek(0, SeekOrigin.Begin); // Regresamos al inicio del stream

                        // Insertamos desde el stream
                        var image = ws.AddPicture(ms)
                                      .MoveTo(ws.Cell(2, 3), 55, 5)
                                      .Scale(0.7);

                        // image.WithXOffset(10); // Tus ajustes opcionales
                    }
                }

                // 2. ENCABEZADOS DEL REPORTE (Centrados desde la columna 4 en adelante)
                int filaActual = 2;
                int colInicioTitulos = 1; // Dejamos espacio para el logo a la izquierda
                int colFinTitulos = 12;

                // A. Título Principal
                ws.Cell(filaActual, colInicioTitulos).Value = "REPORTE CONTROL DE HORAS EXTRAS";
                ws.Range(filaActual, colInicioTitulos, filaActual, colFinTitulos).Merge().Style
                    .Font.SetBold().Font.SetFontSize(16)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                filaActual++;

                // B. Nuevo Subtítulo (PERSONAL DE TRANSPORTE...)
                ws.Cell(filaActual, colInicioTitulos).Value = subtitulo;
                ws.Range(filaActual, colInicioTitulos, filaActual, colFinTitulos).Merge().Style
                    .Font.SetBold().Font.SetFontSize(12) // Letra un poco más pequeña
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                filaActual++;

                // C. Rango de Fechas
                ws.Cell(filaActual, colInicioTitulos).Value = $"Del {dtpInicio.Value:dd-MM-yyyy} al {dtpFin.Value:dd-MM-yyyy}";
                ws.Range(filaActual, colInicioTitulos, filaActual, colFinTitulos).Merge().Style
                    .Font.SetFontSize(11)
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                filaActual += 2; // Espacio antes de la tabla

                // Variables de control
                string motoristaActual = "";
                string identidadActualCache = ""; // Para guardar la identidad del grupo actual
                decimal salarioActualCache = 0;   // Para guardar el salario del grupo actual

                decimal sumTotalHorasExtras = 0;  // <-- CAMBIO: Ahora sumaremos solo extras
                decimal sumLps25 = 0, sumLps50 = 0, sumLps75 = 0, sumLps100 = 0;
                decimal granTotalLps = 0;

                for (int i = 0; i < dgvReporte.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvReporte.Rows[i];
                    string motoristaFila = row.Cells["colMotorista"].Value.ToString();

                    // Leemos datos ocultos
                    string identidadFila = row.Cells["colIdentidad"].Value?.ToString() ?? "";
                    decimal salarioFila = 0;
                    if (row.Cells["colSalarioBase"].Value != null)
                        decimal.TryParse(row.Cells["colSalarioBase"].Value.ToString(), out salarioFila);

                    // CAMBIO DE GRUPO (EMPLEADO)
                    if (motoristaFila != motoristaActual)
                    {
                        if (!string.IsNullOrEmpty(motoristaActual))
                        {
                            // Imprimimos totales del anterior
                            ImprimirPieGrupo(ws, ref filaActual, sumTotalHorasExtras, sumLps25, sumLps50, sumLps75, sumLps100, salarioActualCache);
                            filaActual++;
                            granTotalLps += (sumLps25 + sumLps50 + sumLps75 + sumLps100);
                        }

                        // Reiniciar variables
                        motoristaActual = motoristaFila;
                        identidadActualCache = identidadFila;
                        salarioActualCache = salarioFila;

                        sumTotalHorasExtras = 0; sumLps25 = 0; sumLps50 = 0; sumLps75 = 0; sumLps100 = 0;

                        // Encabezado Empleado
                        ws.Cell(filaActual, 1).Value = $"Nombre Empleado: {motoristaActual}";
                        ws.Cell(filaActual, 1).Style.Font.SetBold().Font.SetFontSize(11);
                        ws.Range(filaActual, 1, filaActual, 6).Merge();

                        // Identidad a la derecha
                        ws.Cell(filaActual, 8).Value = $"Identidad: {identidadActualCache}";
                        ws.Cell(filaActual, 8).Style.Font.SetBold();
                        ws.Range(filaActual, 8, filaActual, 11).Merge();

                        filaActual++;
                        ImprimirEncabezadosTabla(ws, ref filaActual);
                    }

                    // --- IMPRIMIR DETALLE ---
                    ws.Row(filaActual).Style.Alignment.SetVertical(XLAlignmentVerticalValues.Center);

                    ws.Cell(filaActual, 1).Value = row.Cells["colFecha"].Value.ToString();
                    ws.Cell(filaActual, 2).Value = row.Cells["colDia"].Value.ToString();

                    ws.Cell(filaActual, 3).Value = row.Cells["colHorario"].Value.ToString();
                    ws.Cell(filaActual, 3).Style.Alignment.WrapText = true;

                    // --- CAMBIO: OBTENER VALORES PRIMERO ---
                    decimal hrs25 = ObtenerValorDecimal(row, "colExt25");
                    decimal hrs50 = ObtenerValorDecimal(row, "colExt50");
                    decimal hrs75 = ObtenerValorDecimal(row, "colExt75");
                    decimal hrs100 = ObtenerValorDecimal(row, "colExt100");

                    // --- CAMBIO: CALCULAR SOLO EXTRAS ---
                    decimal totalExtrasFila = hrs25 + hrs50 + hrs75 + hrs100;

                    // Columna 4: Ahora muestra Total Extras

                    if (totalExtrasFila == 0) ws.Cell(filaActual, 4).Value = "-";
                    else ws.Cell(filaActual, 4).Value = totalExtrasFila;
                    ws.Cell(filaActual, 4).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    // Valores Monetarios
                    if (hrs25 == 0)
                    {
                        ws.Cell(filaActual, 5).Value = "-";
                        ws.Cell(filaActual, 5).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    }
                    else
                    {
                        ws.Cell(filaActual, 5).Value = hrs25;
                        ws.Cell(filaActual, 5).Style.NumberFormat.Format = "#,##0.00";
                    }

                    //EscribirCeldaMoneda(ws, filaActual, 5, hrs25);
                    EscribirCeldaMoneda(ws, filaActual, 6, ObtenerValorDecimal(row, "colLps25"));

                    if (hrs50 == 0)
                    {
                        ws.Cell(filaActual, 7).Value = "-";
                        ws.Cell(filaActual, 7).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    }
                    else
                    {
                        ws.Cell(filaActual, 7).Value = hrs50;
                        ws.Cell(filaActual, 7).Style.NumberFormat.Format = "#,##0.00";
                    }

                    //EscribirCeldaMoneda(ws, filaActual, 7, hrs50);
                    EscribirCeldaMoneda(ws, filaActual, 8, ObtenerValorDecimal(row, "colLps50"));

                    if (hrs75 == 0)
                    {
                        ws.Cell(filaActual, 9).Value = "-";
                        ws.Cell(filaActual, 9).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    }
                    else
                    {
                        ws.Cell(filaActual, 9).Value = hrs75;
                        ws.Cell(filaActual, 9).Style.NumberFormat.Format = "#,##0.00";
                    }

                    //EscribirCeldaMoneda(ws, filaActual, 9, hrs75);
                    EscribirCeldaMoneda(ws, filaActual, 10, ObtenerValorDecimal(row, "colLps75"));

                    if (hrs100 == 0)
                    {
                        ws.Cell(filaActual, 11).Value = "-";
                        ws.Cell(filaActual, 11).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    }
                    else
                    {
                        ws.Cell(filaActual, 11).Value = hrs100;
                        ws.Cell(filaActual, 11).Style.NumberFormat.Format = "#,##0.00";
                    }

                    //EscribirCeldaMoneda(ws, filaActual, 11, hrs100);
                    EscribirCeldaMoneda(ws, filaActual, 12, ObtenerValorDecimal(row, "colLps100"));

                    // Sumar a acumuladores
                    sumTotalHorasExtras += totalExtrasFila; // Sumamos solo las extras
                    sumLps25 += Convert.ToDecimal(row.Cells["colLps25"].Value);
                    sumLps50 += Convert.ToDecimal(row.Cells["colLps50"].Value);
                    sumLps75 += Convert.ToDecimal(row.Cells["colLps75"].Value);
                    sumLps100 += Convert.ToDecimal(row.Cells["colLps100"].Value);

                    // Borde
                    ws.Range(filaActual, 1, filaActual, 12).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    ws.Range(filaActual, 1, filaActual, 12).Style.Border.BottomBorderColor = XLColor.LightGray;

                    filaActual++;
                }

                // Pie del último grupo
                ImprimirPieGrupo(ws, ref filaActual, sumTotalHorasExtras, sumLps25, sumLps50, sumLps75, sumLps100, salarioActualCache);
                granTotalLps += (sumLps25 + sumLps50 + sumLps75 + sumLps100);

                // --- GRAN TOTAL ---
                filaActual += 2;
                ws.Range(filaActual, 1, filaActual, 10).Merge().Value = "TOTAL HRS EXTRAS:";
                ws.Range(filaActual, 1, filaActual, 10).Style
                    .Font.SetBold()
                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);

                ws.Range(filaActual, 11, filaActual, 12).Merge().Value = granTotalLps;
                ws.Range(filaActual, 11, filaActual, 12).Style
                    .Font.SetBold()
                    .NumberFormat.Format = "\"L. \"#,##0.00";
                ws.Range(filaActual, 11, filaActual, 12).Style.Fill.BackgroundColor = XLColor.Yellow;

                // --- NUEVO: SECCIÓN DE FIRMAS ---
                filaActual += 6; // Dejamos 5 filas de espacio para firmar

                // 1. Firma Elaborado Por (Izquierda)
                var rangoElaborado = ws.Range(filaActual, 2, filaActual, 4); // Columnas B a E
                rangoElaborado.Merge();
                rangoElaborado.Value = "Elaborado Por: Darwin Noe Flores";
                rangoElaborado.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangoElaborado.Style.Font.SetBold();
                // Línea superior para la firma
                rangoElaborado.Style.Border.TopBorder = XLBorderStyleValues.Thin;

                // 2. Firma Autorizado Por (Derecha)
                var rangoAutorizado = ws.Range(filaActual, 8, filaActual, 11); // Columnas H a K
                rangoAutorizado.Merge();
                rangoAutorizado.Value = "Autorizado Por: Julio Cesar Flores";
                rangoAutorizado.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangoAutorizado.Style.Font.SetBold();
                // Línea superior para la firma
                rangoAutorizado.Style.Border.TopBorder = XLBorderStyleValues.Thin;

                // --- AJUSTES FINALES ---
                ws.Columns().AdjustToContents();
                ws.Column(3).Width = 28;
                ws.Column(2).Width = 10;
                for (int c = 5; c <= 12; c++) { if (ws.Column(c).Width < 10) ws.Column(c).Width = 10; }

                workbook.SaveAs(rutaArchivo);
            }
        }

        // --- NUEVOS MÉTODOS AUXILIARES ---

        private decimal ObtenerValorDecimal(DataGridViewRow row, string colName)
        {
            if (row.Cells[colName].Value != null && row.Cells[colName].Value != DBNull.Value)
            {
                decimal val;
                if (decimal.TryParse(row.Cells[colName].Value.ToString(), out val))
                {
                    return val;
                }
            }
            return 0;
        }

        private void EscribirCeldaMoneda(IXLWorksheet ws, int fila, int col, decimal valor)
        {
            if (valor == 0)
            {
                ws.Cell(fila, col).Value = "-";
                ws.Cell(fila, col).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            }
            else
            {
                ws.Cell(fila, col).Value = valor;
                // Formato para mostrar solo 2 decimales (ej: 314.90)
                ws.Cell(fila, col).Style.NumberFormat.Format = "\"L. \"#,##0.00";
            }
        }
        private void ImprimirEncabezadosTabla(IXLWorksheet ws, ref int fila)
        {
            // Títulos superiores agrupados
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

            // Subtítulos
            var estiloSub = ws.Range(fila, 1, fila, 12).Style;
            estiloSub.Fill.BackgroundColor = XLColor.LightGray;
            estiloSub.Font.SetBold();
            estiloSub.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            ws.Cell(fila, 1).Value = "Fecha";
            ws.Cell(fila, 2).Value = "Día";
            ws.Cell(fila, 3).Value = "Horario";
            ws.Cell(fila, 4).Value = "Tot. Extras";

            // Repetir Hrs / Lps
            for (int c = 5; c <= 11; c += 2) { ws.Cell(fila, c).Value = "Hrs"; ws.Cell(fila, c + 1).Value = "LPS"; }

            fila++;
        }

        // Agregamos el parámetro 'salarioBase' al final
        private void ImprimirPieGrupo(IXLWorksheet ws, ref int fila, decimal totHrs, decimal lps25, decimal lps50, decimal lps75, decimal lps100, decimal salarioBase)
        {
            // 1. Fila de Subtotales (La gris oscura)
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

            // --- SECCIÓN DE LIQUIDACIÓN ---
            fila++; // Bajamos línea

            // A. Salario Quincenal
            ws.Cell(fila, 9).Value = "Salario Quincenal:";
            ws.Range(fila, 9, fila, 11).Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            ws.Range(fila, 9, fila, 11).Style.Font.SetBold();

            ws.Cell(fila, 12).Value = salarioBase;
            ws.Cell(fila, 12).Style.NumberFormat.Format = "\"L. \"#,##0.00";

            fila++; // Bajamos línea

            // B. Total Extras
            ws.Cell(fila, 9).Value = "(+) Total Extras:";
            ws.Range(fila, 9, fila, 11).Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            ws.Range(fila, 9, fila, 11).Style.Font.SetBold();

            ws.Cell(fila, 12).Value = totalSoloExtras;
            ws.Cell(fila, 12).Style.NumberFormat.Format = "\"L. \"#,##0.00";
            ws.Cell(fila, 12).Style.Border.BottomBorder = XLBorderStyleValues.Thin; // Línea de suma

            fila++; // Bajamos línea

            // C. GRAN TOTAL A PAGAR
            ws.Cell(fila, 9).Value = "TOTAL A PAGAR:";
            ws.Range(fila, 9, fila, 11).Merge().Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            ws.Range(fila, 9, fila, 11).Style.Font.SetBold();

            decimal granTotalQuincena = salarioBase + totalSoloExtras;

            var celdaTotal = ws.Cell(fila, 12);
            celdaTotal.Value = granTotalQuincena;
            celdaTotal.Style.Font.SetBold();
            celdaTotal.Style.Fill.BackgroundColor = XLColor.LightGreen;
            celdaTotal.Style.NumberFormat.Format = "\"L. \"#,##0.00";
            celdaTotal.Style.Border.BottomBorder = XLBorderStyleValues.Double; // Doble línea final
        }
        private string GenerarTextoHorarioExtras(List<RangoHora> rangos, decimal horasRegularesDelDia)
        {
            // Si no hay horas regulares (ej. Domingo/Feriado), mostramos TODO el horario
            if (horasRegularesDelDia == 0)
            {
                List<string> textos = new List<string>();
                foreach (var r in rangos) textos.Add($"{r.Inicio:hh:mm tt} - {r.Fin:hh:mm tt}");
                return string.Join("\n", textos);
            }

            List<string> rangosExtras = new List<string>();

            // Convertimos las horas regulares (decimal) a minutos para ir restando
            double minutosRegularesPorConsumir = (double)horasRegularesDelDia * 60;

            // Ordenamos los rangos cronológicamente para ir "llenando" el cupo regular en orden
            foreach (var rango in rangos.OrderBy(r => r.Inicio))
            {
                double duracionMinutos = (rango.Fin - rango.Inicio).TotalMinutes;

                if (minutosRegularesPorConsumir >= duracionMinutos)
                {
                    // Caso 1: Todo este rango es regular. Lo consumimos y no mostramos nada.
                    minutosRegularesPorConsumir -= duracionMinutos;
                }
                else if (minutosRegularesPorConsumir > 0)
                {
                    // Caso 2: El rango es mixto (una parte regular, el resto extra).
                    // Calculamos a qué hora terminan las horas regulares
                    DateTime inicioExtra = rango.Inicio.AddMinutes(minutosRegularesPorConsumir);

                    // Agregamos el rango desde ese punto hasta el final
                    rangosExtras.Add($"{inicioExtra:hh:mm tt} - {rango.Fin:hh:mm tt}");

                    // Ya nos acabamos el cupo regular
                    minutosRegularesPorConsumir = 0;
                }
                else
                {
                    // Caso 3: Ya no queda cupo regular. Todo este rango es extra.
                    rangosExtras.Add($"{rango.Inicio:hh:mm tt} - {rango.Fin:hh:mm tt}");
                }
            }

            if (rangosExtras.Count == 0) return "Sin Extras";

            return string.Join("\n", rangosExtras);
        }
        // Clase simple para guardar los totales de cada empleado
        // Clase para guardar los totales acumulados de cada empleado
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

            // --- 1. AGRUPAR DATOS EN MEMORIA ---
            Dictionary<string, ResumenEmpleado> consolidados = new Dictionary<string, ResumenEmpleado>();

            foreach (DataGridViewRow row in dgvReporte.Rows)
            {
                string nombre = row.Cells["colMotorista"].Value.ToString();

                if (!consolidados.ContainsKey(nombre))
                {
                    string identidad = row.Cells["colIdentidad"].Value?.ToString() ?? "";
                    decimal salario = 0;
                    if (row.Cells["colSalarioBase"].Value != null)
                        decimal.TryParse(row.Cells["colSalarioBase"].Value.ToString(), out salario);

                    consolidados[nombre] = new ResumenEmpleado
                    {
                        Nombre = nombre,
                        Identidad = identidad,
                        SalarioBase = salario
                    };
                }

                var emp = consolidados[nombre];

                // Sumar Horas
                emp.SumHrs25 += ObtenerValorDecimal(row, "colExt25");
                emp.SumHrs50 += ObtenerValorDecimal(row, "colExt50");
                emp.SumHrs75 += ObtenerValorDecimal(row, "colExt75");
                emp.SumHrs100 += ObtenerValorDecimal(row, "colExt100");

                // Sumar Dinero
                emp.TotalLps25 += ObtenerValorDecimal(row, "colLps25");
                emp.TotalLps50 += ObtenerValorDecimal(row, "colLps50");
                emp.TotalLps75 += ObtenerValorDecimal(row, "colLps75");
                emp.TotalLps100 += ObtenerValorDecimal(row, "colLps100");
            }

            // --- 2. GENERAR EXCEL ---
            string nombreArchivo = System.IO.Path.Combine(System.IO.Path.GetTempPath(), $"Consolidado_Planilla_{DateTime.Now:yyyyMMdd_HHmm}.xlsx");

            using (var workbook = new XLWorkbook())
            {
                var ws = workbook.Worksheets.Add("Resumen Planilla");

                // Configuración de Impresión (Páginas)
                ws.PageSetup.PageOrientation = XLPageOrientation.Landscape; // Horizontal para que quepan las columnas
                ws.PageSetup.Footer.Center.AddText("Pág. ", XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(XLHFPredefinedText.PageNumber, XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(" de ", XLHFOccurrence.AllPages);
                ws.PageSetup.Footer.Center.AddText(XLHFPredefinedText.NumberOfPages, XLHFOccurrence.AllPages);

                // 0. TÍTULOS Y LOGO
                string quincena = dtpFin.Value.Day <= 15 ? "PRIMERA" : "SEGUNDA";
                string mesNombre = dtpFin.Value.ToString("MMMM", new CultureInfo("es-ES")).ToUpper();
                string anio = dtpFin.Value.Year.ToString();
                string subtitulo = $"PERSONAL DE TRANSPORTE - {quincena} QUINCENA {mesNombre} {anio}";

                //string rutaLogo = "logo.png";
                //if (File.Exists(rutaLogo))
                //{
                //    var image = ws.AddPicture(rutaLogo).MoveTo(ws.Cell(2, 3),175,5).Scale(0.7);
                //    // Ajuste opcional de posición del logo
                //    // image.WithXOffset(10); 
                //}

                var logoBitmap = Properties.Resources.logo;

                if (logoBitmap != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        // Convertimos la imagen interna a un flujo de memoria que Excel entienda
                        logoBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        ms.Seek(0, SeekOrigin.Begin); // Regresamos al inicio del stream

                        // Insertamos desde el stream
                        var image = ws.AddPicture(ms)
                                      .MoveTo(ws.Cell(2, 3), 175, 5).Scale(0.7);

                        // image.WithXOffset(10); // Tus ajustes opcionales
                    }
                }

                int fila = 2;
                int colFinTabla = 14;

                // Títulos
                ws.Cell(fila, 1).Value = "RESUMEN CONSOLIDADO DE PAGO DE HORAS EXTRAS";
                ws.Range(fila, 1, fila, colFinTabla).Merge().Style.Font.SetBold().Font.SetFontSize(16).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                fila++;

                ws.Cell(fila, 1).Value = subtitulo;
                ws.Range(fila, 1, fila, colFinTabla).Merge().Style.Font.SetBold().Font.SetFontSize(12).Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                fila++;

                ws.Cell(fila, 1).Value = $"Del {dtpInicio.Value:dd-MM-yyyy} al {dtpFin.Value:dd-MM-yyyy}";
                ws.Range(fila, 1, fila, colFinTabla).Merge().Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                fila += 2;

                // --- ENCABEZADOS ---
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

                // Variables de Suma Vertical
                decimal sumaLps25 = 0, sumaLps50 = 0, sumaLps75 = 0, sumaLps100 = 0;
                decimal sumaTotalExtras = 0;
                decimal sumaSalarios = 0;
                decimal sumaGranTotal = 0;
                int correlativo = 1;

                // --- 3. IMPRIMIR FILAS ---
                foreach (var item in consolidados.Values)
                {
                    ws.Cell(fila, 1).Value = correlativo++;
                    ws.Cell(fila, 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                    ws.Cell(fila, 2).Value = item.Identidad;
                    ws.Cell(fila, 3).Value = item.Nombre;

                    // Detalles (Horas y Dinero)
                    EscribirHora(ws, fila, 4, item.SumHrs25);
                    EscribirMoneda(ws, fila, 5, item.TotalLps25); // Columna 5: Dinero 25%

                    EscribirHora(ws, fila, 6, item.SumHrs50);
                    EscribirMoneda(ws, fila, 7, item.TotalLps50); // Columna 7: Dinero 50%

                    EscribirHora(ws, fila, 8, item.SumHrs75);
                    EscribirMoneda(ws, fila, 9, item.TotalLps75); // Columna 9: Dinero 75%

                    EscribirHora(ws, fila, 10, item.SumHrs100);
                    EscribirMoneda(ws, fila, 11, item.TotalLps100); // Columna 11: Dinero 100%

                    // Totales por fila
                    EscribirMoneda(ws, fila, 12, item.TotalDineroExtras);
                    EscribirMoneda(ws, fila, 13, item.SalarioBase);
                    EscribirMoneda(ws, fila, 14, item.GranTotalPagar);

                    // Estilos de fila
                    ws.Cell(fila, 12).Style.Font.SetBold();
                    ws.Cell(fila, 14).Style.Font.SetBold().Fill.BackgroundColor = XLColor.LightGray;
                    ws.Range(fila, 1, fila, 14).Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                    ws.Range(fila, 1, fila, 14).Style.Border.BottomBorderColor = XLColor.LightGray;

                    // ACUMULAR TOTALES GENERALES
                    sumaLps25 += item.TotalLps25;
                    sumaLps50 += item.TotalLps50;
                    sumaLps75 += item.TotalLps75;
                    sumaLps100 += item.TotalLps100;

                    sumaTotalExtras += item.TotalDineroExtras;
                    sumaSalarios += item.SalarioBase;
                    sumaGranTotal += item.GranTotalPagar;

                    fila++;
                }

                // --- 4. FILA DE TOTALES FINALES ---
                //fila++;

                // Etiqueta "TOTALES:" (Solo fusionamos las primeras 3 columnas para no tapar los datos)
                var rangoLabel = ws.Range(fila, 1, fila, 3);
                rangoLabel.Merge().Value = "TOTALES:";
                rangoLabel.Style.Font.SetBold().Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right);
                rangoLabel.Style.Fill.BackgroundColor = XLColor.DimGray;
                rangoLabel.Style.Font.FontColor = XLColor.White;

                // Pintar toda la fila de gris para que se vea uniforme
                ws.Range(fila, 4, fila, 14).Style.Fill.BackgroundColor = XLColor.DimGray;
                ws.Range(fila, 4, fila, 14).Style.Font.FontColor = XLColor.White;
                ws.Range(fila, 4, fila, 14).Style.Font.SetBold();

                // Escribir los Totales Verticales Nuevos (Columnas impares: 5, 7, 9, 11)
                EscribirMoneda(ws, fila, 5, sumaLps25);
                EscribirMoneda(ws, fila, 7, sumaLps50);
                EscribirMoneda(ws, fila, 9, sumaLps75);
                EscribirMoneda(ws, fila, 11, sumaLps100);

                // Escribir los Totales Generales (Columnas 12, 13, 14)
                EscribirMoneda(ws, fila, 12, sumaTotalExtras);
                EscribirMoneda(ws, fila, 13, sumaSalarios);
                EscribirMoneda(ws, fila, 14, sumaGranTotal);

                // Formato moneda especial para el gran total
                ws.Cell(fila, 14).Style.NumberFormat.Format = "\"L. \"#,##0.00";

                // --- 5. FIRMAS ---
                fila += 6;
                var rangoElaborado = ws.Range(fila, 3, fila, 3);
                rangoElaborado.Merge().Value = "Elaborado Por:";
                rangoElaborado.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangoElaborado.Style.Border.TopBorder = XLBorderStyleValues.Thin;

                var rangoAutorizado = ws.Range(fila, 10, fila, 13);
                rangoAutorizado.Merge().Value = "Autorizado Por:";
                rangoAutorizado.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                rangoAutorizado.Style.Border.TopBorder = XLBorderStyleValues.Thin;

                // Ajustes finales
                ws.Columns().AdjustToContents();
                ws.Column(1).Width = 5;
                for (int c = 4; c <= 14; c++) { if (ws.Column(c).Width < 10) ws.Column(c).Width = 10; }

                workbook.SaveAs(nombreArchivo);
            }
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(nombreArchivo) { UseShellExecute = true });
        }

        // --- MÉTODOS AUXILIARES ---
        private void EscribirMoneda(IXLWorksheet ws, int fila, int col, decimal valor)
        {
            ws.Cell(fila, col).Value = valor;
            ws.Cell(fila, col).Style.NumberFormat.Format = "\"L. \"#,##0.00";
        }

        // Nuevo helper para escribir horas (centradas y con guion si es cero)
        private void EscribirHora(IXLWorksheet ws, int fila, int col, decimal valor)
        {
            if (valor == 0) ws.Cell(fila, col).Value = "-";
            else ws.Cell(fila, col).Value = valor;
            ws.Cell(fila, col).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
        }
    }
}