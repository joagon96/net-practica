using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Entidades
{
    public class Persona
    {
        public Persona() {}
        public Persona(string apellido, string nombre, string email, DateTime fechaNacimiento, int tipoPersona)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Email = email;
            this.FechaNacimiento = fechaNacimiento;
            this.TipoPersona = tipoPersona;
        }
        private string _Apellido;
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private DateTime _FechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        private int _TipoPersona ;
        public int TipoPersona
        {
            get { return _TipoPersona; }
            set { _TipoPersona = value; }
        }
    }
}
