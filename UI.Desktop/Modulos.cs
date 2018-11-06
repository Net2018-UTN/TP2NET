using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
            this.dgvModulos.AutoGenerateColumns = false;
        }
        public void Listar()
        {
            ModuloLogic ml = new ModuloLogic();
            try
            {
                this.dgvModulos.DataSource = ml.GetAll();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de módulos", Ex);
                throw ExcepcionManejada;
            }
        }
        private void Modulos_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            UI.Desktop.ModuloDesktop formModulo = new ModuloDesktop(ModuloDesktop.ModoForm.Alta);
            formModulo.ShowDialog();
            this.Listar();
        }
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            if (this.dgvModulos.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Modulo)this.dgvModulos.SelectedRows[0].DataBoundItem).ID;
                UI.Desktop.ModuloDesktop formModulo = new ModuloDesktop(ID, ModuloDesktop.ModoForm.Modificación);
                formModulo.ShowDialog();
                this.Listar();
            }
            else
                MessageBox.Show("Debe seleccionar un módulo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvModulos.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Modulo)this.dgvModulos.SelectedRows[0].DataBoundItem).ID;
                UI.Desktop.ModuloDesktop formModulo = new ModuloDesktop(ID, ModuloDesktop.ModoForm.Baja);
                formModulo.ShowDialog();
                this.Listar();
            }
            else
                MessageBox.Show("Debe seleccionar un módulo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
