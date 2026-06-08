using ADIGGM.CapaModelo;
using System.Collections.Generic;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio de consulta de motoristas (dbo.TR_Motoristas), compartido por
    /// los formularios del módulo HE que llenan combos/grids de motoristas.
    /// </summary>
    public class RepositorioMotoristas : RepositorioBase
    {
        public RepositorioMotoristas() : base(Conexion.TRANSPORTE) { }

        /// <summary>Motoristas activos marcados como empleados, ordenados por nombre.</summary>
        public List<MotoristaItem> ListarEmpleadosActivos()
        {
            const string sql = @"SELECT IdMotorista, Motorista
                                 FROM dbo.TR_Motoristas
                                 WHERE Activo = 1 AND EsEmpleado = 1
                                 ORDER BY Motorista";
            return Consultar<MotoristaItem>(sql);
        }
    }
}
