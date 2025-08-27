using LogicaNegocio.Entidades;
using LogicaNegocio.Interfaces.Persistence;

namespace Infraestructura.Persistence
{
    public class IncidenteRepository : IIncidenteRepository
    {
        private readonly AppDbContext _appDbContext;

        public IncidenteRepository(
            AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<int> Guardar(Incidente incidente)
        {
            await _appDbContext.Incidentes.AddAsync(incidente);
            await _appDbContext.SaveChangesAsync();
            return incidente.Id;
        }

        public async Task<Incidente> ObtenerPorId(int id)
        {
            return await _appDbContext.Incidentes.FindAsync(id);
        }
    }
}
