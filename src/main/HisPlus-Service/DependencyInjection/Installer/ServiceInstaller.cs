using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Castle.Core.Logging;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using HisPlus.Infrastructure.Extensions;
using HisPlus.Core.Abstractions.Support;
using HisPlus.Infrastructure.DependencyInjection;
using HisPlus.Infrastructure.Config;
using System.ServiceModel.Description;
using System.ServiceModel;
using Castle.Facilities.WcfIntegration;
using HisPlus.Core.Hosting;

namespace HisPlus.Services.DependencyInjection.Installer
{
    public class ServiceInstaller : IWindsorInstaller
    {
        ILogger Logger
        {
            get { return GetType().GetLogger(); }
        }

        public void Install(IWindsorContainer container, IConfigurationStore store)
        {           
            container.Register(Classes.FromThisAssembly().BasedOn<ServiceRoot>()            
                .WithService.DefaultInterfaces().Configure(c => c.LifestyleTransient()));

            SetupMapperConfiguration();
        }

        private void SetupMapperConfiguration()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles(typeof(ServiceInstaller).Assembly);
            });
        }
    }
}
