using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ADIGGM.Clases;
using System.Net;
using Twilio.Rest;

namespace ADIGGM.OC.Reportes
{
    public partial class TrazabilidadVehiculo : FrmPrincipal
    {
        string usuarioDominio = "Administrator";
        string claveDominio = "camaron+2016";
        string dominio = "";
        public TrazabilidadVehiculo()
        {
            InitializeComponent();
            
        }
        int FiltroFec;
        private void TrazabilidadVehiculo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_ProductosCategorias' Puede moverla o quitarla según sea necesario.
            oC_ProductosCategoriasTableAdapter.FillByTodos(this.dsOC.OC_ProductosCategorias);
            oC_ProductosTableAdapter.FillByTodos(this.dsOC.OC_Productos);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Proveedores' Puede moverla o quitarla según sea necesario.
            oC_ProveedoresTableAdapter.FillByTodos(this.dsOC.OC_Proveedores);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.TR_Vehiculos' Puede moverla o quitarla según sea necesario.
            tR_VehiculosTableAdapter.FillByTodos(this.dsOC.TR_Vehiculos);
            cboTipoReporte.SelectedIndex = 0;
            Dock = DockStyle.Fill;
            reportViewer3.RefreshReport();
        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            

            if (cboTipoReporte.Text == "General")
            {
                reportViewer1.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer1.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptTrazaVehiculo";
                reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = new NetworkCredential(usuarioDominio, claveDominio, dominio);

                reportViewer1.Dock = DockStyle.Fill;
                reportViewer2.Dock = DockStyle.None;
                reportViewer3.Dock = DockStyle.None;
                reportViewer4.Dock = DockStyle.None;
                reportViewer1.Visible = true;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                reportViewer4.Visible = false;
                reportViewer1.ShowParameterPrompts = false;
                reportViewer1.ShowCredentialPrompts = false;

                List<ReportParameter> parameters = new List<ReportParameter>
                {
                    new ReportParameter("FechaDesde", dtpFechaDesde.Value.Date.ToString("dd/MM/yyyy")),
                    new ReportParameter("FechaHasta", dtpFechaHasta.Value.Date.ToString("dd/MM/yyyy")),
                    new ReportParameter("IdVehiculo", cboVehiculo.SelectedValue.ToString()),
                    new ReportParameter("IdProveedor", cboProveedor.SelectedValue.ToString()),
                    new ReportParameter("FiltroFec", Convert.ToString(FiltroFec)),
                    new ReportParameter("IdProducto", cboProducto.SelectedValue.ToString())
                };

                reportViewer1.ServerReport.SetParameters(parameters);
                reportViewer1.RefreshReport();
            }else
                if (cboTipoReporte.Text == "Trazabilidad de Combustible")
            {
                reportViewer2.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer2.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptTrazabilidadCombustible"; 
                reportViewer2.ServerReport.ReportServerCredentials.NetworkCredentials = new NetworkCredential(usuarioDominio, claveDominio, dominio);

                reportViewer1.Dock = DockStyle.None;
                reportViewer2.Dock = DockStyle.Fill;
                reportViewer3.Dock = DockStyle.None;
                reportViewer4.Dock = DockStyle.None;
                reportViewer1.Visible = false;
                reportViewer2.Visible = true;
                reportViewer3.Visible = false;
                reportViewer4.Visible = false;
                reportViewer2.ShowParameterPrompts = false;
                reportViewer2.ShowCredentialPrompts = false;

                List<ReportParameter> parameters = new List<ReportParameter>
                {
                    new ReportParameter("IdVehiculo", cboVehiculo.SelectedValue.ToString()),
                    new ReportParameter("FechaInicio", dtpFechaDesde.Value.Date.ToString("dd/MM/yyyy")),
                    new ReportParameter("FechaFin", dtpFechaHasta.Value.Date.ToString("dd/MM/yyyy"))
                };

                reportViewer2.ServerReport.SetParameters(parameters);
                reportViewer2.RefreshReport();
            }else
                if (cboTipoReporte.Text == "Facturas por Proveedor")
            {
                reportViewer3.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer3.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptProveedoresOC";
                reportViewer3.ServerReport.ReportServerCredentials.NetworkCredentials = new NetworkCredential(usuarioDominio, claveDominio, dominio);

                reportViewer1.Dock = DockStyle.None;
                reportViewer2.Dock = DockStyle.None;
                reportViewer3.Dock = DockStyle.Fill;
                reportViewer4.Dock = DockStyle.None;
                reportViewer1.Visible = false;
                reportViewer2.Visible = false;
                reportViewer3.Visible = true;
                reportViewer4.Visible = false;
                reportViewer3.ShowParameterPrompts = false;
                reportViewer3.ShowCredentialPrompts = false;

                List<ReportParameter> parameters = new List<ReportParameter>
                {
                    new ReportParameter("IdProveedor", cboProveedor.SelectedValue.ToString()),
                    new ReportParameter("FechaInicio", dtpFechaDesde.Value.Date.ToString("dd/MM/yyyy")),
                    new ReportParameter("FechaFin", dtpFechaHasta.Value.Date.ToString("dd/MM/yyyy"))
                };

                reportViewer3.ServerReport.SetParameters(parameters);
                reportViewer3.RefreshReport();
            }
            else
                if (cboTipoReporte.Text == "Requisiciones")
            {
                reportViewer4.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer4.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptMantenimientos";
                reportViewer4.ServerReport.ReportServerCredentials.NetworkCredentials = new NetworkCredential(usuarioDominio, claveDominio, dominio);

                reportViewer1.Dock = DockStyle.None;
                reportViewer2.Dock = DockStyle.None;
                reportViewer3.Dock = DockStyle.None;
                reportViewer4.Dock = DockStyle.Fill;
                reportViewer1.Visible = false;
                reportViewer2.Visible = false;
                reportViewer3.Visible = false;
                reportViewer4.Visible = true;
                reportViewer4.ShowParameterPrompts = false;
                reportViewer4.ShowCredentialPrompts = false;

                List<ReportParameter> parameters = new List<ReportParameter>
                {
                    new ReportParameter("FechaDesde", dtpFechaDesde.Value.Date.ToString("dd/MM/yyyy")),
                    new ReportParameter("FechaHasta", dtpFechaHasta.Value.Date.ToString("dd/MM/yyyy")),
                    new ReportParameter("IdVehiculo", cboVehiculo.SelectedValue.ToString()),
                    new ReportParameter("IdProveedor", cboProveedor.SelectedValue.ToString()),
                    new ReportParameter("FiltroFec", Convert.ToString(FiltroFec)),
                    new ReportParameter("IdProducto", cboProducto.SelectedValue.ToString())
                };

                reportViewer4.ServerReport.SetParameters(parameters);
                reportViewer4.RefreshReport();
            }
        }

