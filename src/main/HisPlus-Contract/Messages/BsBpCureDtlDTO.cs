using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsBpCureDtlDTO : DtoBase<int>
    {
        public BsBpCureDtlDTO()
        {
        }

        [DataMember]
        public int? CureId { get; set; }

        [DataMember]
        public int? BpItemId { get; set; }

        [DataMember]
        public int? TypeCode { get; set; }

        [DataMember]
        public int? RelationCode { get; set; }

        [DataMember]
        public string WayCode { get; set; }

        [DataMember]
        public string Remark { get; set; }
    }
}
