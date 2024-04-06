namespace CorePackeges.Persistence.Context;

public interface IDbContextFactory
{
    ApplicationDbContext Create(string connectionStringName);
}
