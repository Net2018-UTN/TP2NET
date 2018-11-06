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
    public partial class ModuloDesktop : ApplicationForm
    {
        public ModuloDesktop()
        {
            InitializeComponent();
        }
        public enum ModoForm
        {
            Alta, Baja, Modificación, Consulta
        }
        public ModoForm Modo { get; set; }
        public virtual void MapearDeDatos()
        {
            this.txtID.Text = this.ModuloActual.ID.ToString();
            this.txtDescripcion.Text = this.ModuloActual.Descripcion;
            switch (Modo)
            {
                case ModoForm.Alta:
                case ModoForm.Modificación:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.btnAceptar.Text = "Eliminar";
                        txtDescripcion.Enabled = false;
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.btnAceptar.Text = "Aceptar";
                        break;
                    }
            }
        }
        public virtual void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Business.Entities.Modulo m = new Modulo();
                ModuloActual = m;
                this.ModuloActual.State = BusinessEntity.States.New;
            }
            if (Modo == ModoForm.Modificación)
            {
                this.ModuloActual.ID = int.Parse(this.txtID.Text);
                this.ModuloActual.State = BusinessEntity.States.Modified;
            }
            this.ModuloActual.Descripcion = this.txtDescripcion.Text;
        }
        public virtual void GuardarCambios()
        {
            Business.Logic.ModuloLogic ml = new ModuloLogic();
            switch (btnAceptar.Text)
            {
                case "Aceptar":
                case "Guardar":
                    {
                        MapearADatos();
                        ml.Save(ModuloActual);
                        break;
                    }
                case "Eliminar":
                    {
                        ml.Delete(ModuloActual.ID);
                        break;
                    }
            }
        }
        public virtual bool Validar()
        {
            if (String.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                Notificar("Campo vacío", "La descripción no puede estar vacía", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
                return true;
        }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
        public Business.Entities.Modulo ModuloActual { get; set; }
        public ModuloDesktop(ModoForm modo)
            : this()
        {
            Modo = ModoForm.Alta;
        }
        public ModuloDesktop(int ID, ModoForm modo)
            : this()
        {
            Modo = modo;
            Business.Logic.ModuloLogic ml = new ModuloLogic();
            ModuloActual = ml.GetOne(ID);
            MapearDeDatos();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.btnAceptar.Text == "Eliminar")
            {
                GuardarCambios();
                Close();
            }
            else
            {
                if (Validar())
                {
                    GuardarCambios();
                    Close();
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
