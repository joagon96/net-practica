using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Entitdades
{
    public class Alumno
    {
        public Alumno(){}
        public Alumno(string apellidoNombre, string dni, string email, DateTime fechaNacimiento, decimal notaPromedio )
        {
            this.ApellidoNombre = apellidoNombre;
            this.Dni = dni;
            this.Email = email;
            this.FechaNacimiento = fechaNacimiento;
            this.NotaPromedio = notaPromedio;
        }

        private string _ApellidoNombre;
        public string ApellidoNombre
        {
            get { return _ApellidoNombre; }
            set { _ApellidoNombre = value; }
        }

        private string _Dni;
        public string Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
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

        private decimal _NotaPromedio;
        public decimal NotaPromedio
        {
            get { return _NotaPromedio; }
            set { _NotaPromedio = value; }
        }
        public double Edad
        {
            get
            {
                DateTime zeroTime = new DateTime(1, 1, 1);
                DateTime dt = DateTime.Now;
                TimeSpan ts = dt - FechaNacimiento;
                return (zeroTime + ts).Year - 1;
            }
        }
    }
}
