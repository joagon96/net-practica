using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    class DocenteCurso : BusinessEntity
    {
        private TiposCargos _tipoCargo;
        public TiposCargos tipoCargo
        {
            get { return _tipoCargo; }
            set { _tipoCargo = value; }
        }

        private int _IDCurso;
        public int IDCurso
        {
            get { return _IDCurso; }
            set { _IDCurso = value; }
        }

        private int _IDDocente;
        public int IDDocente
        {
            get { return _IDDocente; }
            set { _IDDocente = value; }
        }

        public enum TiposCargos
        {
            Profesor,
            Director
        }
    }
}
