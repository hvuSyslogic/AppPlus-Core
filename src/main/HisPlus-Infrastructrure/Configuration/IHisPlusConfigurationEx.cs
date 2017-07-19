using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Configuration
{
    public static class IHisPlusConfigurationEx
    {
        private const string HisPlusConfigurationSectionName = "hisPlusConfiguration";
        private const string LocalProviderConfig = "localProvider";
        private const string AgentProviderConfig = "agentProvider";
        private const string HostConfig = "host";
        private const string CredentialsConfig = "credentials";
        private const string ConnectionString = "connectionString";
        private const string InstallersConfig = "installers";

        public static void AssertConfigurationIsValid(this IHisPlusConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ConfigurationErrorsException(string.Format("Missing configuration for '{0}' section in configuration file.", HisPlusConfigurationSectionName));
            }

            if (configuration.Provider == ProviderType.Agent)
            {
                if (configuration.AgentProvider == null)
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for '{0}' in '{1}' section.", AgentProviderConfig, HisPlusConfigurationSectionName));
                }

                if (configuration.AgentProvider.Host == null)
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for '{0}' in '{1}' Node.", HostConfig, AgentProviderConfig));
                }

                if (configuration.AgentProvider.Host.Credentials == null)
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for '{0}' in '{1}' Node.", CredentialsConfig, HostConfig));
                }
            }
            else
            {
                if (configuration.LocalProvider == null)
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for '{0}' in '{1}' section.", LocalProviderConfig, HisPlusConfigurationSectionName));
                }

                if (configuration.LocalProvider.ConnectionString == null)
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for '{0}' in '{1}'.", ConnectionString, LocalProviderConfig));
                }

                if (configuration.LocalProvider.Installers == null)
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for '{0}' in '{1}' section.", InstallersConfig, LocalProviderConfig));
                }

                var installGroups = configuration.LocalProvider.Installers.GroupBy(x => x.Assembly)
                    .Select(g => new { key = g.Key, count = g.Count() });

                var duplicatedGroup = installGroups.Where(x => x.count > 1);
                if (duplicatedGroup.Any())
                {
                    throw new ConfigurationErrorsException(string.Format("Duplicated installer '{0}' was configured in '{1}' node.", duplicatedGroup.First().key, InstallersConfig));
                }
            }
        }
    }
}
