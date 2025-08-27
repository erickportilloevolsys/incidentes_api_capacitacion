using LogicaNegocio.Interfaces.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Incidentes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TipoIncidenteController : ControllerBase
    {
        private readonly ITipoIncidenteService _tipoIncidenteService;

        public TipoIncidenteController(ITipoIncidenteService tipoIncidenteService)
        {
            _tipoIncidenteService = tipoIncidenteService;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var tiposIncidente = await _tipoIncidenteService.Listar();
            return Ok(tiposIncidente);
        }
    }
}
