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
    public partial class ComisionDesktop : ApplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public ComisionDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            ComisionLogic co = new ComisionLogic();
            comisionActual = co.GetOne(id);           
            PlanesLogic pl = new PlanesLogic();
            planActual = pl.GetOne(comisionActual.Id_plan);
            this.MapearDeDatos();
        }

       

        private Entidades.Comision comisionActual;
        private Entidades.Planes planActual;


        public Entidades.Comision ComisionActual { get => comisionActual; set => comisionActual = value; }
        public Entidades.Planes PlanActual { get => planActual; set => planActual = value; }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.comisionActual.Id.ToString();
            this.txtDescripcion.Text = this.comisionActual.Descp;
            this.cbPlanes.Text = this.planActual.DescPlan;
            this.txtAño.Text = this.comisionActual.Anio.ToString();
            


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
                Entidades.Comision co = new Entidades.Comision();
                comisionActual = co;
            }
            PlanesLogic pl = new PlanesLogic();
            

            comisionActual.Descp = this.txtDescripcion.Text;
            comisionActual.Anio = int.Parse(this.txtAño.Text);
            
            comisionActual.Id_plan = pl.GetId(this.cbPlanes.Text);

            if (Modo == ModoForm.Alta)
            {
                this.comisionActual.State = BusinessEntity.States.New;

            }
            else if (Modo == ModoForm.Baja)
            {
                this.comisionActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.comisionActual.State = BusinessEntity.States.Unmodified;

            }
            else
            {
                this.comisionActual.State = BusinessEntity.States.Modified;

            }


        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            new ComisionLogic().Save(comisionActual);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void ComisionDesktop_Load(object sender, EventArgs e)
        {
            this.LlenarCb();
        }
        public void LlenarCb()
        {
            PlanesLogic pl = new PlanesLogic();
            foreach(Entidades.Planes p in pl.GetAll())
            {
                this.cbPlanes.Items.Add(p.DescPlan);
            }
        }
    }
}
