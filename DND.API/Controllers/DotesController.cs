using DND.API.Context;
using DND.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DotesController : ControllerBase
    {
        private readonly DndContext _context;

        public DotesController(DndContext context)
        {
            _context = context;
        }

        // GET: api/Dotes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dote>>> GetDotes()
        {
            if (_context.Dotes == null)
            {
                return NotFound();
            }
            return await _context.Dotes.ToListAsync();
        }

        // GET: api/Dotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dote>> GetDote(int id)
        {
            if (_context.Dotes == null)
            {
                return NotFound();
            }
            var dote = await _context.Dotes.FindAsync(id);

            if (dote == null)
            {
                return NotFound();
            }

            return dote;
        }

        // PUT: api/Dotes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDote(int id, Dote dote)
        {
            if (id != dote.Id)
            {
                return BadRequest();
            }

            _context.Entry(dote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DoteExists(id))
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

        // POST: api/Dotes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dote>> PostDote(Dote dote)
        {
            if (_context.Dotes == null)
            {
                return Problem("Entity set 'DndContext.Dotes'  is null.");
            }
            _context.Dotes.Add(dote);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDote", new { id = dote.Id }, dote);
        }

        // DELETE: api/Dotes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDote(int id)
        {
            if (_context.Dotes == null)
            {
                return NotFound();
            }
            var dote = await _context.Dotes.FindAsync(id);
            if (dote == null)
            {
                return NotFound();
            }

            _context.Dotes.Remove(dote);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DoteExists(int id)
        {
            return (_context.Dotes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
