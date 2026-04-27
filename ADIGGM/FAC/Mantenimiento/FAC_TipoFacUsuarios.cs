using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.FAC.Mantenimiento
{
    public partial class FAC_TipoFacUsuarios : ADIGGM.FrmPrincipal
    {
        public FAC_TipoFacUsuarios()
        {
            InitializeComponent();
        }

        private void FAC_TipoFacUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsFAC.FAC_TipoFacturas' Puede moverla o quitarla según sea necesario.
            this.fAC_TipoFacturasTableAdapter.Fill(this.dsFAC.FAC_TipoFacturas);

        }

        private void txtBusqueda1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.fAC_TipoFacUsuario_NoAsigTableAdapter.Fill(this.dsFAC.FAC_TipoFacUsuario_NoAsig, txtBusqueda1.Text, int.Parse(cboTipoFactura.SelectedValue.ToString()));
            }
        }

        private void txtBusqueda2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.fAC_TipoFacUsuario_AsigTableAdapter.Fill(this.dsFAC.FAC_TipoFacUsuario_Asig, txtBusqueda2.Text, int.Parse(cboTipoFactura.SelectedValue.ToString()));
            }
        }

        private void cboTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
                  
        }

        private void cboTipoFactura_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboTipoFactura.SelectedIndex !=-1)
            {
                this.fAC_TipoFacUsuario_NoAsigTableAdapter.Fill(this.dsFAC.FAC_TipoFacUsuario_NoAsig, txtBusqueda1.Text, int.Parse(cboTipoFactura.SelectedValue.ToString()));
                this.fAC_TipoFacUsuario_AsigTableAdapter.Fill(this.dsFAC.FAC_TipoFacUsuario_Asig, txtBusqueda2.Text, int.Parse(cboTipoFactura.SelectedValue.ToString()));
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvNoAsig.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[3].Value) == true)
                    {
                        Clases.VarGlobales.consultasFAC.FAC_Asignaciones_INS_UPD(int.Parse(row.Cells[0].Value.ToString()), int.Parse(cboTipoFactura.SelectedValue.ToString()), 1);
                    }
                }
                this.fAC_TipoFacUsuario_NoAsigTableAdapter.Fill(this.dsFAC.FAC_TipoFacUsuario_NoAsig, txtBusqueda1.Text, int.Parse(cboTipoFactura.SelectedValue.ToString()));
                this.fAC_TipoFacUsuario_AsigTableAdapter.Fill(this.dsFAC.FAC_TipoFacUsuario_Asig, txtBusqueda2.Text, int.Parse(cboTipoFactura.SelectedValue.ToString()));
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvAsig.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[1].Value) == true)
                    {
                        Clases.VarGlobales.consultasFAC.FAC_Asignaciones_INS_UPD(int.Parse(row.Cells[0].Value.ToString()), int.Parse(cboTipoFactura.SelectedValue.ToString()), 2);
                    }
                }
                this.fAC_TipoFacUsuario_NoAsigTableAdapter.Fill(this.dsFAC.FAC_TipoFacUsuario_NoAsig, txtBusqueda1.Text, int.Parse(cboTipoFactura.SelectedValue.ToString()));
                this.fAC_TipoFacUsuario_AsigTableAdapter.Fill(this.dsFAC.FAC_TipoFacUsuario_Asig, txtBusqueda2.Text, int.Parse(cboTipoFactura.SelectedValue.ToString()));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
