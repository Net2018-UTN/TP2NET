using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data.Database;

namespace Negocio
{
    public class PlanesLogic : BusinessLogic
    {
        private PlanesAdapter planesData;

        public PlanesLogic()
        {
            this.planesData = new PlanesAdapter();
        }

        public List<Planes> GetAll()
        {
            try
            {
                return planesData.GetAll();
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

        public Planes GetOne(int id)
        {
            return planesData.GetOne(id);
        }

        public void Save(Planes pl)
        {

        }

        public void Delete(int id)
        {
            try
            {
                planesData.Delete(id);
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
