using DevEvents.API.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Controllers
{
    [Route("api/[controller]")]
    public class CategoriasController : Controller
    {
        [HttpGet]
        public IActionResult ObterTodas()
        {
            var categorias = new List<Categoria>
            {
                new Categoria {Descricao = ".NET"},
                new Categoria {Descricao = "Mobile"},
                new Categoria {Descricao = "Machine Learning"}

            };
            return Ok(categorias);
        }
    }
}
