using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Diagnostics;
using System.Threading;
using System.Collections.ObjectModel;
using log4net;
using AppPlus.Client.Binding;
using System.ServiceModel;
using AppPlus.Infrastructure.Contracts.Services;

namespace AppPlus.Client
{
    public class ProxyManager
    {
        public static string ServiceHost { get; set; }

        public static int Port { get; set; }

        public static BindingType BindingType { get; set; }

        public static T GetProxy<T>()
            where T : IServiceRoot
        {
            string service = typeof(T).Name.Substring(1);
            string url = string.Format(Constants.Uri, ServiceHost, Port, service);
            return GetProxy<T>(BindingType.BasicHttpBinding, url);
        }

        private static T GetProxy<T>(BindingType bindingType, string url)
            where T : IServiceRoot
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException("Url can not be null or empty.");

            EndpointAddress address = new EndpointAddress(url);
            System.ServiceModel.Channels.Binding binding = GetBuilder(bindingType).Build();
            ChannelFactory<T> channelFactory = new ChannelFactory<T>(binding, address);

            return channelFactory.CreateChannel();
        }

        private static IBindingBuilder GetBuilder(BindingType bindingType)
        {
            switch (bindingType)
            {
                case BindingType.BasicHttpBinding:
                    return Binding.BasicHttpBindingFactory.Instance.Configure();

                case BindingType.NetNamedPipeBinding:
                    return Binding.NetNamedPipeBindingFactory.Instance.Configure();

                case BindingType.NetTcpBinding:
                    return Binding.NetTcpBindingFactory.Instance.Configure();

                case BindingType.WebHttpBinding:
                    return Binding.WebHttpBindingFactory.Instance.Configure();

                case BindingType.WSDualHttpBinding:
                    return Binding.WSDualHttpBindingFactory.Instance.Configure();

                case BindingType.WSFederationHttpBinding:
                    return Binding.WSFederationHttpBindingFactory.Instance.Configure();

                case BindingType.WSHttpBinding:
                    return Binding.WSHttpBindingFactory.Instance.Configure();

                default:
                    return Binding.BasicHttpBindingFactory.Instance.Configure();
            }
        }
    }
}
