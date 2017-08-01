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
        private static IHisPlusConfiguration _configuration;
        private static object _lock = new object();
        private static ILogger _logger = typeof(HisConfigurationManager).GetLogger();        

        static HisConfigurationManager()
        {
            if (_configuration == null)
            {
                lock (_lock)
                {
                    if (_configuration == null)
                    {
                        AutoConfig.WhenMapping<IHisPlusConfiguration>(mapper =>
                        {
                            mapper.Map(x => x.AgentProvider).Optional();
                            mapper.Map(x => x.LocalProvider).Optional();                            
                            mapper.Map(x => x.ClientCacheProvider).Optional();
                        });

                        AutoConfig.WhenMapping<IConnectionString>(mapper => 
                        {
                            mapper.Map(x => x.Value).Optional();
                        });

                        try
                        {
                            _configuration = AutoConfig.Map<IHisPlusConfiguration>();
                            _logger.Info("Successfully loaded HisPlusConfiguration from app config.");

                            _configuration.AssertConfigurationIsValid();                            
                        }
                        catch (Exception ex)
                        {                            
                            _logger.Error("Failed to load HisPlus configuration: ", ex);
                            throw;
                        }                        
                    }                    
                }
            }                       
        }

        internal static IHisPlusConfiguration Initialize() 
        {
            Requires.NotNull(_configuration, "HisPlusConfiguration");

            SetRedisConnectionString(_configuration);

            return _configuration;
        }

        private static void SetRedisConnectionString(IHisPlusConfiguration config)
        {
            var connectionStringName = config.ClientCacheProvider.ConnectionString.Name;

            Requires.NotNull(ConfigurationManager.ConnectionStrings, "ConfigurationManager.ConnectionStrings");
            var parameterName = string.Format("ConfigurationManager.ConnectionStrings[\"{0}\"]", connectionStringName);
            Requires.NotNull(ConfigurationManager.ConnectionStrings[connectionStringName], parameterName);

            var connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

            config.ClientCacheProvider.ConnectionString.Value = connectionString;
        }    
    }
}
