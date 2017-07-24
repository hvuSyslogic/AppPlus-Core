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
using Castle.MicroKernel.Registration;
using HisPlus.Infrastructure.Cache;
using ICacheProvider = HisPlus.Infrastructure.Cache.ICacheProvider;
using Depends = Castle.MicroKernel.Registration.Dependency;

namespace HisPlus.Infrastructure.Dependency
{
    public class IoCManager
    {
        private const string Log4netConfigPath = "config\\log4net.config";
        private static object _lock = new object();

        static IoCManager()
        {
            Install();
        }

        private IoCManager()
        {
        }

        static ILogger Logger 
        {
            get { return typeof(IoCManager).GetLogger(); } 
        }

        private static void Install()
        {
            InstallLogger();
            InstallClientCache();
            InstallComponents();
        }

        private static void InstallLogger()
        {
            Container.AddFacility<LoggingFacility>(f => f.LogUsing(LoggerImplementation.Log4net).WithConfig(Log4netConfigPath));
        }

        private static void InstallClientCache()
        {
            var keyFormat = HisConfigurationManager.Configuration.ClientCacheProvider.CustomizedKey.KeyFormat;
            Container.Register(Component.For<ICacheManager>().ImplementedBy<CacheManager>().LifestyleSingleton());
            //Container.Register(Component.For<ICacheProvider>().ImplementedBy<CacheProvider>().LifestyleSingleton());
            Container.Register(Component.For<Db0CacheProvider>().ImplementedBy<Db0CacheProvider>().DependsOn(Depends.OnValue("keyFormat", keyFormat)).LifestyleSingleton());
            Container.Register(Component.For<Db1CacheProvider>().ImplementedBy<Db1CacheProvider>().DependsOn(Depends.OnValue("keyFormat", keyFormat)).LifestyleSingleton());
            Container.Register(Component.For<Db2CacheProvider>().ImplementedBy<Db2CacheProvider>().DependsOn(Depends.OnValue("keyFormat", keyFormat)).LifestyleSingleton());
        }

        public static void InstallComponents()
        {
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
