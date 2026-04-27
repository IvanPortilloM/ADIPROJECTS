using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmAgregarCierre : ADIGGM.FrmPrincipal
    {
        readonly string Usuario = Clases.VarGlobales.Usuario;
        readonly DateTime FechaMax = Convert.ToDateTime(Clases.VarGlobales.consultasTrans.TR_FecMaxCierre()),
            FechaInicio, FechaFin;
        readonly int IdCierre;
        readonly bool Editar;
        //DateTime FechaMin = Convert.ToDateTime(Clases.VarGlobales.consultasTrans.TR_FecMinCierre());

        public FrmAgregarCierre(int IdCierre, bool Editar, DateTime FechaInicio, DateTime FechaFin)
        {
            InitializeComponent();
            this.IdCierre = IdCierre;
            this.Editar = Editar;
            this.FechaInicio = FechaInicio;
            this.FechaFin = FechaFin;
        }

        private void FrmAgregarCierre_Load(object sender, EventArgs e)
        {
            dtpFecInicio.Value = FechaInicio;
            dtpFecFinal.Value = FechaFin;

            if(Editar == true)
            {
                int EditFecAnt = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_CierresValFechaAnterior(IdCierre));
                int EditFecPos = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_CierresValFechaPosterior(IdCierre));
                
                if (EditFecAnt == 0)
                {
                    dtpFecInicio.Enabled = false;
                }else
                    if(EditFecAnt == 1 || EditFecAnt == 2)
                {
                    dtpFecInicio.Enabled = true;
                }

                if (EditFecPos == 0)
                {
                    dtpFecFinal.Enabled = false;
                }
                else
                    if (EditFecPos == 1 || EditFecPos == 2)
                {
                    dtpFecFinal.Enabled = true;
                }
            }
            else
            {
                dtpFecInicio.Value = FechaMax.AddDays(1);
                dtpFecFinal.Value = dtpFecInicio.Value.AddDays(6);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DateTime FechaInicio = Convert.ToDateTime(dtpFecInicio.Value);
            DateTime FechaFin = Convert.ToDateTime(dtpFecFinal.Value);
            int validar = ValidarCampos();

            try
                {
                if(Editar == false)
                {
                    Clases.VarGlobales.consultasTrans.PR_CierresInsert(FechaInicio, FechaFin, Usuario);
                    MessageBox.Show("Datos Guardados Exitosamente", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                if(Editar == true)
                {
                    if(validar == 1)
                    {
                        MessageBox.Show("Datos Editados", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Favor Verifique los Rangos de Fechas Ingresados", Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        public int ValidarCampos()
        {
            int MsgVal, resultado;
            DateTime FechaInicio = Convert.ToDateTime(dtpFecInicio.Value),
                        FechaFin = Convert.ToDateTime(dtpFecFinal.Value);

            MsgVal = Convert.ToInt32(Clases.VarGlobales.consultasTrans.PR_CierresValidarEditar(IdCierre,FechaInicio,FechaFin,Usuario));

            if (MsgVal == 1)
            {
                resultado = 1;
            }
            else
            {
                resultado = 0; 
            }

            return resultado;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFecInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpFecFinal.Value = dtpFecInicio.Value.AddDays(6);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            dtpFecInicio.Value = DateTime.Now;
        }
    }
}
