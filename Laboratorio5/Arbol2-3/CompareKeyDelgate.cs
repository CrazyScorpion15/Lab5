using System;

namespace Laboratorio5.Arbol2_3
{
    public class CompareKeyDelgate<K>
    {
        public static implicit operator CompareKeyDelegate<K>(CompareKeyDelgate<K> v)
        {
            throw new NotImplementedException();
        }
    }
}