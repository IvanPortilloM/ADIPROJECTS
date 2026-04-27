using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.IA.Visores
{
    public partial class frmDetProducto : FrmPrincipal
    {
        string cdesdeducc, cidasociad, ccoddeducc, cnumdeducc;

        private void btnObs_Click(object sender, EventArgs e)
        {
            frmObsProducto obsProducto = new frmObsProducto(Convert.ToString(dgvDetProd.Rows[dgvDetProd.CurrentRow.Index].Cells["cnumasient"].Value.ToString()),
                                                            Convert.ToString(dgvDetProd.Rows[dgvDetProd.CurrentRow.Index].Cells["ctipasient"].Value.ToString()));
            //this.Hide();
            obsProducto.ShowDialog();
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmDetProducto(string cdesdeducc, string cidasociad, string ccoddeducc, string cnumdeducc)
        {
            InitializeComponent();
            this.cdesdeducc = cdesdeducc;
            this.cidasociad = cidasociad;
            this.ccoddeducc = ccoddeducc;
            this.cnumdeducc = cnumdeducc;
        }

        private void frmDetProducto_Load(object sender, EventArgs e)
        {
            txtcdesdeducc.Text = cdesdeducc;
            cargarDgv();
        }
        private void cargarDgv()
        {
            this.uSP_Sel_Cobros_CargarMovimientosProductos_FilterTableAdapter.Fill(this.dsCA.USP_Sel_Cobros_CargarMovimientosProductos_Filter, cidasociad, ccoddeducc, cnumdeducc);
        }
    }
}
