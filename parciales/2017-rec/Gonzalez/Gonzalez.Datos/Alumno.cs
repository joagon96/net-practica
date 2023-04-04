using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gonzalez.Datos
{
    public class Alumno : Base
    {
        public List<Entidades.Alumno> RecuperarTodos()
        {
            List<Entidades.Alumno> alumnos = new List<Entidades.Alumno>();
            this.OpenConnection();
            SqlCommand cmdAlumnos = new SqlCommand("SELECT * FROM Alumnos", this.SqlConn);
            SqlDataReader drAlumnos = cmdAlumnos.ExecuteReader();

            while (drAlumnos.Read())
            { 
                Entidades.Alumno alumno = new Entidades.Alumno(
                    (string)drAlumnos["ApellidoNombre"],
                    (string)drAlumnos["Dni"],
                    (string)drAlumnos["Email"],
                    (decimal)drAlumnos["NotaPromedio"],
                    (DateTime)drAlumnos["FechaNacimiento"]);

                alumnos.Add(alumno);
            }

            this.CloseConnection();
            return alumnos;
        }

        public void Agregar(Entidades.Alumno alumno)
        {
            this.OpenConnection();
            SqlCommand cmdAlumno = new SqlCommand(
                "INSERT INTO Alumnos(ApellidoNombre,Dni,Email,FechaNacimiento,NotaPromedio,ID)" +
                "VALUES(@ApellidoNombre,@Dni,@Email,@FechaNacimiento,@NotaPromedio,@ID)", this.SqlConn);
            cmdAlumno.Parameters.Add("@ApellidoNombre", SqlDbType.VarChar,50).Value = alumno.ApellidoNombre;
            cmdAlumno.Parameters.Add("@Dni", SqlDbType.VarChar, 50).Value = alumno.Dni;
            cmdAlumno.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = alumno.Email;
            cmdAlumno.Parameters.Add("@ID", SqlDbType.Int, 20).Value = alumno.ID;
            cmdAlumno.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime, 50).Value = alumno.FechaNacimiento;
            cmdAlumno.Parameters.Add("@NotaPromedio", SqlDbType.Decimal, 50).Value = alumno.NotaPromedio;
            cmdAlumno.ExecuteNonQuery();

            this.CloseConnection();
        }
    }
}
