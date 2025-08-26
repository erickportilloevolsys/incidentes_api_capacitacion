namespace LogicaNegocio.Models.Validator
{
    public class ValidatorResult
    {
        public bool EsValido { get; set; }
        public string PropiedadError { get; set; }
        public string MensajeError { get; set; }
    }
}
