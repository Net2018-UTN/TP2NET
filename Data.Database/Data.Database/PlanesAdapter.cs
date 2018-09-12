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
    public class PlanesAdapter : Adapter
    {
        public List<Planes> GetAll()
        {
            List<Planes> planes = new List<Planes>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("select * from planes", sqlConn);
                SqlDataReader drPLanes = cmdPlanes.ExecuteReader();
                while(drPLanes.Read())
                {
                    Planes pl = new Planes();
                    pl.Id = (int)drPLanes["id_plan"];
                    pl.DescPlan = (string)drPLanes["desc_plan"];
                    pl.IdEspecialidad = (int)drPLanes["id_especialidad"];

                    planes.Add(pl);
                }

                drPLanes.Close();
            }

            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error. No se pueden recuperar los planes", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return planes;

        }

        public int GetId(string descp)
        {
            Planes p = new Planes();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("select * from planes where desc_plan = @desc", SqlConn);
                cmdPlanes.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = descp;
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
                if (drPlanes.Read())
                {
                    p.Id = (int)drPlanes["id_plan"];
                    p.DescPlan = (string)drPlanes["desc_plan"];
                }

                drPlanes.Close();
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
            return p.Id;

        
    }

        public Planes GetOne(int id)
        {
            Planes pl = new Planes();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("select * from planes where id_plan = @id", SqlConn);
                cmdPlanes.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
                if (drPlanes.Read())
                {
                    pl.Id = (int)drPlanes["id_plan"];
                    pl.DescPlan = (string)drPlanes["desc_plan"];
                    pl.IdEspecialidad = (int)drPlanes["id_especialidad"];
                }

                drPlanes.Close();
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
            return pl;
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
            catch(Exception Ex)
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
            catch(Exception Ex)
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
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        } 


        public void Save(Planes pl)
        {
            if(pl.State == BusinessEntity.States.Deleted)
            {
                this.Delete(pl.Id);
            }
            else if(pl.State == BusinessEntity.States.New)
            {
                this.Insert(pl);
            }
            else if(pl.State == BusinessEntity.States.Modified)
            {
                this.Update(pl);
            }
            pl.State = BusinessEntity.States.Unmodified;
        }
    }
}
