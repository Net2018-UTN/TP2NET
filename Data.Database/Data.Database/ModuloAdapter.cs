using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Data.Database
{
    public class ModuloAdapter: Adapter
    {

        public List<Modulo> GetAll()
        {
            List<Modulo> modulos = new List<Modulo>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulo = new SqlCommand("select * from modulos", sqlConn);
                SqlDataReader drModulo = cmdModulo.ExecuteReader();
                while (drModulo.Read())
                {
                    Modulo m = new Modulo();
                    m.Id = (int)drModulo["id_plan"];
                    m.Descripcion = (string)drModulo["desc_modulo"];
                    m.Ejecuta = (string)drModulo["ejecuta"];
                    

                    modulos.Add(m);
                }

                drModulo.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error. No se pueden recuperar los modulos", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return modulos;
        }

        public Modulo GetOne(int id)
        {
            Modulo m = new Modulo();
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulo = new SqlCommand("select * from modulos where id_modulo = @id", SqlConn);
                cmdModulo.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drModulo = cmdModulo.ExecuteReader();
                if (drModulo.Read())
                {
                    m.Id = (int)drModulo["id_modulo"];
                    m.Descripcion = (string)drModulo["desc_modulo"];
                    m.Ejecuta = (string)drModulo["ejecuta"];
                }

                drModulo.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el modulo ingresado", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return m;
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete from modulos where id_modulo = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el módulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Modulo m)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into modulos (desc_modulo, ejecuta)" +
                    "values (@desc_modulo, @ejecuta)" +
                    "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = m.Ejecuta;
                cmdInsert.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = m.Descripcion;
                m.Id = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al ingresar el modulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Modulo m)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand(
                    "update modulos set desc_modulo = @descModulo, ejecuta = @ejecuta where id_modulo = @id", sqlConn);
                cmdUpdate.Parameters.Add("@descModulo", SqlDbType.VarChar, 50).Value = m.Descripcion;
                cmdUpdate.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = m.Ejecuta;
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = m.Id;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del modulo", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Modulo m)
        {
            if (m.State == BusinessEntity.States.Deleted)
            {
                this.Delete(m.Id);
            }
            else if (m.State == BusinessEntity.States.New)
            {
                this.Insert(m);
            }
            else if (m.State == BusinessEntity.States.Modified)
            {
                this.Update(m);
            }
            m.State = BusinessEntity.States.Unmodified;
        }

    }
}
