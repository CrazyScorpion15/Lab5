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
        public float Longitud { get; set; }
        [Required]
        public float Latitud { get; set; }

    }
}
