using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmCierres : FrmPrincipal
    {
        int selectedIndex;
        public FrmCierres()
        {
            InitializeComponent();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvCierre);
        }

        private void FrmCierres_Load(object sender, EventArgs e)
        {
            this.tR_CierresTableAdapter.Fill(this.dsTransporteAdiggm.TR_Cierres);
        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
        }

        private void LimpiarContextMenuStrip()
        {
            CmsOpciones.Items[0].Visible = false;//Nuevo
            CmsOpciones.Items[1].Visible = false;//Ver Detalles
            CmsOpciones.Items[2].Visible = false;//Cerrar
            CmsOpciones.Items[3].Visible = false;//Editar Fecha
        }

        public void LlenarDgv()
        {
            this.tR_CierresTableAdapter.Fill(this.dsTransporteAdiggm.TR_Cierres);
            
            if (dgvCierre.SelectedRows.Count > 0)
            {
                CmsOpciones.Enabled = true;
            }
            else
                CmsOpciones.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            selectedIndex = dgvCierre.CurrentRow.Index;
            
            FrmAgregarCierre agregarCierre = new FrmAgregarCierre(0, false, Convert.ToDateTime("2019-01-01"), Convert.ToDateTime("2019-01-01"));

            if (agregarCierre.ShowDialog(this) == DialogResult.OK)
            {
                LlenarDgv();
                dgvCierre.CurrentCell = dgvCierre.Rows[selectedIndex].Cells[1];
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCierre_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvCierre_MouseDown(object sender, MouseEventArgs e)
        {
            LimpiarContextMenuStrip();

            //int Nuevo = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_CierresExiste());

            //if (Nuevo == 0 || Nuevo == -1)
            //{
                CmsOpciones.Items[0].Visible = true;
                //btnNuevo.Enabled = true;
            //}
            //else
            //{
            //    CmsOpciones.Items[0].Visible = false;
            //    btnNuevo.Enabled = false;
            //}

            if (dgvCierre.RowCount > 0)
            {
                DateTime FechaFin = DateTime.Parse(dgvCierre.CurrentRow.Cells["fechaFin"].Value.ToString());
                
                if (e.Button == MouseButtons.Right)
                {
                    if (bool.Parse(this.dgvCierre.CurrentRow.Cells["cerrado"].Value.ToString()) == false &&
                        bool.Parse(this.dgvCierre.CurrentRow.Cells["anulado"].Value.ToString()) == false)
                    {
                        CmsOpciones.Items[1].Visible = true;//Ver Detalles
                        CmsOpciones.Items[2].Visible = true;//Cerrar
                        CmsOpciones.Items[3].Visible = true;//Editar Fecha
                    }
                    else 
                    if (bool.Parse(this.dgvCierre.CurrentRow.Cells["cerrado"].Value.ToString()) == true &&
                        bool.Parse(this.dgvCierre.CurrentRow.Cells["anulado"].Value.ToString()) == false)
                    {
                        CmsOpciones.Items[1].Visible = true;//Ver Detalles
                        CmsOpciones.Items[2].Visible = false;//Cerrar
                        CmsOpciones.Items[3].Visible = false;//Editar Fecha
                    }
                    else
                    if (bool.Parse(this.dgvCierre.CurrentRow.Cells["cerrado"].Value.ToString()) == false &&
                        bool.Parse(this.dgvCierre.CurrentRow.Cells["anulado"].Value.ToString()) == true)
                    {
                        CmsOpciones.Items[1].Visible = true;//Ver Detalles
                        CmsOpciones.Items[2].Visible = false;//Cerrar
                        CmsOpciones.Items[3].Visible = false;//Editar Fecha
                    }
                }
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarCierre agregarCierre = new FrmAgregarCierre(0, false, Convert.ToDateTime("2019-01-01"), Convert.ToDateTime("2019-01-01"));

            if (agregarCierre.ShowDialog(this) == DialogResult.OK)
            {
                LlenarDgv();
            }
        }

        private void verDetallesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedIndex = dgvCierre.CurrentRow.Index;
            int IdCierre = int.Parse(dgvCierre.CurrentRow.Cells["idCierre"].Value.ToString());

            FrmCierreCliente cierreCliente = new FrmCierreCliente(IdCierre);
            
            cierreCliente.ShowDialog(this);
            LlenarDgv();
            dgvCierre.CurrentCell = dgvCierre.Rows[selectedIndex].Cells[1];
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Se Cerraran todos los Clientes Asociados a este " +
            "Cierre y Rango de Fecha ¿Desea Continuar?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int IdCierre = int.Parse(dgvCierre.CurrentRow.Cells["idCierre"].Value.ToString());
                Clases.VarGlobales.consultasTrans.PR_CCierresCerrar(IdCierre, Clases.VarGlobales.Usuario);
                MessageBox.Show("Cierre Realizado Exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDgv();
            }
        }

        private void editarFechaCierreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedIndex = dgvCierre.CurrentRow.Index;
            int IdCierre = int.Parse(dgvCierre.CurrentRow.Cells["idCierre"].Value.ToString());
            DateTime FechaInicio = DateTime.Parse(dgvCierre.CurrentRow.Cells["fechaInicio"].Value.ToString());
            DateTime FechaFin = DateTime.Parse(dgvCierre.CurrentRow.Cells["fechaFin"].Value.ToString());

            FrmAgregarCierre agregarCierre = new FrmAgregarCierre(IdCierre, true, FechaInicio, FechaFin);

            if (agregarCierre.ShowDialog(this) == DialogResult.OK)
            {
                LlenarDgv();
                dgvCierre.CurrentCell = dgvCierre.Rows[selectedIndex].Cells[1];
            }
        }
    }
}
