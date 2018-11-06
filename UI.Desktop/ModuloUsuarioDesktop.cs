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
    public partial class ModuloUsuarioDesktop : ApplicationForm
    {
        public ModuloUsuarioDesktop()
        {
            InitializeComponent();
        }
        private void ModuloUsuarioDesktop_Load(object sender, EventArgs e)
        {
            ModuloLogic ml = new ModuloLogic();
            UsuarioLogic ul = new UsuarioLogic();
            cmbModulo.DataSource = ml.GetAll();
            cmbModulo.DisplayMember = "Descripcion";
            cmbModulo.ValueMember = "ID";
            cmbUsuario.DataSource = ul.GetAll();
            cmbUsuario.DisplayMember = "NombreApellido";
            cmbUsuario.ValueMember = "ID";
        }
        public enum ModoForm
        {
            Alta, Baja, Modificación, Consulta
        }
        public ModoForm Modo { get; set; }
        public virtual void MapearDeDatos()
        {
            this.txtID.Text = this.ModuloActual.ID.ToString();
            this.cmbModulo.SelectedValue = this.ModuloActual.IdModulo;
            this.cmbUsuario.SelectedValue = this.ModuloActual.IdUsuario;
            this.chkAlta.Checked = this.ModuloActual.PermiteAlta;
            this.chkBaja.Checked = this.ModuloActual.PermiteBaja;
            this.chkModificacion.Checked = this.ModuloActual.PermiteModificacion;
            this.chkConsulta.Checked = this.ModuloActual.PermiteConsulta;
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
                        cmbModulo.Enabled = false;
                        cmbUsuario.Enabled = false;
                        chkAlta.Enabled = false;
                        chkBaja.Enabled = false;
                        chkConsulta.Enabled = false;
                        chkModificacion.Enabled = false;
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
                Business.Entities.ModuloUsuario m = new ModuloUsuario();
                ModuloActual = m;
                this.ModuloActual.State = BusinessEntity.States.New;
            }
            if (Modo == ModoForm.Modificación)
            {
                this.ModuloActual.ID = int.Parse(this.txtID.Text);
                this.ModuloActual.State = BusinessEntity.States.Modified;
            }
            this.ModuloActual.IdModulo = (int)this.cmbModulo.SelectedValue;
            this.ModuloActual.IdUsuario = (int)this.cmbUsuario.SelectedValue;
            this.ModuloActual.PermiteAlta = this.chkAlta.Checked;
            this.ModuloActual.PermiteBaja = this.chkBaja.Checked;
            this.ModuloActual.PermiteModificacion = this.chkModificacion.Checked;
            this.ModuloActual.PermiteConsulta = this.chkConsulta.Checked;
        }
        public virtual void GuardarCambios()
        {
            Business.Logic.ModuloUsuarioLogic mul = new ModuloUsuarioLogic();
            switch (btnAceptar.Text)
            {
                case "Aceptar":
                case "Guardar":
                    {
                        MapearADatos();
                        mul.Save(ModuloActual);
                        break;
                    }
                case "Eliminar":
                    {
                        mul.Delete(ModuloActual.ID);
                        break;
                    }
            }
        }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones, MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }
        public Business.Entities.ModuloUsuario ModuloActual { get; set; }
        public ModuloUsuarioDesktop(ModoForm modo)
            : this()
        {
            Modo = ModoForm.Alta;
        }
        public ModuloUsuarioDesktop(int ID, ModoForm modo)
            : this()
        {
            Modo = modo;
            Business.Logic.ModuloUsuarioLogic ml = new ModuloUsuarioLogic();
            ModuloActual = ml.GetOne(ID);
            MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GuardarCambios();
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
