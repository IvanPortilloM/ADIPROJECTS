using System;
using System.ServiceProcess;

namespace WSBiometrico
{
    internal static class Program
    {
        /// <summary>
        /// Doble modo: lanzado desde consola (doble clic o terminal) corre INTERACTIVO — ideal para
        /// probar contra el reloj viendo cada petición en vivo, sin instalar nada. Instalado como
        /// servicio Windows (installutil, igual que WSCorreos) corre como ServiceBase.
        /// </summary>
        static void Main()
        {
            if (Environment.UserInteractive)
            {
                Bitacora.EcoConsola = true;
                Console.WriteLine("WSBiometrico — modo CONSOLA (pruebas). Para instalarlo como servicio:");
                Console.WriteLine(@"  C:\Windows\Microsoft.NET\Framework64\v4.0.30319\installutil.exe WSBiometrico.exe");
                Console.WriteLine();
                var servidor = new ServidorAdms(WSBiometrico.PuertoConfigurado(), Bitacora.Escribir);
                servidor.Iniciar();
                Console.WriteLine("Presione ENTER para detener...");
                Console.ReadLine();
                servidor.Detener();
            }
            else
            {
                ServiceBase.Run(new ServiceBase[] { new WSBiometrico() });
            }
        }
    }
}
