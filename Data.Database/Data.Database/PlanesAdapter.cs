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
                    pl.IdPlan = (int)drPLanes["id_plan"];
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
                    pl.IdPlan = (int)drPlanes["id_plan"];
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
    }
}
