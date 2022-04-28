using Laboratorio5.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Laboratorio5.Models
{
    public class VehiculosModel: IComparable
    {
        [Required]
        [Index(0)]
        public int Placas { get; set; }
        [Required]
        [Index(1)]
        public string Color { get; set; }
        [Required]
        [Index(2)]
        public string Propietario { get; set; }
        [Required]
        [Index(3)]
        public double Longitud { get; set; }
        [Required]
        [Index(4)]
        public double Latitud { get; set; }

        public static bool Save(VehiculosModel model)
        {
            Data.Instance.Arbol.Agregar(model, model.Comparer);
            return true;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public Comparison<VehiculosModel> Comparer = delegate (VehiculosModel Vehi1, VehiculosModel vehi2)
        {
            return Vehi1.Placas.CompareTo(vehi2.Placas);
        };



    }
}
