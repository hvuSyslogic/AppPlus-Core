using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel.Activation;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using HisPlus.Core;
using HisPlus.Infrastructure.Configuration;
using HisPlus.Wcf.DependencyInjection;
using HisPlus.Infrastructure.Contract.Services;
using HisPlus.Infrastructure.Dependency;

namespace HisPlus.Wcf.Host
{
    /// <summary>
    /// http://blog.micic.ch/net/dynamic-iis-hosted-wcf-service
    /// https://ayende.com/blog/3752/rhino-service-bus
    /// </summary>
    public class DynamicHostFactory : ServiceHostFactory
    {        
        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        {
            //Type registeredType = registration.RegisteredType;
            //Type mappedToType = registration.MappedToType;

            var serviceHandler = IoCManager.Container.Kernel.GetAssignableHandlers(typeof(object))
                .ToList().Where(x => x.ComponentModel.Implementation.Name == constructorString).FirstOrDefault();
            if (serviceHandler == null)
            {
                throw new InvalidOperationException(string.Format("Could not find a component with name '{0}' , did you forget to register it?", constructorString));
            }

            var serviceType = serviceHandler.ComponentModel.Implementation;

            //var mappedToType = Type.GetType(constructorString, false);

            ServiceHost host = new ServiceHost(serviceType, baseAddresses);
            
            //TimeSpan ts = new TimeSpan(0, 10, 0);

            //foreach (Uri address in baseAddresses)
            //{
            //    BasicHttpBinding wsHttpBinding = new BasicHttpBinding()
            //    {
            //        Name = serviceType.Name,
            //        MaxBufferSize = Int32.MaxValue,
            //        MaxBufferPoolSize = Int32.MaxValue,
            //        MaxReceivedMessageSize = Int32.MaxValue,
            //        ReaderQuotas = new System.Xml.XmlDictionaryReaderQuotas()
            //        {
            //            MaxArrayLength = Int32.MaxValue,
            //            MaxBytesPerRead = Int32.MaxValue,
            //            MaxDepth = Int32.MaxValue,
            //            MaxNameTableCharCount = Int32.MaxValue,
            //            MaxStringContentLength = Int32.MaxValue,
            //        },
            //        CloseTimeout = ts,
            //        OpenTimeout = ts,
            //        ReceiveTimeout = ts,
            //        SendTimeout = ts,
            //    };

                //var attribute = Attribute.GetCustomAttribute(registeredType, typeof(ServiceContractAttribute));
                //var serviceAttribute = (ServiceContractAttribute)attribute;
                //if (serviceAttribute != null)
                //{
                //    //NetTcpBinding tcpBinding = new NetTcpBinding();

                //    //string url = string.Format("net.tcp://localhost:8888/{0}", reference);

                //    //host.AddServiceEndpoint(registeredType, wsHttpBinding, address);

                //    //host.AddServiceEndpoint(registeredType, tcpBinding, url);
                //    //host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");                    
                //}             
            //}

            // Add endpoints
            foreach (Type contract in serviceType.GetInterfaces().Where(x => x.IsSubclassOf(typeof(IServiceRoot))))
            {
                var attribute = (ServiceContractAttribute)Attribute.GetCustomAttribute(contract, typeof(ServiceContractAttribute));
                if (attribute != null)
                {
                    host.AddServiceEndpoint(contract, new BasicHttpBinding(), "");
                }                    
            }

            // Add metdata behavior for generating wsdl
            var metadata = host.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (metadata == null)
            {
                metadata = new ServiceMetadataBehavior() 
                { 
                    HttpGetEnabled = true, 
                    HttpGetUrl = baseAddresses[0] 
                };
                
                host.Description.Behaviors.Add(metadata);
            };
      
            return host;
        }

        //public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        //{
        //    // Load bin/services.dll
        //    var asm = Assembly.Load("Services");
        //    var serviceType = asm.GetType(constructorString);
        //    var host = new ServiceHost(serviceType, baseAddresses);

        //    // Add endpoints. (In this example only IHello interface)
        //    foreach (Type contract in serviceType.GetInterfaces())
        //    {
        //        var attribute = (ServiceContractAttribute)
        //            Attribute.GetCustomAttribute(contract, typeof(ServiceContractAttribute));
        //        if (attribute != null)
        //            host.AddServiceEndpoint(contract, new BasicHttpBinding(), "");
        //    }
        //    // Add metdata behavior for generating wsdl
        //    var metadata = new ServiceMetadataBehavior();
        //    metadata.HttpGetEnabled = true;
        //    host.Description.Behaviors.Add(metadata);

        //    return host;
        //}
    }
}