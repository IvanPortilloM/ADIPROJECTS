using System;

namespace ADIGGM.OC.Visores
{
    public partial class VisOCCodeasDet : ADIGGM.FrmPrincipal
    {
        decimal monto;
        string numOrden, vehi, IdCatPro;
        int idOC, idVeh;

        public VisOCCodeasDet(string numOrden, string vehi, int idVeh, decimal monto, int idOC, string IdCatPro)
        {
            InitializeComponent();
            this.numOrden = numOrden;
            this.idVeh = idVeh;
            this.monto = monto;
            this.idOC = idOC;
            this.IdCatPro = IdCatPro;
            this.vehi = vehi;
        }

        private void VisOCCodeasDet_Load(object sender, EventArgs e)
        {
            lblMonto.Text = monto.ToString("N");
            lblNumOrden.Text = numOrden;
            lblVehiculo.Text = vehi;

            this.oC_OrdenTrabajoDetCODEASTableAdapter.Fill(dsOC.OC_OrdenTrabajoDetCODEAS, idVeh, idOC, IdCatPro);
        }
    }
}
