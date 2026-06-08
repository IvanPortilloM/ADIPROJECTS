namespace ADIGGM.CapaModelo
{
    /// <summary>
    /// Ítem para el combo de tipos de asistencia (Texto = "Codigo - Descripcion").
    /// </summary>
    public class TipoAsistenciaCombo
    {
        public int TipoAsistenciaID { get; set; }
        public string Texto { get; set; }
        public bool RequiereTiempos { get; set; }
    }
}
