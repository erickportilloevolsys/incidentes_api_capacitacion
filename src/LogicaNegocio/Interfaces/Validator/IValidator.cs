using LogicaNegocio.Models.Validator;

namespace LogicaNegocio.Interfaces.Validator
{
    public interface IValidator<T>
    {
        ValidatorResult Validar(T request);
    }
}
