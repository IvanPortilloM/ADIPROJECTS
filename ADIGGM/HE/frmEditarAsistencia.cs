using ADIGGM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADIGGM.Clases;
using System.Data.SqlClient;

namespace ADIGGM.HE
{
    public partial class frmEditarAsistencia : FrmPrincipal
    {
        // Variables para guardar lo que recibimos
        private int _idMotorista;
        private DateTime _fecha;
        private int _registroAsistenciaID = 0; // Para saber si es INSERT o UPDATE

        // VARIABLES NUEVAS PARA LOS LÍMITES
        private DateTime _limiteInicio;
        private DateTime _limiteFin;

        // Constructor que RECIBE los datos
        public frmEditarAsistencia(int idMotorista, string nombreMotorista, DateTime fecha, DateTime limiteInicio, DateTime limiteFin)
        {
            InitializeComponent();

            // Guardamos los datos recibidos
            _idMotorista = idMotorista;
            _fecha = fecha;
            _limiteInicio = limiteInicio; // Guardamos límites
            _limiteFin = limiteFin;

            // Mostramos la info en la etiqueta
            lblInfo.Text = $"Motorista: {nombreMotorista}\nFecha: {_fecha.ToShortDateString()}";
        }
        private void frmEditarAsistencia_Load(object sender, EventArgs e)
        {
            // 1. Cargar el ComboBox con los tipos de asistencia (T, L, F...)
            CargarTiposAsistencia();

            // 2. Buscar si ya existe un registro para este día
            CargarDatosExistentes();

            // Asegura que la fecha "Hasta" inicie con el mismo valor que la fecha "Desde"
            dtpHasta.Value = _fecha;
        }
        /// <summary>
        /// Contiene la lógica para guardar la asistencia (Cabecera y Tiempos) para UN SOLO DÍA.
        /// Debe ser llamado dentro de una transacción.
        /// </summary>
        private void GuardarDiaUnico(int idMotoristaTarget, DateTime dia, int tipoAsistenciaID, bool requiereTiempos, string observaciones, SqlConnection conn, SqlTransaction trans)
        {
            int registroIDDelDia = 0;

            // --- PASO A: VERIFICAR SI EL DÍA YA EXISTE ---
            string queryCheck = "SELECT RegistroAsistenciaID FROM dbo.HE_RegistrosAsistencia WHERE IdMotorista = @IdMotorista AND Fecha = @Fecha";
            using (SqlCommand cmdCheck = new SqlCommand(queryCheck, conn, trans))
            {
                cmdCheck.Parameters.AddWithValue("@IdMotorista", idMotoristaTarget);
                cmdCheck.Parameters.AddWithValue("@Fecha", dia.Date);

                object result = cmdCheck.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    registroIDDelDia = Convert.ToInt32(result);
                }
            }

            // --- PASO B: INSERTAR O ACTUALIZAR LA CABECERA (HE_RegistrosAsistencia) ---
            string queryCabecera;
            if (registroIDDelDia == 0) // Es un NUEVO registro para este día
            {
                queryCabecera = @"
            INSERT INTO dbo.HE_RegistrosAsistencia (IdMotorista, Fecha, TipoAsistenciaID, Observaciones)
            VALUES (@IdMotorista, @Fecha, @TipoAsistenciaID, @Observaciones);
            SELECT SCOPE_IDENTITY();";
            }
            else // Es una ACTUALIZACIÓN
            {
                queryCabecera = @"
            UPDATE dbo.HE_RegistrosAsistencia
            SET TipoAsistenciaID = @TipoAsistenciaID,
            Observaciones = @Observaciones
            WHERE RegistroAsistenciaID = @RegistroID;";
            }

