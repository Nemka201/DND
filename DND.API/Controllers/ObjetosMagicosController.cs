using DND.API.Context;
using DND.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjetosMagicosController : ControllerBase
    {
        private readonly DndContext _context;

        public ObjetosMagicosController(DndContext context)
        {
            _context = context;
        }

        // GET: api/ObjetosMagicos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ObjetoMagico>>> GetObjetosMagicos()
        {
            if (_context.ObjetosMagicos == null)
            {
                return NotFound();
            }
            return await _context.ObjetosMagicos.ToListAsync();
        }

        // GET: api/ObjetosMagicos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ObjetoMagico>> GetObjetoMagico(int id)
        {
            if (_context.ObjetosMagicos == null)
            {
                return NotFound();
            }
            var objetoMagico = await _context.ObjetosMagicos.FindAsync(id);

            if (objetoMagico == null)
            {
                return NotFound();
            }

            return objetoMagico;
        }

        // PUT: api/ObjetosMagicos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObjetoMagico(int id, ObjetoMagico objetoMagico)
        {
            if (id != objetoMagico.Id)
            {
                return BadRequest();
            }

            _context.Entry(objetoMagico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjetoMagicoExists(id))
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

        // POST: api/ObjetosMagicos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ObjetoMagico>> PostObjetoMagico(ObjetoMagico objetoMagico)
        {
            if (_context.ObjetosMagicos == null)
            {
                return Problem("Entity set 'DndContext.ObjetosMagicos'  is null.");
            }
            _context.ObjetosMagicos.Add(objetoMagico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetObjetoMagico", new { id = objetoMagico.Id }, objetoMagico);
        }

        // DELETE: api/ObjetosMagicos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObjetoMagico(int id)
        {
            if (_context.ObjetosMagicos == null)
            {
                return NotFound();
            }
            var objetoMagico = await _context.ObjetosMagicos.FindAsync(id);
            if (objetoMagico == null)
            {
                return NotFound();
            }

            _context.ObjetosMagicos.Remove(objetoMagico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ObjetoMagicoExists(int id)
        {
            return (_context.ObjetosMagicos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
