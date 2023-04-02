using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Entitdades
{
    public class Usuario
    {
        public Usuario() {}
        public Usuario(string nombreUsuario, string email, string clave, int tipoUsuario, DateTime ultimoIngreso)
        {
            this.NombreUsuario = nombreUsuario;
            this.Email = email;
            this.Clave = clave;
            this.TipoUsuario = tipoUsuario;
            this.UltimoIngreso = ultimoIngreso;
        }

        private string _NombreUsuario, _Email, _Clave;
        private int _TipoUsuario, _DiasUltimnoIngresol;
        private DateTime _UltimoIngreso;

        public string NombreUsuario { get { return _NombreUsuario; } set { _NombreUsuario = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        public string Clave { get { return _Clave; } set { _Clave = value; } }
        public int TipoUsuario { get { return _TipoUsuario; } set { _TipoUsuario = value; } }
        public DateTime UltimoIngreso { get { return _UltimoIngreso; } set { _UltimoIngreso = value; } }
        public int DiasUltimoIngreso
        {
            get
            {
                DateTime ZeroDate = new DateTime(1, 1, 1);
                TimeSpan ts = DateTime.Now - this.UltimoIngreso;
                return (ZeroDate + ts).Year - 1;
            }
        }
    }
}


