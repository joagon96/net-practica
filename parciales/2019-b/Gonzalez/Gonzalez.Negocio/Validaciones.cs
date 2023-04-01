using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Negocio
{
    public static class Validaciones
    {
        public static bool Requeridos(Entidades.Persona persona)
        {
            return persona.Apellido != string.Empty &&
                persona.Nombre != string.Empty &&
                persona.Email != string.Empty;
        }
        public static bool EsFechaNacimientoValida(DateTime fechaNacimiento)
        {
            return fechaNacimiento.Date < DateTime.Now.Date;
        }
    }
}
