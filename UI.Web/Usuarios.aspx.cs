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
    public partial class Usuarios : System.Web.UI.Page
    {
        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = Logic.GetAll();
            this.gridView.DataBind();
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
                this.LoadGrid();
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

        private Usuario Entity
        {
            get;
            set;
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

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int id)
        {
                this.Entity = this.Logic.GetOne(id);
                this.nombreTextBox.Text = this.Entity.Nombre;
                this.apellidoTextBox.Text = this.Entity.Apellido;
                this.emailTextBox.Text = this.Entity.Email;
                this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
                this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;
        }

        private void LoadEntity(Usuario usuario)
        {
            usuario.Nombre = this.nombreTextBox.Text;
            usuario.Apellido = this.apellidoTextBox.Text;
            usuario.Email = this.emailTextBox.Text;
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
            usuario.Clave = this.claveTextBox.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;
        }

        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }

        private void EnableForm(bool enable)
        {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.nombreUsuarioTextBox.Enabled = enable;
            this.claveTextBox.Visible = enable;
            this.claveLabel.Visible = enable;
            this.repetirClaveTextBox.Visible = enable;
            this.repetirClaveLabel.Visible = enable;
        }

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
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

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
        
            switch (this.FormMode)
                {
                case FormModes.Alta:
                    this.Entity = new Usuario();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new Usuario();
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

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                formActionsPanel.Visible = true;
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.LoadForm(this.SelectedID);
                this.EnableForm(false);
            }
        }

        private void ClearForm()
        {
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.nombreUsuarioTextBox.Text = string.Empty;
            this.habilitadoCheckBox.Checked = false;
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            formActionsPanel.Visible = true;
            this.formPanel.Visible = true;
            this.ClearForm();
            this.FormMode = FormModes.Alta;
            this.EnableForm(true);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            gridView.Enabled = true;
            this.ClearForm();
            this.formPanel.Visible = false;
            this.formActionsPanel.Visible = false;
            this.LoadGrid();
        }
    }
}
