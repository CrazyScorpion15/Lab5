using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Laboratorio5.Arbol2_3
{
    public class Nodo<T>
    {


        public T valor { get; set; }

        public Nodo<T> Izq { get; set; }

        public Nodo<T> Der { get; set; }

        public Nodo<T> ArbolDer { get; set; }

        public Nodo<T> ArbolIzq { get; set; }

    }

}
