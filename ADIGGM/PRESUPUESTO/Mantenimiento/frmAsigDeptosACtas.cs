using System;
using ADIGGM.Clases;
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
    public partial class frmAsigDeptosACtas : Form
    {
        int selectedIndex;
        public frmAsigDeptosACtas()
        {
            InitializeComponent();
        }

        private void frmAsigDeptosCtas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_ctaCategoria' Puede moverla o quitarla según sea necesario.
            this.pR_ctaCategoriaTableAdapter.Fill(this.dsPresupuesto.PR_ctaCategoria);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Departamentos' Puede moverla o quitarla según sea necesario.
            this.pR_DepartamentosTableAdapter.Fill(this.dsPresupuesto.PR_Departamentos);
            CargarDgv();
            this.dgvCtasNoAsig.ClearSelection();
            this.dgvCtasAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }
        private void CargarDgv()
        {
            try
            {
                if (cboDepartamentos.SelectedIndex != -1 && cboCategoria.SelectedIndex != -1)
                {
                    this.pR_SelectDeptoCtasNoAsigTableAdapter.Fill(dsPresupuesto.PR_SelectDeptoCtasNoAsig,
                                                                    int.Parse(cboDepartamentos.SelectedValue.ToString()),
                                                                    int.Parse(cboCategoria.SelectedValue.ToString()),
                                                                    this.txtCuenta1.Text);
                    this.pR_SelectDeptoCtasAsigTableAdapter.Fill(dsPresupuesto.PR_SelectDeptoCtasAsig,
                                                                    int.Parse(cboDepartamentos.SelectedValue.ToString()),
                                                                    int.Parse(cboCategoria.SelectedValue.ToString()),
                                                                    this.txtCuenta2.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cboCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarDgv();
            this.dgvCtasNoAsig.ClearSelection();
            this.dgvCtasAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }
        private void cboDepartamentos_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarDgv();
            this.dgvCtasNoAsig.ClearSelection();
            this.dgvCtasAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }

        private void dgvCtasNoAsig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCtasNoAsig.RowCount > 0)
            {
                btnAgregar.Enabled = true;
                btnAgregarTodo.Enabled = true;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvCtasAsig.ClearSelection();
            }
            else
            {
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvCtasAsig.ClearSelection();
            }
        }

        private void dgvCtasAsig_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCtasAsig.RowCount > 0)
            {
                btnEliminar.Enabled = true;
                btnEliminarTodo.Enabled = true;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvCtasNoAsig.ClearSelection();
            }
            else
            {
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvCtasNoAsig.ClearSelection();
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCtasAsig.Rows)
            {
                VarGlobales.consultasPR.PR_SelectDeptoCtasAsigDel(int.Parse(row.Cells["idCuenta2"].Value.ToString()),
                                                                  int.Parse(cboDepartamentos.SelectedValue.ToString()));
            }
            CargarDgv();
            this.dgvCtasNoAsig.ClearSelection();
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }

        private void btnAgregarTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvCtasNoAsig.Rows)
            {
                VarGlobales.consultasPR.PR_SelectDeptoCtasAsigInsert(int.Parse(row.Cells["idCuenta"].Value.ToString()),
                                                                     int.Parse(cboDepartamentos.SelectedValue.ToString()));
            }
            CargarDgv();
            this.dgvCtasAsig.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VarGlobales.consultasPR.PR_SelectDeptoCtasAsigInsert(int.Parse(dgvCtasNoAsig.CurrentRow.Cells["idCuenta"].Value.ToString()),
                                                                 int.Parse(cboDepartamentos.SelectedValue.ToString()));

            if (dgvCtasNoAsig.Rows.Count > 0 && dgvCtasNoAsig.FirstDisplayedCell != null)
            {
                selectedIndex = dgvCtasNoAsig.CurrentRow.Index;
                CargarDgv();

                if (selectedIndex < dgvCtasNoAsig.RowCount)
                {
                    dgvCtasNoAsig.CurrentCell = dgvCtasNoAsig.Rows[selectedIndex].Cells[1];
                }
                else if (dgvCtasNoAsig.RowCount == 0)
                {
                    //dgvRutasNoAsignadas.CurrentCell = dgvRutasNoAsignadas.Rows[dgvRutasAsignadas.RowCount - 1].Cells[1];
                }
                else
                {
                    dgvCtasNoAsig.CurrentCell = dgvCtasNoAsig.Rows[dgvCtasNoAsig.RowCount - 1].Cells[1];
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            VarGlobales.consultasPR.PR_SelectDeptoCtasAsigDel(int.Parse(dgvCtasAsig.CurrentRow.Cells["idCuenta2"].Value.ToString()),
                                                              int.Parse(cboDepartamentos.SelectedValue.ToString()));

            if (dgvCtasAsig.Rows.Count > 0 && dgvCtasAsig.FirstDisplayedCell != null)
            {
                selectedIndex = dgvCtasAsig.CurrentRow.Index;
                CargarDgv();

                if (selectedIndex < dgvCtasAsig.RowCount)
                {
                    dgvCtasAsig.CurrentCell = dgvCtasAsig.Rows[selectedIndex].Cells[1];
                }
                else if (dgvCtasAsig.RowCount == 0)
                {

                }
                else
                {
                    dgvCtasAsig.CurrentCell = dgvCtasAsig.Rows[dgvCtasAsig.RowCount - 1].Cells[1];
                }
            }
            //this.dgvRutasNoAsignadas.ClearSelection();
            if (dgvCtasAsig.RowCount > 0)
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

        private void txtCuenta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboDepartamentos.SelectedIndex != -1 && cboCategoria.SelectedIndex != -1)
                this.pR_SelectDeptoCtasAsigTableAdapter.Fill(dsPresupuesto.PR_SelectDeptoCtasAsig, 
                                                           int.Parse(cboDepartamentos.SelectedValue.ToString()),
                                                           int.Parse(cboCategoria.SelectedValue.ToString()),
                                                           this.txtCuenta2.Text);

            if (dgvCtasAsig.RowCount > 0)
            {
                btnEliminar.Enabled = true;
                btnEliminarTodo.Enabled = true;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvCtasNoAsig.ClearSelection();
            }
            else
            {
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvCtasNoAsig.ClearSelection();
            }
        }

        private void txtCuenta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboDepartamentos.SelectedIndex != -1 && cboCategoria.SelectedIndex != -1)
            {
                this.pR_SelectDeptoCtasNoAsigTableAdapter.Fill(dsPresupuesto.PR_SelectDeptoCtasNoAsig,
                                                           int.Parse(cboDepartamentos.SelectedValue.ToString()),
                                                           int.Parse(cboCategoria.SelectedValue.ToString()),
                                                           this.txtCuenta1.Text);
            }
            if (dgvCtasNoAsig.RowCount > 0)
            {
                btnAgregar.Enabled = true;
                btnAgregarTodo.Enabled = true;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvCtasAsig.ClearSelection();
            }
            else
            {
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvCtasAsig.ClearSelection();
            }
        }

        private void dgvCtasNoAsig_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvCtasAsig_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
