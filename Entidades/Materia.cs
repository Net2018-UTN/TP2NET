using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia : BusinessEntity
    {
        string descMateria;
        int hsSemanales;
        int hsTotales;
        int idPlan;

        public string DescMateria { get => descMateria; set => descMateria = value; }
        public int HsSemanales { get => hsSemanales; set => hsSemanales = value; }
        public int HsTotales { get => hsTotales; set => hsTotales = value; }
        public int IdPlan { get => idPlan; set => idPlan = value; }
    }
}
