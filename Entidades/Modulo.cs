using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Modulo : BusinessEntity
    {
        private string descripcion;
        private string ejecuta;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Ejecuta { get => ejecuta; set => ejecuta = value; }
    }
}
