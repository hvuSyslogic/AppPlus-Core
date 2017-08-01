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
using HisPlus.Infrastructure.Config;
using HisPlus.Infrastructure.CodeContracts;
using HisPlus.Infrastructure.Extensions;

namespace HisPlus.Infrastructure.DependencyInjection
{
    public class IoCManager
    {
        private const string Log4netConfigPath = "config\\log4net.config";
        private static object _lock = new object();

        #region static constructor
        
        // Load configuration from app config automatically
        static IoCManager()
        {
            SetupLogger();
            BuildContainer(HisConfigurationManager.Initialize());
        }

        #endregion

        #region private constructor

        private IoCManager()
        {
        }

        #endregion

        #region static properties

        public static IWindsorContainer Container
        {
            get { return Nested._instance; }
        }

        #endregion

        #region build container for castle windsor

        private static void BuildContainer(IHisPlusConfiguration config)
        {            
            SetupCacheProvider(config.ClientCacheProvider);
            SetupInstallers(config);
        }

        #endregion

        #region Setup logger component to windsor container

        private static void SetupLogger()
        {
            Container.AddFacility<LoggingFacility>(f => f.LogUsing(LoggerImplementation.Log4net).WithConfig(Log4netConfigPath));
        }

        #endregion

        #region Setup cache provider component to windsor container

        private static void SetupCacheProvider(ICacheProvider cacheConfig)
        {
            var keyFormat = cacheConfig.CustomizedKey.KeyFormat;

            Container.Register(Component.For<IRedisContext>().ImplementedBy<RedisContext>()
                .DependsOn(Depends.OnValue("connectionString", cacheConfig.ConnectionString.Value))
                .LifestyleSingleton());
        }

        #endregion

        #region Setup installers

        private static void SetupInstallers(IHisPlusConfiguration config)
        {
            lock (_lock)
            {
                Container.Register(Component.For<IHisPlusConfiguration>().Instance(config).LifestyleSingleton());

                if (config.Provider == ProviderType.Local)
                {
                    config.LocalProvider.Installers.ToList().ForEach(installer =>
                    {
                        Container.Install(FromAssembly.Named(installer.Assembly));
                    });
                }
            }
        }

        #endregion

        private class Nested
        {
            static Nested() { }

            internal readonly static IWindsorContainer _instance = new WindsorContainer();
        }
    }    
}
