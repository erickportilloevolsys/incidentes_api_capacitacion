using LogicaNegocio.Models.TipoIncidente;

namespace LogicaNegocio.Interfaces.Servicios
{
    public interface ITipoIncidenteService
    {
        Task<IEnumerable<TipoIncidenteModel>> Listar();
    }
}
