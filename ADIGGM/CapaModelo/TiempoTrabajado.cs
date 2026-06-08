using System;

namespace ADIGGM.CapaModelo
{
    /// <summary>
    /// Bloque de tiempo (entrada/salida) almacenado en dbo.HE_RegistrosTiempos.
    /// </summary>
    public class TiempoTrabajado
    {
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
    }
}
