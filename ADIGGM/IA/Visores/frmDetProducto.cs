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
            ConfigurarColumnas();
            this.cdesdeducc = cdesdeducc;
            this.cidasociad = cidasociad;
            this.ccoddeducc = ccoddeducc;
            this.cnumdeducc = cnumdeducc;
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para que el diseñador de VS no las borre
        /// — gotcha §11. Visor de solo lectura (movimientos del producto).</summary>
        private void ConfigurarColumnas()
        {
            dgvDetProd.AutoGenerateColumns = false;
            dgvDetProd.Columns.Clear();
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("dfechamovi", "dfechamovi", "Fecha", width: 66));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("nnumconsec", "nnumconsec", "Recibo", width: 70));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("nmontomovi", "nmontomovi", "Monto", format: "N2", width: 68));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("nintermovi", "nintermovi", "Interés", format: "N2", width: 67));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("nmtocargos", "nmtocargos", "Cargos", width: 70));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("ncomisinte", "ncomisinte", "Comisión", format: "N2", width: 80));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("nsaldprinc", "nsaldprinc", "Saldo", format: "N2", width: 63));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("nporctasa", "nporctasa", "Tasa", format: "N2", width: 57));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("cnumrecibo", "cnumrecibo", "Recibo.Caja"));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("cnumasient", "cnumasient", "Asiento", width: 70));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("ctipasient", "ctipasient", "Tip.Asi.", width: 66));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("ctipasient1", "ctipasient1", "ctipasient1", visible: false));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("ccodmovimi", "ccodmovimi", "Cod.Mov.", width: 88));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("cnombretip", "cnombretip", "Desc.Mov.", width: 90));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("corigmovim", "corigmovim", "Cod.Origen", width: 95));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("cdescmovim", "cdescmovim", "Desc.Origen", width: 97));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("cnomusuari", "cnomusuari", "Usuario", width: 71));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("cnumoperac", "cnumoperac", "Referencia", width: 90));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("cctabancar", "cctabancar", "Cta.Bancaria", width: 105));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("nnumdocume", "nnumdocume", "Documento", width: 96));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("ctipodocum", "ctipodocum", "Tipo.Docum.", width: 99));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("cnumdeducc1", "cnumdeducc", "cnumdeducc", visible: false));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("cdescrip01", "cdescrip01", "cdescrip01", visible: false));
            dgvDetProd.Columns.Add(Clases.GridColumnas.Texto("cdescrip02", "cdescrip02", "cdescrip02", visible: false));
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
