using Ejercicio2.Models;
using Microsoft.EntityFrameworkCore;
namespace Ejercicio2.Data;

public class Ejercicio2DbContext : DbContext
{
    public Ejercicio2DbContext(DbContextOptions<Ejercicio2DbContext> options)
        : base(options)
    {
    }
    public DbSet<Person> Persons { get; set; } = null!;
    
}

