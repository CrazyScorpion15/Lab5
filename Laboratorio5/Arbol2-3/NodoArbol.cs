using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5.Arbol2_3
{
    public class NodoArbol<T>
    {
        public int[] Key { get; set; }
        public T value { get; set; }
        public int t { get; set; }
        public int numKey { get; set; }
        public bool leaf { get; set; }
        public NodoArbol<T>[] Child { get; set; }
    }
}
