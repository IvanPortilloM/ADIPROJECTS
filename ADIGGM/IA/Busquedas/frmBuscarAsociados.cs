using ADIGGM.Formularios_Base;
using ADIGGM.IA.Transaccionales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.IA.Busquedas
{
    public partial class frmBuscarAsociados : FrmPrincipal
    {
        public frmBuscarAsociados()
        {
            InitializeComponent();
        }
        private frmInformacionAsoc informacionAsoc;
        private void frmBuscarAsociados_Load(object sender, EventArgs e)
        {
            cboOperador.SelectedIndex = 1;
            cboOrdenBusqueda.SelectedIndex = 0;
            txtBusqueda.Focus();
            cargarDgv();
        }
        private void ordenar()
        {
            if (cboOrdenBusqueda.Text == "DNI")
            {
                if (rdbAscendente.Checked == true)
                {
                    dgvAsociados.Sort(dgvAsociados.Columns[0], ListSortDirection.Ascending);
                }
                else
                    dgvAsociados.Sort(dgvAsociados.Columns[0], ListSortDirection.Descending);
            }
            else
            {
                if (rdbAscendente.Checked == true)
                {
                    dgvAsociados.Sort(dgvAsociados.Columns[1], ListSortDirection.Ascending);
                }
                else
                    dgvAsociados.Sort(dgvAsociados.Columns[1], ListSortDirection.Descending);
            }
        }
        private void cargarDgv()
        {
            this.cA_BuscarAsocTableAdapter.Fill(this.dsCA.CA_BuscarAsoc, txtBusqueda.Text, cboOrdenBusqueda.Text, cboOperador.Text, Convert.ToInt32(nudRegistros.Value));
            ordenar();
        }
        private void rdbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            ordenar();
        }
        private void rdbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            ordenar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cargarDgv();
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                cargarDgv();
                e.Handled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmInformacionAsoc"] != null)
            {
                Application.OpenForms["frmInformacionAsoc"].Close();
                informacionAsoc = new frmInformacionAsoc(Convert.ToString(dgvAsociados.Rows[dgvAsociados.CurrentRow.Index].Cells["cidasociad"].Value.ToString()));
                informacionAsoc.ShowDialog(); 
            }
            else
            {
                frmInformacionAsoc informacionAsoc = new frmInformacionAsoc(Convert.ToString(dgvAsociados.Rows[dgvAsociados.CurrentRow.Index].Cells["cidasociad"].Value.ToString()));
                //this.Hide();
                informacionAsoc.ShowDialog();
            }
        }

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtBusqueda.Text != "")
                {
                    e.Handled = true; 
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void dgvAsociados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //DataGridViewRow row = ((DataGridView)sender).CurrentRow;
                //string valorPrimerCelda = Convert.ToString(row.Cells[0].Value);
                //e.Handled = true;
                btnAceptar.PerformClick();
            }
        }
    }
}
