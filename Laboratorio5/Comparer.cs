using Laboratorio5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5
{
    public delegate int Comparer<T>(T a, T b);

    public class Comparer
    {

        public static int Comp(VehiculosModel a, VehiculosModel b)
        {
            if (a.Placas != b.Placas)
            {
                if (a.Placas.CompareTo(b.Placas) < 0)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }


    }
}
