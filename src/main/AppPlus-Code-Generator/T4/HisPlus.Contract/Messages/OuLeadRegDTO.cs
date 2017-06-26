using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OuLeadRegDTO : DtoBase<int>
    {
        public OuLeadRegDTO()
        {
        }

        [DataMember]
        public int PatId { get; set; }

        [DataMember]
        public int? MzRegId { get; set; }

        [DataMember]
        public int RegTypeId { get; set; }

        [DataMember]
        public bool IsPriority { get; set; }

        [DataMember]
        public bool IsElder { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public int? DoctorId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

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
    }
}
