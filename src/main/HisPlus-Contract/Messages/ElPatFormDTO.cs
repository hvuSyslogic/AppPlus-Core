using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class ElPatFormDTO : DtoBase<int>
    {
        public ElPatFormDTO()
        {
        }

        [DataMember]
        public int? PatId { get; set; }

        [DataMember]
        public int? HospitalId { get; set; }

        [DataMember]
        public int PatMenuId { get; set; }

        [DataMember]
        public int? RecId { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public bool? IsAuth { get; set; }

        [DataMember]
        public System.DateTime? AuthTime { get; set; }

        [DataMember]
        public string RejectReason { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string InActiveReason { get; set; }

        [DataMember]
        public System.DateTime? InActiveTime { get; set; }

        [DataMember]
        public int? InActiveOperId { get; set; }

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
