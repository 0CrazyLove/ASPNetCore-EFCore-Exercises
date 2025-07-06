using Ejercicio4.Models.Validations;

namespace Ejercicio4.Models;

public class Task 
{
    public int Id { get; set; }
    [ValidTitle]
    public string? Title { get; set; }

    public bool IsCompleted { get; set; }

}
