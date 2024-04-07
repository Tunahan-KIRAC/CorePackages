using CorePackages.Application.Interfaces.Repository;
namespace CorePackeges.Presentation;

public class ConfigurationReader
{
    private readonly string _applicationName;
    private readonly string _connectionString;
    private readonly int _refreshTimerIntervalInMs;

    private readonly IConfigurationRepository _configurationRepository;

    public ConfigurationReader(string applicationName, string connectionString, int refreshTimerIntervalInMs, IConfigurationRepository configurationRepository)
    {
        _applicationName = applicationName;
        _connectionString = connectionString;
        _refreshTimerIntervalInMs = refreshTimerIntervalInMs;
        _configurationRepository = configurationRepository;
    }

    public async Task<string> GetValueAsync(string name)
    {
       return await _configurationRepository.GetByNameAsync(name);
    }
}
