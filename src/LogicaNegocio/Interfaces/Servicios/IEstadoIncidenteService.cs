using LogicaNegocio.Entidades;
using LogicaNegocio.Models.EstadoIncidente;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces.Servicios
{
    public interface IEstadoIncidenteService
    {
        Task<IEnumerable<EstadoIncidenteModel>> Listar();
    }
}
