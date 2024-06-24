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
    public partial class FormArmarCurso : Form
    {
        string nombreCurso = "";
        List<ClsEstudiante> listaEstudiantes = new List<ClsEstudiante>();
        List<ClsCurso> listaCurso = new List<ClsCurso>();
        public FormArmarCurso()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if(File.Exists("Estudiantes.txt"))
            {
                StreamReader leer = File.OpenText("Estudiantes.txt");
                string registro = leer.ReadLine();
                cmbCurso.Items.Clear();
                while (registro != null && listaCurso.Count < 20)
                {
                    string[] campos = registro.Split(',');
                    ClsEstudiante estudiante = new ClsEstudiante(campos[1], campos[0], int.Parse(campos[2]), campos[3]);
                    listaEstudiantes.Add(estudiante);

                    registro = leer.ReadLine();
                }
                leer.Close();
            }
            

            ClsCurso CursoNuevo = new ClsCurso(cmbCurso.Text, nombreCurso, txtFechaInicio.Text, txtFechaFin.Text, listaEstudiantes);
            listaCurso.Add(CursoNuevo);

            foreach (ClsCurso curso in listaCurso)
            {
                lstInscriptos.Items.Add($"{curso.codigo}, {curso.nombre}, {curso.fecha_inicio}, {curso.fecha_fin}");
            }

            cmbCurso.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";
        }

        private void FormArmarCurso_Load(object sender, EventArgs e)
        {
            StreamReader leer = File.OpenText("Cursos.txt");
            string registro = leer.ReadLine();
            cmbCurso.Items.Clear();
            while (registro != null)
            {
                string[] campos = registro.Split(',');
                string Codcurso = campos[0];
                cmbCurso.Items.Add(Codcurso);
                nombreCurso = campos[1];
                registro = leer.ReadLine();
            }
            leer.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("Inscriptos.txt", false);
            foreach (ClsCurso curso in listaCurso)
            {
                foreach(ClsEstudiante inscripto in listaEstudiantes)
                {
                    escribir.WriteLine($"{curso.codigo},{inscripto.DNI}");
                }
            }
            escribir.Close();
        }
    }
}
