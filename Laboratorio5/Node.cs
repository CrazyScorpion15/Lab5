using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5
{
    public class Node<T>
    {
        public T info;
        public int altura;
        public Node<T> nodo;
        public Node<T> izq;
        public Node<T> der;
    }
}
