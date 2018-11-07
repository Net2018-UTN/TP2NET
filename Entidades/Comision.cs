using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comision : BusinessEntity
    {
        //int idComision;
        string descp;
        int anio;
        int id_plan;

        //public int IdComision { get => idComision; set => idComision = value; }
        public string Descp { get => descp; set => descp = value; }
        public int Anio { get => anio; set => anio = value; }
        public int Id_plan { get => id_plan; set => id_plan = value; }
        
    }
}
