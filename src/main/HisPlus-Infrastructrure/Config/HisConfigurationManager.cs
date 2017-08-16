using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Nerdle.AutoConfig;
using HisPlus.Infrastructure.Extensions;
using HisPlus.Infrastructure.DependencyInjection;
using HisPlus.Infrastructure.CodeContracts;

namespace HisPlus.Infrastructure.Config
{
    internal class HisConfigurationManager
    {
        private static object _lock = new object();
        private static bool _hasLoaded;        
        private static ILogger _logger = typeof(HisConfigurationManager).GetLogger();

        internal static IHisPlusConfiguration Initialize()
        {
            var config = LoadConfigurationFromAppConfig();

            return SetRedisConnectionString(config);
        }

        private static IHisPlusConfiguration LoadConfigurationFromAppConfig()
        {
            if (!_hasLoaded)
            {
                lock (_lock)
                {
                    if (!_hasLoaded)
                    {
                        AutoConfig.WhenMapping<IHisPlusConfiguration>(ms =>
                        {
                            ms.Map(x => x.AgentProvider).Optional();
                            ms.Map(x => x.LocalProvider).Optional();
                            ms.Map(x => x.ClientCacheProvider).Optional();
                        });

                        AutoConfig.WhenMapping<IConnectionString>(ms =>
                        {
                            ms.Map(x => x.Value).Optional();
                        });

                        IHisPlusConfiguration _configuration = AutoConfig.Map<IHisPlusConfiguration>();                        

                        _configuration.AssertConfigurationIsValid();
                        _hasLoaded = true;

                        _logger.Info("Successfully loaded HisPlusConfiguration from app config.");

                        return _configuration;
                    }
                }
            }

            return null;
        }        

        private static IHisPlusConfiguration SetRedisConnectionString(IHisPlusConfiguration config)
        {
            var connectionStringName = config.ClientCacheProvider.ConnectionString.Name;

            Requires.NotNull(ConfigurationManager.ConnectionStrings, "ConfigurationManager.ConnectionStrings");
            var parameterName = string.Format("ConfigurationManager.ConnectionStrings[\"{0}\"]", connectionStringName);
            Requires.NotNull(ConfigurationManager.ConnectionStrings[connectionStringName], parameterName);

            var connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

            config.ClientCacheProvider.ConnectionString.Value = connectionString;

            return config;
        }
    }
}
