using LogicaNegocio.Interfaces.Persistence;
using LogicaNegocio.Models.EstadoIncidente;
using LogicaNegocio.Servicios;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LogicaNegocio.Tests.Servicios
{
    public class EstadoIncidenteServiceTests
    {
        [Fact]
        public async Task Listar_ReturnsMappedModels()
        {
            var mockRepo = new Mock<IEstadoIncidenteRepository>();
            mockRepo.Setup(r => r.Listar()).ReturnsAsync(new List<LogicaNegocio.Entidades.EstadoIncidente>
            {
                new LogicaNegocio.Entidades.EstadoIncidente { Id = 1, Descripcion = "Activo" },
                new LogicaNegocio.Entidades.EstadoIncidente { Id = 2, Descripcion = "Inactivo" }
            });
            var service = new EstadoIncidenteService(mockRepo.Object);

            var result = await service.Listar();

            Assert.Equal(2, result.Count());
            Assert.Contains(result, e => e.Id == 1 && e.Descripcion == "Activo");
            Assert.Contains(result, e => e.Id == 2 && e.Descripcion == "Inactivo");
        }
    }
}
