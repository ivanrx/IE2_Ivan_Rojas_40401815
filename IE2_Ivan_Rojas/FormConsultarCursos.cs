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
    public partial class FormConsultarCursos : Form
    {
        List<ClsCurso> listaCursos = new List<ClsCurso>();
        public FormConsultarCursos()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (File.Exists("Cursos.txt"))
            {
                StreamReader leer = File.OpenText("Cursos.txt");
                string registro = leer.ReadLine();
                lstCursos.Items.Clear();
                while (registro != null)
                {
                    string[] campos = registro.Split(',');
                    if (campos[0] == txtCodigo.Text)
                    {
                        lstCursos.Items.Add(registro);
                    }
                    registro = leer.ReadLine();
                }
                leer.Close();
            }
        }
    }
}
