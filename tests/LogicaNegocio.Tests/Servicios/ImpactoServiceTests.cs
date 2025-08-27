using LogicaNegocio.Interfaces.Persistence;
using LogicaNegocio.Models.Impacto;
using LogicaNegocio.Servicios;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LogicaNegocio.Tests.Servicios
{
    public class ImpactoServiceTests
    {
        [Fact]
        public async Task Listar_ReturnsMappedModels()
        {
            var mockRepo = new Mock<IImpactoRepository>();
            mockRepo.Setup(r => r.Listar()).ReturnsAsync(new List<LogicaNegocio.Entidades.Impacto>
            {
                new LogicaNegocio.Entidades.Impacto { Id = 1, Descripcion = "Alto" },
                new LogicaNegocio.Entidades.Impacto { Id = 2, Descripcion = "Bajo" }
            });
            var service = new ImpactoService(mockRepo.Object);

            var result = await service.Listar();

            Assert.Equal(2, result.Count());
            Assert.Contains(result, i => i.Id == 1 && i.Descripcion == "Alto");
            Assert.Contains(result, i => i.Id == 2 && i.Descripcion == "Bajo");
        }
    }
}
