using ADIGGM.CapaModelo;
using System.Collections.Generic;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio de Tipos de Asistencia (dbo.HE_TiposAsistencia).
    /// PILOTO de referencia del patrón que sustituye al ADO.NET inline y a los DataSets tipados.
    /// Trabaja sobre la base de datos TransporteAdiggm (cadena canónica en App.config).
    /// </summary>
    public class RepositorioTiposAsistencia : RepositorioBase
    {
        public RepositorioTiposAsistencia() : base(Conexion.TRANSPORTE) { }

        public List<TipoAsistencia> Listar()
        {
            const string sql = @"SELECT TipoAsistenciaID, Codigo, Descripcion, RequiereTiempos
                                 FROM dbo.HE_TiposAsistencia
                                 ORDER BY Codigo";
            return Consultar<TipoAsistencia>(sql);
        }

        public bool ExisteCodigo(string codigo)
        {
            const string sql = "SELECT COUNT(*) FROM dbo.HE_TiposAsistencia WHERE Codigo = @Codigo";
            return Escalar<int>(sql, new { Codigo = codigo }) > 0;
        }

        public int Insertar(TipoAsistencia t)
        {
            const string sql = @"INSERT INTO dbo.HE_TiposAsistencia (Codigo, Descripcion, RequiereTiempos)
                                 VALUES (@Codigo, @Descripcion, @RequiereTiempos)";
            return Ejecutar(sql, t);
        }

        public int Actualizar(TipoAsistencia t)
        {
            const string sql = @"UPDATE dbo.HE_TiposAsistencia
                                 SET Codigo = @Codigo,
                                     Descripcion = @Descripcion,
                                     RequiereTiempos = @RequiereTiempos
                                 WHERE TipoAsistenciaID = @TipoAsistenciaID";
            return Ejecutar(sql, t);
        }

        public int Eliminar(int id)
        {
            const string sql = "DELETE FROM dbo.HE_TiposAsistencia WHERE TipoAsistenciaID = @ID";
            return Ejecutar(sql, new { ID = id });
        }
    }
}
