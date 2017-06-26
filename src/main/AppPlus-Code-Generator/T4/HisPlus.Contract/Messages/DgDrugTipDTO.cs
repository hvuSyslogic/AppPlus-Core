using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class DgDrugTipDTO : DtoBase<int>
    {
        public DgDrugTipDTO()
        {
        }

        [DataMember]
        public int DrugId { get; set; }

        [DataMember]
        public string Sex { get; set; }

        [DataMember]
        public int AgeFrom { get; set; }

        [DataMember]
        public int AgeTo { get; set; }

        [DataMember]
        public decimal? Weight { get; set; }

        [DataMember]
        public int? WorktypeId { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public int? IcdId { get; set; }

        [DataMember]
        public short? LsWomenStatus { get; set; }

        [DataMember]
        public int? DropSpeed { get; set; }

        [DataMember]
        public string LClass { get; set; }

        [DataMember]
        public string Expain { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public decimal? Dosage { get; set; }
    }
}
