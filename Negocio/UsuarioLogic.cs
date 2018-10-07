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
            try
            {
                return usuarioData.GetAll();
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public void Save(Usuario usu)
        {
            try
            {
                usuarioData.Save(usu);
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
   
        }

        public void Delete(int id)
        {
            try
            {
                usuarioData.Delete(id);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
        }

        public Usuario GetUsuario(string nombreUsuario)
        {
            try
            {
                return usuarioData.GetUsuario(nombreUsuario);
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
        }
    }
}