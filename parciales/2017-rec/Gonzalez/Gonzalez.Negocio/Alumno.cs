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
            this.DatosAlumno = new Datos.Alumno();
        }

        private Datos.Alumno _DatosAlumno;
        public Datos.Alumno DatosAlumno { get { return _DatosAlumno; } set { _DatosAlumno = value; } }
        public static List<Entidades.Alumno> RecuperarTodos()
        {
            Alumno negocio = new Alumno();
            return negocio.DatosAlumno.RecuperarTodos();
        }

        public static void Agregar(Entidades.Alumno alumno)
        {
            Alumno negocio = new Alumno();
            negocio.DatosAlumno.Agregar(alumno);
        }
    }
}
