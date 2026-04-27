using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADIGGM.CapaModelo
{
    public class Menu
    {
        public string Nombre { get; set; }
        public string NombreFormulario { get; set; }
        public string NombreMenu { get; set; }
        public string Icono { get; set; }
        public List<SubMenu> ListaSubMenu {get; set;}
    }
}
