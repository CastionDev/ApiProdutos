using CrudFronteiraTec.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudFronteiraTec.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
