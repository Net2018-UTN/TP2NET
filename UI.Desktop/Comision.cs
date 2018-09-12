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
    public partial class Comision : Form
    {
        public Comision()
        {
            InitializeComponent();
            this.dgvComisiones.AutoGenerateColumns = false;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

       

        public void Listar()
        {
            ComisionLogic co = new ComisionLogic();
            this.dgvComisiones.DataSource = co.GetAll();
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
            ComisionDesktop cod = new ComisionDesktop(ApplicationForm.ModoForm.Alta);
            cod.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).Id;
            ComisionDesktop cod = new ComisionDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            cod.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).Id;
            ComisionDesktop espd = new ComisionDesktop(ID, ApplicationForm.ModoForm.Baja);
            espd.ShowDialog();
            this.Listar();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            ComisionDesktop cd = new ComisionDesktop(ApplicationForm.ModoForm.Alta);
            cd.ShowDialog();
            this.Listar();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvComisiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Comision_Load_1(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            int ID = ((Entidades.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).Id;
            ComisionDesktop cd = new ComisionDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            cd.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click_1(object sender, EventArgs e)
        {
            int ID = ((Entidades.Comision)this.dgvComisiones.SelectedRows[0].DataBoundItem).Id;
            ComisionDesktop cd = new ComisionDesktop(ID, ApplicationForm.ModoForm.Baja);
            cd.ShowDialog();
            this.Listar();
        }
    }
}