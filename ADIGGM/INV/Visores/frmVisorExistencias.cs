using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.INV.Visores
{
    public partial class frmVisorExistencias : FrmPrincipal
    {
        public frmVisorExistencias()
        {
            InitializeComponent();
            
        }

        private void frmVisorExistencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.TR_Vehiculos' Puede moverla o quitarla según sea necesario.
            this.tR_VehiculosTableAdapter.Fill(this.dsOC.TR_Vehiculos);
            this.oC_ProductosCategoriasTableAdapter.Fill(this.dsOC.OC_ProductosCategorias);
            this.oC_ProductosTableAdapter.FillByTodos(this.dsOC.OC_Productos);
            this.Dock = DockStyle.Fill;

            int IdCatProducto = 0, idproducto = 0, idvehiculo = 0;

            cboTipoReporte.SelectedIndex = 0;

                if (chkCat.Checked == true)
                {
                    cboCategorias.Enabled = true;
                    IdCatProducto = int.Parse(cboCategorias.SelectedValue.ToString());
                }
                if (chkFiltroProd.Checked == true)
                {
                    cboCategorias.Enabled = true;
                    chkFiltroProd.Checked = true;
                    cboProductos.Enabled = true;
                    if (cboCategorias.SelectedIndex != -1)
                        idproducto = int.Parse(cboProductos.SelectedValue.ToString());
                }
                if (chkFiltroVeh.Checked == true)
                {
                    idvehiculo = int.Parse(cboVehiculos.SelectedValue.ToString());
                }

            if (cboTipoReporte.Text == "Reporte General")
            {
                
                iN_R_ExistenciasTableAdapter.Fill(dsInventarioAdiggm.IN_R_Existencias, IdCatProducto, idproducto, idvehiculo, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvInv.RefreshReport();
                rvInv.SetDisplayMode(DisplayMode.PrintLayout);
                rvInv.ZoomMode = ZoomMode.PageWidth;
                rvInv.Dock = DockStyle.Fill;
                rvInv.Visible = true;
                rvExistencias.Visible = false;
                this.rvInv.RefreshReport();
            }
            else if (cboTipoReporte.Text == "Reporte de Existencias")
            {
                iN_R_ProductosExistenciaTableAdapter.Fill(dsInventarioAdiggm.IN_R_ProductosExistencia, IdCatProducto, idproducto, chkSoloExistencias.Checked, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvExistencias.RefreshReport();
                rvExistencias.SetDisplayMode(DisplayMode.PrintLayout);
                rvExistencias.ZoomMode = ZoomMode.PageWidth;
                rvExistencias.Dock = DockStyle.Fill;
                rvInv.Visible = false;
                rvExistencias.Visible = true;
                this.rvExistencias.RefreshReport();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int IdCatProducto = 0, idproducto = 0, idvehiculo = 0;

            if (chkCat.Checked == true)
            {
                cboCategorias.Enabled = true;
                IdCatProducto = int.Parse(cboCategorias.SelectedValue.ToString());
            }
            else
            {
                cboCategorias.Enabled = false;
            }

            if (chkFiltroProd.Checked == true)
            {
                cboCategorias.Enabled = true;
                chkFiltroProd.Checked = true;
                cboProductos.Enabled = true;
                if (cboCategorias.SelectedIndex != -1)
                    idproducto = int.Parse(cboProductos.SelectedValue.ToString());
            }
            else
            {
                cboProductos.Enabled = false;
                chkFiltroProd.Checked = false;
            }

            if (chkFiltroVeh.Checked == true)
            {
                cboVehiculos.Enabled = true;
                idvehiculo = int.Parse(cboVehiculos.SelectedValue.ToString());
            }
            else
            {
                cboVehiculos.Enabled = false;
            }

            if (cboTipoReporte.Text == "Reporte General")
            {                
                iN_R_ExistenciasTableAdapter.Fill(dsInventarioAdiggm.IN_R_Existencias, IdCatProducto, idproducto, idvehiculo, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvInv.RefreshReport();
                rvInv.SetDisplayMode(DisplayMode.PrintLayout);
                rvInv.ZoomMode = ZoomMode.PageWidth;
                rvInv.Dock = DockStyle.Fill;
                rvInv.Visible = true;
                rvExistencias.Visible = false;
                this.rvInv.RefreshReport();
            }
            else if (cboTipoReporte.Text == "Reporte de Existencias")
            {
                iN_R_ProductosExistenciaTableAdapter.Fill(dsInventarioAdiggm.IN_R_ProductosExistencia, IdCatProducto, idproducto, chkSoloExistencias.Checked, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvExistencias.RefreshReport();
                rvExistencias.SetDisplayMode(DisplayMode.PrintLayout);
                rvExistencias.ZoomMode = ZoomMode.PageWidth;
                rvExistencias.Dock = DockStyle.Fill;
                rvInv.Visible = false;
                rvExistencias.Visible = true;

                this.rvExistencias.RefreshReport();
            }
        }

        private void chkFiltroProd_CheckedChanged(object sender, EventArgs e)
        {
            int IdCatProducto = 0, idproducto = 0, idvehiculo = 0;

            if (chkFiltroProd.Checked == true)
            {
                cboCategorias.Enabled = true;
                chkFiltroProd.Checked = true;
                cboProductos.Enabled = true;
                if (cboCategorias.SelectedIndex != -1)
                    idproducto = int.Parse(cboProductos.SelectedValue.ToString());
            }
            else
            {
                cboProductos.Enabled = false;
                chkFiltroProd.Checked = false;
            }

            if (chkFiltroVeh.Checked == true)
            {
                cboVehiculos.Enabled = true;
                idvehiculo = int.Parse(cboVehiculos.SelectedValue.ToString());
            }
            else
            {
                cboVehiculos.Enabled = false;
            }

            if (cboTipoReporte.Text == "Reporte General")
            {                
                iN_R_ExistenciasTableAdapter.Fill(dsInventarioAdiggm.IN_R_Existencias, IdCatProducto, idproducto, idvehiculo, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvInv.RefreshReport();
                rvInv.SetDisplayMode(DisplayMode.PrintLayout);
                rvInv.ZoomMode = ZoomMode.PageWidth;
                rvInv.Dock = DockStyle.Fill;
                rvInv.Visible = true;
                rvExistencias.Visible = false;
                this.rvInv.RefreshReport();
            }
            else if (cboTipoReporte.Text == "Reporte de Existencias")
            {               
                iN_R_ProductosExistenciaTableAdapter.Fill(dsInventarioAdiggm.IN_R_ProductosExistencia, IdCatProducto, idproducto, chkSoloExistencias.Checked, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvExistencias.RefreshReport();
                rvExistencias.SetDisplayMode(DisplayMode.PrintLayout);
                rvExistencias.ZoomMode = ZoomMode.PageWidth;
                rvExistencias.Dock = DockStyle.Fill;
                rvInv.Visible = false;
                rvExistencias.Visible = true;
                this.rvExistencias.RefreshReport();
            }
        }

        private void chkFiltroVeh_CheckedChanged(object sender, EventArgs e)
        {
            int IdCatProducto = 0, idproducto = 0, idvehiculo = 0;

            if (chkCat.Checked == true)
            {
                cboCategorias.Enabled = true;
                IdCatProducto = int.Parse(cboCategorias.SelectedValue.ToString());
            }
            else
            {
                cboCategorias.Enabled = false;
            }

            if (chkFiltroProd.Checked == true)
            {
                cboCategorias.Enabled = true;
                chkFiltroProd.Checked = true;
                cboProductos.Enabled = true;
                if (cboCategorias.SelectedIndex != -1)
                    idproducto = int.Parse(cboProductos.SelectedValue.ToString());
            }
            else
            {
                cboCategorias.Enabled = false;
                cboProductos.Enabled = false;
                chkFiltroProd.Checked = false;
            }

            if (chkFiltroVeh.Checked == true)
            {
                cboVehiculos.Enabled = true;
                idvehiculo = int.Parse(cboVehiculos.SelectedValue.ToString());
            }
            else
            {
                cboVehiculos.Enabled = false;
            }

            if (cboTipoReporte.Text == "Reporte General")
            {
                
                iN_R_ExistenciasTableAdapter.Fill(dsInventarioAdiggm.IN_R_Existencias, IdCatProducto, idproducto, idvehiculo, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvInv.RefreshReport();
                rvInv.SetDisplayMode(DisplayMode.PrintLayout);
                rvInv.ZoomMode = ZoomMode.PageWidth;
                rvInv.Dock = DockStyle.Fill;
                rvInv.Visible = true;
                rvExistencias.Visible = false;
                this.rvInv.RefreshReport();
            }
            else if (cboTipoReporte.Text == "Reporte de Existencias")
            {             
                iN_R_ProductosExistenciaTableAdapter.Fill(dsInventarioAdiggm.IN_R_ProductosExistencia, IdCatProducto, idproducto, chkSoloExistencias.Checked, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvExistencias.RefreshReport();
                rvExistencias.SetDisplayMode(DisplayMode.PrintLayout);
                rvExistencias.ZoomMode = ZoomMode.PageWidth;
                rvExistencias.Dock = DockStyle.Fill;
                rvInv.Visible = false;
                rvExistencias.Visible = true;
                this.rvExistencias.RefreshReport();
            }
        }

        private void chkCat_CheckedChanged(object sender, EventArgs e)
        {
            int IdCatProducto = 0, idproducto = 0, idvehiculo = 0;

            if (chkCat.Checked == true)
            {
                cboCategorias.Enabled = true;
                IdCatProducto = int.Parse(cboCategorias.SelectedValue.ToString());
            }
            else
            {
                cboCategorias.Enabled = false;
            }

            if (chkFiltroProd.Checked == true)
            {
                cboCategorias.Enabled = true;
                chkFiltroProd.Checked = true;
                cboProductos.Enabled = true;
                if (cboCategorias.SelectedIndex != -1)
                    idproducto = int.Parse(cboProductos.SelectedValue.ToString());
            }
            else
            {
                cboProductos.Enabled = false;
                chkFiltroProd.Checked = false;
            }

            if (chkFiltroVeh.Checked == true)
            {
                cboVehiculos.Enabled = true;
                idvehiculo = int.Parse(cboVehiculos.SelectedValue.ToString());
            }
            else
            {
                cboVehiculos.Enabled = false;
            }

            if (cboTipoReporte.Text == "Reporte General")
            {                
                iN_R_ExistenciasTableAdapter.Fill(dsInventarioAdiggm.IN_R_Existencias, IdCatProducto, idproducto, idvehiculo, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvInv.RefreshReport();
                rvInv.SetDisplayMode(DisplayMode.PrintLayout);
                rvInv.ZoomMode = ZoomMode.PageWidth;
                rvInv.Dock = DockStyle.Fill;
                rvInv.Visible = true;
                rvExistencias.Visible = false;
                this.rvInv.RefreshReport();
            }
            else if (cboTipoReporte.Text == "Reporte de Existencias")
            {
                iN_R_ProductosExistenciaTableAdapter.Fill(dsInventarioAdiggm.IN_R_ProductosExistencia, IdCatProducto, idproducto, chkSoloExistencias.Checked, dtpFechaDesde.Value, dtpFechaHasta.Value);
                rvExistencias.RefreshReport();
                rvExistencias.SetDisplayMode(DisplayMode.PrintLayout);
                rvExistencias.ZoomMode = ZoomMode.PageWidth;
                rvExistencias.Dock = DockStyle.Fill;
                rvInv.Visible = false;
                rvExistencias.Visible = true;
                this.rvExistencias.RefreshReport();
            }
        }

        private void cboTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoReporte.Text == "Reporte de Existencias")
            {
                chkSoloExistencias.Enabled = true;
                chkSoloExistencias.Checked = false;
                chkFiltroVeh.Checked = false;
                chkFiltroVeh.Enabled = false;
                cboVehiculos.Enabled = false;
            }
            else
            {
                chkSoloExistencias.Enabled = false;
                chkSoloExistencias.Checked = false;
            }
        }
    }
}
