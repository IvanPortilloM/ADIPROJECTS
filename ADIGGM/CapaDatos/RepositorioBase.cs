using System;
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

        /// <summary>
        /// Persiste los cambios de un DataTable (filas Agregadas/Modificadas/Eliminadas) usando
        /// los SQL indicados, todo dentro de UNA transacción. Reemplaza a TableAdapter.Update()
        /// para los formularios de mantenimiento con grilla editable. Reutilizable.
        /// Los nombres de parámetros en el SQL deben coincidir con los nombres de columna
        /// (p. ej. @IdTipoOperacion, @NombreOperacion).
        ///
        /// Concurrencia optimista (paridad con los TableAdapters originales): si se pasan
        /// <paramref name="tablaSql"/> y <paramref name="pkColumna"/>, antes de cada UPDATE/DELETE
        /// se relee la fila (WITH UPDLOCK, HOLDLOCK, dentro de la transacción) y se compara con la
        /// versión ORIGINAL del DataTable; si otro usuario la modificó o eliminó se lanza
        /// <see cref="DBConcurrencyException"/> y se revierte TODO. Aun sin tabla/pk, un
        /// UPDATE/DELETE que afecte 0 filas también lanza (la fila ya no existe).
        /// </summary>
        protected int GuardarCambios(DataTable tabla, string sqlInsert, string sqlUpdate, string sqlDelete,
            string tablaSql = null, string pkColumna = null)
        {
            bool verificar = !string.IsNullOrEmpty(tablaSql) && !string.IsNullOrEmpty(pkColumna);
            using (DbConnection con = CrearConexion())
            {
                con.Open();
                using (IDbTransaction trans = con.BeginTransaction())
                {
                    try
                    {
                        int afectadas = 0;
                        foreach (DataRow fila in tabla.Rows)
                        {
                            switch (fila.RowState)
                            {
                                case DataRowState.Deleted:
                                    if (!string.IsNullOrEmpty(sqlDelete))
                                    {
                                        if (verificar) VerificarConcurrencia(con, trans, tabla, fila, tablaSql, pkColumna);
                                        afectadas += EjecutarFila(con, trans, sqlDelete, ParametrosDeFila(tabla, fila, DataRowVersion.Original));
                                    }
                                    break;
                                case DataRowState.Added:
                                    if (!string.IsNullOrEmpty(sqlInsert))
                                        afectadas += con.Execute(sqlInsert, ParametrosDeFila(tabla, fila, DataRowVersion.Current), trans);
                                    break;
                                case DataRowState.Modified:
                                    if (!string.IsNullOrEmpty(sqlUpdate))
                                    {
                                        if (verificar) VerificarConcurrencia(con, trans, tabla, fila, tablaSql, pkColumna);
                                        afectadas += EjecutarFila(con, trans, sqlUpdate, ParametrosDeFila(tabla, fila, DataRowVersion.Current));
                                    }
                                    break;
                            }
                        }
                        trans.Commit();
                        tabla.AcceptChanges();
                        return afectadas;
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>UPDATE/DELETE de una fila; 0 filas afectadas = la fila ya no existe en la BD.</summary>
        private static int EjecutarFila(DbConnection con, IDbTransaction trans, string sql, DynamicParameters parametros)
        {
            int n = con.Execute(sql, parametros, trans);
            if (n == 0)
                throw new DBConcurrencyException("El registro fue eliminado por otro usuario. Recargue e intente de nuevo.");
            return n;
        }

        /// <summary>
        /// Relee la fila por PK (UPDLOCK+HOLDLOCK: queda bloqueada hasta el commit) y compara cada
        /// columna del DataTable contra su versión ORIGINAL. Si la fila no existe o cambió, lanza
        /// DBConcurrencyException (mismo tipo que lanzaban los TableAdapters).
        /// </summary>
        private static void VerificarConcurrencia(DbConnection con, IDbTransaction trans, DataTable tabla,
            DataRow fila, string tablaSql, string pkColumna)
        {
            // La versión Original de la PK: para filas Modified la PK no cambia, pero se usa
            // Original por consistencia (y es la única versión accesible en filas Deleted).
            object pk = fila[pkColumna, DataRowVersion.Original];
            var p = new DynamicParameters();
            p.Add("pk", pk);
            IDictionary<string, object> actual;
            using (IDataReader reader = con.ExecuteReader(
                "SELECT * FROM " + tablaSql + " WITH (UPDLOCK, HOLDLOCK) WHERE " + pkColumna + " = @pk", p, trans))
            {
                if (!reader.Read())
                    throw new DBConcurrencyException("El registro fue eliminado por otro usuario. Recargue e intente de nuevo.");
                actual = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
                for (int i = 0; i < reader.FieldCount; i++)
                    actual[reader.GetName(i)] = reader.GetValue(i);
            }

            foreach (DataColumn col in tabla.Columns)
            {
                // Solo se comparan columnas que existen en la tabla real (el DataTable puede traer
                // columnas calculadas del SELECT original que no están en la tabla física).
                if (!actual.TryGetValue(col.ColumnName, out object valorBd)) continue;
                if (!ValoresIguales(fila[col, DataRowVersion.Original], valorBd))
                    throw new DBConcurrencyException("El registro fue modificado por otro usuario. Recargue e intente de nuevo.");
            }
        }

        /// <summary>Igualdad tolerante para la comparación de concurrencia: DBNull==DBNull,
        /// byte[] por contenido, el resto con Equals (los tipos coinciden porque la fila
        /// Original salió del mismo SELECT de la tabla).</summary>
        private static bool ValoresIguales(object a, object b)
        {
            bool aNull = a == null || a == DBNull.Value, bNull = b == null || b == DBNull.Value;
            if (aNull || bNull) return aNull && bNull;
            if (a is byte[] ba && b is byte[] bb)
            {
                if (ba.Length != bb.Length) return false;
                for (int i = 0; i < ba.Length; i++) if (ba[i] != bb[i]) return false;
                return true;
            }
            return a.Equals(b);
        }

        /// <summary>Construye los parámetros Dapper a partir de las columnas de una fila (versión indicada).</summary>
        private static DynamicParameters ParametrosDeFila(DataTable tabla, DataRow fila, DataRowVersion version)
        {
            DynamicParameters p = new DynamicParameters();
            foreach (DataColumn col in tabla.Columns)
            {
                object valor = fila[col, version];
                p.Add(col.ColumnName, valor == DBNull.Value ? null : valor);
            }
            return p;
        }
    }
}
