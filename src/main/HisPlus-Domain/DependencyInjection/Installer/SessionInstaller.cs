using Castle.Core.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using HisPlus.Infrastructure;
using HisPlus.Infrastructure.Config;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HisPlus.Infrastructure.Extensions;
using HisPlus.Infrastructure.DependencyInjection;

namespace HisPlus.Domain.DependencyInjection.Installer
{
    public class SessionInstaller : IWindsorInstaller
    {        
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            var config = IoCManager.Container.Resolve<IHisPlusConfiguration>();
            var dependencies = new Dependency[1];
            dependencies[0] = Dependency.OnValue("connectionString", config.LocalProvider.ConnectionString.Name);

            container.Register(Component.For<DbContext>().ImplementedBy<HisDbContext>()
               .DependsOn(dependencies).LifestylePooled());
        }
    }
}
