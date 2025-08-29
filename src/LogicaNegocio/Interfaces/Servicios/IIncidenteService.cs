using LogicaNegocio.Models.Incidente;

namespace LogicaNegocio.Interfaces.Servicios
{
    public interface IIncidenteService
    {
        Task<CrearIncidenteResult> Crear(CrearIncidenteRequest request);
        Task<IncidenteModel> ObtenerPorId(int id);
    }
}
