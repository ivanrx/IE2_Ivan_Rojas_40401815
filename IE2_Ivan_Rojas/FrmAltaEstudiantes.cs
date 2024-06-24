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
        //List<ClsEstudiante> listaEstudiantes = new List<ClsEstudiante>();
        ClsLista listaEst = new ClsLista();

        
        public FrmAltaEstudiantes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClsEstudiante nuevo = new ClsEstudiante(txtApellido.Text, txtNombre.Text, int.Parse(txtEdad.Text), txtDni.Text);

            listaEst.Insertar(nuevo);

            //listaEstudiantes.Add(nuevo);

            //foreach(ClsEstudiante estudiante in listaEstudiantes)
            //{
            //    lstAlumnos.Items.Add($"{estudiante.Apellido}, {estudiante.Nombre}, {estudiante.edad}, {estudiante.DNI}");
            //}

            listaEst.Listar(lstAlumnos);

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
            //StreamWriter escribir = new StreamWriter("Estudiantes.txt", false);
            //foreach (ClsEstudiante estudiante in listaEstudiantes)
            //{
            //    escribir.WriteLine($"{estudiante.Apellido},{estudiante.Nombre},{estudiante.edad},{estudiante.DNI}");
            //}
            //escribir.Close();

            StreamWriter escribir = new StreamWriter("Estudiantes.txt", false);
            List<ClsEstudiante> lista = listaEst.devolverLista();
            foreach(ClsEstudiante alumno in lista)
            {
                escribir.WriteLine($"{alumno.Nombre},{alumno.Apellido},{alumno.edad},{alumno.DNI}");
            }
            escribir.Close();
        }
    }
}
