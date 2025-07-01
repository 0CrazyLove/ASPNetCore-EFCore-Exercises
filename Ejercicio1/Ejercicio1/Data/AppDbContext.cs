using Microsoft.EntityFrameworkCore;
using Ejercicio1.Models;
namespace Ejercicio1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }

    }
}
