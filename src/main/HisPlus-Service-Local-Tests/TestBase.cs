using AppPlus.Core;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AppPlus.Infrastructure.Contracts.Services;
using AppPlus.Core.Service;
using HisPlus.Services.BS;
using HisPlus.Domain.BS;
using HisPlus.Contracts.Services.BS;

namespace AppPlus.His.Domain.Tests
{
    public class TestBase
    {
        const string ConnectionString = "AppPlus.His";

        static TestBase()
        {
            Container = AppPlusConfigurator.Config()
                .RegisterMapProfiles(typeof(BSGfxeService).Assembly)
                .RegisterStorage<HisPlus.Domain.HisDbContext>(ConnectionString)
                .RegisterServices(typeof(IBSGfxeService).Assembly, typeof(BSGfxeService).Assembly)
            ;
        }

        protected static IUnityContainer Container { get; set; }
    }
}
