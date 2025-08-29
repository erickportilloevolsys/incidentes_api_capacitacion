using LogicaNegocio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.Persistence
{
    public interface IPrioridadRepository
    {
        Task<IEnumerable<Prioridad>> Listar();
    }
}
