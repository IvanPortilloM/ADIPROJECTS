using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADIGGM.Clases
{
    public interface IContract
    {
        void Ejecutar (int Var1, int Var2, int Var3, DateTime Fec1, DateTime Fec2, string Var4);
        //void Ejecurar1(string Var1);
    }
}
