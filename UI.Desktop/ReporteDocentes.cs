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
    public partial class ReporteDocentes : Form
    {
        public ReporteDocentes()
        {
            InitializeComponent();
        }

        private void ReporteDocentes_Load(object sender, EventArgs e)
        {
            Reporte3 report = new Reporte3();
            viewer1.Document = report.Document;
            report.Run();
        }
    }
}
