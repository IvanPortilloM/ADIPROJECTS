using System;
using System.Windows.Forms;

namespace ADIGGM.OC.Visores
{
    public partial class VisOCConfirmadas : FrmPrincipal
    {
        public VisOCConfirmadas()
        {
            InitializeComponent();
        }

        private void VisOCConfirmadas_Load(object sender, EventArgs e)
        {
            this.oC_ProveedoresTableAdapter.FillByTodos(this.dsOC.OC_Proveedores);
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_TipoOC' Puede moverla o quitarla según sea necesario.
            this.oC_TipoOCTableAdapter.FillByTodos(this.dsOC.OC_TipoOC);

            this.oC_OrdenTrabajoConfirVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoConfirVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));

            if (dgvOC.Rows.Count > 0)
            {
                this.oC_OrdenTrabajoDetConfirVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetConfirVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            this.oC_OrdenTrabajoConfirVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoConfirVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));

            if (dgvOC.Rows.Count > 0)
            {
                this.oC_OrdenTrabajoDetConfirVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetConfirVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
            }
        }

        private void dgvOC_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOC.Rows.Count > 0)
            {
                this.oC_OrdenTrabajoDetConfirVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetConfirVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
            }
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea anular esta Orden?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Clases.VarGlobales.consultasOC.OC_OrdenTrabajoAnular(int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()), Clases.VarGlobales.Usuario, Environment.MachineName);

                this.oC_OrdenTrabajoConfirVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoConfirVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));
                if (dgvOC.Rows.Count > 0)
                {
                    this.oC_OrdenTrabajoDetConfirVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetConfirVisor, int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()));
                }
                else
                {
                    this.oC_OrdenTrabajoDetConfirVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetConfirVisor, 0);
                }
            }
        }

        private void dgvOC_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvOC.Rows.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (bool.Parse(this.dgvOC.CurrentRow.Cells["anulado"].Value.ToString()) == true)
                    {
                        contextMenuStrip1.Items[0].Visible = false;
                        contextMenuStrip1.Items[1].Visible = false;
                    }
                    else
                    {
                        contextMenuStrip1.Items[0].Visible = true;
                        contextMenuStrip1.Items[1].Visible = false;
                    }
                }
            }
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.VisualizarReporte reporte = new Reportes.VisualizarReporte(int.Parse(dgvOC.CurrentRow.Cells["IdOC"].Value.ToString()),
                                                                               dtpDesde.Value.Date.ToString(),
                                                                               dtpHasta.Value.Date.ToString(),
                                                                               0,
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

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
