using DevEvents.API.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Controllers
{
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        [HttpPost]
        public IActionResult Cadastrar([FromBody] Usuario usuario)
        {
            return Ok();
        }
    }
}
