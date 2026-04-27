using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmTarifaRutas : FrmPrincipal
    {
        public FrmTarifaRutas()
        {
            InitializeComponent();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvRutasAsignadas);
            DgvStyle.EstiloDgv(dgvRutasNoAsignadas);
        }

            Clases.VarGlobales variables = new Clases.VarGlobales();

        private void FrmTarifaRutas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_SubCliente' Puede moverla o quitarla según sea necesario.
            //this.tR_SubClienteTableAdapter.Fill(this.dsTransporteAdiggm.TR_SubCliente);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Clientes' Puede moverla o quitarla según sea necesario.
            this.tR_ClientesTableAdapter.Fill(this.dsTransporteAdiggm.TR_Clientes);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_ClaseTrabajos' Puede moverla o quitarla según sea necesario.
            this.tR_ClaseTrabajosTableAdapter.FillByActivo(this.dsTransporteAdiggm.TR_ClaseTrabajos);
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_TipoVehiculos' Puede moverla o quitarla según sea necesario.
            this.tR_TipoVehiculosTableAdapter.FillByActivo(this.dsTransporteAdiggm.TR_TipoVehiculos);
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
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRuta1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.pR_TarifaRutasNoAsigTableAdapter.Fill(dsTransporteAdiggm.PR_TarifaRutasNoAsig, 
                                                        int.Parse(cboTipoVehiculo.SelectedValue.ToString()), 
                                                        this.txtRuta1.Text, 
                                                        int.Parse(cboClaseTrabajo.SelectedValue.ToString()),
                                                        int.Parse(cboClientes.SelectedValue.ToString()));
            btnAgregar.Enabled = true;
            btnAgregarTodo.Enabled = true;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
            dgvRutasAsignadas.ClearSelection();
        }

        private void txtRuta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.pR_TarifaRutasAsigTableAdapter.Fill(dsTransporteAdiggm.PR_TarifaRutasAsig, 
                                                    int.Parse(cboTipoVehiculo.SelectedValue.ToString()), 
                                                    this.txtRuta2.Text, 
                                                    int.Parse(cboClaseTrabajo.SelectedValue.ToString()),
                                                    int.Parse(cboClientes.SelectedValue.ToString()));
            btnEliminar.Enabled = true;
            btnEliminarTodo.Enabled = true;
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            dgvRutasNoAsignadas.ClearSelection();
        }

        private void dgvRutasAsignadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnEliminarTodo.Enabled = true;
            btnAgregar.Enabled = false;
            btnAgregarTodo.Enabled = false;
            dgvRutasNoAsignadas.ClearSelection();
        }

        private void dgvRutasNoAsignadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregar.Enabled = true;
            btnAgregarTodo.Enabled = true;
            btnEliminar.Enabled = false;
            btnEliminarTodo.Enabled = false;
            dgvRutasAsignadas.ClearSelection();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Clases.VarGlobales.consultasTrans.PR_TarifaRutasAsigInsert(int.Parse(cboTipoVehiculo.SelectedValue.ToString()), 
                                                                        int.Parse(cboClaseTrabajo.SelectedValue.ToString()), 
                                                                        int.Parse(dgvRutasNoAsignadas.CurrentRow.Cells["idRutaNoAsig"].Value.ToString()),
                                                                        decimal.Parse(dgvRutasNoAsignadas.CurrentRow.Cells["Tarifa"].Value.ToString()),
                                                                        int.Parse(cboClientes.SelectedValue.ToString()));
            CargarDgv();
            this.dgvRutasAsignadas.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.VarGlobales.consultasTrans.PR_TarifaRutasAsigDel(int.Parse(dgvRutasAsignadas.CurrentRow.Cells["IdTarifaRuta"].Value.ToString()));
            CargarDgv();
            this.dgvRutasNoAsignadas.ClearSelection();
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
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRutasAsignadas.Rows)
            {
                Clases.VarGlobales.consultasTrans.PR_TarifaRutasAsigDel(int.Parse(row.Cells["IdTarifaRuta"].Value.ToString()));
            }
            CargarDgv();
            this.dgvRutasNoAsignadas.ClearSelection();
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

        private void cboSubClientes_SelectedValueChanged(object sender, EventArgs e)
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
    }
}
