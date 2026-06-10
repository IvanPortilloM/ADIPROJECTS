using System.Data;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Repositorio del módulo de Seguridad (BD DB_Permisos: Menu, SubMenu, DetSubMenu, permisos).
    /// Reemplaza al DataSet tipado DsPermisos de forma incremental (un formulario a la vez).
    /// </summary>
    public class RepositorioPermisos : RepositorioBase
    {
        public RepositorioPermisos() : base(Conexion.PERMISOS) { }

        // ===== Menu (mantenimiento del menú raíz del sistema) =====

        public DataTable ListarMenus()
        {
            const string sql = "SELECT IdMenu, Nombre, NombreFormulario, NombreMenu, Icono FROM dbo.Menu";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdMenu es identity).</summary>
        public int GuardarMenus(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.Menu (Nombre, NombreFormulario, NombreMenu, Icono) VALUES (@Nombre, @NombreFormulario, @NombreMenu, @Icono)";
            const string update = "UPDATE dbo.Menu SET Nombre = @Nombre, NombreFormulario = @NombreFormulario, NombreMenu = @NombreMenu, Icono = @Icono WHERE IdMenu = @IdMenu";
            const string delete = "DELETE FROM dbo.Menu WHERE IdMenu = @IdMenu";
            return GuardarCambios(tabla, insert, update, delete);
        }

        // ===== SubMenu (mantenimiento de menús hijos; FK IdMenu) =====

        public DataTable ListarSubMenus()
        {
            const string sql = "SELECT IdSubMenu, IdMenu, Nombre, NombreFormulario, NombreMenu FROM dbo.SubMenu";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdSubMenu es identity).</summary>
        public int GuardarSubMenus(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.SubMenu (IdMenu, Nombre, NombreFormulario, NombreMenu) VALUES (@IdMenu, @Nombre, @NombreFormulario, @NombreMenu)";
            const string update = "UPDATE dbo.SubMenu SET IdMenu = @IdMenu, Nombre = @Nombre, NombreFormulario = @NombreFormulario, NombreMenu = @NombreMenu WHERE IdSubMenu = @IdSubMenu";
            const string delete = "DELETE FROM dbo.SubMenu WHERE IdSubMenu = @IdSubMenu";
            return GuardarCambios(tabla, insert, update, delete);
        }

        // ===== DetSubMenu (mantenimiento de menús nietos; FK IdSubMenu) =====

        public DataTable ListarDetSubMenus()
        {
            const string sql = "SELECT IdDetSubMenu, IdSubMenu, Nombre, NombreFormulario, NombreMenu FROM dbo.DetSubMenu";
            return ConsultarTabla(sql);
        }

        /// <summary>Persiste altas/cambios hechos en la grilla (IdDetSubMenu es identity).</summary>
        public int GuardarDetSubMenus(DataTable tabla)
        {
            const string insert = "INSERT INTO dbo.DetSubMenu (IdSubMenu, Nombre, NombreFormulario, NombreMenu) VALUES (@IdSubMenu, @Nombre, @NombreFormulario, @NombreMenu)";
            const string update = "UPDATE dbo.DetSubMenu SET IdSubMenu = @IdSubMenu, Nombre = @Nombre, NombreFormulario = @NombreFormulario, NombreMenu = @NombreMenu WHERE IdDetSubMenu = @IdDetSubMenu";
            const string delete = "DELETE FROM dbo.DetSubMenu WHERE IdDetSubMenu = @IdDetSubMenu";
            return GuardarCambios(tabla, insert, update, delete);
        }
    }
}
