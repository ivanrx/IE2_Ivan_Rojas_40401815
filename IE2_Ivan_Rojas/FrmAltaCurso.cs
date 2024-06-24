using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IE2_Ivan_Rojas
{
    public partial class FrmAltaCurso : Form
    {   
        public FrmAltaCurso()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstCursos.Items.Add(txtCodigo.Text + "," + txtNombre.Text);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("Cursos.txt", false);
            foreach (var cursos in lstCursos.Items)
            {
                escribir.WriteLine(cursos);
            }
            escribir.Close();
        }
    }
}
