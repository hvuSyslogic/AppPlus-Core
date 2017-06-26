using System;
using System.Runtime.Serialization;
using AppPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class BsItemPersonDTO : DtoBase<int>
    {
        public BsItemPersonDTO()
        {
        }

        [DataMember]
        public int ItemId { get; set; }

        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public int? PatId { get; set; }

        [DataMember]
        public System.DateTime? FromTime { get; set; }

        [DataMember]
        public System.DateTime? ToTime { get; set; }

        [DataMember]
        public bool? IsExcept { get; set; }

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
