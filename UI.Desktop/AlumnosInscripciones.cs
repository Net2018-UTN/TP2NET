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
    public partial class AlumnosInscripciones : Form
    {
        Entidades.Persona alumno = new Entidades.Persona();
        AlumnosInscripcionesLogic ail = new AlumnosInscripcionesLogic();

        public AlumnosInscripciones()
        {
            InitializeComponent();
            this.dgvAI.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            this.dgvAI.DataSource = ail.GetAll();
        }

        private void AlumnosInscripciones_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void stbNuevo_Click(object sender, EventArgs e)
        {
            AlumnosInscripcionesDesktop formAlumno = new AlumnosInscripcionesDesktop(ApplicationForm.ModoForm.Alta);
            formAlumno.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvAI.SelectedRows.Count != 0)
            {
                int ID = ((Entidades.AlumnosInscripciones)this.dgvAI.SelectedRows[0].DataBoundItem).Id;
                AlumnosInscripcionesDesktop formAlumno = new AlumnosInscripcionesDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                formAlumno.ShowDialog();
                this.Listar();
            }
            else
                MessageBox.Show("Debe seleccionar una inscripción", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvAI.SelectedRows.Count != 0)
            {
                int ID = ((Entidades.AlumnosInscripciones)this.dgvAI.SelectedRows[0].DataBoundItem).Id;
                AlumnosInscripcionesDesktop formAlumno = new AlumnosInscripcionesDesktop(ID, ApplicationForm.ModoForm.Baja);
                formAlumno.ShowDialog();
                this.Listar();
            }
            else
                MessageBox.Show("Debe seleccionar una inscripción", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }
}