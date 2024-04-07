using CorePackages.Domain.Entities;
using CorePackeges.Persistence.Repositories;

namespace CorePackeges.Presentation;

public class ConfigurationReader
{
    private readonly ConfigurationRepository _configurationRepository;

    public ConfigurationReader(ConfigurationRepository configurationRepository)
    {
        _configurationRepository = configurationRepository;
    }

    public async Task<List<ConfigurationViewModel>> GetAllConfigurations()
    {
        var configurations = await _configurationRepository.GetAllAsync();

        var configurationViewModels = configurations.Select(c => new ConfigurationViewModel
        {
            Name = c.Name,
            Type = c.Type,
            Value = c.Value,
            IsActive = c.IsActive,
            ApplicationName = c.ApplicationName
        }).ToList();

        return configurationViewModels;
    }



    public async Task<ConfigurationViewModel> GetConfigurationById(Guid id)
    {
        var configuration = await _configurationRepository.GetByIdAsync(id);

        if (configuration == null)
            return null;

        var configurationViewModel = new ConfigurationViewModel
        {
            Name = configuration.Name,
            Type = configuration.Type,
            Value = configuration.Value,
            IsActive = configuration.IsActive,
            ApplicationName = configuration.ApplicationName
        };

        return configurationViewModel;
    }

    public async Task<ConfigurationViewModel> GetConfigurationByName(string name)
    {
        var configuration = await _configurationRepository.GetByNameAsync(name);

        if (configuration == null)
            return null;

        var configurationViewModel = new ConfigurationViewModel
        {
            Name = configuration.Name,
            Type = configuration.Type,
            Value = configuration.Value,
            IsActive = configuration.IsActive,
            ApplicationName = configuration.ApplicationName
        };

        return configurationViewModel;
    }

    public async Task<ConfigurationViewModel> AddConfiguration(Configuration configuration)
    {
        var addedConfiguration = await _configurationRepository.AddAsync(configuration);

        var addedConfigurationViewModel = new ConfigurationViewModel
        {
            Name = addedConfiguration.Name,
            Type = addedConfiguration.Type,
            Value = addedConfiguration.Value,
            IsActive = addedConfiguration.IsActive,
            ApplicationName = addedConfiguration.ApplicationName
        };

        return addedConfigurationViewModel;
    }


    public async Task<bool> AddDefaultConfigurations()
    {
        try
        {
            var configurations = new List<Configuration>
        {
            new Configuration
            {
                Name = "SiteName",
                Type = "string",
                Value = "soty.io",
                IsActive = true,
                ApplicationName = "SERVICE-A"
            },
            new Configuration
            {
                Name = "IsBasketEnabled",
                Type = "bool",
                Value = "1",
                IsActive = true,
                ApplicationName = "SERVICE-B"
            },
            new Configuration
            {
                Name = "MaxItemCount",
                Type = "Int",
                Value = "50",
                IsActive = false,
                ApplicationName = "SERVICE-A"
            }
        };

            foreach (var configuration in configurations)
            {
                await _configurationRepository.AddAsync(configuration);
            }

            return true;
        }
        catch (Exception)
        {
            // Hata durumunda false döndürebilirsiniz
            return false;
        }
    }

}
