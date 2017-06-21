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

namespace HisPlus.Service.Local.Tests
{
    public class TestBase
    {
        const string ConnectionString = "AppPlus.His";

        static TestBase()
        {            
            var Container = AppConfigurator.Container
                .RegisterMapProfiles(typeof(BsGfxeService).Assembly)
                .RegisterStorage<HisDbContext>(ConnectionString)
                .RegisterServices(typeof(IBsGfxeService).Assembly, typeof(BsGfxeService).Assembly)
            ;
        }
    }
}
