using Ejercicio3.Data;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio3.Controllers;
public class AnimalController : Controller
{
    private readonly Ejercicio3DbContext _context;
    public AnimalController(Ejercicio3DbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IActionResult CreateAnimal()
    {
        return View();
    }
}

