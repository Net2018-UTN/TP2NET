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
    public partial class CambiarClave : System.Web.UI.Page
    {
        private UsuarioLogic _ul;
        public UsuarioLogic ul
        {
            get
            {
                if (_ul == null)
                    _ul = new UsuarioLogic();
                return _ul;
            }
        }
        private Usuario usuario { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            int id = (int)Session["IdPersona"];
            try
            {
                usuario = ul.GetOne(id);
            }
            catch (Exception ex)
            {
                Page.Response.Redirect("~/Error.aspx");
            }
            finally
            {
                if (txtClaveVieja.Text != usuario.Clave)
                {
                    lblError.Visible = true;
                    txtClaveVieja.Text = "";
                    txtClaveNueva.Text = "";
                    txtRepetirClave.Text = "";
                }
                else
                {
                    usuario.Clave = txtClaveNueva.Text;
                    usuario.State = BusinessEntity.States.Modified;
                    ul.Save(usuario);
                    txtClaveVieja.Text = "";
                    txtClaveNueva.Text = "";
                    txtRepetirClave.Text = "";
                    lblMensaje.Visible = true;
                    btnCancelar.Text = "Volver";
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Perfil.aspx");
        }
    }
}