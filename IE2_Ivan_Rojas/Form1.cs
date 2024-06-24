using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE2_Ivan_Rojas
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAltaEstudiantes_Click(object sender, EventArgs e)
        {
            FrmAltaEstudiantes f2 = new FrmAltaEstudiantes();
            f2.ShowDialog();
        }

        private void btnAltaCurso_Click(object sender, EventArgs e)
        {
            FrmAltaCurso f3 = new FrmAltaCurso();
            f3.ShowDialog();
        }

        private void btnPreinscribirAlumno_Click(object sender, EventArgs e)
        {
            FormPreinscripcion f4 = new FormPreinscripcion();
            f4.ShowDialog();
        }

        private void btnArmarCurso_Click(object sender, EventArgs e)
        {
            FormArmarCurso f5 = new FormArmarCurso();
            f5.ShowDialog();
        }
    }
}
