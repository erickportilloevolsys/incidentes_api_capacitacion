using LogicaNegocio.Models.Prioridad;

namespace LogicaNegocio.Interfaces.Servicios
{
    public interface IPrioridadService
    {
        Task<IEnumerable<PrioridadModel>> Listar();
    }
}
