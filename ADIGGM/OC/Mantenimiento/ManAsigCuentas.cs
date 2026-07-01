using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.Clases;
using ADIGGM.CapaDatos;

namespace ADIGGM.OC.Mantenimiento
{
    public partial class ManAsigCuentas : ADIGGM.FrmPrincipal
    {
        private readonly RepositorioOC _repo = new RepositorioOC();

        public ManAsigCuentas()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas de ambos grids EN CÓDIGO (gotcha §11). Cuenta y la columna de selección quedan
        /// editables (readOnly:false); son grids de selección/edición directa (no mantenimiento Opción A),
        /// así que no usan GridColumnas.Edicion (mismo precedente que FrmSolCred, §13.b).</summary>
        private void ConfigurarColumnas()
        {
            dgvNoAsig.AutoGenerateColumns = false;
            dgvNoAsig.Columns.Clear();
            dgvNoAsig.Columns.Add(GridColumnas.Texto("IdVehiculo", "IdVehiculo", "IdVehiculo", visible: false));
            dgvNoAsig.Columns.Add(GridColumnas.Texto("CodVehiculo", "CodVehiculo", "Codigo"));
            dgvNoAsig.Columns.Add(GridColumnas.Texto("Contratista", "Contratista", "Contratista"));
            dgvNoAsig.Columns.Add(GridColumnas.Texto("Placa", "Placa", "Placa"));
            dgvNoAsig.Columns.Add(GridColumnas.Texto("Motorista", "Motorista", "Motorista", visible: false));
            dgvNoAsig.Columns.Add(GridColumnas.Texto("Cuenta", "Cuenta", "Cuenta", readOnly: false));
            dgvNoAsig.Columns.Add(GridColumnas.Check("Seleccion", "", "", readOnly: false));
            dgvNoAsig.DataSource = vehiculosNoAsigBindingSource;

            dgvAsig.AutoGenerateColumns = false;
            dgvAsig.Columns.Clear();
            dgvAsig.Columns.Add(GridColumnas.Texto("IdVehiculo", "IdVehiculo", "IdVehiculo", visible: false));
            dgvAsig.Columns.Add(GridColumnas.Check("Seleccion", "", "", readOnly: false));
            dgvAsig.Columns.Add(GridColumnas.Texto("CodVehiculo", "CodVehiculo", "Codigo"));
            dgvAsig.Columns.Add(GridColumnas.Texto("Contratista", "Contratista", "Contratista"));
            dgvAsig.Columns.Add(GridColumnas.Texto("Placa", "Placa", "Placa"));
            dgvAsig.Columns.Add(GridColumnas.Texto("Motorista", "Motorista", "Motorista", visible: false));
            dgvAsig.Columns.Add(GridColumnas.Texto("Cuenta", "Cuenta", "Cuenta", readOnly: false));
            dgvAsig.DataSource = vehiculosAsigBindingSource;
        }

        private void ManAsigCuentas_Load(object sender, EventArgs e)
        {
            oCProductosCategoriasBindingSource.DataSource = _repo.ListarCategoriasProductosOCActivas();
            CargarGrids();
        }

        private void CargarAsig()
        {
            if (cboCategoria.SelectedValue == null) return;
            vehiculosAsigBindingSource.DataSource = _repo.ListarVehiculosAsignados(int.Parse(cboCategoria.SelectedValue.ToString()), txtBusqueda2.Text);
        }

        private void CargarNoAsig()
        {
            if (cboCategoria.SelectedValue == null) return;
            vehiculosNoAsigBindingSource.DataSource = _repo.ListarVehiculosNoAsignados(txtBusqueda1.Text, int.Parse(cboCategoria.SelectedValue.ToString()));
        }

        private void CargarGrids()
        {
            CargarAsig();
            CargarNoAsig();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cboCategoria.SelectedIndex.ToString()) != -1)
            {
                CargarGrids();
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
                    int idCategoria = int.Parse(cboCategoria.SelectedValue.ToString());
                    foreach (DataGridViewRow row in dgvNoAsig.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[6].Value) == true)
                        {
                            _repo.GuardarAsigCuentaOpcion(idCategoria, int.Parse(row.Cells[0].Value.ToString()), row.Cells[5].Value.ToString(), VarGlobales.Usuario, Environment.MachineName, 1);
                        }
                    }
                    CargarGrids();
                }
                else
                {
                    MessageBox.Show("Existen cuentas de gastos vacias, ingrese todas las cuentas seleccionadas para continuar", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria = int.Parse(cboCategoria.SelectedValue.ToString());
                foreach (DataGridViewRow row in dgvAsig.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[1].Value) == true)
                    {
                        _repo.GuardarAsigCuentaOpcion(idCategoria, int.Parse(row.Cells[0].Value.ToString()), row.Cells[6].Value.ToString(), VarGlobales.Usuario, Environment.MachineName, 3);
                    }
                }
                CargarGrids();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAsig_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvAsig.CurrentRow != null)
                {
                    int idCategoria = int.Parse(cboCategoria.SelectedValue.ToString());
                    _repo.GuardarAsigCuentaOpcion(idCategoria, int.Parse(dgvAsig.CurrentRow.Cells[0].Value.ToString()), dgvAsig.CurrentRow.Cells[6].Value.ToString(), VarGlobales.Usuario, Environment.MachineName, 2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusqueda1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarNoAsig();
            }
        }

        private void txtBusqueda2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarAsig();
            }
        }
    }
}
