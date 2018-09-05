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
    public partial class ComisionDesktop : ApplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();
        }

        private void ComisionDesktop_Load(object sender, EventArgs e)
        {
            PlanesLogic pl = new PlanesLogic();
            cmbPlan.DataSource = pl.GetAll();
            cmbPlan.DisplayMember = "Descripcion";
            cmbPlan.ValueMember = "ID";
        }
        public enum ModoForm
        {
            Alta, Baja, Modificación, Consulta
        }
        public ModoForm Modo { get; set; }
        public virtual void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;
            this.txtAño.Text = this.ComisionActual.AñoEspecialidad.ToString();
            this.cmbPlan.SelectedValue = this.ComisionActual.IdPlan;
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
                        txtAño.Enabled = false;
                        txtDescripcion.Enabled = false;
                        cmbPlan.Enabled = false;
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
                Business.Entities.Comision c = new Comision();
                ComisionActual = c;
                this.ComisionActual.State = BusinessEntity.States.New;
            }
            if (Modo == ModoForm.Modificación)
            {
                this.ComisionActual.ID = int.Parse(this.txtID.Text);
                this.ComisionActual.State = BusinessEntity.States.Modified;
            }
            this.ComisionActual.Descripcion = this.txtDescripcion.Text;
            this.ComisionActual.IdPlan = (int)this.cmbPlan.SelectedValue;
            this.ComisionActual.AñoEspecialidad = int.Parse(this.txtAño.Text);
        }
        public virtual void GuardarCambios()
        {
            Business.Logic.ComisionLogic cl = new ComisionLogic();
            switch (btnAceptar.Text)
            {
                case "Aceptar":
                case "Guardar":
                    {
                        MapearADatos();
                        cl.Save(ComisionActual);
                        break;
                    }
                case "Eliminar":
                    {
                        cl.Delete(ComisionActual.ID);
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
            else if (Util.Validacion.ValidarNum(txtAño.Text))
            {
                Notificar("Año Incorrecto", "El año debe ser un número entero", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        public Business.Entities.Comision ComisionActual { get; set; }
        public ComisionDesktop(ModoForm modo)
            : this()
        {
            Modo = ModoForm.Alta;
        }
        public ComisionDesktop(int ID, ModoForm modo)
            : this()
        {
            Modo = modo;
            Business.Logic.ComisionLogic cl = new ComisionLogic();
            ComisionActual = cl.GetOne(ID);
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