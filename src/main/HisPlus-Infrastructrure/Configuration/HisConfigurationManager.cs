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
    public class HisConfigurationManager
    {        
        private static IHisPlusConfiguration _configuration;
        private static object _lock = new object();

        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static HisConfigurationManager()
        {
            lock (_lock)
            {
                AutoConfig.WhenMapping<IHisPlusConfiguration>(mapper =>
                {
                    mapper.Map(x => x.AgentProvider).Optional();
                    mapper.Map(x => x.LocalProvider).Optional();
                    mapper.Map(x => x.CacheProvider).Optional();
                });

                try
                {
                    _configuration = AutoConfig.Map<IHisPlusConfiguration>();
                }
                catch (TypeInitializationException ex)
                {
                    Log.Error(ex);
                    throw;
                }
            }

            _configuration.AssertConfigurationIsValid();
        }        

        public static IHisPlusConfiguration Configuration
        {
            get { return _configuration; }
            internal set { value = _configuration; }
        }        
    }
}
