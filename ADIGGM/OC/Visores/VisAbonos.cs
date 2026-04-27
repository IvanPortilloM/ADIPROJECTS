using System;
using System.Windows.Forms;

namespace ADIGGM.OC.Visores
{
    public partial class VisAbonos : ADIGGM.FrmPrincipal
    {
        public VisAbonos()
        {
            InitializeComponent();
        }

        private void VisAbonos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Proveedores' Puede moverla o quitarla según sea necesario.
            this.oC_ProveedoresTableAdapter.FillByTodos(this.dsOC.OC_Proveedores);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.CP_TipoDocumentos' Puede moverla o quitarla según sea necesario.
            this.cP_TipoDocumentosTableAdapter.FillByTodos(this.dsOC.CP_TipoDocumentos);

            this.cP_AbonosVisorTableAdapter.Fill(dsOC.CP_AbonosVisor, int.Parse(cboTipoDoc.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()), dtpDesde.Value.Date, dtpHasta.Value.Date);
            if (dgvAbonos.Rows.Count > 0)
            {
                this.cP_AbonosDetTableAdapter.Fill(dsOC.CP_AbonosDet, int.Parse(dgvAbonos.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            this.cP_AbonosVisorTableAdapter.Fill(dsOC.CP_AbonosVisor, int.Parse(cboTipoDoc.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()), dtpDesde.Value.Date, dtpHasta.Value.Date);

            if (dgvAbonos.Rows.Count > 0)
            {
                this.cP_AbonosDetTableAdapter.Fill(dsOC.CP_AbonosDet, int.Parse(dgvAbonos.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea anular este abono?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clases.VarGlobales.consultasOC.OC_AbonosAnular(int.Parse(dgvAbonos.CurrentRow.Cells[0].Value.ToString()), Clases.VarGlobales.Usuario, Environment.MachineName);

                this.cP_AbonosVisorTableAdapter.Fill(dsOC.CP_AbonosVisor, int.Parse(cboTipoDoc.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()), dtpDesde.Value.Date, dtpHasta.Value.Date);
                if (dgvAbonos.Rows.Count > 0)
                {
                    this.cP_AbonosDetTableAdapter.Fill(dsOC.CP_AbonosDet, int.Parse(dgvAbonos.CurrentRow.Cells[0].Value.ToString()));
                }
            }
        }

        private void dgvAbonos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAbonos.Rows.Count > 0)
            {
                this.cP_AbonosDetTableAdapter.Fill(dsOC.CP_AbonosDet, int.Parse(dgvAbonos.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.VisualizarReporte reporte = new Reportes.VisualizarReporte(-2,
                                                                               dtpDesde.Value.Date.ToString(),
                                                                               dtpHasta.Value.Date.ToString(),
                                                                               int.Parse(cboTipoDoc.SelectedValue.ToString()),
                                                                               int.Parse(cboProveedor.SelectedValue.ToString()),
                                                                               "",
                                                                               "",
                                                                               "",
                                                                               0,
                                                                               0,
                                                                               "",
                                                                               true);
            reporte.ShowDialog();
        }
    }
}
