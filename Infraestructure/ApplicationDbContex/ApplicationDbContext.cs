using Domain.Entities;
using Infraestructure.Map;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Infraestructure.ApplicationDbContex
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<ValidationResult>();

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            modelBuilder.ApplyConfiguration(new BrandMap());
            modelBuilder.ApplyConfiguration(new OwnerMap());
            modelBuilder.ApplyConfiguration(new VehicleMap());
        }
    }
}
