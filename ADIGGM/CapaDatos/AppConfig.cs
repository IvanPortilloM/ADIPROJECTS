using System.Configuration;

namespace ADIGGM.CapaDatos
{
    /// <summary>
    /// Acceso centralizado a credenciales y parámetros sensibles (appSettings).
    /// Los valores REALES (rotados) viven SOLO en 'secrets.config' (gitignored, override
    /// del App.config vía file="secrets.config"). El App.config versionado tiene las claves
    /// VACÍAS. No commitear secretos. Para desplegar, copiar secrets.config junto al .exe.
    /// </summary>
    public static class AppConfig
    {
        private static string Get(string clave, string porDefecto = "")
        {
            return ConfigurationManager.AppSettings[clave] ?? porDefecto;
        }

        // --- Servidor de reportes (SSRS) ---
        public static string ReportServerUsuario => Get("ReportServerUsuario");
        public static string ReportServerClave => Get("ReportServerClave");
        public static string ReportServerDominio => Get("ReportServerDominio");

        // --- Correo SMTP (cuenta de servicios serviciosadiggm@) ---
        public static string SmtpUsuario => Get("SmtpUsuario");
        public static string SmtpClave => Get("SmtpClave");

        // --- Correo SMTP (estados de cuenta, jlanza@) ---
        public static string SmtpEdoCtaUsuario => Get("SmtpEdoCtaUsuario");
        public static string SmtpEdoCtaClave => Get("SmtpEdoCtaClave");
    }
}
