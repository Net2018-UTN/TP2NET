using Entidades;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        UsuarioLogic ul = new UsuarioLogic();

        public Usuario usuario;

        public Usuario Usuario
        {
            get
            {

                if(usuario == null)
                {
                    usuario = new Usuario();
                }
                return usuario;
            }
        }

        PersonasLogic pl;

        public PersonasLogic Pl
        {
            get
            {
                if (Pl == null)
                {
                    pl = new PersonasLogic();
                }
                return pl;
            }
        }

        private void formLogin_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = ul.GetUsuario(txtUsuario.Text);
                if(string.IsNullOrEmpty(txtUsuario.Text.Trim()) || string.IsNullOrEmpty(txtPass.Text.Trim()))
                {
                    MessageBox.Show("Debe ingresar usuarios y contraseña", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                else if(usuario.NombreUsuario != txtUsuario.Text || usuario.Clave != txtPass.Text || usuario.Habilitado == false)
                {
                    MessageBox.Show("El usuario y/o clave es incorrecto o no se encuentra habilitado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                }           
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
