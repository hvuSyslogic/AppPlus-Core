using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace AppPlus.Infrastructure.Configuration
{
    public class AppConfigurator
    {
        static AppConfigurator()
        {
            AppServiceConfig = new ServiceConfiguration();
        }

        private AppConfigurator()
        {            
        }

        public static IUnityContainer Container
        {
            get { return Nested._instance; }
        }

        private class Nested
        {
            static Nested() { }

            internal readonly static IUnityContainer _instance = new UnityContainer();
        }

        public static ServiceConfiguration AppServiceConfig { get; private set; }

        public static IUnityContainer WithServiceMode(string host, int port)
        {
            AppServiceConfig.ServiceMode = ServiceMode.Remote;
            AppServiceConfig.Host = host;
            AppServiceConfig.Port = port;

            return Container;
        }
    }

    public enum ServiceMode
    {
        Local = 0,
        Remote = 1,        
    }

    public class ServiceConfiguration
    {
        public ServiceMode ServiceMode { get; internal set; }
        public string Host { get; internal set; }
        public int Port { get; internal set; }
    }
}
