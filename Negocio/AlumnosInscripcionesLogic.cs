using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data.Database;

namespace Negocio
{
    public class AlumnosInscripcionesLogic : BusinessLogic
    {
        private AlumnosInscripcionesAdapter alumnosInscripcionesData;

        public AlumnosInscripcionesLogic()
        {
            this.alumnosInscripcionesData = new AlumnosInscripcionesAdapter();
        }

        public List<AlumnosInscripciones> GetAll()
        {
            try
            {
                return alumnosInscripcionesData.GetAll();
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

        public AlumnosInscripciones GetOne(int id)
        {
            return alumnosInscripcionesData.GetOne(id);
        }

        public void Save(AlumnosInscripciones ai)
        {
            alumnosInscripcionesData.Save(ai);
        }

        public void Delete(int id)
        {
            try
            {
                alumnosInscripcionesData.Delete(id);
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }

        public int GetId(int id_al, int id_cur)
        {
            try
            {
                return alumnosInscripcionesData.GetId(id_al, id_cur);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }
    }
}
