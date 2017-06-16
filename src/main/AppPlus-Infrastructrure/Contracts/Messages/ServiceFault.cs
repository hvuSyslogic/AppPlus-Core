using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace AppPlus.Infrastructure.Contracts.Messages
{

    [DataContract]
    [Serializable]
    [XmlSerializerFormat]
    public class ServiceFault
    {
        [DataMember]
        public int ErrCode
        {
            get;
            set;
        }
        
        [DataMember]
        public string Type
        {
            get;
            set;
        }

        [DataMember]
        public System.Collections.Generic.List<string> Messages
        {
            get;
            set;
        }
        
        public ServiceFault()
        {
            this.Messages = new System.Collections.Generic.List<string>();
        }
    }

}
