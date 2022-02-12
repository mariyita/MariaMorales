using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MariaMorales.Models
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }
        
      public float MontoPagado { get; set; }

      public DateTime FechaPago { get; set; }

        [Required]
        public int IdPrestamo { get; set; }

        [ForeignKey("IdPrestamo")]
        public Prestamo Prestamo { get; set; }
    }
}
