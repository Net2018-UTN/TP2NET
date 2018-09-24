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
        public AlumnosInscripciones()
        {
            InitializeComponent();
            this.dgvAI.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            AlumnosInscripcionesLogic ail = new AlumnosInscripcionesLogic();
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
    }
}