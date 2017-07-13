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
        [Fact]
        public void TestRegister()
        {
            var container = DependencyContext.Container;                     

            var context = container.Resolve<DbContext>();
            var area = context.Set<BsArea>().FirstOrDefault();
            
            var service = container.Resolve<IBsLocationService>();
            var result = service.RetrieveAll();
        }

        [Fact]
        public void TestConfiguration()
        {
            var container = DependencyContext.Container;

            foreach (var handler in container.Kernel.GetAssignableHandlers(typeof(object)))
            {
                Console.WriteLine("{0} {1}", handler.ComponentModel.Services, handler.ComponentModel.Implementation);
            }
        }
    }
}