            using (SqlCommand cmdCabecera = new SqlCommand(queryCabecera, conn, trans))
            {
                cmdCabecera.Parameters.AddWithValue("@IdMotorista", idMotoristaTarget);
                cmdCabecera.Parameters.AddWithValue("@Fecha", dia.Date);
                cmdCabecera.Parameters.AddWithValue("@TipoAsistenciaID", tipoAsistenciaID);
                if (string.IsNullOrWhiteSpace(observaciones))
                    cmdCabecera.Parameters.AddWithValue("@Observaciones", DBNull.Value);
                else
                    cmdCabecera.Parameters.AddWithValue("@Observaciones", observaciones.Trim());
                if (registroIDDelDia == 0)
                {
                    registroIDDelDia = Convert.ToInt32(cmdCabecera.ExecuteScalar()); // Obtenemos el nuevo ID
                }
                else
                {
                    cmdCabecera.Parameters.AddWithValue("@RegistroID", registroIDDelDia);
                    cmdCabecera.ExecuteNonQuery();
                }
            }

            // --- PASO C: LIMPIAR SIEMPRE LOS TIEMPOS ANTIGUOS ---
            string queryLimpieza = "DELETE FROM dbo.HE_RegistrosTiempos WHERE RegistroAsistenciaID = @RegistroID";
            using (SqlCommand cmdLimpieza = new SqlCommand(queryLimpieza, conn, trans))
            {
                cmdLimpieza.Parameters.AddWithValue("@RegistroID", registroIDDelDia);
                cmdLimpieza.ExecuteNonQuery();
            }

