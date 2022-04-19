using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5.Arbol2_3
{
    class Nodo<K,V>
    {
        List<K> Ks { get; set; }
        List<V> Vs { get; set; }
        List<Nodo<K,V>> Hijos { get; set; }
        Nodo<K,V> Padre { get; set; }
        public int Nodominimo { get; set; }
        public int Nodomaximo { get; set; }
        public int CantidadNodos { get; set; }
        public bool TipoNodo { get; set; }
    }
}
