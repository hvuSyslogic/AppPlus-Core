using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AppPlus.Infrastructure.Contracts.Messages
{
    [Serializable]
    [DataContract]
    public class Error
    {
        [DataMember]
        public int ErrCode { get; set; }

        [DataMember]
        public string ErrType { get; set; }

        [DataMember]
        public string ErrMsg { get; set; }
    }
}
