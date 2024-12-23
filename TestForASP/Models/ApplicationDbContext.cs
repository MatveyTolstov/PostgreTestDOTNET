using Microsoft.EntityFrameworkCore;

namespace TestForASP.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<roles> roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<roles>().HasKey(roles => roles.id_roles);

    }

  
}
