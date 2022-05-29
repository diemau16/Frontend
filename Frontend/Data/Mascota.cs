﻿using System.ComponentModel.DataAnnotations;

namespace Frontend.Data
{
    public class Mascota
    {
        [Key]
        public int celularDueño { get; set; }
        public string nombre { get; set; }
        public string raza { get; set; }
        public int edad { get; set; }
        public string nombreDueño { get; set; }
    }
}
