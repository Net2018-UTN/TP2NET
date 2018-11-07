using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnosInscripciones : BusinessEntity
    {
        int idCurso;
        int idAlumno;
        string condicion;
        int nota;

        public int IdCurso { get => idCurso; set => idCurso = value; }
        public int IdAlumno { get => idAlumno; set => idAlumno = value; }
        public string Condicion { get => condicion; set => condicion = value; }
        public int Nota { get => nota; set => nota = value; }
    }
}
