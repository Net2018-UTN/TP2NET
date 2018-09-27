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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        UsuarioLogic ul = new UsuarioLogic();

        /*public UsuarioLogic Ul
        {
            get
            {
                if (Ul == null)
                {
                    ul = new UsuarioLogic();
                }
                return ul;
            }
        }*/

        Usuario usuario;

        private Usuario Usuario { get; set; }

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
                if(usuario != null)
                {
                    if(this.ValidarPass(usuario.Clave)){
                        this.DialogResult = DialogResult.OK;
                    }

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            //A esto hay que adaptarlo para que funcione con la capa de negocio


            /*if (this.txtUsuario.Text == Ul.get && this.txtPass.Text == "admin")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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
