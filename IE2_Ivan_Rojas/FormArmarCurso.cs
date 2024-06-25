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
        string codigoCurso = "";
        List<ClsEstudiante> listaEstudiantes = new List<ClsEstudiante>();
        List<ClsCurso> listaCurso = new List<ClsCurso>();
        public FormArmarCurso()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            List<string> sinpreinscribir = new List<string>();

            if(File.Exists("ColaEspera.txt"))
            {
                StreamReader leerCola = File.OpenText("ColaEspera.txt");
                string registroCola = leerCola.ReadLine();
                int estudiantesInscriptos = 0;
                while (registroCola != null || estudiantesInscriptos < 20)
                {
                    string[] campos = registroCola.Split(',');
                    
                    if(campos[0] == cmbCurso.Text)
                    {
                        ClsEstudiante nuevo = new ClsEstudiante(campos[3], campos[2], int.Parse(campos[1]), campos[4]);
                        listaEstudiantes.Add(nuevo);
                        estudiantesInscriptos++;
                    }
                    else
                    {
                        sinpreinscribir.Add(registroCola);
                    }
                    
                   
                    registroCola = leerCola.ReadLine();
                }
                leerCola.Close();
            }

            StreamWriter escribir = new StreamWriter("ColaEspera.txt", false);
            foreach (string linea in sinpreinscribir)
            {
                escribir.WriteLine(linea);
            }
            escribir.Close();


            ClsCurso CursoNuevo = new ClsCurso(cmbCurso.Text, nombreCurso, txtFechaInicio.Text, txtFechaFin.Text, listaEstudiantes);
            listaCurso.Add(CursoNuevo);

            foreach (ClsCurso curso in listaCurso)
            {
                lstInscriptos.Items.Add($"{curso.codigo}, {curso.nombre}, {curso.fecha_inicio}, {curso.fecha_fin}");
            }

            codigoCurso = cmbCurso.Text;

            List<string> lineas = new List<string>();

            StreamReader leer = File.OpenText("Cursos.txt");
            string registro = leer.ReadLine();
            
            while (registro != null)
            {
                string[] campos = registro.Split(',');
                if (codigoCurso == campos[0])
                {
                    lineas.Add($"{codigoCurso},{campos[1]},{txtFechaInicio.Text},{txtFechaFin.Text}");
                }
                else
                {
                    lineas.Add(registro);
                }
                registro = leer.ReadLine();
            }
            leer.Close();

            StreamWriter escribirCursos = new StreamWriter("Cursos.txt", false);
            foreach(string linea in lineas)
            {
                escribirCursos.WriteLine(linea);
            }
            escribirCursos.Close();


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
                foreach(ClsEstudiante inscripto in listaEstudiantes)
                {
                    escribir.WriteLine($"{codigoCurso},{inscripto.DNI}");
                }
            escribir.Close();

           
        }
    }
}
