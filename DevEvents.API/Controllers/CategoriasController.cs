using DevEvents.API.Persistencia;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DevEvents.API.Controllers
{
    [Route("api/[controller]")]
    public class CategoriasController : Controller
    {
        private readonly DevEventsContext _dbContext;
        public CategoriasController(DevEventsContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult ObterTodas()
        {
            var categorias = _dbContext.Categorias.ToList();

            return Ok(categorias);
        }
    }
}
