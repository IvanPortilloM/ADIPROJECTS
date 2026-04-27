using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Net.Mail;

namespace ADIGGM.Reportes
{
    public partial class RptMaestro : FrmPrincipal
    {
        int IdTipoVehiculo = Convert.ToInt32(Clases.VarGlobales.consultasTrans.TR_SelectIdRetro());
        public RptMaestro()
        {
            InitializeComponent();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvClaseTrab);
            DgvStyle.EstiloDgv(dgvTipoVeh);
            
        }

        private void RptViajes_Load(object sender, EventArgs e)
        {
            try
            {
                this.Dock = DockStyle.Fill;
                this.tR_VehiculosTableAdapter.FillByTodo(this.dsTransporteAdiggm.TR_Vehiculos);
                this.tR_ContratistasTableAdapter.FillByTodo(this.dsTransporteAdiggm.TR_Contratistas);
                this.tR_TipoVehiculosTableAdapter.FillByActivo(this.dsTransporteAdiggm.TR_TipoVehiculos);
                this.tR_MotoristasTableAdapter.FillByTodo(this.dsTransporteAdiggm.TR_Motoristas);
                this.tR_ClientesTableAdapter.FillByTodo(this.dsTransporteAdiggm.TR_Clientes);
                this.tR_ClaseTrabajosTableAdapter.FillByTodo(this.dsTransporteAdiggm.TR_ClaseTrabajos);
                this.tR_RutasFiltradasTableAdapter.FillByTodo(this.dsTransporteAdiggm.TR_RutasFiltradas);

                List<Item> lista = new List<Item>();
                lista.Add(new Item(1, "Detalle de Viajes"));
                lista.Add(new Item(1, "Horas Retro"));
                lista.Add(new Item(1, "Resumen de Viajes"));

                cboListaReportes.DisplayMember = "Name";
                cboListaReportes.ValueMember = "Value";
                cboListaReportes.DataSource = lista;

                chkResumenCta.Checked = true;
                MarcarClaTra();
                MarcarTipoVeh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class Item
        {
            public int Value { get; set; }
            public string Name { get; set; }

            public Item(int value, string name)
            {
                Name = name;
                Value = value;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        public void MarcarClaTra()
        {
            if (ckbMarcarTodo.Checked == true)
            {
                foreach (DataGridViewRow fila in dgvClaseTrab.Rows)
                {
                    fila.Cells["Seleccionar"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow fila in dgvClaseTrab.Rows)
                {
                    fila.Cells["Seleccionar"].Value = false;
                }
            }
        }

        public void MarcarTipoVeh()
        {
            if (ckbMarcarTpVeh.Checked == true)
            {
                foreach (DataGridViewRow fila in dgvTipoVeh.Rows)
                {
                    fila.Cells["Seleccion"].Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow fila in dgvTipoVeh.Rows)
                {
                    fila.Cells["Seleccion"].Value = false;
                }
            }
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboListaReportes.Text == "Detalle de Viajes")
                {
                    Clases.VarGlobales.consultasTrans.PR_TmpTblDel(Clases.VarGlobales.Usuario);

                    foreach (DataGridViewRow row in dgvClaseTrab.Rows)
                    {
                        if (bool.Parse(row.Cells["Seleccionar"].Value.ToString()) == true)
                        {
                            Clases.VarGlobales.consultasTrans.PR_TmpTblInsert(int.Parse(row.Cells["idClaseTrabajo"].Value.ToString()), "ClaTra", Clases.VarGlobales.Usuario);
                        }
                    }
                    foreach (DataGridViewRow row in dgvTipoVeh.Rows)
                    {
                        if (bool.Parse(row.Cells["Seleccion"].Value.ToString()) == true)
                        {
                            Clases.VarGlobales.consultasTrans.PR_TmpTblInsert(int.Parse(row.Cells["idTipoVehiculoD"].Value.ToString()), "TipoVeh", Clases.VarGlobales.Usuario);
                        }
                    }
                    this.pR_R_DetalleViajesTableAdapter.Fill(this.dsTransporteAdiggm.PR_R_DetalleViajes, Convert.ToDateTime(dtpDesde.Value), Convert.ToDateTime(dtpHasta.Value), Clases.VarGlobales.Usuario,
                                                                                                            int.Parse(cboClientes.SelectedValue.ToString()),
                                                                                                            int.Parse(cboVeh.SelectedValue.ToString()),
                                                                                                            int.Parse(cboMotoristas.SelectedValue.ToString()), int.Parse(cboContratistas.SelectedValue.ToString()),
                                                                                                            int.Parse(cboRutas.SelectedValue.ToString()));
                    if (chkResumenCta.Checked == true)
                    {
                        this.pR_R_DetalleCtaTableAdapter.Fill(this.dsTransporteAdiggm.PR_R_DetalleCta, Convert.ToDateTime(dtpDesde.Value), Convert.ToDateTime(dtpHasta.Value), Clases.VarGlobales.Usuario,
                                                                                                                int.Parse(cboClientes.SelectedValue.ToString()),
                                                                                                                int.Parse(cboVeh.SelectedValue.ToString()),
                                                                                                                int.Parse(cboMotoristas.SelectedValue.ToString()), int.Parse(cboContratistas.SelectedValue.ToString()),
                                                                                                                int.Parse(cboRutas.SelectedValue.ToString()), chkResumenCta.Checked);
                    }
                    rvViajesR.Visible = false;
                    rvViajes.Visible = true;
                    rvResViajes.Visible = false;
                    rvViajes.Dock = DockStyle.Fill;

                    this.rvViajes.RefreshReport();
                }
                else
                if (cboListaReportes.Text == "Horas Retro")
                {
                    Clases.VarGlobales.consultasTrans.PR_TmpTblDel(Clases.VarGlobales.Usuario);

                    foreach (DataGridViewRow row in dgvClaseTrab.Rows)
                    {
                        if (bool.Parse(row.Cells["Seleccionar"].Value.ToString()) == true)
                        {
                            Clases.VarGlobales.consultasTrans.PR_TmpTblInsert(int.Parse(row.Cells["idClaseTrabajo"].Value.ToString()), "ClaTra", Clases.VarGlobales.Usuario);
                        }
                    }

                    Clases.VarGlobales.consultasTrans.PR_TmpTblInsert(IdTipoVehiculo, "TipoVeh", Clases.VarGlobales.Usuario);

                    this.pR_R_DetalleViajesRTableAdapter.Fill(this.dsTransporteAdiggm.PR_R_DetalleViajesR, Convert.ToDateTime(dtpDesde.Value), Convert.ToDateTime(dtpHasta.Value), Clases.VarGlobales.Usuario,
                                                                                                            int.Parse(cboClientes.SelectedValue.ToString()), int.Parse(cboVeh.SelectedValue.ToString()),
                                                                                                            int.Parse(cboMotoristas.SelectedValue.ToString()), int.Parse(cboContratistas.SelectedValue.ToString()));
                    if (chkResumenCta.Checked == true)
                    {

                        this.pR_R_DetalleCtaTableAdapter.Fill(this.dsTransporteAdiggm.PR_R_DetalleCta, Convert.ToDateTime(dtpDesde.Value), Convert.ToDateTime(dtpHasta.Value), Clases.VarGlobales.Usuario,
                                                                                                                int.Parse(cboClientes.SelectedValue.ToString()),
                                                                                                                int.Parse(cboVeh.SelectedValue.ToString()),
                                                                                                                int.Parse(cboMotoristas.SelectedValue.ToString()), int.Parse(cboContratistas.SelectedValue.ToString()),
                                                                                                                0, chkResumenCta.Checked);
                    }
                    rvViajes.Visible = false;
                    rvViajesR.Visible = true;
                    rvResViajes.Visible = false;
                    rvViajesR.Dock = DockStyle.Fill;

                    this.rvViajesR.RefreshReport();
                }
                else
                if (cboListaReportes.Text == "Resumen de Viajes")
                {
                    Clases.VarGlobales.consultasTrans.PR_TmpTblDel(Clases.VarGlobales.Usuario);

                    foreach (DataGridViewRow row in dgvClaseTrab.Rows)
                    {
                        if (bool.Parse(row.Cells["Seleccionar"].Value.ToString()) == true)
                        {
                            Clases.VarGlobales.consultasTrans.PR_TmpTblInsert(int.Parse(row.Cells["idClaseTrabajo"].Value.ToString()), "ClaTra", Clases.VarGlobales.Usuario);
                        }
                    }
                    foreach (DataGridViewRow row in dgvTipoVeh.Rows)
                    {
                        if (bool.Parse(row.Cells["Seleccion"].Value.ToString()) == true)
                        {
                            Clases.VarGlobales.consultasTrans.PR_TmpTblInsert(int.Parse(row.Cells["idTipoVehiculoD"].Value.ToString()), "TipoVeh", Clases.VarGlobales.Usuario);
                        }
                    }
                    this.pR_R_ResumenViajesTableAdapter.Fill(this.dsTransporteAdiggm.PR_R_ResumenViajes, Convert.ToDateTime(dtpDesde.Value), Convert.ToDateTime(dtpHasta.Value), Clases.VarGlobales.Usuario,
                                                                                                            int.Parse(cboClientes.SelectedValue.ToString()),
                                                                                                            int.Parse(cboVeh.SelectedValue.ToString()),
                                                                                                            int.Parse(cboMotoristas.SelectedValue.ToString()), int.Parse(cboContratistas.SelectedValue.ToString()),
                                                                                                            int.Parse(cboRutas.SelectedValue.ToString()));
                    rvViajesR.Visible = false;
                    rvViajes.Visible = false;
                    rvResViajes.Visible = true;
                    rvResViajes.Dock = DockStyle.Fill;

                    this.rvResViajes.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckbMarcarTodo_CheckedChanged(object sender, EventArgs e)
        {
            MarcarClaTra();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (cboListaReportes.Text == "Horas Retro")
            {
                ExportarViajesR();
            }
            else if (cboListaReportes.Text == "Resumen de Viajes")
            {
                ExportarResViajes();
            }
            else
                ExportarViajes();
        }

        private void ExportarViajes()
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = rvViajes.LocalReport.Render(
                   "Excel", null, out mimeType, out encoding,
                    out extension,
                   out streamids, out warnings);

                FileStream fs = new FileStream(@Path.GetTempPath() + "\\RptViajes.xls",
                   FileMode.Create);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                Process.Start(@Path.GetTempPath() + "\\RptViajes.xls");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportarViajesR()
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = rvViajesR.LocalReport.Render(
                   "Excel", null, out mimeType, out encoding,
                    out extension,
                   out streamids, out warnings);

                FileStream fs = new FileStream(@Path.GetTempPath() + "\\RptViajes.xls",
                   FileMode.Create);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                Process.Start(@Path.GetTempPath() + "\\RptViajes.xls");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportarResViajes()
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = rvResViajes.LocalReport.Render(
                   "Excel", null, out mimeType, out encoding,
                    out extension,
                   out streamids, out warnings);

                FileStream fs = new FileStream(@Path.GetTempPath() + "\\RptResViajes.xls",
                   FileMode.Create);
                fs.Write(bytes, 0, bytes.Length);
                fs.Close();
                Process.Start(@Path.GetTempPath() + "\\RptResViajes.xls");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CboListaReportes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboListaReportes.Text == "Horas Retro")
            {
                cboRutas.Enabled = false;
                dgvTipoVeh.Enabled = false;
            }
            else
            {
                cboRutas.Enabled = true;
                dgvTipoVeh.Enabled = true;
            }
        }

        private void ckbMarcarTpVeh_CheckedChanged(object sender, EventArgs e)
        {
            MarcarTipoVeh();
        }
    }
}
