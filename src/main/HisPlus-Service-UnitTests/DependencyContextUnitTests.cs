using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.Windsor.Installer;
using HisPlus.Contract.Services;
using HisPlus.Core;
using HisPlus.Domain;
using HisPlus.Infrastructure;
using HisPlus.Infrastructure.Configuration;
using HisPlus.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HisPlus.Service.UnitTests
{
    public class DependencyContextUnitTests
    {
        const string TraitName = "DependencyContextUnitTests";
        const string DisplayName = "DependenyInjection";

        [Fact(DisplayName = "001_Container_Registeration_Test")]
        [Trait(TraitName, DisplayName)]
        public void TestRegister()
        {
            if (!HisConfigurationManager.Configuration.IsDistributed)
            {
                var container = DependencyContext.Container;
                var context = container.Resolve<DbContext>();

                var area = context.Set<BsArea>().FirstOrDefault();
                Assert.NotNull(area);

                var service = container.Resolve<IBsLocationService>();
                var result = service.RetrieveAll();

                Assert.NotNull(result);
            }
        }

        [Fact(DisplayName = "002_Container_Get_All_Registeration_Components")]
        [Trait(TraitName, DisplayName)]
        public void TestConfiguration()
        {
            if (!HisConfigurationManager.Configuration.IsDistributed)
            {
                var container = DependencyContext.Container;
                var handlers = container.Kernel.GetAssignableHandlers(typeof(object));

                Assert.NotNull(handlers);
                Assert.NotEmpty(handlers);

                foreach (var handler in handlers)
                {
                    var service = handler.ComponentModel.Services;
                    var type = handler.ComponentModel.Implementation;
                }
            }
        }
    }
}
