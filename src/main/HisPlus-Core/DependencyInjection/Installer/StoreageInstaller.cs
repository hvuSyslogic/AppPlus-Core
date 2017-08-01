using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using HisPlus.Core.Abstractions;
using HisPlus.Core.Abstractions.Support;
using HisPlus.Infrastructure.Extensions;

namespace HisPlus.Core.DependencyInjection.Installer
{
    public class StoreageInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            // You can set dependencies on Resolve() method by adding an anonymous type with constructor parameter's name
            // type = container.Resolve<IType>(new { connectionString = connectionString });
            this.GetLogger().InfoFormat("Starting to install components for Storeage .....");

            container.Register(Component.For<IUnitOfWork>().ImplementedBy<UnitOfWork>().LifestyleTransient());
            container.Register(Component.For(typeof(IRepository<>)).ImplementedBy(typeof(Repository<>)).LifestyleTransient());
            
            this.GetLogger().InfoFormat("Storeage components was successfully installed from assembly '{0}'.", GetType().Assembly);
        }
    }
}
