using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsLabSourceItemDTO : DtoBase<int>
    {
        public BsLabSourceItemDTO()
        {
        }

        [DataMember]
        public int SourceId { get; set; }

        [DataMember]
        public int? TubeTypeId { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal Totality { get; set; }

        [DataMember]
        public short LsUseArea { get; set; }
    }
}
