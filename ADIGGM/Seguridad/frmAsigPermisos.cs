using ADIGGM.CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace ADIGGM.Seguridad
{
    public partial class frmAsigPermisos : FrmPrincipal
    {
        private readonly RepositorioPermisos _repoPermisos = new RepositorioPermisos();
        private readonly RepositorioUsuarios _repoUsuarios = new RepositorioUsuarios();
        bool selectAllOff = true;

        public frmAsigPermisos()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para que el diseñador de VS no las borre
        /// — gotcha §11. Solo "habilitado" es editable y se habilita en cargarDgv() (Columns["habilitado"].ReadOnly=false).</summary>
        private void ConfigurarColumnas()
        {
            dgvPermisosAsig.AutoGenerateColumns = false;
            dgvPermisosAsig.Columns.Clear();
            dgvPermisosAsig.Columns.Add(Clases.GridColumnas.Texto("idMenu", "IdMenu", "IdMenu", visible: false));
            dgvPermisosAsig.Columns.Add(Clases.GridColumnas.Texto("idSubMenu", "IdSubMenu", "IdSubMenu", visible: false));
            dgvPermisosAsig.Columns.Add(Clases.GridColumnas.Texto("idDetSubMenu", "IdDetSubMenu", "IdDetSubMenu", visible: false));
            dgvPermisosAsig.Columns.Add(Clases.GridColumnas.Texto("nombreMenu", "NombreMenu", "Menu Padre", autoSize: DataGridViewAutoSizeColumnMode.DisplayedCells));
            dgvPermisosAsig.Columns.Add(Clases.GridColumnas.Texto("nombreSubMenu", "NombreSubMenu", "Menu Hijo", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvPermisosAsig.Columns.Add(Clases.GridColumnas.Texto("nombreDetSubMenu", "NombreDetSubMenu", "Menu Nieto", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvPermisosAsig.Columns.Add(Clases.GridColumnas.Check("habilitado", "Habilitado", "Habilitado", autoSize: DataGridViewAutoSizeColumnMode.ColumnHeader, width: 70));
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            marcar();
        }

        private void marcar()
        {
            int rowcount = dgvPermisosAsig.Rows.Count;

            if (selectAllOff == true && rowcount > 0)
            {
                foreach (DataGridViewRow row in dgvPermisosAsig.Rows)
                {
                    row.Cells["habilitado"].Value = true;
                }
                btnImp.Image = Properties.Resources.select_all_on;
                selectAllOff = false;
            }
            else
            if (selectAllOff == false && rowcount > 0)
            {
                foreach (DataGridViewRow row in dgvPermisosAsig.Rows)
                {
                    row.Cells["habilitado"].Value = false;
                }
                btnImp.Image = Properties.Resources.select_all_off;
                selectAllOff = true;
            }
        }

        private void cargarDgv()
        {
            uspCargarPermisosBindingSource.DataMember = "";
            uspCargarPermisosBindingSource.DataSource = _repoPermisos.CargarPermisosUsuario(Convert.ToInt32(cboUsuarios.SelectedValue));
            // El DataSource se asigna aquí y NO en el Designer: si el grid queda enlazado en
            // diseño, el diseñador de VS borra las columnas al no poder resolver el esquema.
            dgvPermisosAsig.DataSource = uspCargarPermisosBindingSource;
            dgvPermisosAsig.Columns["habilitado"].ReadOnly = false;

            // El botón marcar/desmarcar-todo vuelve a su estado inicial con cada recarga
            // (antes quedaba desincronizado al cambiar de usuario).
            selectAllOff = true;
            btnImp.Image = Properties.Resources.select_all_off;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se recolecta primero (sin tocar la BD); DBNull cuenta como no habilitado
                var habilitados = new List<(int IdSubMenu, int IdDetSubMenu)>();
                foreach (DataGridViewRow row in dgvPermisosAsig.Rows)
                {
                    object valor = row.Cells["habilitado"].Value;
                    if (valor != null && valor != DBNull.Value && Convert.ToBoolean(valor))
                    {
                        habilitados.Add((Convert.ToInt32(row.Cells["idSubMenu"].Value),
                                         Convert.ToInt32(row.Cells["idDetSubMenu"].Value)));
                    }
                }

                // DELETE + inserts en UNA transacción: o se guarda todo o no cambia nada
                _repoPermisos.GuardarPermisosUsuario(Convert.ToInt32(cboUsuarios.SelectedValue), habilitados);

                MessageBox.Show("Permisos actualizados exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardaron los cambios (la operación se revirtió): " + ex.Message,
                    Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargarDgv();
        }

        private void frmAsigPermisos_Load(object sender, EventArgs e)
        {
            // Solo Id y nombre para el combo (antes se traía TR_Usuarios completo, password incluido)
            tRUsuariosBindingSource.DataMember = "";
            tRUsuariosBindingSource.DataSource = _repoUsuarios.ListarUsuariosCombo();
            cargarDgv();
            this.Dock = DockStyle.Fill;
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            cargarDgv();
        }

        private void cboUsuarios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarDgv();
        }
    }
}
