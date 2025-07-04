namespace Ejercicio3.Data;
using Microsoft.EntityFrameworkCore;

public class Ejercicio3DbContext : DbContext
{
    public Ejercicio3DbContext(DbContextOptions<Ejercicio3DbContext> options): base(options)
    {
    }
    public DbSet<Models.Animal> Animals { get; set; } = null!;


}

