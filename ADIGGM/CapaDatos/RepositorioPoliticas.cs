using ADIGGM.Clases;
using System.Collections.Generic;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio de Políticas de Pago (dbo.HE_PoliticasPago).
    /// </summary>
    public class RepositorioPoliticas : RepositorioBase
    {
        public RepositorioPoliticas() : base(Conexion.TRANSPORTE) { }

        public List<PoliticaPago> Listar()
        {
            const string sql = @"SELECT PoliticaID, NombrePolitica, PagaExtrasDiarias, PagaDomingos, PagaFeriados, AplicaJornadaMixta
                                 FROM dbo.HE_PoliticasPago
                                 ORDER BY NombrePolitica";
            return Consultar<PoliticaPago>(sql);
        }

        public int Insertar(PoliticaPago p)
        {
            const string sql = @"INSERT INTO dbo.HE_PoliticasPago (NombrePolitica, PagaExtrasDiarias, PagaDomingos, PagaFeriados, AplicaJornadaMixta)
                                 VALUES (@NombrePolitica, @PagaExtrasDiarias, @PagaDomingos, @PagaFeriados, @AplicaJornadaMixta)";
            return Ejecutar(sql, p);
        }

        public int Actualizar(PoliticaPago p)
        {
            const string sql = @"UPDATE dbo.HE_PoliticasPago
                                 SET NombrePolitica = @NombrePolitica,
                                     PagaExtrasDiarias = @PagaExtrasDiarias,
                                     PagaDomingos = @PagaDomingos,
                                     PagaFeriados = @PagaFeriados,
                                     AplicaJornadaMixta = @AplicaJornadaMixta
                                 WHERE PoliticaID = @PoliticaID";
            return Ejecutar(sql, p);
        }

        public int Eliminar(int politicaId)
        {
            const string sql = "DELETE FROM dbo.HE_PoliticasPago WHERE PoliticaID = @PoliticaID";
            return Ejecutar(sql, new { PoliticaID = politicaId });
        }
    }
}
