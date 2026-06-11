using System;
using System.Collections.Generic;
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

        // ===== Resolución del servidor con respaldo por IP (VPN sin DNS interno) =====
        // App.config <appSettings>: ServidorNombre (ej. ADIGGM) y ServidorIp (ej. 192.168.2.77).
        // Al primer uso se intenta resolver el NOMBRE; si el DNS falla se usa la IP,
        // y esa decisión se mantiene durante TODA la sesión.

        private static string _servidor;
        private static readonly object _candado = new object();
        private static readonly Dictionary<string, string> _cadenasAjustadas = new Dictionary<string, string>();

        private static string NombreServidorConfigurado =>
            ConfigurationManager.AppSettings["ServidorNombre"] ?? "ADIGGM";

        private static string IpServidorConfigurada =>
            ConfigurationManager.AppSettings["ServidorIp"];

        /// <summary>
        /// Servidor efectivo de la sesión: el nombre si el DNS lo resuelve; si no, la IP de respaldo.
        /// </summary>
        public static string Servidor
        {
            get
            {
                if (_servidor == null)
                {
                    lock (_candado)
                    {
                        if (_servidor == null)
                        {
                            string nombre = NombreServidorConfigurado;
                            string ip = IpServidorConfigurada;
                            string resuelto = nombre;
                            if (!string.IsNullOrEmpty(ip))
                            {
                                try
                                {
                                    System.Net.Dns.GetHostEntry(nombre);
                                }
                                catch (System.Net.Sockets.SocketException)
                                {
                                    resuelto = ip; // VPN u otra red sin el DNS interno
                                }
                            }
                            _servidor = resuelto;
                        }
                    }
                }
                return _servidor;
            }
        }

        /// <summary>
        /// Si el host de la cadena es el servidor por nombre y el nombre NO resuelve,
        /// lo reemplaza por la IP de respaldo (mantiene instancia "\X" o puerto ",N").
        /// Cadenas que apuntan a otros hosts quedan intactas.
        /// </summary>
        public static string AjustarServidorEnCadena(string cadena)
        {
            if (string.IsNullOrEmpty(cadena))
                return cadena;

            string nombre = NombreServidorConfigurado;
            string servidor = Servidor;
            if (string.Equals(servidor, nombre, StringComparison.OrdinalIgnoreCase))
                return cadena; // el nombre resuelve: nada que ajustar

            DbConnectionStringBuilder builder = new DbConnectionStringBuilder();
            try { builder.ConnectionString = cadena; }
            catch (ArgumentException) { return cadena; }

            string[] clavesHost = { "Data Source", "Server", "Address", "Addr", "Network Address", "Host" };
            bool cambiado = false;
            foreach (string clave in clavesHost)
            {
                if (!builder.ContainsKey(clave))
                    continue;
                string valor = Convert.ToString(builder[clave]);
                int corte = valor.IndexOfAny(new[] { '\\', ',' });
                string host = corte < 0 ? valor : valor.Substring(0, corte);
                if (string.Equals(host, nombre, StringComparison.OrdinalIgnoreCase))
                {
                    builder[clave] = servidor + (corte < 0 ? "" : valor.Substring(corte));
                    cambiado = true;
                }
            }
            return cambiado ? builder.ConnectionString : cadena;
        }

        /// <summary>Reescribe rutas UNC \\NOMBRE\... al servidor efectivo (IP si el nombre no resuelve).</summary>
        public static string AjustarRuta(string ruta)
        {
            if (string.IsNullOrEmpty(ruta))
                return ruta;
            string nombre = NombreServidorConfigurado;
            string servidor = Servidor;
            if (string.Equals(servidor, nombre, StringComparison.OrdinalIgnoreCase))
                return ruta;
            string prefijo = @"\\" + nombre;
            if (ruta.StartsWith(prefijo + @"\", StringComparison.OrdinalIgnoreCase) ||
                string.Equals(ruta, prefijo, StringComparison.OrdinalIgnoreCase))
                return @"\\" + servidor + ruta.Substring(prefijo.Length);
            return ruta;
        }

        /// <summary>
        /// Ajusta EN MEMORIA las cadenas legacy (ADIGGM.Properties.Settings.*) que aún consumen
        /// los DataSets tipados no migrados, para que usen el servidor efectivo toda la sesión.
        /// Llamar UNA vez al arrancar (Program.Main), antes de abrir formularios.
        /// </summary>
        public static void AjustarCadenasLegacy(ApplicationSettingsBase settings)
        {
            foreach (SettingsProperty prop in settings.Properties)
            {
                SpecialSettingAttribute especial = prop.Attributes[typeof(SpecialSettingAttribute)] as SpecialSettingAttribute;
                if (especial == null || especial.SpecialSetting != SpecialSetting.ConnectionString)
                    continue;

                string actual = settings[prop.Name] as string; // materializa el valor desde el config
                string ajustada = AjustarServidorEnCadena(actual);
                if (!string.Equals(actual, ajustada, StringComparison.Ordinal))
                    settings.PropertyValues[prop.Name].PropertyValue = ajustada;
            }
        }

        /// <summary>Devuelve la cadena de conexión por nombre desde App.config (con el servidor efectivo).</summary>
        public static string Cadena(string nombre)
        {
            lock (_candado)
            {
                string ajustada;
                if (_cadenasAjustadas.TryGetValue(nombre, out ajustada))
                    return ajustada;
            }

            ConnectionStringSettings cfg = ConfigurationManager.ConnectionStrings[nombre];
            if (cfg == null)
                throw new ConfigurationErrorsException(
                    "No existe la cadena de conexión '" + nombre +
                    "' en la sección <connectionStrings> de App.config.");

            string resultado = AjustarServidorEnCadena(cfg.ConnectionString);
            lock (_candado)
            {
                _cadenasAjustadas[nombre] = resultado;
            }
            return resultado;
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
            con.ConnectionString = Cadena(nombre);
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
