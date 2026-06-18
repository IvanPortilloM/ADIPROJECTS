using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ADIGGM.CapaDatos;
using ADIGGM.CapaModelo;
using ADIGGM.Clases;

namespace ADIGGM.Mantenimiento
{
    /// <summary>
    /// Actualización masiva de tarifas aplicando un porcentaje (subir/bajar). Tres procesos
    /// INDEPENDIENTES en pestañas: tarifa base (TR_AsigRutaTipoVeh, solo tipo de vehículo), tarifa
    /// asignada (TR_TarifaRutas: cliente+tipo veh.+clase) y boletas (TR_Viajes: lo mismo + rango de
    /// fechas). La vista previa muestra "tarifa actual → tarifa nueva" y permite ajustar cada fila a
    /// mano. Cada "Aplicar" persiste en UNA transacción (todo-o-nada) y registra en ADI_Auditoria.
    /// </summary>
    public partial class FrmActualizarTarifas : FrmPrincipal
    {
        private enum Modo { Base = 0, Asignada = 1, Viajes = 2 }

        private readonly RepositorioTransporte _repo = new RepositorioTransporte();
        private BindingList<FilaTarifa> _previaTarifas;
        private BindingList<FilaViaje> _previaViajes;

        public FrmActualizarTarifas()
        {
            InitializeComponent();
            FuncionesGlobales estilo = new FuncionesGlobales();
            estilo.EstiloDgv(dgvPrevia);
            dgvPrevia.DataError += dgvPrevia_DataError;
        }

        private Modo ModoActual { get { return (Modo)tabsProceso.SelectedIndex; } }

        private void FrmActualizarTarifas_Load(object sender, EventArgs e)
        {
            // Cada combo con su propio DataTable (evita que combos del mismo DataSource compartan selección).
            CargarCombo(cboTvBase, _repo.ListarTipoVehiculosActivos(), "TipoVehiculo", "IdTipoVehiculo");

            CargarCombo(cboClienteAsig, _repo.ListarClientesActivos(), "Cliente", "IdCliente");
            CargarCombo(cboTvAsig, _repo.ListarTipoVehiculosActivos(), "TipoVehiculo", "IdTipoVehiculo");
            CargarCombo(cboClaseAsig, _repo.ListarClaseTrabajosActivos(), "ClaseTrabajo", "IdClaseTrabajo");

            CargarCombo(cboClienteViaje, _repo.ListarClientesActivos(), "Cliente", "IdCliente");
            CargarCombo(cboTvViaje, _repo.ListarTipoVehiculosActivos(), "TipoVehiculo", "IdTipoVehiculo");
            CargarCombo(cboClaseViaje, _repo.ListarClaseTrabajosActivos(), "ClaseTrabajo", "IdClaseTrabajo");

            dtpDesde.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpHasta.Value = DateTime.Today;
        }

        private static void CargarCombo(ComboBox combo, System.Data.DataTable datos, string display, string value)
        {
            combo.DataSource = datos;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.SelectedIndex = -1;
        }

        private void tabsProceso_SelectedIndexChanged(object sender, EventArgs e)
        {
            LimpiarPrevia();
        }

        private void LimpiarPrevia()
        {
            dgvPrevia.DataSource = null;
            dgvPrevia.Columns.Clear();
            _previaTarifas = null;
            _previaViajes = null;
            btnAplicar.Enabled = false;
            lblRegistros.Text = "Registros: 0";
        }

        /// <summary>Si ya hay una previa cargada, recalcula la "tarifa nueva" de todas las filas con el
        /// nuevo %. (Cambiar el % es el "baseline": reaplica a todo, sobrescribiendo ajustes por fila.)</summary>
        private void nudPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            decimal pct = nudPorcentaje.Value;
            if (_previaViajes != null)
            {
                foreach (FilaViaje f in _previaViajes) RecalcularViaje(f, pct);
                _previaViajes.ResetBindings();
            }
            else if (_previaTarifas != null)
            {
                foreach (FilaTarifa f in _previaTarifas) f.TarifaNueva = Redondear(f.TarifaActual * (1 + pct / 100m));
                _previaTarifas.ResetBindings();
            }
        }

