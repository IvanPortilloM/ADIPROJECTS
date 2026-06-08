using System;

namespace ADIGGM.CapaModelo
{
    /// <summary>
    /// Modelo (POCO) de la tabla dbo.HE_DiasFeriados.
    /// Los nombres de las propiedades coinciden con las columnas (mapeo de Dapper)
    /// y con los nombres de columna que el formulario consulta en el DataGridView.
    /// </summary>
    public class DiaFeriado
    {
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}
