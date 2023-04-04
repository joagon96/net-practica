using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Utiles
{
    public class Validaciones
    {
        public static bool EsFechaDeNacimientoValida(DateTime fecha)
        {
            DateTime ZeroDate = new DateTime(1, 1, 1);
            TimeSpan ts = DateTime.Now - fecha;
            double edad =  (ZeroDate + ts).Year - 1;

            return edad > 0 && edad <= 110;
        }
    }
}
