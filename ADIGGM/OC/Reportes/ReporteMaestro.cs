using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using ADIGGM.Clases;

namespace ADIGGM.OC.Reportes
{
    public partial class ReporteMaestro : ADIGGM.FrmPrincipal
    {
        string usuarioDominio = "Administrator";
        string claveDominio = "camaron+2016";
        string dominio = "";
        public ReporteMaestro()
        {
            InitializeComponent();
        }

        private void ReporteMaestro_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_ProductosCategorias' Puede moverla o quitarla según sea necesario.
            this.oC_ProductosCategoriasTableAdapter.FillByTodos(this.dsOC.OC_ProductosCategorias);
            txtProveedores.Enabled = true;
            rdbProveedores.Checked = true;
            this.reportViewer1.RefreshReport();
        }

        private void rdbProveedores_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProveedores.Checked == true)
            {
                txtProveedores.Enabled = true;
            }
            else
            {
                txtProveedores.Enabled = false;
            }

        }

        private void rdbProductos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProductos.Checked == true)
            {
                cboCategoria.Enabled = true;
            }
            else
            {
                cboCategoria.Enabled = false;
            }
        }

        private void rdbAsignacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAsignacion.Checked == true)
            {
                cboCategoria.Enabled = true;
            }
            else
            {
                cboCategoria.Enabled = false;
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {       
            if (rdbProveedores.Checked == true)
            {
                reportViewer1.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer1.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptProveedores";

                reportViewer1.Visible = true;
                reportViewer1.ShowParameterPrompts = false;
                reportViewer1.ShowCredentialPrompts = false;

                reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("Filtro", txtProveedores.Text));

                reportViewer1.ServerReport.SetParameters(parameters);
            }
            if (rdbProductos.Checked == true)
            {
                reportViewer1.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer1.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptProductos";

                reportViewer1.Visible = true;
                reportViewer1.ShowParameterPrompts = false;
                reportViewer1.ShowCredentialPrompts = false;

                reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("IdCategoria", (cboCategoria.SelectedValue.ToString())));

                reportViewer1.ServerReport.SetParameters(parameters);
            }
            if (rdbAsignacion.Checked == true)
            {
                reportViewer1.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer1.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptAsignacionCuentas";

                reportViewer1.Visible = true;
                reportViewer1.ShowParameterPrompts = false;
                reportViewer1.ShowCredentialPrompts = false;

                reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("IdCategoria", (cboCategoria.SelectedValue.ToString())));

                reportViewer1.ServerReport.SetParameters(parameters);
            }


            this.reportViewer1.RefreshReport();
        }
    }
}
