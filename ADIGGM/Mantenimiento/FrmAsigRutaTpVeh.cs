using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Formularios_Base;

namespace ADIGGM.Mantenimiento
{
    public partial class FrmAsigRutaTpVeh : FrmMantenimiento
    {
        int selectedIndex;
        // Agrega esta variable a nivel de clase (fuera de tus métodos, junto a selectedIndex)
        private bool ordenRutaAscendente = true;
        public FrmAsigRutaTpVeh()
        {
            InitializeComponent();
            HabilitarBtn();
            Clases.FuncionesGlobales DgvStyle = new Clases.FuncionesGlobales();
            DgvStyle.EstiloDgv(dgvRutaTpVeh);

            this.dgvRutaTpVeh.SortCompare += new DataGridViewSortCompareEventHandler(dgvRutaTpVeh_SortCompare);
        }

        private void FrmAsigRutaTpVeh_Load(object sender, EventArgs e)
        {
            this.tR_TipoVehiculosTableAdapter.Fill(this.dsTransporteAdiggm.TR_TipoVehiculos);
            this.tR_AsigRutaTipoVehTableAdapter.Fill(this.dsTransporteAdiggm.TR_AsigRutaTipoVeh);
            this.tR_RutasFiltradasTableAdapter.FillByN(this.dsTransporteAdiggm.TR_RutasFiltradas);
            lblFooter.Text = "RUTAS ASIGNADAS AL VEHÍCULO - CANTIDAD DE REGISTROS: " + dgvRutaTpVeh.RowCount;

            for (int i = this.dsTransporteAdiggm.TR_AsigRutaTipoVeh.ParentRelations.Count - 1; i >= 0; i--)
            {
                DataRelation relacionOriginal = this.dsTransporteAdiggm.TR_AsigRutaTipoVeh.ParentRelations[i];

                if (relacionOriginal.ChildColumns.Length > 0 && relacionOriginal.ChildColumns[0].ColumnName == "IdRuta")
                {
                    this.dsTransporteAdiggm.Relations.Remove(relacionOriginal);
                }
            }

            if (!this.dsTransporteAdiggm.Relations.Contains("RelacionTemporalRutas"))
            {
                this.dsTransporteAdiggm.Relations.Add(
                    "RelacionTemporalRutas",
                    this.dsTransporteAdiggm.TR_RutasFiltradas.Columns["IdRuta"], // Padre
                    this.dsTransporteAdiggm.TR_AsigRutaTipoVeh.Columns["IdRuta"], // Hija
                    false // evita que lance errores por restricciones de base de datos
                );
            }

            // CREAR LA COLUMNA VIRTUAL ---
            if (!this.dsTransporteAdiggm.TR_AsigRutaTipoVeh.Columns.Contains("RutaDescriptiva"))
            {
                DataColumn colVirtual = new DataColumn("RutaDescriptiva", typeof(string));
                colVirtual.Expression = "Parent(RelacionTemporalRutas).Ruta";
                this.dsTransporteAdiggm.TR_AsigRutaTipoVeh.Columns.Add(colVirtual);
            }

        }

        public void HabilitarBtn()
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvRutaTpVeh.AllowUserToAddRows = true;
            dgvRutaTpVeh.ReadOnly = false;
            dgvRutaTpVeh.FirstDisplayedScrollingRowIndex = dgvRutaTpVeh.RowCount - 1;
            var cantidadRow = dgvRutaTpVeh.RowCount - 1;
            dgvRutaTpVeh.CurrentCell = dgvRutaTpVeh.Rows[cantidadRow].Cells[2];
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRutaTpVeh.Rows.Count > 0 && dgvRutaTpVeh.FirstDisplayedCell != null)
                {
                    selectedIndex = dgvRutaTpVeh.CurrentRow.Index;
                    dgvRutaTpVeh.EndEdit();
                    this.tR_AsigRutaTipoVehTableAdapter.Update(this.dsTransporteAdiggm.TR_AsigRutaTipoVeh);
                    dgvRutaTpVeh.CurrentCell = dgvRutaTpVeh.Rows[selectedIndex].Cells[2];
                    dgvRutaTpVeh.AllowUserToAddRows = false;

                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnEditar.Enabled = true;
                    btnCancelar.Enabled = false;
                    dgvRutaTpVeh.ReadOnly = true;
                    lblFooter.Text = "VEHÍCULOS - CANTIDAD DE REGISTROS: " + dgvRutaTpVeh.RowCount;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Clases.VarGlobales.nombreSistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int saveRow = 0;

            if (dgvRutaTpVeh.Rows.Count > 0 && dgvRutaTpVeh.FirstDisplayedCell != null)
            {
                saveRow = dgvRutaTpVeh.FirstDisplayedCell.RowIndex;
                dgvRutaTpVeh.ReadOnly = false;
                dgvRutaTpVeh.AllowUserToAddRows = false;

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevo.Enabled = false;
                btnEditar.Enabled = false;
            }

            if (saveRow != 0 && saveRow < dgvRutaTpVeh.Rows.Count)
                dgvRutaTpVeh.FirstDisplayedScrollingRowIndex = saveRow;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvRutaTpVeh.Rows.Count > 0 && dgvRutaTpVeh.FirstDisplayedCell != null)
            {
                selectedIndex = dgvRutaTpVeh.CurrentRow.Index;

                this.tR_AsigRutaTipoVehTableAdapter.Fill(this.dsTransporteAdiggm.TR_AsigRutaTipoVeh);
                dgvRutaTpVeh.CurrentCell = dgvRutaTpVeh.Rows[selectedIndex].Cells[2];
                dgvRutaTpVeh.AllowUserToAddRows = false;

                dgvRutaTpVeh.ReadOnly = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRutaTpVeh_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dgvRutaTpVeh_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            lblFooter.Text = "RUTAS ASIG. A ESTE TIPO DE VEHÍCULO: " + dgvRutaTpVeh.RowCount;
        }
        
        private void dgvRutaTpVeh_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {

        }
        private void dgvRutaTpVeh_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Verificamos si hicieron clic en la columna del ComboBox (idRuta)
            if (dgvRutaTpVeh.Columns[e.ColumnIndex].Name == "idRuta")
            {
                // Ordenamos usando la columna virtual que creamos en el Load
                string direccion = ordenRutaAscendente ? "ASC" : "DESC";
                fKTRAsigRutaTipoVehTRTipoVehiculosBindingSource.Sort = $"RutaDescriptiva {direccion}";

                // Alternamos el estado
                ordenRutaAscendente = !ordenRutaAscendente;

                // Ponemos la flechita gráfica
                dgvRutaTpVeh.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection =
                    ordenRutaAscendente ? SortOrder.Descending : SortOrder.Ascending;
            }
        }
    }
}
