using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios_Base;
using ADIGGM.CapaDatos;

namespace ADIGGM.Seguridad
{
    public partial class frmDetSubMenu : FrmMantenimiento
    {
        private readonly RepositorioPermisos _repo = new RepositorioPermisos();
        private DataSet _dsMenus;
        int selectedIndex;
        public frmDetSubMenu()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvdetSubMenu);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        /// <summary>Carga Menu+SubMenu+DetSubMenu con sus relaciones FK y enlaza la cadena de combos y el grid.</summary>
        private void CargarDatos()
        {
            object idMenuSeleccionado = cboMenuPadre.SelectedValue;
            object idSubMenuSeleccionado = comboBox1.SelectedValue;

            _dsMenus = new DataSet();
            DataTable menus = _repo.ListarMenus();
            menus.TableName = "Menu";
            DataTable subMenus = _repo.ListarSubMenus();
            subMenus.TableName = "SubMenu";
            DataTable detSubMenus = _repo.ListarDetSubMenus();
            detSubMenus.TableName = "DetSubMenu";
            _dsMenus.Tables.Add(menus);
            _dsMenus.Tables.Add(subMenus);
            _dsMenus.Tables.Add(detSubMenus);
            _dsMenus.Relations.Add("FK_SubMenu_Menu",
                menus.Columns["IdMenu"], subMenus.Columns["IdMenu"], false);
            _dsMenus.Relations.Add("FK_DetSubMenu_SubMenu",
                subMenus.Columns["IdSubMenu"], detSubMenus.Columns["IdSubMenu"], false);

            menuBindingSource.DataMember = "Menu";
            menuBindingSource.DataSource = _dsMenus;
            fKSubMenuMenuBindingSource.DataSource = menuBindingSource;
            fKSubMenuMenuBindingSource.DataMember = "FK_SubMenu_Menu";
            fKDetSubMenuSubMenuBindingSource.DataSource = fKSubMenuMenuBindingSource;
            fKDetSubMenuSubMenuBindingSource.DataMember = "FK_DetSubMenu_SubMenu";
            // El DataSource se asigna aquí y NO en el Designer: si el grid queda enlazado en
            // diseño, el diseñador de VS borra las columnas al no poder resolver el esquema.
            dgvdetSubMenu.DataSource = fKDetSubMenuSubMenuBindingSource;

            if (idMenuSeleccionado != null)
                cboMenuPadre.SelectedValue = idMenuSeleccionado;
            if (idSubMenuSeleccionado != null)
                comboBox1.SelectedValue = idSubMenuSeleccionado;
        }

        private void frmDetSubMenu_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvdetSubMenu.AllowUserToAddRows = true;
            dgvdetSubMenu.ReadOnly = false;
            dgvdetSubMenu.FirstDisplayedScrollingRowIndex = dgvdetSubMenu.RowCount - 1;
            var cantidadRow = dgvdetSubMenu.RowCount - 1;
            dgvdetSubMenu.CurrentCell = dgvdetSubMenu.Rows[cantidadRow].Cells[2];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvdetSubMenu.Rows.Count > 0 && dgvdetSubMenu.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvdetSubMenu.CurrentRow.Index;
                    dgvdetSubMenu.EndEdit();
                    fKDetSubMenuSubMenuBindingSource.EndEdit();
                    _repo.GuardarDetSubMenus(_dsMenus.Tables["DetSubMenu"]);
                    CargarDatos();
                    if (selectedIndex >= 0 && selectedIndex < dgvdetSubMenu.Rows.Count)
                        dgvdetSubMenu.CurrentCell = dgvdetSubMenu.Rows[selectedIndex].Cells[2];
                    dgvdetSubMenu.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvdetSubMenu.ReadOnly = true;
                    lblFooter.Text = "MENUS HIJOS - CANTIDAD DE REGISTROS: " + dgvdetSubMenu.RowCount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvdetSubMenu.Rows.Count > 0 && dgvdetSubMenu.FirstDisplayedCell != null)
            {
                saveRow = dgvdetSubMenu.FirstDisplayedCell.RowIndex;
                dgvdetSubMenu.ReadOnly = false;
                dgvdetSubMenu.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvdetSubMenu.Rows.Count)
                dgvdetSubMenu.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvdetSubMenu.Rows.Count > 0 && dgvdetSubMenu.FirstDisplayedCell != null)
            {
                selectedIndex = dgvdetSubMenu.CurrentRow.Index;

                CargarDatos();
                if (selectedIndex >= 0 && selectedIndex < dgvdetSubMenu.Rows.Count)
                    dgvdetSubMenu.CurrentCell = dgvdetSubMenu.Rows[selectedIndex].Cells[2];
                dgvdetSubMenu.AllowUserToAddRows = false;

                dgvdetSubMenu.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMenuPadre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dgvdetSubMenu.Rows.Count > 0 && dgvdetSubMenu.SelectedRows.Count >= 1)
                selectedIndex = dgvdetSubMenu.SelectedRows[0].Index;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dgvdetSubMenu.Rows.Count > 0 && dgvdetSubMenu.SelectedRows.Count >= 1)
                selectedIndex = dgvdetSubMenu.SelectedRows[0].Index;
        }

        private void dgvdetSubMenu_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR ITEMS - N° DE REGISTROS: " + dgvdetSubMenu.RowCount;
        }

        private void dgvdetSubMenu_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
