using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace ADIGGM.Herramientas
{
    public partial class frmAccionPersonalTrans : FrmPrincipal
    {
        public frmAccionPersonalTrans()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int cantidadLibres = int.Parse(txtCantidadLibres.Text);
            List<int> diasLibres = listBoxDiasLibres.SelectedItems.Cast<int>().ToList();
            string mes = cmbMes.SelectedItem?.ToString() ?? "";
            string año = cmbAño.SelectedItem?.ToString() ?? "";
            string observacion = cmbObservacion.SelectedItem?.ToString() ?? "";
            string compensacion = cmbCompensacion.SelectedItem?.ToString() ?? "";
            string compensacion2 = cmbCompensacion2.SelectedItem?.ToString() ?? "";
            string motivo = txtMotivo.Text;
            //DateTime fechaTrabajada = dtpFechaTrabajada1.Value;

            var fechaTrabajada = new List<string>();

            if (dtpFechaTrabajada1.Checked) fechaTrabajada.Add(dtpFechaTrabajada1.Value.ToString("dd/MM/yyyy"));
            if (dtpFechaTrabajada2.Checked) fechaTrabajada.Add(dtpFechaTrabajada2.Value.ToString("dd/MM/yyyy"));
            if (dtpFechaTrabajada3.Checked) fechaTrabajada.Add(dtpFechaTrabajada3.Value.ToString("dd/MM/yyyy"));
            if (dtpFechaTrabajada4.Checked) fechaTrabajada.Add(dtpFechaTrabajada4.Value.ToString("dd/MM/yyyy"));
            if (dtpFechaTrabajada5.Checked) fechaTrabajada.Add(dtpFechaTrabajada5.Value.ToString("dd/MM/yyyy"));
            if (dtpFechaTrabajada6.Checked) fechaTrabajada.Add(dtpFechaTrabajada6.Value.ToString("dd/MM/yyyy"));

            string resultado = "";

            if (fechaTrabajada.Count == 1)
                resultado = fechaTrabajada[0];
            else if (fechaTrabajada.Count > 1)
                resultado = string.Join(", ", fechaTrabajada.Take(fechaTrabajada.Count - 1)) + " Y " + fechaTrabajada.Last();

            string mensaje = GenerarTextoObservacion(cantidadLibres, diasLibres, mes, año, observacion, compensacion, compensacion2, motivo, resultado);
            txtResultado.Text = mensaje;

            try
            {                
                int idAcccion = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_AccionPersonalInsert(
                    dtpFechaAccion.Value,
                    txtId.Text,
                    cboEmpleado.Text, 
                    txtPuesto.Text,                      
                    "TipoAccion_Valor",                   
                    txtResultado.Text
                ));

                this.tR_AccionesPersonalTableAdapter.Fill(this.dsTransporteAdiggm.TR_AccionesPersonal,idAcccion);

                using (LocalReport rdlc = new LocalReport())
                {
                    rdlc.DataSources.Clear();
                    rdlc.ReportEmbeddedResource = "ADIGGM.Informes.rptAccion.rdlc";

                    DataTable TR_AccionesPersonal = dsTransporteAdiggm.TR_AccionesPersonal;
                    rdlc.DataSources.Add(new ReportDataSource("DsAcciones", TR_AccionesPersonal));

                    ReportParameter[] ParametroAccion = new ReportParameter[1];
                    ParametroAccion[0] = new ReportParameter("IdAccion", idAcccion.ToString(), false);
                    rdlc.SetParameters(ParametroAccion);

                    string format = "EXCELOPENXML";
                    string fileExtension = ".xlsx";

                    Warning[] warnings;
                    string[] streamids;
                    string mimeType;
                    string encoding;
                    string extension;

                    byte[] bytes = rdlc.Render(
                        format,
                        null,
                        out mimeType,
                        out encoding,
                        out extension,
                        out streamids,
                        out warnings
                    );

                    string tempFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + fileExtension);

                    using (FileStream fs = new FileStream(tempFilePath, FileMode.Create))
                    {
                        fs.Write(bytes, 0, bytes.Length);
                    }

                    Process.Start(tempFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar o guardar el informe: {ex.Message}");
            }
        }           

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }  
        
        private void frmAccionPersonalTrans_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsTransporteAdiggm.TR_Motoristas' Puede moverla o quitarla según sea necesario.
            this.tR_MotoristasTableAdapter.FillByActivo(this.dsTransporteAdiggm.TR_Motoristas);
            // Llenar días del mes
            for (int i = 1; i <= 31; i++)
            {
                listBoxDiasLibres.Items.Add(i);
            }

            // Llenar meses
            cmbMes.Items.AddRange(new string[]
            {
            "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO",
            "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"
            });

            // Llenar años
            for (int year = DateTime.Now.Year; year <= DateTime.Now.Year + 5; year++)
            {
                cmbAño.Items.Add(year.ToString());
            }

            // Observación
            cmbObservacion.Items.AddRange(new string[] { "", "POR ADELANTADO" });

            // Compensación
            cmbCompensacion.Items.AddRange(new string[] { "FERIADO", "FERIADOS", "DOMINGO", "DOMINGOS", "INTERRUPCIÓN DE CONTRATO", "VACACIONES", "SÉPTIMO DÍA", "SÉPTIMOS DÍAS" });
            // Compensación
            cmbCompensacion2.Items.AddRange(new string[] {"", "FERIADO", "FERIADOS", "DOMINGO", "DOMINGOS", "VACACIONES", "SÉPTIMO DÍA", "SÉPTIMOS DÍAS" });

            //GenerarTextoObservacion(Convert.ToInt32(nudDiasLibres.Value), diasLibres, cboMes.Text, cboAnio.Text, cboObservaciones.Text, cboVacaciones.Text, cboFeriado.Text, dtpFechaTrabajada.Value);
        }

        private string GenerarTextoObservacion(
            int cantidadLibres,
            List<int> diasLibres,
            string mes,
            string año,
            string observacion,
            string compensacion,
            string compensacion2,
            string motivo,
            string fechaTrabajada)
            {

            string mensaje;

            if (cantidadLibres > 1)
            {
                mensaje = $"SE LE CONCEDEN {cantidadLibres} DÍAS LIBRES";

                if (observacion.Contains("POR ADELANTADO"))
                {
                    mensaje += $" {observacion}";
                }
                if (compensacion.Contains("VACACIONES"))
                {
                    mensaje += " POR GOCE DE VACACIONES";
                }

                mensaje += ": EL ";

                if (diasLibres.Count == 1)
                {
                    mensaje += diasLibres[0].ToString();
                }
                else
                {
                    mensaje += string.Join(", ", diasLibres.Take(diasLibres.Count - 1));
                    mensaje += " Y " + diasLibres.Last();
                }

                mensaje += $" DE {mes} DEL {año}";

                if (ckbYN.Checked == true)
                {
                    mensaje += $", EN COMPENSACIÓN POR {compensacion}";
                    mensaje += compensacion2.Length > 0 ? $" Y {compensacion2}" : "";

                    if (compensacion.Contains("INTERRUPCIÓN DE CONTRATO"))
                    {
                        if (ckbIC.Checked == false)
                        {
                            mensaje += ".";
                        }
                        else
                        {
                            mensaje += observacion.Contains("POR ADELANTADO") ? " A TRABAJAR" : " TRABAJADOS";
                            mensaje += $", LAS FECHAS: {fechaTrabajada}.";
                        }
                    }
                    else
                    {
                        mensaje += observacion.Contains("POR ADELANTADO") ? " A TRABAJAR" : " TRABAJADOS";
                        mensaje += $", LAS FECHAS: {fechaTrabajada}.";
                    }
                }
                else
                {
                    mensaje += ".";
                }
            }
            ///////////////////////       SINGULAR       ///////////////////////
            else
            {
                mensaje = $"SE LE CONCEDE {cantidadLibres} DÍA LIBRE";

                if (observacion.Contains("POR ADELANTADO"))
                {
                    mensaje += $" {observacion}";
                }
                if (compensacion.Contains("VACACIONES"))
                {
                    mensaje += " POR GOCE DE VACACIONES";
                }

                mensaje += $": EL {diasLibres[0]} DE {mes} DEL {año}";

                if (ckbYN.Checked == true)
                {
                    mensaje += $", EN COMPENSACIÓN POR {compensacion}";

                    if (compensacion.Contains("INTERRUPCIÓN DE CONTRATO"))
                    {
                        if (ckbIC.Checked == false)
                        {
                            mensaje += ".";
                        }
                        else
                        {
                            mensaje += observacion.Contains("POR ADELANTADO") ? " A TRABAJAR" : " TRABAJADO";
                            mensaje += $", LA FECHA: {fechaTrabajada}.";
                        }
                    }
                    else
                    {
                        mensaje += observacion.Contains("POR ADELANTADO") ? " A TRABAJAR" : " TRABAJADO";
                        mensaje += $", LA FECHA: {fechaTrabajada}.";
                    }
                }
                else
                {
                    mensaje += ".";
                }
            }

            return mensaje;
        }//SE LE CONCEDE 1 DÍA LIBRE POR GOCE DE VACACIONES: EL 11 Y 12 DE NOVIEMBRE DEL 2025.

        private void cmbCompensacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string compensacion = cmbCompensacion.SelectedItem?.ToString() ?? "";

            if (compensacion.Contains("INTERRUPCIÓN DE CONTRATO"))
            {
                ckbIC.Visible = true;
            }else
                ckbIC.Visible = false;
        }

        private void ckbFecha2_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFecha2.Checked == true)
            {
                dtpFechaTrabajada2.Visible = true;
                ckbFecha3.Visible = true;
            }
            else
            {
                dtpFechaTrabajada2.Visible = false;
                ckbFecha3.Visible = false;
                ckbFecha4.Visible = false;
                ckbFecha5.Visible = false;
                ckbFecha6.Visible = false;
            }
        }

        private void ckbFecha3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFecha3.Checked == true)
            {
                dtpFechaTrabajada3.Visible = true;
                ckbFecha4.Visible = true;
            }
            else
            {
                dtpFechaTrabajada3.Visible = false;
                dtpFechaTrabajada4.Visible = false;
                dtpFechaTrabajada5.Visible = false;
                dtpFechaTrabajada6.Visible = false;

                ckbFecha4.Visible = false;
                ckbFecha5.Visible = false;
                ckbFecha6.Visible = false;

                ckbFecha4.Checked = false;
                ckbFecha5.Checked = false;
                ckbFecha6.Checked = false;
            }
        }

        private void ckbFecha4_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFecha4.Checked == true)
            {
                dtpFechaTrabajada4.Visible = true;
                ckbFecha5.Visible = true;
            }
            else
            {
                dtpFechaTrabajada4.Visible = false;
                ckbFecha5.Visible = false;

                ckbFecha5.Visible = false;
                ckbFecha6.Visible = false;

                ckbFecha5.Checked = false;
                ckbFecha6.Checked = false;
            }
        }

        private void ckbFecha5_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFecha5.Checked == true)
            {
                dtpFechaTrabajada5.Visible = true;
                ckbFecha6.Visible = true;
            }
            else
            {
                dtpFechaTrabajada5.Visible = false;
                dtpFechaTrabajada6.Visible = false;
                ckbFecha6.Visible= false;
                ckbFecha6.Checked = false;
            }
        }

        private void ckbFecha6_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbFecha6.Checked == true)
            {
                dtpFechaTrabajada6.Visible = true;
            }
            else
            {
                dtpFechaTrabajada6.Visible = false;                
            }
        }
    }
}
