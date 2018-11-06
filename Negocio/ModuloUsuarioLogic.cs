using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ModuloUsuarioLogic : BusinessLogic
    {
        private Data.Database.ModuloUsuarioAdapter _moduloData = new ModuloUsuarioAdapter();
        public Data.Database.ModuloUsuarioAdapter ModuloData
        {
            get { return _moduloData; }
            set { _moduloData = value; }
        }
        public Business.Entities.ModuloUsuario GetOne(int ID)
        {
            return ModuloData.GetOne(ID);
        }
        public List<ModuloUsuario> GetAll()
        {
            try
            {
                return ModuloData.GetAll();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de módulos", Ex);
                throw ExcepcionManejada;
            }
        }
        public void Save(Business.Entities.ModuloUsuario ModuloUsuario)
        {
            ModuloData.Save(ModuloUsuario);
        }
        public void Delete(int ID)
        {
            ModuloData.Delete(ID);
        }
    }
}
