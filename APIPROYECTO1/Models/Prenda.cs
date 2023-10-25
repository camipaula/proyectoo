﻿using System.ComponentModel.DataAnnotations;

namespace APIPROYECTO1.Models
{
    public class Prenda
    {
        [Key]
        public int IdPrenda { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public string Marca { get; set; }

        public int Cantidad { get; set; }

        public float Precio { get; set; }
    }
}
