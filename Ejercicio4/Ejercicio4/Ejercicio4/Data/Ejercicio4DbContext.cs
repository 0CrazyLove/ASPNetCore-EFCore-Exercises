using Microsoft.EntityFrameworkCore;
namespace Ejercicio4.Data;

public class Ejercicio4DbContext : DbContext
{
    public Ejercicio4DbContext(DbContextOptions<Ejercicio4DbContext> options) : base(options)
    {
    }
    public DbSet<Models.Task> Tasks { get; set; } = null!;

}




