using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5.Arbol2_3
{
    public class BTree<T> : IEnumerable<T>, IEnumerable
    {
        NodoArbol<T> raiz;
        int t;
        public BTree(int _t)
        {
            raiz = null;
            t = _t;
        }
        public BTree(int t1, bool leaf1)
        {
            t = t1;
            raiz.leaf = leaf1;

            raiz.Key = new int[2 * t-1];
            raiz.Child = new NodoArbol<T>[2 * t];

            raiz.numKey = 0;
        }
        public void Insertar(int k, T value)
        {
            if(raiz == null)
            {
                //raiz = new BTree(t, true);
                raiz.Key[0] = k;
                raiz.numKey = 1;
                raiz.value = value;
            }
            else
            {
                if(raiz.numKey == 2*t-1)
                {
                    //BTree<T> s = new BTree(t, false);

                }
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
