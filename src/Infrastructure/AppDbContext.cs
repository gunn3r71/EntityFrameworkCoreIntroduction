using Infrastructure.EntitiesTypesConfigurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infrastructure
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=localhost;Database=entityTestes;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}