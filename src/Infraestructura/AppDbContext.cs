using LogicaNegocio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura
{
    public class AppDbContext : DbContext
    {
        public DbSet<Incidente> Incidentes { get; set; }
        public DbSet<TipoIncidente> TiposIncidentes { get; set; }
        public DbSet<Impacto> ImpactosIncidentes { get; set; }
        public DbSet<EstadoIncidente> EstadosIncidentes { get; set; }
        public DbSet<Prioridad> PrioridadesIncidentes { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuraciones adicionales si es necesario

            //Agrega las configuraciones para las propiedades de navegación TipoIncidente, Impacto, Prioridad y EstadoIncidente en la entidad Incidente
            modelBuilder.Entity<Incidente>()
                .HasOne(i => i.TipoIncidente)
                .WithMany()
                .HasForeignKey(i => i.IdTipoIncidente)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Incidente>()
                .HasOne(i => i.Impacto)
                .WithMany()
                .HasForeignKey(i => i.IdImpacto)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Incidente>()
                .HasOne(i => i.Prioridad)
                .WithMany()
                .HasForeignKey(i => i.IdPrioridad)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Incidente>()
                .HasOne(i => i.EstadoIncidente)
                .WithMany()
                .HasForeignKey(i => i.IdEstado)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<TipoIncidente>().HasData(
                new TipoIncidente { Id = 1, Descripcion = "ERROR DE SISTEMA" },
                new TipoIncidente { Id = 2, Descripcion = "ERROR DE USUARIO" },
                new TipoIncidente { Id = 3, Descripcion = "CONSULTA SOBRE FUNCIONALIDAD DEL SISTEMA" },
                new TipoIncidente { Id = 4, Descripcion = "SOLICITUD DE INFORMACIÓN" },
                new TipoIncidente { Id = 5, Descripcion = "NUEVO REQUERIMIENTO" }
            );

            modelBuilder.Entity<Impacto>().HasData(
                new Impacto { Id = 1, Descripcion = "UN USUARIO" },
                new Impacto { Id = 2, Descripcion = "VARIOS USUARIOS" },
                new Impacto { Id = 3, Descripcion = "TODA LA INSTITUCIÓN" }
            );

            modelBuilder.Entity<Prioridad>().HasData(
                new Prioridad { Id = 1, Descripcion = "NO PUEDE ESPERAR" },
                new Prioridad { Id = 2, Descripcion = "PUEDE ESPERAR UNOS MINUTOS" },
                new Prioridad { Id = 3, Descripcion = "PUEDE ESPERAR HORAS" },
                new Prioridad { Id = 4, Descripcion = "PUEDE ESPERAR DIAS" }
            );

            modelBuilder.Entity<EstadoIncidente>().HasData(
                new EstadoIncidente { Id = 1, Descripcion = "SOLICITADO" },
                new EstadoIncidente { Id = 2, Descripcion = "EN PROCESO" },
                new EstadoIncidente { Id = 3, Descripcion = "RESUELTO" },
                new EstadoIncidente { Id = 4, Descripcion = "CERRADO" },
                new EstadoIncidente { Id = 5, Descripcion = "CANCELADO" }
            );
        }
    }
}
