using ADIGGM.CapaModelo;
using System;
using System.Collections.Generic;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio del historial de salarios (dbo.TR_HistorialSalarios).
    /// </summary>
    public class RepositorioHistorialSalarios : RepositorioBase
    {
        public RepositorioHistorialSalarios() : base(Conexion.TRANSPORTE) { }

        public List<HistorialSalario> ListarPorMotorista(int idMotorista)
        {
            const string sql = @"SELECT SalarioQuincenal, FechaVigencia, HistorialID
                                 FROM dbo.TR_HistorialSalarios
                                 WHERE IdMotorista = @IdMotorista
                                 ORDER BY FechaVigencia DESC";
            return Consultar<HistorialSalario>(sql, new { IdMotorista = idMotorista });
        }

        public int Insertar(int idMotorista, decimal salarioQuincenal, DateTime fechaVigencia)
        {
            const string sql = @"INSERT INTO dbo.TR_HistorialSalarios (IdMotorista, SalarioQuincenal, FechaVigencia)
                                 VALUES (@IdMotorista, @SalarioQuincenal, @FechaVigencia)";
            return Ejecutar(sql, new { IdMotorista = idMotorista, SalarioQuincenal = salarioQuincenal, FechaVigencia = fechaVigencia });
        }
    }
}
