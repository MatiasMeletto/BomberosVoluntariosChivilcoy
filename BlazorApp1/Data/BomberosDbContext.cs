using BlazorApp1.Data.Models.Personales;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class BomberosDbContext : DbContext
    {
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
