using LogicaNegocio.Entidades;
using LogicaNegocio.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestructura.Persistence
{
    public class PrioridadRepository : IPrioridadRepository
    {
        private readonly AppDbContext _appDbContext;

        public PrioridadRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Prioridad>> Listar()
        {
            return await _appDbContext.PrioridadesIncidentes.ToListAsync();
        }
    }
}
