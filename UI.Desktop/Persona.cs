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
    }
}
