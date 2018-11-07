using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace UI.Desktop
{
    public partial class PersonaDesktop : ApplicationForm
    {
        public PersonaDesktop()
        {
            InitializeComponent();
        }

        public PersonaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public PersonaDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            PersonasLogic pl = new PersonasLogic();
            PlanesLogic el = new PlanesLogic();
            personaActual = pl.GetOne(id);
            planActual = el.GetOne(personaActual.Id_plan);
            this.MapearDeDatos();
        }

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
            this.LlenarCb();
        }

        private Entidades.Persona personaActual;
        private Entidades.Planes planActual;

        public Entidades.Persona PersonaActual { get => personaActual; set => personaActual = value; }
        public Entidades.Planes PlanActual { get => planActual; set => planActual = value; }

        public override void MapearDeDatos()
        {
            this.txtId.Text = this.personaActual.Id.ToString();
            this.txtNombre.Text = this.personaActual.Nombre;
            this.txtApellido.Text = this.personaActual.Apellido;
            this.txtDireccion.Text = this.personaActual.Direccion;
            this.txtEmail.Text = this.personaActual.Email;
            this.txtTelefono.Text = this.personaActual.Telefono;
            this.txtFechaNac.Text = this.personaActual.FechaNacimiento.ToString();
            this.txtLegajo.Text = this.personaActual.Legajo.ToString();
            this.txtTipoPer.Text = this.personaActual.TipoPersona.ToString();
            this.cbPlan.Text = this.planActual.DescPlan;




            if (Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";
            }
            else
            {
                this.btnAceptar.Text = "Guardar";
            }
        }

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Entidades.Persona pl = new Entidades.Persona();
                personaActual = pl;
            }

            Entidades.Planes nuevoPlan = new Entidades.Planes();
            PlanesLogic el = new PlanesLogic();

            personaActual.Id_plan = el.GetId(this.cbPlan.Text);
            personaActual.Nombre = this.txtNombre.Text;
            personaActual.Apellido = this.txtApellido.Text;
            personaActual.Direccion = this.txtDireccion.Text;
            personaActual.Email = this.txtEmail.Text;
            personaActual.Telefono = this.txtTelefono.Text;
            personaActual.FechaNacimiento = Convert.ToDateTime(this.txtFechaNac.Text);
            personaActual.Legajo = int.Parse(this.txtLegajo.Text);
            personaActual.TipoPersona = int.Parse(this.txtTipoPer.Text);
            



            if (Modo == ModoForm.Alta)
            {
                this.personaActual.State = BusinessEntity.States.New;

            }
            else if (Modo == ModoForm.Baja)
            {
                this.personaActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.personaActual.State = BusinessEntity.States.Unmodified;

            }
            else
            {
                this.personaActual.State = BusinessEntity.States.Modified;

            }


        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            new PersonasLogic().Save(personaActual);
        }

        public override bool Validar()
        {
            if (this.txtNombre.Text == "" || this.txtApellido.Text=="")
            {
                this.Notificar("Error", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        

        public void LlenarCb()
        {
            PlanesLogic el = new PlanesLogic();
            foreach (Entidades.Planes esp in el.GetAll())
            {
                this.cbPlan.Items.Add(esp.DescPlan);
            }
        }

        private void cbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

