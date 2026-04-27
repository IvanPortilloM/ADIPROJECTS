using ADIGGM.Clases;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ADIGGM.SAC
{
    public partial class frmOrdenes : FrmPrincipal
    {
        bool PermitirMonto = true;
        private readonly string cadenaConexionSQL = @"Initial Catalog=TransporteAdiggm;Data Source=ADIGGM.granjasmarinas.hn;Persist Security Info=True;User ID=sa;Password=ADIGGM*2016+";
        public frmOrdenes()
        {
            InitializeComponent();
        }
        public bool ValidarMonto(int code, string NombreControl)
        {
            bool resultado = true;
            Control[] ctrls = Controls.Find(NombreControl, true);

            if (ctrls.Length > 0)
            {
                TextBox ControlTexbox = ctrls[0] as TextBox;

                if (code == 46 && ControlTexbox.Text == "") //se evalúa si es punto y revisa si el texto está vacío.
                {
                    resultado = true;
                }
                if (code == 46 && ControlTexbox.Text.Contains(".")) //se evalúa si es punto y revisa si ya existe en el textbox
                {
                    resultado = true;
                }
                else if ((((code >= 48) && (code <= 57)) || (code == 8) || code == 46)) //se evalúan las teclas válidas
                {
                    resultado = false;
                }
                else if (!PermitirMonto)
                {
                    resultado = PermitirMonto;
                }
                else
                {
                    resultado = true;
                }
            }
            return resultado;
        }
        private void mskId_Leave(object sender, EventArgs e)
        {
            string t = this.mskId.Text.Replace("-", "").Replace(" ", "");

            this.coD_SlcASMaestrasTableAdapter.Fill(this.dsCodeasAdiggm.COD_SlcASMaestras, t);
            txtNombreCompleto.DataBindings.Clear();
            txtNombreCompleto.DataBindings.Add(new Binding("Text", this.cODSlcASMaestrasBindingSource, "cnombreaso", false));
        }

        private void mskId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void mskId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                string t = mskId.Text.Replace("-", "");
                t = t.Replace(" ", "");
                if (t != "")
                {
                    //e.Handled = true; 
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)(Keys.Enter))
            {
                if (txtValor.Text != "")
                {
                    e.Handled = true; SendKeys.Send("{TAB}");
                }
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox ctrl = sender as TextBox;
            e.Handled = ValidarMonto(Convert.ToInt32(e.KeyChar), Convert.ToString(ctrl.Name)); //llamada a la función que evalúa qué tecla es aceptada
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtValor.SelectAll();
            });
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text) || txtValor.Text == ".")
            {
                txtValor.Text = $"{0:n}";
            }
            else
            {
                txtValor.Text = string.Format("{0:#,##0.00}", double.Parse(txtValor.Text));
            }
        }

        private void txtValor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Ingrese un valor mayor a cero", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Text = $"{0:n}";
                txtValor.Focus();
            }
        }

        private void frmOrdenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsOC.OC_Proveedores' Puede moverla o quitarla según sea necesario.
            this.oC_ProveedoresTableAdapter.FillByEsSAC(this.dsOC.OC_Proveedores);
            cboProveedores.SelectedIndex = -1;
            dtpFechaOrden.Value = DateTime.Now;
            txtValor.Text = $"{0:n}";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int repetido = 0;
            ////////////////////////////////////////////////////////////
            foreach (DataGridViewRow row in dgvOrdenes.Rows)
            {
                string numOrden = row.Cells["numOrden"].Value.ToString();

                if (int.Parse(row.Cells["numOrden"].Value.ToString()) == int.Parse(mskNumOrden.Text))
                {
                    repetido++;
                    MessageBox.Show("El numero de orden ya existe", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //////////////////////////////////////////////////

            if (cboTipoOrden.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor elija un Tipo de Orden", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (cboProveedores.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor elija un Proveedor", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (txtValor.Text == $"{0:n}")
            {
                MessageBox.Show("La cantidad debe ser mayor a cero", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (mskNumOrden.Text == "")
            {
                MessageBox.Show("Por favor ingrese un número de orden", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (mskId.Text == "    -    -")
            {
                MessageBox.Show("Ingrese la identidad de Asociado", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (txtNombreCompleto.Text == string.Empty)
            {
                MessageBox.Show("El asociado no existe", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (repetido == 0)
            {
                //Verificar si el valor del campo Columna1 ya existe en la base de datos
                ////////////////////////////////////////////////////////////////////////
                using (SqlConnection conexionSQL = new SqlConnection(cadenaConexionSQL))
                {
                    SqlCommand comandoSQL = new SqlCommand($"SELECT COUNT(IdOrdenFact) FROM SAC_Ordenes WHERE (NumOrden='{mskNumOrden.Text}')", conexionSQL);
                    conexionSQL.Open();
                    int cantidadRegistros = (int)comandoSQL.ExecuteScalar();
                    if (cantidadRegistros > 0)
                    {
                        repetido++;
                        MessageBox.Show($"El número de " + mskNumOrden.Text + " orden ya existe en la base de datos.");
                    }
                }
                ////////////////////////////////////////////////////////////////////
                if (repetido == 0)
                {
                    dgvOrdenes.Rows.Add(cboTipoOrden.Text, mskNumOrden.Text, dtpFechaOrden.Value, cboProveedores.SelectedValue, cboProveedores.Text, mskId.Text.Replace("-",""), txtNombreCompleto.Text, txtValor.Text);
                    mskId.Text = "";
                    cboProveedores.SelectedIndex = -1;
                    ////////////////////////////////////////////////////////////////
                    mskNumOrden.Text = (Convert.ToDouble(mskNumOrden.Text.ToString()) + 1).ToString().PadLeft(5, '0');
                    ////////////////////////////////////////////////////////////////
                    txtValor.Text = $"{0:n}";
                    txtNombreCompleto.Text = "";
                }
            } 
        }

        private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrdenes.Rows)
            {
                VarGlobales.consultasOC.SAC_OrdenesInsert(row.Cells["numOrden"].Value.ToString(),                                                                               
                                                                              DateTime.Parse(row.Cells["fecha"].Value.ToString()),
                                                                              int.Parse(row.Cells["idProveedor"].Value.ToString()),
                                                                              row.Cells["idAsociado"].Value.ToString(),
                                                                              row.Cells["nombreAsoc"].Value.ToString(),
                                                                              row.Cells["tipoOrden"].Value.ToString(), decimal.Parse(row.Cells["valor"].Value.ToString()));
            }

            dgvOrdenes.DataSource = null;
            dgvOrdenes.Rows.Clear();
            MessageBox.Show("Orden agregada exitosamente", VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}