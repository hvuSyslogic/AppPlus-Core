using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace AppPlus.Infrastructure.Contract.Messages
{
    [DataContract]
    [Serializable]    
    public class AppPlusFault
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
        public List<string> Messages
        {
            get;
            set;
        }
        
        public AppPlusFault()
        {
            this.Messages = new List<string>();
        }
    }

}
