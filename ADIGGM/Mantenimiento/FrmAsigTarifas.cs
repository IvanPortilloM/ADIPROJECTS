namespace ADIGGM.Mantenimiento
{
    using ADIGGM.CapaDatos;
    using Clases;
    using System;
    using System.Windows.Forms;
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
            dgvRutasAsignadas.Columns["TarifaReal"].DefaultCellStyle.Format = "N4";
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
            try
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexion.TransporteADI))
                {
                    conn.Open();
                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("PR_TarifaRutasAsigInsert", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@IdTipoVehiculo", System.Data.SqlDbType.Int).Value = int.Parse(cboTipoVehiculo.SelectedValue.ToString());
                        cmd.Parameters.Add("@IdClaseTrabajo", System.Data.SqlDbType.Int).Value = int.Parse(cboClaseTrabajo.SelectedValue.ToString());
                        cmd.Parameters.Add("@IdRuta", System.Data.SqlDbType.Int).Value = int.Parse(dgvRutasNoAsignadas.CurrentRow.Cells["idRutaNoAsig"].Value.ToString());
                        cmd.Parameters.Add("@IdCliente", System.Data.SqlDbType.Int).Value = int.Parse(cboClientes.SelectedValue.ToString());

                        System.Data.SqlClient.SqlParameter paramTarifa = new System.Data.SqlClient.SqlParameter();
                        paramTarifa.ParameterName = "@Tarifa";
                        paramTarifa.SqlDbType = System.Data.SqlDbType.Decimal;
                        paramTarifa.Precision = 10;
                        paramTarifa.Scale = 4;
                        paramTarifa.Value = Convert.ToDecimal(dgvRutasNoAsignadas.CurrentRow.Cells["Tarifa"].Value, System.Globalization.CultureInfo.InvariantCulture);
                        cmd.Parameters.Add(paramTarifa);

                        cmd.ExecuteNonQuery();
                    }
                }

                if (dgvRutasNoAsignadas.Rows.Count > 0 && dgvRutasNoAsignadas.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvRutasNoAsignadas.CurrentRow.Index;
                    CargarDgv();

                    if (selectedIndex < dgvRutasNoAsignadas.RowCount)
                        dgvRutasNoAsignadas.CurrentCell = dgvRutasNoAsignadas.Rows[selectedIndex].Cells[1];
                    else if (dgvRutasNoAsignadas.RowCount > 0)
                        dgvRutasNoAsignadas.CurrentCell = dgvRutasNoAsignadas.Rows[dgvRutasNoAsignadas.RowCount - 1].Cells[1];
                }

                btnAgregar.Enabled = dgvRutasNoAsignadas.RowCount > 0;
                btnAgregarTodo.Enabled = dgvRutasNoAsignadas.RowCount > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarTodo_Click(object sender, EventArgs e)
        {
            try
            {
                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexion.TransporteADI))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dgvRutasNoAsignadas.Rows)
                    {
                        using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("PR_TarifaRutasAsigInsert", conn))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            cmd.Parameters.Add("@IdTipoVehiculo", System.Data.SqlDbType.Int).Value = int.Parse(cboTipoVehiculo.SelectedValue.ToString());
                            cmd.Parameters.Add("@IdClaseTrabajo", System.Data.SqlDbType.Int).Value = int.Parse(cboClaseTrabajo.SelectedValue.ToString());
                            cmd.Parameters.Add("@IdRuta", System.Data.SqlDbType.Int).Value = int.Parse(row.Cells["idRutaNoAsig"].Value.ToString());
                            cmd.Parameters.Add("@IdCliente", System.Data.SqlDbType.Int).Value = int.Parse(cboClientes.SelectedValue.ToString());

                            System.Data.SqlClient.SqlParameter paramTarifa = new System.Data.SqlClient.SqlParameter();
                            paramTarifa.ParameterName = "@Tarifa";
                            paramTarifa.SqlDbType = System.Data.SqlDbType.Decimal;
                            paramTarifa.Precision = 10;
                            paramTarifa.Scale = 4;
                            paramTarifa.Value = Convert.ToDecimal(row.Cells["Tarifa"].Value, System.Globalization.CultureInfo.InvariantCulture);
                            cmd.Parameters.Add(paramTarifa);

                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                CargarDgv();
                this.dgvRutasAsignadas.ClearSelection();
                btnAgregar.Enabled = false;
                btnAgregarTodo.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            VarGlobales.consultasTrans.PR_TarifaRutasAsigDel(int.Parse(dgvRutasAsignadas.CurrentRow.Cells["IdTarifaRuta"].Value.ToString()));

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

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se eliminaran todas la rutas asignadas ¿Desea Continuar?", VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvRutasAsignadas.Rows)
                {
                    VarGlobales.consultasTrans.PR_TarifaRutasAsigDel(int.Parse(row.Cells["IdTarifaRuta"].Value.ToString()));
                }
                CargarDgv();
                this.dgvRutasNoAsignadas.ClearSelection();
                btnEliminar.Enabled = false;
                btnEliminarTodo.Enabled = false;
            }
        }

        private void dgvRutasAsignadas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRutasAsignadas.Columns[e.ColumnIndex].Name != "TarifaReal") return;

            try
            {
                int idTarifaRuta = int.Parse(
                    dgvRutasAsignadas.CurrentRow.Cells["IdTarifaRuta"].Value.ToString());

                decimal tarifa = Convert.ToDecimal(
                    dgvRutasAsignadas.CurrentRow.Cells["TarifaReal"].Value,
                    System.Globalization.CultureInfo.InvariantCulture);

                using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Conexion.TransporteADI))
                {
                    conn.Open();
                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand("PR_TarifaRutasAsigUpdate", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.Add("@IdTarifaRuta", System.Data.SqlDbType.Int).Value = idTarifaRuta;

                        // ✅ Forzar precisión 10,4 explícitamente
                        System.Data.SqlClient.SqlParameter paramTarifa = new System.Data.SqlClient.SqlParameter();
                        paramTarifa.ParameterName = "@Tarifa";
                        paramTarifa.SqlDbType = System.Data.SqlDbType.Decimal;
                        paramTarifa.Precision = 10;
                        paramTarifa.Scale = 4;
                        paramTarifa.Value = tarifa;
                        cmd.Parameters.Add(paramTarifa);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, VarGlobales.nombreSistema,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
