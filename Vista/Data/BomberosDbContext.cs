using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Componentes;
using Vista.Data.Models.Salidas.Planillas;
using Microsoft.EntityFrameworkCore;

namespace Vista.Data
{
    public class BomberosDbContext : DbContext
    {
        public DbSet<Bombero> Bomberos { get; set; }
        public DbSet<Movil> Moviles { get; set; }
        public DbSet<VehiculoPersonal> VehiculosPersonales { get; set; }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Damnificado> Damnificados { get; set; }
        public DbSet<ImagenBombero> ImagenesBomberos { get; set; }
        public DbSet<ImagenMovil> ImagenesMoviles { get; set; }
        public DbSet<SeguroSalida> SegurosSalidas { get; set; }
        public DbSet<SeguroVehiculo> SeguroVehiculos { get; set; }
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
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Brigada> Brigadas { get; set; }


        public BomberosDbContext(DbContextOptions<BomberosDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movil>()
                .HasIndex(m => m.NumeroMovil)
                .IsUnique();

            modelBuilder.Entity<Bombero>()
                .HasIndex(b => b.NumeroLegajo)
                .IsUnique();

            modelBuilder.Entity<Persona>()
                .HasDiscriminator<int>("TipoPersona")
                .HasValue<Bombero>(1)
                .HasValue<Persona>(2);
            modelBuilder.Entity<Persona>()
                .ToTable("Personas");

            modelBuilder.Entity<Seguro>()
                .HasDiscriminator<int>("TipoSeguro")
                .HasValue<SeguroSalida>(1)
                .HasValue<SeguroVehiculo>(2);
            modelBuilder.Entity<Seguro>()
                .ToTable("Seguros");

            modelBuilder.Entity<Imagen>()
                .HasDiscriminator<int>("TipoImagenDiscriminador")
                .HasValue<ImagenBombero>(1)
                .HasValue<ImagenMovil>(2);
            modelBuilder.Entity<Imagen>()
                .ToTable("Imagenes");

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
            
            modelBuilder
                .Entity<Bombero>()
                .Property(b => b.Dotacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Bombero>()
                .Property(b => b.Estado)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<ServicioEspecialRepresentacion>()
                .Property(s => s.TipoRepresentacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<ServicioEspecialPrevencion>()
                .Property(s => s.TipoPrevencion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<ServicioEspecial>()
                .Property(s => s.Tipo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<ServicioEspecial>()
                .Property(s => s.TipoOrganizacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<RescateAnimal>()
                .Property(r => r.TipoRescateAnimal)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Salida>()
                .Property(s => s.TipoZona)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<RescatePersona>()
                .Property(r => r.TipoRescatePersona)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioVivienda>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioIndustria>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioHospitalesYClinicas>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioForestal>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioEstablecimientoPublico>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioEstablecimientoEducativo>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioComercio>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<IncendioVivienda>()
                .Property(i => i.TipoLugar)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.TipoLugarSiniestroEmbarcacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.TipoEvacuacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.TipoSuperficieAfectada)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.SuperficieAfectadaCausa)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.Tipo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.TipoAbertura)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Incendio>()
                .Property(i => i.TipoTecho)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<FactorClimatico>()
                .Property(f => f.Tipo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<FactorClimatico>()
                .Property(f => f.Evacuacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<FactorClimatico>()
                .Property(f => f.Superficie)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Accidente>()
                .Property(a => a.Tipo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<DatosCapacitacion>()
                .Property(d => d.NivelCapacitacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<DatosCapacitacion>()
                .Property(d => d.TipoCapacitacion)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<MovilBombero>()
                .Property(m => m.Rol)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<BomberoSalida>()
                .Property(b => b.Grado)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Damnificado>()
                .Property(d => d.Sexo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Damnificado>()
                .Property(d => d.Estado)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Movil>()
                .Property(m => m.Estado)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<MaterialPeligroso>()
                .Property(m => m.Tipo)
                .HasConversion<string>()
                .HasMaxLength(255);

            modelBuilder
                .Entity<Accidente>()
                .Property(a => a.CondicionesClimaticas)
                .HasConversion<string>()
                .HasMaxLength(255);
        }
    }
}
