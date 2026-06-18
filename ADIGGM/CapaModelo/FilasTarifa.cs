using System;

namespace ADIGGM.CapaModelo
{
    /// <summary>
    /// Fila de "vista previa" para la actualización masiva de tarifas por porcentaje.
    /// Sirve para las tarifas BASE (TR_AsigRutaTipoVeh) y ASIGNADAS (TR_TarifaRutas).
    /// En modo base, Cliente y ClaseTrabajo quedan vacíos (esa tabla no los maneja).
    /// </summary>
    public class FilaTarifa
    {
        /// <summary>PK del registro a actualizar (IdAsigRutaTipoVeh o IdTarifaRuta).</summary>
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string ClaseTrabajo { get; set; }
        public string TipoVehiculo { get; set; }
        public string Ruta { get; set; }
        public decimal TarifaActual { get; set; }
        /// <summary>Tarifa resultante (calculada con el % o ajustada a mano en la previa).</summary>
        public decimal TarifaNueva { get; set; }
    }

    /// <summary>
    /// Fila de "vista previa" para actualizar el precio de boletas ya digitadas (TR_Viajes).
    /// Conserva los montos actuales para recalcular Subtotal/ISV/Total y para la auditoría.
    /// La tasa de ISV de cada boleta se preserva (ISVActual / SubtotalActual).
    /// </summary>
    public class FilaViaje
    {
        public int IdViaje { get; set; }
        public DateTime Fecha { get; set; }
        public string NumBoleta { get; set; }
        public string Cliente { get; set; }
        public string TipoVehiculo { get; set; }
        public string Ruta { get; set; }
        public decimal Cantidad { get; set; }
        public decimal TarifaActual { get; set; }
        public decimal SubtotalActual { get; set; }
        public decimal IsvActual { get; set; }
        public decimal TotalActual { get; set; }
        public decimal TarifaNueva { get; set; }
        public decimal SubtotalNuevo { get; set; }
        public decimal IsvNuevo { get; set; }
        public decimal TotalNuevo { get; set; }
    }
}
