using LogicaNegocio.Entidades;
using LogicaNegocio.Enums;
using LogicaNegocio.Interfaces.Persistence;
using LogicaNegocio.Interfaces.Servicios;
using LogicaNegocio.Models.Incidente;
using LogicaNegocio.Validators.Incidente;

namespace LogicaNegocio.Servicios
{
    public class IncidenteService : IIncidenteService
    {
        private readonly IIncidenteRepository _repository;

        public IncidenteService(IIncidenteRepository repository)
        {
            _repository = repository;
        }

        public async Task<CrearIncidenteResult> Crear(CrearIncidenteRequest request)
        {
            var validator = new CrearIncidenteRequestValidator();
            var validationResult = validator.Validar(request);
            if(!validationResult.EsValido)
            {
                return new CrearIncidenteResult
                {
                    EsValido = validationResult.EsValido,
                    MensajeError = validationResult.MensajeError,
                    PropiedadError = validationResult.PropiedadError
                };
            }

            var incidente = new Incidente
            {
                Descripcion = request.Descripcion,
                FechaRegistro = DateTime.Now,
                IdEstado = (int)EstadoIncidenteEnum.Solicitado,
                IdImpacto = request.IdImpacto,
                IdPrioridad = request.IdPrioridad,
                IdTipoIncidente = request.IdTipoIncidente,
                NombreCompleto = request.NombreCompleto,
                Telefono = request.Telefono,
                Email = request.Email
            };
            var id = await _repository.Guardar(incidente);
            return new CrearIncidenteResult
            {
                IdIncidente = id,
                FechaRegistro = incidente.FechaRegistro.ToShortDateString(),
                HoraRegistro = incidente.FechaRegistro.ToShortTimeString(),
                EsValido = true
            };
        }

        public async Task<IncidenteModel> ObtenerPorId(int id)
        {
            var incidente = await _repository.ObtenerPorId(id);
            if (incidente == null)
            {
                throw new Exception("Incidente no encontrado");
            }
            return new IncidenteModel
            {
                Id = incidente.Id,
                Descripcion = incidente.Descripcion,
                FechaRegistro = incidente.FechaRegistro,
                IdEstado = incidente.IdEstado,
                Estado = incidente.EstadoIncidente.Descripcion,
                IdImpacto = incidente.IdImpacto,
                Impacto = incidente.Impacto.Descripcion,
                IdPrioridad = incidente.IdPrioridad,
                Prioridad = incidente.Prioridad.Descripcion,
                IdTipoIncidente = incidente.IdTipoIncidente,
                TipoIncidente = incidente.TipoIncidente.Descripcion,
                NombreCompleto = incidente.NombreCompleto,
                Telefono = incidente.Telefono,
                Email = incidente.Email
            };
        }
    }
}
