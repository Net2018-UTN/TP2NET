using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
using Util;

namespace UI.Web
{
    public partial class CalificarAlumnos : System.Web.UI.Page
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
        AlumnoInscripcionLogic _al;
        private AlumnoInscripcionLogic al
        {
            get
            {
                if (_al == null)
                    _al = new AlumnoInscripcionLogic();
                return _al;
            }
        }
        private AlumnoInscripcion Entity { get; set; }
        public enum FormModes
        {
            Modificacion, Consulta
        }
        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LoadGrid();
                this.FormMode = FormModes.Consulta;
            }
        }
        protected void LoadGrid()
        {
            try
            {
                this.gridView.DataSource = pl.GetListaAlumnos();
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

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                    return (int)ViewState["SelectedID"];
                else
                    return 0;
            }
            set { this.ViewState["SelectedID"] = value; }
        }
        private bool IsEntitySelected
        {
            get { return (this.SelectedID != 0); }
        }

        private void ClearForm()
        {
            this.txtNota.Text = string.Empty;
            this.gridView.SelectedIndex = -1;
            this.SelectedID = 0;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if(this.IsEntitySelected)
            {
                this.gridView.Enabled = false;
                this.formPanel.Visible = true;
                this.txtNota.Enabled = true;
                this.FormMode = FormModes.Modificacion; 
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.FormMode == FormModes.Modificacion)
            {
                if (Util.Validacion.ValidarNum(txtNota.Text) || int.Parse(txtNota.Text) <= 0 || int.Parse(txtNota.Text) > 10)
                {
                    lblError.Visible = true;
                }
                else
                {
                    try
                    {
                        Entity = al.GetOne(this.SelectedID);
                    }
                    catch (Exception ex)
                    {
                        Page.Response.Redirect("~/Error.aspx");
                    }
                    finally
                    {
                        Entity.Nota = int.Parse(this.txtNota.Text);
                        Entity.State = BusinessEntity.States.Modified;
                        al.Save(Entity);
                        this.gridView.Enabled = true;
                        this.ClearForm();
                        this.LoadGrid();
                        this.formPanel.Visible = false;
                        this.txtNota.Enabled = false;
                        this.FormMode = FormModes.Consulta;
                    }
                }
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            gridView.Enabled = true;
            this.ClearForm();
            this.formPanel.Visible = false;
            this.LoadGrid();   
        }

    }
}