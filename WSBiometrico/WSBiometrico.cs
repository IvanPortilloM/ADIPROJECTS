using System;
using System.Configuration;
using System.ServiceProcess;

namespace WSBiometrico
{
    /// <summary>Servicio Windows que recibe las marcas del reloj biométrico ZKTeco vía PUSH/ADMS
    /// (ver ServidorAdms) y las guarda en BIO_Marcas. Patrón hermano de WSCorreos.</summary>
    public class WSBiometrico : ServiceBase
    {
        private ServidorAdms _servidor;

        public WSBiometrico()
        {
            ServiceName = "WSBiometrico";
        }

        internal static int PuertoConfigurado()
        {
            int puerto;
            string valor = ConfigurationManager.AppSettings["PuertoAdms"];
            return int.TryParse(valor, out puerto) ? puerto : 8081;
        }

        protected override void OnStart(string[] args)
        {
            Bitacora.Escribir("=== WSBiometrico iniciando (puerto " + PuertoConfigurado() + ") ===");
            _servidor = new ServidorAdms(PuertoConfigurado(), Bitacora.Escribir);
            _servidor.Iniciar();
        }

        protected override void OnStop()
        {
            if (_servidor != null) _servidor.Detener();
            Bitacora.Escribir("=== WSBiometrico detenido ===");
        }
    }
}
