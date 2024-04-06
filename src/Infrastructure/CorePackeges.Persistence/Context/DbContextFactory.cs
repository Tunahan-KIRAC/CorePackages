using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CorePackeges.Persistence.Context;

public class DbContextFactory : IDbContextFactory
{
    private readonly IConfiguration _configuration;

    public DbContextFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public ApplicationDbContext Create(string connectionStringName)
    {
        var connectionString = _configuration.GetConnectionString(connectionStringName);
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}

