using ADIGGM.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.PRESUPUESTO.Mantenimiento
{
    public partial class frmAsigDeptosAUsu : Form
    {
        int selectedIndex;
        public frmAsigDeptosAUsu()
        {
            InitializeComponent();
        }

        private void frmAsigDeptosAUsu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Usuarios' Puede moverla o quitarla según sea necesario.
            this.tR_UsuariosTableAdapter.Fill(this.dsTransporteAdiggm.TR_Usuarios);
            CargarDgv();
            this.dgvDeptosNoAsig.ClearSelection();
            this.dgvDeptosAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }
        private void CargarDgv()
        {
            try
            {
                if (cboUsuarios.SelectedIndex != -1)
                {
                    this.pR_SelectDeptoUsuNoAsigTableAdapter.Fill(dsPresupuesto.PR_SelectDeptoUsuNoAsig,
                                                                    int.Parse(cboUsuarios.SelectedValue.ToString()));
                    this.pR_SelectDeptoUsuAsigTableAdapter.Fill(dsPresupuesto.PR_SelectDeptoUsuAsig,
                                                                    int.Parse(cboUsuarios.SelectedValue.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboUsuarios_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarDgv();
            this.dgvDeptosNoAsig.ClearSelection();
            this.dgvDeptosAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }

        private void dgvDeptosAsig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDeptosAsig.RowCount > 0)
            {
                btnEliminar.Enabled = true;
                btnEliminarTodo.Enabled = true;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvDeptosNoAsig.ClearSelection();
            }
            else
            {
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvDeptosNoAsig.ClearSelection();
            }
        }

        private void dgvDeptosNoAsig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDeptosNoAsig.RowCount > 0)
            {
                btnAgregar.Enabled = true;
                btnAgregarTodo.Enabled = true;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvDeptosAsig.ClearSelection();
            }
            else
            {
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvDeptosAsig.ClearSelection();
            }
        }
        private void btnAgregarTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDeptosNoAsig.Rows)
            {
                VarGlobales.consultasPR.PR_SelectDeptoUsuAsigInsert(int.Parse(cboUsuarios.SelectedValue.ToString()),
                                                                    int.Parse(row.Cells["idDepartamento"].Value.ToString()));
            }
            CargarDgv();
            this.dgvDeptosAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
        }
        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDeptosAsig.Rows)
            {
                VarGlobales.consultasPR.PR_SelectDeptoUsuAsigDel(int.Parse(cboUsuarios.SelectedValue.ToString()),
                                                                              int.Parse(row.Cells["idDepartamento2"].Value.ToString()));
            }
            CargarDgv();
            this.dgvDeptosNoAsig.ClearSelection();
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VarGlobales.consultasPR.PR_SelectDeptoUsuAsigInsert(int.Parse(cboUsuarios.SelectedValue.ToString()),
                                                                             int.Parse(dgvDeptosNoAsig.CurrentRow.Cells["idDepartamento"].Value.ToString()));

            if (dgvDeptosNoAsig.Rows.Count > 0 && dgvDeptosNoAsig.FirstDisplayedCell != null)
            {
                selectedIndex = dgvDeptosNoAsig.CurrentRow.Index;
                CargarDgv();

                if (selectedIndex < dgvDeptosNoAsig.RowCount)
                {
                    dgvDeptosNoAsig.CurrentCell = dgvDeptosNoAsig.Rows[selectedIndex].Cells[1];
                }
                else if (dgvDeptosNoAsig.RowCount == 0)
                {
                    //dgvRutasNoAsignadas.CurrentCell = dgvRutasNoAsignadas.Rows[dgvRutasAsignadas.RowCount - 1].Cells[1];
                }
                else
                {
                    dgvDeptosNoAsig.CurrentCell = dgvDeptosNoAsig.Rows[dgvDeptosNoAsig.RowCount - 1].Cells[1];
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            VarGlobales.consultasPR.PR_SelectDeptoUsuAsigDel(int.Parse(cboUsuarios.SelectedValue.ToString()),
                                                                            int.Parse(dgvDeptosAsig.CurrentRow.Cells["idDepartamento2"].Value.ToString()));

            if (dgvDeptosAsig.Rows.Count > 0 && dgvDeptosAsig.FirstDisplayedCell != null)
            {
                selectedIndex = dgvDeptosAsig.CurrentRow.Index;
                CargarDgv();

                if (selectedIndex < dgvDeptosAsig.RowCount)
                {
                    dgvDeptosAsig.CurrentCell = dgvDeptosAsig.Rows[selectedIndex].Cells[1];
                }
                else if (dgvDeptosAsig.RowCount == 0)
                {
                    //dgvRutasAsignadas.CurrentCell = dgvRutasAsignadas.Rows[dgvRutasAsignadas.RowCount - 1].Cells[1];
                }
                else
                {
                    dgvDeptosAsig.CurrentCell = dgvDeptosAsig.Rows[dgvDeptosAsig.RowCount - 1].Cells[1];
                }
            }
            //this.dgvRutasNoAsignadas.ClearSelection();
            if (dgvDeptosAsig.RowCount > 0)
            {
                btnEliminar.Enabled = true;
                btnEliminarTodo.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
            }
        }

        private void dgvDeptosNoAsig_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvDeptosAsig_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
