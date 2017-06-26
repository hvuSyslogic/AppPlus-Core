using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class FtMainDTO : DtoBase<int>
    {
        public FtMainDTO()
        {
        }

        [DataMember]
        public string CheckNo { get; set; }

        [DataMember]
        public int? UserId { get; set; }

        [DataMember]
        public int? HospId { get; set; }

        [DataMember]
        public int? LocationId { get; set; }

        [DataMember]
        public int OperId { get; set; }

        [DataMember]
        public System.DateTime OperTime { get; set; }

        [DataMember]
        public string Memo { get; set; }

        [DataMember]
        public bool? IsPrint { get; set; }

        [DataMember]
        public bool IsConfirm { get; set; }

        [DataMember]
        public System.DateTime? ConfirmOperTime { get; set; }

        [DataMember]
        public int? ConfirmOperId { get; set; }

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