        private void btnPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                Modo m = ModoActual;
                decimal pct = nudPorcentaje.Value;

                if (m == Modo.Base)
                {
                    if (cboTvBase.SelectedIndex < 0) { Aviso("Seleccione el tipo de vehículo."); return; }
                    List<FilaTarifa> filas = _repo.PreviewTarifasBase(Convert.ToInt32(cboTvBase.SelectedValue));
                    AplicarPctTarifas(filas, pct);
                    _previaTarifas = new BindingList<FilaTarifa>(filas);
                    ConfigurarColumnasTarifa(false);
                    dgvPrevia.DataSource = _previaTarifas;
                    FinalizarPrevia(filas.Count);
                }
                else if (m == Modo.Asignada)
                {
                    if (cboClienteAsig.SelectedIndex < 0 || cboTvAsig.SelectedIndex < 0 || cboClaseAsig.SelectedIndex < 0)
                    { Aviso("Seleccione cliente, tipo de vehículo y clase de trabajo."); return; }
                    List<FilaTarifa> filas = _repo.PreviewTarifasAsignadas(
                        Convert.ToInt32(cboClienteAsig.SelectedValue), Convert.ToInt32(cboClaseAsig.SelectedValue),
                        Convert.ToInt32(cboTvAsig.SelectedValue));
                    AplicarPctTarifas(filas, pct);
                    _previaTarifas = new BindingList<FilaTarifa>(filas);
                    ConfigurarColumnasTarifa(true);
                    dgvPrevia.DataSource = _previaTarifas;
                    FinalizarPrevia(filas.Count);
                }
                else // Viajes
                {
                    if (cboClienteViaje.SelectedIndex < 0 || cboTvViaje.SelectedIndex < 0 || cboClaseViaje.SelectedIndex < 0)
                    { Aviso("Seleccione cliente, tipo de vehículo y clase de trabajo."); return; }
                    DateTime ini = dtpDesde.Value.Date, fin = dtpHasta.Value.Date;
                    if (ini > fin) { Aviso("La fecha 'Desde' no puede ser mayor que 'Hasta'."); return; }
                    List<FilaViaje> filas = _repo.PreviewViajes(
                        Convert.ToInt32(cboClienteViaje.SelectedValue), Convert.ToInt32(cboClaseViaje.SelectedValue),
                        Convert.ToInt32(cboTvViaje.SelectedValue), ini, fin);
                    foreach (FilaViaje f in filas) RecalcularViaje(f, pct);
                    _previaViajes = new BindingList<FilaViaje>(filas);
                    ConfigurarColumnasViaje();
                    dgvPrevia.DataSource = _previaViajes;
                    FinalizarPrevia(filas.Count);
                }
            }
            catch (Exception ex) { Error(ex); }
        }

        private static void AplicarPctTarifas(List<FilaTarifa> filas, decimal pct)
        {
            foreach (FilaTarifa f in filas) f.TarifaNueva = Redondear(f.TarifaActual * (1 + pct / 100m));
        }

        private void FinalizarPrevia(int n)
        {
            lblRegistros.Text = "Registros: " + n;
            btnAplicar.Enabled = n > 0;
            dgvPrevia.ClearSelection();
        }

        // ----- Cálculo -----

        private static decimal Redondear(decimal v)
        {
            return Math.Round(v, 4, MidpointRounding.AwayFromZero);
        }

        private static void RecalcularViaje(FilaViaje f, decimal pct)
        {
            f.TarifaNueva = Redondear(f.TarifaActual * (1 + pct / 100m));
            RecalcularTotales(f);
        }

        /// <summary>Recalcula Subtotal/ISV/Total preservando la TASA de ISV original de la boleta
        /// (ISVActual / SubtotalActual); si la boleta no tenía ISV, sigue sin ISV.</summary>
        private static void RecalcularTotales(FilaViaje f)
        {
            decimal tasaIsv = f.SubtotalActual != 0 ? f.IsvActual / f.SubtotalActual : 0m;
            f.SubtotalNuevo = Redondear(f.Cantidad * f.TarifaNueva);
            f.IsvNuevo = Redondear(f.SubtotalNuevo * tasaIsv);
            f.TotalNuevo = f.SubtotalNuevo + f.IsvNuevo;
        }

        // ----- Columnas (en código, gotcha §11) -----

        private void ConfigurarColumnasTarifa(bool incluyeClienteClase)
        {
            DataGridViewAutoSizeColumnMode dc = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPrevia.AutoGenerateColumns = false;
            dgvPrevia.Columns.Clear();
            dgvPrevia.Columns.Add(GridColumnas.Texto("Id", "Id", "Id", visible: false));
            if (incluyeClienteClase)
            {
                dgvPrevia.Columns.Add(GridColumnas.Texto("Cliente", "Cliente", "Cliente", autoSize: dc));
                dgvPrevia.Columns.Add(GridColumnas.Texto("ClaseTrabajo", "ClaseTrabajo", "Clase Trabajo", autoSize: dc));
            }
            dgvPrevia.Columns.Add(GridColumnas.Texto("TipoVehiculo", "TipoVehiculo", "Tipo Vehículo", autoSize: dc));
            dgvPrevia.Columns.Add(GridColumnas.Texto("Ruta", "Ruta", "Ruta", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvPrevia.Columns.Add(GridColumnas.Texto("TarifaActual", "TarifaActual", "Tarifa actual", format: "N4", width: 110));
            dgvPrevia.Columns.Add(GridColumnas.Texto("TarifaNueva", "TarifaNueva", "Tarifa nueva", format: "N4", width: 110, readOnly: false));
        }

        private void ConfigurarColumnasViaje()
        {
            DataGridViewAutoSizeColumnMode dc = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvPrevia.AutoGenerateColumns = false;
            dgvPrevia.Columns.Clear();
            dgvPrevia.Columns.Add(GridColumnas.Texto("IdViaje", "IdViaje", "Id", visible: false));
            dgvPrevia.Columns.Add(GridColumnas.Texto("Fecha", "Fecha", "Fecha", format: "d", width: 80, autoSize: dc));
            dgvPrevia.Columns.Add(GridColumnas.Texto("NumBoleta", "NumBoleta", "Boleta", width: 80, autoSize: dc));
            dgvPrevia.Columns.Add(GridColumnas.Texto("Cliente", "Cliente", "Cliente", autoSize: dc));
            dgvPrevia.Columns.Add(GridColumnas.Texto("TipoVehiculo", "TipoVehiculo", "Tipo Veh.", autoSize: dc));
            dgvPrevia.Columns.Add(GridColumnas.Texto("Ruta", "Ruta", "Ruta", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvPrevia.Columns.Add(GridColumnas.Texto("Cantidad", "Cantidad", "Cantidad", format: "N2", width: 70));
            dgvPrevia.Columns.Add(GridColumnas.Texto("TarifaActual", "TarifaActual", "Tarifa actual", format: "N4", width: 95));
            dgvPrevia.Columns.Add(GridColumnas.Texto("TarifaNueva", "TarifaNueva", "Tarifa nueva", format: "N4", width: 95, readOnly: false));
            dgvPrevia.Columns.Add(GridColumnas.Texto("SubtotalNuevo", "SubtotalNuevo", "Subtotal nuevo", format: "N4", width: 100));
            dgvPrevia.Columns.Add(GridColumnas.Texto("IsvNuevo", "IsvNuevo", "ISV nuevo", format: "N4", width: 85));
            dgvPrevia.Columns.Add(GridColumnas.Texto("TotalNuevo", "TotalNuevo", "Total nuevo", format: "N4", width: 95));
        }

        // ----- Edición por fila en la previa -----

        private void dgvPrevia_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvPrevia.Columns[e.ColumnIndex].Name != "TarifaNueva") return;
            try
            {
                if (_previaViajes != null)
                {
                    FilaViaje f = _previaViajes[e.RowIndex];
                    f.TarifaNueva = Redondear(f.TarifaNueva);
                    RecalcularTotales(f);
                    _previaViajes.ResetItem(e.RowIndex);
                }
                else if (_previaTarifas != null)
                {
                    FilaTarifa f = _previaTarifas[e.RowIndex];
                    f.TarifaNueva = Redondear(f.TarifaNueva);
                    _previaTarifas.ResetItem(e.RowIndex);
                }
            }
            catch (Exception ex) { Error(ex); }
        }

        private void dgvPrevia_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Valor inválido (texto no numérico en Tarifa nueva): se cancela y se conserva el valor previo.
            e.Cancel = true;
        }

        // ----- Aplicar -----

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                Modo m = ModoActual;
                dgvPrevia.EndEdit();

                int total = (m == Modo.Viajes) ? (_previaViajes != null ? _previaViajes.Count : 0)
                                               : (_previaTarifas != null ? _previaTarifas.Count : 0);
                if (total == 0) { Aviso("Genere primero la vista previa."); return; }

                int cambios = (m == Modo.Viajes)
                    ? _previaViajes.Count(f => f.TarifaNueva != f.TarifaActual)
                    : _previaTarifas.Count(f => f.TarifaNueva != f.TarifaActual);
                if (cambios == 0) { Aviso("Ninguna tarifa cambió respecto a la actual."); return; }

                string nombreProc = m == Modo.Base ? "tarifas BASE"
                                   : (m == Modo.Asignada ? "tarifas ASIGNADAS" : "boletas (TR_Viajes)");
                DialogResult r = MessageBox.Show(
                    "Se actualizarán " + cambios + " registro(s) de " + nombreProc +
                    " con un " + nudPorcentaje.Value.ToString("0.##") + "%." + Environment.NewLine + "¿Desea continuar?",
                    VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.Yes) return;

                string usuario = VarGlobales.Usuario ?? "";
                string detalle = ConstruirDetalle(m);
                int n;
                switch (m)
                {
                    case Modo.Base: n = _repo.AplicarTarifasBase(_previaTarifas, usuario, detalle); break;
                    case Modo.Asignada: n = _repo.AplicarTarifasAsignadas(_previaTarifas, usuario, detalle); break;
                    default: n = _repo.AplicarViajes(_previaViajes, usuario, detalle); break;
                }

                MessageBox.Show(n + " registro(s) actualizado(s) correctamente.",
                    VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPrevia_Click(sender, e); // refrescar la previa con los valores ya guardados
            }
            catch (Exception ex) { Error(ex); }
        }

        private string ConstruirDetalle(Modo m)
        {
            string s = "Proceso=" + m + "; %=" + nudPorcentaje.Value.ToString(CultureInfo.InvariantCulture);
            switch (m)
            {
                case Modo.Base:
                    s += "; TipoVeh=" + cboTvBase.Text;
                    break;
                case Modo.Asignada:
                    s += "; Cliente=" + cboClienteAsig.Text + "; TipoVeh=" + cboTvAsig.Text + "; Clase=" + cboClaseAsig.Text;
                    break;
                default:
                    s += "; Cliente=" + cboClienteViaje.Text + "; TipoVeh=" + cboTvViaje.Text + "; Clase=" + cboClaseViaje.Text +
                         "; Fechas=" + dtpDesde.Value.ToString("yyyy-MM-dd") + ".." + dtpHasta.Value.ToString("yyyy-MM-dd");
                    break;
            }
            return s;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private static void Aviso(string msg)
        {
            MessageBox.Show(msg, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void Error(Exception ex)
        {
            MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
