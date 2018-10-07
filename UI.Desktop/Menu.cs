﻿using System;
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
    public partial class Menu : Form
    {
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
            this.Hide();
            Login Login = new Login();
            if (Login.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
            this.Show();

            

        }

        private void Menu_Load(object sender, EventArgs e)
        {

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
    }
}
