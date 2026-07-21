using System;
using System.IO;

namespace WSBiometrico
{
    /// <summary>Bitácora simple a archivo diario (Logs\adms-yyyyMMdd.log junto al .exe) con eco
    /// opcional a consola (modo interactivo de pruebas). Thread-safe (lock por escritura).</summary>
    public static class Bitacora
    {
        private static readonly object _candado = new object();
        private static readonly string _carpeta =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

        public static bool EcoConsola;

        public static void Escribir(string mensaje)
        {
            string linea = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  " + mensaje;
            lock (_candado)
            {
                try
                {
                    Directory.CreateDirectory(_carpeta);
                    File.AppendAllText(
                        Path.Combine(_carpeta, "adms-" + DateTime.Today.ToString("yyyyMMdd") + ".log"),
                        linea + Environment.NewLine);
                }
                catch { /* la bitácora nunca debe tumbar el servicio */ }
            }
            if (EcoConsola)
            {
                try { Console.WriteLine(linea); } catch { }
            }
        }
    }
}
