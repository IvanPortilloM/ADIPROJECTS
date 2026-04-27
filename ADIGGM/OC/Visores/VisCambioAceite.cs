using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.OC.Visores
{
    public partial class VisCambioAceite : ADIGGM.FrmPrincipal
    {
        public VisCambioAceite()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }
        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            this.oC_CambioAceiteVisorTableAdapter.Fill(this.dsOC.OC_CambioAceiteVisor, dtpDesde.Value.Date, dtpHasta.Value.Date);
        }

        private void dgvCambioAceite_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCambioAceite.Rows.Count > 0)
            {
                this.oC_CambioAceiteDetVisorTableAdapter.Fill(this.dsOC.OC_CambioAceiteDetVisor, int.Parse(dgvCambioAceite.CurrentRow.Cells["idCambioAceiteDGV"].Value.ToString()));
            }
        }
    }
}
