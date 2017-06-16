using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Activation;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;
using Microsoft.Practices.Unity;
using log4net;
using System.ServiceModel.Security;
using AppPlus.Core;

namespace HisPlus.Wcf.Host
{
    public class DynamicHostFactory : ServiceHostFactory
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private void ArgumentValidation(string reference, Uri[] baseAddresses)
        {
            if (string.IsNullOrEmpty(reference))
            {
                throw new ArgumentNullException("reference");
            }

            if (baseAddresses == null)
            {
                throw new ArgumentNullException("baseAddresses");
            }

            if (!baseAddresses.Any())
            {
                throw new ArgumentException("baseAddresses can not be empty.");
            }
        }

        public override ServiceHostBase CreateServiceHost(string reference, Uri[] baseAddresses)
        {
            ArgumentValidation(reference, baseAddresses);
            
            var containerRegistrations = IoCContainer.Instance.Registrations;

            var registration = containerRegistrations.Where(x => x.MappedToType.Name.ToLower() == reference.ToLower()).FirstOrDefault();
            if (registration == null)
            {
                throw new ArgumentOutOfRangeException(string.Format("Invalid service name '{0}'", reference));
            }

            Type registeredType = registration.RegisteredType;
            Type mappedToType = registration.MappedToType;
      
            ServiceHost host = new ServiceHost(mappedToType, baseAddresses);
            
            TimeSpan ts = new TimeSpan(0, 10, 0);

            foreach (Uri address in baseAddresses)
            {
                BasicHttpBinding wsHttpBinding = new BasicHttpBinding()
                {
                    Name = mappedToType.Name,
                    MaxBufferSize = Int32.MaxValue,
                    MaxBufferPoolSize = Int32.MaxValue,
                    MaxReceivedMessageSize = Int32.MaxValue,
                    ReaderQuotas = new System.Xml.XmlDictionaryReaderQuotas()
                    {
                        MaxArrayLength = Int32.MaxValue,
                        MaxBytesPerRead = Int32.MaxValue,
                        MaxDepth = Int32.MaxValue,
                        MaxNameTableCharCount = Int32.MaxValue,
                        MaxStringContentLength = Int32.MaxValue,
                    },
                    CloseTimeout = ts,
                    OpenTimeout = ts,
                    ReceiveTimeout = ts,
                    SendTimeout = ts,
                };

                var attribute = Attribute.GetCustomAttribute(registeredType, typeof(ServiceContractAttribute));
                var serviceAttribute = (ServiceContractAttribute)attribute;
                if (serviceAttribute != null)
                {
                    //NetTcpBinding tcpBinding = new NetTcpBinding();

                    //string url = string.Format("net.tcp://localhost:8888/{0}", reference);

                    //host.AddServiceEndpoint(registeredType, wsHttpBinding, address);

                    //host.AddServiceEndpoint(registeredType, tcpBinding, url);
                    //host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");                    
                }
                //Uri httpBaseAddress = new Uri("http://localhost:8000");
                //WebServiceHost mServiceHost = new WebServiceHost(typeof(SmartService), httpBaseAddress);
                //Binding nWebHttpBinding = new WebHttpBinding();
                //mServiceHost.AddServiceEndpoint(typeof(ISmartService), nWebHttpBinding, "SmartService");
                //WebHttpBehavior helpBehavior = new WebHttpBehavior();
                //helpBehavior.HelpEnabled = true;
                //mServiceHost.Description.Endpoints[0].Behaviors.Add(helpBehavior);
                //mServiceHost.Open(); 
            }

            if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)
            {
                ServiceMetadataBehavior metadata = new ServiceMetadataBehavior();
                metadata.HttpGetEnabled = true;
                metadata.HttpGetUrl = baseAddresses[0];
                host.Description.Behaviors.Add(metadata);
            }
            
            return host;
        }     
    }
}