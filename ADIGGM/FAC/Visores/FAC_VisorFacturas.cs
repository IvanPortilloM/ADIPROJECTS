using ADIGGM.CapaDatos;
using ADIGGM.FAC.Transacciones;
using System;
using System.Windows.Forms;

namespace ADIGGM.FAC.Visores
{
    public partial class FAC_VisorFacturas : FrmPrincipal
    {
        private readonly RepositorioFAC _repo = new RepositorioFAC();

        public FAC_VisorFacturas()
        {
            InitializeComponent();
        }

        private void FAC_VisorFacturas_Load(object sender, EventArgs e)
        {
            // Combos con fila "Todos"
            fACTipoFacturasBindingSource.DataMember = "";
            fACTipoFacturasBindingSource.DataSource = _repo.ListarTipoFacturasConTodos();
            cboTipoFactura.DataSource = fACTipoFacturasBindingSource;
            tRClientesBindingSource.DataMember = "";
            tRClientesBindingSource.DataSource = _repo.ListarClientesConTodos();
            cboCliente.DataSource = tRClientesBindingSource;

            // Grids: el DataSource se asigna aquí y NO en el Designer (gotcha del diseñador de VS)
            dgvFactura.DataSource = fACFacturasVisorBindingSource;
            dgvFacturaDet.DataSource = fACFacturaDetVisorBindingSource;

            RefrescarFacturas();

            // El textbox de observaciones se enlazaba en el Designer contra el BindingSource del
            // maestro; sin DataSet de diseño debe enlazarse en runtime tras cargar los datos.
            txtObservaciones.DataBindings.Clear();
            txtObservaciones.DataBindings.Add(new Binding("Text", this.fACFacturasVisorBindingSource, "Observaciones", true));

            CargarDetalleSegunSeleccion();
        }

        private void RefrescarFacturas()
        {
            fACFacturasVisorBindingSource.DataMember = "";
            fACFacturasVisorBindingSource.DataSource = _repo.ListarFacturasVisor(
                dtpDesde.Value.Date, dtpHasta.Value.Date,
                int.Parse(cboTipoFactura.SelectedValue.ToString()),
                int.Parse(cboCliente.SelectedValue.ToString()),
                txtFiltro.Text);
        }

        private void CargarDetalle(int idFactura)
        {
            fACFacturaDetVisorBindingSource.DataMember = "";
            fACFacturaDetVisorBindingSource.DataSource = _repo.ListarFacturaDetVisor(idFactura);
        }

        private void CargarDetalleSegunSeleccion()
        {
            if (dgvFactura.Rows.Count > 0)
                CargarDetalle(int.Parse(dgvFactura.CurrentRow.Cells[0].Value.ToString()));
            else
                CargarDetalle(0);
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            RefrescarFacturas();
            CargarDetalleSegunSeleccion();
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RefrescarFacturas();
                CargarDetalleSegunSeleccion();
            }
        }

        private void dgvOC_SelectionChanged(object sender, EventArgs e)
        {
            CargarDetalleSegunSeleccion();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FAC_Factura tran = new FAC_Factura();
            tran.ShowDialog(this);
            RefrescarFacturas();
            CargarDetalleSegunSeleccion();
        }

        private void dgvFactura_MouseDown(object sender, MouseEventArgs e)
        {
            if (dgvFactura.Rows.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (bool.Parse(this.dgvFactura.CurrentRow.Cells[6].Value.ToString()) == true)
                    {
                        contextMenuStrip1.Items[0].Visible = false;
                        contextMenuStrip1.Items[1].Visible = false;
                        contextMenuStrip1.Items[2].Visible = false;
                    }
                    else
                    {
                        contextMenuStrip1.Items[0].Visible = true;
                        contextMenuStrip1.Items[1].Visible = true;
                        if (this.dgvFactura.CurrentRow.Cells["tipoFactura"].Value.ToString() == "Factura Transporte")
                            contextMenuStrip1.Items[2].Visible = true;
                        else
                            contextMenuStrip1.Items[2].Visible = false;
                    }
                }
            }
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro desea anular esta Factura?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _repo.AnularFactura(int.Parse(dgvFactura.CurrentRow.Cells[0].Value.ToString()), Clases.VarGlobales.Usuario);

                RefrescarFacturas();
                CargarDetalleSegunSeleccion();
            }
        }

        private void verFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAC_VerReporte tran = new FAC_VerReporte(int.Parse(dgvFactura.CurrentRow.Cells[0].Value.ToString()), 1, dtpDesde.Value, dtpHasta.Value, "");
            tran.ShowDialog();
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            FAC_VerReporte tran = new FAC_VerReporte(int.Parse(cboTipoFactura.SelectedValue.ToString()), 2, dtpDesde.Value, dtpHasta.Value, "");
            tran.ShowDialog();
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            FAC_VerReporte tran = new FAC_VerReporte(int.Parse(cboCliente.SelectedValue.ToString()), 3, dtpDesde.Value, dtpHasta.Value, "");
            tran.ShowDialog();
        }

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAC_ActualizarDatos tran = new FAC_ActualizarDatos(int.Parse(dgvFactura.CurrentRow.Cells[0].Value.ToString()));
            tran.ShowDialog();
        }

        private void verFacturaCondescipcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAC_VerReporte tran = new FAC_VerReporte(int.Parse(dgvFactura.CurrentRow.Cells[0].Value.ToString()), 4, dtpDesde.Value, dtpHasta.Value, "Facturación de Camiones y Cabezales");
            tran.ShowDialog();
        }
    }
}
