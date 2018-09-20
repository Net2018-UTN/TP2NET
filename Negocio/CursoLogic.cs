using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data.Database;

namespace Negocio
{
    public class CursoLogic : BusinessLogic
    {
        private CursoAdapter cursoData;

        public CursoLogic()
        {
            this.cursoData = new CursoAdapter();
        }

        public List<Curso> GetAll()
        {
            try
            {
                return cursoData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public Curso GetOne(int id)
        {
           try
           {
              return cursoData.GetOne(id);
           }
           catch (Exception Ex)
           {
              throw Ex;
           }
        }

        public void Save(Curso cur)
        {
            cursoData.Save(cur);
        }

        public void Delete(int id)
        {
            try
            {
                cursoData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

    }
}
