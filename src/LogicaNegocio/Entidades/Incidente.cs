namespace LogicaNegocio.Entidades
{
    public class Incidente
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public int IdEstado { get; set; }
        public EstadoIncidente EstadoIncidente { get; set; }
        public int IdTipoIncidente { get; set; }
        public TipoIncidente TipoIncidente { get; set; }
        public int IdImpacto { get; set; }
        public Impacto Impacto { get; set; }
        public int IdPrioridad { get; set; }
        public Prioridad Prioridad { get; set; }
        public string NombreCompleto { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
