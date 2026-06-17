using Formularios_Base;
using System;
using System.Data;
using System.Windows.Forms;
using ADIGGM.CapaDatos;

namespace ADIGGM.Seguridad
{
    public partial class frmSubMenu : FrmMantenimiento
    {
        private readonly RepositorioPermisos _repo = new RepositorioPermisos();
        private DataSet _dsMenus;
        int selectedIndex;
        public frmSubMenu()
        {
            InitializeComponent();
            ConfigurarColumnas();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvSubMenu);
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para que el diseñador de VS no las borre
        /// — gotcha §11. Grid editable de mantenimiento (edición por cascada de dgv.ReadOnly).</summary>
        private void ConfigurarColumnas()
        {
            dgvSubMenu.AutoGenerateColumns = false;
            dgvSubMenu.Columns.Clear();
            dgvSubMenu.Columns.Add(Clases.GridColumnas.Texto("idSubMenuDataGridViewTextBoxColumn", "IdSubMenu", "IdSubMenu", visible: false));
            dgvSubMenu.Columns.Add(Clases.GridColumnas.Texto("idMenuDataGridViewTextBoxColumn", "IdMenu", "IdMenu", visible: false));
            dgvSubMenu.Columns.Add(Clases.GridColumnas.Texto("nombreDataGridViewTextBoxColumn", "Nombre", "Texto", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvSubMenu.Columns.Add(Clases.GridColumnas.Texto("nombreFormularioDataGridViewTextBoxColumn", "NombreFormulario", "Formulario", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvSubMenu.Columns.Add(Clases.GridColumnas.Texto("nombreMenuDataGridViewTextBoxColumn", "NombreMenu", "Menú", autoSize: DataGridViewAutoSizeColumnMode.Fill));
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        /// <summary>Carga Menu+SubMenu con la relación FK (sustituye al DataSet tipado) y enlaza el grid.</summary>
        private void CargarDatos()
        {
            object idMenuSeleccionado = cboMenuPadre.SelectedValue;

            _dsMenus = new DataSet();
            DataTable menus = _repo.ListarMenus();
            menus.TableName = "Menu";
            DataTable subMenus = _repo.ListarSubMenus();
            subMenus.TableName = "SubMenu";
            _dsMenus.Tables.Add(menus);
            _dsMenus.Tables.Add(subMenus);
            _dsMenus.Relations.Add("FK_SubMenu_Menu",
                menus.Columns["IdMenu"], subMenus.Columns["IdMenu"], false);

            menuBindingSource.DataMember = "Menu";
            menuBindingSource.DataSource = _dsMenus;
            fKSubMenuBindingSource.DataSource = menuBindingSource;
            fKSubMenuBindingSource.DataMember = "FK_SubMenu_Menu";
            // El DataSource se asigna aquí y NO en el Designer: si el grid queda enlazado en
            // diseño, el diseñador de VS borra las columnas al no poder resolver el esquema.
            dgvSubMenu.DataSource = fKSubMenuBindingSource;

            if (idMenuSeleccionado != null)
                cboMenuPadre.SelectedValue = idMenuSeleccionado;
        }

        private void frmSubMenu_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvSubMenu.AllowUserToAddRows = true;
            dgvSubMenu.ReadOnly = false;
            dgvSubMenu.FirstDisplayedScrollingRowIndex = dgvSubMenu.RowCount - 1;
            var cantidadRow = dgvSubMenu.RowCount - 1;
            dgvSubMenu.CurrentCell = dgvSubMenu.Rows[cantidadRow].Cells[2];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSubMenu.Rows.Count > 0 && dgvSubMenu.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvSubMenu.CurrentRow.Index;
                    dgvSubMenu.EndEdit();
                    fKSubMenuBindingSource.EndEdit();
                    _repo.GuardarSubMenus(_dsMenus.Tables["SubMenu"]);
                    CargarDatos();
                    if (selectedIndex >= 0 && selectedIndex < dgvSubMenu.Rows.Count)
                        dgvSubMenu.CurrentCell = dgvSubMenu.Rows[selectedIndex].Cells[2];
                    dgvSubMenu.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvSubMenu.ReadOnly = true;
                    lblFooter.Text = "MENUS HIJOS - CANTIDAD DE REGISTROS: " + dgvSubMenu.RowCount;
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

            if (dgvSubMenu.Rows.Count > 0 && dgvSubMenu.FirstDisplayedCell != null)
            {
                saveRow = dgvSubMenu.FirstDisplayedCell.RowIndex;
                dgvSubMenu.ReadOnly = false;
                dgvSubMenu.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvSubMenu.Rows.Count)
                dgvSubMenu.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvSubMenu.Rows.Count > 0 && dgvSubMenu.FirstDisplayedCell != null)
            {
                selectedIndex = dgvSubMenu.CurrentRow.Index;

                CargarDatos();
                if (selectedIndex >= 0 && selectedIndex < dgvSubMenu.Rows.Count)
                    dgvSubMenu.CurrentCell = dgvSubMenu.Rows[selectedIndex].Cells[2];
                dgvSubMenu.AllowUserToAddRows = false;

                dgvSubMenu.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private void dgvSubMenu_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvSubMenu_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "INGRESAR ITEMS - N° DE REGISTROS: " + dgvSubMenu.RowCount;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMenuPadre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dgvSubMenu.Rows.Count > 0 && dgvSubMenu.SelectedRows.Count >= 1)
                selectedIndex = dgvSubMenu.SelectedRows[0].Index;
        }

        private void dgvSubMenu_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
