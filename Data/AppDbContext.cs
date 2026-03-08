using Badania.Models;
using Microsoft.EntityFrameworkCore;

namespace Badania.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Registration> Registrations { get; set; }
    }
}
