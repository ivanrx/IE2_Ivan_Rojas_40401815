using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE2_Ivan_Rojas
{
    public  class ClsCola
    {
        public ClsNodo inicio;
        public ClsNodo fin;

        public void Insertar(ClsEstudiante estudiante)
        {
            ClsNodo nuevo = new ClsNodo(estudiante);
            if(inicio == null)
            {
                inicio = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.siguiente = nuevo;
                fin = nuevo;
            }
        }

        public void Eliminar()
        {
            if(inicio != null)
            {
                ClsNodo aux = inicio;
                inicio = aux.siguiente;
                aux = null;

                if (inicio == null) fin = null;
            }
        }
        public void ListarPreinscriptos(string Codigo, ListBox lstPreinscriptos)
        {
            lstPreinscriptos.Items.Clear();
            if (inicio == null) lstPreinscriptos.Items.Add("No hay preinscriptos");
            else
            {
                ClsNodo aux = inicio;
                while(aux != null)
                {
                    lstPreinscriptos.Items.Add(Codigo + "," + aux.estudiante.DNI + "," + aux.estudiante.Apellido + "," + aux.estudiante.Nombre + "," + aux.estudiante.edad);
                    aux = aux.siguiente;
                }
            }
        }
    }
}
