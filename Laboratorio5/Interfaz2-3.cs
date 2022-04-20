using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

public delegate K GetKeyDelegate<K, V>(V value);

public delegate int CompareKeyDelegate<K>(K key1, K key2);

namespace Laboratorio5
{
    interface DostresTree <K, V>
    {
        void Insert(K key, V value);

        V Search(K key);

        V Delete(K key);

        V[] GetList();

        //void Traversal(TreeTraversal<V> trasversal);

        bool IsEmpty();

        int Count();
    }
}
