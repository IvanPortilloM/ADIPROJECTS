using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Base para los repositorios de acceso a datos (patrón estándar del proyecto con Dapper).
    ///
    /// Centraliza la apertura/cierre de la conexión a través de la fuente única
    /// <see cref="Conexion"/> y la ejecución de consultas con Dapper.
    /// Cada repositorio concreto indica, en su constructor, el NOMBRE de la cadena
    /// de conexión (definida en App.config) sobre la que trabaja.
    ///
    /// Reemplaza progresivamente al ADO.NET inline y a los DataSets tipados.
    /// </summary>
    public abstract class RepositorioBase
    {
        private readonly string _nombreConexion;

        protected RepositorioBase(string nombreConexion)
        {
            _nombreConexion = nombreConexion;
        }

        /// <summary>
        /// Crea (sin abrir) una conexión a la base de datos del repositorio.
        /// Úsese cuando se necesita controlar manualmente una transacción que abarca
        /// varias operaciones (abrir, BeginTransaction, Commit/Rollback, liberar con using).
        /// </summary>
        protected DbConnection CrearConexion()
        {
            return Conexion.CrearConexion(_nombreConexion);
        }

        /// <summary>Consulta que devuelve una lista de T (Dapper mapea por nombre de columna).</summary>
        protected List<T> Consultar<T>(string sql, object parametros = null, CommandType tipo = CommandType.Text)
        {
            using (DbConnection con = Conexion.CrearConexion(_nombreConexion))
            {
                con.Open();
                return con.Query<T>(sql, parametros, commandType: tipo).AsList();
            }
        }

        /// <summary>Primer registro de la consulta, o default(T) si no hay filas.</summary>
        protected T PrimeroODefault<T>(string sql, object parametros = null, CommandType tipo = CommandType.Text)
        {
            using (DbConnection con = Conexion.CrearConexion(_nombreConexion))
            {
                con.Open();
                return con.QueryFirstOrDefault<T>(sql, parametros, commandType: tipo);
            }
        }

        /// <summary>Devuelve un valor escalar (COUNT, SUM, un solo campo, etc.).</summary>
        protected T Escalar<T>(string sql, object parametros = null, CommandType tipo = CommandType.Text)
        {
            using (DbConnection con = Conexion.CrearConexion(_nombreConexion))
            {
                con.Open();
                return con.ExecuteScalar<T>(sql, parametros, commandType: tipo);
            }
        }

        /// <summary>Ejecuta INSERT/UPDATE/DELETE o un SP de acción. Devuelve filas afectadas.</summary>
        protected int Ejecutar(string sql, object parametros = null, CommandType tipo = CommandType.Text)
        {
            using (DbConnection con = Conexion.CrearConexion(_nombreConexion))
            {
                con.Open();
                return con.Execute(sql, parametros, commandType: tipo);
            }
        }

        /// <summary>
        /// Ejecuta una consulta y devuelve un DataTable. Útil para formularios/reportes
        /// que aún procesan los resultados como DataTable (p. ej. cálculos con LINQ-to-DataTable).
        /// La conexión y los parámetros (objeto anónimo) se gestionan vía la fuente única y Dapper.
        /// </summary>
        protected DataTable ConsultarTabla(string sql, object parametros = null, CommandType tipo = CommandType.Text)
        {
            using (DbConnection con = Conexion.CrearConexion(_nombreConexion))
            {
                con.Open();
                using (IDataReader reader = con.ExecuteReader(sql, parametros, commandType: tipo))
                {
                    DataTable tabla = new DataTable();
                    tabla.Load(reader);
                    return tabla;
                }
            }
        }
    }
}
