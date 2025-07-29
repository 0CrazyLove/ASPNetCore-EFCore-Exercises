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
    //[HttpGet("{id}")]

    [HttpGet("Search")]
    public IActionResult SearchUser([FromQuery] string? name, [FromQuery] int? id)
    {
        var query = _context.Users.AsQueryable();
        if (!string.IsNullOrWhiteSpace(name))
        {
            query = query.Where(u => u.Name != null && u.Name.Contains(name));
        }
        if (id != null)
        {
            query = query.Where(u => u.Id == id);
        }
        var resultado = query.ToList();
        return Ok(resultado);
    }
    
    [HttpPost]
     public ActionResult CreateUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return CreatedAtAction(nameof(SearchUser), new { id = user.Id }, user);
    }
    
}