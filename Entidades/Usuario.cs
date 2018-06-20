using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario : BusinessEntity
    {
        string nombreUsuario;
        string clave;
        string nombre;
        string apellido;
        string email;
        bool habilitado;

        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public bool Habilitado { get => habilitado; set => habilitado = value; }
    }
}
