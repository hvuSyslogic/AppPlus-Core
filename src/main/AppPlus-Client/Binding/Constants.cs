using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPlus.Client.Binding
{
    public class Constants
    {
        public const long MaxReceivedMessageSize = 65535000;
        public const int TimeoutMinutes = 10;
        public const string Uri = "http://{0}:{1}/{2}.svc";
        //public const string Uri = "net.tcp://{0}:{1}/{2}";
        
    }
}
