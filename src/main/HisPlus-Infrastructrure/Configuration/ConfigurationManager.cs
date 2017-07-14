using log4net;
using Nerdle.AutoConfig;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Configuration
{
    public class ConfigurationManager
    {        
        private static IHisPlusConfiguration _configuration;
        private static object _lock = new object();
        private const string HisPlusConfigurationSectionName = "hisPlusConfiguration";
        private const string LocalSectionName = "localSection";
        private const string AgentSectionName = "agentSection";

        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static ConfigurationManager()
        {
            lock (_lock)
            {
                AutoConfig.WhenMapping<IHisPlusConfiguration>(mapper =>
                {
                    mapper.Map(x => x.AgentSection).Optional();
                    mapper.Map(x => x.LocalSection).Optional();
                });

                try
                {
                    _configuration = AutoConfig.Map<IHisPlusConfiguration>();
                }
                catch (TypeInitializationException ex)
                {
                    Log.Error(ex);
                }
            }
            
            AssertConfigurationIsValid(_configuration);
        }

        private static void AssertConfigurationIsValid(IHisPlusConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new ConfigurationErrorsException(string.Format("Missing configuration for '{0}' section in configuration file.", HisPlusConfigurationSectionName));
            }

            if (configuration.IsDistributed)
            {
                if (configuration.AgentSection == null)
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for 'agentSection' node in '{0}' section.", AgentSectionName));
                }

                if (configuration.AgentSection.ServiceAgent == null)
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for 'serviceAgent' node in '{0}' section.", AgentSectionName));
                }

                if (configuration.AgentSection.Credentials == null)
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for 'credentials' node in '{0}' section.", AgentSectionName));
                }
            }
            else
            {
                if (configuration.LocalSection == null)
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for 'localSection' node in '{0}' section.", HisPlusConfigurationSectionName));
                }

                if (string.IsNullOrWhiteSpace(configuration.LocalSection.ConnectionStringName))
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for 'connectionStringName' node in '{0}'.", LocalSectionName));
                }
                
                if (configuration.LocalSection.Installers == null)
                {
                    throw new ConfigurationErrorsException(string.Format("Missing configuration for 'installers' node in '{0}' section.", LocalSectionName));
                }

                var installGroups = configuration.LocalSection.Installers.GroupBy(x => x.Assembly)
                    .Select(g => new { key = g.Key, count = g.Count() });

                var duplicatedGroup = installGroups.Where(x => x.count > 1);
                if (duplicatedGroup.Any())
                {
                    throw new ConfigurationErrorsException(string.Format("Duplicated installer '{0}' was configured in '{1}' node.", duplicatedGroup.First().key, "installers"));
                }
            }
        }

        public static IHisPlusConfiguration Configuration
        {
            get { return _configuration; }
            internal set { value = _configuration; }
        }        
    }
}
