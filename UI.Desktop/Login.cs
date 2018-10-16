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

        public Usuario Usuario { get; set; }

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

        private Persona persona { get; set; }

        private void formLogin_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = ul.GetUsuario(txtUsuario.Text);
                if(usuario.NombreUsuario != txtUsuario.Text)
                {
                    MessageBox.Show("El usuario es incorrecto", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!this.ValidarPass(usuario.Clave))
                {
                    MessageBox.Show("La contraseña no es correcta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!usuario.Habilitado)
                {
                    MessageBox.Show("El usuario no está habilitado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool ValidarPass(string clave)
        {
            if (this.txtPass.Text.Equals(clave))
            {
                return true;
            }
            return false;
        }


        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
