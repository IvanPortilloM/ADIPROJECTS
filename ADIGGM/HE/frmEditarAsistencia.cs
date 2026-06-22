using ADIGGM.CapaDatos;
using ADIGGM.CapaModelo;
using ADIGGM.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ADIGGM.HE
{
    public partial class frmEditarAsistencia : FrmPrincipal
    {
        private readonly RepositorioAsistencias _repo = new RepositorioAsistencias();

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
            ConfigurarColumnas();

            // Guardamos los datos recibidos
            _idMotorista = idMotorista;
            _fecha = fecha;
            _limiteInicio = limiteInicio; // Guardamos límites
            _limiteFin = limiteFin;

            // Mostramos la info en la etiqueta
            lblInfo.Text = $"Motorista: {nombreMotorista}\nFecha: {_fecha.ToShortDateString()}";
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para inmunizarlo al borrado del
        /// diseñador de VS — gotcha §11. Grid NO enlazado (Rows.Add posicional): colInicio/colFin son
        /// TextBox sin DataPropertyName, formato hora corta ("t"); el .cs accede por Name → Names exactos.
        /// Editables (el usuario digita las horas); el grid se bloquea entero con dgvTiempos.ReadOnly=true
        /// si el período está cerrado (CargarDatosExistentes). AutoSizeColumnsMode=Fill queda en el grid.</summary>
        private void ConfigurarColumnas()
        {
            dgvTiempos.AutoGenerateColumns = false;
            dgvTiempos.Columns.Clear();
            dgvTiempos.Columns.Add(GridColumnas.Texto("colInicio", "", "Hora de Inicio", format: "t", readOnly: false));
            dgvTiempos.Columns.Add(GridColumnas.Texto("colFin", "", "Hora Final", format: "t", readOnly: false));
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

        private void CargarTiposAsistencia()
        {
            try
            {
                cboTipoAsistencia.DisplayMember = "Texto";
                cboTipoAsistencia.ValueMember = "TipoAsistenciaID";
                cboTipoAsistencia.DataSource = _repo.ListarTiposCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos: " + ex.Message);
            }
        }

        private void CargarDatosExistentes()
        {
            try
            {
                RegistroAsistenciaCab registro = _repo.ObtenerRegistro(_idMotorista, _fecha);

                // Si no hay registro, el formulario queda "limpio" y listo para un INSERT.
                if (registro == null) return;

                // ¡Encontramos un registro!
                _registroAsistenciaID = registro.RegistroAsistenciaID;
                cboTipoAsistencia.SelectedValue = registro.TipoAsistenciaID;
                txtObservaciones.Text = registro.Observaciones ?? "";

                // --- LÓGICA DE BLOQUEO ---
                if (registro.EstaCerrado)
                {
                    // Si el registro está cerrado, bloqueamos todo
                    lblInfo.Text += "\n\n*** PERÍODO CERRADO - NO SE PERMITEN CAMBIOS ***";
                    lblInfo.ForeColor = Color.Red;

                    cboTipoAsistencia.Enabled = false;
                    chkAplicarRango.Enabled = false;
                    dtpHasta.Enabled = false;
                    dgvTiempos.ReadOnly = true;
                    btnGuardar.Enabled = false;
                }
                else
                {
                    // Si no está cerrado, cargamos los tiempos (lógica normal)
                    if (pnlTiempos.Visible)
                    {
                        foreach (TiempoTrabajado t in _repo.ListarTiempos(_registroAsistenciaID))
                        {
                            dgvTiempos.Rows.Add(t.HoraInicio.ToString("HH:mm"), t.HoraFin.ToString("HH:mm"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos existentes: " + ex.Message);
            }
        }

        private void cboTipoAsistencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // El item enlazado ahora es un POCO (antes era un DataRowView)
            if (cboTipoAsistencia.SelectedItem is TipoAsistenciaCombo tipo)
            {
                // Mostramos u ocultamos el panel de tiempos según corresponda
                pnlTiempos.Visible = tipo.RequiereTiempos;
            }
        }

        /// <summary>Extrae los bloques de tiempo (hora de inicio/fin) del grid de tiempos.</summary>
        private List<(TimeSpan Inicio, TimeSpan Fin)> ExtraerTiempos(bool requiereTiempos)
        {
            var tiempos = new List<(TimeSpan Inicio, TimeSpan Fin)>();
            if (!requiereTiempos) return tiempos;

            foreach (DataGridViewRow row in dgvTiempos.Rows)
            {
                if (row.IsNewRow) continue;
                tiempos.Add((
                    DateTime.Parse(row.Cells["colInicio"].Value.ToString()).TimeOfDay,
                    DateTime.Parse(row.Cells["colFin"].Value.ToString()).TimeOfDay
                ));
            }
            return tiempos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Validaciones
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

            // --- LÓGICA DE RANGO ---
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

            // 3. Guardar (la transacción la maneja el repositorio: atómico para todo el rango)
            try
            {
                List<DateTime> dias = new List<DateTime>();
                for (DateTime dia = fechaInicio; dia <= fechaFin; dia = dia.AddDays(1))
                {
                    dias.Add(dia);
                }

                _repo.GuardarDias(new[] { _idMotorista }, dias, tipoAsistenciaID, requiereTiempos, obs, ExtraerTiempos(requiereTiempos));

                MessageBox.Show($"Registros guardados correctamente desde {fechaInicio.ToShortDateString()} hasta {fechaFin.ToShortDateString()}.", "Éxito");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar en base de datos: " + ex.Message);
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
            }

            // 2. Abrir Popup (Pasando los 4 parámetros nuevos)
            frmCopiarAsistencia frm = new frmCopiarAsistencia(_idMotorista, _fecha, _limiteInicio, _limiteFin);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                List<int> listaMotoristas = frm.IdsMotoristasSeleccionados; // Incluye al original
                List<DateTime> listaFechas = frm.FechasSeleccionadas;       // Incluye la fecha original

                // 3. Guardado Masivo Unificado (transacción en el repositorio)
                try
                {
                    int contador = _repo.GuardarDias(listaMotoristas, listaFechas, tipoAsistenciaID, requiereTiempos, obs, ExtraerTiempos(requiereTiempos));

                    MessageBox.Show($"Proceso completado. Se procesaron {contador} registros.", "Éxito");

                    this.DialogResult = DialogResult.OK; // Para refrescar el Grid principal
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error en copiado masivo: " + ex.Message);
                }
            }
        }
    }
}
