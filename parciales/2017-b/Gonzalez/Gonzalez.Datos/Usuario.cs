using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Gonzalez.Datos
{
    public class Usuario : Base
    {
        public List<Entitdades.Usuario> RecuperarTodos()
        {
            List<Entitdades.Usuario> usuarios = new List<Entitdades.Usuario>();
            this.OpenConnection();
            SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM Usuarios",this.SqlConn);
            SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

            while (drUsuarios.Read())
            {
                Entitdades.Usuario usr = new Entitdades.Usuario();
                usr.NombreUsuario = (string)drUsuarios["NombreUsuario"];
                usr.Email = (string)drUsuarios["Email"];
                usr.Clave = (string)drUsuarios["Clave"];
                usr.TipoUsuario = (int)drUsuarios["TipoUsuario"];
                usr.UltimoIngreso = (DateTime)drUsuarios["UltimoIngreso"];

                usuarios.Add(usr);
            }

            this.CloseConnection();
            return usuarios;
        }

        public void Agregar(Entitdades.Usuario usr)
        {
            this.OpenConnection();
            SqlCommand cmdUsuario = new SqlCommand("INSERT INTO Usuarios(NombreUsuario,Email,Clave,TipoUsuario,UltimoIngreso)" +
                "VALUES(@NombreUsuario,@Email,@Clave,@TipoUsuario,@UltimoIngreso)", this.SqlConn);
            cmdUsuario.Parameters.Add("@NombreUsuario", SqlDbType.VarChar,50).Value = usr.NombreUsuario;
            cmdUsuario.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = usr.Email;
            cmdUsuario.Parameters.Add("@Clave", SqlDbType.VarChar, 50).Value = usr.Clave;
            cmdUsuario.Parameters.Add("@TipoUsuario", SqlDbType.Int, 20).Value = usr.TipoUsuario;
            cmdUsuario.Parameters.Add("@UltimoIngreso", SqlDbType.DateTime, 50).Value = usr.UltimoIngreso;
            cmdUsuario.ExecuteNonQuery();

            this.CloseConnection();
        }

        public void Eliminar(string nombreUsuario)
        {
            Entitdades.Usuario usuario = this.RecuperarTodos().Where(u => u.NombreUsuario.Equals(nombreUsuario)).First();
            if (usuario.TipoUsuario != 1) {
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("DELETE FROM Usuarios WHERE NombreUsuario = @NombreUsuario", this.SqlConn);
                cmdUsuario.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 50).Value = nombreUsuario;
                cmdUsuario.ExecuteNonQuery();
                this.CloseConnection();
            }
            else
            {
                throw new Exception("Los usuarios tipo administrador no pueden ser eliminados");
            }
        }
    }
}
