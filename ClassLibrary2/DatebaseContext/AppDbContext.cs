using COMMON.Models;
using COMMON.Models.Entity;
using Microsoft.EntityFrameworkCore;


namespace DAL.DatabaseContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        // public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; } = default!;
        public DbSet<Project> Projects { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-1IGMUL6;Initial Catalog=Project;Integrated security=true;TrustServerCertificate=true");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
