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

        // ===== FAC_CAI (mantenimiento de CAI / rangos de facturación SAR) =====

        public DataTable ListarCAI()
        {
            const string sql = "SELECT IdCai, Cai, FragmentoSAR, FechaDesde, FechaHasta, NumeroDesde, NumeroHasta, Activo, Anulado, Usuario, NombreEquipo, IdSucursal FROM dbo.FAC_CAI";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdCai es identity).</summary>
        public int GuardarCAI(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.FAC_CAI (Cai, FragmentoSAR, FechaDesde, FechaHasta, NumeroDesde, NumeroHasta, Activo, Anulado, Usuario, NombreEquipo, IdSucursal) " +
                                  "VALUES (@Cai, @FragmentoSAR, @FechaDesde, @FechaHasta, @NumeroDesde, @NumeroHasta, @Activo, @Anulado, @Usuario, @NombreEquipo, @IdSucursal)";
            const string update = "UPDATE dbo.FAC_CAI SET Cai = @Cai, FragmentoSAR = @FragmentoSAR, FechaDesde = @FechaDesde, FechaHasta = @FechaHasta, " +
                                  "NumeroDesde = @NumeroDesde, NumeroHasta = @NumeroHasta, Activo = @Activo, Anulado = @Anulado, Usuario = @Usuario, " +
                                  "NombreEquipo = @NombreEquipo, IdSucursal = @IdSucursal WHERE IdCai = @IdCai";
            const string delete = "DELETE FROM dbo.FAC_CAI WHERE IdCai = @IdCai";
            return GuardarCambios(tabla, insert, update, delete);
        }

        // ===== FAC_TipoFacturas (mantenimiento de tipos de factura) =====

        public DataTable ListarTiposFactura()
        {
            const string sql = "SELECT IdTipoFactura, CodTipoFactura, TipoFactura, Activo, EsTransporte FROM dbo.FAC_TipoFacturas";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdTipoFactura es identity).</summary>
        public int GuardarTiposFactura(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.FAC_TipoFacturas (CodTipoFactura, TipoFactura, Activo, EsTransporte) VALUES (@CodTipoFactura, @TipoFactura, @Activo, @EsTransporte)";
            const string update = "UPDATE dbo.FAC_TipoFacturas SET CodTipoFactura = @CodTipoFactura, TipoFactura = @TipoFactura, Activo = @Activo, EsTransporte = @EsTransporte WHERE IdTipoFactura = @IdTipoFactura";
            const string delete = "DELETE FROM dbo.FAC_TipoFacturas WHERE IdTipoFactura = @IdTipoFactura";
            return GuardarCambios(tabla, insert, update, delete);
        }

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
