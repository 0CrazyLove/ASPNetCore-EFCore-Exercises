namespace Ejercicio8.Controllers;

using Ejercicio8.Data;
using Ejercicio8.Models;
using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class UserApiController : ControllerBase
{
    public readonly Ejercicio8DbContext _context; //entender por qué es readonly
    public UserApiController(Ejercicio8DbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IActionResult GetUsers([FromQuery] int? id, string? name)
    {
        var query = _context.Users.AsQueryable(); //repasar lo de AsQueryable
        if (id.HasValue)
        {
            query = query.Where(u => u.Id == id);
        }
        if (!string.IsNullOrWhiteSpace(name))
        {
            query = query.Where(u => u.Name != null && u.Name.Contains(name)); //repasar esta linea y lo de lambda
        }
        var users = query.ToList();
        return Ok(users);
    }
    [HttpPost]
    public IActionResult CreateUser(User user)
    {
        if (ModelState.IsValid)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);

        }
        return BadRequest(ModelState);
    }
}