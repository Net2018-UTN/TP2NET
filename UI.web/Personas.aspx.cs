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
    public partial class Personas : System.Web.UI.Page
    {

        PersonasLogic _logic;

        private PersonasLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new PersonasLogic();
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
            if (Session["tipoUsuario"].Equals(2))
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

        public Entidades.Persona Entity { get; set; }

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
            PersonasGridView.DataBind();
        }

        private void LoadCb()
        {
            ddlPlan.DataBind();
        }

        private bool IsEntitySelected
        {
            get { return (this.SelectedID != 0); }
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            txtId.Text = Entity.Id.ToString();
            txtLegajo.Text = Entity.Legajo.ToString();
            txtNombre.Text = Entity.Nombre;
            txtApellido.Text = Entity.Apellido;
            txtEmail.Text = Entity.Email;
            txtDireccion.Text = Entity.Direccion;
            txtTelefono.Text = Entity.Telefono.ToString();
            txtTipoPersona.Text = Entity.TipoPersona.ToString();
            txtFechaNacimiento.Text = Entity.FechaNacimiento.Date.ToString("yyyy-MM-dd");
            ddlPlan.Text = Entity.Id_plan.ToString();
        }

        private void LoadEntity(Entidades.Persona per)
        {            
            per.Legajo = int.Parse(txtLegajo.Text);
            per.Nombre = txtNombre.Text;
            per.Apellido = txtApellido.Text;
            per.Email = txtEmail.Text;
            per.Direccion = txtDireccion.Text;
            per.Telefono = txtTelefono.Text;
            per.TipoPersona = int.Parse(txtTipoPersona.Text);
            per.Id_plan = int.Parse(ddlPlan.SelectedValue);
            per.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);

        }

        private void SaveEntity(Entidades.Persona per)
        {
            this.Logic.Save(per);
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
            txtLegajo.Enabled = enable;
            txtApellido.Enabled = enable;
            txtNombre.Enabled = enable;
            txtDireccion.Enabled = enable;
            txtEmail.Enabled = enable;
            txtTelefono.Enabled = enable;
            ddlPlan.Enabled = enable;
            txtFechaNacimiento.Enabled = enable;
            txtTipoPersona.Enabled = enable;
        }

        private void ClearForm()
        {
            txtLegajo.Text = string.Empty;
            txtId.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
            ddlPlan.ClearSelection();
            txtTipoPersona.Text = string.Empty;
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

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            switch (this.FormMode)
            {
                case FormModes.Alta:
                    this.Entity = new Entidades.Persona();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Entidades.Persona();
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
            PersonasGridView.Enabled = true;
            this.ClearForm();
            this.formPanel.Visible = false;
            formActionsPanel.Visible = false;
            LoadGrid();
        }

        protected void PersonasGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.PersonasGridView.SelectedValue;
        }
    }
}