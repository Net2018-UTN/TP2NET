using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Persona : BusinessEntity
    {
        private String nombre;
        private String apellido;
        private string email;
        private string direccion;
        private string telefono;
        private DateTime fechaNacimiento;
        private int legajo;
        private int tipoPersona;
        private int id_plan;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Legajo { get => legajo; set => legajo = value; }
        public int TipoPersona { get => tipoPersona; set => tipoPersona = value; }
        public int Id_plan { get => id_plan; set => id_plan = value; }
    }
}
