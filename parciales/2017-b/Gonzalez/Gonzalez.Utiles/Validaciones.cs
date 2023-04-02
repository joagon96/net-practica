using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Gonzalez.Utiles
{
    public class Validaciones
    {
        public static bool EsMailValido(string mail)
        {
            return true;
        }

        const string EmailRegExp = @"/^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/.";
    }
}
