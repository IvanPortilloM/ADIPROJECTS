using ADIGGM.Formularios_Base;
using ADIGGM.IA.Transaccionales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ADIGGM.CapaDatos;

namespace ADIGGM.IA.Busquedas
{
    public partial class frmBuscarAsociados : FrmPrincipal
    {
        private readonly RepositorioCA _repo = new RepositorioCA();
        public frmBuscarAsociados()
        {
            InitializeComponent();
            ConfigurarColumnas();
        }

        /// <summary>Columnas del grid EN CÓDIGO (no en el Designer) para que el diseñador de VS no las borre
        /// — gotcha §11. Visor de búsqueda (solo lectura); orden preservado (Sort usa Columns[0]/[1];
        /// Aceptar lee Cells["cidasociad"]). 23 columnas ocultas (header = nombre de campo).</summary>
        private void ConfigurarColumnas()
        {
            dgvAsociados.AutoGenerateColumns = false;
            dgvAsociados.Columns.Clear();
            dgvAsociados.Columns.Add(Clases.GridColumnas.Texto("cidasociad", "cidasociad", "Identificación"));
            dgvAsociados.Columns.Add(Clases.GridColumnas.Texto("cnombreasoDataGridViewTextBoxColumn", "cnombreaso", "Nombre", autoSize: DataGridViewAutoSizeColumnMode.Fill));
            dgvAsociados.Columns.Add(Clases.GridColumnas.Texto("ccedulasocDataGridViewTextBoxColumn", "ccedulasoc", "DNI"));
            dgvAsociados.Columns.Add(Clases.GridColumnas.Texto("dfechaingaDataGridViewTextBoxColumn", "dfechainga", "dfechainga", visible: false));
            dgvAsociados.Columns.Add(Clases.GridColumnas.Texto("dfechasaliDataGridViewTextBoxColumn", "dfechasali", "dfechasali", visible: false));
            dgvAsociados.Columns.Add(Clases.GridColumnas.Texto("cnombcondaDataGridViewTextBoxColumn", "cnombconda", "Estátus"));
            foreach (var p in new[] { "cnombinsti", "cnombdepto", "cnombdivis", "cnombtipop", "cteletraba", "ctelecelul", "cextentrab", "cteledomic", "cdireccaso", "dfechanaci", "nsalarioas", "nsalarione", "cmuestclav", "dfechaingc", "cconoccomo", "cemailasoc", "anios", "meses", "dias", "cnombrecom", "ccoddelega", "cnombredel" })
                dgvAsociados.Columns.Add(Clases.GridColumnas.Texto(p + "DataGridViewTextBoxColumn", p, p, visible: false));
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
            cABuscarAsocBindingSource.DataMember = "";
            cABuscarAsocBindingSource.DataSource = _repo.BuscarAsociados(txtBusqueda.Text, cboOrdenBusqueda.Text, cboOperador.Text, Convert.ToInt32(nudRegistros.Value));
            // El DataSource se asigna aquí y NO en el Designer: si el grid queda enlazado en
            // diseño, el diseñador de VS borra las columnas al no poder resolver el esquema.
            dgvAsociados.DataSource = cABuscarAsocBindingSource;
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
            if (dgvAsociados.CurrentRow == null)
                return;

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
