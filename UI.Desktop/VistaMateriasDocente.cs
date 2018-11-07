using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class VistaMateriasDocente : Form
    {
        Business.Logic.PersonasLogic pl = new Business.Logic.PersonasLogic();
        Business.Entities.Persona pActual = new Business.Entities.Persona();
        public VistaMateriasDocente(Business.Entities.Persona persona)
        {
            InitializeComponent();
            dgvMateriasDocente.AutoGenerateColumns = false;
            pActual = persona;
        }
        private void VistaMateriasDocente_Load_1(object sender, EventArgs e)
        {
            try
            {
                this.dgvMateriasDocente.DataSource = pl.GetListaDocentes(pActual.ID);
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de materias", ex);
                throw ExcepcionManejada;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
