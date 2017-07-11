using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;
using System.Web.Security;
using System.Web.SessionState;
using AutoMapper;
using HisPlus.Core.Service;
using HisPlus.Core;
using HisPlus.Wcf.Host;
using HisPlus.Services;
using HisPlus.Contract.Services;
using HisPlus.Infrastructure.Configuration;

namespace HisPlus
{
    public class Global : System.Web.HttpApplication
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private const string ConnectionString = "HisPlus";

        protected void Application_Start(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();

            HostingEnvironment.RegisterVirtualPathProvider(new ServicePathProvider());

            Application_Initialize();
        }

        private void Application_Initialize()
        {
           HisPlusConfigurator.Container               
               .RegisterStorage<HisPlus.Domain.HisDbContext>(ConnectionString)               
               .RegisterServices(typeof(IBsGfxeService).Assembly, typeof(BsGfxeService).Assembly)
               .RegisterMapProfiles(typeof(BsGfxeService).Assembly)
            ;
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

        }
    }
}