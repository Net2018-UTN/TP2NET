using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DocenteCurso : BusinessEntity
    {
        private int idCurso, idDocente;
        private string cargo;
        
        public int IdCurso { get => idCurso; set => idCurso = value; }
        public int IdDocente { get => idDocente; set => idDocente = value; }
        public string Cargo { get => cargo; set => cargo = value; }
    }
}
