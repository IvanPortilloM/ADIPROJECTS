using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADIGGM.OC.ViewModels
{
    public class OCWebViewModel
    {
        public int IdOC_pk { get; set; }
        public int IdOC { get; set; }
        public string Correlativo { get; set; }
        public string TipoOrden { get; set; }
        public string Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Accion { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
    }
}
