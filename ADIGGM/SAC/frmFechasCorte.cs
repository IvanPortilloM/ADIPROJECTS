using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ADIGGM.SAC
{
    public partial class frmFechasCorte : FrmPrincipal
    {
        // 1. CONFIGURA TU CONEXIÓN AQUÍ
        string connectionString = ADIGGM.CapaDatos.Conexion.Cadena("TransporteAdiggm");

        // Variable para controlar si editamos (0 = Nuevo, >0 = ID a Editar)
        private int idRegistroEditar = 0;

        // Bandera para evitar recálculos infinitos
        private bool isCalculating = false;
        public frmFechasCorte()
        {
            InitializeComponent();
        }

        private void frmFechasCorte_Load(object sender, EventArgs e)
        {
            LimpiarFormulario();
            CargarHistorial();
        }

        private void CalcularFechas()
        {
            if (isCalculating) return;
            isCalculating = true;

            try
            {
                DateTime fechaFormalizacion = dtpFechaForma.Value;

                // REGLA: Fecha + 16 días de margen administrativo
                int diasMargen = 16;
                DateTime fechaPivote = fechaFormalizacion.AddDays(diasMargen);
                DateTime fechaPrimerPago;

                // Determinar corte matemático (15 o Fin de Mes)
                if (fechaPivote.Day <= 15)
                {
                    fechaPrimerPago = new DateTime(fechaPivote.Year, fechaPivote.Month, 15);
                }
                else
                {
                    int ultimoDia = DateTime.DaysInMonth(fechaPivote.Year, fechaPivote.Month);
                    fechaPrimerPago = new DateTime(fechaPivote.Year, fechaPivote.Month, ultimoDia);
                }

                // VALIDACIÓN DINÁMICA: Si el usuario dice que ya cerraron planilla
                if (chkCierreRealizado.Checked)
                {
                    fechaPrimerPago = ObtenerSiguienteCorte(fechaPrimerPago);
                }

                // Asignar valores a la UI
                dtpFechaPago.Value = fechaPrimerPago;
                txtPeriodo.Text = GenerarDescripcionPeriodo(fechaPrimerPago);
            }
            finally
            {
                isCalculating = false;
            }
        }

        private DateTime ObtenerSiguienteCorte(DateTime fechaActual)
        {
            if (fechaActual.Day <= 15) // Si es 15, salta a fin de mes
            {
                int ultimoDia = DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month);
                return new DateTime(fechaActual.Year, fechaActual.Month, ultimoDia);
            }
            else // Si es fin de mes, salta al 15 del siguiente
            {
                DateTime mesSiguiente = fechaActual.AddMonths(1);
                return new DateTime(mesSiguiente.Year, mesSiguiente.Month, 15);
            }
        }

        private string GenerarDescripcionPeriodo(DateTime fecha)
        {
            string quincena = (fecha.Day <= 15) ? "1.era" : "2.ª";
            CultureInfo cultura = new CultureInfo("es-ES");
            string mes = fecha.ToString("MMM", cultura).ToUpper().Replace(".", "");
            string anio = fecha.ToString("yy");
            return $"{quincena} QNA./{mes} {anio}";
        }

        // EVENTOS QUE DISPARAN EL CÁLCULO
        private void dtpFechaForma_ValueChanged(object sender, EventArgs e)
        {
            CalcularFechas();
        }

        private void chkCierreRealizado_CheckedChanged(object sender, EventArgs e)
        {
            CalcularFechas();
        }

        // --- ACCESO A DATOS (CRUD CON PROCEDIMIENTOS SAC_) ---

        private void CargarHistorial()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    // Usamos el procedimiento SAC_ListarFechasCorte
                    SqlDataAdapter da = new SqlDataAdapter("SAC_ListarFechasCorte", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvHistorial.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Decidir si es INSERT o UPDATE
                    if (idRegistroEditar == 0)
                    {
                        cmd.CommandText = "SAC_CrearFechaCorte";
                    }
                    else
                    {
                        cmd.CommandText = "SAC_ActualizarFechaCorte";
                        cmd.Parameters.AddWithValue("@ncodfecort", idRegistroEditar);
                    }

                    // Parámetros comunes
                    cmd.Parameters.AddWithValue("@dfechforma", dtpFechaForma.Value);
                    cmd.Parameters.AddWithValue("@dfecpripag", dtpFechaPago.Value);
                    cmd.Parameters.AddWithValue("@cperiodpag", txtPeriodo.Text);
                    cmd.Parameters.AddWithValue("@bestaactiv", chkActivo.Checked ? 1 : 0);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                    CargarHistorial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idRegistroEditar == 0) return;

            if (MessageBox.Show("¿Seguro que deseas eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("SAC_EliminarFechaCorte", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ncodfecort", idRegistroEditar);

                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registro eliminado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarFormulario();
                        CargarHistorial();
                    }
                }
                catch (SqlException sqlEx)
                {
                    if (sqlEx.Number == 547) // Error de Clave Foránea
                        MessageBox.Show("No se puede eliminar porque tiene préstamos asociados.", "Bloqueo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    else
                        MessageBox.Show("Error SQL: " + sqlEx.Message);
                }
            }
        }

        private void dgvHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvHistorial.Rows[e.RowIndex];

                // 1. Obtener ID (Asegúrate que coincida con el nombre de columna del SP Listar)
                // El SP devuelve: ncodfecort, dfechforma, etc.
                idRegistroEditar = Convert.ToInt32(fila.Cells["ncodfecort"].Value);

                // 2. Apagar evento temporalmente
                dtpFechaForma.ValueChanged -= dtpFechaForma_ValueChanged;

                // 3. Cargar datos
                dtpFechaForma.Value = Convert.ToDateTime(fila.Cells["dfechforma"].Value);
                dtpFechaPago.Value = Convert.ToDateTime(fila.Cells["dfecpripag"].Value); // Esto se sobrescribirá si no apagamos el cálculo, pero aquí ya lo apagamos.

                // Nota: Al cargar un histórico, reseteamos el check de "Cierre realizado" 
                // porque ese dato no se guardó en BD, es lógico del momento.
                chkCierreRealizado.Checked = false;

                txtPeriodo.Text = fila.Cells["cperiodpag"].Value.ToString();
                chkActivo.Checked = Convert.ToBoolean(fila.Cells["bestaactiv"].Value);

                // 4. Reactivar evento
                dtpFechaForma.ValueChanged += dtpFechaForma_ValueChanged;

                // 5. Ajustar Interfaz
                btnGuardar.Text = "Actualizar";
                btnEliminar.Visible = true;

                // Si tienes botón cancelar:
                if (btnCancelar != null) btnCancelar.Visible = true;
            }
        }
        private void LimpiarFormulario()
        {
            idRegistroEditar = 0;
            btnGuardar.Text = "Guardar";
            btnEliminar.Visible = false;
            if (btnCancelar != null) btnCancelar.Visible = false;

            dtpFechaForma.Value = DateTime.Now;
            chkActivo.Checked = true;
            chkCierreRealizado.Checked = false;

            // Recalcular para la fecha de hoy
            CalcularFechas();
        }

        // Botón Cancelar (si lo agregas)
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
