using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADIGGM
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Resuelve el servidor (nombre o IP de respaldo si el DNS falla, p. ej. por VPN)
            // y ajusta las cadenas legacy que consumen los DataSets tipados aún no migrados.
            CapaDatos.Conexion.AjustarCadenasLegacy(Properties.Settings.Default);
            Application.Run(new Seguridad.FrmLogin());
            //Application.Run(new Herramientas.frmVisorLiqudaciones());
        }
    }
}
