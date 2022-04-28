using Laboratorio5.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5.Arbol2_3
{
    public class BTree<T> : IEnumerable<T>, IEnumerable
    {

        readonly Nodo<T> NPadre = new Nodo<T>();


        public void Agregar(T valor, Delegate delegado)
        {
            Insertar(NPadre, valor, delegado);
        }

        void Insertar(Nodo<T> padre, T valor, Delegate delegado)
        {
            if (padre.valor == null)
            {
                padre.valor = valor;

                padre.Izq = new Nodo<T>();
                padre.Der = new Nodo<T>();
                padre.ArbolDer = new Nodo<T>();
                padre.Izq = new Nodo<T>();

            }
            else if (padre.ArbolIzq.valor == null && Convert.ToInt32(delegado.DynamicInvoke(valor, padre.valor)) == -1)
            {
                if (padre.Izq.valor != null)
                {
                    padre.Der.valor = padre.valor;

                    if (Convert.ToInt32(delegado.DynamicInvoke(valor, padre.Der.valor)) == -1)
                    {
                        padre.valor = valor;
                    }
                    else
                    {
                        padre.valor = padre.Izq.valor;
                        padre.Izq.valor = valor;
                    }
                }
            }
            else if (padre.ArbolDer.valor == null && Convert.ToInt32(delegado.DynamicInvoke(valor, padre.valor)) == -1)
            {
                if (padre.Der.valor != null)
                {
                    padre.Izq.valor = padre.valor;

                    if (Convert.ToInt32(delegado.DynamicInvoke(valor, padre.Der.valor)) == -1)
                    {
                        padre.valor = valor;
                    }
                    else
                    {
                        padre.valor = padre.Der.valor;
                        padre.Der.valor = valor;
                    }
                }
            }
            else if (Convert.ToInt32(delegado.DynamicInvoke(valor, padre.valor)) == -1)
            {
                Insertar(padre.ArbolIzq, valor, delegado);
                split(padre.ArbolIzq, padre.Izq);
            }
            else if (Convert.ToInt32(delegado.DynamicInvoke(valor, padre.valor)) == -1)
            {
                Insertar(padre.ArbolDer, valor, delegado);
                split(padre.ArbolDer, padre.Der);
            }           
 
        }

        void split(Nodo<T> mid, Nodo<T> padre)
        {
            if (mid.Izq.valor != null && mid.valor  != null && mid.Der.valor != null)
            {
                padre.valor = mid.valor;
                mid.valor = default;

                padre.ArbolDer = mid.Der;
                padre.ArbolIzq = mid.Izq;
            }
        }

        //last commit
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
