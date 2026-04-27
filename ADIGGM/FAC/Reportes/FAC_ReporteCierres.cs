using ADIGGM.Clases;
using Microsoft.Reporting.WinForms;
using System;

namespace ADIGGM.FAC.Reportes
{
    public partial class FAC_ReporteCierres : FrmPrincipal
    {
        string usuarioDominio = "Administrator";
        string claveDominio = "camaron+2016";
        string dominio = "";
        public FAC_ReporteCierres()
        {
            InitializeComponent();
        }

        private void FAC_ReporteCierres_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsFAC.FAC_FincasGGM' Puede moverla o quitarla según sea necesario.
            this.fAC_FincasGGMTableAdapter.Fill(this.dsFAC.FAC_FincasGGM);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            rvFAC.ServerReport.ReportServerUrl = new Uri(VarGlobales.urlReportes);
            rvFAC.ServerReport.ReportPath = VarGlobales._gCarpetaReportes + "FAC_ReporteCierreFincas";

            rvFAC.Visible = true;
            rvFAC.ShowParameterPrompts = true;
            rvFAC.ShowCredentialPrompts = false;

            rvFAC.ServerReport.ReportServerCredentials.NetworkCredentials =
                    new System.Net.NetworkCredential(usuarioDominio, claveDominio, dominio);

            ReportParameter[] parametros = new ReportParameter[3];
            parametros[0] = new ReportParameter("IdCliente", cboCliente.SelectedValue.ToString());
            parametros[1] = new ReportParameter("FechaDesde", dtpDesde.Value.ToString());
            parametros[2] = new ReportParameter("FechaHasta", dtpHasta.Value.ToString());

            rvFAC.ServerReport.SetParameters(parametros);
            rvFAC.RefreshReport();
        }
    }
}
