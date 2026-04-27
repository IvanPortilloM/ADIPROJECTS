using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using ADIGGM.Clases;

namespace ADIGGM.OC.Reportes
{
    public partial class VisualizarReporte : FrmPrincipal
    {
        int ID = 0;
        string fechaini, fechafin, codbanco, cuentabancaria, tipodoc, descripdetalle;

        string usuarioDominio = "Administrator";
        string claveDominio = "camaron+2016";
        string dominio = "";
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        int idtipoorden, idproveedor, numdoc;
        decimal monto;
        bool confirmadas;
        public VisualizarReporte(int ID, string fechaini,
                                         string fechafin,
                                         int idtipoorden,
                                         int idproveedor,
                                         string codbanco,
                                         string cuentabancaria,
                                         string tipodoc,
                                         int numdoc,
                                         decimal monto,
                                         string descripdetalle,
                                         bool confirmadas)
        {
            InitializeComponent();
            this.ID = ID;
            this.fechaini = fechaini;
            this.fechafin = fechafin;
            this.idtipoorden = idtipoorden;
            this.idproveedor = idproveedor;
            this.codbanco = codbanco;
            this.cuentabancaria = cuentabancaria;
            this.tipodoc = tipodoc;
            this.numdoc = numdoc;
            this.monto = monto;
            this.descripdetalle = descripdetalle;
            this.confirmadas = confirmadas;

        }

        private void VisualizarReporte_Load(object sender, EventArgs e)
        {        
            if (ID == 0)
            {
                reportViewer1.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer1.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptDetalleOrdenesCodeas";

                reportViewer1.Visible = true;
                reportViewer1.ShowParameterPrompts = false;
                reportViewer1.ShowCredentialPrompts = false;

                reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("FechaInicio", fechaini));
                parameters.Add(new ReportParameter("FechaFin", fechafin));
                parameters.Add(new ReportParameter("IdTipoOrden", idtipoorden.ToString()));
                parameters.Add(new ReportParameter("IdProveedor", idproveedor.ToString()));
                parameters.Add(new ReportParameter("CodBanco", codbanco));
                parameters.Add(new ReportParameter("CtaBancaria", cuentabancaria));
                parameters.Add(new ReportParameter("TipoDoc", tipodoc));
                parameters.Add(new ReportParameter("NumDoc", numdoc.ToString()));
                parameters.Add(new ReportParameter("Monto", monto.ToString()));
                parameters.Add(new ReportParameter("DescripDetalle", descripdetalle));
                parameters.Add(new ReportParameter("Confirmadas", confirmadas.ToString()));

                reportViewer1.ServerReport.SetParameters(parameters);
            }
            if (ID == -1)
            {
                reportViewer1.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer1.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptCuentasxPagar";

                reportViewer1.Visible = true;
                reportViewer1.ShowParameterPrompts = false;
                reportViewer1.ShowCredentialPrompts = false;

                reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("FechaDesde", fechaini));
                parameters.Add(new ReportParameter("FechaHasta", fechafin));
                parameters.Add(new ReportParameter("IdProveedor", idproveedor.ToString()));
                parameters.Add(new ReportParameter("Todos", confirmadas.ToString()));
                parameters.Add(new ReportParameter("Activa", numdoc.ToString()));

                reportViewer1.ServerReport.SetParameters(parameters);
            }
            if (ID > 0)
            {
                int tipoOC = int.Parse(VarGlobales.consultasOC.OC_TipoOrdenObtener2(ID).ToString());

                if (tipoOC == 1)
                {
                    reportViewer1.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                    reportViewer1.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptFacturaCombustible";

                    reportViewer1.Visible = true;
                    reportViewer1.ShowParameterPrompts = false;
                    reportViewer1.ShowCredentialPrompts = false;

                    reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials =
                        new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                    List<ReportParameter> parameters = new List<ReportParameter>();
                    parameters.Add(new ReportParameter("IdOC", ID.ToString()));

                    reportViewer1.ServerReport.SetParameters(parameters);
                }
                else
                {
                    reportViewer1.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                    reportViewer1.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptFacturaOC";

                    reportViewer1.Visible = true;
                    reportViewer1.ShowParameterPrompts = false;
                    reportViewer1.ShowCredentialPrompts = false;                    

                    reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials =
                        new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                    List<ReportParameter> parameters = new List<ReportParameter>();
                    parameters.Add(new ReportParameter("IdOC", ID.ToString()));

                    reportViewer1.ServerReport.SetParameters(parameters);
                }
            }

            if (ID == -2)
            {
                reportViewer1.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer1.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptAbonos";

                reportViewer1.Visible = true;
                reportViewer1.ShowParameterPrompts = false;
                reportViewer1.ShowCredentialPrompts = false;

                reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("FechaDesde", fechaini));
                parameters.Add(new ReportParameter("FechaHasta", fechafin));
                parameters.Add(new ReportParameter("IdProveedor", idproveedor.ToString()));
                parameters.Add(new ReportParameter("IdTipoDocumento", idtipoorden.ToString()));

                reportViewer1.ServerReport.SetParameters(parameters);
            }
            if (ID == -4)
            {
                reportViewer1.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer1.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptResumen";

                reportViewer1.Visible = true;
                reportViewer1.ShowParameterPrompts = false;
                reportViewer1.ShowCredentialPrompts = false;

                reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

            }
            if (ID == -3)
            {
                reportViewer1.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                reportViewer1.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "rptRegistroKardex";

                reportViewer1.Visible = true;
                reportViewer1.ShowParameterPrompts = false;
                reportViewer1.ShowCredentialPrompts = false;

                reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                List<ReportParameter> parameters = new List<ReportParameter>();
                parameters.Add(new ReportParameter("IdKardexHeader", numdoc.ToString()));

                reportViewer1.ServerReport.SetParameters(parameters);
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
