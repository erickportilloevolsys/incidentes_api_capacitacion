using LogicaNegocio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.Persistence
{
    public interface IEstadoIncidenteRepository
    {
        Task<IEnumerable<EstadoIncidente>> Listar();
    }
}
