using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADIGGM.CapaDatos;

namespace ADIGGM.IA.Visores
{
    public partial class frmDetProducto : FrmPrincipal
    {
        private readonly RepositorioCA _repo = new RepositorioCA();
        string cdesdeducc, cidasociad, ccoddeducc, cnumdeducc;

        private void btnObs_Click(object sender, EventArgs e)
        {
            if (dgvDetProd.CurrentRow == null)
                return;

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
            uSPSelCobrosCargarMovimientosProductosFilterBindingSource.DataMember = "";
            uSPSelCobrosCargarMovimientosProductosFilterBindingSource.DataSource = _repo.CargarMovimientosProducto(cidasociad, ccoddeducc, cnumdeducc);
            // El DataSource se asigna aquí y NO en el Designer: si el grid queda enlazado en
            // diseño, el diseñador de VS borra las columnas al no poder resolver el esquema.
            dgvDetProd.DataSource = uSPSelCobrosCargarMovimientosProductosFilterBindingSource;
        }
    }
}
