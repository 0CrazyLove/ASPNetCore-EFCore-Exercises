using Microsoft.AspNetCore.Mvc;
namespace Ejercicio7.Controllers;

public class UserController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}

