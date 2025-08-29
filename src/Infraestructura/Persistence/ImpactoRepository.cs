using LogicaNegocio.Entidades;
using LogicaNegocio.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestructura.Persistence
{
    public class ImpactoRepository : IImpactoRepository
    {
        private readonly AppDbContext _appDbContext;

        public ImpactoRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Impacto>> Listar()
        {
            return await _appDbContext.ImpactosIncidentes.ToListAsync();
        }
    }
}
