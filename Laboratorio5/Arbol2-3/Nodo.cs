using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Laboratorio5.Arbol2_3
{
    class Nodo<K, V>
    {
        List<K> Ks { get; set; }
        List<V> Vs { get; set; }
        List<Nodo<K, V>> Hijos { get; set; }
        Nodo<K, V> Padre { get; set; }
        public int Nodosminimos { get; set; }
        public int Nodosmaximos { get; set; }
        public int CantidadNodos { get; set; }
        public bool TipoNodo { get; set; }

        CompareKeyDelegate<K> KeyComparator;

        public Nodo(int Nodosminimos, int Nodosmaximos, bool TipoNodo, CompareKeyDelgate<K> _KeysComparator)
        {
            this.Ks = new List<K>();

            this.Vs = new List<V>();

            this.Hijos = new List<Nodo<K, V>>();

            this.Padre = null;

            this.Nodosminimos = Nodosminimos;

            CantidadNodos = 0;

            this.TipoNodo = TipoNodo;

            KeyComparator = _KeysComparator;
        }


        public V Search(K _Ks, Nodo<K, V> actual)
        {
            throw new NotImplementedException();
        }    

        public void Insert(K _Ks, V _value)
        {
            if (CantidadNodos < (Nodosmaximos - 1))
            {
                if (TipoNodo)
                {
                    int i = 0;
                    bool indexIsFound = false;
                    while ((i < Ks.Count) || (!indexIsFound))
                    {

                        if (KeyComparator(_Ks, Ks[i]) == 0)
                        {
                            return;
                        }

                        indexIsFound = KeyComparator(_Ks, Ks[i]) < 0;
                        i++;
                    }

                    Ks.Insert(i, _Ks);
                    Vs.Insert(i, _value);
                    CantidadNodos++;
                }
                else
                {
                    int i = 0;
                    bool indexIsFound = false;
                    while ((i < Ks.Count) || (!indexIsFound))
                    {
                        if (KeyComparator(_Ks, Ks[i]) == 0)
                        {
                            return;
                        }

                        indexIsFound = KeyComparator(_Ks, Ks[i]) < 0;
                        i++;
                    }
                    if (indexIsFound)
                    {
                        Hijos[i].Insert(_Ks, _value);
                    }
                    else
                    {
                        Hijos[Ks.Count].Insert(_Ks, _value);
                    }
                }
            }
        }
        private void Split(Nodo<K, V> actual)
        {
            if (Padre != null)
            {

            }
            else
            {
                if (TipoNodo)
                {
                    int index = Nodosmaximos / 2;
                    Nodo<K, V> izquierda = new Nodo<K, V>(Nodosminimos, Nodosmaximos,TipoNodo, numeros);
                    Nodo<K, V> derecha = new Nodo<K, V>(Nodosminimos, Nodosmaximos,TipoNodo,);

                    TipoNodo = false;

                    int borrar_llave = 0;
                    for (int i = 0; i < index; i++)
                    {
                        izquierda.Insert(Ks[i], Vs[i]);
                        izquierda.CantidadNodos++;
                        borrar_llave++;
                    }

                    while (borrar_llave > 0)
                    {
                        Ks.RemoveAt(0);
                        Vs.RemoveAt(0);
                        borrar_llave--;
                    }

                    for (int i = 1; i < index; i++)
                    {
                        derecha.Insert(Ks[i], Vs[i]);
                        derecha.CantidadNodos++;
                        borrar_llave++;
                    }

                    while (borrar_llave > 0)
                    {
                        Ks.RemoveAt(1);
                        Vs.RemoveAt(1);
                        borrar_llave--;
                    }

                    Hijos.Insert(0, izquierda);
                    Hijos.Insert(1, derecha);
                    izquierda.Padre = this;
                    derecha.Padre = this;
                    CantidadNodos = 1;
                }
            }
        }
    }

}
