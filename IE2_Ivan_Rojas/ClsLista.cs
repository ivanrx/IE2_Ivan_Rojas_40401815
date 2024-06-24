using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IE2_Ivan_Rojas
{
    public class ClsLista
    {
        ClsNodo inicio;
        ClsNodo fin;

        public ClsLista()
        {
            inicio = null;
            fin = null;
        }

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
                if(int.Parse(nuevo.estudiante.DNI) < int.Parse(inicio.estudiante.DNI))
                {
                    nuevo.siguiente = inicio;
                    inicio = nuevo;
                }
                else
                {
                    if(int.Parse(nuevo.estudiante.DNI) > int.Parse(inicio.estudiante.DNI))
                    {
                        fin.siguiente = nuevo;
                        fin = nuevo;
                    }
                    else
                    {
                        ClsNodo anterior = inicio;
                        ClsNodo actual = inicio;
                        while(int.Parse(nuevo.estudiante.DNI) > int.Parse(actual.estudiante.DNI))
                        {
                            anterior = actual;
                            actual = actual.siguiente;
                        }
                        anterior.siguiente = nuevo;
                        nuevo.siguiente = actual;
                    }
                }
            }
        }

        public void Eliminar()
        {

        }

        public void Listar(ListBox lstLista)
        {
            lstLista.Items.Clear();
            if (inicio != null)
            {
                ClsNodo aux = inicio;
                while (aux != null)
                {
                    lstLista.Items.Add(aux.estudiante.Nombre + " " + 
                                       aux.estudiante.Apellido + " " + 
                                       aux.estudiante.edad + " " + 
                                       aux.estudiante.DNI);
                    aux = aux.siguiente;
                }
            }
            else lstLista.Items.Add("Lista vacia");
        }

        public List<ClsEstudiante> devolverLista()
        {
            List<ClsEstudiante> lista = new List<ClsEstudiante>();

            if (inicio != null)
            {
                ClsNodo aux = inicio;
                while (aux != null)
                {
                    lista.Add(aux.estudiante);
                    aux = aux.siguiente;
                }
            }
            return lista;
        }
    }
}
