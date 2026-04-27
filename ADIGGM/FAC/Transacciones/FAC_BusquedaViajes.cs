using ADIGGM.Clases;
using CheckComboBoxTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.FAC.Transacciones
{    
    public partial class FAC_BusquedaViajes : FrmPrincipal
    {
        public int IdCliente = 0;
        public decimal Cant = 0;
        public decimal Impuesto = 0;
        public decimal Tot = 0;
        Boolean permitir = true;

        public FAC_BusquedaViajes(int IdCliente)
        {
            InitializeComponent();
            this.IdCliente = IdCliente;
        }

        private void FAC_BusquedaViajes_Load(object sender, EventArgs e)
        {          
            // TODO: esta línea de código carga datos en la tabla 'dsFAC.TR_TipoFacturas' Puede moverla o quitarla según sea necesario.
            this.tR_TipoFacturasTableAdapter.FillByTransporte(this.dsFAC.TR_TipoFacturas);
            // TODO: esta línea de código carga datos en la tabla 'dsFAC.FAC_Productos' Puede moverla o quitarla según sea necesario.
            if (int.Parse(cboTipoFac.SelectedIndex.ToString()) != -1)
            {
                this.fAC_ProductosTableAdapter.FillByTransporte(this.dsFAC.FAC_Productos, int.Parse(cboTipoFac.SelectedValue.ToString()));
            }
            
            // TODO: esta línea de código carga datos en la tabla 'dsFAC.FAC_Cierres' Puede moverla o quitarla según sea necesario.
            this.fAC_CierresTableAdapter.Fill(this.dsFAC.FAC_Cierres);
            this.tR_ClientesTableAdapter.Fill(this.dsFAC.TR_Clientes, true);

            if (cboCalendarizacion.SelectedIndex != -1)
            {
                this.fAC_ProformasTableAdapter.Fill(this.dsFAC.FAC_Proformas, int.Parse(cboCalendarizacion.SelectedValue.ToString()), IdCliente);
            }

            cboCliente.SelectedValue = IdCliente;
            txtCantidad.Text = "0";
            lblTotal.Text = $"Cantidad: {0} ISV: {0} Total: {0}";
        }

        private void cboCalendarizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCalendarizacion.SelectedIndex != -1)
            {
                this.fAC_ProformasTableAdapter.Fill(this.dsFAC.FAC_Proformas, int.Parse(cboCalendarizacion.SelectedValue.ToString()), IdCliente);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (int.Parse(cboTipoFac.SelectedIndex.ToString())==-1) {
                MessageBox.Show("Seleccione Tipo Factura", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.fAC_VisorBoletasTableAdapter.Fill(this.dsFAC.FAC_VisorBoletas, int.Parse(cboCalendarizacion.SelectedValue.ToString()), int.Parse(cboCliente.SelectedValue.ToString()), int.Parse(cboTipoFac.SelectedValue.ToString()));

                Cant = 0;
                Impuesto = 0;
                Tot = 0;
                
                foreach (DataGridViewRow row in dgvBoletas.Rows)
                {
                    Cant += decimal.Parse(row.Cells[6].Value.ToString());
                    Impuesto += decimal.Parse(row.Cells[8].Value.ToString());
                    Tot += decimal.Parse(row.Cells[9].Value.ToString());
                }
                decimal Tot2 = Impuesto+Tot;
                txtCantidad.Text = Cant.ToString();
                lblTotal.Text = $"Cantidad: {Convert.ToString(Cant.ToString("N2"))}    ISV: {Convert.ToString(Impuesto.ToString("N2"))}    Sub-Total: {Convert.ToString(Tot.ToString("N2"))}     Total: {Convert.ToString(Tot2.ToString("N2"))}";
            }            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (int.Parse(cboTipoFac.SelectedIndex.ToString()) == -1)
            {
                MessageBox.Show("Seleccione un Tipo Factura", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (int.Parse(cboProducto.SelectedIndex.ToString()) == -1)
            {
                MessageBox.Show("Seleccione una producto", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(int.Parse(cboProforma.SelectedIndex.ToString())== -1){
                MessageBox.Show("Seleccione una proforma", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (decimal.Parse(dgvBoletas.Rows.Count.ToString()) == 0)
            {
                MessageBox.Show("No hay información en el grid, seleccione los parametros y haga clic en visualizar", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FAC_Factura.IdCierre = int.Parse(cboCalendarizacion.SelectedValue.ToString());
                FAC_Factura.IdProforma = int.Parse(cboProforma.SelectedValue.ToString());
                FAC_Factura.IdProducto = int.Parse(cboProducto.SelectedValue.ToString());
                FAC_Factura.Cant = decimal.Parse(txtCantidad.Text);
                FAC_Factura.Imp = Impuesto;
                FAC_Factura.Tot = Tot;
                FAC_Factura.TipoFact = cboTipoFac.Text;
                Cant = 0;
                Impuesto = 0;
                Tot = 0;

                this.Close();
            }
        }

        private void cboTipoFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.Parse(cboTipoFac.SelectedIndex.ToString()) != -1)
            {
                this.fAC_ProductosTableAdapter.FillByTransporte(this.dsFAC.FAC_Productos, int.Parse(cboTipoFac.SelectedValue.ToString()));
            }
        }

        public bool solonumeros(int code, TextBox txt)
        {
            bool resultado;

            if (code == 46 && txt.Text.Contains("."))//se evalua si es punto y si es punto se revisa si ya existe en el textbox
            {
                resultado = true;
            }
            else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evaluan las teclas validas
            {
                resultado = false;
            }
            else if (!permitir)
            {
                resultado = permitir;
            }
            else
            {
                resultado = true;
            }

            return resultado;

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = solonumeros(Convert.ToInt32(e.KeyChar), txtCantidad);
        }
    }
}
