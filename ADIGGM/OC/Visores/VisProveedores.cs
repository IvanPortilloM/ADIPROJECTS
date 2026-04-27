using System;
using System.Windows.Forms;

namespace ADIGGM.OC.Visores
{
    public partial class VisProveedores : ADIGGM.FrmPrincipal
    {
        public VisProveedores()
        {
            InitializeComponent();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvProveedores);
        }

        private void VisProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Proveedores' Puede moverla o quitarla según sea necesario.
            this.oC_ProveedoresTableAdapter.FillBy(this.dsOC.OC_Proveedores, txtNombre.Text);

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.oC_ProveedoresTableAdapter.FillBy(this.dsOC.OC_Proveedores, txtNombre.Text);
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedores.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                if (e.ColumnIndex == dgvProveedores.Columns["Modificar"].Index)
                {
                    OC.Mantenimiento.ManProveedores proveedores = new Mantenimiento.ManProveedores(int.Parse(dgvProveedores.CurrentRow.Cells[0].Value.ToString()));
                    proveedores.ShowDialog(this);
                    this.oC_ProveedoresTableAdapter.FillBy(this.dsOC.OC_Proveedores, txtNombre.Text);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            OC.Mantenimiento.ManProveedores proveedores = new Mantenimiento.ManProveedores(0);
            proveedores.ShowDialog(this);
            this.oC_ProveedoresTableAdapter.FillBy(this.dsOC.OC_Proveedores, txtNombre.Text);
        }
    }
}
