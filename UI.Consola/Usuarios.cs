using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Negocio;

namespace UI.Consola
{
    public class Usuarios
    {
        private UsuarioLogic usuarioNegocio;
        public Usuarios()
        {
            this.UsuarioNegocio = new UsuarioLogic();
        }
        public UsuarioLogic UsuarioNegocio
        {
            get => usuarioNegocio;
            set => usuarioNegocio = value;
        }
        public void Menu()
        {
            ConsoleKeyInfo op;
            do
            {
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Listado general");
                Console.WriteLine("2. Consulta");
                Console.WriteLine("3. Agregar");
                Console.WriteLine("4. Modificar");
                Console.WriteLine("5. Eliminar");
                Console.WriteLine("6. Salir");

                op = Console.ReadKey();

                switch (op.Key)
                {
                    case ConsoleKey.D1:
                        this.ListadoGeneral();
                        break;
                    case ConsoleKey.D2:
                        this.Consultar();
                        break;
                    case ConsoleKey.D3:
                        this.Agregar();
                        break;
                    case ConsoleKey.D4:
                        this.Modificar();
                        break;
                    case ConsoleKey.D5:
                        this.Eliminar();
                        break;
                }
            } while (op.Key != ConsoleKey.D6);
        }

        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
            Console.ReadKey();
        }

        public void MostrarDatos (Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.Id);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            Console.WriteLine(" ");
        }

        public void Consultar()
        {

            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el Id del usuario a consultar");
                int id = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(id));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La id ingresada debe ser un numero entero", fe);
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine();
                Console.WriteLine("No existe un usuario con esa id", nre);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingresar el id del usuario a modificar");
                int id = int.Parse(Console.ReadLine());
                Usuario usuario = usuarioNegocio.GetOne(id);
                Console.WriteLine("Ingrese nombre");
                usuario.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese apellido");
                usuario.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese nombre de usuario");
                usuario.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese clave");
                usuario.Clave = Console.ReadLine();
                Console.WriteLine("Ingrese email");
                usuario.Email = Console.ReadLine();
                Console.WriteLine("Ingrese habilitacion del usuario: 1-Si/otro-No");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;
                usuarioNegocio.Save(usuario);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La id ingresada debe ser un numero entero", fe);
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine();
                Console.WriteLine("No existe un usuario con esa id", nre);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }

        public void Agregar()
        {
            Entidades.Usuario usuario = new Usuario();
            Console.Clear();
            Console.WriteLine("Ingrese nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido");
            usuario.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese nombre de usuario");
            usuario.NombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese clave");
            usuario.Clave = Console.ReadLine();
            Console.WriteLine("Ingrese email");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingrese habilitacion del usuario: 1-Si/otro-No");
            usuario.Habilitado = (Console.ReadLine() == "1" );
            usuario.State = BusinessEntity.States.New;
            usuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("Id = {0}", usuario.Id);

        }

        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el Id del usuario a eliminar");
                int id = int.Parse(Console.ReadLine());
                Usuario usuario = new Usuario();
                usuario = usuarioNegocio.GetOne(id);
                usuario.State = BusinessEntity.States.Deleted;
                usuarioNegocio.Delete(id);
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("La id ingresada debe ser un numero entero", fe);
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine();
                Console.WriteLine("No existe un usuario con esa id", nre);
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            }
        }



    }
}