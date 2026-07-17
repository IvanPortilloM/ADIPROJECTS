using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using ADIGGM.CapaModelo;
using ADIGGM.Clases;

namespace ADIGGM.BIO
{
    /// <summary>Descarga y reporte de asistencia del reloj biométrico ZKTeco (módulo BIO, empleados
    /// administrativos — independiente del módulo HE). "Descargar del reloj" baja el log completo vía
    /// ZKTecoLector (SDK gratuito, TCP/IP:4370) a BIO_Marcas con deduplicación; el reporte muestra
    /// Entrada (primera marca) / Salida (última) / Horas por empleado/día, con detalle y export a Excel.</summary>
    public partial class frmBioAsistencia : FrmPrincipal
    {
        private readonly RepositorioBiometrico _repo = new RepositorioBiometrico();
        private DataTable _dtResumen;

        public frmBioAsistencia()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas de ambos grids EN CÓDIGO (gotcha §11); ambos de solo lectura.</summary>
        private void ConfigurarColumnas()
        {
            dgvResumen.AutoGenerateColumns = false;
            dgvResumen.Columns.Clear();
            dgvResumen.Columns.Add(GridColumnas.Texto("IdBiometrico", "IdBiometrico", "No.", width: 45));
            dgvResumen.Columns.Add(GridColumnas.Texto("Empleado", "Empleado", "Empleado", width: 220));
            dgvResumen.Columns.Add(GridColumnas.Texto("Fecha", "Fecha", "Fecha", format: "d", width: 85));
            dgvResumen.Columns.Add(GridColumnas.Texto("Entrada", "Entrada", "Entrada", format: "HH:mm:ss", width: 85));
            dgvResumen.Columns.Add(GridColumnas.Texto("Salida", "Salida", "Salida", format: "HH:mm:ss", width: 85));
            dgvResumen.Columns.Add(GridColumnas.Texto("Horas", "Horas", "Horas", format: "N2", width: 65));
            dgvResumen.Columns.Add(GridColumnas.Texto("Marcas", "Marcas", "# Marcas", width: 70));

            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.Columns.Clear();
            dgvDetalle.Columns.Add(GridColumnas.Texto("FechaHora", "FechaHora", "Marca", format: "dd/MM/yyyy HH:mm:ss", width: 150));
            dgvDetalle.Columns.Add(GridColumnas.Texto("Verificacion", "Verificacion", "Verificación", width: 110));
        }

        private void frmBioAsistencia_Load(object sender, EventArgs e)
        {
            txtIp.Text = ConfigurationManager.AppSettings["BiometricoIp"] ?? "";
            txtPuerto.Text = ConfigurationManager.AppSettings["BiometricoPuerto"] ?? "4370";
            dtpDesde.Value = DateTime.Today.AddDays(-7);
            dtpHasta.Value = DateTime.Today;

            bioEmpleadosBindingSource.DataSource = _repo.ListarEmpleadosConTodos();
            cboEmpleado.SelectedIndex = 0;

            MostrarUltimaDescarga();
            CargarReporte();
        }

        private void MostrarUltimaDescarga()
        {
            DateTime? ultima = _repo.UltimaDescarga();
            lblUltima.Text = ultima == null
                ? "Última descarga: (nunca)"
                : "Última descarga: " + ultima.Value.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIp.Text))
            {
                MessageBox.Show("Ingrese la IP del reloj (Menú > Comunicación en el equipo). Puede dejarla fija en App.config (BiometricoIp).",
                    VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int puerto;
            if (!int.TryParse(txtPuerto.Text, out puerto)) puerto = 4370;

            Cursor = Cursors.WaitCursor;
            btnDescargar.Enabled = false;
            try
            {
                var marcas = ZKTecoLector.DescargarMarcas(txtIp.Text.Trim(), puerto);
                if (marcas.Count == 0)
                {
                    MessageBox.Show("El reloj no devolvió ninguna marca (¿aún no hay checadas registradas?).",
                        VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var resultado = _repo.InsertarMarcas(marcas, DateTime.Now);
                int noRegistrados = _repo.ContarNoRegistrados();

                string mensaje = "Descarga completada:\n\n" +
                    "Marcas nuevas: " + resultado.Nuevas + "\n" +
                    "Ya existían (ignoradas): " + resultado.Existentes;
                if (noRegistrados > 0)
                    mensaje += "\n\n⚠ Hay " + noRegistrados + " número(s) de usuario del reloj SIN registrar en el " +
                               "catálogo de empleados — aparecen como \"(no registrado)\"; agréguelos en Empleados Biométrico.";
                MessageBox.Show(mensaje, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);

                MostrarUltimaDescarga();
                CargarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDescargar.Enabled = true;
                Cursor = Cursors.Default;
            }
        }

        private void CargarReporte()
        {
            int idEmpleado = cboEmpleado.SelectedValue == null ? 0 : Convert.ToInt32(cboEmpleado.SelectedValue);
            _dtResumen = _repo.ReporteResumen(dtpDesde.Value, dtpHasta.Value, idEmpleado);
            dgvResumen.DataSource = _dtResumen;

            // Días con una sola marca o marcas impares (falta entrada o salida): resaltados
            foreach (DataGridViewRow row in dgvResumen.Rows)
            {
                int marcasDia = Convert.ToInt32(row.Cells["Marcas"].Value);
                if (marcasDia % 2 != 0)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 205); // naranja suave
            }
            lblFooter.Text = "Asistencia Biométrico - Días listados: " + dgvResumen.RowCount;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                MessageBox.Show("La fecha Desde no puede ser posterior a Hasta", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CargarReporte();
        }

        private void dgvResumen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvResumen.CurrentRow == null)
            {
                dgvDetalle.DataSource = null;
                return;
            }
            int idBiometrico = Convert.ToInt32(dgvResumen.CurrentRow.Cells["IdBiometrico"].Value);
            DateTime fecha = Convert.ToDateTime(dgvResumen.CurrentRow.Cells["Fecha"].Value);
            dgvDetalle.DataSource = _repo.DetalleMarcas(idBiometrico, fecha);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (_dtResumen == null || _dtResumen.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar; genere primero el reporte.", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var sfd = new SaveFileDialog { Filter = "Excel (*.xlsx)|*.xlsx", FileName = "AsistenciaBiometrico_" + DateTime.Today.ToString("yyyyMMdd") + ".xlsx" })
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    using (var wb = new ClosedXML.Excel.XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Asistencia");
                        ws.Cell(1, 1).InsertTable(_dtResumen, "Asistencia", true);
                        ws.Columns().AdjustToContents();
                        wb.SaveAs(sfd.FileName);
                    }
                    MessageBox.Show("Reporte exportado exitosamente", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
