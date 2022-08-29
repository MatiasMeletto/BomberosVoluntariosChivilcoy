using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data
{
    public class BomberosDbContext : DbContext
    {
        public BomberosDbContext(DbContextOptions<BomberosDbContext> options)
            : base(options)
        {
        }
    }
}
