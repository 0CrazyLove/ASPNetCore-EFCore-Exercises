using System.ComponentModel.DataAnnotations;

namespace Ejercicio1.Models
{
    public class Producto
    {
        //properties
        public int? Id { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public decimal? Precio { get; set; }
        [Required]
        public int? Stock { get; set; }

    }
}
