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
    public partial class InscripcionesAlumno : System.Web.UI.Page
    {
        PersonasLogic _pl;
        private PersonasLogic pl
        {
            get
            {
                if (_pl == null)
                    _pl = new PersonasLogic();
                return _pl;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                LoadGrid();
        }
        protected void LoadGrid()
        {
            int id = (int)Session["IdPersona"];
            try
            {
                this.gridView.DataSource = this.pl.GetListaByAlumno(id);
            }
            catch (Exception ex)
            {
                Page.Response.Redirect("~/Error.aspx");
            }
            finally
            {
                this.gridView.DataBind();
            }
        }
    }
}