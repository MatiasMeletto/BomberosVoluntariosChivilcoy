using BlazorApp1.Data.Models.Personales;
using BlazorApp1.Data.Models.Salidas.Componentes;
using BlazorApp1.Data.Models.Salidas.Planillas;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class BomberosDbContext : DbContext
    {
        public DbSet<Bombero> Bomberos { get; set; }
        public DbSet<Movil> Moviles { get; set; }
        public DbSet<VehiculoPersonal> VehiculosPersonales { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Damnificado> Damnificados { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<DatosCapacitacion> DatosCapacitaciones { get; set; }
        public DbSet<EmbarcacionAfectada> EmbarcacionesAfectadas { get; set; }
        public DbSet<VehiculoAfectadoAccidente> VehiculosAfectadosAccidentes { get; set; }
       public  DbSet<VehiculoAfectadoIncendio> VehiculosAfectadoIncendios { get; set; }
        public DbSet<VehiculoDamnificado> VehiculosDamnificados { get; set; }
        public DbSet<Accidente> Accidentes { get; set; }
        public DbSet<FactorClimatico> FactoresClimaticos { get; set; }
        public DbSet<RescatePersona> RescatePersonas { get; set; }
        public DbSet<RescateAnimal> RescateAnimales { get; set; }
        public DbSet<IncendioComercio> IncendiosComercios { get; set; }
        public DbSet<IncendioEstablecimientoEducativo> IncendiosEstablecimientosEducativos { get; set; }
        public DbSet<IncendioEstablecimientoPublico> IncendiosEstablecimientosPublicos { get; set; }
        public DbSet<IncendioForestal> IncendiosForestales { get; set; }
        public DbSet<IncendioHospitalesYClinicas> IncendiosHospitalesYClinicas { get; set; }
        public DbSet<IncendioIndustria> IncendiosIndustrias { get; set; }
        public DbSet<IncendioVivienda> IncendiosViviendas { get; set; }
        public DbSet<MaterialPeligroso> MaterialesPeligrosos { get; set; }
        public DbSet<ServicioEspecialRepresentacion> ServicioEspecialesRespresentaciones { get; set; }
        public DbSet<ServicioEspecialPrevencion> ServicioEspecialPrevenciones { get; set; }


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

            // Enum
            modelBuilder
                .Entity<Persona>()
                .Property(p => p.Sexo)                
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Bombero>()
                .Property(b => b.Grado)
                .HasConversion<string>()
                .HasMaxLength(255);
        }
    }
}
