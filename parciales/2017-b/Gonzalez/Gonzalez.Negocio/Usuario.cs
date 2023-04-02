using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Negocio
{
    public class Usuario
    {
        public Usuario()
        {
            this.DatosUsuario = new Datos.Usuario();
        }
        private Datos.Usuario _DatosUsuario;
        public Datos.Usuario DatosUsuario { get { return _DatosUsuario; } set { _DatosUsuario = value; } }
        public static List<Entitdades.Usuario> RecuperarTodos()
        {
            Usuario usr = new Usuario();
            return usr.DatosUsuario.RecuperarTodos();
        }

        public static void Agregar(Entitdades.Usuario usuario)
        {
            Usuario usr = new Usuario();
            usr.DatosUsuario.Agregar(usuario);
        }

        public static void Eliminar(string nombreUsuario)
        {
            try
            {
                Usuario usr = new Usuario();
                usr.DatosUsuario.Eliminar(nombreUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
