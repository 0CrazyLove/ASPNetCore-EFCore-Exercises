using Ejercicio3.Data;
using Microsoft.AspNetCore.Mvc;
using Ejercicio3.Models;
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
    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        if (ModelState.IsValid)
        {
            _context.Animals.Add(animal);
            _context.SaveChanges();
            return RedirectToAction("TableAnimals"); 
        }
        return View(animal);
    }
    [HttpGet]
    public IActionResult TableAnimals()
    {
        var animals = _context.Animals.ToList();
        return View(animals);
    }
    [HttpPost]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = _context.Animals.Find(id);
        if (animal != null)
        {
            _context.Animals.Remove(animal);
            _context.SaveChanges();
        }
        return RedirectToAction("TableAnimals");
    }
}

