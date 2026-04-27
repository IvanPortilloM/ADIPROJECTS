using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.PRESUPUESTO.Visores
{
    public partial class frmVisorPresupuesto : Form
    {
        int selectedIndex;
        public frmVisorPresupuesto()
        {
            InitializeComponent();
        }

        private void frmVisorPresupuesto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Anios' Puede moverla o quitarla según sea necesario.
            this.pR_AniosTableAdapter.Fill(this.dsPresupuesto.PR_Anios);
            // TODO: esta línea de código carga datos en la tabla 'dsPresupuesto.PR_Departamentos' Puede moverla o quitarla según sea necesario.
            this.pR_DepartamentosTableAdapter.FillByUsuario(this.dsPresupuesto.PR_Departamentos, Clases.VarGlobales.IdUsuario);
            if (cboDepartamento.SelectedIndex != -1)
            {
                this.pR_VisorPresupuestoTableAdapter.Fill(this.dsPresupuesto.PR_VisorPresupuesto, Convert.ToInt32(cboDepartamento.SelectedValue.ToString()));
            }
            CargarDgv();
        }
        private void CargarDgv()
        {
            try
            {
                if (cboDepartamento.SelectedIndex != -1)
                {
                    this.pR_VisorPresupuestoTableAdapter.Fill(this.dsPresupuesto.PR_VisorPresupuesto, Convert.ToInt32(cboDepartamento.SelectedValue.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarDgv();
        }

        private void dgvPresupuesto_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgvPresupuesto.Rows.Count > 0)
                {
                   contextMenuStrip1.Items[0].Visible = true;
                   contextMenuStrip1.Items[1].Visible = true;
                }
                else
                {
                   contextMenuStrip1.Items[0].Visible = false;
                   contextMenuStrip1.Items[1].Visible = false;
                }
            }
        }

        private void verPresupuestoSemanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPresupuesto.Rows.Count > 0)
            {
                selectedIndex = dgvPresupuesto.CurrentRow.Index;
                Transaccionales.frmPresupuestoSem presupuestoSem = new Transaccionales.frmPresupuestoSem(int.Parse(dgvPresupuesto.CurrentRow.Cells["idPresupuesto"].Value.ToString()), Convert.ToInt32(cboDepartamento.SelectedValue.ToString()));
                presupuestoSem.ShowDialog(this);
                //    this.oC_OrdenTrabajoVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoVisor, dtpDesde.Value.Date, dtpHasta.Value.Date, int.Parse(cboTipoOC.SelectedValue.ToString()), int.Parse(cboProveedor.SelectedValue.ToString()));

                //    dgvOC.CurrentCell = dgvOC.Rows[selectedIndex].Cells[1];
                //    this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, int.Parse(dgvOC.CurrentRow.Cells[0].Value.ToString()));
                //}
                //else
                //{
                //    this.oC_OrdenTrabajoDetVisorTableAdapter.Fill(this.dsOC.OC_OrdenTrabajoDetVisor, 0);
                //}
            }
        }

        private void verSueldosYSalariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPresupuesto.Rows.Count > 0)
            {
                selectedIndex = dgvPresupuesto.CurrentRow.Index;
                Transaccionales.frmSueldosSalarios sueldosYSalarios = new Transaccionales.frmSueldosSalarios(int.Parse(dgvPresupuesto.CurrentRow.Cells["idPresupuesto"].Value.ToString()), int.Parse(cboDepartamento.SelectedValue.ToString()));
                sueldosYSalarios.ShowDialog(this);
            }
        }
    }
}
