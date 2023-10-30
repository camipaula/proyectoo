﻿using System.ComponentModel.DataAnnotations;

namespace APIPROYECTO1.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
    }
}
