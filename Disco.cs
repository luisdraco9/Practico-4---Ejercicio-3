using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico_4___Ejercicio_3
{
    public class Disco
    {
        private string titulo;
        private string interprete;
        private double duracion;

        /* Get Set */
        protected string Titulo
        {
            get{return titulo;}
            set{titulo = value;}
        }
        protected string Interprete
        {
            get{return interprete;}
            set{interprete = value;}
        }
        protected double Duracion
        {
            get{return duracion;}
            set{duracion = value;}
        }

        public Disco(string titulo, string interprete, double duracion)
        {
            this.titulo = titulo;
            this.interprete = interprete;
            this.duracion = duracion;
        }

    }
}
