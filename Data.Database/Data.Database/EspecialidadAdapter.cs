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
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("select * from especialidad", sqlConn);
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                while (drEspecialidad.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.Id_especialidad = (int)drEspecialidad["id_especialidad"];
                    esp.Desc_especialidad = (string)drEspecialidad["desc_especialidad"];

                    especialidades.Add(esp);
                }

                drEspecialidad.Close();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error. No se pueden recuperar las especialidades", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return especialidades;

        }

        public Especialidad GetOne(int id)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidad = new SqlCommand("select * from especialidad where id_especialidad = @id", SqlConn);
                cmdEspecialidad.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drEspecialidad = cmdEspecialidad.ExecuteReader();
                if (drEspecialidad.Read())
                {
                    esp.Id_especialidad = (int)drEspecialidad["id_especialidad"];
                    esp.Desc_especialidad = (string)drEspecialidad["desc_especialidad"];
                }

                drEspecialidad.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la especialidad ingresada", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return esp;
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete from especialidad where id_especialidad = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into especialidad (desc_especialidad, id_especialidad)" +
                    "values (@desc_especialidad, @id_especialidad)" +
                    "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = esp.Id_especialidad;
                cmdInsert.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = esp.Desc_especialidad;
                esp.Id = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al ingresar especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand(
                    "update especialidad set desc_especialidad = @descEspecialidad where id_especialidad = @id", sqlConn);
                cmdUpdate.Parameters.Add("@descEspecialidad", SqlDbType.VarChar, 50).Value = esp.Desc_especialidad;
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = esp.Id_especialidad;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        public void Save(Especialidad esp)
        {
            if (esp.State == BusinessEntity.States.Deleted)
            {
                this.Delete(esp.Id);
            }
            else if (esp.State == BusinessEntity.States.New)
            {
                this.Insert(esp);
            }
            else if (esp.State == BusinessEntity.States.Modified)
            {
                this.Update(esp);
            }
            esp.State = BusinessEntity.States.Unmodified;
        }
    }
}
