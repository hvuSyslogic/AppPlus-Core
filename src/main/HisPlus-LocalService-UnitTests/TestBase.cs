using HisPlus.Core;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Core.Service;
using HisPlus.Services;
using HisPlus.Contract.Services;
using HisPlus.Domain;
using HisPlus.Infrastructure.Configuration;
using System.Linq.Expressions;
using HisPlus.Client;
using log4net;

namespace HisPlus.Service.Local.UnitTests
{
    public abstract class TestBase
    {
        const string ConnectionString = "HisPlus";
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static TestBase()
        {
            var Container = HisPlusConfigurator.Container
                .RegisterStorage<HisDbContext>(ConnectionString)
                .RegisterMapProfiles(typeof(BsGfxeService).Assembly)
                .RegisterServices(typeof(IBsGfxeService).Assembly, typeof(BsGfxeService).Assembly)
                ;
        }

        internal protected static void CallService<T>(Expression<Action<T>> expression)
            where T : HisPlus.Infrastructure.Contract.Services.IServiceRoot
        {
            ServiceHandler.CallService(expression);
        }

        internal protected static TResult CallService<T, TResult>(Expression<Func<T, TResult>> expression)
            where T : HisPlus.Infrastructure.Contract.Services.IServiceRoot
        {
            return ServiceHandler.CallService(expression);
        }
    }
}
