using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Entidades;

namespace Negocio
{
    public class MateriaLogic
    {
        private MateriaAdapter materiaData;

        public MateriaLogic()
        {
            this.materiaData = new MateriaAdapter();
        }

        public List<Materia> GetAll()
        {
            try
            {
                return materiaData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public Materia GetOne(int id)
        {
            try
            {
                return materiaData.GetOne(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Save(Materia mat)
        {
            materiaData.Save(mat);
        }

        public void Delete(int id)
        {
            try
            {
                materiaData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }



    }
}
