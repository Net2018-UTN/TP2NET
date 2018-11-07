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
    public partial class DocentesCursos : System.Web.UI.Page
    {
        DocenteCursoLogic _logic;
        private DocenteCursoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new DocenteCursoLogic();
                }
                return _logic;
            }
        }


        private void LoadGrid()
        {
            this.gridView1.DataSource = Logic.GetAll();
            this.gridView1.DataBind();
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

        private Entidades.DocenteCurso Entity
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
            this.SelectedID = (int)this.gridView1.SelectedValue;
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.nombreTextBox.Text = this.Entity.Id.ToString();
            this.DropDownList1.Text = this.Entity.IdCurso.ToString();
            this.DropDownList2.Text = this.Entity.IdDocente.ToString();            
            this.DropDownList3.Text = this.Entity.Cargo;

        }

        private void LoadEntity(DocenteCurso dc)
        {
            
            dc.IdCurso = int.Parse(this.DropDownList1.SelectedValue);
            dc.IdDocente = int.Parse(this.DropDownList2.SelectedValue);
            dc.Cargo = this.DropDownList3.Text;
            
        }

        private void SaveEntity(DocenteCurso dc)
        {
            this.Logic.Save(dc);
        }

        private void EnableForm(bool enable)
        {

            this.nombreTextBox.Enabled = false;
            this.DropDownList1.Enabled = enable;
            this.DropDownList2.Enabled = enable;
            this.DropDownList3.Enabled = enable;
            



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
                    this.Entity = new DocenteCurso();
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    break;
                case FormModes.Baja:
                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    break;
                case FormModes.Modificacion:
                    this.Entity = new DocenteCurso();
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
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.LoadForm(this.SelectedID);
                this.EnableForm(false);
            }
        }

        private void ClearForm()
        {
            
            
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.ClearForm();
            this.FormMode = FormModes.Alta;
            this.EnableForm(true);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            gridView1.Enabled = true;
            this.ClearForm();
            this.formPanel.Visible = false;
            
        }

        
    }
}