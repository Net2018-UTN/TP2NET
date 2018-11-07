using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace UI.web
{
    public partial class AlumnoInscripcion : System.Web.UI.Page
    {
        AlumnosInscripcionesLogic _logic;


        private AlumnosInscripcionesLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new AlumnosInscripcionesLogic();
                }
                return _logic;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipoUsuario"].Equals(1))
            {
                Response.Redirect("/Error.aspx");
            }
            if (!Page.IsPostBack)
            {
                LoadGrid();
                LoadCb();
            }
        }

        public enum FormModes
        {
            Alta, Baja, Modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        public Entidades.AlumnosInscripciones Entity { get; set; }

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

        private void LoadGrid()
        {
            this.alumnosInscripcionsGridView.DataBind();
            
        }

        private void LoadCb()
        {
            ddlAlumnos.DataBind();
            ddlCursos.DataBind();
        }

        private bool IsEntitySelected
        {
            get { return (this.SelectedID != 0); }
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            txtId.Text = Entity.Id.ToString();
            this.txtNota.Text = this.Entity.Nota.ToString();
            this.txtCondicion.Text = this.Entity.Condicion;
            ddlAlumnos.Text = Entity.IdAlumno.ToString();
            ddlCursos.Text = Entity.IdCurso.ToString();
        }

        private void LoadEntity(Entidades.AlumnosInscripciones ai)
        {
            ai.IdAlumno = int.Parse(ddlAlumnos.SelectedValue);
            ai.IdCurso = int.Parse(ddlCursos.SelectedValue);
            ai.Nota = int.Parse(txtNota.Text);
            ai.Condicion = txtCondicion.Text;             
            
        }

        private void SaveEntity(Entidades.AlumnosInscripciones ai)
        {
            this.Logic.Save(ai);
        }

        private void DeleteEntity(int id)
        {
            try
            {
                this.Logic.Delete(id);
            }
            catch (Exception Ex)
            {
                Page.Response.Write(Ex.Message);
            }
        }

        private void EnableForm(bool enable)
        {
            txtNota.Enabled = enable;
            txtCondicion.Enabled = enable;
            ddlAlumnos.Enabled = enable;
            ddlCursos.Enabled = enable;

        }

        private void ClearForm()
        {
            this.txtNota.Text = string.Empty;
            txtCondicion.Text = string.Empty;
            txtId.Text = string.Empty;
            ddlCursos.ClearSelection();
            ddlAlumnos.ClearSelection();
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Entidades.AlumnosInscripciones();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Entidades.AlumnosInscripciones();
                    this.Entity.Id = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                default:
                    break;
            }
            this.formPanel.Visible = false;
            this.formActionsPanel.Visible = false;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            alumnosInscripcionsGridView.Enabled = true;
            this.ClearForm();
            this.formPanel.Visible = false;
            formActionsPanel.Visible = false;
            this.LoadGrid();
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.formActionsPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
                this.EnableForm(true);
            }

        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                formActionsPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.LoadForm(this.SelectedID);
                this.EnableForm(false);
            }
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.formActionsPanel.Visible = true;
            this.ClearForm();
            this.FormMode = FormModes.Alta;
            this.EnableForm(true);
        }

        protected void alumnosInscripcionsGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.alumnosInscripcionsGridView.SelectedValue;
        }
    }
}