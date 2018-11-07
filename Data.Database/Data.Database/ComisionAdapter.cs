using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Data.Database
{
    public class ComisionAdapter : Adapter
    {
        public List<Comision> GetAll()
        {
            List<Comision> comision = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select * from comisiones", sqlConn);
                SqlDataReader drComision = cmdComision.ExecuteReader();
                while (drComision.Read())
                {
                    Comision co = new Comision();
                    co.Id = (int)drComision["id_comision"];
                    co.Descp = (string)drComision["desc_comision"];
                    co.Anio = (int)drComision["anio_especialidad"];
                    co.Id_plan = (int)drComision["id_plan"];

                    comision.Add(co);
                }

                drComision.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error. No se pueden recuperar las comisiones", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return comision;

        }
        public Comision GetOne(int id)
        {
            Comision co = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select * from comisiones where id_comision = @idComision", SqlConn);
                cmdComision.Parameters.Add("@idComision", SqlDbType.Int).Value = id;
                SqlDataReader drComision = cmdComision.ExecuteReader();
                if (drComision.Read())
                {
                    co.Id = (int)drComision["id_comision"];
                    co.Descp = (string)drComision["desc_comision"];
                    co.Anio = (int)drComision["anio_especialidad"];
                    co.Id_plan = (int)drComision["id_plan"];
                }

                drComision.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la comision ingresada", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return co;
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete from comisiones where id_comision = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Comision co)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into comisiones (desc_comision, anio_especialidad,id_plan)" +
                    "values (@desc_comision,@anio_especialidad,@id_plan)" +
                    "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = co.Descp;
                cmdInsert.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = co.Anio;
                cmdInsert.Parameters.Add("@id_plan", SqlDbType.Int).Value = co.Id_plan;

                co.Id = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al ingresar comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Comision co)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand(
                    "update comisiones set desc_comision = @desc_comision, anio_especialidad = @anio_especialidad, id_plan = @id_plan where id_comision = @id", sqlConn);
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = co.Id;
                cmdUpdate.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = co.Descp;
                cmdUpdate.Parameters.Add("@anio_especialidad", SqlDbType.Int).Value = co.Anio;
                cmdUpdate.Parameters.Add("@id_plan", SqlDbType.Int).Value = co.Id_plan;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public void Save(Comision co)
        {
            if (co.State == BusinessEntity.States.Deleted)
            {
                this.Delete(co.Id);
            }
            else if (co.State == BusinessEntity.States.New)
            {
                this.Insert(co);
            }
            else if (co.State == BusinessEntity.States.Modified)
            {
                this.Update(co);
            }
            co.State = BusinessEntity.States.Unmodified;
        }

        public int GetId(string desc)
        {
            Comision com = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select * from comisiones where desc_comision = @desc", SqlConn);
                cmdComision.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = desc;
                SqlDataReader drComision = cmdComision.ExecuteReader();
                if (drComision.Read())
                {
                    com.Id = (int)drComision["id_comision"];
                    com.Descp = (string)drComision["desc_comision"];
                    com.Anio = (int)drComision["anio_especialidad"];
                    com.Id_plan = (int)drComision["id_plan"];
                }

                drComision.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la comision ingresada", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return com.Id;

        }
    }
}
