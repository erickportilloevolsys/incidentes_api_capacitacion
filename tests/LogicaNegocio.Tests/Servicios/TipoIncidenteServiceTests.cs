using LogicaNegocio.Interfaces.Persistence;
using LogicaNegocio.Models.TipoIncidente;
using LogicaNegocio.Servicios;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LogicaNegocio.Tests.Servicios
{
    public class TipoIncidenteServiceTests
    {
        [Fact]
        public async Task Listar_ReturnsMappedModels()
        {
            var mockRepo = new Mock<ITipoIncidenteRepository>();
            mockRepo.Setup(r => r.Listar()).ReturnsAsync(new List<LogicaNegocio.Entidades.TipoIncidente>
            {
                new LogicaNegocio.Entidades.TipoIncidente { Id = 1, Descripcion = "Error" },
                new LogicaNegocio.Entidades.TipoIncidente { Id = 2, Descripcion = "Consulta" }
            });
            var service = new TipoIncidenteService(mockRepo.Object);

            var result = await service.Listar();

            Assert.Equal(2, result.Count());
            Assert.Contains(result, t => t.Id == 1 && t.Descripcion == "Error");
            Assert.Contains(result, t => t.Id == 2 && t.Descripcion == "Consulta");
        }
    }
}
