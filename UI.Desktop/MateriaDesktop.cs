using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        private Entidades.Materia materiaActual;
        private Entidades.Planes planActual;

        public Entidades.Materia MateriaActual { get => materiaActual; set => materiaActual = value; }
        public Entidades.Planes PlanActual { get => planActual; set => planActual = value; }

        public MateriaDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            MateriaLogic ml = new MateriaLogic();
            PlanesLogic pl = new PlanesLogic();
            materiaActual = ml.GetOne(id);
            planActual = pl.GetOne(materiaActual.IdPlan);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {

            this.txtId.Text = this.materiaActual.Id.ToString();
            this.txtDescripcion.Text = this.materiaActual.DescMateria;
            this.txtHsSemanales.Text = this.materiaActual.HsSemanales.ToString();
            this.txtHsTotales.Text = this.materiaActual.HsTotales.ToString();

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
                Entidades.Materia m = new Entidades.Materia();
                materiaActual = m;
            }

            PlanesLogic pl = new PlanesLogic();

            materiaActual.DescMateria = this.txtDescripcion.Text;
            materiaActual.HsSemanales = int.Parse(this.txtHsSemanales.Text);
            materiaActual.HsTotales = int.Parse(this.txtHsTotales.Text);
            materiaActual.IdPlan = pl.GetId(this.cbPlan.Text);

            if (Modo == ModoForm.Alta)
            {
                this.materiaActual.State = BusinessEntity.States.New;

            }
            else if (Modo == ModoForm.Baja)
            {
                this.materiaActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.materiaActual.State = BusinessEntity.States.Unmodified;

            }
            else
            {
                this.materiaActual.State = BusinessEntity.States.Modified;

            }


        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            new MateriaLogic().Save(materiaActual);
        }

        public override bool Validar()
        {
            if (this.txtDescripcion.Text == "") //**Agregar mas campos para validar HACERLO CON CLASE UTIL**
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
            PlanesLogic pl = new PlanesLogic();
            foreach (Entidades.Planes p in pl.GetAll())
            {
                this.cbPlan.Items.Add(p.DescPlan);
            }
        }

        private void CursoDesktop_Load(object sender, EventArgs e)
        {
            this.LlenarCb();
        }

    }
}
