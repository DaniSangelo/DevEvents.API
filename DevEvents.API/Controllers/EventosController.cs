using DevEvents.API.Entidades;
using DevEvents.API.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DevEvents.API.Controllers
{
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DevEventsContext _context;

        public EventosController(DevEventsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ObterEventos()
        {
            var eventos = _context.Eventos.ToList();            
            return Ok(eventos);
        }

        [HttpGet("{id}")]
        public IActionResult ObterEvento(int id)
        {
            var evento = _context.Eventos.Include(e => e.Categoria).Include(e => e.Usuario).SingleOrDefault(e => e.Id == id);
            if (evento == null)
                return NotFound();

            return Ok();
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Evento evento)
        {
            _context.Eventos.Add(evento);
            _context.SaveChanges();
            return Ok();
        }
        
        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] Evento evento)
        {
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Cancelar(int id)
        {
            return NoContent();
        }

        [HttpPost("{id}/usuarios/{idUsuario}/inscrever")]
        public IActionResult Inscrever(int id, int idUsuario, [FromBody] Inscricao inscricao)
        {
            return NoContent();
        }
    }
}
