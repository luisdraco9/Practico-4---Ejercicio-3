using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_4___Ejercicio_3
{
    public class Pila
    {
        private int tope = -1;
        private Disco[] listaDeDiscos;


        /*Creador*/
        public Pila(int cantidadDeDiscos)
        {
            this.listaDeDiscos[] = listaDeDiscos[cantidadDeDiscos];
        }
    
        /*Funciones*/
        public void Push(Disco disco)
        {
            if (IsFull() == false)
            {
                tope++;
                listaDeDiscos[tope] = disco;
            }
        }
        public Disco Pop()
        {
            if (IsEmpty() == false)
            {
                return listaDeDiscos[tope];
                listaDeDiscos[tope] = null;
                tope--;
            }
        }
        public Disco Peek()
        {
            if (IsEmpty() == false)
            {
                return listaDeDiscos[tope];
            }
        }
        public bool IsEmpty()
        {
            if (tope == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFull()
        {
            if (tope == listaDeDiscos.Length - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
