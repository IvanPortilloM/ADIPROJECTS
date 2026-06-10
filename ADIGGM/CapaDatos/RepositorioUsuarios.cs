using System.Data;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio de usuarios del sistema (tabla TR_Usuarios, BD TransporteAdiggm).
    /// </summary>
    public class RepositorioUsuarios : RepositorioBase
    {
        public RepositorioUsuarios() : base(Conexion.TRANSPORTE) { }

        /// <summary>Usuarios para combos (solo Id y nombre; NO traer Password ni demás columnas sensibles).</summary>
        public DataTable ListarUsuariosCombo()
        {
            const string sql = "SELECT IdUsuario, NombreApellido FROM dbo.TR_Usuarios";
            return ConsultarTabla(sql);
        }
    }
}
