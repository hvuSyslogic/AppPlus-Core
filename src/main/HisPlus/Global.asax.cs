using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Hosting;
using System.Web.Security;
using System.Web.SessionState;
using HisPlus.Wcf.Host;
using HisPlus.Infrastructure;

namespace HisPlus
{
    public class Global : System.Web.HttpApplication
    {        
        protected void Application_Start(object sender, EventArgs e)
        {     
            HostingEnvironment.RegisterVirtualPathProvider(new ServicePathProvider());            
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            DependencyContext.InstallComponents();
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
            if (DependencyContext.Container != null)
            {
                DependencyContext.Container.Dispose();
            }
        }
    }
}