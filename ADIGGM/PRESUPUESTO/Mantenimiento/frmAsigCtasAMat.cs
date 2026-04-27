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
    public partial class frmAsigCtasAMat : Form
    {
        int selectedIndex;
        public frmAsigCtasAMat()
        {
            InitializeComponent();
        }

        private void frmAsigCtasAMat_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Departamentos' Puede moverla o quitarla según sea necesario.
            this.pR_DepartamentosTableAdapter.FillByUsuario(this.dsPresupuesto.PR_Departamentos, VarGlobales.IdUsuario);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_ctaCategoria' Puede moverla o quitarla según sea necesario.
            this.pR_ctaCategoriaTableAdapter.Fill(this.dsPresupuesto.PR_ctaCategoria);
            this.pR_CuentasTableAdapter.Fill(this.dsPresupuesto.PR_Cuentas);

            if (cboDepartamento.SelectedIndex != -1)
            {
                this.pR_ctaCategoriaTableAdapter.FillByDepartamento(this.dsPresupuesto.PR_ctaCategoria, Convert.ToInt32(cboDepartamento.SelectedValue.ToString()));
                this.pR_CuentasTableAdapter.FillByDepartamento(this.dsPresupuesto.PR_Cuentas, Convert.ToInt32(cboDepartamento.SelectedValue.ToString()));
            }
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Cuentas' Puede moverla o quitarla según sea necesario.
           
            CargarDgv();
            this.dgvMatNoAsig.ClearSelection();
            this.dgvMatAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }
        private void CargarDgv()
        {
            try
            {
                if (cboDepartamento.SelectedIndex != -1 && cboCategoria.SelectedIndex != -1  && cboCuenta.SelectedIndex != -1)
                {
                    this.pR_SelectCtasMatNoAsigTableAdapter.Fill(dsPresupuesto.PR_SelectCtasMatNoAsig,
                                                                    int.Parse(cboCuenta.SelectedValue.ToString()),
                                                                    int.Parse(cboDepartamento.SelectedValue.ToString()),
                                                                    this.txtMaterial1.Text);
                    this.pR_SelectCtasMatAsigTableAdapter.Fill(dsPresupuesto.PR_SelectCtasMatAsig,
                                                                    int.Parse(cboCuenta.SelectedValue.ToString()),
                                                                    int.Parse(cboDepartamento.SelectedValue.ToString()),
                                                                    this.txtMaterial2.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedIndex != -1)
            {
                this.pR_ctaCategoriaTableAdapter.FillByDepartamento(this.dsPresupuesto.PR_ctaCategoria, Convert.ToInt32(cboDepartamento.SelectedValue.ToString()));
            }

            CargarDgv();
            this.dgvMatNoAsig.ClearSelection();
            this.dgvMatAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }
        private void cboCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCategoria.SelectedIndex != -1 && cboDepartamento.SelectedIndex != -1)
            {
                this.pR_CuentasTableAdapter.FillByDepartamento(this.dsPresupuesto.PR_Cuentas, Convert.ToInt32(cboDepartamento.SelectedValue.ToString()));
            }

            CargarDgv();
            this.dgvMatNoAsig.ClearSelection();
            this.dgvMatAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }
        private void cboCuenta_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarDgv();
            this.dgvMatNoAsig.ClearSelection();
            this.dgvMatAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }

        private void dgvMatNoAsig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMatNoAsig.RowCount > 0)
            {
                btnAgregar.Enabled = true;
                btnAgregarTodo.Enabled = true;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvMatAsig.ClearSelection();
            }
            else
            {
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvMatAsig.ClearSelection();
            }
        }

        private void dgvMatAsig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMatAsig.RowCount > 0)
            {
                btnEliminar.Enabled = true;
                btnEliminarTodo.Enabled = true;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvMatNoAsig.ClearSelection();
            }
            else
            {
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvMatNoAsig.ClearSelection();
            }
        }

        private void txtMaterial1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.pR_SelectCtasMatNoAsigTableAdapter.Fill(dsPresupuesto.PR_SelectCtasMatNoAsig,
                                                            int.Parse(cboCuenta.SelectedValue.ToString()),
                                                            int.Parse(cboDepartamento.SelectedValue.ToString()),
                                                            this.txtMaterial1.Text);
            if (dgvMatNoAsig.RowCount > 0)
            {
                btnAgregar.Enabled = true;
                btnAgregarTodo.Enabled = true;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvMatAsig.ClearSelection();
            }
            else
            {
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvMatAsig.ClearSelection();
            }
        }

        private void txtMaterial2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.pR_SelectCtasMatAsigTableAdapter.Fill(dsPresupuesto.PR_SelectCtasMatAsig,
                                                           int.Parse(cboCuenta.SelectedValue.ToString()),
                                                           int.Parse(cboDepartamento.SelectedValue.ToString()),
                                                           this.txtMaterial2.Text);
            if (dgvMatAsig.RowCount > 0)
            {
                btnEliminar.Enabled = true;
                btnEliminarTodo.Enabled = true;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvMatNoAsig.ClearSelection();
            }
            else
            {
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvMatNoAsig.ClearSelection();
            }
        }
        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMatAsig.Rows)
            {
                VarGlobales.consultasPR.PR_SelectCtasMatAsigDel(int.Parse(cboCuenta.SelectedValue.ToString()),
                                                                int.Parse(cboDepartamento.SelectedValue.ToString()),
                                                                int.Parse(row.Cells["idMaterial2"].Value.ToString()));
            }
            CargarDgv();
            this.dgvMatNoAsig.ClearSelection();
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clases.VarGlobales.consultasPR.PR_SelectCtasMatAsigInsert(int.Parse(cboCuenta.SelectedValue.ToString()),
                                                                      int.Parse(cboDepartamento.SelectedValue.ToString()),
                                                                      int.Parse(dgvMatNoAsig.CurrentRow.Cells["idMaterial"].Value.ToString()));

            if (dgvMatNoAsig.Rows.Count > 0 && dgvMatNoAsig.FirstDisplayedCell != null)
            {
                selectedIndex = dgvMatNoAsig.CurrentRow.Index;
                CargarDgv();

                if (selectedIndex < dgvMatNoAsig.RowCount)
                {
                    dgvMatNoAsig.CurrentCell = dgvMatNoAsig.Rows[selectedIndex].Cells[1];
                }
                else if (dgvMatNoAsig.RowCount == 0)
                {
                    //dgvRutasNoAsignadas.CurrentCell = dgvRutasNoAsignadas.Rows[dgvRutasAsignadas.RowCount - 1].Cells[1];
                }
                else
                {
                    dgvMatNoAsig.CurrentCell = dgvMatNoAsig.Rows[dgvMatNoAsig.RowCount - 1].Cells[1];
                }
            }
            if (dgvMatNoAsig.RowCount > 0)
            {
                btnAgregar.Enabled = true;
                btnAgregarTodo.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.VarGlobales.consultasPR.PR_SelectCtasMatAsigDel(int.Parse(cboCuenta.SelectedValue.ToString()),
                                                                   int.Parse(cboDepartamento.SelectedValue.ToString()),
                                                                   int.Parse(dgvMatAsig.CurrentRow.Cells["idMaterial2"].Value.ToString()));

            if (dgvMatAsig.Rows.Count > 0 && dgvMatAsig.FirstDisplayedCell != null)
            {
                selectedIndex = dgvMatAsig.CurrentRow.Index;
                CargarDgv();

                if (selectedIndex < dgvMatAsig.RowCount)
                {
                    dgvMatAsig.CurrentCell = dgvMatAsig.Rows[selectedIndex].Cells[1];
                }
                else if (dgvMatAsig.RowCount == 0)
                {
                    //dgvRutasAsignadas.CurrentCell = dgvRutasAsignadas.Rows[dgvRutasAsignadas.RowCount - 1].Cells[1];
                }
                else
                {
                    dgvMatAsig.CurrentCell = dgvMatAsig.Rows[dgvMatAsig.RowCount - 1].Cells[1];
                }
            }
            //this.dgvRutasNoAsignadas.ClearSelection();
            if (dgvMatAsig.RowCount > 0)
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

        private void btnAgregarTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvMatNoAsig.Rows)
            {
                VarGlobales.consultasPR.PR_SelectCtasMatAsigInsert(int.Parse(cboCuenta.SelectedValue.ToString()),
                                                                   int.Parse(cboDepartamento.SelectedValue.ToString()),
                                                                   int.Parse(row.Cells["idMaterial"].Value.ToString()));
            }
            CargarDgv();
            this.dgvMatAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
        }

        private void dgvMatNoAsig_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvMatAsig_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
