using Microsoft.EntityFrameworkCore;
using TiendaOnline.Web.Models;

namespace TiendaOnline.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Department>().HasIndex("Name", "CountryId").IsUnique();
            modelBuilder.Entity<City>().HasIndex("Name", "DepartmentId").IsUnique();
        }
    }
}
