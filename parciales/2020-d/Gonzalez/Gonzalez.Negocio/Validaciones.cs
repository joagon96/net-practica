using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Negocio
{
    public static class Validaciones
    {
        const int cuilLength = 11;
        public static bool EsCuilValido(string cuil)
        {
            List<string> iniciosValidos = new List<string>() { "20", "27", "33" };
            string inicio = cuil.Substring(0, 2);

            return iniciosValidos.Contains(inicio) && cuil.Length != cuilLength;

  
        }
    }
}