            // --- PASO D: INSERTAR NUEVOS TIEMPOS (SÓLO SI SE REQUIERE) ---
            if (requiereTiempos)
            {
                string queryTiempo = @"INSERT INTO dbo.HE_RegistrosTiempos (RegistroAsistenciaID, HoraInicio, HoraFin) VALUES (@RegistroID, @Inicio, @Fin)";

                foreach (DataGridViewRow row in dgvTiempos.Rows)
                {
                    if (row.IsNewRow) continue;

                    DateTime horaInicio = dia.Date + DateTime.Parse(row.Cells["colInicio"].Value.ToString()).TimeOfDay;
                    DateTime horaFin = dia.Date + DateTime.Parse(row.Cells["colFin"].Value.ToString()).TimeOfDay;

                    if (horaFin <= horaInicio)
                    {
                        horaFin = horaFin.AddDays(1);
                    }

                    using (SqlCommand cmdTiempo = new SqlCommand(queryTiempo, conn, trans))
                    {
                        cmdTiempo.Parameters.AddWithValue("@RegistroID", registroIDDelDia);
                        cmdTiempo.Parameters.AddWithValue("@Inicio", horaInicio);
                        cmdTiempo.Parameters.AddWithValue("@Fin", horaFin);
                        cmdTiempo.ExecuteNonQuery();
                    }
                }
            }
        }
        private void CargarTiposAsistencia()
        {
            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT TipoAsistenciaID, Codigo + ' - ' + Descripcion AS Texto, RequiereTiempos FROM dbo.HE_TiposAsistencia";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cboTipoAsistencia.DisplayMember = "Texto";
                    cboTipoAsistencia.ValueMember = "TipoAsistenciaID";
                    cboTipoAsistencia.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar tipos: " + ex.Message);
                }
            }
        }

        private void CargarDatosExistentes()
        {
            using (SqlConnection conn = DbManager.GetConnection())
            {
                try
                {
                    conn.Open();
                    // --- MODIFICADO: Ahora traemos la nueva columna 'EstaCerrado' ---
                    string queryCabecera = "SELECT RegistroAsistenciaID, TipoAsistenciaID, EstaCerrado, Observaciones FROM dbo.HE_RegistrosAsistencia WHERE IdMotorista = @IdMotorista AND Fecha = @Fecha";

                    SqlCommand cmd = new SqlCommand(queryCabecera, conn);
                    cmd.Parameters.AddWithValue("@IdMotorista", _idMotorista);
                    cmd.Parameters.AddWithValue("@Fecha", _fecha);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // ¡Encontramos un registro!
                        _registroAsistenciaID = reader.GetInt32(0); // Guardamos el ID
                        int tipoAsistenciaID = reader.GetInt32(1);
                        bool esCerrado = reader.GetBoolean(2); // Leemos el estado de bloqueo

                        // Seleccionamos el valor en el ComboBox
                        cboTipoAsistencia.SelectedValue = tipoAsistenciaID;

                        if (!reader.IsDBNull(3)) // El índice 3 es Observaciones
                        {
                            txtObservaciones.Text = reader.GetString(3);
                        }
                        else
                        {
                            txtObservaciones.Text = "";
                        }

                        reader.Close();

                        // --- ¡NUEVA LÓGICA DE BLOQUEO! ---
                        if (esCerrado)
                        {
                            // Si el registro está cerrado, bloqueamos todo
                            lblInfo.Text += "\n\n*** PERÍODO CERRADO - NO SE PERMITEN CAMBIOS ***";
                            lblInfo.ForeColor = Color.Red;

                            // Deshabilitamos todos los controles
                            cboTipoAsistencia.Enabled = false;
                            chkAplicarRango.Enabled = false;
                            dtpHasta.Enabled = false;
                            dgvTiempos.ReadOnly = true; // El grid de tiempos
                            btnGuardar.Enabled = false; // El botón de guardar
                        }
                        else
                        {
                            // Si no está cerrado, cargamos los tiempos (lógica normal)
                            if (pnlTiempos.Visible)
                            {
                                string queryTiempos = "SELECT HoraInicio, HoraFin FROM dbo.HE_RegistrosTiempos WHERE RegistroAsistenciaID = @RegistroID";
                                SqlCommand cmdTiempos = new SqlCommand(queryTiempos, conn);
                                cmdTiempos.Parameters.AddWithValue("@RegistroID", _registroAsistenciaID);

                                SqlDataReader readerTiempos = cmdTiempos.ExecuteReader();
                                while (readerTiempos.Read())
                                {
                                    DateTime inicio = readerTiempos.GetDateTime(0);
                                    DateTime fin = readerTiempos.GetDateTime(1);
                                    dgvTiempos.Rows.Add(inicio.ToString("HH:mm"), fin.ToString("HH:mm"));
                                }
                                readerTiempos.Close();
                            }
                        }
                    }
                    // Si reader.Read() es falso (no hay registro), el formulario
                    // se queda "limpio" y listo para un INSERT, lo cual es correcto.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos existentes: " + ex.Message);
                }
            }
        }
        private void cboTipoAsistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoAsistencia.SelectedItem != null)
            {
                // Obtenemos la fila seleccionada del DataTable que está enlazado al ComboBox
                DataRowView row = (DataRowView)cboTipoAsistencia.SelectedItem;
                bool requiereTiempos = Convert.ToBoolean(row["RequiereTiempos"]);

                // Mostramos u ocultamos el panel de tiempos según corresponda
                pnlTiempos.Visible = requiereTiempos;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones (son las mismas de antes)
            if (cboTipoAsistencia.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de asistencia.");
                return;
            }

            int tipoAsistenciaID = (int)cboTipoAsistencia.SelectedValue;
            bool requiereTiempos = pnlTiempos.Visible;

            if (requiereTiempos)
            {
                if (dgvTiempos.Rows.Count <= 1 && dgvTiempos.Rows[0].IsNewRow) { MessageBox.Show("Ingrese tiempos."); return; }
                foreach (DataGridViewRow row in dgvTiempos.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.Cells["colInicio"].Value == null || row.Cells["colFin"].Value == null) { /*...error...*/ return; }
                    DateTime inicio, fin;
                    if (!DateTime.TryParse(row.Cells["colInicio"].Value.ToString(), out inicio) || !DateTime.TryParse(row.Cells["colFin"].Value.ToString(), out fin)) { /*...error...*/ return; }
                }
            }

            // --- NUEVA LÓGICA DE RANGO ---
            // 2. Definir el rango de fechas a procesar
            DateTime fechaInicio = _fecha.Date; // El día original que se abrió
            DateTime fechaFin = _fecha.Date;    // Por defecto, es el mismo día

            if (chkAplicarRango.Checked)
            {
                fechaFin = dtpHasta.Value.Date; // Si el check está marcado, usamos la fecha "Hasta"

                if (fechaFin < fechaInicio)
                {
                    MessageBox.Show("La fecha 'Hasta' no puede ser anterior a la fecha de inicio.");
                    return;
                }
            }

            string obs = txtObservaciones.Text;

            // 3. Guardar en la Base de Datos (La transacción AHORA envuelve el bucle)
            using (SqlConnection conn = DbManager.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // --- INICIO DEL BUCLE ---
                    // Este bucle se ejecutará 1 vez (si no hay rango) o N veces (si hay rango)
                    for (DateTime dia = fechaInicio; dia <= fechaFin; dia = dia.AddDays(1))
                    {
                        // Opcional: Ignorar Domingos si tu regla de negocio lo pide
                        // if (dia.DayOfWeek == DayOfWeek.Sunday) continue;

                        // Llamamos a nuestro nuevo método para CADA día en el bucle
                        GuardarDiaUnico(_idMotorista, dia, tipoAsistenciaID, requiereTiempos, obs, conn, transaction);
                    }
                    // --- FIN DEL BUCLE ---

                    // Si el bucle terminó sin errores, confirmamos TODO
                    transaction.Commit();
                    MessageBox.Show($"Registros guardados correctamente desde {fechaInicio.ToShortDateString()} hasta {fechaFin.ToShortDateString()}.", "Éxito");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error al guardar en base de datos: " + ex.Message);
                }
            }
        }

        private void chkAplicarRango_CheckedChanged(object sender, EventArgs e)
        {
            // Muestra u oculta el selector de fecha "Hasta"
            dtpHasta.Visible = chkAplicarRango.Checked;
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas
            if (cboTipoAsistencia.SelectedValue == null) { MessageBox.Show("Seleccione un tipo."); return; }

            // Datos de la UI
            int tipoAsistenciaID = (int)cboTipoAsistencia.SelectedValue;
            bool requiereTiempos = pnlTiempos.Visible;
            string obs = txtObservaciones.Text;

            // Validar horas si aplica
            if (requiereTiempos)
            {
                if (dgvTiempos.Rows.Count <= 1 && dgvTiempos.Rows[0].IsNewRow) { MessageBox.Show("Ingrese horas."); return; }
                // Agregar validaciones de formato de horas aquí si las tienes...
            }

            // 2. Abrir Popup (Pasando los 4 parámetros nuevos)
            frmCopiarAsistencia frm = new frmCopiarAsistencia(_idMotorista, _fecha, _limiteInicio, _limiteFin);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<int> listaMotoristas = frm.IdsMotoristasSeleccionados; // Incluye al original
                List<DateTime> listaFechas = frm.FechasSeleccionadas;       // Incluye la fecha original

                // 3. Guardado Masivo Unificado
                using (SqlConnection conn = DbManager.GetConnection())
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();
                    try
                    {
                        int contador = 0;

                        // Bucle Sencillo: Recorremos todo lo que vino del popup
                        // Como el usuario ya no puede desmarcar al original ni borrar la fecha actual,
                        // esto garantiza que SIEMPRE se guarda el registro actual + las copias.
                        foreach (int idMoto in listaMotoristas)
                        {
                            foreach (DateTime dia in listaFechas)
                            {
                                GuardarDiaUnico(idMoto, dia, tipoAsistenciaID, requiereTiempos, obs, conn, transaction);
                                contador++;
                            }
                        }

                        transaction.Commit();

                        MessageBox.Show($"Proceso completado. Se procesaron {contador} registros.", "Éxito");

                        this.DialogResult = DialogResult.OK; // Para refrescar el Grid principal
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error en copiado masivo: " + ex.Message);
                    }
                }
            }
        }
    } 
}
