using System.Data;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio del módulo de Facturación (tablas FAC_*). Reemplaza al DataSet tipado
    /// DsFAC de forma incremental (un formulario a la vez).
    /// </summary>
    public class RepositorioFAC : RepositorioBase
    {
        public RepositorioFAC() : base(Conexion.TRANSPORTE) { }

        // ===== FAC_TipoMoneda (mantenimiento de tipos de moneda) =====

        public DataTable ListarTiposMoneda()
        {
            const string sql = "SELECT IdTipoMoneda, TipoMoneda, Simbolo, ValorLempiras FROM dbo.FAC_TipoMoneda";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdTipoMoneda es identity).</summary>
        public int GuardarTiposMoneda(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.FAC_TipoMoneda (TipoMoneda, Simbolo, ValorLempiras) VALUES (@TipoMoneda, @Simbolo, @ValorLempiras)";
            const string update = "UPDATE dbo.FAC_TipoMoneda SET TipoMoneda = @TipoMoneda, Simbolo = @Simbolo, ValorLempiras = @ValorLempiras WHERE IdTipoMoneda = @IdTipoMoneda";
            const string delete = "DELETE FROM dbo.FAC_TipoMoneda WHERE IdTipoMoneda = @IdTipoMoneda";
            return GuardarCambios(tabla, insert, update, delete);
        }
    }
}
