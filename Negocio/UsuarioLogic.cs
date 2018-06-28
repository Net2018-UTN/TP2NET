using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Entidades;

namespace Negocio
{
    public class UsuarioLogic : BusinessLogic
    {
        private UsuarioAdapter usuarioData;

        public UsuarioLogic()
        {
            this.usuarioData = new UsuarioAdapter();
        }

        public Usuario GetOne(int id)
        {
            return usuarioData.GetOne(id);
        }

        public List<Usuario> GetAll()
        {
<<<<<<< HEAD
            try
            {
                return usuarioData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
=======
            return usuarioData.GetAll();
>>>>>>> ddb8c777793596006ed7d852127319bd1d7041b3
        }

        public void Save(Usuario usu)
        {
<<<<<<< HEAD
            try
            {
                usuarioData.Save(usu);
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
           
=======
            usuarioData.Save(usu);
>>>>>>> ddb8c777793596006ed7d852127319bd1d7041b3
        }

        public void Delete(int id)
        {
<<<<<<< HEAD
            try
            {
                usuarioData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

           
=======
            usuarioData.Delete(id);
>>>>>>> ddb8c777793596006ed7d852127319bd1d7041b3
        }       
    }
}