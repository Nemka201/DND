using DND.API.Context;
using DND.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmasController : ControllerBase
    {
        private readonly DndContext _context;

        public ArmasController(DndContext context)
        {
            _context = context;
        }

        // GET: api/Armas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Arma>>> GetArmas()
        {
            if (_context.Armas == null)
            {
                return NotFound();
            }
            return await _context.Armas.ToListAsync();
        }

        // GET: api/Armas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Arma>> GetArma(int id)
        {
            if (_context.Armas == null)
            {
                return NotFound();
            }
            var arma = await _context.Armas.FindAsync(id);

            if (arma == null)
            {
                return NotFound();
            }

            return arma;
        }

        // PUT: api/Armas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArma(int id, Arma arma)
        {
            if (id != arma.Id)
            {
                return BadRequest();
            }

            _context.Entry(arma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmaExists(id))
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

        // POST: api/Armas
        [HttpPost]
        public async Task<ActionResult<Arma>> PostArma(Arma arma)
        {
            if (_context.Armas == null)
            {
                return Problem("Entity set 'DndContext.Armas'  is null.");
            }
            _context.Armas.Add(arma);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArma", new { id = arma.Id }, arma);
        }

        // DELETE: api/Armas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArma(int id)
        {
            if (_context.Armas == null)
            {
                return NotFound();
            }
            var arma = await _context.Armas.FindAsync(id);
            if (arma == null)
            {
                return NotFound();
            }

            _context.Armas.Remove(arma);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArmaExists(int id)
        {
            return (_context.Armas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
