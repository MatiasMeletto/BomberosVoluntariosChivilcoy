using BlazorApp1.Data.Models.Personales;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class BomberosDbContext : DbContext
    {
        public DbSet<Persona> Persona { get; set; }

        public BomberosDbContext(DbContextOptions<BomberosDbContext> options)
            : base(options)
        {
        }
    }
}
