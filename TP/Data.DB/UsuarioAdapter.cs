using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.DB
{
    public class UsuarioAdapter : Adapter
    {
        #region DatosEnMemoria
        // Esta región solo se usa en esta etapa donde los datos se mantienen en memoria.
        // Al modificar este proyecto para que acceda a la base de datos esta será eliminada
        private static List<Usuario> _Usuarios;

        private static List<Usuario> Usuarios
        {
            get
            {
                if (_Usuarios == null)
                {
                    _Usuarios = new List<Business.Entities.Usuario>();
                    Business.Entities.Usuario usr;
                    usr = new Business.Entities.Usuario();
                    usr.ID = 1;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Casimiro";
                    usr.Apellido = "Cegado";
                    usr.NombreUsuario = "casicegado";
                    usr.Clave = "miro";
                    usr.Email = "casimirocegado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.ID = 2;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Armando Esteban";
                    usr.Apellido = "Quito";
                    usr.NombreUsuario = "aequito";
                    usr.Clave = "carpintero";
                    usr.Email = "armandoquito@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                    usr = new Business.Entities.Usuario();
                    usr.ID = 3;
                    usr.State = Business.Entities.BusinessEntity.States.Unmodified;
                    usr.Nombre = "Alan";
                    usr.Apellido = "Brado";
                    usr.NombreUsuario = "alanbrado";
                    usr.Clave = "abrete sesamo";
                    usr.Email = "alanbrado@gmail.com";
                    usr.Habilitado = true;
                    _Usuarios.Add(usr);

                }
                return _Usuarios;
            }
        }
        #endregion

        public List<Usuario> GetAll()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();
                this.OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios", sqlConn);
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                while (drUsuarios.Read())
                {
                    Usuario user = new Usuario();
                    user.ID = (int)drUsuarios["id_usuario"];
                    user.Nombre = (string)drUsuarios["nombre"];
                    user.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    user.Clave = (string)drUsuarios["clave"];
                    user.Habilitado = (bool)drUsuarios["habilitado"];
                    user.Apellido = (string)drUsuarios["apellido"];
                    user.Email = (string)drUsuarios["email"];

                    usuarios.Add(user);
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                Exception excep = new Exception("excepction manejada", ex);
                throw excep;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Usuario GetOne(int ID)
        {
            try
            {
                Usuario user = new Usuario();
                this.OpenConnection();
                SqlCommand cmdUsuario = new SqlCommand("SELECT * FROM usuarios where id_usuario = @id", sqlConn);
                cmdUsuario.Parameters.Add("@id", SqlDbType.Int).Value = ID; 
                SqlDataReader drUsuario = cmdUsuario.ExecuteReader();

                if (drUsuario.Read())
                {
                    user.ID = (int)drUsuario["id_usuario"];
                    user.Nombre = (string)drUsuario["nombre"];
                    user.NombreUsuario = (string)drUsuario["nombre_usuario"];
                    user.Clave = (string)drUsuario["clave"];
                    user.Habilitado = (bool)drUsuario["habilitado"];
                    user.Apellido = (string)drUsuario["apellido"];
                    user.Email = (string)drUsuario["email"];
                }
                return user;
            }
            catch (Exception ex)
            {
                Exception excep = new Exception("excepction manejada", ex);
                throw excep;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE usuarios WHERE id_usuario = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excep = new Exception("excepction manejada", ex);
                throw excep;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Usuario user)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE usuarios SET nombre_usuario = @nombre_usuario, nombre=@nombre, apellido = @apellido," +
                    "habilitado = @habilitado, email=@email, clave=@clave WHERE id_usuario = @id", sqlConn);
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.Char).Value = user.NombreUsuario;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = user.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = user.Apellido;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = user.Email;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = user.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = user.Habilitado;
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = user.ID;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excep = new Exception("excepction manejada", ex);
                throw excep;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Usuario user)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "INSERT INTO usuarios(nombre_usuario,nombre,apellido,habilitado,email,clave)" +
                    "VALUES(@nombre_usuario,@nombre, @apellido, @habilitado, @email, @clave)" +
                    "SELECT @@identity", sqlConn);
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = user.NombreUsuario;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = user.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = user.Apellido;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = user.Email;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = user.Clave;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = user.Habilitado;
                user.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception ex)
            {
                Exception excep = new Exception("excepction manejada", ex);
                throw excep;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Usuario usuario)
        {
            if (usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);
            }
            else if (usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.ID);
            }
            else if (usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }
    }
}
