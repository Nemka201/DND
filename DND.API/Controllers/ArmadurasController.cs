using DND.API.Context;
using DND.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dnd.API.Controllers
{
    [Route("api/armaduras")]
    [ApiController]
    public class ArmadurasController : ControllerBase
    {
        private readonly DndContext _context;

        public ArmadurasController(DndContext context)
        {
            _context = context;
        }

        // GET: api/Armaduras
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Armadura>>> GetArmaduras()
        {
            if (_context.Armaduras == null)
            {
                return NotFound();
            }
            return await _context.Armaduras.ToListAsync();
        }

        // GET: api/Armaduras/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Armadura>> GetArmadura(int id)
        {
            if (_context.Armaduras == null)
            {
                return NotFound();
            }
            var armadura = await _context.Armaduras.FindAsync(id);

            if (armadura == null)
            {
                return NotFound();
            }

            return armadura;
        }

        // PUT: api/Armaduras/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArmadura(int id, Armadura armadura)
        {
            if (id != armadura.Id)
            {
                return BadRequest();
            }

            _context.Entry(armadura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArmaduraExists(id))
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

        // POST: api/Armaduras
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Armadura>> PostArmadura(Armadura armadura)
        {
            if (_context.Armaduras == null)
            {
                return Problem("Entity set 'DndContext.Armaduras'  is null.");
            }
            _context.Armaduras.Add(armadura);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArmadura", new { id = armadura.Id }, armadura);
        }

        // DELETE: api/Armaduras/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArmadura(int id)
        {
            if (_context.Armaduras == null)
            {
                return NotFound();
            }
            var armadura = await _context.Armaduras.FindAsync(id);
            if (armadura == null)
            {
                return NotFound();
            }

            _context.Armaduras.Remove(armadura);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArmaduraExists(int id)
        {
            return (_context.Armaduras?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
