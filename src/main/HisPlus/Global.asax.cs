using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;
using System.Web.Security;
using System.Web.SessionState;
using HisPlus.WCF.Host;
using HisPlus.Infrastructure.DependencyInjection;
using Castle.Facilities.WcfIntegration;
using HisPlus.Services;
using HisPlus.Contract.Services;
using Castle.MicroKernel.Registration;
using System.ServiceModel;
using HisPlus.Services.DependencyInjection.Installer;
using HisPlus.Core.Abstractions.Support;
using System.ServiceModel.Description;
using HisPlus.WCF;
using Castle.Windsor.Installer;
using HisPlus.Core.Hosting;
using AutoMapper;

namespace HisPlus
{
    public class Global : System.Web.HttpApplication
    {
        static Global()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfiles(typeof(ServiceInstaller).Assembly);
            });
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            HostingEnvironment.RegisterVirtualPathProvider(new ServicePathProvider());             

            RegisterServices();
        }

        private void RegisterServices()
        {
            ServiceDebugBehavior returnFaults = new ServiceDebugBehavior();
            returnFaults.IncludeExceptionDetailInFaults = true;
            returnFaults.HttpHelpPageEnabled = true;

            ServiceMetadataBehavior metadata = new ServiceMetadataBehavior();
            metadata.HttpGetEnabled = true;

            var basicHttpBinding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            basicHttpBinding.MaxReceivedMessageSize = int.MaxValue;

            var wsHttpBinding = new WSHttpBinding(SecurityMode.None)
            {
                MaxReceivedMessageSize = int.MaxValue
            };

            var assembly = typeof(ServiceInstaller).Assembly;

            IoCManager.Container.AddFacility<WcfFacility>().Register(
                Component.For<IServiceBehavior>().Instance(returnFaults),
                Component.For<IServiceBehavior>().Instance(metadata),
                Component.For<IServiceBehavior>().Instance(new ErrorHandlerBehavior()),
                Classes.FromAssembly(assembly).BasedOn<ServiceRoot>()
                .WithService.DefaultInterfaces()
                .Configure(c =>
                    c.LifestyleTransient().Named(c.Implementation.Name.Replace(c.Implementation.Namespace, "")
            ).AsWcfService(new DefaultServiceModel().Hosted().AddEndpoints(
            WcfEndpoint.BoundTo(basicHttpBinding)//,
            //WcfEndpoint.BoundTo(new NetTcpBinding() { PortSharingEnabled = true })
            //.At(string.Format("net.tcp://localhost/{0}", c.Implementation.Name.Replace(c.Implementation.Namespace, ""))),
            //WcfEndpoint.BoundTo(wsHttpBinding).At("ws")
            ).PublishMetadata())));
        }

        protected void Session_Start(object sender, EventArgs e)
        {            
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            if (IoCManager.Container != null)
            {
                IoCManager.Container.Dispose();
            }
        }
    }
}