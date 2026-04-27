using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ADIGGM.Clases;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.PRESUPUESTO.Transaccionales
{ 
    public partial class frmSueldosSalarios : Form
    {
        int selectedIndex, idPresupuesto, IdDepartamento;
        int existe;
        public frmSueldosSalarios(int idPresupuesto, int IdDepartamento)
        {
            InitializeComponent();
            this.idPresupuesto = idPresupuesto;
            this.IdDepartamento = IdDepartamento;
            existe = Convert.ToInt32(VarGlobales.consultasPR.PR_SSdetSueldosExiste(idPresupuesto));
        }

        private void CargarSueldo(int idEmpleado,decimal sueldoDiario,DateTime fechaIngreso,string idTipoContrato)
        {
            if (dgvEmpleados.RowCount > 0)
            {
                //var fecIngreso = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells["fechaIngreso"].Value).ToString("yyyy-dd-MM");

                this.pR_SSCalculosTableAdapter.Fill(this.dsPresupuesto.PR_SSCalculos, idPresupuesto, idEmpleado,sueldoDiario,fechaIngreso,idTipoContrato);
            }
        }

        private void frmSueldosSalarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Departamentos' Puede moverla o quitarla según sea necesario.
            this.pR_DepartamentosTableAdapter.Fill(this.dsPresupuesto.PR_Departamentos);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_tipoContratos' Puede moverla o quitarla según sea necesario.
            this.pR_tipoContratosTableAdapter.Fill(this.dsPresupuesto.PR_tipoContratos);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_ssConcepto' Puede moverla o quitarla según sea necesario.
            this.pR_ssConceptoTableAdapter.Fill(this.dsPresupuesto.PR_ssConcepto);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_ssPorcentajeMeses' Puede moverla o quitarla según sea necesario.
            this.pR_ssPorcentajeMesesTableAdapter.FillByPresupuesto(this.dsPresupuesto.PR_ssPorcentajeMeses, idPresupuesto);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Genero' Puede moverla o quitarla según sea necesario.
            this.pR_GeneroTableAdapter.Fill(this.dsPresupuesto.PR_Genero);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Cargos' Puede moverla o quitarla según sea necesario.
            this.pR_CargosTableAdapter.Fill(this.dsPresupuesto.PR_Cargos);

            if (existe == 0)
            {
                dgvEmpleados.Visible = true;
                dgvEmpleados.Dock = DockStyle.Fill;
                dgvEmpGuardado.Visible = false;
                dgvEmpleados.ReadOnly = true;
                btnVerPrestaciones.Enabled = false;
            }
            else
            {
                dgvEmpGuardado.Visible = true;
                dgvEmpGuardado.Dock = DockStyle.Fill;
                dgvEmpleados.Visible = false;
                //dgvEmpGuardado.ReadOnly = true;
                CargarEmpleadosGuardados();
                CargarSueldo(Convert.ToInt32(dgvEmpGuardado.CurrentRow.Cells["idEmpleado2"].Value.ToString()),
                                               Convert.ToDecimal(dgvEmpGuardado.CurrentRow.Cells["sueldoDiario2"].Value.ToString()),
                                               Convert.ToDateTime(dgvEmpGuardado.CurrentRow.Cells["fechaIngreso2"].Value),
                                               dgvEmpGuardado.CurrentRow.Cells["idTipoContrato2"].FormattedValue.ToString());

                btnCargarEmpleados.Enabled = false;
                btnVerPrestaciones.Enabled = true;
            }
            dgvEmpGuardado.Columns["sueldoBase2"].ReadOnly = true;
            btnCancelarPorc.Enabled = false;
            btnGuardarPorc.Enabled = false;
            btnGuardarEmp.Enabled = false;
            btnCancelar.Enabled = false;

            foreach (DataGridViewColumn c in dgvEmpGuardado.Columns)
                if (c.Name != "sueldoDiario2") c.ReadOnly = true;
        }
        private void dgvEmpleados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex].Name == "codigo" ||
                dgv.Columns[e.ColumnIndex].Name == "nombre" ||
                dgv.Columns[e.ColumnIndex].Name == "idDepartamento2" ||
                dgv.Columns[e.ColumnIndex].Name == "idCargo" ||
                dgv.Columns[e.ColumnIndex].Name == "idGenero" ||
                dgv.Columns[e.ColumnIndex].Name == "sueldoBase")
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
        }
        private void dgvEmpGuardado_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex].Name == "codigo2" || 
                dgv.Columns[e.ColumnIndex].Name == "nombre2" ||
                dgv.Columns[e.ColumnIndex].Name == "idDepartamento3" ||
                dgv.Columns[e.ColumnIndex].Name == "idCargo2" ||
                dgv.Columns[e.ColumnIndex].Name == "idGenero2" ||
                dgv.Columns[e.ColumnIndex].Name == "sueldoBase2") 
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
        }
       
        private void CargarEmpleados()
        {
            this.pR_SelectEmpleadosTableAdapter.Fill(this.dsPresupuesto.PR_SelectEmpleados, IdDepartamento);
            btnCargarEmpleados.Enabled = false;
        }

        private void CargarEmpleadosGuardados()
        {
            this.pR_SelectEmpleadosTableAdapter.FillByPresupuesto(this.dsPresupuesto.PR_SelectEmpleados, idPresupuesto);
            btnCargarEmpleados.Enabled = false;
        }

        private void dgvPorcentaje_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPorcentaje.IsCurrentCellDirty)
            {
                dgvPorcentaje.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnCargarEmpleados_Click(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btnVerParametros_Click(object sender, EventArgs e)
        {
            Mantenimiento.frmSS_Parametros verParametro = new Mantenimiento.frmSS_Parametros(idPresupuesto);
            verParametro.ShowDialog(this);
        }

        private void btnVerPrestaciones_Click(object sender, EventArgs e)
        {
            frmPrestaciones verPrestaciones = new frmPrestaciones(idPresupuesto,existe);
            verPrestaciones.ShowDialog(this);
        }

        private void btnGuardarPorc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPorcentaje.Rows.Count > 0 && dgvPorcentaje.FirstDisplayedCell != null)
                {                    
                        selectedIndex = dgvPorcentaje.CurrentRow.Index;
                        dgvPorcentaje.EndEdit();
                        this.pR_ssPorcentajeMesesTableAdapter.Update(this.dsPresupuesto.PR_ssPorcentajeMeses);
                        dgvPorcentaje.CurrentCell = dgvPorcentaje.Rows[selectedIndex].Cells[1];
                        dgvPorcentaje.AllowUserToAddRows = false;

                        btnGuardarPorc.Enabled = false;
                        btnEditarPorc.Enabled = true;
                        btnCancelarPorc.Enabled = false;
                        dgvPorcentaje.ReadOnly = true;

                        CargarSueldo(Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["idEmpleado"].Value.ToString()),
                                                   Convert.ToDecimal(dgvEmpleados.CurrentRow.Cells["sueldoDiario"].Value.ToString()),
                                                   Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells["fechaIngreso"].Value),
                                                   dgvEmpleados.CurrentRow.Cells["idTipoContrato"].FormattedValue.ToString());
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvEmpGuardado.Columns["sueldoDiario2"].ReadOnly == true)
            {
                //Pone todas las columnas en ReadOnly = true
                foreach (var col in dgvEmpGuardado.Columns.Cast<DataGridViewColumn>()) col.ReadOnly = true;
                //Pone la columna "X" en ReadOnly = false, para poder editarla
                dgvEmpGuardado.Columns["sueldoDiario2"].ReadOnly = false;
                dgvEmpGuardado.Columns["idTipoContrato2"].ReadOnly = false;
                //dgvEmpGuardado.Columns["ctaContable"].ReadOnly = false;
                //dgvEmpGuardado.Columns["descripcion"].ReadOnly = false;
                //dgvEmpGuardado.Columns["debe"].ReadOnly = false;
                //dgvEmpGuardado.Columns["haber"].ReadOnly = false;
                //dgvEmpGuardado.Columns["Aprobar"].ReadOnly = false;
            }
            else
            if (existe == 0)
            {
                if (dgvEmpleados.Rows.Count > 0 && dgvEmpleados.FirstDisplayedCell != null)
                {
                    saveRow = dgvEmpleados.FirstDisplayedCell.RowIndex;
                    dgvEmpleados.ReadOnly = false;
                    dgvEmpleados.AllowUserToAddRows = false;

                    btnGuardarEmp.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                }

                if (saveRow != 0 && saveRow < dgvEmpleados.Rows.Count)
                    dgvEmpleados.FirstDisplayedScrollingRowIndex = saveRow;
            }
            else
            {
                if (dgvEmpGuardado.Rows.Count > 0 && dgvEmpGuardado.FirstDisplayedCell != null)
                {
                    saveRow = dgvEmpGuardado.FirstDisplayedCell.RowIndex;
                    dgvEmpGuardado.ReadOnly = false;
                    dgvEmpGuardado.AllowUserToAddRows = false;

                    btnGuardarEmp.Enabled = true;
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                }

                if (saveRow != 0 && saveRow < dgvEmpGuardado.Rows.Count)
                    dgvEmpGuardado.FirstDisplayedScrollingRowIndex = saveRow;

                //if (dgvEmpGuardado.Columns["sueldoDiario2"].ReadOnly == false)
                //{
                //    //Pone todas las columnas en ReadOnly = true
                //    foreach (var col in dgvEmpGuardado.Columns.Cast<DataGridViewColumn>()) col.ReadOnly = false;
                //    //Pone la columna "X" en ReadOnly = false, para poder editarla          
                //    dgvEmpGuardado.Columns["codigo2"].ReadOnly = true;
                //    dgvEmpGuardado.Columns["nombre2"].ReadOnly = true;
                //    dgvEmpGuardado.Columns["idDepartamento3"].ReadOnly = true;
                //    dgvEmpGuardado.Columns["idCargo2"].ReadOnly = true;
                //    dgvEmpGuardado.Columns["idGenero2"].ReadOnly = true;
                //    dgvEmpGuardado.Columns["sueldoBase2"].ReadOnly = true;
                //    dgvEmpGuardado.Columns["sueldoDiario2"].ReadOnly = false;
                //}
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (existe == 0)
            {
                if (dgvEmpleados.Rows.Count > 0 && dgvEmpleados.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvEmpleados.CurrentRow.Index;

                    CargarEmpleados();
                    dgvEmpleados.CurrentCell = dgvEmpleados.Rows[selectedIndex].Cells[1];
                    dgvEmpleados.AllowUserToAddRows = false;

                    dgvEmpleados.ReadOnly = true;
                    btnGuardarEmp.Enabled = false;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                }
            }
            else
            {
                if (dgvEmpGuardado.Rows.Count > 0 && dgvEmpGuardado.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvEmpGuardado.CurrentRow.Index;

                    CargarEmpleadosGuardados();
                    dgvEmpGuardado.CurrentCell = dgvEmpGuardado.Rows[selectedIndex].Cells[3];
                    dgvEmpGuardado.AllowUserToAddRows = false;

                    dgvEmpGuardado.ReadOnly = true;
                    btnGuardarEmp.Enabled = false;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                }
            }
        }

        private void btnEditarPorc_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvPorcentaje.Rows.Count > 0 && dgvPorcentaje.FirstDisplayedCell != null)
            {
                saveRow = dgvPorcentaje.FirstDisplayedCell.RowIndex;
                dgvPorcentaje.ReadOnly = false;
                dgvPorcentaje.AllowUserToAddRows = false;

                btnGuardarPorc.Enabled = true;
                btnCancelarPorc.Enabled = true;
                btnEditarPorc.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvPorcentaje.Rows.Count)
                dgvPorcentaje.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelarPorc_Click(object sender, EventArgs e)
        {
            if (dgvPorcentaje.Rows.Count > 0 && dgvPorcentaje.FirstDisplayedCell != null)
            {
                selectedIndex = dgvPorcentaje.CurrentRow.Index;

                this.pR_CargosTableAdapter.Fill(this.dsPresupuesto.PR_Cargos);
                dgvPorcentaje.CurrentCell = dgvPorcentaje.Rows[selectedIndex].Cells[1];
                dgvPorcentaje.AllowUserToAddRows = false;

                dgvPorcentaje.ReadOnly = true;
                btnGuardarPorc.Enabled = false;
                btnEditarPorc.Enabled = true;
                btnCancelarPorc.Enabled = false;
            }
        }

        private void dgvEmpleados_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.Rows.Count > 0 && dgvEmpleados.FirstDisplayedCell != null)
            {
                CargarSueldo(Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["idEmpleado"].Value.ToString()),
                                               Convert.ToDecimal(dgvEmpleados.CurrentRow.Cells["sueldoDiario"].Value.ToString()),
                                               Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells["fechaIngreso"].Value),
                                               dgvEmpleados.CurrentRow.Cells["idTipoContrato"].FormattedValue.ToString());
            }
        }
        private void dgvEmpGuardado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEmpGuardado.Rows.Count > 0 && dgvEmpGuardado.FirstDisplayedCell != null)
            {
                CargarSueldo(Convert.ToInt32(dgvEmpGuardado.CurrentRow.Cells["idEmpleado2"].Value.ToString()),
                                               Convert.ToDecimal(dgvEmpGuardado.CurrentRow.Cells["sueldoDiario2"].Value.ToString()),
                                               Convert.ToDateTime(dgvEmpGuardado.CurrentRow.Cells["fechaIngreso2"].Value),
                                               dgvEmpGuardado.CurrentRow.Cells["idTipoContrato2"].FormattedValue.ToString());

                //dgvEmpGuardado.CurrentCell = dgvEmpGuardado.CurrentRow.Cells["sueldoDiario2"];
                //dgvEmpGuardado.BeginEdit(true);
            }           
        }

        private void dgvEmpGuardado_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvEmpGuardado.IsCurrentCellDirty)
            {
                dgvEmpGuardado.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvEmpleados_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvEmpleados.IsCurrentCellDirty)
            {
                dgvEmpleados.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void btnGuardarEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (existe == 0)
                {
                    foreach (DataGridViewRow row in dgvEmpleados.Rows)
                    {
                          VarGlobales.consultasPR.PR_InsertDetSueldos(idPresupuesto,
                                                   Convert.ToInt32(row.Cells["idEmpleado"].Value),
                                                   Convert.ToDecimal(row.Cells["sueldoDiario"].Value),
                                                   Convert.ToDecimal(row.Cells["sueldoBase"].Value),
                                                   Convert.ToDateTime(row.Cells["fechaIngreso"].Value),
                                                   row.Cells["idTipoContrato"].FormattedValue.ToString(),
                                                   Convert.ToDateTime(row.Cells["fechaCancelacion"].Value),
                                                   Convert.ToBoolean(row.Cells["cancelacion"].Value),
                                                   Convert.ToBoolean(row.Cells["calcularPrestaciones"].Value),
                                                   Convert.ToBoolean(row.Cells["calcularPreaviso"].Value),
                                                   Convert.ToBoolean(row.Cells["aplicaRecontratacion"].Value),
                                                   Convert.ToBoolean(row.Cells["pagoDinamico"].Value));
                    }

                    dgvEmpGuardado.Visible = false;
                    dgvEmpleados.Visible = true;
                    dgvEmpleados.Dock = DockStyle.Fill;

                    CargarSueldo(Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["idEmpleado"].Value),
                                                   Convert.ToDecimal(dgvEmpleados.CurrentRow.Cells["sueldoDiario"].Value),
                                                   Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells["fechaIngreso"].Value),
                                                  dgvEmpleados.CurrentRow.Cells["idTipoContrato"].FormattedValue.ToString());
                    btnVerPrestaciones.Enabled = true;
                }
                else
                {
                    foreach (DataGridViewRow row in dgvEmpGuardado.Rows)
                    {

                        VarGlobales.consultasPR.PR_UpdateDetSueldos(idPresupuesto,
                                                   Convert.ToInt32(row.Cells["idSueldo"].Value.ToString()),
                                                   Convert.ToInt32(row.Cells["idEmpleado2"].Value.ToString()),
                                                   Convert.ToDecimal(row.Cells["sueldoDiario2"].Value.ToString()),
                                                   Convert.ToDecimal(row.Cells["sueldoBase2"].Value.ToString()),
                                                   row.Cells["idTipoContrato2"].FormattedValue.ToString(),
                                                   Convert.ToDateTime(row.Cells["fechaIngreso2"].Value),
                                                   Convert.ToDateTime(row.Cells["fechaCancelacion2"].Value),
                                                   Convert.ToBoolean(row.Cells["Cancelacion2"].Value),
                                                   Convert.ToBoolean(row.Cells["calcularPrestaciones2"].Value),
                                                   Convert.ToBoolean(row.Cells["calcularPreaviso2"].Value),
                                                   Convert.ToBoolean(row.Cells["aplicaRecontratacion2"].Value),
                                                   Convert.ToBoolean(row.Cells["pagoDinamico2"].Value));                                                 
                    } 

                    CargarSueldo(Convert.ToInt32(dgvEmpGuardado.CurrentRow.Cells["idEmpleado2"].Value.ToString()),
                                                   Convert.ToDecimal(dgvEmpGuardado.CurrentRow.Cells["sueldoDiario2"].Value.ToString()),
                                                   Convert.ToDateTime(dgvEmpGuardado.CurrentRow.Cells["fechaIngreso2"].Value),
                                                   dgvEmpGuardado.CurrentRow.Cells["idTipoContrato2"].FormattedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnCargarEmpleados.Enabled = false;
            btnGuardarEmp.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }   

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEmpGuardado_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dgvSueldos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dgvPorcentaje_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
        private void dgvEmpleados_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
