using AutoMapper;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Core
{
    public class AppPlusConfigurator
    {
        public IUnityContainer Container { get { return IoCContainer.Instance; } }

        public AppPlusConfigurator BuildMapper(Assembly profileAssembly)
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles(profileAssembly);
            });

            return this;
        }

        public IUnityContainer BuildContext<TDbContext>(string connectionString)
             where TDbContext : DbContext
        {
            ContainerBuilder.Build<TDbContext>(connectionString);

            return Container;
        }

        public IUnityContainer RegisterServices(Assembly fromAssembly, Assembly toAssembly)
        {
            return Container.RegisterAssembly(fromAssembly, toAssembly);
        }
    }

    public interface IAppPlusConfigurator
    {

    }
}
