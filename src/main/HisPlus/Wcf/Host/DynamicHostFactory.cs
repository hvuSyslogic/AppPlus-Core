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
using AppPlus.Infrastructure.Configuration;
using HisPlus.Wcf.DependencyInjection;

namespace HisPlus.Wcf.Host
{
    public class DynamicHostFactory : DependencyInjectionServiceHostFactory //ServiceHostFactory
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
       
        public override ServiceHostBase CreateServiceHost(string reference, Uri[] baseAddresses)
        {
            ArgumentValidation(reference, baseAddresses);

            var containerRegistrations = AppConfigurator.Container.Registrations;

            var registration = containerRegistrations.Where(x => x.MappedToType.Name.ToLower() == reference.ToLower()).FirstOrDefault();
            if (registration == null)
            {
                throw new ArgumentOutOfRangeException(string.Format("Invalid service name '{0}'", reference));
            }
            
            Type registeredType = registration.RegisteredType;
            Type mappedToType = registration.MappedToType;

            //object serviceType = AppConfigurator.Container.Resolve(mappedToType);

            ServiceHost host = new DependencyInjectionServiceHost(mappedToType, baseAddresses);
            
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

        protected override void RegisterDependencies()
        {
            //DependencyFactory.Container.RegisterType(typeof(IExampleRepository), typeof(ExampleRepository), new ContainerControlledLifetimeManager());

            Log.Error("+++++++++++++++++++++++++++++");
        }

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
    }
}