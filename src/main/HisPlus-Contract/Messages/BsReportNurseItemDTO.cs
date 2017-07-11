using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsReportNurseItemDTO : DtoBase<int>
    {
        public BsReportNurseItemDTO()
        {
        }

        [DataMember]
        public string FeeName { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Spec { get; set; }

        [DataMember]
        public double? Price { get; set; }

        [DataMember]
        public string Unit { get; set; }

        [DataMember]
        public int? ItemId { get; set; }

        [DataMember]
        public int? IsOuInAll { get; set; }

        [DataMember]
        public string Type { get; set; }
    }
}
