using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5.Arbol2_3
{
    public class NodoArbol<T>
    {
        public NodoArbol<T> Padre { get; set; }
        public List<NodoArbol<T>> Hijo { get; set; }
        public T value { get; set; }
        public int MaxNode { get; set; }
        public int MinNode { get; set; }
        public int CantNode { get; set; }
        public bool Size { get; set; }
    }
}
