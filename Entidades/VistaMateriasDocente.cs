using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class VistaMateriasDocente : BusinessEntity
    {
        private int _IdCurso;
        public int IdCurso
        {
            get { return _IdCurso; }
            set { _IdCurso = value; }
        }
        private int _IdDocente;
        public int IdDocente
        {
            get { return _IdDocente; }
            set { _IdDocente = value; }
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
        private TipoCargo _Cargo;
        public TipoCargo Cargo
        {
            get { return _Cargo; }
            set { _Cargo = value; }
        }
        public enum TipoCargo
        {
            Práctica, Teoría
        }
        private int _Cupo;
        public int Cupo
        {
            get { return _Cupo; }
            set { _Cupo = value; }
        }
        private int _AñoCalendario;
        public int AñoCalendario
        {
            get { return _AñoCalendario; }
            set { _AñoCalendario = value; }
        }
    }
}
