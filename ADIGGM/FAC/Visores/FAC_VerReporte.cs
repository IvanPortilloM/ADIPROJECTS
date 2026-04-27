namespace ADIGGM.FAC.Visores
{
    using ADIGGM.Clases;
    using Microsoft.Reporting.WinForms;
    using System;
    public partial class FAC_VerReporte : FrmPrincipal
    {
        int IdFactura, NumReporte;
        DateTime fecha1, fecha2;
        string TipoFac;

        string usuarioDominio = "Administrator";
        string claveDominio = "camaron+2016";
        string dominio = "";
        public FAC_VerReporte(int IdFactura, int NumReporte, DateTime fecha1, DateTime fecha2, string TipoFac)
        {
            InitializeComponent();
            this.IdFactura = IdFactura;
            this.NumReporte = NumReporte;
            this.fecha1 = fecha1;
            this.fecha2 = fecha2;
            this.TipoFac = TipoFac;
        }

        private void FAC_VerReporte_Load(object sender, EventArgs e)
        {
            if (NumReporte == 1)
            {
                rvFAC.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                rvFAC.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "FAC_Factura";

                rvFAC.Visible = true;
                rvFAC.ShowParameterPrompts = true;
                rvFAC.ShowCredentialPrompts = false;

                rvFAC.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                ReportParameter[] parametros = new ReportParameter[1];
                parametros[0] = new ReportParameter("IdFactura", IdFactura.ToString());

                rvFAC.ServerReport.SetParameters(parametros);
                rvFAC.RefreshReport();
            }

            if (NumReporte == 2)
            {
                rvFAC.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                rvFAC.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "FAC_ReporteFacturas";

                rvFAC.Visible = true;
                rvFAC.ShowParameterPrompts = true;
                rvFAC.ShowCredentialPrompts = false;

                rvFAC.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                ReportParameter[] parametros = new ReportParameter[3];
                parametros[0] = new ReportParameter("Desde", fecha1.Date.ToString());
                parametros[1] = new ReportParameter("Hasta", fecha2.Date.ToString());
                parametros[2] = new ReportParameter("IdTipoFactura", IdFactura.ToString());

                rvFAC.ServerReport.SetParameters(parametros);
                rvFAC.RefreshReport();
            }

            if (NumReporte == 3)
            {
                rvFAC.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                rvFAC.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "FAC_ReporteFacturaCliente";

                rvFAC.Visible = true;
                rvFAC.ShowParameterPrompts = true;
                rvFAC.ShowCredentialPrompts = false;

                rvFAC.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                ReportParameter[] parametros = new ReportParameter[3];
                parametros[0] = new ReportParameter("Desde", fecha1.Date.ToString());
                parametros[1] = new ReportParameter("Hasta", fecha2.Date.ToString());
                parametros[2] = new ReportParameter("IdCliente", IdFactura.ToString());

                rvFAC.ServerReport.SetParameters(parametros);
                rvFAC.RefreshReport();
            }
            if (NumReporte == 4)
            {
                rvFAC.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
                rvFAC.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "FAC_Factura_v2";

                rvFAC.Visible = true;
                rvFAC.ShowParameterPrompts = true;
                rvFAC.ShowCredentialPrompts = false;

                rvFAC.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

                ReportParameter[] parametros = new ReportParameter[2];
                parametros[0] = new ReportParameter("IdFactura", IdFactura.ToString());
                parametros[1] = new ReportParameter("TipoFac", TipoFac.ToString());

                rvFAC.ServerReport.SetParameters(parametros);
                rvFAC.RefreshReport();
            }
        }
    }
}
