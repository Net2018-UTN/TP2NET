using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipoUsuario"].Equals(1))
            {
                Planes.Visible = false;
                hlUsuarios.Visible = false;
                hlCursos.Visible = false;                
                hlComisiones.Visible = false;                
                Materias.Visible = false;
                hlPersonas.Visible = false;
                hlEspecialidades.Visible = false;
                hlAlumnosInscripciones.Visible = false;
                hlDocentesCursos.Visible = false;          

            }
            if (Session["tipoUsuario"].Equals(2))
            {
                Planes.Visible = false;
                hlUsuarios.Visible = false;
                hlCursos.Visible = false;
                hlComisiones.Visible = false;
                Materias.Visible = false;
                hlPersonas.Visible = false;
                hlEspecialidades.Visible = false;                
                hlDocentesCursos.Visible = false;

            }
        }
    }
}