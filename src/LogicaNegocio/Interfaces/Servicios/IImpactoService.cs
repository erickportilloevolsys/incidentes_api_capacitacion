using LogicaNegocio.Models.Impacto;

namespace LogicaNegocio.Interfaces.Servicios
{
    public interface IImpactoService
    {
        Task<IEnumerable<ImpactoModel>> Listar();
    }
}
