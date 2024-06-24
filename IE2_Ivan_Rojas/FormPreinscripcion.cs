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
    public partial class FormPreinscripcion : Form
    {
        ClsCola colaPreinscriptos = new ClsCola();
        public FormPreinscripcion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;

            string Nombre = "";
            string Apellido = "";
            int edad = 0;

            if(File.Exists("Estudiantes.txt"))
            {
                StreamReader leer = File.OpenText("Estudiantes.txt");
                string registro = leer.ReadLine();
                cmbCursos.Items.Clear();
                while (registro != null)
                {
                    string[] campos = registro.Split(',');

                    if (DNI == campos[3])
                    {
                        Nombre = campos[1];
                        Apellido = campos[0];
                        edad = int.Parse(campos[2]);
                    }

                    registro = leer.ReadLine();
                }
                leer.Close();
            }
            
            ClsEstudiante estudiante = new ClsEstudiante(Apellido, Nombre, edad, DNI);

            colaPreinscriptos.Insertar(estudiante);
            colaPreinscriptos.ListarPreinscriptos(cmbCursos.Text, lstPreinscriptos);

            cmbCursos.Text = "";
            txtDNI.Text = "";
        }

        private void FormPreinscripcion_Load(object sender, EventArgs e)
        {
            if(File.Exists("Cursos.txt"))
                { 
                StreamReader leer = File.OpenText("Cursos.txt");
                string registro = leer.ReadLine();
                cmbCursos.Items.Clear();
                while (registro != null)
                {
                    string[] campos = registro.Split(',');
                    string Codcurso = campos[0];
                    cmbCursos.Items.Add(Codcurso);
                    registro = leer.ReadLine();
                }
                leer.Close();
            }
            
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StreamWriter escribir = new StreamWriter("ColaEspera.txt", false);
            foreach (var preinscripto in lstPreinscriptos.Items)
            {
                escribir.WriteLine(preinscripto);
            }
            escribir.Close();
        }


    }
}
