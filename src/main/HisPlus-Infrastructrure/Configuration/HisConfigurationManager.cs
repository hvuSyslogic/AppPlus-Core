using Castle.Core.Logging;
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

        private static ILogger Logger
        {
            get;
            set;
        }

        static HisConfigurationManager()
        {
            Logger = DependencyContext.Container.Resolve<ILogger>();

            if (Configuration == null)
            {
                lock (_lock)
                {
                    if (Configuration == null)
                    {
                        AutoConfig.WhenMapping<IHisPlusConfiguration>(mapper =>
                        {
                            mapper.Map(x => x.AgentProvider).Optional();
                            mapper.Map(x => x.LocalProvider).Optional();
                            mapper.Map(x => x.ClientCacheProvider).Optional();
                        });

                        try
                        {
                            _configuration = AutoConfig.Map<IHisPlusConfiguration>();
                            Logger.Info("HisPlus configuration was successfully loaded from app config.");

                            _configuration.AssertConfigurationIsValid();

                            LoadIsCompleted = true;
                        }
                        catch (Exception ex)
                        {
                            LoadIsCompleted = false;
                            Logger.Error("HisPlus configuration error occured: ", ex);
                            throw;
                        }

                        DependencyContext.InstallComponents();
                    }                    
                }
            }                       
        }

        public static bool LoadIsCompleted
        {
            get;
            private set;
        }

        public static IHisPlusConfiguration Configuration
        {
            get { return _configuration; }
            internal set { value = _configuration; }
        }        
    }
}
