using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MariaMorales.Models
{
    public class Prestamo
    {
        [Key]
        public int IdPrestamo { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        public float Monto { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        public float Interes { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        public int Plazo { get; set; }

       
        public DateTime FechaCreacion { get; set; }

        public int EstadoPrestamo { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }
    }
}
