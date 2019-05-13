using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_4___Ejercicio_3
{
    public abstract class Disco
    {
        protected string titulo;
        protected string interprete;
        protected double duracion;

        /* Get Set */
        public string Titulo
        {
            get{return titulo;}
            set{titulo = value;}
        }
        public string Interprete
        {
            get{return interprete;}
            set{interprete = value;}
        }
        public double Duracion
        {
            get{return duracion;}
            set{duracion = value;}
        }

        /*Constructor*/
        public Disco(string titulo, string interprete, double duracion)
        {
            this.titulo = titulo;
            this.interprete = interprete;
            this.duracion = duracion;
        }


    }
}
