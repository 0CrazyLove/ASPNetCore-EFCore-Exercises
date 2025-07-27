using Microsoft.AspNetCore.Mvc;
using Ejercicio6.Data;
using Ejercicio6.Models;

namespace Ejercicio6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public readonly Ejercicio6DbContext _context;
        public UserController(Ejercicio6DbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            return _context.Users.ToList();
        }
        [HttpGet("{id}")]
        public ActionResult<User> SearchUserId(int id)
        {
            var User = _context.Users.SingleOrDefault(u => u.Id == id);
            if (User == null) return NotFound();
            return Ok(User);
        }


        [HttpPost]
        // POST api/user
        public ActionResult<User> CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUsers), new { id = user.Id }, user);
        }   

    }
}
