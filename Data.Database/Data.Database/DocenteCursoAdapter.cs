using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class DocenteCursoAdapter : Adapter
    {
       public List<Entidades.DocenteCurso> GetAll()
        {
            List<Entidades.DocenteCurso> dcs = new List<Entidades.DocenteCurso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from docentes_cursos",SqlConn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Entidades.DocenteCurso dc = new Entidades.DocenteCurso();
                    int c;
                    dc.Id = (int)dr["id_dictado"];
                    dc.IdCurso = (int)dr["id_curso"];
                    dc.IdDocente = (int)dr["id_docente"];
                    c = (int)dr["cargo"];
                    if (c == 1)
                    {
                        dc.Cargo = "Práctica";
                    }
                    if (c == 2)
                    {
                        dc.Cargo = "Teoría";
                    }
                    dcs.Add(dc);
                }

                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.CloseConnection();
            }
            return dcs;
        }
        public Entidades.DocenteCurso GetOne(int id)
        {
            Entidades.DocenteCurso dc = new DocenteCurso();
            try
            {
                int c;
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("select * from docentes_cursos where id_dictado=@id",SqlConn);
                cmd.Parameters.Add("@id",SqlDbType.Int).Value=id;
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                dc.Id = (int)dr["id_dictado"];
                dc.IdCurso = (int)dr["id_curso"];
                dc.IdDocente = (int)dr["id_docente"];
                c = (int)dr["cargo"];
                if (c == 1)
                {
                    dc.Cargo = "Práctica";
                }
                if (c == 2)
                {
                    dc.Cargo = "Teoría";
                }
                dr.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.CloseConnection();
            }
            return dc;
        }
        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("delete from docentes_cursos where id_dictado=@id",SqlConn);
                cmd.Parameters.Add("@id",SqlDbType.Int).Value=id;
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Insert(Entidades.DocenteCurso docenteCurso)
        {
            try
            {
                int op = 0;
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand("insert into docentes_cursos(id_curso, id_docente, cargo) " +
                    "values (@id_curso, @id_docente, @cargo)",SqlConn);                
                cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = docenteCurso.IdCurso;
                cmd.Parameters.Add("@id_docente", SqlDbType.Int).Value = docenteCurso.IdDocente;
                if (docenteCurso.Cargo.Equals("Práctica")){
                    cmd.Parameters.Add("@cargo", SqlDbType.Int).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@cargo", SqlDbType.Int).Value = 2;
                }
               
                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Entidades.DocenteCurso doc)
        {
            if (doc.State == BusinessEntity.States.Deleted)
            {
                this.Delete(doc.Id);
            }
            else if (doc.State == BusinessEntity.States.New)
            {
                this.Insert(doc);
            }
            else if (doc.State == BusinessEntity.States.Modified)
            {
                this.Update(doc);
            }
            doc.State = BusinessEntity.States.Unmodified;
        }
        public void Update(Entidades.DocenteCurso docenteCurso)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE docentes_cursos SET  id_curso = @id_curso, " +
                    "id_docente = @id_docente, cargo = @cargo WHERE id_dictado=@id_dictado", sqlConn);
                cmd.Parameters.Add("@id_dictado", SqlDbType.Int).Value = docenteCurso.Id;
                cmd.Parameters.Add("@id_curso", SqlDbType.Int).Value = docenteCurso.IdCurso;
                cmd.Parameters.Add("@id_docente", SqlDbType.Int).Value = docenteCurso.IdDocente;
                if (docenteCurso.Cargo.Equals("Práctica"))
                {
                    cmd.Parameters.Add("@cargo", SqlDbType.Int).Value = 1;
                }
                else
                {
                    cmd.Parameters.Add("@cargo", SqlDbType.Int).Value = 2;
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception )
            {
                
                throw;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
