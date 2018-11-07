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
    public partial class Menu : Form
    {
        private Login login;

        public Usuario usuario;

        PersonasLogic personaNegocio = new PersonasLogic();

        public Menu()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            switch (personaNegocio.GetOne(login.Usuario.Id_persona).TipoPersona)
            {
                case 1:
                    personasToolStripMenuItem.Visible = false;
                    planesToolStripMenuItem.Visible = false;
                    materiasToolStripMenuItem.Visible = false;
                    docentesToolStripMenuItem.Visible = false;
                    usuariosToolStripMenuItem.Visible = false;
                    materiasToolStripMenuItem.Visible = false;
                    especialidadesToolStripMenuItem.Visible = false;
                    cursosToolStripMenuItem.Visible = false;
                    comisionesToolStripMenuItem.Visible = false;
                    break;
                case 2:
                    personasToolStripMenuItem.Visible = false;
                    planesToolStripMenuItem.Visible = false;
                    materiasToolStripMenuItem.Visible = false;
                    docentesToolStripMenuItem.Visible = false;
                    usuariosToolStripMenuItem.Visible = false;
                    materiasToolStripMenuItem.Visible = false;
                    especialidadesToolStripMenuItem.Visible = false;
                    cursosToolStripMenuItem.Visible = false;
                    comisionesToolStripMenuItem.Visible = false;
                    break;
                case 0:
                    btnReporteDocentes.Visible = true;
                    break;
            }
           
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.ShowDialog();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.ShowDialog();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            materia.ShowDialog();
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            Comision comision = new Comision();
            comision.ShowDialog();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            Planes planes = new Planes();
            planes.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.ShowDialog();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad();
            especialidad.ShowDialog();
        }

        private void btnReporteDocentes_Click(object sender, EventArgs e)
        {
            ReporteDocentes rep = new ReporteDocentes();
            rep.ShowDialog();
        }

        //Nuevo menu de opciones

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.ShowDialog();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes planes = new Planes();
            planes.ShowDialog();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.ShowDialog();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidad especialidad = new Especialidad();
            especialidad.ShowDialog();
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comision comision = new Comision();
            comision.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materia materia = new Materia();
            materia.ShowDialog();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnosInscripciones alumnosInscripciones = new AlumnosInscripciones();
            alumnosInscripciones.ShowDialog();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocentesCursos docentesCursos = new DocentesCursos();
            docentesCursos.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Hide();
            login = new Login();
            if (login.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
            else
            {
                this.Show();
            }
        }

    }



}
