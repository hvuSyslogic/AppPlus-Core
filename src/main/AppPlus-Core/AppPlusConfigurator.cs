using AutoMapper;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Core
{
    public class AppPlusConfigurator
    {        
        public static IUnityContainer Config()
        {
            return IoCContainer.Instance;
        }       
    }
}
