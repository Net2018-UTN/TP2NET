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
    public partial class Especialidad : Form
    {
        public Especialidad()
        {
            InitializeComponent();
            this.dgvEspecialidad.AutoGenerateColumns = false;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Especialidad_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            EspecialidadLogic esp = new EspecialidadLogic();
            this.dgvEspecialidad.DataSource = esp.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEspecialidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            EspecialidadDesktop espd = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            espd.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Especialidad)this.dgvEspecialidad.SelectedRows[0].DataBoundItem).Id;
            EspecialidadDesktop espd = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            espd.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Especialidad)this.dgvEspecialidad.SelectedRows[0].DataBoundItem).Id;
            EspecialidadDesktop espd = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Baja);
            espd.ShowDialog();
            this.Listar();
        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            EspecialidadDesktop esd = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            esd.ShowDialog();
            this.Listar();
        }
    }
}