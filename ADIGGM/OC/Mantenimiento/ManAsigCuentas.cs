using System;
using System.Windows.Forms;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManAsigCuentas : ADIGGM.FrmPrincipal
    {
        public ManAsigCuentas()
        {
            InitializeComponent();
        }

        private void ManAsigCuentas_Load(object sender, EventArgs e)
        {
            this.oC_ProductosCategoriasTableAdapter.FillByActivos(this.dsOC.OC_ProductosCategorias);

            this.vehiculosAsigTableAdapter.Fill(this.dsOC.VehiculosAsig, int.Parse(cboCategoria.SelectedValue.ToString()), txtBusqueda2.Text);

            this.vehiculosNoAsigTableAdapter.Fill(this.dsOC.VehiculosNoAsig, txtBusqueda1.Text, int.Parse(cboCategoria.SelectedValue.ToString()));
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cboCategoria.SelectedIndex.ToString()) != -1)
            {
                this.vehiculosAsigTableAdapter.Fill(this.dsOC.VehiculosAsig, int.Parse(cboCategoria.SelectedValue.ToString()), txtBusqueda2.Text);

                this.vehiculosNoAsigTableAdapter.Fill(this.dsOC.VehiculosNoAsig, txtBusqueda1.Text, int.Parse(cboCategoria.SelectedValue.ToString()));
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int contador = 0;
                foreach (DataGridViewRow row in dgvNoAsig.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[6].Value) == true && String.IsNullOrEmpty(row.Cells[5].Value.ToString()))
                    {
                        contador += 1;
                    }
                }

                if (contador == 0)
                {
                    foreach (DataGridViewRow row in dgvNoAsig.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[6].Value) == true)
                        {
                            Clases.VarGlobales.consultasOC.OC_AsigCuentasOpciones(int.Parse(cboCategoria.SelectedValue.ToString()), int.Parse(row.Cells[0].Value.ToString()), (row.Cells[5].Value.ToString()), Clases.VarGlobales.Usuario, System.Environment.MachineName, 1);
                        }
                    }
                    this.vehiculosAsigTableAdapter.Fill(this.dsOC.VehiculosAsig, int.Parse(cboCategoria.SelectedValue.ToString()), txtBusqueda2.Text);

                    this.vehiculosNoAsigTableAdapter.Fill(this.dsOC.VehiculosNoAsig, txtBusqueda1.Text, int.Parse(cboCategoria.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("Existen cuentas de gastos vacias, ingrese todas las cuentas seleccionadas para continuar", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvAsig.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[1].Value) == true)
                    {
                        Clases.VarGlobales.consultasOC.OC_AsigCuentasOpciones(int.Parse(cboCategoria.SelectedValue.ToString()), int.Parse(row.Cells[0].Value.ToString()), (row.Cells[6].Value.ToString()), Clases.VarGlobales.Usuario, System.Environment.MachineName, 3);
                    }
                }
                this.vehiculosAsigTableAdapter.Fill(this.dsOC.VehiculosAsig, int.Parse(cboCategoria.SelectedValue.ToString()), txtBusqueda2.Text);

                this.vehiculosNoAsigTableAdapter.Fill(this.dsOC.VehiculosNoAsig, txtBusqueda1.Text, int.Parse(cboCategoria.SelectedValue.ToString()));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAsig_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAsig.CurrentRow != null)
                {
                    Clases.VarGlobales.consultasOC.OC_AsigCuentasOpciones(int.Parse(cboCategoria.SelectedValue.ToString()), int.Parse(dgvAsig.CurrentRow.Cells[0].Value.ToString()), (dgvAsig.CurrentRow.Cells[6].Value.ToString()), Clases.VarGlobales.Usuario, System.Environment.MachineName, 2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusqueda1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.vehiculosNoAsigTableAdapter.Fill(this.dsOC.VehiculosNoAsig, txtBusqueda1.Text, int.Parse(cboCategoria.SelectedValue.ToString()));
            }
        }

        private void txtBusqueda2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.vehiculosAsigTableAdapter.Fill(this.dsOC.VehiculosAsig, int.Parse(cboCategoria.SelectedValue.ToString()), txtBusqueda2.Text);
            }
        }
    }
}
