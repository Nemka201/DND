﻿using DND.API.Context;
using DND.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dnd.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClasesController : ControllerBase
    {
        private readonly DndContext _context;

        public ClasesController(DndContext context)
        {
            _context = context;
        }

        // GET: api/Clases
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clase>>> GetClases()
        {
            if (_context.Clases == null)
            {
                return NotFound();
            }
            return await _context.Clases.ToListAsync();
        }

        // GET: api/Clases/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clase>> GetClase(int id)
        {
            if (_context.Clases == null)
            {
                return NotFound();
            }
            var clase = await _context.Clases.FindAsync(id);

            if (clase == null)
            {
                return NotFound();
            }

            return clase;
        }

        // PUT: api/Clases/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClase(int id, Clase clase)
        {
            if (id != clase.Id)
            {
                return BadRequest();
            }

            _context.Entry(clase).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClaseExists(id))
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

        // POST: api/Clases
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Clase>> PostClase(Clase clase)
        {
            if (_context.Clases == null)
            {
                return Problem("Entity set 'DndContext.Clases'  is null.");
            }
            _context.Clases.Add(clase);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClase", new { id = clase.Id }, clase);
        }

        // DELETE: api/Clases/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClase(int id)
        {
            if (_context.Clases == null)
            {
                return NotFound();
            }
            var clase = await _context.Clases.FindAsync(id);
            if (clase == null)
            {
                return NotFound();
            }

            _context.Clases.Remove(clase);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClaseExists(int id)
        {
            return (_context.Clases?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
