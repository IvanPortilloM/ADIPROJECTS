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

        /// <summary>Columna combo (muestra DisplayMember a partir del Id en DataPropertyName/ValueMember).
        /// El DataSource se asigna por separado en el form, tras poblar su BindingSource vía repositorio.</summary>
        public static DataGridViewComboBoxColumn Combo(string name, string prop, string header,
            string displayMember, string valueMember, bool visible = true,
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
            if (autoSize != DataGridViewAutoSizeColumnMode.NotSet) c.AutoSizeMode = autoSize;
            return c;
        }
    }
}
