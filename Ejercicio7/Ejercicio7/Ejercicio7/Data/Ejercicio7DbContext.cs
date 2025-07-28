namespace Ejercicio7.Data;
using Microsoft.EntityFrameworkCore;
using Ejercicio7.Models;
public class Ejercicio7DbContext : DbContext
{
    public Ejercicio7DbContext(DbContextOptions<Ejercicio7DbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
}
