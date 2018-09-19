using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data.Database;

namespace Negocio
{
    class PersonasLogic : BusinessLogic
    {
        PersonaAdapter data = new PersonaAdapter();
        public List<Persona> GetAll()
        {
            List<Persona> pers = data.GetAll();
            return pers;
        }
    }
}
