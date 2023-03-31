using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gonzalez.Datos
{
    public class Docente : Base
    {
        public List<Entidades.Docente> RecuperarTodos()
        {
            List<Entidades.Docente> docentes = new List<Entidades.Docente>();
            this.OpenConnection();
            SqlCommand cmdDocentes = new SqlCommand("SELECT * FROM Docentes;",SqlConn);
            SqlDataReader drDocentes = cmdDocentes.ExecuteReader();

            while (drDocentes.Read())
            {
                Entidades.Docente docente = new Entidades.Docente(
                    (string)drDocentes["ApellidoNombre"],
                    (string)drDocentes["Cuil"],
                    (string)drDocentes["Email"],
                    (DateTime)drDocentes["FechaIngreso"],
                    (int)drDocentes["IdDocente"],
                    (decimal)drDocentes["Salario"]
                    );

                docentes.Add(docente);
            }

            this.CloseConnection();

            return docentes;
        }

        public Entidades.Docente RecuperarUno(string cuil)
        {
            List<Entidades.Docente> docentes = this.RecuperarTodos();
            return docentes.Where(d => d.Cuil.Equals(cuil)).First();
        }

        public void Agregar(Entidades.Docente docente)
        {
            this.OpenConnection();
            SqlCommand cmdDocentes = new SqlCommand(
                "INSERT INTO Docentes(IdDocente,Cuil,ApellidoNombre,Email,FechaIngreso,Salario)" +
                "VALUES(@IdDocente,@Cuil,@ApellidoNombre,@Email,@FechaIngreso,@Salario)", SqlConn);
            cmdDocentes.Parameters.Add("@IdDocente", SqlDbType.Int, 50).Value = docente.id;
            cmdDocentes.Parameters.Add("@Cuil", SqlDbType.VarChar, 50).Value = docente.Cuil;
            cmdDocentes.Parameters.Add("@ApellidoNombre", SqlDbType.VarChar, 50).Value = docente.ApellidoNombre;
            cmdDocentes.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = docente.Email;
            cmdDocentes.Parameters.Add("@FechaIngreso", SqlDbType.DateTime, 50).Value = docente.FechaIngreso;
            cmdDocentes.Parameters.Add("@Salario", SqlDbType.Decimal, 50).Value = docente.Salario;
            cmdDocentes.ExecuteNonQuery();
            this.CloseConnection();
        }
    }
}
