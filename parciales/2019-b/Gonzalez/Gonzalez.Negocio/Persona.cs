using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Negocio
{
    public class Persona
    {
        public Persona()
        {
            this.DatosPersona = new Datos.Persona();
        }

        private Datos.Persona _DatosPersona;
        public Datos.Persona DatosPersona
        {
            get { return _DatosPersona; }
            set { _DatosPersona = value; }
        }

        public List<Entidades.Persona> RecuperarTodos()
        {
            return this.DatosPersona.RecuperarTodos();
        }

        public List<Entidades.Persona> RecuperarPorTipoPersona(int IDTipoPersona)
        {
            return this.DatosPersona.RecuperarPorTipoPersona(IDTipoPersona);
        }

        public void Agregar(Entidades.Persona persona)
        {
            this.DatosPersona.Agregar(persona);
        }
    }
}
