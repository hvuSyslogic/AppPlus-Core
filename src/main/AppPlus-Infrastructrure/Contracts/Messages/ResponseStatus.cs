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
    public enum ResponseStatus
    {
        [EnumMember(Value = "OK")]
        OK = 0,

        [EnumMember(Value = "ERROR")]
        Error = 1,
    }   
}
