using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class NrPregnancyDTO : DtoBase<int>
    {
        public NrPregnancyDTO()
        {
        }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public System.DateTime ExpectDate { get; set; }

        [DataMember]
        public short PregnantWeek { get; set; }

        [DataMember]
        public short? PregnancyTime { get; set; }

        [DataMember]
        public short? DeliveryTimes { get; set; }

        [DataMember]
        public System.DateTime? UterusShrink { get; set; }

        [DataMember]
        public System.DateTime? UterusOpen { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }
    }
}
