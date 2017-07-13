using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using HisPlus.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HisPlus.Services.Installer
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly().BasedOn<ServiceRoot>()
                .WithService.DefaultInterfaces().Configure(c => c.LifestyleTransient()));

            InstallAutoMapper();
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
