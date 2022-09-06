using BlazorApp1.Data.Models.Personales;
using BlazorApp1.Data.Models.Salidas.Componentes;
using BlazorApp1.Data.Models.Salidas.Planillas;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class BomberosDbContext : DbContext
    {
        DbSet<Contacto> Contactos { get; set; }
        DbSet<Damnificado> Damnificados { get; set; }
        DbSet<Seguro> Seguros { get; set; }

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
