namespace ADIGGM.Mantenimiento
{
    using ADIGGM.Clases;
    using System;
    using System.Windows.Forms;
    public partial class FrmAsigRutaClientes : FrmPrincipal
    {
        int selectedIndex;
        public FrmAsigRutaClientes()
        {
            InitializeComponent();
            FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvRutasAsignadas);
            DgvStyle.EstiloDgv(dgvRutasNoAsignadas);
            
        }

        private void FrmAsigRutaClientes_Load(object sender, EventArgs e)
        {
            this.tR_ClientesTableAdapter.FillByActivo(this.dsTransporteAdiggm.TR_Clientes);
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
                if (cboClientes.SelectedIndex != -1)
                {
                    this.pR_SelectRutaClienteNoAsigTableAdapter.Fill(dsTransporteAdiggm.PR_SelectRutaClienteNoAsig,
                                                                    int.Parse(cboClientes.SelectedValue.ToString()),
                                                                    this.txtRuta1.Text);
                    this.pR_SelectRutaClienteAsigTableAdapter.Fill(dsTransporteAdiggm.PR_SelectRutaClienteAsig,
                                                                    int.Parse(cboClientes.SelectedValue.ToString()),
                                                                    this.txtRuta2.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRuta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.pR_SelectRutaClienteAsigTableAdapter.Fill(dsTransporteAdiggm.PR_SelectRutaClienteAsig, 
                                                           int.Parse(cboClientes.SelectedValue.ToString()), 
                                                           this.txtRuta2.Text);
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

        private void txtRuta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.pR_SelectRutaClienteNoAsigTableAdapter.Fill(dsTransporteAdiggm.PR_SelectRutaClienteNoAsig, 
                                                            int.Parse(cboClientes.SelectedValue.ToString()), 
                                                            this.txtRuta1.Text);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            VarGlobales.consultasTrans.PR_SelectRutaClienteAsigDel(int.Parse(cboClientes.SelectedValue.ToString()),
                                                                            int.Parse(dgvRutasAsignadas.CurrentRow.Cells["idRuta"].Value.ToString()));

            if (dgvRutasAsignadas.Rows.Count > 0 && dgvRutasAsignadas.FirstDisplayedCell != null)
            {
                selectedIndex = dgvRutasAsignadas.CurrentRow.Index;
                CargarDgv();

                if (selectedIndex < dgvRutasAsignadas.RowCount)
                {
                    dgvRutasAsignadas.CurrentCell = dgvRutasAsignadas.Rows[selectedIndex].Cells[1];
                }
                else if (dgvRutasAsignadas.RowCount == 0)
                {
                    //dgvRutasAsignadas.CurrentCell = dgvRutasAsignadas.Rows[dgvRutasAsignadas.RowCount - 1].Cells[1];
                }
                else
                {
                    dgvRutasAsignadas.CurrentCell = dgvRutasAsignadas.Rows[dgvRutasAsignadas.RowCount - 1].Cells[1];
                }
            }
            if(dgvRutasAsignadas.RowCount > 0)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VarGlobales.consultasTrans.PR_SelectRutaClienteAsigInsert(int.Parse(cboClientes.SelectedValue.ToString()), 
                                                                             int.Parse(dgvRutasNoAsignadas.CurrentRow.Cells["idRutaNoAsig"].Value.ToString()));

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
                    //dgvRutasNoAsignadas.CurrentCell = dgvRutasNoAsignadas.Rows[dgvRutasAsignadas.RowCount - 1].Cells[1];
                }
                else
                {
                    dgvRutasNoAsignadas.CurrentCell = dgvRutasNoAsignadas.Rows[dgvRutasNoAsignadas.RowCount - 1].Cells[1];
                }
            }
            if(dgvRutasNoAsignadas.RowCount > 0)
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

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se eliminaran todas la rutas asignadas ¿Desea Continuar?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvRutasAsignadas.Rows)
                {
                    VarGlobales.consultasTrans.PR_SelectRutaClienteAsigDel(int.Parse(cboClientes.SelectedValue.ToString()),
                                                                                  int.Parse(row.Cells["idRuta"].Value.ToString()));
                }
                CargarDgv();
                this.dgvRutasNoAsignadas.ClearSelection();
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
            }
        }
        private void btnAgregarTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRutasNoAsignadas.Rows)
            {
                VarGlobales.consultasTrans.PR_SelectRutaClienteAsigInsert(int.Parse(cboClientes.SelectedValue.ToString()), 
                                                                                    int.Parse(row.Cells["idRutaNoAsig"].Value.ToString()));
            }
            CargarDgv();
            this.dgvRutasAsignadas.ClearSelection();
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
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

        private void txtRuta2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
