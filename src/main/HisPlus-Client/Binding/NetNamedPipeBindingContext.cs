using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace HisPlus.Client.Binding
{
    public class NetNamedPipeBindingContext : IBindingBuilder
    {
        public System.ServiceModel.Channels.Binding Build()
        {
            NetNamedPipeBinding netNamedPipeBinding = new NetNamedPipeBinding()
            {
                MaxReceivedMessageSize = Constants.MaxReceivedMessageSize
            };

            return netNamedPipeBinding;
        }
    }
}
