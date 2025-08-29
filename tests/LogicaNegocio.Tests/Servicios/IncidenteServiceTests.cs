using LogicaNegocio.Entidades;
using LogicaNegocio.Enums;
using LogicaNegocio.Interfaces.Persistence;
using LogicaNegocio.Models.Incidente;
using LogicaNegocio.Servicios;
using LogicaNegocio.Validators.Incidente;
using Moq;
using System;
using System.Threading.Tasks;
using Xunit;

namespace LogicaNegocio.Tests.Servicios
{
    public class IncidenteServiceTests
    {
        [Fact]
        public async Task Crear_ReturnsValidResult_WhenRequestIsValid()
        {
            var mockRepo = new Mock<IIncidenteRepository>();
            mockRepo.Setup(r => r.Guardar(It.IsAny<Incidente>())).ReturnsAsync(1);
            var service = new IncidenteService(mockRepo.Object);
            var request = new CrearIncidenteRequest
            {
                Descripcion = "desc",
                IdImpacto = 1,
                IdPrioridad = 1,
                IdTipoIncidente = 1,
                NombreCompleto = "Nombre",
                Telefono = "999956936",
                Email = "test@test.com"
            };

            var result = await service.Crear(request);

            Assert.True(result.EsValido);
            Assert.Equal(1, result.IdIncidente);
        }

        [Fact]
        public async Task ObtenerPorId_ReturnsModel_WhenIncidenteExists()
        {
            var mockRepo = new Mock<IIncidenteRepository>();
            mockRepo.Setup(r => r.ObtenerPorId(1)).ReturnsAsync(new Incidente
            {
                Id = 1,
                Descripcion = "desc",
                FechaRegistro = DateTime.Now,
                IdEstado = (int)EstadoIncidenteEnum.Solicitado,
                EstadoIncidente = new EstadoIncidente { Id = 1, Descripcion = ""},
                IdImpacto = 1,
                Impacto = new Impacto { Id = 1, Descripcion = ""},
                IdPrioridad = 1,
                Prioridad = new Prioridad { Id = 1, Descripcion = "" },
                IdTipoIncidente =1,
                TipoIncidente = new TipoIncidente { Id = 1, Descripcion = "" },
                NombreCompleto = "Nombre",
                Telefono = "999956936",
                Email = "test@test.com"
            });
            var service = new IncidenteService(mockRepo.Object);

            var result = await service.ObtenerPorId(1);

            Assert.Equal(1, result.Id);
            Assert.Equal("desc", result.Descripcion);
        }

        [Fact]
        public async Task ObtenerPorId_ThrowsException_WhenIncidenteNotFound()
        {
            var mockRepo = new Mock<IIncidenteRepository>();
            mockRepo.Setup(r => r.ObtenerPorId(1)).ReturnsAsync((Incidente)null);
            var service = new IncidenteService(mockRepo.Object);

            await Assert.ThrowsAsync<Exception>(() => service.ObtenerPorId(1));
        }
    }
}
