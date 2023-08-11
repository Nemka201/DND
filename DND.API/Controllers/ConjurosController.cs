using DND.API.Context;
using DND.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConjurosController : ControllerBase
    {
        private readonly DndContext _context;

        public ConjurosController(DndContext context)
        {
            _context = context;
        }

        // GET: api/Conjuros
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Conjuro>>> GetConjuros()
        {
            if (_context.Conjuros == null)
            {
                return NotFound();
            }
            return await _context.Conjuros.ToListAsync();
        }

        // GET: api/Conjuros/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Conjuro>> GetConjuro(int id)
        {
            if (_context.Conjuros == null)
            {
                return NotFound();
            }
            var conjuro = await _context.Conjuros.FindAsync(id);

            if (conjuro == null)
            {
                return NotFound();
            }

            return conjuro;
        }

        // PUT: api/Conjuros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConjuro(int id, Conjuro conjuro)
        {
            if (id != conjuro.Id)
            {
                return BadRequest();
            }

            _context.Entry(conjuro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConjuroExists(id))
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

        // POST: api/Conjuros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Conjuro>> PostConjuro(Conjuro conjuro)
        {
            if (_context.Conjuros == null)
            {
                return Problem("Entity set 'DndContext.Conjuros'  is null.");
            }
            _context.Conjuros.Add(conjuro);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConjuro", new { id = conjuro.Id }, conjuro);
        }

        // DELETE: api/Conjuros/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConjuro(int id)
        {
            if (_context.Conjuros == null)
            {
                return NotFound();
            }
            var conjuro = await _context.Conjuros.FindAsync(id);
            if (conjuro == null)
            {
                return NotFound();
            }

            _context.Conjuros.Remove(conjuro);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ConjuroExists(int id)
        {
            return (_context.Conjuros?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
