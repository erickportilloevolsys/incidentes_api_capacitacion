using LogicaNegocio.Interfaces.Servicios;
using LogicaNegocio.Models.Incidente;
using Microsoft.AspNetCore.Mvc;

namespace Incidentes.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncidenteController : ControllerBase
    {
        private readonly IIncidenteService _incidenteService;

        public IncidenteController(IIncidenteService incidenteService)
        {
            _incidenteService = incidenteService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(int id)
        {
            var incidente = await _incidenteService.ObtenerPorId(id);
            return Ok(incidente);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(
            [FromBody] CrearIncidenteRequest modelo)
        {
            var nuevoIncidente = await _incidenteService.Crear(modelo);
            return CreatedAtAction(
                nameof(ObtenerPorId),
                new { id = nuevoIncidente.IdIncidente },
                nuevoIncidente);
        }
    }
}
