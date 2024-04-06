using CorePackages.Application.Interfaces.DbContextFactory;
using Microsoft.EntityFrameworkCore;

namespace CorePackeges.Persistence.Context;

public class DbContextFactory : IDbContextFactory
{
    public ApplicationDbContext Create(string connectionString)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
