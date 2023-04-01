using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gonzalez.Datos
{
    public class TipoPersona : Base
    {
        public List<Entidades.TipoPersona> RecuperarTodos()
        {
            List<Entidades.TipoPersona> TiposPersona = new List<Entidades.TipoPersona>();
            this.OpenConnection();
            SqlCommand cmdTiposPersona = new SqlCommand("SELECT * FROM TiposPersona", this.SqlConn);
            SqlDataReader drTipos = cmdTiposPersona.ExecuteReader();

            while (drTipos.Read())
            {
                Entidades.TipoPersona tipo = new Entidades.TipoPersona();
                tipo.ID = (int)drTipos["ID"];
                tipo.Descripcion = (string)drTipos["Descripcion"];
                TiposPersona.Add(tipo);
            }

            this.CloseConnection();
            return TiposPersona;
        }
    }
}
