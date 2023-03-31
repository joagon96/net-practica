using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Entidades
{
    public class Docente
    {
        public Docente() {}

        public Docente(string apellidoNombre, string cuil, string email, DateTime fechaIngreso, int id, decimal salario)
        {
            this.ApellidoNombre = apellidoNombre;
            this.Cuil = cuil;
            this.Email = email;
            this.FechaIngreso = fechaIngreso;
            this.id = id;
            this.Salario = salario;
        }
        private string _ApellidoNombre;
        public string ApellidoNombre
        {
            get { return _ApellidoNombre; }
            set { _ApellidoNombre = value; }
        }

        private string _Cuil;
        public string Cuil
        {
            get { return _Cuil; }
            set { _Cuil = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private DateTime _FechaIngreso;
        public DateTime FechaIngreso
        {
            get { return _FechaIngreso; }
            set { _FechaIngreso = value; }
        }

        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private decimal _Salario;
        public decimal Salario
        {
            get { return _Salario; }
            set { _Salario = value; }
        }

        private int _Antiguedad;
        public int Antiguedad
        {
            get 
            {
                DateTime dateZero = new DateTime(1, 1, 1);
                TimeSpan ts = DateTime.Now - this.FechaIngreso;
                return (dateZero + ts).Year - 1;
            }
        }
    }
}
