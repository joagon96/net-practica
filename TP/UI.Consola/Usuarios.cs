using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        public Usuarios()
        {
            this.UsuarioNegocio = new UsuarioLogic();
        }

        private UsuarioLogic _UsuarioNegocio;
        public UsuarioLogic UsuarioNegocio
        {
            get { return _UsuarioNegocio; }
            set { _UsuarioNegocio = value; }
        }

        public void Menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1-Listado General");
                Console.WriteLine("2-Consulta");
                Console.WriteLine("3-Agregar");
                Console.WriteLine("4-Modificar");
                Console.WriteLine("5-Eliminar");
                Console.WriteLine("6-Salir");
                switch (Console.ReadLine())
                {
                    case "1":
                        ListadoGeneral();
                        break;
                    case "2":
                        Consultar();
                        break;
                    case "3":
                        Agregar();
                        break;
                    case "4":
                        Modificar();                  
                        break;
                    case "5":
                        Eliminar();
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Menu();
                        break;
                }
            }
        }

        private void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario user in UsuarioNegocio.GetAll())
            {
                MostrarDatos(user);
            }
            Console.ReadKey();
        }

        private void MostrarDatos(Usuario user)
        {
            Console.WriteLine("Usuario: {0}", user.ID);
            Console.WriteLine("Nombre: {0}", user.Nombre);
            Console.WriteLine("Apellido: {0}", user.Apellido);
            Console.WriteLine("Nombre de Usuario: {0}", user.NombreUsuario);
            Console.WriteLine("Email: {0}", user.Email);
            Console.WriteLine("Habilitado: {0}", user.Habilitado);
            Console.WriteLine();
        }

        private void Consultar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese ID de Usuario: ");
                int ID = int.Parse(Console.ReadLine());
                MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un número entero.");
            }
            catch(Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        private void Modificar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese ID de Usuario: ");
                int ID = int.Parse(Console.ReadLine());
                Usuario user = UsuarioNegocio.GetOne(ID);
                Console.WriteLine("Ingrese Nombre: ");
                user.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido: ");
                user.Apellido = Console.ReadLine();
                Console.WriteLine("Nombre de Usuario: ");
                user.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Email: ");
                user.Email = Console.ReadLine();
                Console.WriteLine("Habilitado?(1=SI/otro=NO): ");
                int habilitado = int.Parse(Console.ReadLine());
                user.Habilitado = habilitado == 1;
                user.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(user);

            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un número entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        private void Agregar()
        {
            try
            {
                Console.Clear();
                Usuario user = new Usuario();
                Console.WriteLine("Ingrese Nombre: ");
                user.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido: ");
                user.Apellido = Console.ReadLine();
                Console.WriteLine("Nombre de Usuario: ");
                user.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Email: ");
                user.Email = Console.ReadLine();
                Console.WriteLine("Habilitado?(1=SI/otro=NO): ");
                int habilitado = int.Parse(Console.ReadLine());
                user.Habilitado = habilitado == 1;
                user.State = BusinessEntity.States.New;
                UsuarioNegocio.Save(user);
                Console.WriteLine();
                Console.WriteLine("Usuario {0} creado",user.ID);

            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        private void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.Write("Ingrese ID de Usuario que desee eliminar: ");
                UsuarioNegocio.Delete(int.Parse(Console.ReadLine()));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La ID ingresada debe ser un número entero.");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }
    }
}
