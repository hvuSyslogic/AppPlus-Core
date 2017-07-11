using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HuVoucherDTO : DtoBase<int>
    {
        public HuVoucherDTO()
        {
        }

        [DataMember]
        public string VoucherNo { get; set; }

        [DataMember]
        public int? HouseId { get; set; }

        [DataMember]
        public int? CompId { get; set; }

        [DataMember]
        public int? OperId { get; set; }

        [DataMember]
        public System.DateTime? OperTime { get; set; }

        [DataMember]
        public string Memo { get; set; }
    }
}
