using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;


namespace UI.web
{
    public partial class login : System.Web.UI.Page
    {
        UsuarioLogic ul = new UsuarioLogic();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkRecordarClave_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx?msj=Es Ud. un usuario muy descuidado, haga memoria");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Entidades.Usuario usu = new Usuario();
            usu = ul.GetUsuario(txtUsuario.Text);
            if(usu != null && this.txtClave.Text == usu.Clave)
            {
                Page.Response.Write("Ingreso ok");
                Session["nombreUsuario"] = txtUsuario.Text;
                txtUsuario.Text = "";
                Page.Response.Redirect("~/Default.aspx");
            }
            else
            {
                Page.Response.Write("Usuario y/o contraseña inorrectos");
            }
        }
    }
}