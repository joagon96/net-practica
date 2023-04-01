using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonzalez.Negocio
{
    public class TipoPersona
    {
        public TipoPersona()
        {
            this.DatosTipoPersona = new Datos.TipoPersona();
        }

        private Datos.TipoPersona _DatosTipoPersona;
        public Datos.TipoPersona DatosTipoPersona
        {
            get { return _DatosTipoPersona; }
            set { _DatosTipoPersona = value; }
        }

        public List<Entidades.TipoPersona> RecuperarTodos()
        {
            return this.DatosTipoPersona.RecuperarTodos();
        }
    }
}
