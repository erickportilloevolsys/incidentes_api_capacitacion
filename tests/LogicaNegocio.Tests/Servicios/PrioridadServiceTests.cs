using LogicaNegocio.Interfaces.Persistence;
using LogicaNegocio.Models.Prioridad;
using LogicaNegocio.Servicios;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LogicaNegocio.Tests.Servicios
{
    public class PrioridadServiceTests
    {
        [Fact]
        public async Task Listar_ReturnsMappedModels()
        {
            var mockRepo = new Mock<IPrioridadRepository>();
            mockRepo.Setup(r => r.Listar()).ReturnsAsync(new List<LogicaNegocio.Entidades.Prioridad>
            {
                new LogicaNegocio.Entidades.Prioridad { Id = 1, Descripcion = "Alta" },
                new LogicaNegocio.Entidades.Prioridad { Id = 2, Descripcion = "Baja" }
            });
            var service = new PrioridadService(mockRepo.Object);

            var result = await service.Listar();

            Assert.Equal(2, result.Count());
            Assert.Contains(result, p => p.Id == 1 && p.Descripcion == "Alta");
            Assert.Contains(result, p => p.Id == 2 && p.Descripcion == "Baja");
        }
    }
}
