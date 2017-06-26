using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InWorkLogDTO : DtoBase<int>
    {
        public InWorkLogDTO()
        {
        }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public decimal? BedSum { get; set; }

        [DataMember]
        public decimal? OverBedSum { get; set; }

        [DataMember]
        public string Standard { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public short? LastNum { get; set; }

        [DataMember]
        public short? StartNum { get; set; }

        [DataMember]
        public short? InHospital { get; set; }

        [DataMember]
        public short? InLocation { get; set; }

        [DataMember]
        public short? OutLocation { get; set; }

        [DataMember]
        public short? OutHospital { get; set; }

        [DataMember]
        public short? Dead { get; set; }

        [DataMember]
        public short? NowNum { get; set; }

        [DataMember]
        public short? OverNum { get; set; }

        [DataMember]
        public short? CompanyNum { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public int? Days { get; set; }

        [DataMember]
        public int? Danger { get; set; }

        [DataMember]
        public int? Heavy { get; set; }

        [DataMember]
        public int? Acute { get; set; }
    }
}
