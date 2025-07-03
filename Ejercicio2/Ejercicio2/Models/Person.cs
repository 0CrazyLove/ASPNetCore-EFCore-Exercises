using Ejercicio2.Models.Validations;
namespace Ejercicio2.Models;

public class Person
{
    public int? Id { get; set; }
    [ValidName]
    public string? Name { get; set; }
    [ValidAge]
    public int? Age { get; set; }

}
