using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADIGGM.Clases
{
    public class VarGlobales
    {
        public static string nombreSistema = "A.D.I.-GGM";
        //public static int usuarioSistema;
        public static string Usuario;
        public static int IdUsuario;
        public static int IdPerfil;
        public static string Division;
        public static int Departamento = 1;
        public static string tempVar = "";
        //public static DateTime primerPago = DateTime.Now;
        //public static DateTime formalizacion = DateTime.Now;
        // Rutas al servidor: pasan por Conexion para usar la IP de respaldo cuando el nombre no resuelve (VPN)
        public static string urlReportes = "http://" + CapaDatos.Conexion.Servidor + "/ReportServer";
        public static string dirFotos = CapaDatos.Conexion.AjustarRuta(@"\\ADIGGM\Publish\ADIPROJECTS\BD_Fotos\");
        public static string dirFotosCarnets = CapaDatos.Conexion.AjustarRuta(@"\\ADIGGM\Publish\ADIPROJECTS\FotosCarnets\");
        public static string dirEstadosDeCuenta = CapaDatos.Conexion.AjustarRuta(@"\\ADIGGM\Publish\ADIPROJECTS\EstadosDeCuenta\");
        public static string _gCarpetaReportes = "/ADIGGM/";
        //public string CodigoSistema = "007";
        //public static string CodigoSistemaMenu = "007";
        public static DataSets.DsTransporteAdiggmTableAdapters.ConsultasTrans consultasTrans = new DataSets.DsTransporteAdiggmTableAdapters.ConsultasTrans();
        public static DataSets.DsOCTableAdapters.ConsultasOC consultasOC = new DataSets.DsOCTableAdapters.ConsultasOC();
        public static DataSetsWeb.DsOCWebTableAdapters.ConsultasOCWeb consultasOCWeb = new DataSetsWeb.DsOCWebTableAdapters.ConsultasOCWeb();
        public static DataSets.DsPresupuestoTableAdapters.SP_Presupuesto consultasPR = new DataSets.DsPresupuestoTableAdapters.SP_Presupuesto();
        //public static DataSet.GGMDataSetTableAdapters.ConsultasGGM consultasGGM = new ConsultasGGM();
    }
}
