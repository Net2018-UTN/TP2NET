using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data.Database;

namespace Negocio
{
    public class DocenteCursoLogic : BusinessLogic
    {
        DocenteCursoAdapter data = new DocenteCursoAdapter();
        public List<Entidades.DocenteCurso> GetAll()
        {
            return data.GetAll();
        }
        public Entidades.DocenteCurso GetOne(int id)
        {
            return data.GetOne(id);
        }
        public void Delete(int id)
        {
            data.Delete(id);
        }
        public void Insert(Entidades.DocenteCurso doc)
        {
            data.Insert(doc);
        }
        public void Save(Entidades.DocenteCurso docenteCurso)
        {
            data.Save(docenteCurso);
        }
    }
}
