
namespace CorePackages.Application.Interfaces.DbContextFactory;

public interface IDbContextFactory
{
    ApplicationDbContext Create(string connectionString);
}
