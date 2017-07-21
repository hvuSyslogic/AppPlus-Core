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
            return IoCManager.Container.Resolve<ILoggerFactory>().Create(type);
        }
    }
}
