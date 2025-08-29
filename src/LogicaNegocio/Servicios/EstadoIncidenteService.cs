using LogicaNegocio.Interfaces.Persistence;
using LogicaNegocio.Interfaces.Servicios;
using LogicaNegocio.Models.EstadoIncidente;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicaNegocio.Servicios
{
    public class EstadoIncidenteService : IEstadoIncidenteService
    {
        private readonly IEstadoIncidenteRepository _repository;

        public EstadoIncidenteService(IEstadoIncidenteRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<EstadoIncidenteModel>> Listar()
        {
            var entidades = await _repository.Listar();
            return entidades.Select(e => new EstadoIncidenteModel
            {
                Id = e.Id,
                Descripcion = e.Descripcion
            });
        }
    }
}
