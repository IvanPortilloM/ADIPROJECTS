namespace ADIGGM.Mantenimiento
{
    using System;
    using System.Windows.Forms;
    using Clases;
    public partial class FrmAsigTarifas : FrmPrincipal
    {
        int selectedIndex;
        public FrmAsigTarifas()
        {
            InitializeComponent();
            FuncionesGlobales DgvStyle = new FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvRutasAsignadas);
            DgvStyle.EstiloDgv(dgvRutasNoAsignadas);
        }

        private void FrmTarifaRutas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm1.TR_Clientes' Puede moverla o quitarla según sea necesario.
            this.tR_ClientesTableAdapter.FillByActivo(this.dsTransporteAdiggm1.TR_Clientes);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm1.TR_ClaseTrabajos' Puede moverla o quitarla según sea necesario.
            this.tR_ClaseTrabajosTableAdapter.FillByActivo(this.dsTransporteAdiggm1.TR_ClaseTrabajos);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm1.TR_TipoVehiculos' Puede moverla o quitarla según sea necesario.
            this.tR_TipoVehiculosTableAdapter.FillByActivo(this.dsTransporteAdiggm1.TR_TipoVehiculos);
           
            CargarDgv();
            this.dgvRutasNoAsignadas.ClearSelection();
            this.dgvRutasAsignadas.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }

        private void CargarDgv()
        {
            try
            {
                if (cboClientes.SelectedIndex != -1 && cboTipoVehiculo.SelectedIndex != -1 && cboClaseTrabajo.SelectedIndex != -1)
                {
                    this.pR_TarifaRutasAsigTableAdapter.Fill(dsTransporteAdiggm.PR_TarifaRutasAsig, 
                                                        int.Parse(cboTipoVehiculo.SelectedValue.ToString()), 
                                                        this.txtRuta2.Text,
                                                        int.Parse(cboClaseTrabajo.SelectedValue.ToString()),
                                                        int.Parse(cboClientes.SelectedValue.ToString()));

                    this.pR_TarifaRutasNoAsigTableAdapter.Fill(dsTransporteAdiggm.PR_TarifaRutasNoAsig, 
                                                        int.Parse(cboTipoVehiculo.SelectedValue.ToString()), 
                                                        this.txtRuta1.Text, 
                                                        int.Parse(cboClaseTrabajo.SelectedValue.ToString()),
                                                        int.Parse(cboClientes.SelectedValue.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRuta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.pR_TarifaRutasNoAsigTableAdapter.Fill(dsTransporteAdiggm.PR_TarifaRutasNoAsig, 
                                                        int.Parse(cboTipoVehiculo.SelectedValue.ToString()), 
                                                        this.txtRuta1.Text, 
                                                        int.Parse(cboClaseTrabajo.SelectedValue.ToString()),
                                                        int.Parse(cboClientes.SelectedValue.ToString()));
            if (dgvRutasNoAsignadas.RowCount > 0)
            {
                btnAgregar.Enabled = true;
                btnAgregarTodo.Enabled = true;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvRutasAsignadas.ClearSelection();
            }
            else
            {
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvRutasAsignadas.ClearSelection();
            }
        }

        private void txtRuta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.pR_TarifaRutasAsigTableAdapter.Fill(dsTransporteAdiggm.PR_TarifaRutasAsig, 
                                                    int.Parse(cboTipoVehiculo.SelectedValue.ToString()), 
                                                    this.txtRuta2.Text, 
                                                    int.Parse(cboClaseTrabajo.SelectedValue.ToString()),
                                                    int.Parse(cboClientes.SelectedValue.ToString()));
            if (dgvRutasAsignadas.RowCount > 0)
            {
                btnEliminar.Enabled = true;
                btnEliminarTodo.Enabled = true;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvRutasNoAsignadas.ClearSelection();
            }
            else
            {
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvRutasNoAsignadas.ClearSelection();
            }
        }

        private void dgvRutasAsignadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRutasAsignadas.RowCount > 0)
            {
                btnEliminar.Enabled = true;
                btnEliminarTodo.Enabled = true;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvRutasNoAsignadas.ClearSelection();
            }
            else
            {
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                dgvRutasNoAsignadas.ClearSelection();
            }
        }

        private void dgvRutasNoAsignadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRutasNoAsignadas.RowCount > 0)
            {
                btnAgregar.Enabled = true;
                btnAgregarTodo.Enabled = true;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvRutasAsignadas.ClearSelection();
            }
            else
            {
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
                dgvRutasAsignadas.ClearSelection();
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clases.VarGlobales.consultasTrans.PR_TarifaRutasAsigInsert(int.Parse(cboTipoVehiculo.SelectedValue.ToString()), 
                                                                        int.Parse(cboClaseTrabajo.SelectedValue.ToString()), 
                                                                        int.Parse(dgvRutasNoAsignadas.CurrentRow.Cells["idRutaNoAsig"].Value.ToString()),
                                                                        decimal.Parse(dgvRutasNoAsignadas.CurrentRow.Cells["Tarifa"].Value.ToString()),
                                                                        int.Parse(cboClientes.SelectedValue.ToString()));

            if (dgvRutasNoAsignadas.Rows.Count > 0 && dgvRutasNoAsignadas.FirstDisplayedCell != null)
            {
                selectedIndex = dgvRutasNoAsignadas.CurrentRow.Index;
                CargarDgv();

                if (selectedIndex < dgvRutasNoAsignadas.RowCount)
                {
                    dgvRutasNoAsignadas.CurrentCell = dgvRutasNoAsignadas.Rows[selectedIndex].Cells[1];
                }
                else if (dgvRutasNoAsignadas.RowCount == 0)
                {
                    //dgvRutasNoAsignadas.CurrentCell = dgvRutasNoAsignadas.Rows[dgvRutasNoAsignadas.RowCount - 1].Cells[1];
                }
                else
                {
                    dgvRutasNoAsignadas.CurrentCell = dgvRutasNoAsignadas.Rows[dgvRutasNoAsignadas.RowCount - 1].Cells[1];
                }
                
            }
            //this.dgvRutasAsignadas.ClearSelection();
            if (dgvRutasNoAsignadas.RowCount > 0)
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
            Clases.VarGlobales.consultasTrans.PR_TarifaRutasAsigDel(int.Parse(dgvRutasAsignadas.CurrentRow.Cells["IdTarifaRuta"].Value.ToString()));

            if (dgvRutasAsignadas.Rows.Count > 0 && dgvRutasAsignadas.FirstDisplayedCell != null)
            {
                selectedIndex = dgvRutasAsignadas.CurrentRow.Index;
                CargarDgv();

                if (selectedIndex < dgvRutasAsignadas.RowCount)
                {
                    dgvRutasAsignadas.CurrentCell = dgvRutasAsignadas.Rows[selectedIndex].Cells[3];
                }
                else if(dgvRutasAsignadas.RowCount == 0)
                {
                    //dgvRutasAsignadas.CurrentCell = dgvRutasAsignadas.Rows[dgvRutasAsignadas.RowCount - 1].Cells[3];
                }
                else
                {
                    dgvRutasAsignadas.CurrentCell = dgvRutasAsignadas.Rows[dgvRutasAsignadas.RowCount - 1].Cells[3];
                }
            }
            //this.dgvRutasNoAsignadas.ClearSelection();
            if (dgvRutasAsignadas.RowCount > 0)
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
            foreach (DataGridViewRow row in dgvRutasNoAsignadas.Rows)
            {
                Clases.VarGlobales.consultasTrans.PR_TarifaRutasAsigInsert(int.Parse(cboTipoVehiculo.SelectedValue.ToString()),
                                                                        int.Parse(cboClaseTrabajo.SelectedValue.ToString()),
                                                                        int.Parse(row.Cells["idRutaNoAsig"].Value.ToString()),
                                                                        decimal.Parse(row.Cells["Tarifa"].Value.ToString()),
                                                                        int.Parse(cboClientes.SelectedValue.ToString()));
            }
            CargarDgv();
            this.dgvRutasAsignadas.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se eliminaran todas la rutas asignadas ¿Desea Continuar?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvRutasAsignadas.Rows)
                {
                    Clases.VarGlobales.consultasTrans.PR_TarifaRutasAsigDel(int.Parse(row.Cells["IdTarifaRuta"].Value.ToString()));
                }
                CargarDgv();
                this.dgvRutasNoAsignadas.ClearSelection();
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
            }
        }

        private void dgvRutasAsignadas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Clases.VarGlobales.consultasTrans.PR_TarifaRutasAsigUpdate(int.Parse(dgvRutasAsignadas.CurrentRow.Cells["IdTarifaRuta"].Value.ToString()),
                                                                       decimal.Parse(dgvRutasAsignadas.CurrentRow.Cells["TarifaReal"].Value.ToString()));
        }

        private void cboClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarDgv();
            this.dgvRutasNoAsignadas.ClearSelection();
            this.dgvRutasAsignadas.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }

        private void cboTipoVehiculo_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarDgv();
            this.dgvRutasNoAsignadas.ClearSelection();
            this.dgvRutasAsignadas.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }

        private void cboClaseTrabajo_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarDgv();
            this.dgvRutasNoAsignadas.ClearSelection();
            this.dgvRutasAsignadas.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
        }

        private void dgvRutasNoAsignadas_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvRutasNoAsignadas.Rows.Count > 0 && dgvRutasNoAsignadas.SelectedRows.Count >= 1)
            //    selectedIndex = dgvRutasNoAsignadas.SelectedRows[0].Index;
        }

        private void dgvRutasAsignadas_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvRutasAsignadas.Rows.Count > 0 && dgvRutasAsignadas.SelectedRows.Count >= 1)
            //    selectedIndex = dgvRutasAsignadas.SelectedRows[0].Index;
        }
    }
}
