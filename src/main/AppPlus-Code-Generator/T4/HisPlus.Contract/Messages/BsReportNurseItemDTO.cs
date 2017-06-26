using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    // The table 'BsReportNurseItem' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    [Serializable]
    [DataContract]
    public class BsReportNurseItemDTO
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
