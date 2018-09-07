using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data.Database;

namespace Negocio
{
    public class EspecialidadLogic : BusinessLogic
    {
        private EspecialidadAdapter especialidadData;

        public EspecialidadLogic()
        {
            this.especialidadData = new EspecialidadAdapter();
        }

        public List<Especialidad> GetAll()
        {
            try
            {
                return especialidadData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public Especialidad GetOne(int id)
        {
            return especialidadData.GetOne(id);
        }

        public void Save(Especialidad esp)
        {
            especialidadData.Save(esp);
        }

        public void Delete(int id)
        {
            try
            {
                especialidadData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public int GetId(string desc)
        {
            try
            {
                return especialidadData.GetId(desc);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

    }
}
