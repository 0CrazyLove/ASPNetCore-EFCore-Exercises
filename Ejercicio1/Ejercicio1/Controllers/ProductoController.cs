
using Ejercicio1.Data;
using Ejercicio1.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio1.Controllers;
public class ProductoController : Controller
{
    private readonly AppDbContext _context;
    public ProductoController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    // GET: Producto/Create
    public IActionResult Create()
    {
        return View();
    }
    // POST: Producto/Create
    [HttpPost]
    public IActionResult Create(Producto producto)
    {
        if (ModelState.IsValid)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
            return RedirectToAction("Crear");
        }
        return View(producto);
    }

}

