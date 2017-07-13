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
            
            //container.Install(new StoreageInstaller());
            //container.Install(FromAssembly.Named("HisPlus.Core"), FromAssembly.Named("HisPlus.Service"));
            //var isDistributed = ConfigurationManager.Configuration.IsDistributed;
            //if (isDistributed)
            //{
            //    ConfigurationManager.Configuration.LocalSection.Installers.ToList().ForEach(x => 
            //    {
            //        container.Install(FromAssembly.Named(x.Value));
            //    });
            //}

            //container.Register(Component.For<DbContext>().ImplementedBy<HisDbContext>()
            //    .DependsOn(Dependency.OnValue("connectionString", "HisPlus"))
            //    .DependsOn(Dependency.OnValue("assemblies", new Assembly[] { typeof(BsArea).Assembly })).LifestyleTransient());
            //container.Register(Types.FromAssemblyNamed("HisPlus.Service")
            //    .Where(type => type.Name.EndsWith("Service"))
            //    .WithService.DefaultInterfaces().Configure(c => c.LifestyleTransient() ));

            var context = container.Resolve<DbContext>();
            var area = context.Set<BsArea>().FirstOrDefault();
            var hasComponent = DependencyContext.Container.Kernel.HasComponent("HisPlus.Service.BsAreaCommitteeService");
            //Mapper.Initialize(cfg =>
            //{
            //    cfg.AddProfiles(typeof(BsAreaService).Assembly);
            //});

            IBsLocationService service = container.Resolve<IBsLocationService>();
            var result = service.RetrieveAll();

        }

        [Fact]
        public void TestConfiguration()
        {
            var container = DependencyContext.Container;

            foreach (var handler in container.Kernel.GetAssignableHandlers(typeof(object)))
            {
                Console.WriteLine("{0} {1}",
                   handler.ComponentModel.Services,
                   handler.ComponentModel.Implementation);
            }
        }
    }
}
