using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace HisPlus.Infrastructure.Configuration
{
    public class HisPlusConfigurator
    {
        private HisPlusConfigurator()
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

        public static HisPlusConfigurationSection HisPlusConfiguration
        {
            get { return HisPlusConfigurationManager.HisPlusConfiguration; } 
        }

        //public static IUnityContainer WithServiceMode(string host, int port)
        //{
        //    HisPlusConfiguration.ServiceCallMode = ServiceCallMode.MiddleWare;
        //    HisPlusConfiguration.Middle.Host = host;
        //    HisPlusConfiguration.Middle.Port = port;

        //    return Container;
        //}
    }    

    //public class ServiceConfiguration
    //{
    //    public ServiceCallMode ServiceMode { get; internal set; }

    //    public string Host { get; internal set; }

    //    public int Port { get; internal set; }
    //}
}
