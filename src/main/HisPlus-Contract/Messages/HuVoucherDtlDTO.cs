using System;
using System.Runtime.Serialization;
using HisPlus.Infrastructure.Contract.Messages;

namespace HisPlus.Contract.Messages
{
    [Serializable]
    [DataContract]
    public class HuVoucherDtlDTO : DtoBase<int>
    {
        public HuVoucherDtlDTO()
        {
        }

        [DataMember]
        public int? VoucherId { get; set; }

        [DataMember]
        public int BillId { get; set; }

        [DataMember]
        public decimal? Amount { get; set; }

        [DataMember]
        public decimal? HasPay { get; set; }
    }
}
