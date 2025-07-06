using Ejercicio4.Data;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio4.Controllers;
public class TaskController : Controller
{
    private readonly Ejercicio4DbContext _context;
    public TaskController(Ejercicio4DbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IActionResult CreateSampleTask()
    {
        return View();
    }
    [HttpPost]
    public IActionResult CreateSampleTask(Models.Task task)
    {
        if (ModelState.IsValid)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return RedirectToAction("ListTask");
        }
        return View(task);
    }
    [HttpGet]
    public IActionResult ListTask()
    {
        var tasks = _context.Tasks.ToList(); //sin el var seria: List<Models.Task>
        return View(tasks);
    }


}

