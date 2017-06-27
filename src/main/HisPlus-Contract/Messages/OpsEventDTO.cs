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
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? UsageId { get; set; }
    }
}