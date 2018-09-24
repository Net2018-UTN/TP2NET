using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data.Database;

namespace Negocio
{
    public class PersonasLogic : BusinessLogic
    {
        PersonaAdapter data = new PersonaAdapter();
        public List<Persona> GetAll()
        {
            List<Persona> pers = data.GetAll();
            return pers;
        }

        public Persona GetOne(int id)
        {
            return data.GetOne(id);
        }

        public void Save(Persona p)
        {
            data.Save(p);
        }
        public void Delete(int id)
        {
            try
            {
                data.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
       
        }
    }

