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
    public partial class UsuarioDesktop : ApplicationForm
    {
        public Entidades.Persona PersonaActual { get; set; }

        private Usuario usuarioActual;

        public Usuario UsuarioActual { get => usuarioActual; set => usuarioActual = value; }

        PersonasLogic pl = new PersonasLogic();

        public UsuarioDesktop()
        {
            InitializeComponent();
            Llenarcb();

        }
        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {
            
        }

        public void Llenarcb()
        {
            cbPersonas.DataSource = pl.GetAll();
            cbPersonas.SelectedIndex = -1;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic usuario = new UsuarioLogic();
            usuarioActual = usuario.GetOne(ID);
            PersonaActual = pl.GetOne(UsuarioActual.Id_persona);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.UsuarioActual.Id.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario; 
            this.txtEmail.Text = this.UsuarioActual.Email;
            cbPersonas.Text = PersonaActual.Legajo.ToString();

            if (Modo == ModoForm.Baja){
                this.btnAceptar.Text = "Eliminar";
            } else if(Modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";
            } else
            {
                this.btnAceptar.Text = "Guardar";
            }
        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                usuarioActual = new Usuario();

            }

            this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
            this.UsuarioActual.Nombre = this.txtNombre.Text;
            this.UsuarioActual.Apellido = this.txtApellido.Text;
            this.UsuarioActual.Clave = this.txtClave.Text;
            this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
            this.UsuarioActual.Email = this.txtEmail.Text;
            this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
            PersonaActual = (Entidades.Persona) cbPersonas.SelectedItem;
            UsuarioActual.Id_persona = PersonaActual.Id;

            if (Modo == ModoForm.Alta)
            {
                this.usuarioActual.State = BusinessEntity.States.New;

            }
            else if (Modo == ModoForm.Baja)
            {
                this.usuarioActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.usuarioActual.State = BusinessEntity.States.Unmodified;

            }
            else
            {
                this.usuarioActual.State = BusinessEntity.States.Modified;

            }
        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            new UsuarioLogic().Save(usuarioActual);
        }
        public override bool Validar()
        {
            if(string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtApellido.Text.Trim()) || string.IsNullOrEmpty(txtClave.Text.Trim())
                || string.IsNullOrEmpty(txtEmail.Text.Trim()) || string.IsNullOrEmpty(txtConfirmarClave.Text.Trim()) || string.IsNullOrEmpty(txtUsuario.Text.Trim()))
            {
                MessageBox.Show("No puede haber campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!Util.Validacion.ValidarEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("El mail no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
            
        }
        public new void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public new void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
