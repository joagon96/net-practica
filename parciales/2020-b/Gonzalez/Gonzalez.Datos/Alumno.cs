using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Gonzalez.Datos
{
    public class Alumno : Base
    {
        public List<Entitdades.Alumno> RecuperarTodos()
        {
            List<Entitdades.Alumno> alumnos = new List<Entitdades.Alumno>();
            this.OpenConnection();
            SqlCommand cmdAlumno = new SqlCommand("SELECT * FROM Alumnos",SqlConn);
            SqlDataReader drAlumnos = cmdAlumno.ExecuteReader();

            while (drAlumnos.Read())
            {
                Entitdades.Alumno alumno = new Entitdades.Alumno(
                    (string)drAlumnos["ApellidoNombre"],
                    (string)drAlumnos["Dni"],
                    (string)drAlumnos["Email"],
                    (DateTime)drAlumnos["FechaNacimiento"],
                    (decimal)drAlumnos["NotaPromedio"]);

                alumnos.Add(alumno);
            }
            this.CloseConnection();

            return alumnos;
        }

        public void Agregar(Entitdades.Alumno alumno)
        {
            this.OpenConnection();
            SqlCommand cmdAlumno = new SqlCommand(
                "INSERT INTO Alumnos(ApellidoNombre,Dni,Email,FechaNacimiento,NotaPromedio)" +
                "VALUES(@ApellidoNombre,@Dni,@Email,@FechaNacimiento,@NotaPromedio)", this.SqlConn);
            cmdAlumno.Parameters.Add("@ApellidoNombre", SqlDbType.VarChar, 50).Value = alumno.ApellidoNombre;
            cmdAlumno.Parameters.Add("@Dni", SqlDbType.VarChar, 50).Value = alumno.Dni;
            cmdAlumno.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = alumno.Email;
            cmdAlumno.Parameters.Add("@FechaNacimiento", SqlDbType.DateTime, 50).Value = alumno.FechaNacimiento;
            cmdAlumno.Parameters.Add("@NotaPromedio", SqlDbType.Decimal, 50).Value = alumno.NotaPromedio;
            cmdAlumno.ExecuteNonQuery();
            this.CloseConnection();
        }

        public Entitdades.Alumno RecuperarUno(string dni)
        {
            List<Entitdades.Alumno> alumnos = new List<Entitdades.Alumno>();
            alumnos = RecuperarTodos();
            return alumnos.Where(a => a.Dni.Equals(dni)).First();
        }
    }
}
