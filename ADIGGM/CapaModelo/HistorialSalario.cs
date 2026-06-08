using System;

namespace ADIGGM.CapaModelo
{
    /// <summary>
    /// Fila del historial de salarios (vista de grid) de dbo.TR_HistorialSalarios.
    /// El orden de las propiedades define el orden de columnas; los encabezados
    /// "Salario Quincenal" / "Fecha Vigencia" se fijan en el formulario.
    /// </summary>
    public class HistorialSalario
    {
        public decimal SalarioQuincenal { get; set; }
        public DateTime FechaVigencia { get; set; }
        public int HistorialID { get; set; }
    }
}
