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
            Console.WriteLine("Elija una opción:");
            Console.WriteLine("1. Listado general");
            Console.WriteLine("2. Consulta");
            Console.WriteLine("3. Agregar");
            Console.WriteLine("4. Modificar");
            Console.WriteLine("5. Eliminar");
            Console.WriteLine("6. Salir");
            ConsoleKeyInfo op = Console.ReadKey();
            Console.WriteLine("\n");
            switch(op.Key)
            {
                case ConsoleKey.D1:
                    this.ListadoGeneral();
                    break;
                case ConsoleKey.D2:
                    //this.Consultar();
                    break;
                case ConsoleKey.D3:
                    //this.Agregar();
                    break;
                case ConsoleKey.D4:
                   // this.Modificar();
                    break;
                case ConsoleKey.D5:
                   // this.Eliminar();
                    break;
                case ConsoleKey.D6:
                    break;
            }

            Console.ReadLine();
        }

        public void ListadoGeneral()
        {
            Console.Clear();
            foreach (Usuario usr in UsuarioNegocio.GetAll())
            {
                MostrarDatos(usr);
            }
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
    }
}