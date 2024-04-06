using CorePackeges.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace CorePackeges.Presentation;

public class ConfigurationReader
{
    private readonly string _applicationName;
    private readonly string _connectionString;
    private readonly int _refreshTimerIntervalInMs;

    public ConfigurationReader(string applicationName, string connectionString, int refreshTimerIntervalInMs)
    {
        _applicationName = applicationName;
        _connectionString = connectionString;
        _refreshTimerIntervalInMs = refreshTimerIntervalInMs;
    }

    public async Task<T> GetValueAsync<T>(string name)
    {
   
    }
}
