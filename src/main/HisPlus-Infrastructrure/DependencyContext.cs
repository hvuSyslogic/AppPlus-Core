using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using HisPlus.Infrastructure.Configuration;
using Castle.Windsor.Installer;
using Castle.Facilities.Logging;
using Castle.Core.Logging;

namespace HisPlus.Infrastructure
{
    public class DependencyContext
    {
        private const string Log4netConfigPath = "config\\log4net.config";
        private static object _lock = new object();

        static DependencyContext()
        {
            InstallLogger();
            InstallComponents();
        }

        private DependencyContext()
        {
        }

        private static void InstallLogger()
        {
            Container.AddFacility<LoggingFacility>(f => f.LogUsing(LoggerImplementation.Log4net).WithConfig(Log4netConfigPath));
        }

        public static void InstallComponents()
        {
            var logger = Container.Resolve<ILogger>();
            if (HisConfigurationManager.LoadIsCompleted)
            {
                lock (_lock)
                {
                    if (!ConfigurationIsInstalled)
                    {
                        if (HisConfigurationManager.Configuration.Provider == ProviderType.Local)
                        {
                            HisConfigurationManager.Configuration.LocalProvider.Installers.ToList().ForEach(installer =>
                            {
                                Container.Install(FromAssembly.Named(installer.Assembly));
                                //logger.InfoFormat("Components was successfully installed from assembly '{0}.dll'.", installer.Assembly);
                                
                                ConfigurationIsInstalled = true;
                            });
                        }
                    }
                }
            }
        }

        private static bool ConfigurationIsInstalled
        {
            get;
            set;
        }

        public static IWindsorContainer Container
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal readonly static IWindsorContainer _instance = new WindsorContainer();
        }
    }    
}
