using BlazorApp1.Data.Models.Personales;
using BlazorApp1.Data.Models.Salidas.Componentes;
using BlazorApp1.Data.Models.Salidas.Planillas;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class BomberosDbContext : DbContext
    {
        DbSet<Persona> Personas { get; set; }
        DbSet<Bombero> Bomberos { get; set; }
        DbSet<Movil> Moviles { get; set; }
        DbSet<MovilBombero> MovilesBomberos { get; set; }
        DbSet<VehiculoPersonal> VehiculosPersonales { get; set; }
        DbSet<Contacto> Contactos { get; set; }
        DbSet<Salida> Salidas { get; set; }
        DbSet<Damnificado> Damnificados { get; set; }
        DbSet<Seguro> Seguros { get; set; }
        DbSet<DatosCapacitacion> DatosCapacitaciones { get; set; }
        DbSet<EmbarcacionAfectada> EmbarcacionesAfectadas { get; set; }
        DbSet<VehiculoAfectado> VehiculosAfectados { get; set; }
        DbSet<VehiculoAfectadoAccidente> VehiculosAfectadosAccidentes { get; set; }
        DbSet<VehiculoAfectadoIncendio> VehiculosAfectadoIncendios { get; set; }
        DbSet<VehiculoDamnificado> VehiculosDamnificados { get; set; }
        DbSet<Accidente> Accidentes { get; set; }
        DbSet<Incendio> Incendios { get; set; }
        DbSet<Rescate> Rescates { get; set; }
        DbSet<FactorClimatico> FactoresClimaticos { get; set; }
        DbSet<RescatePersona> RescatePersonas { get; set; }
        DbSet<RescateAnimal> RescateAnimales { get; set; }
        DbSet<IncendioComercio> IncendiosComercios { get; set; }
        DbSet<IncendioEstablecimientoEducativo> IncendiosEstablecimientosEducativos { get; set; }
        DbSet<IncendioEstablecimientoPublico> IncendiosEstablecimientosPublicos { get; set; }
        DbSet<IncendioForestal> IncendiosForestales { get; set; }
        DbSet<IncendioHospitalesYClinicas> IncendiosHospitalesYClinicas { get; set; }
        DbSet<IncendioIndustria> IncendiosIndustrias {get; set; }
        DbSet<IncendioVivienda> IncendiosViviendas { get; set; }
        DbSet<MaterialesPeligrosos> MaterialesPeligrosos { get; set; }
        DbSet<ServicioEspecial> ServicioEspeciales { get; set; }


        public BomberosDbContext(DbContextOptions<BomberosDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasDiscriminator<int>("Tipo")
                .HasValue<Bombero>(1);
            modelBuilder.Entity<Persona>()
                .ToTable("Personas");
        }
    }
}
