using System.ComponentModel.DataAnnotations;

namespace Ejercicio4.Models;

public class Task 
{
    public int Id { get; set; }
    [Required]
    public string? Title { get; set; }

    public bool IsCompleted { get; set; }

}
