using Nerdle.AutoConfig;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Infrastructure.Configuration
{
    public class ConfigurationManager
    {        
        private static IHisPlusConfiguration _configuration;

        static ConfigurationManager()
        {
            AutoConfig.WhenMapping<IHisPlusConfiguration>(mapper => 
            {
                mapper.Map(x => x.Credentials).Optional();
                mapper.Map(x => x.ServiceAgent).Optional();
                mapper.Map(x => x.Assemblies).Optional();
            });            

            _configuration = AutoConfig.Map<IHisPlusConfiguration>();
            
            AssertConfigurationIsValid(_configuration);
        }

        private static void AssertConfigurationIsValid(IHisPlusConfiguration configuration)
        {            
            if (configuration == null)
            {
                throw new ConfigurationErrorsException("Missing configuration for 'hisPlusConfiguration' section in configuration file.");
            }

            if (configuration.IsDistributed)
            {
                if (configuration.ServiceAgent == null)
                {
                    throw new ConfigurationErrorsException("Missing configuration for 'serviceAgent' node in hisPlusConfiguration section.");
                }

                if (configuration.Credentials == null)
                {
                    throw new ConfigurationErrorsException("Missing configuration for 'credentials' node in hisPlusConfiguration section.");
                }
            }
            else
            {
                if (configuration.Assemblies == null)
                {
                    throw new ConfigurationErrorsException("Missing configuration for 'assemblies' node in hisPlusConfiguration section.");
                }

                if (configuration.Assemblies.Count() == 0)
                {
                    throw new ConfigurationErrorsException("At least one item was included in 'assemblies' node to specify the service and its type.");
                }

                var groups = configuration.Assemblies.GroupBy(x => x.Service).Select(g => new { key = g.Key, count = g.Count() });

                var duplicatedGroup = groups.Where(x => x.count > 1);
                if (duplicatedGroup.Any())
                {
                    throw new ConfigurationErrorsException(string.Format("Duplicated assembly '{0}' was configured in 'assemblies' node.", duplicatedGroup.First()));
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
