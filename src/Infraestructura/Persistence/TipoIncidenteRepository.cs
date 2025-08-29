using LogicaNegocio.Entidades;
using LogicaNegocio.Interfaces.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestructura.Persistence
{
    public class TipoIncidenteRepository : ITipoIncidenteRepository
    {
        private readonly AppDbContext _appDbContext;

        public TipoIncidenteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<TipoIncidente>> Listar()
        {
            return await _appDbContext.TiposIncidentes.ToListAsync();
        }
    }
}
