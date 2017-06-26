using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class InAdviceGroupDTO : DtoBase<int>
    {
        public InAdviceGroupDTO()
        {
        }

        [DataMember]
        public int HospId { get; set; }

        [DataMember]
        public int UsageId { get; set; }

        [DataMember]
        public short? GroupNum { get; set; }

        [DataMember]
        public short? LsMarkType { get; set; }

        [DataMember]
        public int? MaxFrequency { get; set; }

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
        public int? LocationId { get; set; }
    }
}
