using System.ComponentModel.DataAnnotations;

namespace Ejercicio3.Models;

public class Animal
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Species { get; set; }
    [Required]
    public int? Age { get; set; }
    [Required]
    public decimal? Stature { get; set; }
}

