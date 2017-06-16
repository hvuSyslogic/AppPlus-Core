using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace AppPlus.Core
{
    public class IoCContainer
    {
        private IoCContainer() { }    

        public static IUnityContainer Instance
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
