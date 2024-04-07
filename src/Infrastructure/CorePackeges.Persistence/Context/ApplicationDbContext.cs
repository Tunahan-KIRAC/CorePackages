using CorePackages.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CorePackeges.Persistence.Context;

public class ApplicationDbContext : DbContext
{

    public DbSet<Configuration> Configurations { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions ):base(dbContextOptions)
    {
        
    }



}
