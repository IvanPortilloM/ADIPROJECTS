using System.Data;
using System.Windows.Forms;

namespace ADIGGM.Clases
{
    /// <summary>
    /// Fábrica de columnas de DataGridView para definirlas EN CÓDIGO en vez de en el .Designer.cs.
    /// Motivo (gotcha §11): al migrar los forms a Dapper se quitó el DataSet tipado de diseño; si las
    /// columnas viven en InitializeComponent, el diseñador de VS las borra al abrir el form (no puede
    /// resolver el esquema). Definiéndolas aquí (llamado desde el constructor) el diseñador no tiene
    /// columnas que "limpiar" y el grid queda inmune. ReadOnly por defecto (grids de solo lectura/visores).
    /// </summary>
    internal static class GridColumnas
    {
        public static DataGridViewTextBoxColumn Texto(string name, string prop, string header,
            bool visible = true, string format = null, int width = 0,
            DataGridViewAutoSizeColumnMode autoSize = DataGridViewAutoSizeColumnMode.NotSet, bool readOnly = true)
        {
            var c = new DataGridViewTextBoxColumn
            {
                Name = name,
                DataPropertyName = prop,
                HeaderText = header,
                Visible = visible,
                ReadOnly = readOnly
            };
            if (format != null) c.DefaultCellStyle = new DataGridViewCellStyle { Format = format };
            if (width > 0) c.Width = width;
            if (autoSize != DataGridViewAutoSizeColumnMode.NotSet) c.AutoSizeMode = autoSize;
            return c;
        }

        public static DataGridViewCheckBoxColumn Check(string name, string prop, string header,
            bool visible = true, int width = 0,
            DataGridViewAutoSizeColumnMode autoSize = DataGridViewAutoSizeColumnMode.NotSet, bool readOnly = true)
        {
            var c = new DataGridViewCheckBoxColumn
            {
                Name = name,
                DataPropertyName = prop,
                HeaderText = header,
                Visible = visible,
                ReadOnly = readOnly
            };
            if (width > 0) c.Width = width;
            if (autoSize != DataGridViewAutoSizeColumnMode.NotSet) c.AutoSizeMode = autoSize;
            return c;
        }

        /// <summary>Habilita o bloquea la edición de un grid de mantenimiento de forma robusta:
        /// fija dgv.ReadOnly Y el ReadOnly de TODAS las columnas a la vez. Necesario porque al definir
        /// las columnas en código (tras InitializeComponent, gotcha §11) el cascade de
        /// DataGridView.ReadOnly dejó de reactivar las columnas al PRIMER clic de "Editar": el grid no
        /// se habilitaba hasta hacer Cancelar + Editar otra vez (la transición true→false real disparaba
        /// el cascade). Fijar el ReadOnly de cada columna explícitamente elimina esa dependencia.</summary>
        public static void Edicion(DataGridView dgv, bool habilitar)
        {
            dgv.ReadOnly = !habilitar;
            // Al habilitar, una columna enlazada a un DataColumn de SOLO LECTURA (p.ej. el PK
            // identity que DataTable.Load marca ReadOnly, o columnas calculadas — gotcha §11)
            // DEBE permanecer en ReadOnly=true: ponerla en false lanza InvalidOperationException
            // ("...enlazada a un campo de solo lectura debe tener ReadOnly en True"). Solo se
            // habilitan las columnas cuyo campo es editable.
            DataTable tabla = habilitar ? TablaDe(dgv) : null;
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (!habilitar)
                {
                    col.ReadOnly = true;
                    continue;
                }
                bool campoSoloLectura = tabla != null
                    && !string.IsNullOrEmpty(col.DataPropertyName)
                    && tabla.Columns.Contains(col.DataPropertyName)
                    && tabla.Columns[col.DataPropertyName].ReadOnly;
                col.ReadOnly = campoSoloLectura;
            }
        }

        /// <summary>DataTable subyacente al grid, ya sea enlazado directo o vía BindingSource/DataView
        /// (incluye binding por DataRelation, donde List es el DataView de la tabla hija).</summary>
        private static DataTable TablaDe(DataGridView dgv)
        {
            if (dgv.DataSource is BindingSource bs)
            {
                if (bs.List is DataView dv) return dv.Table;
                if (bs.DataSource is DataTable t) return t;
            }
            return dgv.DataSource as DataTable;
        }

        /// <summary>Columna combo (muestra DisplayMember a partir del Id en DataPropertyName/ValueMember).
        /// El DataSource se asigna por separado en el form, tras poblar su BindingSource vía repositorio.</summary>
        public static DataGridViewComboBoxColumn Combo(string name, string prop, string header,
            string displayMember, string valueMember, bool visible = true, int width = 0,
            DataGridViewAutoSizeColumnMode autoSize = DataGridViewAutoSizeColumnMode.NotSet, bool readOnly = true)
        {
            var c = new DataGridViewComboBoxColumn
            {
                Name = name,
                DataPropertyName = prop,
                HeaderText = header,
                DisplayMember = displayMember,
                ValueMember = valueMember,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing,
                Visible = visible,
                ReadOnly = readOnly
            };
            if (width > 0) c.Width = width;
            if (autoSize != DataGridViewAutoSizeColumnMode.NotSet) c.AutoSizeMode = autoSize;
            return c;
        }

        /// <summary>Columna de imagen (firmas, logos, fotos almacenadas como byte[] en DataPropertyName).
        /// Display-only por naturaleza; ImageLayout controla el encuadre (Stretch/Zoom/Normal).</summary>
        public static DataGridViewImageColumn Imagen(string name, string prop, string header,
            DataGridViewImageCellLayout imageLayout = DataGridViewImageCellLayout.Normal,
            bool visible = true, int width = 0,
            DataGridViewAutoSizeColumnMode autoSize = DataGridViewAutoSizeColumnMode.NotSet, bool readOnly = true)
        {
            var c = new DataGridViewImageColumn
            {
                Name = name,
                DataPropertyName = prop,
                HeaderText = header,
                ImageLayout = imageLayout,
                Visible = visible,
                ReadOnly = readOnly
            };
            if (width > 0) c.Width = width;
            if (autoSize != DataGridViewAutoSizeColumnMode.NotSet) c.AutoSizeMode = autoSize;
            return c;
        }
    }
}
