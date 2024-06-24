using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE2_Ivan_Rojas
{
    public class ClsEstudiante
    {
        public string Apellido;
        public string Nombre;
        public int edad;
        public string DNI;

        public ClsEstudiante(string apellido, string nombre, int edad, string dNI)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.edad = edad;
            this.DNI = dNI;
        }   
    }
}
