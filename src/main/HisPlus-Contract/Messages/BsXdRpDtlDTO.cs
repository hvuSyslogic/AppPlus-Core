using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsXdRpDtlDTO : DtoBase<int>
    {
        public BsXdRpDtlDTO()
        {
        }

        [DataMember]
        public int XdRpId { get; set; }

        [DataMember]
        public short GroupNum { get; set; }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public decimal Dosage { get; set; }

        [DataMember]
        public int? UnitTakeId { get; set; }

        [DataMember]
        public int? FrequencyId { get; set; }

        [DataMember]
        public int? UsageId { get; set; }

        [DataMember]
        public short? Days { get; set; }

        [DataMember]
        public int? ExecLocId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public decimal? FeeTotality { get; set; }

        [DataMember]
        public int? UnitId { get; set; }
    }
}
