using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE2_Ivan_Rojas
{
    public class ClsCurso
    {
        public string codigo;
        public string nombre;
        public string fecha_inicio;
        public string fecha_fin;
        public List<ClsEstudiante> estudiantes;

        public ClsCurso(string codigo, string nombre, string fecha_inicio, string fecha_fin, List<ClsEstudiante> estudiantes)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin = fecha_fin;
            this.estudiantes = estudiantes;
        }
    }
}
