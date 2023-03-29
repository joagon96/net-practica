using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Negocio
{
    public class Validaciones
    {
        public static bool EsMailValido(string mail)
        {
            return true;
        }

        public bool Validar(Entitdades.Alumno a)
        {
            return a.Dni.Length > 0 
                && a.ApellidoNombre.Length > 0
                && a.Email.Length > 0
                && EsMailValido(a.Email);
        }
    }
}
