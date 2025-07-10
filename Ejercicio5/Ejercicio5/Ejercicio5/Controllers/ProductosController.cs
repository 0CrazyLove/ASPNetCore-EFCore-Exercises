using Ejercicio5.Models;
using Microsoft.AspNetCore.Mvc;
namespace Ejercicio5.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductosController : ControllerBase
{
    private static List<Producto> productos = new List<Producto>
    {
        new Producto { Id = 1, Nombre = "Producto 1", Precio = 10.0 },
        new Producto { Id = 2, Nombre = "Producto 2", Precio = 20.0 },
    };
    // Get: api/productos
    [HttpGet]
    public ActionResult<IEnumerable<Producto>> Get()
    {
        return Ok(productos);
    }

    // GET: api/productos/1
    [HttpGet("{id}")]
    public ActionResult<Producto> Get(int id)
    {
        var producto = productos.FirstOrDefault(p => p.Id == id);
        if (producto == null)
        {
            return NotFound();
        }
        return Ok(producto);
    }
    // POST: api/productos
    [HttpPost]
    public ActionResult<Producto> Post(Producto nuevo)
    {
       
        nuevo.Id = productos.Count + 1; 
        productos.Add(nuevo);
        return CreatedAtAction(nameof(Get), new { id = nuevo.Id }, nuevo);
    }
    // PUT: api/productos/{id}
    [HttpPut("{id}")]
    public IActionResult Put(int id, Producto actualizado)
    {
        var producto = productos.FirstOrDefault(p => p.Id == id);
        if (producto == null)
        {
            return NotFound();
        }
        producto.Nombre = actualizado.Nombre;
        producto.Precio = actualizado.Precio;
        return NoContent();
    }
    // DELETE: api/productos/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var producto = productos.FirstOrDefault(p => p.Id == id);
        if (producto == null)
        {
            return NotFound();
        }
        productos.Remove(producto);
        return NoContent();
    }

}


