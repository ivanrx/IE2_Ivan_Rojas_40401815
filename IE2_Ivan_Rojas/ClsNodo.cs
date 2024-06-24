using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE2_Ivan_Rojas
{
    public class ClsNodo
    {
        public ClsEstudiante estudiante;
        public ClsNodo siguiente;

        public ClsNodo(ClsEstudiante estudiante)
        {
            this.estudiante = estudiante;
            this.siguiente = null;
        }
    }
}