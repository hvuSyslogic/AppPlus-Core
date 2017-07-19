using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace HisPlus.Infrastructure.Contract.Messages
{    
    [Serializable]
    [DataContract]
    public class UnexpectedServiceFault
    {
        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public string StackTrace { get; set; }

        [DataMember]
        public string Target { get; set; }

        [DataMember]
        public string Source { get; set; }
    }

}
