using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gonzalez.Datos
{
    public class Persona : Base
    {
        public List<Entidades.Persona> RecuperarTodos()
        {
            List<Entidades.Persona> personas = new List<Entidades.Persona>();
            this.OpenConnection();
            SqlCommand cmdPersonas = new SqlCommand("SELECT * FROM Personas", this.SqlConn);
            SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

            while (drPersonas.Read())
            {
                Entidades.Persona persona = new Entidades.Persona(
                    (string)drPersonas["Apellido"],
                    (string)drPersonas["Nombre"],
                    (string)drPersonas["Email"],
                    (DateTime)drPersonas["FechaNacimiento"],
                    (int)drPersonas["TipoPersona"]);

                personas.Add(persona);
            }

            this.CloseConnection();
            return personas;
        }

        public List<Entidades.Persona> RecuperarPorTipoPersona(int IDTipoPersona)
        {
            List<Entidades.Persona> personas = this.RecuperarTodos();
            List<Entidades.Persona> personasPorTipo = personas.Where(p => p.TipoPersona.Equals(IDTipoPersona)).ToList();

            return personasPorTipo;
        }

        public void Agregar(Entidades.Persona persona)
        {
            this.OpenConnection();
            SqlCommand cmdPersonas = new SqlCommand("INSERT INTO Personas(Apellido,Nombre,Email,FechaNacimiento,TipoPersona)" +
                "VALUES(@Apellido,@Nombre,@Email,@FechaNacimiento,@TipoPersona)", this.SqlConn);
            cmdPersonas.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
            cmdPersonas.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
            cmdPersonas.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = persona.Email;
            cmdPersonas.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime, 50).Value = persona.FechaNacimiento;
            cmdPersonas.Parameters.Add("@TipoPersona", SqlDbType.Int, 50).Value = persona.TipoPersona;

            cmdPersonas.ExecuteNonQuery();
            this.CloseConnection();
        }
    }
}
