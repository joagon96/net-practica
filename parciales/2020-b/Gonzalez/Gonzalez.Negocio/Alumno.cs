using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Negocio
{
    public class Alumno
    {
        public Alumno()
        {
            this.AlumnoDatos = new Datos.Alumno();
        }

        private Datos.Alumno _AlumnoDatos;
        public Datos.Alumno AlumnoDatos
        {
            get { return _AlumnoDatos; }
            set { _AlumnoDatos = value; }
        }

        private Validaciones _Validaciones;
        public Validaciones Validaciones
        {
            get { return _Validaciones; }
            set { _Validaciones = value; }
        }

        public List<Entitdades.Alumno> RecuperarTodos()
        {
            return this.AlumnoDatos.RecuperarTodos();
        }

        public void Agregar(Entitdades.Alumno alumno)
        {
            this.AlumnoDatos.Agregar(alumno);
        }

        public Entitdades.Alumno RecuperarUno(string dni)
        {
            if (dni.Length == 0)
            {
                throw new Exception("Dni es requerido");
            }

            return this.AlumnoDatos.RecuperarUno(dni);
                       
        }
    }
}
