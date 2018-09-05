using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Especialidad : BusinessEntity
    {
        int id_especialidad;
        string desc_especialidad;
        public int Id_especialidad { get => id_especialidad; set => id_especialidad = value; }
        public string Desc_especialidad { get => desc_especialidad; set => desc_especialidad = value; }
    }
}
