using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_4___Ejercicio_3
{
    class TestPila
    {
        static void Main(string[] args)
        {
            int tamanoPila = 5;
            int i = 0;
            Disco disco_extra;
            Pila pila_1 = new Pila(tamanoPila);
            Pila pila_2 = new Pila(tamanoPila);
            Pila pila_extra = new Pila(tamanoPila);

            CD cd_1 = new CD("lalalo", "aloala", 3.30);
            CD cd_2 = new CD("dade", "egga", 2.80);
            CD cd_3 = new CD("glorpara araadg", "SSSE", 5.10);
            CD cd_4 = new CD("a2h224 2424 2422","ewfeafga",3.58);
            CD cd_5 = new CD("fegwo", "ewfeafga", 1.10);

            pila_1.Push(cd_1);
            pila_1.Push(cd_2);
            pila_1.Push(cd_3);
            pila_1.Push(cd_4);
            pila_1.Push(cd_5);

            for(i = 0; i < tamanoPila; i++)
            {
                pila_extra.Push(pila_1.Pop());
            }

            for(i = 0; i < tamanoPila; i++)
            {
                pila_2.Push(pila_extra.Pop());
                disco_extra = pila_2.Peek();
                Console.WriteLine("Titulo: " + disco_extra.Titulo);
            }
        }
    }
}
