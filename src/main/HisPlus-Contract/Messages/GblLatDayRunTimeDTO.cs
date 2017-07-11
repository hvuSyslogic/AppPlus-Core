using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class GblLatDayRunTimeDTO : DtoBase<int>
    {
        public GblLatDayRunTimeDTO()
        {
        }

        [DataMember]
        public System.DateTime? LastTime { get; set; }
    }
}
