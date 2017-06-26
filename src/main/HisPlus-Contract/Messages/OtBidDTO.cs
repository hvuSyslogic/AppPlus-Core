using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class OtBidDTO : DtoBase<int>
    {
        public OtBidDTO()
        {
        }

        [DataMember]
        public string RecNo { get; set; }

        [DataMember]
        public System.DateTime? BitTime { get; set; }

        [DataMember]
        public System.DateTime? NotifyDate { get; set; }

        [DataMember]
        public string DispUnit { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public short? LsStatus { get; set; }

        [DataMember]
        public System.DateTime? SignTime { get; set; }

        [DataMember]
        public int? SignOperId { get; set; }

        [DataMember]
        public string F1 { get; set; }

        [DataMember]
        public string F2 { get; set; }

        [DataMember]
        public string F3 { get; set; }

        [DataMember]
        public string F4 { get; set; }

        [DataMember]
        public bool? IsSign { get; set; }
    }
}
