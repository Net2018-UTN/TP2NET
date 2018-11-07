using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class ModuloUsuarioAdapter : Adapter
    {
        public List<ModuloUsuario> GetAll()
        {
            List<ModuloUsuario> modulos = new List<ModuloUsuario>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulo = new SqlCommand("select * from modulos_usuarios", SqlConn);
                SqlDataReader drModulo = cmdModulo.ExecuteReader();
                while (drModulo.Read())
                {
                    ModuloUsuario mu = new ModuloUsuario();
                    mu.ID = (int)drModulo["id_modulo_usuario"];
                    mu.IdModulo = (int)drModulo["id_modulo"];
                    mu.IdUsuario = (int)drModulo["id_usuario"];
                    mu.PermiteAlta = (bool)drModulo["alta"];
                    mu.PermiteBaja = (bool)drModulo["baja"];
                    mu.PermiteConsulta = (bool)drModulo["consulta"];
                    mu.PermiteModificacion = (bool)drModulo["modificacion"];
                    modulos.Add(mu);
                }
                drModulo.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de módulos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return modulos;
        }

        public Business.Entities.ModuloUsuario GetOne(int ID)
        {
            ModuloUsuario mu = new ModuloUsuario();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulo = new SqlCommand("select * from modulos_usuarios where id_modulo_usuario = @id", SqlConn);
                cmdModulo.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drModulo = cmdModulo.ExecuteReader();
                if (drModulo.Read())
                {
                    mu.ID = (int)drModulo["id_modulo_usuario"];
                    mu.IdModulo = (int)drModulo["id_modulo"];
                    mu.IdUsuario = (int)drModulo["id_usuario"];
                    mu.PermiteAlta = (bool)drModulo["alta"];
                    mu.PermiteBaja = (bool)drModulo["baja"];
                    mu.PermiteConsulta = (bool)drModulo["consulta"];
                    mu.PermiteModificacion = (bool)drModulo["modificacion"];
                }
                drModulo.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de módulos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mu;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete modulos_usuarios where id_modulo_usuario = @id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar módulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(ModuloUsuario modulo)
        {
            if (modulo.State == BusinessEntity.States.New)
                this.Insert(modulo);
            else if (modulo.State == BusinessEntity.States.Modified)
                this.Update(modulo);
            else if (modulo.State == BusinessEntity.States.Delete)
                this.Delete(modulo.ID);
            modulo.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(ModuloUsuario modulo)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE modulos_usuarios SET id_modulo = @id_mod, id_usuario = @id_us, alta = @alta, baja = @baja, modificacion = @modificacion, consulta = @consulta WHERE id_modulo_usuario = @id", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = modulo.ID;
                cmdSave.Parameters.Add("@id_mod", SqlDbType.Int).Value = modulo.IdModulo;
                cmdSave.Parameters.Add("@id_us", SqlDbType.Int).Value = modulo.IdUsuario;
                cmdSave.Parameters.Add("@alta", SqlDbType.Bit).Value = modulo.PermiteAlta;
                cmdSave.Parameters.Add("@baja", SqlDbType.Bit).Value = modulo.PermiteBaja;
                cmdSave.Parameters.Add("@modificacion", SqlDbType.Bit).Value = modulo.PermiteModificacion;
                cmdSave.Parameters.Add("@consulta", SqlDbType.Bit).Value = modulo.PermiteConsulta;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del módulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(ModuloUsuario modulo)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO modulos_usuarios (id_modulo, id_usuario, alta, baja, modificacion, consulta) " +
                                                    "values (@id_mod, @id_us, @alta, @baja, @modificacion, @consulta) " +
                                                    "select @@identity", SqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = modulo.ID;
                cmdSave.Parameters.Add("@id_mod", SqlDbType.Int).Value = modulo.IdModulo;
                cmdSave.Parameters.Add("@id_us", SqlDbType.Int).Value = modulo.IdUsuario;
                cmdSave.Parameters.Add("@alta", SqlDbType.Bit).Value = modulo.PermiteAlta;
                cmdSave.Parameters.Add("@baja", SqlDbType.Bit).Value = modulo.PermiteBaja;
                cmdSave.Parameters.Add("@modificacion", SqlDbType.Bit).Value = modulo.PermiteModificacion;
                cmdSave.Parameters.Add("@consulta", SqlDbType.Bit).Value = modulo.PermiteConsulta;
                modulo.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear módulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
