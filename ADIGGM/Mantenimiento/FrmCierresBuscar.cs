using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADIGGM.Clases;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmCierresBuscar : ADIGGM.FrmPrincipal
    {
        public IContract contrato { get; set; }
        public FrmCierresBuscar()
        {
            InitializeComponent();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvCierres);
        }

        private void FrmCierresBuscar_Load(object sender, EventArgs e)
        {
            this.tR_TipoFacturasTableAdapter.Fill(this.dsCodeasAdiggm.TR_TipoFacturas);
            this.tR_ClientesTableAdapter.FillByActivo(this.dsTransporteAdiggm.TR_Clientes);
            this.tR_CierresTableAdapter.Fill(this.dsTransporteAdiggm.TR_Cierres);
            
        }
        public void LlenarDgv()
        {
            if(cboClientes.SelectedIndex != -1 && cboTipoFac.SelectedIndex != -1)
            {
                int IdCliente = Convert.ToInt32(cboClientes.SelectedValue), 
                    IdTipoFac = Convert.ToInt32(cboTipoFac.SelectedValue);

                this.tR_CierreClientesTableAdapter.FillByClienteTipoFac(this.dsCodeasAdiggm.TR_CierreClientes, IdCliente, IdTipoFac);
            }
            if (dgvCierres.RowCount > 0)
            {
                btnSeleccionar.Enabled = true;
            }
            else
            {
                btnSeleccionar.Enabled = false;
            }
        }
        private void cboClientes_SelectedValueChanged(object sender, EventArgs e)
        {
            LlenarDgv();
        }

        private void cboTipoFac_SelectedValueChanged(object sender, EventArgs e)
        {
            LlenarDgv();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            contrato.Ejecutar(Convert.ToInt32(dgvCierres.CurrentRow.Cells["idCierre"].Value),
                                Convert.ToInt32(cboClientes.SelectedValue), 
                                Convert.ToInt32(cboTipoFac.SelectedValue),
                                Convert.ToDateTime(dgvCierres.CurrentRow.Cells["FechaInicio"].Value),
                                Convert.ToDateTime(dgvCierres.CurrentRow.Cells["FechaFin"].Value),
                                "");
            this.DialogResult = DialogResult.OK;
        }
    }
}