using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planes
    {
        int idPlan;
        string descPlan;
        int idEspecialidad;

        public int IdPlan { get => idPlan; set => idPlan = value; }
        public string DescPlan { get => descPlan; set => descPlan = value; }
        public int IdEspecialidad { get => idEspecialidad; set => idEspecialidad = value; }
    }
}
