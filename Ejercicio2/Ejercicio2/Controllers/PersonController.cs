using Microsoft.AspNetCore.Mvc;
using Ejercicio2.Data;
using Ejercicio2.Models;
namespace Ejercicio2.Controllers;

public class PersonController : Controller
{
    private readonly Ejercicio2DbContext _context;
    public PersonController(Ejercicio2DbContext context)
    {
        _context = context;
    }
    // GET: Person/Create
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    // POST: Person/Create
    [HttpPost]
    public IActionResult Create(Person person)
    {
        if (ModelState.IsValid)
        {
            _context.Persons.Add(person);
            _context.SaveChanges();
            return RedirectToAction("Verified");
        }
        return View(person);
    }
    [HttpGet]
    public IActionResult Verified()
    {
        var persons = _context.Persons.ToList();
        return View(persons);
    }
}

