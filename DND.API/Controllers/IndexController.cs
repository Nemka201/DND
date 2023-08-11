using DND.API.Context;
using DND.Shared.Models.DTO;
using DND.Shared.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dnd.API.Controllers
{
    [Route("api/index")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        private readonly DndContext _context;

        public IndexController(DndContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IndexDTO>> GetIndexDTO()
        {
            IndexDTO indexData = new IndexDTO();
            if (_context.Armaduras != null)
            {
                indexData.Armaduras = await _context.Armaduras.ToListAsync();
            }
            if (_context.Armas != null)
            {
                indexData.Armas = await _context.Armas.ToListAsync();
            }
            if (_context.Clases != null)
            {
                indexData.Clases = await _context.Clases.ToListAsync();
            }
            if (_context.Conjuros != null)
            {
                indexData.Conjuros = await _context.Conjuros.ToListAsync();
            }
            if (_context.Dotes != null)
            {
                indexData.Dotes = await _context.Dotes.ToListAsync();
            }
            if (_context.ObjetosMagicos != null)
            {
                indexData.ObjetosMagicos = await _context.ObjetosMagicos.ToListAsync();
            }
            if (_context.Razas != null)
            {
                indexData.Razas = await _context.Razas.ToListAsync();
            }
            return indexData;
        }       
    }
}
