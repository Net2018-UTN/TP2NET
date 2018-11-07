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
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
            this.dgvCurso.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            CursoLogic cl = new CursoLogic();
            this.dgvCurso.DataSource = cl.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop cd = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            cd.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Curso)this.dgvCurso.SelectedRows[0].DataBoundItem).Id;
            CursoDesktop cd = new CursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            cd.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Curso)this.dgvCurso.SelectedRows[0].DataBoundItem).Id;
            CursoDesktop cd = new CursoDesktop(ID, ApplicationForm.ModoForm.Baja);
            cd.ShowDialog();
            this.Listar();
        }

        private void Curso_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
