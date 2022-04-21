using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio5.Models
{
    public class VehiculosModel
    {
        [Required]
        public int Placas { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Propietario { get; set; }
        [Required]
        public double Longitud { get; set; }
        [Required]
        public double Latitud { get; set; }

        public static bool Save(VehiculosModel model)
        {

            return true;
        }
    }
}
