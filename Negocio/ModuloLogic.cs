using Data.Database;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class ModuloLogic : BusinessLogic
    {
        private ModuloAdapter modulodata;

        public ModuloLogic()
        {
            this.modulodata = new ModuloAdapter();
        }

        public List<Modulo> GetAll()
        {
            try
            {
                return modulodata.GetAll();
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

        public Modulo GetOne(int id)
        {
            try
            {
                return modulodata.GetOne(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Save(Modulo m)
        {
            modulodata.Save(m);
        }

        public void Delete(int id)
        {
            try
            {
                modulodata.Delete(id);
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}
