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
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
            this.dgvPersonas.AutoGenerateColumns=false;
        }

        public void Listar()
        {
            PersonasLogic ctrl = new Negocio.PersonasLogic();
            this.dgvPersonas.DataSource=ctrl.GetAll();
        }

        private void Persona_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PersonaDesktop pd = new PersonaDesktop(ApplicationForm.ModoForm.Alta);
            pd.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).Id;
            PersonaDesktop pld = new PersonaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            pld.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Entidades.Persona)this.dgvPersonas.SelectedRows[0].DataBoundItem).Id;
            PersonaDesktop pld = new PersonaDesktop(ID, ApplicationForm.ModoForm.Baja);
            pld.ShowDialog();
            this.Listar();
        }
    }
}
