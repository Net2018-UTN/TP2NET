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
    public partial class EspecialidadDesktop : ApplicationForm
    {
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }

        private void EspecialidadDesktop_Load(object sender, EventArgs e)
        {

        }
        public EspecialidadDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public EspecialidadDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            EspecialidadLogic esp = new EspecialidadLogic();
            espActual = esp.GetOne(id);
            this.MapearDeDatos();
        }

        private Entidades.Especialidad espActual;

        public Entidades.Especialidad EspActual { get => espActual; set => espActual = value; }

        public override void MapearDeDatos()
        {
            this.txtDesc.Text = this.espActual.Desc_especialidad;
            this.txtID.Text = this.espActual.Id_especialidad.ToString();


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
                Entidades.Especialidad esp = new Entidades.Especialidad();
                espActual = esp;
            }

            espActual.Id_especialidad = int.Parse(this.txtID.Text);
            espActual.Desc_especialidad = this.txtDesc.Text;

            if (Modo == ModoForm.Alta)
            {
                this.espActual.State = BusinessEntity.States.New;
            }
            else if (Modo == ModoForm.Baja)
            {
                this.espActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.espActual.State = BusinessEntity.States.Unmodified;
            }
            else
            {
                this.espActual.State = BusinessEntity.States.Modified;
            }

        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            new EspecialidadLogic().Save(espActual);
        }

        public override bool Validar()
        {
            if (this.txtDesc.Text == "")
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
    }
}