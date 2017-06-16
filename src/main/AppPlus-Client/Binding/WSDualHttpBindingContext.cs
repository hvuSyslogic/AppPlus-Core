using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace AppPlus.Client.Binding
{
    public class WSDualHttpBindingContext : IBindingBuilder
    {        
        public System.ServiceModel.Channels.Binding Build()
        {
            WSDualHttpBinding wsDualHttpBinding = new WSDualHttpBinding()
            {
                MaxReceivedMessageSize = Constants.MaxReceivedMessageSize
            };

            return wsDualHttpBinding;
        }
    }
}
