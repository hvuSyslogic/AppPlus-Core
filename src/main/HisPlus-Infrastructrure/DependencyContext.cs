using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using HisPlus.Infrastructure.Configuration;
using Castle.Windsor.Installer;

namespace HisPlus.Infrastructure
{
    public class DependencyContext
    {       
        static DependencyContext()
        {
            InstallComponents();
        }

        private DependencyContext()
        {            
        }

        private static void InstallComponents()
        {
            var isDistributed = HisConfigurationManager.Configuration.IsDistributed;
            if (!isDistributed)
            {
                HisConfigurationManager.Configuration.LocalSection.Installers.ToList().ForEach(installer =>
                {
                    Container.Install(FromAssembly.Named(installer.Assembly));
                });
            }
        }

        public static void Initialize() 
        {

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
