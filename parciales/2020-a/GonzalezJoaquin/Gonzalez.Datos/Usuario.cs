using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gonzalez.Entitdades;
using System.Data.SqlClient;
using System.Data;

namespace Gonzalez.Datos
{
    public class Usuario : Base
    {
        public List<Entitdades.Usuario> RecuperarTodos()
        {
            List<Entitdades.Usuario> usuarios = new List<Entitdades.Usuario>();
            OpenConnection();
            SqlCommand cmdUsuario = new SqlCommand("SELECT * FROM Usuarios", sqlConn);
            SqlDataReader drUsuarios = cmdUsuario.ExecuteReader();
            while (drUsuarios.Read())
            {
                Entitdades.Usuario usr = new Entitdades.Usuario();
                usr.Clave = (string)drUsuarios["clave"];
                usr.Email = (string)drUsuarios["email"];
                usr.NombreUsuario = (string)drUsuarios["NombreUsuario"];
                usr.TipoUsuario = (int)drUsuarios["TipoUsuario"];
                usr.UltimoIngreso = (DateTime)drUsuarios["UltimoIngreso"];
                usuarios.Add(usr);
            }
            drUsuarios.Close();
            CloseConnection();
            return usuarios;
        }

        public void Agregar(Entitdades.Usuario usr)
        {
            OpenConnection();
            this.OpenConnection();
            SqlCommand cmdSave = new SqlCommand(
                "INSERT INTO usuarios(NombreUsuario,Clave,TipoUsuario,Email,UltimoIngreso)" +
                "VALUES(@NombreUsuario,@Clave, @TipoUsuario, @Email, @UltimoIngreso)" +
                "SELECT @@identity", sqlConn);
            cmdSave.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50).Value = usr.NombreUsuario;
            cmdSave.Parameters.Add("@Clave", SqlDbType.VarChar, 50).Value = usr.Clave;
            cmdSave.Parameters.Add("@TipoUsuario", SqlDbType.VarChar, 50).Value = usr.TipoUsuario;
            cmdSave.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = usr.Email;
            cmdSave.Parameters.Add("@UltimoIngreso", SqlDbType.DateTime).Value = DateTime.Now;
            cmdSave.ExecuteNonQuery();
            CloseConnection();
        }

        public Entitdades.Usuario RecuperarUno(string nombre)
        {
            List<Entitdades.Usuario> usuarios = RecuperarTodos();
            return usuarios.Where(u => u.NombreUsuario.Equals(nombre)).First();
        }
    }
}
