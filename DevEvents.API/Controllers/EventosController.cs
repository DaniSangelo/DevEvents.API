using DevEvents.API.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Controllers
{
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObterEventos()
        {
            var evento = new Evento
            {
                Titulo = "Bootcamp ASP.NET Core",
                Descricao = "Evento gratuito de ASP.NET Core",
                DataInicio = new DateTime(2021, 01, 25),
                DataFim = new DateTime(2021, 01, 29)
            };
            return Ok(evento);
        }

        [HttpGet("{id}")]
        public IActionResult ObterEvento(int id)
        {

        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Evento evento)
        {
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
    }
}
