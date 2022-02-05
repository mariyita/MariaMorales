using System;
using System.ComponentModel.DataAnnotations;

namespace MariaMorales.Models
{
    public class Cliente
    {
        
       [Key]
    public int ClienteId { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage ="El campo nombre es requerido")]
        public string Nombre { get; set; }

        [StringLength(100)]
        [Required(ErrorMessage = "El campo apellido es requerido")]
        public string Apellido { get; set; }

       
        [Required(ErrorMessage = "El campo telefono es requerido")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "El campo direccion es requerido")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El campo genero es requerido")]
        public int Genero { get; set; }

        [Required(ErrorMessage = "El campo cedula es requerido")]
        public string Cedula { get; set; }

       
        public int IdUsuario { get; set; }

        public DateTime FechaCreacion { get; set; }
    }

   
}

