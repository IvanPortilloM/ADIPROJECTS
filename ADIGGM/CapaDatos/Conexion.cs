using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// FUENTE ÚNICA de cadenas de conexión y de creación de conexiones del sistema.
    ///
    /// Todas las cadenas viven en App.config (sección &lt;connectionStrings&gt;).
    /// Para migrar de servidor, de credenciales o de MOTOR de base de datos,
    /// se edita ÚNICAMENTE App.config (el atributo providerName define el motor).
    ///
    /// Reemplaza el hardcodeo de cadenas que antes estaba disperso por todo el proyecto.
    /// </summary>
    public class Conexion
    {
        // ---- Nombres canónicos de cadenas (deben existir en App.config) ----
        public const string TRANSPORTE = "TransporteAdiggm";
        public const string PERMISOS = "Permisos";
        public const string CA = "CA";
        public const string PRESUPUESTO = "Presupuesto";
        public const string COVIBASE = "Covibase";
        public const string COVIPRUEBAS = "Covipruebas";
        public const string SAC_MYSQL = "SAC_MySql";

        /// <summary>Devuelve la cadena de conexión por nombre desde App.config.</summary>
        public static string Cadena(string nombre)
        {
            ConnectionStringSettings cfg = ConfigurationManager.ConnectionStrings[nombre];
            if (cfg == null)
                throw new ConfigurationErrorsException(
                    "No existe la cadena de conexión '" + nombre +
                    "' en la sección <connectionStrings> de App.config.");
            return cfg.ConnectionString;
        }

        /// <summary>Nombre del proveedor (motor) configurado para esa cadena.</summary>
        public static string Proveedor(string nombre)
        {
            ConnectionStringSettings cfg = ConfigurationManager.ConnectionStrings[nombre];
            if (cfg == null)
                throw new ConfigurationErrorsException(
                    "No existe la cadena de conexión '" + nombre + "' en App.config.");
            return string.IsNullOrEmpty(cfg.ProviderName) ? "System.Data.SqlClient" : cfg.ProviderName;
        }

        /// <summary>
        /// Crea una conexión AGNÓSTICA del motor (DbConnection) usando el providerName de App.config.
        /// Permite migrar de SQL Server a otro motor cambiando solo el providerName en el config.
        /// Devuelve la conexión CERRADA; el llamador debe abrirla y liberarla (using).
        /// </summary>
        public static DbConnection CrearConexion(string nombre)
        {
            ConnectionStringSettings cfg = ConfigurationManager.ConnectionStrings[nombre];
            if (cfg == null)
                throw new ConfigurationErrorsException(
                    "No existe la cadena de conexión '" + nombre + "' en App.config.");

            string proveedor = string.IsNullOrEmpty(cfg.ProviderName) ? "System.Data.SqlClient" : cfg.ProviderName;
            DbProviderFactory factory = DbProviderFactories.GetFactory(proveedor);
            DbConnection con = factory.CreateConnection();
            con.ConnectionString = cfg.ConnectionString;
            return con;
        }

        /// <summary>
        /// Crea una SqlConnection (SQL Server) ya tipada, por comodidad para el código existente.
        /// </summary>
        public static SqlConnection CrearSql(string nombre)
        {
            return new SqlConnection(Cadena(nombre));
        }

        // ===== Compatibilidad con el código existente (no romper llamadas previas) =====
        // Antes eran literales hardcodeados; ahora se resuelven desde App.config.
        public static string cn => Cadena(PERMISOS);
        public static string TransporteADI => Cadena(TRANSPORTE);
    }
}
