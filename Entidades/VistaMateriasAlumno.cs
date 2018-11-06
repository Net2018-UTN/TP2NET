using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class VistaMateriasAlumno : BusinessEntity
    {
        private int _IdInscripcion;
        public int IdInscripcion
        {
            get { return _IdInscripcion; }
            set { _IdInscripcion = value; }
        }
        private int _IdCurso;
        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
        }
        private int _IdAlumno;
        public int IdAlumno
        {
            get { return _IdAlumno; }
            set { _IdAlumno = value; }
        }
        private int _IdMateria;
        public int IdMateria
        {
            get { return _IdMateria; }
            set { _IdMateria = value; }
        }
        private int _IdComision;
        public int IdComision
        {
            get { return _IdComision; }
            set { _IdComision = value; }
        }
        private string _DescripcionMateria;
        public string DescripcionMateria
        {
            get { return _DescripcionMateria; }
            set { _DescripcionMateria = value; }
        }
        private string _DescripcionCurso;
        public string DescripcionCurso
        {
            get { return _DescripcionCurso; }
            set { _DescripcionCurso = value; }
        }
        private string _DescripcionComision;
        public string DescripcionComision
        {
            get { return _DescripcionComision; }
            set { _DescripcionComision = value; }
        }
        private string _ApellidoNombre;
        public string ApellidoNombre
        {
            get { return _ApellidoNombre; }
            set { _ApellidoNombre = value; }
        }
        private int _Legajo;
        public int Legajo
        {
            get { return _Legajo; }
            set { _Legajo = value; }
        }
        private int _Nota;
        public int Nota
        {
            get { return _Nota; }
            set { _Nota = value; }
        }
        private string _Condicion;
        public string Condicion
        {
            get
            {
                if (Nota <= 0)
                    return "Sin nota";
                else if (Nota > 0 && Nota < 4)
                    return "Libre";
                else if (Nota >= 4 && Nota < 8)
                    return "Regular";
                else if (Nota > 8 && Nota <= 10)
                    return "Promovido";
                else
                    return "Sin nota";
            }
        }
    }
}
