using CorePackages.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CorePackeges.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public DbSet<Configuration> Configurations { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Configuration>().HasData(
            new Configuration
            {
                Id = Guid.NewGuid(),
                Name = "SiteName",
                Type = "string",
                Value = "soty.io",
                IsActive = true,
                ApplicationName = "SERVICE-A"
            },
            new Configuration
            {
                Id = Guid.NewGuid(),
                Name = "IsBasketEnabled",
                Type = "bool",
                Value = "1",
                IsActive = true,
                ApplicationName = "SERVICE-B"
            },
            new Configuration
            {
                Id = Guid.NewGuid(),
                Name = "MaxItemCount",
                Type = "Int",
                Value = "50",
                IsActive = false,
                ApplicationName = "SERVICE-A"
            }
        );

        base.OnModelCreating(modelBuilder);
    }

}
