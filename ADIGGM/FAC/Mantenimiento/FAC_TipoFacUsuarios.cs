using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.CapaDatos;

namespace ADIGGM.FAC.Mantenimiento
{
    public partial class FAC_TipoFacUsuarios : ADIGGM.FrmPrincipal
    {
        private readonly RepositorioFAC _repo = new RepositorioFAC();

        public FAC_TipoFacUsuarios()
        {
            InitializeComponent();
        }

        private void FAC_TipoFacUsuarios_Load(object sender, EventArgs e)
        {
            fACTipoFacturasBindingSource.DataMember = "";
            fACTipoFacturasBindingSource.DataSource = _repo.ListarTiposFactura();
            cboTipoFactura.DataSource = fACTipoFacturasBindingSource;
        }

        private int IdTipoFacSeleccionado()
        {
            return int.Parse(cboTipoFactura.SelectedValue.ToString());
        }

        private void CargarNoAsignados()
        {
            fACTipoFacUsuarioNoAsigBindingSource.DataMember = "";
            fACTipoFacUsuarioNoAsigBindingSource.DataSource = _repo.ListarUsuariosNoAsignados(txtBusqueda1.Text, IdTipoFacSeleccionado());
            dgvNoAsig.DataSource = fACTipoFacUsuarioNoAsigBindingSource;
        }

        private void CargarAsignados()
        {
            fACTipoFacUsuarioAsigBindingSource.DataMember = "";
            fACTipoFacUsuarioAsigBindingSource.DataSource = _repo.ListarUsuariosAsignados(txtBusqueda2.Text, IdTipoFacSeleccionado());
            dgvAsig.DataSource = fACTipoFacUsuarioAsigBindingSource;
        }

        private void txtBusqueda1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarNoAsignados();
            }
        }

        private void txtBusqueda2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CargarAsignados();
            }
        }

        private void cboTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTipoFactura_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTipoFactura.SelectedIndex != -1)
            {
                CargarNoAsignados();
                CargarAsignados();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvNoAsig.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        _repo.GuardarAsignacionUsuario(int.Parse(row.Cells[0].Value.ToString()), IdTipoFacSeleccionado(), 1);
                    }
                }
                CargarNoAsignados();
                CargarAsignados();
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
                        _repo.GuardarAsignacionUsuario(int.Parse(row.Cells[0].Value.ToString()), IdTipoFacSeleccionado(), 2);
                    }
                }
                CargarNoAsignados();
                CargarAsignados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
