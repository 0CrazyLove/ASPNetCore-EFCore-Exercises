namespace Ejercicio8.Data;
using Ejercicio8.Models;
using Microsoft.EntityFrameworkCore;
public class Ejercicio8DbContext : DbContext
{
    public Ejercicio8DbContext(DbContextOptions<Ejercicio8DbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
}