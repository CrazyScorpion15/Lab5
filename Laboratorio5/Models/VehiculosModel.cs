using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace Laboratorio5.Models
{
    public class VehiculosModel
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

            return true;
        }
    }
}
