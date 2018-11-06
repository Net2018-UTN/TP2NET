using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace UI.Desktop
{
    public partial class DocentesCursosDesktop : ApplicationForm
    {
        Entidades.DocenteCurso dcActual;
        Entidades.Curso cursoActual;
        Entidades.Persona docenteActual;
        
        DocenteCursoLogic dcl = new DocenteCursoLogic();

       

        public DocentesCursosDesktop()
        {
            InitializeComponent();
        }
        public DocentesCursosDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public DocentesCursosDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            DocenteCursoLogic dc = new DocenteCursoLogic();
            dcActual = dc.GetOne(ID);

            this.MapearDeDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.Close();
        }

        private void DocentesCursosDesktop_Load(object sender, EventArgs e)
        {
            this.LlenarCombos();
        }

        private void LlenarCombos()
        {
            Negocio.CursoLogic cl = new Negocio.CursoLogic();
            foreach (Entidades.Curso c in cl.GetAll())
            {
                this.cbIdCurso.Items.Add(c.Id);
            }
            Negocio.PersonasLogic pl = new Negocio.PersonasLogic();
            foreach (Entidades.Persona p in pl.GetByTipo(2))
            {
                this.cbIdDocente.Items.Add(p.Id);
            }
            this.cbIdCargo.Items.Add("Práctica");
            this.cbIdCargo.Items.Add("Teoría");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            dcl.Save(dcActual);
        }
        public override void MapearDeDatos()
        {
            this.txtIdDictado.Text = this.dcActual.Id.ToString();
            this.cbIdCurso.Text = this.dcActual.IdCurso.ToString();
            this.cbIdDocente.Text = this.dcActual.IdDocente.ToString();
            this.cbIdCargo.Text = this.dcActual.Cargo;
            







            if (Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
                this.cbIdCurso.Enabled = false;
                this.cbIdDocente.Enabled = false;
                this.cbIdCargo.Enabled = false;
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";
            }
            else
            {
                this.btnAceptar.Text = "Guardar";
            }
        }
        public override void MapearADatos()
        {
            if (Modo == ModoForm.Alta)
            {
                Entidades.DocenteCurso esp = new Entidades.DocenteCurso();
                dcActual = esp;
            }

            dcActual.Cargo = this.cbIdCargo.Text;
            dcActual.IdCurso = int.Parse(this.cbIdCurso.Text);
            dcActual.IdDocente = int.Parse(this.cbIdDocente.Text);
            

            if (Modo == ModoForm.Alta)
            {
                this.dcActual.State = BusinessEntity.States.New;
            }
            else if (Modo == ModoForm.Baja)
            {
                this.dcActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.dcActual.State = BusinessEntity.States.Unmodified;
            }
            else
            {
                this.dcActual.State = BusinessEntity.States.Modified;
            }


        }
    }
}
