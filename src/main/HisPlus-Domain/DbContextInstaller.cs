using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using HisPlus.Infrastructure.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Domain
{
    public class DbContextInstaller : IWindsorInstaller
    {
        private const string DependencyName = "connectionString";

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            string connectionStringName = ConfigurationManager.Configuration.LocalSection.ConnectionStringName;

            container.Register(Component.For<DbContext>().ImplementedBy<HisDbContext>()
               .DependsOn(Dependency.OnValue(DependencyName, connectionStringName)).LifestyleTransient());
        }
    }
}
