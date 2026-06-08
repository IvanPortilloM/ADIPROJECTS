using ADIGGM.CapaDatos;
using System;
using System.Windows.Forms;

namespace ADIGGM.HE
{
    public partial class frmCerrarPeriodo : FrmPrincipal
    {
        private readonly RepositorioAsistencias _repo = new RepositorioAsistencias();

        public frmCerrarPeriodo()
        {
            InitializeComponent();
        }

        private void btnCerrarPeriodo_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpCierreInicio.Value.Date;
            DateTime fechaFin = dtpCierreFin.Value.Date;

            if (fechaFin < fechaInicio)
            {
                MessageBox.Show("La fecha 'Hasta' no puede ser anterior a la fecha 'Desde'.", "Error de Rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- ¡ADVERTENCIA DE SEGURIDAD CRÍTICA! ---
            string advertencia = $"¿Está 100% seguro que desea cerrar todos los registros de asistencia desde el {fechaInicio.ToShortDateString()} hasta el {fechaFin.ToShortDateString()}?\n\nESTA ACCIÓN NO SE PUEDE DESHACER FÁCILMENTE Y BLOQUEARÁ LA EDICIÓN DE ESTOS REGISTROS.";

            if (MessageBox.Show(advertencia, "Confirmación Requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    // El usuario confirmó, procedemos a cerrar (solo los que no estén ya cerrados)
                    int registrosAfectados = _repo.CerrarPeriodo(fechaInicio, fechaFin);

                    MessageBox.Show($"¡Período cerrado exitosamente!\n\nSe bloquearon {registrosAfectados} registros de asistencia.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar el cierre: " + ex.Message, "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Acción cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
