using LogicaNegocio.Interfaces.Persistence;
using LogicaNegocio.Interfaces.Servicios;
using LogicaNegocio.Models.TipoIncidente;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicaNegocio.Servicios
{
    public class TipoIncidenteService : ITipoIncidenteService
    {
        private readonly ITipoIncidenteRepository _repository;

        public TipoIncidenteService(ITipoIncidenteRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<TipoIncidenteModel>> Listar()
        {
            var entidades = await _repository.Listar();
            return entidades.Select(e => new TipoIncidenteModel
            {
                Id = e.Id,
                Descripcion = e.Descripcion
            });
        }
    }
}
