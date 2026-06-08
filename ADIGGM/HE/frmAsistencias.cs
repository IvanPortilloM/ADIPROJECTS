using ADIGGM.Clases;
using ADIGGM.CapaDatos;
using ADIGGM.CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ADIGGM.HE
{
    public partial class frmAsistencias : FrmPrincipal
    {
        private readonly RepositorioFeriados _repoFeriados = new RepositorioFeriados();
        private readonly RepositorioPoliticas _repoPoliticas = new RepositorioPoliticas();
        private readonly RepositorioAsistencias _repoAsistencias = new RepositorioAsistencias();

        private int _filaActual = 0;
        private int _columnaActual = 0;
        private int _filaSuperiorVisible = 0;
        private int _horizontalScrollOffset = 0;

        private List<DateTime> _feriadosDelMes = new List<DateTime>();
        private Dictionary<string, string> _observacionesCache = new Dictionary<string, string>();
        public frmAsistencias()
        {
            InitializeComponent();

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

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatosAsistencia();
        }

        private void CargarFeriadosDelMes()
        {
            // Traemos solo los feriados que caen DENTRO del rango seleccionado
            DateTime inicio = dtpInicio.Value.Date;
            DateTime fin = dtpFin.Value.Date;

            try
            {
                _feriadosDelMes = _repoFeriados.ListarFechasEntre(inicio, fin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando feriados: " + ex.Message);
            }
        }
        public class StatsAsistencia
        {
            public int DiasICP { get; set; }
            public int DiasLibres { get; set; }
            public int DiasSDT { get; set; }
            public int DiasFeriadosTrabajados { get; set; }
            public int DomingosTrabajados { get; set; }
        }
        private void CargarDatosAsistencia()
        {
            DateTime fechaInicio = dtpInicio.Value.Date;
            DateTime fechaFin = dtpFin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha fin.");
                return;
            }

            bool mostrarInactivos = chkMostrarInactivos.Checked;
            bool mostrarSubs = chkIncluirSubcontratistas.Checked;
            int politicaID = 0;
            if (cboFiltroPolitica.SelectedValue != null)
                int.TryParse(cboFiltroPolitica.SelectedValue.ToString(), out politicaID);

            CargarFeriadosDelMes();
            CargarObservacionesDelMes();

            try
            {
                DataTable dt = _repoAsistencias.ObtenerAsistencia(fechaInicio, fechaFin, mostrarInactivos, mostrarSubs, politicaID);

                // --- CONSTRUIR GRID ---
                dgvAsistencia.DataSource = null;
                dgvAsistencia.Columns.Clear();
                dgvAsistencia.Rows.Clear();

                // Columnas Fijas
                dgvAsistencia.Columns.Add("IdMotorista", "Id");
                dgvAsistencia.Columns["IdMotorista"].Visible = false;
                dgvAsistencia.Columns.Add("Motorista", "Motorista");
                dgvAsistencia.Columns["Motorista"].Frozen = true;
                dgvAsistencia.Columns["Motorista"].Width = 200;

                // Columnas Días
                for (DateTime dia = fechaInicio; dia <= fechaFin; dia = dia.AddDays(1))
                {
                    string colName = $"Dia_{dia:yyyyMMdd}";
                    string header = $"{dia:ddd dd}".ToUpper();
                    int idx = dgvAsistencia.Columns.Add(colName, header);
                    dgvAsistencia.Columns[idx].Width = 40;
                    dgvAsistencia.Columns[idx].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    if (dia.DayOfWeek == DayOfWeek.Sunday)
                    {
                        dgvAsistencia.Columns[idx].HeaderCell.Style.ForeColor = Color.Red;
                        dgvAsistencia.Columns[idx].HeaderCell.Style.Font = new Font(dgvAsistencia.Font, FontStyle.Bold);
                    }
                }

                // --- COLUMNAS DE TOTALES (Agregamos las nuevas) ---

                // 1. ICP
                int idxICP = dgvAsistencia.Columns.Add("TotalICP", "ICP");
                dgvAsistencia.Columns[idxICP].Width = 40;
                dgvAsistencia.Columns[idxICP].DefaultCellStyle.BackColor = Color.Turquoise;
                dgvAsistencia.Columns[idxICP].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // 2. CAMBIO #1: SDT (Septimo Dia Trabajado)
                int idxSDT = dgvAsistencia.Columns.Add("TotalSDT", "SDT");
                dgvAsistencia.Columns[idxSDT].Width = 40;
                dgvAsistencia.Columns[idxSDT].DefaultCellStyle.BackColor = Color.LightBlue; // Color distintivo
                dgvAsistencia.Columns[idxSDT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // 3. CAMBIO #3: Feriados Trabajados
                int idxFer = dgvAsistencia.Columns.Add("TotalFer", "Fer.Trab");
                dgvAsistencia.Columns[idxFer].Width = 55;
                dgvAsistencia.Columns[idxFer].DefaultCellStyle.BackColor = Color.Pink;
                dgvAsistencia.Columns[idxFer].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // 4. Domingos Trabajados
                int idxDom = dgvAsistencia.Columns.Add("TotalDom", "Dom.Trab");
                dgvAsistencia.Columns[idxDom].Width = 60;
                dgvAsistencia.Columns[idxDom].DefaultCellStyle.BackColor = Color.Lavender;
                dgvAsistencia.Columns[idxDom].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // 5. Libres
                int idxL = dgvAsistencia.Columns.Add("TotalL", "Libres");
                dgvAsistencia.Columns[idxL].Width = 45;
                dgvAsistencia.Columns[idxL].DefaultCellStyle.BackColor = Color.LightCyan;
                dgvAsistencia.Columns[idxL].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // --- PROCESAMIENTO ---
                Dictionary<int, int> mapaFilas = new Dictionary<int, int>();
                Dictionary<int, StatsAsistencia> mapaStats = new Dictionary<int, StatsAsistencia>();

                foreach (DataRow row in dt.Rows)
                {
                    int idMoto = Convert.ToInt32(row["IdMotorista"]);
                    string nombre = row["Motorista"].ToString();

                    if (!mapaFilas.ContainsKey(idMoto))
                    {
                        int rowIndex = dgvAsistencia.Rows.Add();
                        dgvAsistencia.Rows[rowIndex].Cells["IdMotorista"].Value = idMoto;
                        dgvAsistencia.Rows[rowIndex].Cells["Motorista"].Value = nombre;
                        mapaFilas[idMoto] = rowIndex;
                        mapaStats[idMoto] = new StatsAsistencia();
                    }

                    if (row["Fecha"] != DBNull.Value)
                    {
                        DateTime fecha = Convert.ToDateTime(row["Fecha"]);
                        string colName = $"Dia_{fecha:yyyyMMdd}";

                        if (dgvAsistencia.Columns.Contains(colName))
                        {
                            int rowIndex = mapaFilas[idMoto];
                            var stats = mapaStats[idMoto];

                            DataGridViewCell celda = dgvAsistencia.Rows[rowIndex].Cells[colName];

                            string codigo = row["Codigo"] != DBNull.Value ? row["Codigo"].ToString() : "";
                            bool requiereTiempos = row["RequiereTiempos"] != DBNull.Value && Convert.ToBoolean(row["RequiereTiempos"]);
                            decimal horas = row["HorasCalculadas"] != DBNull.Value ? Convert.ToDecimal(row["HorasCalculadas"]) : 0;

                            celda.Tag = codigo;

                            // Visualización en celda
                            //if (requiereTiempos && horas > 0)
                            //    dgvAsistencia.Rows[rowIndex].Cells[colName].Value = horas.ToString("0.##");
                            //else
                            //    dgvAsistencia.Rows[rowIndex].Cells[colName].Value = codigo;
                            if (requiereTiempos && horas > 0)
                            {
                                celda.Value = horas.ToString("0.##"); // Muestra el número (ej. 8.00)
                            }
                            else
                            {
                                celda.Value = codigo; // Muestra el texto (ej. L)
                            }

                            // --- LÓGICA DE CONTADORES (TUS 4 CAMBIOS) ---

                            // A. ICP (Igual que antes)
                            if (codigo == "ICP") stats.DiasICP++;

                            // B. CAMBIO #1: Contar SDT
                            if (codigo == "SDT") stats.DiasSDT++;

                            // C. CAMBIO #4: Libres (NO contar Domingos)
                            if (codigo == "L" && fecha.DayOfWeek != DayOfWeek.Sunday)
                            {
                                stats.DiasLibres++;
                            }

                            // D. CAMBIO #2: Domingos Trabajados
                            // Regla: Es Domingo Y tiene horario ingresado (Horas > 0). Ignora códigos.
                            if (fecha.DayOfWeek == DayOfWeek.Sunday)
                            {
                                if (horas > 0)
                                {
                                    stats.DomingosTrabajados++;
                                }
                            }

                            // E. CAMBIO #3: Feriados Trabajados
                            // Regla: Es Feriado Y tiene horario ingresado (Horas > 0).
                            if (_feriadosDelMes.Contains(fecha.Date))
                            {
                                if (horas > 0)
                                {
                                    stats.DiasFeriadosTrabajados++;
                                }
                            }
                        }
                    }
                }

                // --- MOSTRAR TOTALES ---
                foreach (var kvp in mapaFilas)
                {
                    int id = kvp.Key;
                    int rowIndex = kvp.Value;
                    var stats = mapaStats[id];

                    // Asignar valores (si es 0 dejar vacío para limpieza visual)
                    dgvAsistencia.Rows[rowIndex].Cells["TotalICP"].Value = stats.DiasICP > 0 ? stats.DiasICP.ToString() : "";

                    dgvAsistencia.Rows[rowIndex].Cells["TotalSDT"].Value = stats.DiasSDT > 0 ? stats.DiasSDT.ToString() : "";

                    dgvAsistencia.Rows[rowIndex].Cells["TotalFer"].Value = stats.DiasFeriadosTrabajados > 0 ? stats.DiasFeriadosTrabajados.ToString() : "";

                    dgvAsistencia.Rows[rowIndex].Cells["TotalL"].Value = stats.DiasLibres > 0 ? stats.DiasLibres.ToString() : "";

                    dgvAsistencia.Rows[rowIndex].Cells["TotalDom"].Value = stats.DomingosTrabajados > 0 ? stats.DomingosTrabajados.ToString() : "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la asistencia: " + ex.Message);
            }
        }

        private void dgvAsistencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            try
            {
                // 1. Validar que la columna seleccionada sea un DÍA (empiezan con "Dia_")
                // Esto evita errores si hacen clic en "Motorista" o en las columnas de Totales ("TotalICP", etc)
                string colName = dgvAsistencia.Columns[e.ColumnIndex].Name;

                if (!colName.StartsWith("Dia_"))
                {
                    return; // No es una columna de fecha, no hacemos nada
                }

                // 2. Obtener la Fecha desde el nombre de la columna
                // El formato es "Dia_yyyyMMdd" (Ej: Dia_20251207).
                // Cortamos los primeros 4 caracteres ("Dia_") y parseamos el resto.
                string fechaString = colName.Substring(4); // Queda "20251207"
                DateTime fechaSeleccionada = DateTime.ParseExact(fechaString, "yyyyMMdd", CultureInfo.InvariantCulture);

                // 3. Obtener Datos del Motorista directamente de la fila
                // Ya no necesitamos buscar el ID en la BD, lo tenemos en la columna oculta "IdMotorista"
                int idMotorista = Convert.ToInt32(dgvAsistencia.Rows[e.RowIndex].Cells["IdMotorista"].Value);
                string nombreMotorista = dgvAsistencia.Rows[e.RowIndex].Cells["Motorista"].Value.ToString();

                // 4. Guardar posición del Scroll (UX)
                _filaActual = e.RowIndex;
                _columnaActual = e.ColumnIndex;

                try
                {
                    _filaSuperiorVisible = dgvAsistencia.FirstDisplayedScrollingRowIndex;
                    _horizontalScrollOffset = dgvAsistencia.HorizontalScrollingOffset;
                }
                catch
                {
                    _filaSuperiorVisible = 0;
                    _horizontalScrollOffset = 0;
                }
                // Obtener los límites del filtro actual
                DateTime limiteInicio = dtpInicio.Value.Date;
                DateTime limiteFin = dtpFin.Value.Date;

                // 5. Abrir el formulario de edición
                frmEditarAsistencia frm = new frmEditarAsistencia(idMotorista, nombreMotorista, fechaSeleccionada, limiteInicio, limiteFin);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarDatosAsistencia();
                    RestaurarPosicionGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir edición: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RestaurarPosicionGrid()
        {
            try
            {
                // 1. Restaurar la barra de scroll VERTICAL
                if (_filaSuperiorVisible > 0 && _filaSuperiorVisible < dgvAsistencia.RowCount)
                {
                    dgvAsistencia.FirstDisplayedScrollingRowIndex = _filaSuperiorVisible;
                }

                // 2. Restaurar la barra de scroll HORIZONTAL
                // (Asegúrate de que haya columnas a las que hacer scroll)
                if (_horizontalScrollOffset > 0 && dgvAsistencia.ColumnCount > 0)
                {
                    dgvAsistencia.HorizontalScrollingOffset = _horizontalScrollOffset;
                }

                // 3. Restaurar la celda seleccionada (al final)
                if (_filaActual < dgvAsistencia.RowCount && _columnaActual < dgvAsistencia.ColumnCount)
                {
                    dgvAsistencia.ClearSelection();
                    dgvAsistencia.CurrentCell = dgvAsistencia[_columnaActual, _filaActual];
                    dgvAsistencia[_columnaActual, _filaActual].Selected = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al restaurar posición del grid: " + ex.Message);
            }
        }
        private void chkMostrarInactivos_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatosAsistencia();
        }

        private void btnHorasExtras_Click(object sender, EventArgs e)
        {
            frmReporteHorasExtras frm = new frmReporteHorasExtras();
            frm.Show();
        }

        private void chkIncluirSubcontratistas_CheckedChanged(object sender, EventArgs e)
        {
            CargarDatosAsistencia();
        }

        private void dgvAsistencia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 1. Validaciones básicas
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string colName = dgvAsistencia.Columns[e.ColumnIndex].Name;
            if (!colName.StartsWith("Dia_")) return;

            // Reseteamos estilos
            e.CellStyle.BackColor = dgvAsistencia.DefaultCellStyle.BackColor;
            e.CellStyle.ForeColor = dgvAsistencia.DefaultCellStyle.ForeColor;
            e.CellStyle.Font = dgvAsistencia.DefaultCellStyle.Font;

            // --- NUEVO: LEER EL CÓDIGO OCULTO (TAG) ---
            string codigoOculto = dgvAsistencia.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag?.ToString();

            // 2. Obtener fecha y valores
            DateTime fechaCelda;
            try { fechaCelda = DateTime.ParseExact(colName.Substring(4), "yyyyMMdd", CultureInfo.InvariantCulture); } catch { return; }

            string valorCelda = e.Value?.ToString().Trim().ToUpper() ?? "";
            decimal horas;
            bool esNumero = decimal.TryParse(valorCelda, out horas);

            if (codigoOculto == "ICP" || codigoOculto == "IC")
            {
                e.CellStyle.BackColor = Color.Turquoise;
            }
            // Prioridad #1: Días Trabajados en DOMINGO o FERIADO
            else if (esNumero && horas > 0 && (fechaCelda.DayOfWeek == DayOfWeek.Sunday || _feriadosDelMes.Contains(fechaCelda.Date)))
            {
                e.CellStyle.BackColor = Color.Pink;
                if (horas > 8.0m) e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
            // Prioridad #2: Extras Normales
            else if (esNumero && horas > 8.0m)
            {
                e.CellStyle.BackColor = Color.Salmon;
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
            }
            // Prioridad #3: Otros Códigos de Texto (Leemos valorCelda O codigoOculto)
            else
            {
                // Usamos codigoOculto para mayor seguridad
                switch (codigoOculto)
                {
                    case "L":
                    case "V":
                    case "P":
                        e.CellStyle.BackColor = Color.LightYellow;
                        break;
                    case "F":
                    case "I":
                        e.CellStyle.BackColor = Color.LavenderBlush;
                        break;
                    case "SDT":
                        e.CellStyle.BackColor = Color.LightBlue;
                        break;
                    case "SUS":
                        e.CellStyle.BackColor = Color.LightGray;
                        break;
                }
            }

            // Prioridad #4: Ceros
            if (esNumero && horas == 0.0m)
            {
                e.CellStyle.ForeColor = Color.LightGray;
            }

            // --- LÓGICA DE OBSERVACIONES (Se mantiene al final para pintar encima de cualquier color) ---
            // (Tu código de Tooltips/Subrayado va aquí igual que antes)
            try
            {
                int idMoto = Convert.ToInt32(dgvAsistencia.Rows[e.RowIndex].Cells["IdMotorista"].Value);
                string clave = $"{idMoto}_{fechaCelda:yyyyMMdd}";
                if (_observacionesCache.ContainsKey(clave))
                {
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Underline | e.CellStyle.Font.Style);
                }
            }
            catch { }
        }
        private void CargarFiltroPoliticas()
        {
            try
            {
                var lista = _repoPoliticas.Listar();
                // Agregamos la opción "(Todas)" al inicio
                lista.Insert(0, new PoliticaPago { PoliticaID = 0, NombrePolitica = "(Todas)" });

                cboFiltroPolitica.DisplayMember = "NombrePolitica";
                cboFiltroPolitica.ValueMember = "PoliticaID";
                cboFiltroPolitica.DataSource = lista;

                // Suscribimos al evento aquí para evitar que se dispare mientras carga
                cboFiltroPolitica.SelectedIndexChanged += cboFiltroPolitica_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar políticas: " + ex.Message);
            }
        }

        private void CargarObservacionesDelMes()
        {
            _observacionesCache.Clear();
            DateTime inicio = dtpInicio.Value.Date;
            DateTime fin = dtpFin.Value.Date;

            try
            {
                foreach (ObservacionDia obs in _repoAsistencias.ListarObservaciones(inicio, fin))
                {
                    // CLAVE ÚNICA: ID_yyyMMdd (Ej: 10_20251207)
                    string clave = $"{obs.IdMotorista}_{obs.Fecha:yyyyMMdd}";

                    if (!_observacionesCache.ContainsKey(clave))
                    {
                        _observacionesCache.Add(clave, obs.Observaciones);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error observaciones: " + ex.Message);
            }
        }
        private void btnCerrarPeriodo_Click(object sender, EventArgs e)
        {
            // Solo permitimos abrir esto si hay un administrador (opcional a futuro)
            frmCerrarPeriodo frm = new frmCerrarPeriodo();
            frm.ShowDialog();

            // Al volver, sería bueno recargar la cuadrícula por si se cerraron registros visualizados
            CargarDatosAsistencia();
            // Re-aplicar formato para que los días cerrados (si decidimos pintarlos) se actualicen
            dgvAsistencia.Refresh();
        }

        private void btnFeriados_Click(object sender, EventArgs e)
        {
            frmFeriados frm = new frmFeriados();
            frm.ShowDialog();

            CargarDatosAsistencia();
        }

        private void cboFiltroPolitica_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosAsistencia();
        }

        private void frmAsistencias_Load(object sender, EventArgs e)
        {
            CargarFiltroPoliticas();
        }

        private void btnTiposAsistencia_Click(object sender, EventArgs e)
        {
            frmTiposAsistencia frm = new frmTiposAsistencia();
            frm.ShowDialog();
        }

        private void btnGestionSalarios_Click(object sender, EventArgs e)
        {
            frmHistorialSalarios frm = new frmHistorialSalarios();
            frm.ShowDialog();
        }

        private void btnPoliticas_Click(object sender, EventArgs e)
        {
            frmPoliticas frm = new frmPoliticas();
            frm.ShowDialog();

            CargarFiltroPoliticas();
        }


        private void dgvAsistencia_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Validar que no sea cabecera (-1)
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // 2. Validar que sea columna de Día
            string colName = dgvAsistencia.Columns[e.ColumnIndex].Name;
            if (!colName.StartsWith("Dia_")) return;

            // 3. Obtener la celda actual
            DataGridViewCell celda = dgvAsistencia.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Si la celda ya tiene el tooltip puesto, no recalcular (ahorra proceso)
            if (!string.IsNullOrEmpty(celda.ToolTipText)) return;

            try
            {
                // 4. Buscar en el caché
                int idMoto = Convert.ToInt32(dgvAsistencia.Rows[e.RowIndex].Cells["IdMotorista"].Value);
                string fechaString = colName.Substring(4); // "20260104"
                string clave = $"{idMoto}_{fechaString}";

                if (_observacionesCache.ContainsKey(clave))
                {
                    // Asignamos el texto DIRECTAMENTE a la propiedad de la celda
                    celda.ToolTipText = $"OBSERVACIÓN:\n{_observacionesCache[clave]}";

                    // Opcional: Cambiar el cursor para que el usuario sepa que hay algo ahí
                    dgvAsistencia.Cursor = Cursors.Help;
                }
                else
                {
                    // Asegurarnos de limpiar si no hay observación (por si se recicla la fila)
                    celda.ToolTipText = string.Empty;
                }
            }
            catch
            {
                // Ignorar errores silenciosamente
            }
        }

        private void dgvAsistencia_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Opcional: Restaurar cursor
                dgvAsistencia.Cursor = Cursors.Default;
            }
        }
    }
}
