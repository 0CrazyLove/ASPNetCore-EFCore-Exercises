using Microsoft.AspNetCore.Mvc;

namespace Ejercicio8.Controllers;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}