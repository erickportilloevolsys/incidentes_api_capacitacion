using LogicaNegocio.Interfaces.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Incidentes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImpactoController : ControllerBase
    {
        private readonly IImpactoService _impactoService;

        public ImpactoController(IImpactoService impactoService)
        {
            _impactoService = impactoService;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var impactos = await _impactoService.Listar();
            return Ok(impactos);
        }
    }
}
