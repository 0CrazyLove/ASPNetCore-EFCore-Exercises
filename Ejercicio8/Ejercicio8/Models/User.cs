using System.ComponentModel.DataAnnotations;

namespace Ejercicio8.Models;
public class User
{
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? LastName { get; set; }
}