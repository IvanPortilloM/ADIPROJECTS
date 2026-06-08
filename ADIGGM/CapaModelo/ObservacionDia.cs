using System;

namespace ADIGGM.CapaModelo
{
    /// <summary>
    /// Observación de un día de asistencia (para el cache de observaciones del grid).
    /// </summary>
    public class ObservacionDia
    {
        public int IdMotorista { get; set; }
        public DateTime Fecha { get; set; }
        public string Observaciones { get; set; }
    }
}
