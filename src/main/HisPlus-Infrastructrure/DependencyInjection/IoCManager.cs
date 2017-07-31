using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Castle.Facilities.Logging;
using Castle.Core.Logging;
using Castle.MicroKernel.Registration;
using Depends = Castle.MicroKernel.Registration.Dependency;
using CachingFramework.Redis.Contracts;
using CachingFramework.Redis;
using HisPlus.Infrastructure.Cache;
using HisPlus.Infrastructure.Configuration;
using HisPlus.Infrastructure.CodeContracts;
using HisPlus.Infrastructure.Extensions;

namespace HisPlus.Infrastructure.DependencyInjection
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
            InstallCacheProvider();
            InstallComponents();
        }

        private static void InstallLogger()
        {
            Container.AddFacility<LoggingFacility>(f => f.LogUsing(LoggerImplementation.Log4net).WithConfig(Log4netConfigPath));
        }

        private static void InstallCacheProvider()
        {
            var keyFormat = HisConfigurationManager.Configuration.ClientCacheProvider.CustomizedKey.KeyFormat;
            var connectionStringName = HisConfigurationManager.Configuration.ClientCacheProvider.ConnectionString.Name;
            
            Requires.NotNull(ConfigurationManager.ConnectionStrings, "ConfigurationManager.ConnectionStrings");
            Requires.NotNull(ConfigurationManager.ConnectionStrings[connectionStringName], "connectionStringName");

            var connectionString = ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;
                        
            //Register Redis cache context
            Container.Register(Component.For<IRedisContext>().ImplementedBy<RedisContext>()
                .DependsOn(Depends.OnValue("connectionString", connectionString))
                .LifestyleSingleton());

            //Container.Register(Component.For<RedisCacheOptions>().ImplementedBy<RedisCacheOptions>()
            //    .DependsOn(Depends.OnValue("connectionString", connectionString), Depends.OnValue("databaseId", 0), Depends.OnValue("keyFormat", keyFormat))
            //    .LifestyleSingleton());
            //Container.Register(Component.For<IRedisCache>().ImplementedBy<RedisCache>().LifestyleSingleton());
            //Container.Register(Component.For<IRedisCacheDatabaseProvider>().ImplementedBy<RedisCacheDatabaseProvider>().LifestyleSingleton());                     
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

        private static bool ConfigurationIsInstalled { get; set; }

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
