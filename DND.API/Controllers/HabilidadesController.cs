using DND.API.Context;
using DND.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabilidadesController : ControllerBase
    {
        private readonly DndContext _context;

        public HabilidadesController(DndContext context)
        {
            _context = context;
        }

        // GET: api/Habilidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Habilidades>>> GetHabilidades()
        {
            if (_context.Habilidades == null)
            {
                return NotFound();
            }
            return await _context.Habilidades.ToListAsync();
        }

        // GET: api/Habilidades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Habilidades>> GetHabilidades(int id)
        {
            if (_context.Habilidades == null)
            {
                return NotFound();
            }
            var habilidades = await _context.Habilidades.FindAsync(id);

            if (habilidades == null)
            {
                return NotFound();
            }

            return habilidades;
        }

        // PUT: api/Habilidades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHabilidades(int id, Habilidades habilidades)
        {
            if (id != habilidades.Id)
            {
                return BadRequest();
            }

            _context.Entry(habilidades).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HabilidadesExists(id))
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

        // POST: api/Habilidades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Habilidades>> PostHabilidades(Habilidades habilidades)
        {
            if (_context.Habilidades == null)
            {
                return Problem("Entity set 'DndContext.Habilidades'  is null.");
            }
            _context.Habilidades.Add(habilidades);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHabilidades", new { id = habilidades.Id }, habilidades);
        }

        // DELETE: api/Habilidades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHabilidades(int id)
        {
            if (_context.Habilidades == null)
            {
                return NotFound();
            }
            var habilidades = await _context.Habilidades.FindAsync(id);
            if (habilidades == null)
            {
                return NotFound();
            }

            _context.Habilidades.Remove(habilidades);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HabilidadesExists(int id)
        {
            return (_context.Habilidades?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
