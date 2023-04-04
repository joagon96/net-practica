using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Entidades
{
    public class Alumno
    {
        public Alumno() {}

        public Alumno(string apellidoNombre, string dni, string email, decimal notaPromedio, DateTime fechaNacimiento)
        {
            this.ApellidoNombre = apellidoNombre;
            this.Dni = dni;
            this.Email = email;
            this.ID = 1;
            this.NotaPromedio = notaPromedio;
            this.FechaNacimiento = fechaNacimiento;
        }

        private string _ApellidoNombre, _Dni, _Email;
        private int _ID;
        private decimal _NotaPromedio;
        private DateTime _FechaNacimiento;

        public string ApellidoNombre { get { return _ApellidoNombre; } set { _ApellidoNombre = value; } }
        public string Dni { get { return _Dni; } set { _Dni = value; } }
        public string Email { get { return _Email; } set { _Email = value; } }
        public int ID { get { return _ID; } set { _ID = value; } }
        public decimal NotaPromedio { get { return _NotaPromedio; } set { _NotaPromedio = value; } }
        public DateTime FechaNacimiento { get { return _FechaNacimiento; } set { _FechaNacimiento = value; } }

        public int Edad
        {
            get
            {
                DateTime ZeroDate = new DateTime(1, 1, 1);
                TimeSpan ts = DateTime.Now - this.FechaNacimiento;
                return (ZeroDate + ts).Year - 1;
            }
        }
    }
}
