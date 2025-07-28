namespace Ejercicio7.Controllers;
using Ejercicio7.Models;
using Ejercicio7.Data;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{

    public readonly Ejercicio7DbContext _context;

    public UserController(Ejercicio7DbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public ActionResult<IEnumerable<User>> GetUsers()
    {
        var users = _context.Users.ToList();
        return Ok(users);
    }
    [HttpGet("{id}")]
    public ActionResult<User> GetUserByUser(int id)
    {
        var User = _context.Users.SingleOrDefault(u => u.Id == id);
        if (User == null) return NotFound();
        return Ok(User);
    }
    [HttpGet("Search")]
    public IActionResult SearchUser([FromQuery] string? name, [FromQuery] int? age)
    {
        var query = _context.Users.AsQueryable();
        if (!string.IsNullOrWhiteSpace(name))
        {
            query = query.Where(u => u.Name != null && u.Name.Contains(name));
        }
        if(age != null)
        {
            query = query.Where(u => u.Age == age);
        }
        var resultado = query.ToList();
        return Ok(resultado);
    }
    [HttpPost]
    public ActionResult CreateUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
    }

}