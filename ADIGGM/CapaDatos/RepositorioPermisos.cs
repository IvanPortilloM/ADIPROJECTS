using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Dapper;

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

        // ===== Asignación de permisos por usuario =====

        /// <summary>Matriz de permisos del usuario (SP usp_CargarPermisos: menús con flag Habilitado).</summary>
        public DataTable CargarPermisosUsuario(int idUsuario)
        {
            DataTable tabla = ConsultarTabla("dbo.usp_CargarPermisos", new { IdUsuario = idUsuario }, CommandType.StoredProcedure);
            // DataTable.Load marca ReadOnly las columnas calculadas del SP; Habilitado debe
            // poder editarse en el grid (el DataSet tipado la generaba editable).
            if (tabla.Columns.Contains("Habilitado"))
                tabla.Columns["Habilitado"].ReadOnly = false;
            return tabla;
        }

        /// <summary>
        /// Reemplaza TODOS los permisos del usuario por la lista indicada, en UNA transacción:
        /// si algo falla se revierte y el usuario conserva sus permisos anteriores.
        /// (Antes el form hacía DELETE + inserts sueltos: un fallo a medio camino dejaba al usuario sin permisos.)
        /// </summary>
        public void GuardarPermisosUsuario(int idUsuario, IEnumerable<(int IdSubMenu, int IdDetSubMenu)> habilitados)
        {
            using (DbConnection con = CrearConexion())
            {
                con.Open();
                using (IDbTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        con.Execute("DELETE FROM dbo.Permiso WHERE IdUsuario = @IdUsuario",
                            new { IdUsuario = idUsuario }, trans);

                        foreach ((int idSubMenu, int idDetSubMenu) in habilitados)
                        {
                            con.Execute("dbo.usp_ActualizarPermisos",
                                new { IdUsuario = idUsuario, IdSubMenu = idSubMenu, IdDetSubMenu = idDetSubMenu },
                                trans, commandType: CommandType.StoredProcedure);
                        }

                        trans.Commit();
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
