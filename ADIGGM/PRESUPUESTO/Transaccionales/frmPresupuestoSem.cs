using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADIGGM.Clases;

namespace ADIGGM.PRESUPUESTO.Transaccionales
{
    public partial class frmPresupuestoSem : Form
    {
        int selectedIndexMat, selectedIndexSem, idPresupuesto, idDepartamento; 
        Clases.VarGlobales variables = new Clases.VarGlobales();
        public frmPresupuestoSem(int idPresupuesto, int idDepartamento)
        {
            InitializeComponent();
            this.idPresupuesto = idPresupuesto;
            this.idDepartamento = idDepartamento;
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvCuentas);
        }
        private void frmPresupuestoSem_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto1.PR_ctaCategoria' Puede moverla o quitarla según sea necesario.
            this.pR_ctaCategoriaTableAdapter.FillByPresupuesto(this.dsPresupuesto1.PR_ctaCategoria, idPresupuesto);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Semanas' Puede moverla o quitarla según sea necesario.
            this.pR_SemanasTableAdapter.Fill(this.dsPresupuesto.PR_Semanas);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto1.PR_Semanas' Puede moverla o quitarla según sea necesario.
            this.pR_SemanasTableAdapter.Fill(this.dsPresupuesto.PR_Semanas);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Cuentas' Puede moverla o quitarla según sea necesario.
            //this.pR_CuentasTableAdapter.FillByPresupuesto(this.dsPresupuesto.PR_Cuentas, idPresupuesto);

            this.pR_SelectMatCuentasTableAdapter.Fill(this.dsPresupuesto.PR_SelectMatCuentas, int.Parse(dgvCuentas.CurrentRow.Cells["idCuenta"].Value.ToString()), idPresupuesto);
            dgvSemanas.Columns["cantidad3"].ReadOnly = true;
        }
        public void HabilitarBtn()
        {
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
            btnSalir.Enabled = true;
        }
        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategoria.Rows.Count > 0)
            {
                CargarCuenta(int.Parse(dgvCategoria.CurrentRow.Cells["idCtaCategoria1"].Value.ToString()));
            }
            else
            {
                CargarCuenta(0);
            }
        }
        private void dgvCuentas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCuentas.Rows.Count > 0)
            {

                CargarMateriales(int.Parse(dgvCuentas.CurrentRow.Cells["idCuenta"].Value.ToString()));
            }
            else
            {
                CargarMateriales(0);
            }
        }
        private void dgvMateriales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMateriales.Rows.Count > 0)
            {
                CargarSemanas(int.Parse(dgvMateriales.CurrentRow.Cells["idPresupuestoSem"].Value.ToString()));
            }
            else
            {
                CargarSemanas(0);
            }
        }
        public void CargarCuenta(int idCtaCategoria)
        {
            try
            {
                this.pR_CuentasTableAdapter.FillByPresupuesto(this.dsPresupuesto.PR_Cuentas, idPresupuesto, idCtaCategoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarMateriales(int idCuenta)
        {
            try
            {
                if (dgvCuentas.Rows.Count > 0)
                {
                    this.pR_SelectMatCuentasTableAdapter.Fill(this.dsPresupuesto.PR_SelectMatCuentas, idCuenta, idPresupuesto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarSemanas(int idPresupuestoSem)
        {
            try
            {
                if (dgvMateriales.Rows.Count > 0)
                {
                    this.pR_SelectMatCuentasCantTableAdapter.Fill(this.dsPresupuesto.PR_SelectMatCuentasCant, idPresupuestoSem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            selectedIndexMat = dgvMateriales.CurrentRow.Index;
            selectedIndexSem = dgvSemanas.CurrentRow.Index;

            foreach (DataGridViewRow row in dgvSemanas.Rows)
            {
                VarGlobales.consultasPR.PR_UpdateDetPresupuestoSem(Convert.ToInt32(row.Cells["idDetPresupuestoSem"].Value),
                                                                   Convert.ToInt32(row.Cells["cantidad3"].Value));
            }
            if (dgvSemanas.Columns["cantidad3"].ReadOnly == false)
            {
                //Pone todas las columnas en ReadOnly = true
                foreach (var col in dgvSemanas.Columns.Cast<DataGridViewColumn>()) col.ReadOnly = true;
                //Pone la columna "X" en ReadOnly = false, para poder editarla       
                dgvSemanas.Columns["cantidad3"].ReadOnly = true;
            }

            VarGlobales.consultasPR.PR_UpdatePresupuestoSem(int.Parse(dgvMateriales.CurrentRow.Cells["idPresupuestoSem"].Value.ToString()),
                                                           int.Parse(dgvMateriales.CurrentRow.Cells["idMaterial"].Value.ToString()));
            if (dgvCuentas.Rows.Count > 0)
            {

                CargarMateriales(int.Parse(dgvCuentas.CurrentRow.Cells["idCuenta"].Value.ToString()));
            }
            else
            {
                CargarMateriales(0);
            }

            dgvMateriales.CurrentCell = dgvMateriales.Rows[selectedIndexMat].Cells[3];
            dgvSemanas.CurrentCell = dgvSemanas.Rows[selectedIndexSem].Cells[2];

            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvSemanas.Rows.Count > 0 && dgvSemanas.FirstDisplayedCell != null)
            {
                saveRow = dgvSemanas.FirstDisplayedCell.RowIndex;
                dgvSemanas.ReadOnly = false;
                if (dgvSemanas.Columns["cantidad3"].ReadOnly == true)
                {
                    //Pone todas las columnas en ReadOnly = true
                    foreach (var col in dgvSemanas.Columns.Cast<DataGridViewColumn>()) col.ReadOnly = true;
                    //Pone la columna "X" en ReadOnly = false, para poder editarla       
                    dgvSemanas.Columns["cantidad3"].ReadOnly = false;
                }
                dgvSemanas.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvSemanas.Rows.Count)
                dgvSemanas.FirstDisplayedScrollingRowIndex = saveRow;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvCuentas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void btnSincronizarMat_Click(object sender, EventArgs e)
        {
            VarGlobales.consultasPR.PR_SincronizarMat(idPresupuesto, idDepartamento);
            this.pR_ctaCategoriaTableAdapter.FillByPresupuesto(this.dsPresupuesto1.PR_ctaCategoria, idPresupuesto);
            //if (dgvCategoria.Rows.Count > 0)
            //{
            //    CargarCuenta(int.Parse(dgvCategoria.CurrentRow.Cells["idCtaCategoria1"].Value.ToString()));
            //}
            //else
            //{
            //    CargarCuenta(0);
            //}

            //if (dgvCuentas.Rows.Count > 0)
            //{
            //    CargarMateriales(int.Parse(dgvCuentas.CurrentRow.Cells["idCuenta"].Value.ToString()));
            //}
            //else
            //{
            //    CargarMateriales(0);
            //}
        }

        private void dgvCategoria_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvMateriales_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dgvSemanas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

       
    }

}
