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
    public partial class frmEmpleados : Form
    {
        int selectedIndex;
        Clases.VarGlobales variables = new Clases.VarGlobales();
        public frmEmpleados()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvEmpleados);
        }
        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void dgvEmpleados_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Departamentos' Puede moverla o quitarla según sea necesario.
            this.pR_DepartamentosTableAdapter.Fill(this.dsPresupuesto.PR_Departamentos);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Genero' Puede moverla o quitarla según sea necesario.
            this.pR_GeneroTableAdapter.Fill(this.dsPresupuesto.PR_Genero);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_tipoContratos' Puede moverla o quitarla según sea necesario.
            this.pR_tipoContratosTableAdapter.Fill(this.dsPresupuesto.PR_tipoContratos);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Cargos' Puede moverla o quitarla según sea necesario.
            this.pR_CargosTableAdapter.Fill(this.dsPresupuesto.PR_Cargos);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Empleados' Puede moverla o quitarla según sea necesario.
            this.pR_EmpleadosTableAdapter.FillByNombre(this.dsPresupuesto.PR_Empleados,txtBuscar.Text);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_tipoContratos' Puede moverla o quitarla según sea necesario.
            
            this.pR_tipoContratosTableAdapter.Fill(this.dsPresupuesto.PR_tipoContratos);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Cargos' Puede moverla o quitarla según sea necesario.
            this.pR_CargosTableAdapter.Fill(this.dsPresupuesto.PR_Cargos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvEmpleados.AllowUserToAddRows = true;
            dgvEmpleados.ReadOnly = false;
            dgvEmpleados.FirstDisplayedScrollingRowIndex = dgvEmpleados.RowCount - 1;
            var cantidadRow = dgvEmpleados.RowCount - 1;
            dgvEmpleados.CurrentCell = dgvEmpleados.Rows[cantidadRow].Cells[1];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.Rows.Count > 0 && dgvEmpleados.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvEmpleados.CurrentRow.Index;
                    dgvEmpleados.EndEdit();
                    this.pR_EmpleadosTableAdapter.Update(this.dsPresupuesto.PR_Empleados);
                    dgvEmpleados.CurrentCell = dgvEmpleados.Rows[selectedIndex].Cells[1];
                    dgvEmpleados.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvEmpleados.ReadOnly = true;
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

            if (dgvEmpleados.Rows.Count > 0 && dgvEmpleados.FirstDisplayedCell != null)
            {
                saveRow = dgvEmpleados.FirstDisplayedCell.RowIndex;
                dgvEmpleados.ReadOnly = false;
                dgvEmpleados.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvEmpleados.Rows.Count)
                dgvEmpleados.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count > 0 && dgvEmpleados.FirstDisplayedCell != null)
            {
                selectedIndex = dgvEmpleados.CurrentRow.Index;

                this.pR_EmpleadosTableAdapter.Fill(this.dsPresupuesto.PR_Empleados);
                dgvEmpleados.CurrentCell = dgvEmpleados.Rows[selectedIndex].Cells[1];
                dgvEmpleados.AllowUserToAddRows = false;

                dgvEmpleados.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private void cboDepartamentos_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cboDepartamentos.SelectedIndex != -1)
            {
                this.pR_EmpleadosTableAdapter.FillByNombre(dsPresupuesto.PR_Empleados, this.txtBuscar.Text);
            }
        }
    }
}
