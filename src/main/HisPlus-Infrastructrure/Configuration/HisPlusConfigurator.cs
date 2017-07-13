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
    }    
}
