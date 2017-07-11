using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace HisPlus.Client.Binding
{
    public class NetTcpBindingContext : IBindingBuilder
    {        
        public System.ServiceModel.Channels.Binding Build()
        {
            //NetTcpBinding netTcpBinding = new NetTcpBinding(SecurityMode.None)
            NetTcpBinding netTcpBinding = new NetTcpBinding()
            {
                MaxReceivedMessageSize = Constants.MaxReceivedMessageSize
            };

            return netTcpBinding;
        }
    }
}
