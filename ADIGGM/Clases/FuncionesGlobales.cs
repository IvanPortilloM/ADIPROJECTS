using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM.Clases
{
    class FuncionesGlobales
    {
        public void EstiloDgv(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = Properties.Settings.Default.FuenteContDgv;
            dgv.ColumnHeadersDefaultCellStyle.Font = Properties.Settings.Default.FuenteTituloDgv;
            dgv.DefaultCellStyle.SelectionBackColor = Properties.Settings.Default.SeleccionarDgv;
            dgv.DefaultCellStyle.SelectionForeColor = Properties.Settings.Default.ColorFuenteDgv;
            dgv.EditMode = DataGridViewEditMode.EditOnEnter;
        }
    }
}
