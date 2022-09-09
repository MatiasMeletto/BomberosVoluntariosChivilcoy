using BlazorApp1.Data.Models.Personales;
using BlazorApp1.Data.Models.Salidas.Componentes;
using BlazorApp1.Data.Models.Salidas.Planillas;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class BomberosDbContext : DbContext
    {
        DbSet<Bombero> Bomberos { get; set; }
        DbSet<Movil> Moviles { get; set; }
        DbSet<VehiculoPersonal> VehiculosPersonales { get; set; }
        DbSet<Contacto> Contactos { get; set; }
        DbSet<Damnificado> Damnificados { get; set; }
        DbSet<Seguro> Seguros { get; set; }
        DbSet<DatosCapacitacion> DatosCapacitaciones { get; set; }
        DbSet<EmbarcacionAfectada> EmbarcacionesAfectadas { get; set; }
        DbSet<VehiculoAfectadoAccidente> VehiculosAfectadosAccidentes { get; set; }
        DbSet<VehiculoAfectadoIncendio> VehiculosAfectadoIncendios { get; set; }
        DbSet<VehiculoDamnificado> VehiculosDamnificados { get; set; }
        DbSet<Accidente> Accidentes { get; set; }
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
        DbSet<MaterialPeligroso> MaterialesPeligrosos { get; set; }
        DbSet<ServicioEspecialRepresentacion> ServicioEspecialesRespresentaciones { get; set; }
        DbSet<ServicioEspecialPrevencion> ServicioEspecialPrevenciones { get; set; }


        public BomberosDbContext(DbContextOptions<BomberosDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .HasDiscriminator<int>("TipoPersona")
                .HasValue<Bombero>(1)
                .HasValue<Persona>(2);
            modelBuilder.Entity<Persona>()
                .ToTable("Personas");

            modelBuilder.Entity<Salida>()
                .HasDiscriminator<int>("TipoSalida")
                .HasValue<Accidente>(1)
                .HasValue<FactorClimatico>(2)
                .HasValue<MaterialPeligroso>(3)
                .HasValue<ServicioEspecialRepresentacion>(4)
                .HasValue<RescateAnimal>(5)
                .HasValue<RescatePersona>(6)
                .HasValue<IncendioComercio>(7)
                .HasValue<IncendioEstablecimientoEducativo>(8)
                .HasValue<IncendioEstablecimientoPublico>(9)
                .HasValue<IncendioForestal>(10)
                .HasValue<IncendioHospitalesYClinicas>(11)
                .HasValue<IncendioIndustria>(12)
                .HasValue<IncendioVivienda>(13)
                .HasValue<ServicioEspecialPrevencion>(14)
                .HasValue<Incendio>(15)
                .HasValue<ServicioEspecial>(16);
            modelBuilder.Entity<Salida>()
                .ToTable("Salidas");

            modelBuilder.Entity<Vehiculo>()
                .HasDiscriminator<int>("TipoVehiculo")
                .HasValue<VehiculoAfectadoAccidente>(1)
                .HasValue<VehiculoAfectadoIncendio>(2)
                .HasValue<VehiculoDamnificado>(3)
                .HasValue<VehiculoPersonal>(4)
                .HasValue<Movil>(5)
                .HasValue<VehiculoAfectado>(6);


            modelBuilder.Entity<Bombero>()
                .HasOne(b => b.Movil)
                .WithOne(m => m.Bombero)
                .HasForeignKey<MovilBombero>(mb => mb.PersonaId);

            modelBuilder.Entity<ServicioEspecial>()
                .HasOne(se => se.DatosCapacitacion)
                .WithOne(dc => dc.ServicioEspecial)
                .HasForeignKey<DatosCapacitacion>(dc => dc.DatosCapacitacionId);

            modelBuilder.Entity<Salida>()
                .HasOne(sa => sa.Seguro)
                .WithOne(se => se.Salida)
                .HasForeignKey<Seguro>(se => se.SeguroId);
        }
    }
}
