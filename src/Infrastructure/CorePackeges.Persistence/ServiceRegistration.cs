using CorePackages.Application.Interfaces.Repository;
using CorePackeges.Persistence.Context;
using CorePackeges.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CorePackeges.Persistence;

public static class ServiceRegistration
{
    public static IServiceCollection AddPersistenceSerives(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));


        serviceCollection.AddTransient<IConfigurationRepository, ConfigurationRepository>();

        return serviceCollection;
    }
}
