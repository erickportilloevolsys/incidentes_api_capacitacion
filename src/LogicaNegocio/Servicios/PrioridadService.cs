using LogicaNegocio.Interfaces.Persistence;
using LogicaNegocio.Interfaces.Servicios;
using LogicaNegocio.Models.Prioridad;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicaNegocio.Servicios
{
    public class PrioridadService : IPrioridadService
    {
        private readonly IPrioridadRepository _repository;

        public PrioridadService(IPrioridadRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<PrioridadModel>> Listar()
        {
            var entidades = await _repository.Listar();
            return entidades.Select(e => new PrioridadModel
            {
                Id = e.Id,
                Descripcion = e.Descripcion
            });
        }
    }
}
