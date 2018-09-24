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
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> materias = new List<Materia>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("select * from materias", sqlConn);
                SqlDataReader drMaterias = cmdMateria.ExecuteReader();
                while (drMaterias.Read())
                {
                    Materia mat = new Materia();
                    mat.Id = (int)drMaterias["id_materia"];
                    mat.DescMateria = (string)drMaterias["desc_materia"];
                    mat.HsSemanales = (int)drMaterias["hs_semanales"];
                    mat.HsTotales = (int)drMaterias["hs_totales"];
                    mat.IdPlan = (int)drMaterias["id_plan"];

                    materias.Add(mat);
                }

                drMaterias.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error. No se pueden recuperar las materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return materias;
        }

        public Materia GetOne(int id)
        {
            Materia mat = new Materia();

            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("select * from materias where id_materia = @id", sqlConn);
                cmdMateria.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drMateria = cmdMateria.ExecuteReader();
                if (drMateria.Read())
                {
                    mat.Id = (int)drMateria["id_materia"];
                    mat.DescMateria = (string)drMateria["desc_materia"];
                    mat.HsSemanales = (int)drMateria["hs_semanales"];
                    mat.HsTotales = (int)drMateria["hs_totales"];
                    mat.IdPlan = (int)drMateria["id_plan"];
                }
                drMateria.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return mat;
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete from materias where id_materia = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into materias (desc_materia, hs_semanales, hs_totales, id_plan)" +
                    "values (@descMateria, @hsSemanales, @hsTotales, @idPlan)" +
                    "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@descMateria", SqlDbType.VarChar).Value = mat.DescMateria;
                cmdInsert.Parameters.Add("@hsSemanales", SqlDbType.Int).Value = mat.HsSemanales;
                cmdInsert.Parameters.Add("@hsTotales", SqlDbType.Int).Value = mat.HsTotales;
                cmdInsert.Parameters.Add("@idPlan", SqlDbType.Int).Value = mat.IdPlan;
                mat.Id = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al ingresar materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand(
                    "update materias set desc_materia = @descMateria, hs_semanales = @hsSemanales, hs_totales = @hsTotales, id_plan = @idPlan" +
                    "where id_materia = @id", sqlConn);
                cmdUpdate.Parameters.Add("@descMateria", SqlDbType.VarChar).Value = mat.DescMateria;
                cmdUpdate.Parameters.Add("@hsSemanales", SqlDbType.Int).Value = mat.HsSemanales;
                cmdUpdate.Parameters.Add("@hsTotales", SqlDbType.Int).Value = mat.HsTotales;
                cmdUpdate.Parameters.Add("@idPlan", SqlDbType.Int).Value = mat.IdPlan;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Materia mat)
        {
            if (mat.State == BusinessEntity.States.Deleted)
            {
                this.Delete(mat.Id);
            }
            else if (mat.State == BusinessEntity.States.New)
            {
                this.Insert(mat);
            }
            else if (mat.State == BusinessEntity.States.Modified)
            {
                this.Update(mat);
            }
            mat.State = BusinessEntity.States.Unmodified;
        }
    }
}
