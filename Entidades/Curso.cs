using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso : BusinessEntity
    {
        int idMateria;
        int idComision;
        int anioCalendario;
        int cupo;

        public int IdCurso { get => idCurso; set => idCurso = value; }
        public int IdMateria { get => idMateria; set => idMateria = value; }
        public int IdComision { get => idComision; set => idComision = value; }
        public int AnioCalendario { get => anioCalendario; set => anioCalendario = value; }
        public int Cupo { get => cupo; set => cupo = value; }
    }
}
