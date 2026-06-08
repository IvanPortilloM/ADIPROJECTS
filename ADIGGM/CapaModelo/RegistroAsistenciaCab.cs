namespace ADIGGM.CapaModelo
{
    /// <summary>
    /// Cabecera de un registro de asistencia (dbo.HE_RegistrosAsistencia) para un motorista/fecha.
    /// </summary>
    public class RegistroAsistenciaCab
    {
        public int RegistroAsistenciaID { get; set; }
        public int TipoAsistenciaID { get; set; }
        public bool EstaCerrado { get; set; }
        public string Observaciones { get; set; }
    }
}
