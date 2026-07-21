using System.ComponentModel;
using System.Configuration.Install;
using System.ServiceProcess;

namespace WSBiometrico
{
    /// <summary>Instalador del servicio (installutil.exe WSBiometrico.exe). Mismo esquema que
    /// WSCorreos: cuenta LocalSystem, arranque automático.</summary>
    [RunInstaller(true)]
    public class ProjectInstaller : Installer
    {
        public ProjectInstaller()
        {
            var proceso = new ServiceProcessInstaller
            {
                Account = ServiceAccount.LocalSystem,
                Username = null,
                Password = null
            };
            var servicio = new ServiceInstaller
            {
                ServiceName = "WSBiometrico",
                DisplayName = "WSBiometrico",
                Description = "Recibe las marcas del reloj biométrico ZKTeco (PUSH/ADMS) para el sistema ADI",
                StartType = ServiceStartMode.Automatic
            };
            Installers.Add(proceso);
            Installers.Add(servicio);
        }
    }
}
