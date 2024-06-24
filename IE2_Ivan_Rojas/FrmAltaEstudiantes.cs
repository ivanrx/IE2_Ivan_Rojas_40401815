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
    public partial class FrmAltaEstudiantes : Form
    {
        public FrmAltaEstudiantes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lstAlumnos.Items.Add(txtNombre.Text + "," + txtApellido.Text + "," + txtEdad.Text + "," + txtDni.Text); 

            txtApellido.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtDni.Text = "";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("Estudiantes.txt", false);
            foreach (var estudiante in lstAlumnos.Items)
            {
                escribir.WriteLine(estudiante);
            }
            escribir.Close();
        }
    }
}
