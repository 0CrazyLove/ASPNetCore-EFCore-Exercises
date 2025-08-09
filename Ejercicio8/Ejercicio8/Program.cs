using Microsoft.EntityFrameworkCore;
using Ejercicio8.Data;

var builder = WebApplication.CreateBuilder(args);
//database connection
builder.Services.AddDbContext<Ejercicio8DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllers();

app.UseHttpsRedirection();


app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
