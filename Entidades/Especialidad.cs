using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Especialidad : BusinessEntity
    {
        string desc_especialidad;
        public string Desc_especialidad { get => desc_especialidad; set => desc_especialidad = value; }
    }
}
