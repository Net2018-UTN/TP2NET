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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            this.dgvPlanes.AutoGenerateColumns = false;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void Planes_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        public void Listar()
        {
            PlanesLogic pl = new PlanesLogic();
            this.dgvPlanes.DataSource = pl.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPlanes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanesDesktop pld = new PlanesDesktop(ApplicationForm.ModoForm.Alta);
            pld.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Planes)this.dgvPlanes.SelectedRows[0].DataBoundItem).Id;
            PlanesDesktop pld = new PlanesDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            pld.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Planes)this.dgvPlanes.SelectedRows[0].DataBoundItem).Id;
            PlanesDesktop pld = new PlanesDesktop(ID, ApplicationForm.ModoForm.Baja);
            pld.ShowDialog();
            this.Listar();
        }
    }
}
