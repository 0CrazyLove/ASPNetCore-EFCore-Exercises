namespace Ejercicio6.Data;
using Microsoft.EntityFrameworkCore;
using Ejercicio6.Models;
public class Ejercicio6DbContext : DbContext
    {
        public Ejercicio6DbContext(DbContextOptions<Ejercicio6DbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; } = null!;
}
