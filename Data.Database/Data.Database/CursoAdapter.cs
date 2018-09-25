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
    public class CursoAdapter : Adapter
    {
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select * from cursos", sqlConn);
                SqlDataReader drCursos = cmdCurso.ExecuteReader();
                while (drCursos.Read())
                {
                    Curso cur = new Curso();
                    cur.Id = (int)drCursos["id_curso"];
                    cur.IdComision = (int)drCursos["id_comision"];
                    cur.IdMateria = (int)drCursos["id_materia"];
                    cur.AnioCalendario = (int)drCursos["anio_calendario"];
                    cur.Cupo = (int)drCursos["cupo"];

                    cursos.Add(cur);
                }

                drCursos.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error. No se pueden recuperar los crusos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cursos;
        }

        public Curso GetOne(int id)
        {
            Curso cur = new Curso();

            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("select * from cursos where id_curso = @id", sqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                if (drCurso.Read())
                {
                    cur.Id = (int)drCurso["id_curso"];
                    cur.IdComision = (int)drCurso["id_comision"];
                    cur.IdMateria = (int)drCurso["id_materia"];
                    cur.Cupo = (int)drCurso["cupo"];
                    cur.AnioCalendario = (int)drCurso["anio_calendario"];
                }
                drCurso.Close();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return cur;
        }

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete from cursos where id_curso = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into cursos (cupo, anio_calendario, id_materia, id_comision)" +
                    "values (@cupo, @anio_calendario, @id_materia, @id_comision)" +
                    "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@cupo", SqlDbType.Int).Value = cur.Cupo;
                cmdInsert.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = cur.AnioCalendario;
                cmdInsert.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IdMateria;
                cmdInsert.Parameters.Add("@id_comision", SqlDbType.Int).Value = cur.IdComision;
                cur.Id = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al ingresar curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand(
                    "update cursos set id_materia = @id_materia, id_comision = @id_comision, anio_calendario = @anio_calendario, cupo = @cupo " +
                    "where id_curso = @id", sqlConn);
                cmdUpdate.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IdMateria;
                cmdUpdate.Parameters.Add("@id_comision", SqlDbType.Int).Value = cur.IdComision;
                cmdUpdate.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = cur.AnioCalendario;
                cmdUpdate.Parameters.Add("@cupo", SqlDbType.Int).Value = cur.Cupo;
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = cur.Id;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Curso cur)
        {
            if (cur.State == BusinessEntity.States.Deleted)
            {
                this.Delete(cur.Id);
            }
            else if (cur.State == BusinessEntity.States.New)
            {
                this.Insert(cur);
            }
            else if (cur.State == BusinessEntity.States.Modified)
            {
                this.Update(cur);
            }
            cur.State = BusinessEntity.States.Unmodified;
        }
    }
}
