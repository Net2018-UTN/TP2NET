using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AlumnosInscripciones : BusinessEntity
    {
        //int id_inscripcion;
        int id_curso;
        int id_alumno;
        string condicion;
        int nota;

        //public int Id_inscripcion { get => id_inscripcion; set => id_inscripcion = value; }
        public int Id_curso { get => id_curso; set => id_curso = value; }
        public int Id_alumno { get => id_alumno; set => id_alumno = value; }
        public string Condicion { get => condicion; set => condicion = value; }
        public int Nota { get => nota; set => nota = value; }
    }
}
