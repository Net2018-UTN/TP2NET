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
    public partial class AlumnosInscripcionesDesktop : ApplicationForm
    {
        public AlumnosInscripcionesDesktop()
        {
            InitializeComponent();
        }

        private Entidades.AlumnosInscripciones aiActual;

        public Entidades.AlumnosInscripciones AiActual { get => aiActual; set => aiActual = value; }

        public AlumnosInscripcionesDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public AlumnosInscripcionesDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            AlumnosInscripcionesLogic ai = new AlumnosInscripcionesLogic();
            AiActual = ai.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtIdIns.Text = this.AiActual.Id.ToString();
            this.txtIdAl.Text = this.AiActual.Id_alumno.ToString();
            this.txtIdCur.Text = this.AiActual.Id_curso.ToString();
            this.txtCond.Text = this.AiActual.Condicion;
            this.txtNota.Text = this.AiActual.Nota.ToString();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
