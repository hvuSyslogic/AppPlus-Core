using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OpsEventDTO : DtoBase<int>
    {
        public OpsEventDTO()
        {
        }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }
    }
}
