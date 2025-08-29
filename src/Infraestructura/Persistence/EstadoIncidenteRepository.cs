using LogicaNegocio.Entidades;
using LogicaNegocio.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Persistence
{
    public class EstadoIncidenteRepository : IEstadoIncidenteRepository
    {
        private readonly AppDbContext _appDbContext;

        public EstadoIncidenteRepository(
            AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<EstadoIncidente>> Listar()
        {
            return await _appDbContext.EstadosIncidentes.ToListAsync();
        }
    }
}
