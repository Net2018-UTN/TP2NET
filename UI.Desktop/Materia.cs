using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Materia : Form
    {
        public Materia()
        {
            InitializeComponent();
            this.dgvMateria.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            this.dgvMateria.DataSource = ml.GetAll();
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
            MateriaDesktop md = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            md.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Materia)this.dgvMateria.SelectedRows[0].DataBoundItem).Id;
            MateriaDesktop md = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            md.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Materia)this.dgvMateria.SelectedRows[0].DataBoundItem).Id;
            MateriaDesktop md = new MateriaDesktop(ID, ApplicationForm.ModoForm.Baja);
            md.ShowDialog();
            this.Listar();
        }

        private void Materia_Load(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