        private void cboTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {            
            cboVehiculo.Visible = false;
            label3.Visible = false;
            cboProveedor.Visible = false;
            label4.Visible = false;
            cboProducto.Visible = false;
            label6.Visible = false;
            cboCategoria.Visible = false;
            label7.Visible = false;

            if (cboTipoReporte.Text == "General")
            {
                label3.Visible = true;
                cboVehiculo.Visible = true;
                cboProveedor.Visible = true;
                label4.Visible = true;
                cboProducto.Visible = true;
                label6.Visible = true;
                cboCategoria.Visible = true;
                label7.Visible = true;
            }
            else
            if (cboTipoReporte.Text == "Facturas por Proveedor")
            {
                cboProveedor.Visible = true;
                label4.Visible = true;
            }
            else
            if (cboTipoReporte.Text == "Trazabilidad de Combustible")
            {
                cboVehiculo.Visible = true;
                label3.Visible = true;
            }
            else
            {
                label3.Visible = true;
                cboVehiculo.Visible = true;
                cboProveedor.Visible = true;
                label4.Visible = true;
            }
        }

        private void rdbFecElab_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFecElab.Checked == true)
            {
                FiltroFec = 1;
            }
            else
            {
                FiltroFec = 0;
            }
        }

        private void rdbFecConf_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFecConf.Checked == true)
            {
                FiltroFec = 0;
            }
            else
            {
                FiltroFec = 1;
            }
        }
    }
}
