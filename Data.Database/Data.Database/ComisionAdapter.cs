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

                    co.IdComision = (int)drComision["id_comision"];
                    co.Descp = (string)drComision["desc_comision"];
                    co.Anio = (int)drComision["anio_especialidad"];
                    co.Id_plan = (int)drComision["id_plan"];

                    comision.Add(co);
                }

                drComision.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error. No se pueden recuperar los planes", Ex);
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
                SqlCommand cmdComision = new SqlCommand("select * from planes where id_plan = @id", SqlConn);
                cmdPlanes.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drComision = cmdComision.ExecuteReader();
                if (drComision.Read())
                {
                    co.Id = (int)drPlanes["id_plan"];
                    co.DescPlan = (string)drComision["desc_plan"];
                    co.IdEspecialidad = (int)drComision["id_especialidad"];
                }

                drComision.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el plan ingresado", Ex);
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
                SqlCommand cmdDelete = new SqlCommand("delete from planes where id_plan = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Planes pl)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into planes (desc_plan, id_especialidad)" +
                    "values (@desc_plan, @id_especialidad)" +
                    "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = pl.IdEspecialidad;
                cmdInsert.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = pl.DescPlan;
                pl.Id = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al ingresar usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Planes pl)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand(
                    "update planes set desc_plan = @descPlan, id_especialidad = @idEspecialidad where id_plan = @id", sqlConn);
                cmdUpdate.Parameters.Add("@descPlan", SqlDbType.VarChar, 50).Value = pl.DescPlan;
                cmdUpdate.Parameters.Add("@idEspecialidad", SqlDbType.Int).Value = pl.IdEspecialidad;
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = pl.Id;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del plan", Ex);
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
    }
}
