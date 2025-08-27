using LogicaNegocio.Entidades;
using LogicaNegocio.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;

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
            return await _appDbContext.Incidentes
                .Include(i => i.TipoIncidente)
                .Include(i => i.Impacto)
                .Include(i => i.Prioridad)
                .Include(i => i.EstadoIncidente)
                .FirstOrDefaultAsync(i => i.Id == id);
        }
    }
}
