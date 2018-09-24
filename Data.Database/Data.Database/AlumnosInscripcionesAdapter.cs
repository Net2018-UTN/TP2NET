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
    public class AlumnosInscripcionesAdapter : Adapter
    {
        public List<AlumnosInscripciones> GetAll()
        {
            List<AlumnosInscripciones> alumnosInscripciones = new List<AlumnosInscripciones>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnosInscripciones = new SqlCommand("select * from alumnos_inscripciones", sqlConn);
                SqlDataReader drAlumnosInscripciones = cmdAlumnosInscripciones.ExecuteReader();
                while(drAlumnosInscripciones.Read())
                {
                    AlumnosInscripciones ai = new AlumnosInscripciones();
                    ai.Id_alumno = (int)drAlumnosInscripciones["id_alumno"];
                    ai.Id_curso = (int)drAlumnosInscripciones["id_curso"];
                    //ai.Id_inscripcion = (int)drAlumnos_Inscripciones["id_inscripcion"];
                    ai.Nota = (int)drAlumnosInscripciones["nota"];
                    ai.Condicion = (string)drAlumnosInscripciones["condicion"];

                    alumnosInscripciones.Add(ai);
                }

                drAlumnosInscripciones.Close();
            }

            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error. No se pueden recuperar los planes", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return alumnosInscripciones;
        }

        public int GetId(int id_al, int id_cur)
        {
            AlumnosInscripciones ai = new AlumnosInscripciones();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnosInscripciones = new SqlCommand("select * from alumnos_inscripciones where id_curso = @id_cur and id_alumno = @id_al", SqlConn);
                cmdAlumnosInscripciones.Parameters.Add("@id_al", SqlDbType.Int).Value = id_al;
                cmdAlumnosInscripciones.Parameters.Add("@id_cur", SqlDbType.Int).Value = id_cur;
                SqlDataReader drAlumnosInscripciones = cmdAlumnosInscripciones.ExecuteReader();
                if (drAlumnosInscripciones.Read())
                {
                    ai.Id = (int)drAlumnosInscripciones["id_inscripcion"];
                    ai.Id_curso = (int)drAlumnosInscripciones["id_curso"];
                    ai.Id_alumno = (int)drAlumnosInscripciones["id_alumno"];
                    ai.Condicion = (string)drAlumnosInscripciones["condicion"];
                    ai.Nota = (int)drAlumnosInscripciones["nota"];
                }
                drAlumnosInscripciones.Close();
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
            return ai.Id;

        
    }

        public AlumnosInscripciones GetOne(int id)
        {
            AlumnosInscripciones ai = new AlumnosInscripciones();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos_Inscripciones = new SqlCommand("select * from alumnos_inscripciones where id_inscripciones = @id", SqlConn);
                cmdAlumnos_Inscripciones.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drAlumnos_Inscripciones = cmdAlumnos_Inscripciones.ExecuteReader();
                if (drAlumnos_Inscripciones.Read())
                {
                    ai.Id = (int)drAlumnos_Inscripciones["id_inscripcion"];
                    ai.Id_curso = (int)drAlumnos_Inscripciones["id_curso"];
                    ai.Id_alumno = (int)drAlumnos_Inscripciones["id_alumno"];
                    ai.Condicion = (string)drAlumnos_Inscripciones["condicion"];
                    ai.Nota = (int)drAlumnos_Inscripciones["nota"];
                }

                drAlumnos_Inscripciones.Close();
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
            return ai;
        } 

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete from alumnos_inscripciones where id_inscripcion = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(AlumnosInscripciones ai)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into alumnos_inscripciones (id_inscripcion, id_alumno, id_curso, condicion, nota)" +
                    "values (@id_inscripcion, @id_alumno, @id_curso, @condicion, @nota)" +
                    "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@id_inscripcion", SqlDbType.Int).Value = ai.Id;
                cmdInsert.Parameters.Add("@id_alumno", SqlDbType.Int).Value = ai.Id_alumno;
                cmdInsert.Parameters.Add("@id_curso", SqlDbType.Int).Value = ai.Id_curso;
                cmdInsert.Parameters.Add("@condicion", SqlDbType.Text).Value = ai.Condicion;
                cmdInsert.Parameters.Add("@nota", SqlDbType.Int).Value = ai.Nota;

                ai.Id = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al registrar la inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(AlumnosInscripciones ai)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand(
                    "update alumnos_inscripciones set id_alumno = @id_al, id_curso = @id_cur, condicion = @cond, nota = @nota where id_inscripcion = @id", sqlConn);
                cmdUpdate.Parameters.Add("@id_inscripcion", SqlDbType.Int).Value = ai.Id;
                cmdUpdate.Parameters.Add("@id_alumno", SqlDbType.Int).Value = ai.Id_alumno;
                cmdUpdate.Parameters.Add("@id_curso", SqlDbType.Int).Value = ai.Id_curso;
                cmdUpdate.Parameters.Add("@condicion", SqlDbType.Text).Value = ai.Condicion;
                cmdUpdate.Parameters.Add("@nota", SqlDbType.Int).Value = ai.Nota;
                cmdUpdate.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        } 


        public void Save(AlumnosInscripciones ai)
        {
            if(ai.State == BusinessEntity.States.Deleted)
            {
                this.Delete(ai.Id);
            }
            else if(ai.State == BusinessEntity.States.New)
            {
                this.Insert(ai);
            }
            else if(ai.State == BusinessEntity.States.Modified)
            {
                this.Update(ai);
            }
            ai.State = BusinessEntity.States.Unmodified;
        }
    }
}
