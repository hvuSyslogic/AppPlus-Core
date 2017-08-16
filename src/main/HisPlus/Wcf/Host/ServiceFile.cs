using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.IO;
using HisPlus.Infrastructure.Extensions;

namespace HisPlus.WCF.Host
{
    public class ServiceFile : VirtualFile
    {
        public ServiceFile(string virtualPath)
            : base(virtualPath)
        { 
        }

        public string GetCallingServiceName
        {
            get
            {
                return base.VirtualPath.Replace(ServiceHostConfiguration.PathSeparator, string.Empty)
                    .Replace(ServiceHostConfiguration.Extension, string.Empty)
                    .TrimStart(ServiceHostConfiguration.Prefix.ToCharArray());                
            }
        }

        public string GetService()
        {
            return this.GetCallingServiceName;
        }

        public override Stream Open()
        {
            var serviceDef = new MemoryStream();
            var defWriter = new StreamWriter(serviceDef);
            string serviceName = this.GetService();
                        
            //var type = typeof(DynamicHostFactory);
            //var typeName = string.Format("{0}, {1}", type.FullName, type.Assembly.FullName);

            //https://stackoverflow.com/questions/10085172/using-castle-windsor-wcffacility-to-create-client-endpoints
            //var serviceHostDef = string.Format(ServiceHostConfiguration.Definition, ServiceHostConfiguration.Debug, serviceName, typeName);                            
            var serviceHostDef = string.Format(ServiceHostConfiguration.Definition, serviceName);

            defWriter.Write(serviceHostDef);
            defWriter.Flush();

            serviceDef.Position = 0;
            
            return serviceDef;
        }
    }
}