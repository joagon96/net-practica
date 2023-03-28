using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Entitdades
{
    public class Usuario
    {
        public Usuario(){}

        private string _Clave;
        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _NombreUsuario;
        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }

        private int _TipoUsuario;
        public int TipoUsuario
        {
            get { return _TipoUsuario; }
            set { _TipoUsuario = value; }
        }

        private DateTime _UltimoIngreso;
        public DateTime UltimoIngreso
        {
            get { return _UltimoIngreso; }
            set { _UltimoIngreso = value; }
        }

        private double _DiasUltimoIngreso;
        public double DiasUltimoIngreso
        {
            get
            {
                return (DateTime.Now - UltimoIngreso).TotalDays;
            }
        }
    }
}
