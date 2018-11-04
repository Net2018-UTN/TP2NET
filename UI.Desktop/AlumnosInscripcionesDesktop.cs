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
        public Entidades.AlumnosInscripciones AiActual { get; set; }
        public Entidades.Persona PersonaActual { get; private set; }
        public Entidades.Curso CursoActual { get; private set; }

        public AlumnosInscripcionesDesktop()
        {
            InitializeComponent();
            LlenarCbAlumnos();
            LlenarCbCursos();
        }

        public AlumnosInscripcionesDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public AlumnosInscripcionesDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            AlumnosInscripcionesLogic ail = new AlumnosInscripcionesLogic();
            AiActual = ail.GetOne(ID);
            PersonasLogic pl = new PersonasLogic();
            PersonaActual = pl.GetOne(AiActual.IdAlumno);
            //CursoLogic cl = new CursoLogic();
            //CursoActual = cl.GetOne(AiActual.IdCurso);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtIdIns.Text = this.AiActual.Id.ToString();
            this.cbAlumno.Text = this.PersonaActual.Legajo.ToString();
            this.cbCurso.Text = this.AiActual.IdCurso.ToString();
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

        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Entidades.AlumnosInscripciones ai = new Entidades.AlumnosInscripciones();
                AiActual = ai;
            }

            Entidades.Persona alumno = new Entidades.Persona();
            alumno = (Entidades.Persona)cbAlumno.SelectedItem;

            Entidades.Curso curso = new Entidades.Curso();
            curso = (Entidades.Curso)cbCurso.SelectedItem;



            AiActual.IdCurso = curso.Id;
            AiActual.IdAlumno = alumno.Id;
            AiActual.Nota = int.Parse(txtNota.Text);
            AiActual.Condicion = txtCond.Text;

            if (Modo == ModoForm.Alta)
            {
                this.AiActual.State = BusinessEntity.States.New;

            }
            else if (Modo == ModoForm.Baja)
            {
                this.AiActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.AiActual.State = BusinessEntity.States.Unmodified;

            }
            else
            {
                this.AiActual.State = BusinessEntity.States.Modified;

            }
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        public override bool Validar()
        {
            if (string.IsNullOrEmpty(txtCond.Text.Trim()) || string.IsNullOrEmpty(txtNota.Text.Trim()) || cbAlumno.SelectedIndex < 0 || cbCurso.SelectedIndex < 0)
            {
                this.Notificar("Error", "Completar todos los campos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }

        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
            new AlumnosInscripcionesLogic().Save(AiActual);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LlenarCbAlumnos()
        {
            PersonasLogic pl = new PersonasLogic();
            cbAlumno.DataSource = pl.GetAll();
            cbAlumno.SelectedIndex = -1;
        }

        public void LlenarCbCursos()
        {
            CursoLogic cl = new CursoLogic();
            cbCurso.DataSource = cl.GetAll();
            cbCurso.SelectedIndex = -1;
        }
    }
}
