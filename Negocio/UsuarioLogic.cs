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
            return usuarioData.GetAll();
        }

        public void Save(Usuario usu)
        {
            usuarioData.Save(usu);
        }

        public void Delete(int id)
        {
            usuarioData.Delete(id);
        }

       
    }
}
