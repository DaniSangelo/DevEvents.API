using DevEvents.API.Entidades;
using DevEvents.API.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace DevEvents.API.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly DevEventsContext _dbContext;
        public UsuariosController(DevEventsContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            _dbContext.Usuarios.Add(usuario);
            _dbContext.SaveChanges();

            return Ok();
        }
    }
}
