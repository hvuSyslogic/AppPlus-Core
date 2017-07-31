using Castle.Core.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using HisPlus.Infrastructure;
using HisPlus.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CastleDependency = Castle.MicroKernel.Registration;
using HisPlus.Infrastructure.Extensions;

namespace HisPlus.Domain.Installer
{
    public class SessionInstaller : IWindsorInstaller
    {
        private const string DependencyName = "connectionString";

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            string connectionStringName = HisConfigurationManager.Configuration.LocalProvider.ConnectionString.Name;

            container.Register(Component.For<DbContext>().ImplementedBy<HisDbContext>()
               .DependsOn(CastleDependency.Dependency.OnValue(DependencyName, connectionStringName)).LifestylePooled());

            this.GetLogger().InfoFormat("DbContext component was successfully installed from assembly '{0}'.", GetType().Assembly);
        }
    }
}
