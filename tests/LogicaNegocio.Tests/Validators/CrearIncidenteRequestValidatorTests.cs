using LogicaNegocio.Models.Incidente;
using LogicaNegocio.Validators.Incidente;
using Xunit;

namespace LogicaNegocio.Tests.Validators
{
    public class CrearIncidenteRequestValidatorTests
    {
        [Fact]
        public void Validar_ReturnsInvalid_WhenDescripcionIsEmpty()
        {
            var validator = new CrearIncidenteRequestValidator();
            var request = new CrearIncidenteRequest { Descripcion = "", IdImpacto = 1, IdPrioridad = 1, Telefono = "912345678" };
            var result = validator.Validar(request);
            Assert.False(result.EsValido);
            Assert.Equal("Descripcion", result.PropiedadError);
        }

        [Fact]
        public void Validar_ReturnsInvalid_WhenIdImpactoIsZero()
        {
            var validator = new CrearIncidenteRequestValidator();
            var request = new CrearIncidenteRequest { Descripcion = "desc", IdImpacto = 0, IdPrioridad = 1, IdTipoIncidente= 1, Telefono = "912345678" };
            var result = validator.Validar(request);
            Assert.False(result.EsValido);
            Assert.Equal("IdImpacto", result.PropiedadError);
        }

        [Fact]
        public void Validar_ReturnsInvalid_WhenIdPrioridadIsZero()
        {
            var validator = new CrearIncidenteRequestValidator();
            var request = new CrearIncidenteRequest { Descripcion = "desc", IdImpacto = 1, IdPrioridad = 0, IdTipoIncidente = 1, Telefono = "912345678" };
            var result = validator.Validar(request);
            Assert.False(result.EsValido);
            Assert.Equal("IdPrioridad", result.PropiedadError);
        }

        [Fact]
        public void Validar_ReturnsInvalid_WhenIdTipoIncidenteIsZero()
        {
            var validator = new CrearIncidenteRequestValidator();
            var request = new CrearIncidenteRequest { Descripcion = "desc", IdImpacto = 1, IdPrioridad = 1, IdTipoIncidente = 0, Telefono = "912345678" };
            var result = validator.Validar(request);
            Assert.False(result.EsValido);
            Assert.Equal("IdTipoIncidente", result.PropiedadError);
        }

        [Fact]
        public void Validar_ReturnsInvalid_WhenTelefonoIsInvalid()
        {
            var validator = new CrearIncidenteRequestValidator();
            var request = new CrearIncidenteRequest { Descripcion = "desc", IdImpacto = 1, IdPrioridad = 1, IdTipoIncidente = 1, Telefono = "812345678" };
            var result = validator.Validar(request);
            Assert.False(result.EsValido);
            Assert.Equal("Telefono", result.PropiedadError);
        }

        [Fact]
        public void Validar_ReturnsValid_WhenAllFieldsAreValid()
        {
            var validator = new CrearIncidenteRequestValidator();
            var request = new CrearIncidenteRequest { Descripcion = "desc", IdImpacto = 1, IdPrioridad = 1, IdTipoIncidente = 1, Telefono = "912345678" };
            var result = validator.Validar(request);
            Assert.True(result.EsValido);
        }
    }
}
