namespace LogicaNegocio.Models.Incidente
{
    public class CrearIncidenteResult
    {
        public int IdIncidente { get; set; }
        public string FechaRegistro { get; set; }
        public string HoraRegistro { get; set; }
        public bool EsValido { get; set; }
        public string PropiedadError { get; set; }
        public string MensajeError { get; set; }
    }
}
