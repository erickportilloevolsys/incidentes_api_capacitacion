using LogicaNegocio.Entidades;

namespace LogicaNegocio.Interfaces.Persistence
{
    public interface IIncidenteRepository
    {
        Task<int> Guardar(Incidente incidente);
        Task<Incidente> ObtenerPorId(int id);
    }
}
