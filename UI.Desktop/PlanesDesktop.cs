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
    public partial class PlanesDesktop : ApplicationForm
    {
        public PlanesDesktop()
        {
            InitializeComponent();
            this.LlenarCb();
        }

        public PlanesDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public PlanesDesktop(int id, ModoForm modo): this()
        {
            this.Modo = modo;
            PlanesLogic pl = new PlanesLogic();
            EspecialidadLogic el = new EspecialidadLogic();
            planActual = pl.GetOne(id);
            espActual = el.GetOne(planActual.IdEspecialidad);
            this.MapearDeDatos();
        }

        private Entidades.Planes planActual;
        private Entidades.Especialidad espActual;

        public Entidades.Planes PlanActual { get => planActual; set => planActual = value; }
        public Entidades.Especialidad EspActual { get => espActual; set => espActual = value; }

        public override void MapearDeDatos()
        {
            this.txtId.Text = this.planActual.Id.ToString();
            this.txtDescripcion.Text = this.planActual.DescPlan;
            cbEspecialidad.Text = espActual.Desc_especialidad;

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
            if(Modo == ModoForm.Alta)
            {
                Entidades.Planes pl = new Entidades.Planes();
                planActual = pl;
            }

            EspecialidadLogic el = new EspecialidadLogic();

            Entidades.Especialidad esp = new Entidades.Especialidad();

            esp = (Entidades.Especialidad)cbEspecialidad.SelectedItem;

            planActual.IdEspecialidad = esp.Id;
            planActual.DescPlan = this.txtDescripcion.Text;

            if (Modo == ModoForm.Alta)
            {
                this.planActual.State = BusinessEntity.States.New;

            }
            else if (Modo == ModoForm.Baja)
            {
                this.planActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.planActual.State = BusinessEntity.States.Unmodified;

            }
            else
            {
                this.planActual.State = BusinessEntity.States.Modified;

            }


        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            new PlanesLogic().Save(planActual);
        }

        public override bool Validar()
        {
            if (this.txtDescripcion.Text == "")
            {
                this.Notificar("Error", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LlenarCb()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            cbEspecialidad.DataSource = el.GetAll();
            cbEspecialidad.SelectedIndex = -1;
        }
    }
}
