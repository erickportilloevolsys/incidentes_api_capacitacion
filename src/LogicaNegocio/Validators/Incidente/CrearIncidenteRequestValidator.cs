using LogicaNegocio.Interfaces.Validator;
using LogicaNegocio.Models.Incidente;
using LogicaNegocio.Models.Validator;

namespace LogicaNegocio.Validators.Incidente
{
    public class CrearIncidenteRequestValidator
        : IValidator<CrearIncidenteRequest>
    {
        public ValidatorResult Validar(CrearIncidenteRequest request)
        {
            var resultado = new ValidatorResult();

            if (string.IsNullOrEmpty(request.Descripcion))
            {
                resultado.EsValido = false;
                resultado.PropiedadError = nameof(request.Descripcion);
                resultado.MensajeError = "La descripción es obligatoria.";
                return resultado;
            }

            if (request.IdImpacto == 0)
            {
                resultado.EsValido = false;
                resultado.PropiedadError = nameof(request.IdImpacto);
                resultado.MensajeError = "El impacto es obligatorio.";
                return resultado;
            }

            if (request.IdPrioridad == 0)
            {
                resultado.EsValido = false;
                resultado.PropiedadError = nameof(request.IdPrioridad);
                resultado.MensajeError = "La prioridad es obligatoria.";
                return resultado;
            }

            if (request.IdTipoIncidente == 0)
            {
                resultado.EsValido = false;
                resultado.PropiedadError = nameof(request.IdTipoIncidente);
                resultado.MensajeError = "El tipo de incidente es obligatorio.";
                return resultado;
            }

            if (string.IsNullOrEmpty(request.Telefono)
                || !System.Text.RegularExpressions.Regex.IsMatch(request.Telefono, @"^9\d{8}$"))
            {
                resultado.EsValido = false;
                resultado.PropiedadError = nameof(request.Telefono);
                resultado.MensajeError = "El teléfono es obligatorio y debe empezar por 9 y tener 9 dígitos.";
                return resultado;
            }

            resultado.EsValido = true;

            return resultado;
        }
    }
}
