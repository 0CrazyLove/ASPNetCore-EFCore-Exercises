using Microsoft.EntityFrameworkCore;
using Ejercicio8.Data;

var builder = WebApplication.CreateBuilder(args);
//database connection
builder.Services.AddDbContext<Ejercicio8DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Agrega servicios para MVC con vistas Razor
builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllers();

app.UseHttpsRedirection();
// Enable static files to serve CSS, JS, and images
app.UseStaticFiles();

//mapear ruta mvc
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=User}/{action=Index}/{id?}");
app.Run();


