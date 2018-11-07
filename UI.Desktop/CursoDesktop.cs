using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace UI.Desktop
{
    public partial class CursoDesktop : ApplicationForm
    {
        public CursoDesktop()
        {
            InitializeComponent();
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public CursoDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            CursoLogic cl = new CursoLogic();
            ComisionLogic coml = new ComisionLogic();
            MateriaLogic ml = new MateriaLogic();
            CursoActual = cl.GetOne(id);
            ComisionActual = coml.GetOne(cursoActual.IdComision);
            MateriaActual = ml.GetOne(cursoActual.IdMateria);
            this.MapearDeDatos();
        }

        private Entidades.Curso cursoActual;
        private Entidades.Comision comisionActual;
        private Entidades.Materia materiaActual;

        public Entidades.Curso CursoActual { get => cursoActual; set => cursoActual = value; }
        public Entidades.Comision ComisionActual { get => comisionActual; set => comisionActual = value; }
        public Entidades.Materia MateriaActual { get => materiaActual; set => materiaActual = value; }

        public override void MapearDeDatos()
        {
            this.txtId.Text = this.cursoActual.Id.ToString();
            this.txtCupo.Text = this.cursoActual.Cupo.ToString();
            this.txtAnioCalendario.Text = this.cursoActual.AnioCalendario.ToString();

            this.cbMateria.Text = this.materiaActual.DescMateria;
            this.cbComision.Text = this.comisionActual.Descp;


            if (Modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";
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
                Entidades.Curso c = new Entidades.Curso();
                cursoActual = c;
            }

            ComisionLogic coml = new ComisionLogic();
            MateriaLogic ml = new MateriaLogic();

            cursoActual.AnioCalendario = int.Parse(this.txtAnioCalendario.Text);
            cursoActual.Cupo = int.Parse(this.txtCupo.Text);

            cursoActual.IdComision = coml.GetId(this.cbComision.Text);
            cursoActual.IdMateria = ml.GetId(this.cbMateria.Text);

            if (Modo == ModoForm.Alta)
            {
                this.cursoActual.State = BusinessEntity.States.New;

            }
            else if (Modo == ModoForm.Baja)
            {
                this.cursoActual.State = BusinessEntity.States.Deleted;
            }
            else if (Modo == ModoForm.Consulta)
            {
                this.cursoActual.State = BusinessEntity.States.Unmodified;

            }
            else
            {
                this.cursoActual.State = BusinessEntity.States.Modified;

            }


        }
        public override void GuardarCambios()
        {
            this.MapearADatos();
            new CursoLogic().Save(cursoActual);
        }

        public override bool Validar()
        {
            if (this.txtCupo.Text == "") //**Agregar mas campos para validar HACERLO CON CLASE UTIL**
            {
                this.Notificar("Error", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LlenarCb()
        {
            ComisionLogic cl = new ComisionLogic();
            foreach(Entidades.Comision com in cl.GetAll())
            {
                this.cbComision.Items.Add(com.Descp);
            }

            MateriaLogic ml = new MateriaLogic();
            foreach (Entidades.Materia m in ml.GetAll())
            {
                this.cbMateria.Items.Add(m.DescMateria);
            }
        }

        private void CursoDesktop_Load(object sender, EventArgs e)
        {
            this.LlenarCb();
        }
    }
}
