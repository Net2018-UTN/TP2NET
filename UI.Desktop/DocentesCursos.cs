using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace UI.Desktop
{
    public partial class DocentesCursos : Form
    {
        public DocentesCursos()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            DocenteCursoLogic dl = new DocenteCursoLogic();
            this.dataGridView1.DataSource = dl.GetAll();
        }

        private void DocentesCursos_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            DocentesCursosDesktop dcd = new DocentesCursosDesktop();
            dcd.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.DocenteCurso)this.dataGridView1.SelectedRows[0].DataBoundItem).Id;
            DocentesCursosDesktop dcd = new DocentesCursosDesktop(ID, ApplicationForm.ModoForm.Baja);
            dcd.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.DocenteCurso)this.dataGridView1.SelectedRows[0].DataBoundItem).Id;
            DocentesCursosDesktop dcd = new DocentesCursosDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            dcd.ShowDialog();
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
    }
}
