using Microsoft.AspNetCore.Mvc;
using Ejercicio6.Data;
using Ejercicio6.Models;

namespace Ejercicio6.Controllers
{
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
        [HttpPost]
        // POST api/user
        public ActionResult CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetUsers), new { id = user.Id });
        }   

    }
}
