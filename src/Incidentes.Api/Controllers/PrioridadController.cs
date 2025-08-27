using LogicaNegocio.Interfaces.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Incidentes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PrioridadController : ControllerBase
    {
        private readonly IPrioridadService _prioridadService;

        public PrioridadController(IPrioridadService prioridadService)
        {
            _prioridadService = prioridadService;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var prioridades = await _prioridadService.Listar();
            return Ok(prioridades);
        }
    }
}
