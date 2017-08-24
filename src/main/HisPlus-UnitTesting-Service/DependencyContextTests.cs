using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using AutoMapper;
using HisPlus.Contract.Services;
using HisPlus.Core;
using HisPlus.Domain;
using HisPlus.Infrastructure.Config;
using HisPlus.Services;
using HisPlus.Infrastructure.DependencyInjection;
using Castle.MicroKernel.Registration;
using HisPlus.Core.Abstractions.Support;

namespace HisPlus.UnitTesting
{
    public class DependencyContextTests
    {
        const string TraitName = "DependencyContextUnitTests";
        const string DisplayName = "DependenyInjection";
        IHisPlusConfiguration config = IoCManager.Container.Resolve<IHisPlusConfiguration>();

        [Fact(DisplayName = "001_Container_Registeration_Test")]
        [Trait(TraitName, DisplayName)]
        public void TestRegister()
        {
            if (config.Provider == ProviderType.Local)
            {
                var container = IoCManager.Container;
                var context = container.Resolve<DbContext>();

                var area = context.Set<BsArea>().FirstOrDefault();                
                area.Should().NotBeNull();

                var service = container.Resolve<IBsLocationService>();
                var result = service.GetAll();
                result.Should().NotBeNullOrEmpty();                
            }
        }

        [Fact(DisplayName = "002_Container_Get_All_Registeration_Components")]
        [Trait(TraitName, DisplayName)]
        public void TestConfiguration()
        {
            if (config.Provider == ProviderType.Local)
            {
                var container = IoCManager.Container;
                var handlers = container.Kernel.GetAssignableHandlers(typeof(object));                
                handlers.Should().NotBeNullOrEmpty();
                
                foreach (var handler in handlers)
                {
                    var service = handler.ComponentModel.Services;
                    var type = handler.ComponentModel.Implementation;
                }
            }
        }        
    }
}
