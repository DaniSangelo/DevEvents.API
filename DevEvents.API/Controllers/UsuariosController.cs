using DevEvents.API.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace DevEvents.API.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            usuario = new Usuario
            {
                NomeCompleto = "Daniel Sangelo",
                Email = "danielsangelo@hotmail.com"
            };
            return Ok(usuario);
        }
    }
}
