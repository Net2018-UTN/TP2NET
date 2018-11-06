using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;


namespace UI.Web
{
    public partial class Recuperar : System.Web.UI.Page
    {
        UsuarioLogic _logic;
        UsuarioLogic logic
        {
            get
            {
                if (_logic == null)
                    _logic = new UsuarioLogic();
                return _logic;
            }
        }
        private Usuario usuario { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRecuperar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = logic.GetUsuario(txtUsuario.Text);
            }
            catch (Exception ex)
            {
                Page.Response.Redirect("~/Error.aspx");
            }
            finally
            {
                if (usuario.ID == 0)
                {
                    lblusu.Visible = true;
                    txtUsuario.Text = "";
                }
                else
                {
                    btnRecuperar.Visible = false;
                    lblMail.Text = "Se ha enviado un mail con la clave a: " + usuario.Email;
                    lblMail.Visible = true;
                    btnVolver.Visible = true;
                }
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Login.aspx");
        }
    }
}