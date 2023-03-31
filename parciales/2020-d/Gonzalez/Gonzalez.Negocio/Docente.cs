using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Negocio
{
    public class Docente
    {
        public Docente()
        {
            this.DatosDocente = new Datos.Docente();
        }

        private Datos.Docente _DatosDocente;
        public Datos.Docente DatosDocente
        {
            get { return _DatosDocente; }
            set { _DatosDocente = value; }
        }

        public List<Entidades.Docente> RecuperarTodos()
        {
            return this.DatosDocente.RecuperarTodos();
        }

        public Entidades.Docente RecuperarUno(string cuil)
        {
            if (Validaciones.EsCuilValido(cuil))
            {
                return this.DatosDocente.RecuperarUno(cuil);
            }

            throw new Exception("Cuil invalido");
            
        }

        public void Agregar(Entidades.Docente docente) 
        {
            this.DatosDocente.Agregar(docente);
        }
    }
}
