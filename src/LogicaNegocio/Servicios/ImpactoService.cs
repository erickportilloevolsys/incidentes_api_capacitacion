using LogicaNegocio.Interfaces.Persistence;
using LogicaNegocio.Interfaces.Servicios;
using LogicaNegocio.Models.Impacto;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogicaNegocio.Servicios
{
    public class ImpactoService : IImpactoService
    {
        private readonly IImpactoRepository _repository;

        public ImpactoService(IImpactoRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ImpactoModel>> Listar()
        {
            var entidades = await _repository.Listar();
            return entidades.Select(e => new ImpactoModel
            {
                Id = e.Id,
                Descripcion = e.Descripcion
            });
        }
    }
}
