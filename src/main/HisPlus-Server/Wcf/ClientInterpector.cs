using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace HisPlus.Wcf
{
    public class ClientInterpector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
        }
        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            var userName = MessageHeader.CreateHeader("userName", "http://tempuri.org", "dragon.luo", false, "");
            var password = MessageHeader.CreateHeader("Password", "http://tempuri.org", "lawson", false, "");
            request.Headers.Add(userName);
            request.Headers.Add(password);
            
            return null;
        }
    }  
}
