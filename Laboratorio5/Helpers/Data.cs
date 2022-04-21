using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio5.Arbol2_3;
using Laboratorio5.Models;

namespace Laboratorio5.Helpers
{
    public class Data
    {
        private static Data _instance = null;
        public BTree<VehiculosModel> Arbol = new BTree<VehiculosModel>();
        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }
    }
}
