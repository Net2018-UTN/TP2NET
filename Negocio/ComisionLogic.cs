using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data.Database;

namespace Negocio
{
    public class ComisionLogic : BusinessLogic
    {
        private ComisionAdapter comisionData;

        public ComisionLogic()
        {
            this.comisionData = new ComisionAdapter();
        }

        public List<Comision> GetAll()
        {
            try
            {
                return comisionData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public Comision GetOne(int id)
        {
            return comisionData.GetOne(id);
        }

        public void Save(Comision co)
        {
            comisionData.Save(co);
        }

        public void Delete(int id)
        {
            try
            {
                comisionData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

    }
}

