using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using HisPlus.Infrastructure.Dependency;

namespace HisPlus
{
    public static class TyperEx
    {
        public static ILogger GetLogger(this Type type)
        {
            ILogger logger = IoCManager.Container.Resolve<ILoggerFactory>().Create(type);

            if (logger == null)
            {
                logger = NullLogger.Instance;
            }

            return logger;
        }

        public static ILogger GetLogger(this object c) 
        {
            ILogger logger = IoCManager.Container.Resolve<ILoggerFactory>().Create(c.GetType());

            if (logger == null)
            {
                logger = NullLogger.Instance;
            }

            return logger;
        }  
    }
}
