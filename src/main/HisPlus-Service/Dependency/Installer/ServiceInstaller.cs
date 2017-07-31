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

namespace HisPlus.Services.Installer
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

            Logger.InfoFormat("Services was successfully installed from assembly '{0}'.", GetType().Assembly);

            InstallAutoMapper();

            Logger.InfoFormat("Automapper profiles was successfully configured from assembly '{0}'.", GetType().Assembly);
        }

        private void InstallAutoMapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles(GetType().Assembly);
            });
        }
    }
}
