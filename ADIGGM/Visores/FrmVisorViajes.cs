using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ADIGGM.Formularios_Base.Visores
{
    public partial class FrmVisorViajes : FrmPrincipal
    {
        int IdTipoVehiculo = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_SelectIdRetro());

        public FrmVisorViajes()
        {
            InitializeComponent();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvVisorViajes);
            LimpiarContextMenuStrip();
        }

        private void FrmVisorViajes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Prefijos' Puede moverla o quitarla según sea necesario.
            this.tR_PrefijosTableAdapter.FillByVisor(this.dsTransporteAdiggm.TR_Prefijos);
            dtpFechaDesde.Value = DateTime.Now;
            dtpFechaHasta.Value = DateTime.Now;
            
            if (RdbCodigo.Checked)
            {
                mskNumBolHasta.Enabled = false;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
            }
            else
            {
                mskNumBolHasta.Enabled = true;
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
            }

            LlenarDgv();
            LlenarDetalles(0);
            mskNumBolDesde.Focus();
            btnEditar.Enabled = false;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            LlenarDgv();
            LlenarDetalles(0);
        }

        public void LlenarDgv()
        {
            string Prefijo = Convert.ToString(cboPrefijos.Text).ToString();
            string NumBolDesde = Convert.ToString(mskNumBolDesde.Text).ToString();
            string NumBolHasta = Convert.ToString(mskNumBolHasta.Text).ToString();
            DateTime FechaDesde = Convert.ToDateTime(dtpFechaDesde.Value);
            DateTime FechaHasta = Convert.ToDateTime(dtpFechaHasta.Value);

            if (RdbCodigo.Checked)
            {
                if (NumBolDesde.Length > 0)
                {
                    this.pR_ViajesTableAdapter.FillByFiltros(this.dsTransporteAdiggm.PR_Viajes, Prefijo, NumBolDesde, NumBolHasta, FechaDesde, FechaHasta,RdbCodigo.Checked);
                }
            }
            else
            {
                this.pR_ViajesTableAdapter.FillByFiltros(this.dsTransporteAdiggm.PR_Viajes, Prefijo, NumBolDesde, NumBolHasta, FechaDesde, FechaHasta, RdbCodigo.Checked);
            }

            if (dgvVisorViajes.SelectedRows.Count > 0)
            {
                CmsOpciones.Enabled = true;
            }
            else
                CmsOpciones.Enabled = false;
        }

        public void LlenarDetalles(int IndiceDgv)
        {
            try
            {
                if (dgvVisorViajes.RowCount > 0)
                {
                    txtVehiculo.Text = dgvVisorViajes.Rows[IndiceDgv].Cells["codVehiculo"].Value.ToString();
                    txtMotorista.Text = dgvVisorViajes.Rows[IndiceDgv].Cells["motorista"].Value.ToString();
                    txtCantidad.Text = $"{Convert.ToDouble(dgvVisorViajes.Rows[IndiceDgv].Cells["cantidad"].Value.ToString()):n}";
                    txtTarifa.Text = $"{Convert.ToDouble(dgvVisorViajes.Rows[IndiceDgv].Cells["tarifa"].Value.ToString()):n}";
                    txtISV.Text = $"{Convert.ToDouble(dgvVisorViajes.Rows[IndiceDgv].Cells["iSV"].Value.ToString()):n}";
                    txtSubtotal.Text = $"{Convert.ToDouble(dgvVisorViajes.Rows[IndiceDgv].Cells["subtotal"].Value.ToString()):n}";
                    txtTotal.Text = $"{Convert.ToDouble(dgvVisorViajes.Rows[IndiceDgv].Cells["total"].Value.ToString()):n}";
                    txtHrInical.Text = dgvVisorViajes.Rows[IndiceDgv].Cells["HrInicial"].Value.ToString();
                    txtHrFinal.Text = dgvVisorViajes.Rows[IndiceDgv].Cells["HrFinal"].Value.ToString();
                    txtHrTrabajadas.Text = dgvVisorViajes.Rows[IndiceDgv].Cells["HrTrabajadas"].Value.ToString();
                    txtHrGPS.Text = dgvVisorViajes.Rows[IndiceDgv].Cells["HrGPS"].Value.ToString();
                    txtObservaciones.Text = dgvVisorViajes.Rows[IndiceDgv].Cells["observaciones"].Value.ToString();
                }
                else
                {
                    txtVehiculo.Text = "";
                    txtMotorista.Text = "";
                    txtCantidad.Text = $"{0:n}";
                    txtTarifa.Text = $"{0:n}";
                    txtISV.Text = $"{0:n}";
                    txtSubtotal.Text = $"{0:n}";
                    txtTotal.Text = $"{0:n}";
                    txtHrInical.Text = $"{0:n}";
                    txtHrFinal.Text = $"{0:n}";
                    txtHrTrabajadas.Text = $"{0:n}";
                    txtHrGPS.Text = $"{0:n}";
                    txtObservaciones.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVisorViajes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVisorViajes.RowCount > 0)
            {
                LlenarDetalles(dgvVisorViajes.CurrentRow.Index);

                if (txtObservaciones.Enabled == true)
                {
                    txtObservaciones.Enabled = false;
                    LklEditarObs.Text = "Editar Observación";
                }

                LklEditarObs.Enabled = true;

                if (int.Parse(this.dgvVisorViajes.CurrentRow.Cells["idTipoVeh"].Value.ToString()) == IdTipoVehiculo)
                {
                    gboDetHr.Visible = true;
                }
                else
                {
                    gboDetHr.Visible = false;
                }

                if (bool.Parse(this.dgvVisorViajes.CurrentRow.Cells["Anulado"].Value.ToString()) == false)
                {
                    btnEditar.Enabled = true;
                }
                else
                {
                    btnEditar.Enabled = false;
                }
            }
            else
            {
                btnEditar.Enabled = false;
                LklEditarObs.Enabled = false;
            }
        }

        private void dgvVisorViajes_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int IdViaje = int.Parse(dgvVisorViajes.CurrentRow.Cells["idViaje"].Value.ToString());
            string Prefijo = dgvVisorViajes.CurrentRow.Cells["prefijo"].Value.ToString();
            string CodBoleta = dgvVisorViajes.CurrentRow.Cells["codBoleta"].Value.ToString();
            DateTime Fecha = DateTime.Parse(dgvVisorViajes.CurrentRow.Cells["fecha"].Value.ToString());
            int IdCliente = int.Parse(dgvVisorViajes.CurrentRow.Cells["idCliente"].Value.ToString());
            int IdClaseTrabajo = int.Parse(dgvVisorViajes.CurrentRow.Cells["idClaseTrabajo"].Value.ToString());
            int IdTipoVeh = int.Parse(dgvVisorViajes.CurrentRow.Cells["idTipoVeh"].Value.ToString());
            int IdRuta = int.Parse(dgvVisorViajes.CurrentRow.Cells["idRuta"].Value.ToString());
            int IdVehiculo = int.Parse(dgvVisorViajes.CurrentRow.Cells["idVehiculo"].Value.ToString());
            decimal Cantidad = decimal.Parse(dgvVisorViajes.CurrentRow.Cells["cantidad"].Value.ToString());
            decimal Tarifa = decimal.Parse(dgvVisorViajes.CurrentRow.Cells["tarifa"].Value.ToString());
            decimal ISV = decimal.Parse(dgvVisorViajes.CurrentRow.Cells["iSV"].Value.ToString());
            decimal SubTotal = decimal.Parse(dgvVisorViajes.CurrentRow.Cells["subtotal"].Value.ToString());
            decimal Total = decimal.Parse(dgvVisorViajes.CurrentRow.Cells["total"].Value.ToString());
            string Observaciones = dgvVisorViajes.CurrentRow.Cells["observaciones"].Value.ToString();

            if(IdTipoVeh == IdTipoVehiculo)
            {
                int IdViajeR = int.Parse(dgvVisorViajes.CurrentRow.Cells["IdViajeR"].Value.ToString());
                int IdRetrero = int.Parse(dgvVisorViajes.CurrentRow.Cells["idMotorista"].Value.ToString());
                int IdLaguna = int.Parse(dgvVisorViajes.CurrentRow.Cells["IdLaguna"].Value.ToString());
                int IdFinca = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_SeleccionarIdFinca(IdLaguna));
                double HrInicial = double.Parse(dgvVisorViajes.CurrentRow.Cells["HrInicial"].Value.ToString());
                double HrFinal = double.Parse(dgvVisorViajes.CurrentRow.Cells["HrFinal"].Value.ToString());
                double HrTrabajadas = double.Parse(dgvVisorViajes.CurrentRow.Cells["HrTrabajadas"].Value.ToString());
                double HrGPS = double.Parse(dgvVisorViajes.CurrentRow.Cells["HrGPS"].Value.ToString());

                Transaccionales.FrmViajesRetro viajesRetro = new Transaccionales.FrmViajesRetro(IdViaje,IdViajeR, Prefijo, CodBoleta, Fecha, IdCliente,
                IdClaseTrabajo, IdVehiculo, Tarifa, ISV, SubTotal, Total, Observaciones, 1, IdRetrero, IdFinca, IdLaguna, HrInicial, HrFinal, HrTrabajadas, HrGPS);

                if (viajesRetro.ShowDialog(this) == DialogResult.OK)
                {
                    LlenarDgv();
                    LlenarDetalles(0);
                }
            }
            else
            {
                Transaccionales.FrmViajes viajes = new Transaccionales.FrmViajes(IdViaje, Prefijo, CodBoleta, Fecha,
                                                IdCliente, IdClaseTrabajo, IdTipoVeh, IdRuta, IdVehiculo, Tarifa, Cantidad, ISV, SubTotal,
                                                Total, Observaciones, 1);

                if (viajes.ShowDialog(this) == DialogResult.OK)
                {
                    LlenarDgv();
                    LlenarDetalles(0);
                }
            }
        }

        private void cboPrefijos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboPrefijos.SelectedIndex != -1)
            {
                LlenarDgv();
                LlenarDetalles(0);
            }
        }

        private void anularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea anular este viaje?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int IdViaje = int.Parse(dgvVisorViajes.CurrentRow.Cells["idViaje"].Value.ToString());
                Clases.VarGlobales.consultasTrans.PR_ViajesAnular(IdViaje,1);
                MessageBox.Show("Viaje anulado exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK,MessageBoxIcon.Information);
                LlenarDgv();
                LlenarDetalles(0);
            }
        }

        private void reversarAnularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea reversar este viaje?", Clases.VarGlobales.nombreSistema, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int IdViaje = int.Parse(dgvVisorViajes.CurrentRow.Cells["idViaje"].Value.ToString());
                Clases.VarGlobales.consultasTrans.PR_ViajesAnular(IdViaje, 0);
                MessageBox.Show("Viaje reversado exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarDgv();
                LlenarDetalles(0);
            }
        }

        private void LimpiarContextMenuStrip()
        {
            CmsOpciones.Items[0].Visible = false;
            CmsOpciones.Items[1].Visible = false;
            CmsOpciones.Items[2].Visible = false;
        }

        private void dgvVisorViajes_MouseDown(object sender, MouseEventArgs e)
        {
            LimpiarContextMenuStrip();
            if (dgvVisorViajes.RowCount > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (bool.Parse(this.dgvVisorViajes.CurrentRow.Cells["Anulado"].Value.ToString()) == false)
                    {
                        CmsOpciones.Items[0].Visible = true;
                        CmsOpciones.Items[1].Visible = true;
                        CmsOpciones.Items[2].Visible = false;
                    }
                    else
                    {
                        CmsOpciones.Items[0].Visible = false;
                        CmsOpciones.Items[1].Visible = false;
                        CmsOpciones.Items[2].Visible = true;
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Transaccionales.FrmViajes viajes = new Transaccionales.FrmViajes(0, "", "", DateTime.Now, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, "", 0);
            //viajes.MdiParent = this.MdiParent;
            viajes.ShowDialog(this);
                LlenarDgv();
                LlenarDetalles(0);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdViaje = int.Parse(dgvVisorViajes.CurrentRow.Cells["idViaje"].Value.ToString());
            string Prefijo = dgvVisorViajes.CurrentRow.Cells["prefijo"].Value.ToString();
            string CodBoleta = dgvVisorViajes.CurrentRow.Cells["codBoleta"].Value.ToString();
            DateTime Fecha = DateTime.Parse(dgvVisorViajes.CurrentRow.Cells["fecha"].Value.ToString());
            int IdCliente = int.Parse(dgvVisorViajes.CurrentRow.Cells["idCliente"].Value.ToString());
            int IdClaseTrabajo = int.Parse(dgvVisorViajes.CurrentRow.Cells["idClaseTrabajo"].Value.ToString());
            int IdTipoVeh = int.Parse(dgvVisorViajes.CurrentRow.Cells["idTipoVeh"].Value.ToString());
            int IdRuta = int.Parse(dgvVisorViajes.CurrentRow.Cells["idRuta"].Value.ToString());
            int IdVehiculo = int.Parse(dgvVisorViajes.CurrentRow.Cells["idVehiculo"].Value.ToString());
            decimal Cantidad = decimal.Parse(dgvVisorViajes.CurrentRow.Cells["cantidad"].Value.ToString());
            decimal Tarifa = decimal.Parse(dgvVisorViajes.CurrentRow.Cells["tarifa"].Value.ToString());
            decimal ISV = decimal.Parse(dgvVisorViajes.CurrentRow.Cells["iSV"].Value.ToString());
            decimal SubTotal = decimal.Parse(dgvVisorViajes.CurrentRow.Cells["subtotal"].Value.ToString());
            decimal Total = decimal.Parse(dgvVisorViajes.CurrentRow.Cells["total"].Value.ToString());
            string Observaciones = dgvVisorViajes.CurrentRow.Cells["observaciones"].Value.ToString();

            if (IdTipoVeh == IdTipoVehiculo)
            {
                int IdViajeR = int.Parse(dgvVisorViajes.CurrentRow.Cells["IdViajeR"].Value.ToString());
                int IdRetrero = int.Parse(dgvVisorViajes.CurrentRow.Cells["idMotorista"].Value.ToString());
                int IdLaguna = int.Parse(dgvVisorViajes.CurrentRow.Cells["IdLaguna"].Value.ToString());
                int IdFinca = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_SeleccionarIdFinca(IdLaguna));
                double HrInicial = double.Parse(dgvVisorViajes.CurrentRow.Cells["HrInicial"].Value.ToString());
                double HrFinal = double.Parse(dgvVisorViajes.CurrentRow.Cells["HrFinal"].Value.ToString());
                double HrTrabajadas = double.Parse(dgvVisorViajes.CurrentRow.Cells["HrTrabajadas"].Value.ToString());
                double HrGPS = double.Parse(dgvVisorViajes.CurrentRow.Cells["HrGPS"].Value.ToString());

                Transaccionales.FrmViajesRetro viajesRetro = new Transaccionales.FrmViajesRetro(IdViaje, IdViajeR, Prefijo, CodBoleta, Fecha, IdCliente,
                IdClaseTrabajo, IdVehiculo, Tarifa, ISV, SubTotal, Total, Observaciones, 1, IdRetrero, IdFinca, IdLaguna, HrInicial, HrFinal, HrTrabajadas, HrGPS);

                if (viajesRetro.ShowDialog(this) == DialogResult.OK)
                {
                    LlenarDgv();
                    LlenarDetalles(0);
                }
            }
            else
            {
                Transaccionales.FrmViajes viajes = new Transaccionales.FrmViajes(IdViaje, Prefijo, CodBoleta, Fecha,
                                                IdCliente, IdClaseTrabajo, IdTipoVeh, IdRuta, IdVehiculo, Tarifa, Cantidad, ISV, SubTotal,
                                                Total, Observaciones, 1);

                if (viajes.ShowDialog(this) == DialogResult.OK)
                {
                    LlenarDgv();
                    LlenarDetalles(0);
                }
            }
        }

        private void LklEditarObs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvVisorViajes.Rows.Count > 0 && dgvVisorViajes.FirstDisplayedCell != null)
            {

                if (LklEditarObs.Text == "Editar Observación")
                {
                    LklEditarObs.Text = "Guardar Cambios";
                    if (txtObservaciones.Enabled == false)
                    {
                        txtObservaciones.Enabled = true;
                        txtObservaciones.Focus();
                    }
                }
                else if (LklEditarObs.Text == "Guardar Cambios")
                {
                    
                    string Veh = txtVehiculo.Text,
                        Mot = txtMotorista.Text,
                        Cant = txtCantidad.Text,
                        Tar = txtTarifa.Text,
                        Isv = txtISV.Text,
                        Sub = txtSubtotal.Text,
                        Tot = txtTotal.Text,
                        HrI = txtHrInical.Text,
                        HrF = txtHrFinal.Text,
                        HrTra = txtHrTrabajadas.Text,
                        HrGps = txtHrGPS.Text,
                        Obs = txtObservaciones.Text,
                        Usuario = Clases.VarGlobales.Usuario;
                    int IdViaje = int.Parse(dgvVisorViajes.CurrentRow.Cells["idViaje"].Value.ToString());

                    int selectedIndex = dgvVisorViajes.CurrentRow.Index;
                    
                    Clases.VarGlobales.consultasTrans.PR_ViajesUpdateObs(Obs, Usuario, IdViaje);

                    LlenarDgv();
                    LlenarDetalles(selectedIndex);
                    dgvVisorViajes.CurrentCell = dgvVisorViajes.Rows[selectedIndex].Cells[13];

                    txtVehiculo.Text = Veh;
                    txtMotorista.Text = Mot;
                    txtCantidad.Text = Cant;
                    txtTarifa.Text = Tar;
                    txtISV.Text = Isv;
                    txtSubtotal.Text = Sub;
                    txtTotal.Text = Tot;
                    txtHrInical.Text = HrI;
                    txtHrFinal.Text = HrF;
                    txtHrTrabajadas.Text = HrTra;
                    txtHrGPS.Text = HrGps;
                    txtObservaciones.Text = Obs;

                    txtObservaciones.Enabled = false;
                }
            }
        }

        private void RdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbCodigo.Checked)
            {
                mskNumBolHasta.Enabled = false;
                dtpFechaDesde.Enabled = false;
                dtpFechaHasta.Enabled = false;
            }
            else
            {
                mskNumBolHasta.Enabled = true;
                dtpFechaDesde.Enabled = true;
                dtpFechaHasta.Enabled = true;
            }
        }

        private void mskNumBolDesde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (mskNumBolDesde.Text != "")
                {
                    if (RdbCodigo.Checked)
                    {
                        btnVisualizar.PerformClick();
                    }
                    else
                        e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void mskNumBolDesde_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mskNumBolDesde.SelectAll();
            });
        }
    }
}