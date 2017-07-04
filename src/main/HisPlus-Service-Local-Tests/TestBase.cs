using AppPlus.Core;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AppPlus.Infrastructure.Contract.Services;
using AppPlus.Core.Service;
using HisPlus.Services;
using HisPlus.Contract.Services;
using HisPlus.Domain;
using AppPlus.Infrastructure.Configuration;
using System.Linq.Expressions;
using AppPlus.Client;
using log4net;

namespace HisPlus.Service.Local.Tests
{
    public abstract class TestBase
    {
        const string ConnectionString = "HisPlus";
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static TestBase()
        {
            var Container = AppConfigurator.Container                
                .RegisterStorage<HisDbContext>(ConnectionString)
                .RegisterMapProfiles(typeof(BsGfxeService).Assembly)
                .RegisterServices(typeof(IBsGfxeService).Assembly, typeof(BsGfxeService).Assembly)
            ;
        }

        internal protected static void CallService<T>(Expression<Action<T>> expression)
            where T : AppPlus.Infrastructure.Contract.Services.IServiceRoot
        {
            ServiceHandler.CallService(expression);
        }

        internal protected static TResult CallService<T, TResult>(Expression<Func<T, TResult>> expression)
            where T : AppPlus.Infrastructure.Contract.Services.IServiceRoot
        {
            return ServiceHandler.CallService(expression);
        }
    }
}
