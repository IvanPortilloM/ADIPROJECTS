namespace ADIGGM.CapaModelo
{
    /// <summary>
    /// Modelo (POCO) de la tabla dbo.HE_TiposAsistencia.
    /// Los nombres de las propiedades coinciden con las columnas de la tabla
    /// (para el mapeo automático de Dapper) y con los nombres de columna que el
    /// formulario consulta en el DataGridView.
    /// </summary>
    public class TipoAsistencia
    {
        public int TipoAsistenciaID { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool RequiereTiempos { get; set; }
    }
}
