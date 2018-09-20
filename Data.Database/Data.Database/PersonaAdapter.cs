using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas",sqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    Persona per = new Persona();

                    per.Id = (int) drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TipoPersona = (int)drPersonas["tipo_persona"];
                    per.Id_plan = (int)drPersonas["id_plan"];

                    personas.Add(per);
                }
                drPersonas.Close();
            }
            catch (Exception Ex)
            {

                Exception ExcepcionManejada = new Exception("Error al recuperar lista de personas", Ex);
                throw ExcepcionManejada;
            }
            

            return personas;
        }

        

        public Persona GetOne(int id)
        {
            Persona per = new Persona();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersona = new SqlCommand("select * from personas where id_persona = @id", SqlConn);
                cmdPersona.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drPersonas = cmdPersona.ExecuteReader();
                if (drPersonas.Read())
                {
                    per.Id = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TipoPersona = (int)drPersonas["tipo_persona"];
                    per.Id_plan = (int)drPersonas["id_plan"];
                }

                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la persona ingresada", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return per;
        }

        public void Save(Persona p)
        {
            if (p.State == BusinessEntity.States.Deleted)
            {
                this.Delete(p.Id);
            }
            else if (p.State == BusinessEntity.States.New)
            {
                this.Insert(p);
            }
            else if (p.State == BusinessEntity.States.Modified)
            {
               // this.Update(p);
            }
            p.State = BusinessEntity.States.Unmodified;
        }

        

        public void Insert(Persona p)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "insert into personas (nombre,apellido,direccion,email,telefono,fecha_nac,legajo,tipo_persona,id_plan)" +
                    "values (@nombre,@apellido,@direccion,@email,@telefono,@fecha_nac,@legajo,@tipo_persona,@id_plan)" +
                    "select @@identity", sqlConn);
                cmdInsert.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = p.Nombre;
                cmdInsert.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = p.Apellido;
                cmdInsert.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = p.Direccion;
                cmdInsert.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = p.Email;
                cmdInsert.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = p.Telefono;
                cmdInsert.Parameters.Add("@fecha_nac", SqlDbType.DateTime).Value = p.FechaNacimiento;
                cmdInsert.Parameters.Add("@legajo", SqlDbType.Int).Value = p.Legajo;
                cmdInsert.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = p.TipoPersona;
                cmdInsert.Parameters.Add("@id_plan", SqlDbType.Int).Value = p.Id_plan;


                p.Id = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
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

        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete from personas where id_persona = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Update(Persona pl)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand(
                    "update personas set  nombre=@nombre,apellido=@apellido,direccion=@direccion,email=@email,telefono=@telefono,fecha_nac=@fechanac,legajo=@legajo,tipo_persona=@tipo_persona,id_plan=@id_plan where id_persona = @id", sqlConn);
                cmdUpdate.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = pl.Nombre;
                cmdUpdate.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = pl.Apellido;
                cmdUpdate.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = pl.Direccion;
                cmdUpdate.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = pl.Email;
                cmdUpdate.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = pl.Telefono;
                cmdUpdate.Parameters.Add("@fecha_nac", SqlDbType.Date).Value = pl.FechaNacimiento;
                cmdUpdate.Parameters.Add("@legajo", SqlDbType.Int).Value = pl.Legajo;
                cmdUpdate.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = pl.TipoPersona;
                cmdUpdate.Parameters.Add("@id_plan", SqlDbType.Int).Value = pl.Id_plan;

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
    }
}
