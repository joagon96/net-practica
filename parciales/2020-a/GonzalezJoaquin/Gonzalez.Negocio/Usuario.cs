using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Gonzalez.Negocio
{
    public class Usuario
    {
        public Usuario()
        {
            this.UsuarioData = new Datos.Usuario();
        }

        public Datos.Usuario _UsuarioData;
        private Datos.Usuario UsuarioData
        {
            get { return _UsuarioData; }
            set { _UsuarioData = value; }
        }

        public List<Entitdades.Usuario> RecuperarTodos()
        {
            return this.UsuarioData.RecuperarTodos();
        }

        public void Agregar(Entitdades.Usuario usr)
        {
            this.UsuarioData.Agregar(usr);
        }

        public Entitdades.Usuario RecuperarUno(string nombre)
        {
            Entitdades.Usuario usr = this.UsuarioData.RecuperarUno(nombre);
            if (usr.NombreUsuario.Length == 0)
            {
                throw new Exception("Nombre de usuario no valido");
            }
            return usr;
        }

        public bool validaciones(Entitdades.Usuario usr)
        {

            return usr.NombreUsuario.Length > 0 &&
                usr.Email.Length > 0 &&
                usr.Clave.Length > 0 &&
                EsEmailValido(usr.Email);
        }

        private static bool EsEmailValido(string email)
        {
            string regex = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
            return true;
        }
    }
}
