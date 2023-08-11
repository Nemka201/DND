using DND.API.Context;
using DND.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaracteristicasController : ControllerBase
    {
        private readonly DndContext _context;

        public CaracteristicasController(DndContext context)
        {
            _context = context;
        }

        // GET: api/Caracteristicas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Caracteristicas>>> GetCaracteristicas()
        {
            if (_context.Caracteristicas == null)
            {
                return NotFound();
            }
            return await _context.Caracteristicas.ToListAsync();
        }

        // GET: api/Caracteristicas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Caracteristicas>> GetCaracteristicas(int id)
        {
            if (_context.Caracteristicas == null)
            {
                return NotFound();
            }
            var caracteristicas = await _context.Caracteristicas.FindAsync(id);

            if (caracteristicas == null)
            {
                return NotFound();
            }

            return caracteristicas;
        }

        // PUT: api/Caracteristicas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCaracteristicas(int id, Caracteristicas caracteristicas)
        {
            if (id != caracteristicas.Id)
            {
                return BadRequest();
            }

            _context.Entry(caracteristicas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CaracteristicasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Caracteristicas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Caracteristicas>> PostCaracteristicas(Caracteristicas caracteristicas)
        {
            if (_context.Caracteristicas == null)
            {
                return Problem("Entity set 'DndContext.Caracteristicas'  is null.");
            }
            _context.Caracteristicas.Add(caracteristicas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCaracteristicas", new { id = caracteristicas.Id }, caracteristicas);
        }

        // DELETE: api/Caracteristicas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCaracteristicas(int id)
        {
            if (_context.Caracteristicas == null)
            {
                return NotFound();
            }
            var caracteristicas = await _context.Caracteristicas.FindAsync(id);
            if (caracteristicas == null)
            {
                return NotFound();
            }

            _context.Caracteristicas.Remove(caracteristicas);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CaracteristicasExists(int id)
        {
            return (_context.Caracteristicas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
